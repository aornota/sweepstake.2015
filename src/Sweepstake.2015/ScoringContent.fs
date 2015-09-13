namespace AOrNotA.Sweepstake2015

open System
open System.Text

open AOrNotA.Sweepstake2015.Content
open AOrNotA.Sweepstake2015.Domain
open AOrNotA.Sweepstake2015.Sweepstake

module ScoringContent =

    let linksHtml = table (Some 40) (tr ( [ td (linkToAnchor "2011-team-scores" "2011 team scores")
                                            td (linkToAnchor "2011-player-scores" "2011 player scores") ] ))

    let getScoringLinksHtml () = linksHtml
                                 |> concatenateWithNewLine

    let getTeamScores2011Html =
        let teamHeaderRow = tr ( [ td (bold "Team")
                                   td (bold "Seeding")
                                   td (bold "Coach")
                                   td (bold "2011 score") ] )
        let teamsHtml =
            let teamRow (team: Team) = tr ( [ td team.Name
                                              td (getTeamSeeding team)
                                              td team.Coach
                                              td (getTeamScore2011 team) ] )
            table (Some 80) (teamHeaderRow @
                             (teamScores2011 |> List.collect (fun (team, _) -> teamRow team)))
        [ h3 (anchor "2011-team-scores" "2011 team scores") ] @
        teamsHtml

    let getPlayerScores2011Html =
        let playerHeaderRow = tr ( [ td (bold "Name")
                                     td (bold "Team")
                                     td (bold "Type")
                                     td (bold "2011 score") ] )
        let playersHtml =
            let playerRow (player: Player) = tr ( [ td player.Name
                                                    td player.Team.Name
                                                    td (getPlayerTypeAndStatus player)
                                                    td (getPlayerScore2011 player) ] )
            table (Some 100) (playerHeaderRow @
                             (playerScores2011 |> List.filter (fun (_, score) -> score <> 0<score>)
                                               |> List.collect (fun (player, _) -> playerRow player)))
        let nonScoringHtml =
            let nonScoring = playerScores2011 |> List.filter (fun (_, score) -> score = 0<score>)
                                              |> List.length
            [ para (sprintf "%d players scored 0 points" nonScoring) ]
        [ h3 (anchor "2011-player-scores" "2011 player scores (non-zero only)") ] @
        playersHtml @
        nonScoringHtml


    let getScoringHtml () = getTeamScores2011Html @ getPlayerScores2011Html
                            |> concatenateWithNewLine

