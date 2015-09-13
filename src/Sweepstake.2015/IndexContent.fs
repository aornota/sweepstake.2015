namespace AOrNotA.Sweepstake2015

open System
open System.Text

open AOrNotA.Sweepstake2015.Content
open AOrNotA.Sweepstake2015.Domain
open AOrNotA.Sweepstake2015.Sweepstake
open AOrNotA.Sweepstake2015.``Sweepstake 2015``

module IndexContent =

    let sweepstakerLinksHtml =
        let sweepstakerCell sweepstaker = [ td (linkToAnchor (getParticipant sweepstaker) (getParticipant sweepstaker)) ]
        // TODO [NMB]: Adjust table width as required...
        table (Some 40) (tr ( [ td (linkToAnchor "Standings" (bold "Standings")) ] @
                              (sweepstakers |> List.collect sweepstakerCell) ))

    let linksHtml = table (Some 60) (tr ( [ td (bold "Top")
                                            td (linkToAnchor "Top-teams" "teams/coaches")
                                            td (linkToAnchor "Top-players" "players")
                                            td (linkToAnchor "Top-forwards" "forwards")
                                            td (linkToAnchor "Top-backs" "backs") ] ) @
                                     tr ( [ td (bold "Best unpicked") 
                                            td (linkToAnchor "Best-unpicked-teams" "teams/coaches")
                                            td (linkToAnchor "Best-unpicked-players" "players")
                                            td (linkToAnchor "Best-unpicked-forwards" "forwards")
                                            td (linkToAnchor "Best-unpicked-backs" "backs") ] ))

    let getIndexLinksHtml () = (* TEMP [NMB]: Remove sweepstakeLinksHtml | para until real data is available... *)
                               sweepstakerLinksHtml @ [ para "" ] @
                               linksHtml
                               |> concatenateWithNewLine

    let sweepstakerTeamScore sweepstaker =
        match sweepstaker.CoachTeam with | Some team' -> getTeamScore2015 team' | None -> 0<score>

    let sweepstakerPlayersScore sweepstaker =
        sweepstaker.Picks |> List.map (fun pick -> getPlayerScore2015 pick.Player)
                          |> List.sum

    let sweepstakerScore sweepstaker = sweepstakerTeamScore sweepstaker + sweepstakerPlayersScore sweepstaker

    let standingsHtml =
        let standingsHeaderRow = tr ( [ td (bold "Name")
                                        // TODO [NMB]: CoachTeam Status [and strikethrough?]? Players remaining?...
                                        td (bold "Score") ] )
        let sweepstakersHtml =
            let sweepstakerRow (sweepstaker, score) = tr ( [ td (getParticipant sweepstaker)
                                                             // TODO [NMB]: See above...
                                                             td (sprintf "%d" score) ] )
            let sweepstakerScores = sweepstakers |> List.map (fun sweepstaker -> sweepstaker, sweepstakerScore sweepstaker)
                                                 |> List.sortBy (fun (_, score) -> -score)
            table (Some 40) (standingsHeaderRow @ (sweepstakerScores |> List.collect sweepstakerRow))
        [ h2 (anchor "Standings" "Standings") ] @
        sweepstakersHtml

    // TODO [NMB]...
    let sweepstakerTeamsHtml = [ h3 (anchor "Neph" "Neph")
                                 h3 (anchor "Jack" "Jack")
                                 h3 (anchor "Rosie" "Rosie") ]

    let unpickedAnchorText unpicked = match unpicked with | true -> "Best-unpicked" | false -> "Top"
    let unpickedText unpicked = match unpicked with | true -> "Best unpicked" | false -> "Top"
    let playerTypeText playerType = match playerType with
                                    | Some playerType' -> match playerType' with | Forward -> "forwards" | Back -> "backs"
                                    | None -> "players"

    let topN n list = if list |> List.length > n then list |> Seq.ofList |> Seq.take n |> List.ofSeq
                      else list

    let teamScoresHtml unpicked =
        let teamsHeaderRow = tr ( [ td (bold "Team")
                                    td (bold "Seeding")
                                    td (bold "Coach") ] @
                                  (if unpicked then [] else [ td (bold "Picked by") ] ) @
                                  [ td (bold "Score") ] )
        let teamsHtml teamScores =
            let teamRow (team, score) = tr ( [ td (getTeamTextWithStrike team team.Name)
                                               td (getTeamSeeding team)
                                               td (getTeamTextWithStrike team team.Coach) ] @
                                             (if unpicked then [] else [ td (getTeamPickedBy team) ] ) @
                                             [ td (sprintf "%d" score) ] )
            table (Some (if unpicked then 70 else 80)) (teamsHeaderRow @ (teamScores |> List.collect teamRow))
        let picked team = getTeamPickedBy team <> ""
        let matching unpicked picked = if unpicked then not picked else true
        let topScoring = teamScores2015 |> List.filter (fun (team, _) -> matching unpicked (picked team))
                                        |> List.filter (fun (_, score) -> score > 0<score>)
                                        |> List.sortBy (fun (_, score) -> -score)
                                        |> topN 10
        let scoresHtml = if topScoring |> List.length = 0 then [ para (italic "Coming soon...") ]
                         else topScoring |> teamsHtml
        [ h3 (anchor (sprintf "%s-teams" (unpickedAnchorText unpicked)) (sprintf "%s teams/coaches" (unpickedText unpicked))) ] @
        scoresHtml

    let playerScoresHtml unpicked (playerType: PlayerType option) =
        let playersHeaderRow = tr ( [ td (bold "Name")
                                      td (bold "Team") ] @
                                    (if playerType.IsSome then [ td "" ] else [ td (bold "Type") ] ) @
                                    (if unpicked then [] else [ td (bold "Picked by") ] ) @
                                    [ td (bold "Score") ] )
        let playersHtml playerScores =
            let playerRow (player, score) = tr ( [ td (getPlayerNameWithStrike player)
                                                   td (getTeamTextWithStrike player.Team player.Team.Name) ] @
                                                 (if playerType.IsSome then
                                                      match getPlayerStatus player with | Some status -> [ td status ]
                                                                                        | None -> [ td "" ]
                                                  else [ td (getPlayerTypeAndStatus player) ] ) @
                                                 (if unpicked then [] else [ td (getPlayerPickedBy player) ] ) @
                                                 [ td (sprintf "%d" score) ] )
            table (Some (if unpicked then 80 else 100)) (playersHeaderRow @ (playerScores |> List.collect playerRow))
        let picked player = getPlayerPickedBy player <> ""
        let matching unpicked picked = if unpicked then not picked else true
        let matching' playerType player = match playerType with
                                          | Some playerType' -> playerType' = player.Type
                                          | None -> true
        let topScoring = playerScores2015 |> List.filter (fun (player, _) ->
                                                              matching unpicked (picked player) && matching' playerType player)
                                          |> List.filter (fun (_, score) -> score > 0<score>)
                                          |> List.sortBy (fun (_, score) -> -score)
                                          |> topN 20
        let scoresHtml = if topScoring |> List.length = 0 then [ para (italic "Coming soon...") ]
                         else topScoring |> playersHtml
        [ h3 (anchor (sprintf "%s-%s" (unpickedAnchorText unpicked) (playerTypeText playerType))
                     (sprintf "%s %s" (unpickedText unpicked) (playerTypeText playerType))) ] @
        scoresHtml

    let getIndexHtml () = (* TEMP [NMB]: Remove standingsHtml | sweepstakerTeamsHtml until real data is available... *)
                          standingsHtml @ sweepstakerTeamsHtml @
                          teamScoresHtml false @
                          playerScoresHtml false None @
                          playerScoresHtml false (Some Forward) @
                          playerScoresHtml false (Some Back) @
                          teamScoresHtml true @
                          playerScoresHtml true None @
                          playerScoresHtml true (Some Forward) @
                          playerScoresHtml true (Some Back)
                          |> concatenateWithNewLine

