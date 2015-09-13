namespace AOrNotA.Sweepstake2015

open System
open System.Text

open AOrNotA.Sweepstake2015.Domain
open AOrNotA.Sweepstake2015.Sweepstake

module HtmlContent =

    let concatenateWithNewLine (lines: string list) =
        let append (state: StringBuilder) (line: string) = state.Append (sprintf "%s\n" line)
        let builder = lines |> List.fold append (StringBuilder ())
        builder.ToString ()

    let h2 text = sprintf "<h2>%s</h2>" text
    let h3 text = sprintf "<h3>%s</h3>" text
    let para text = sprintf "<p>%s</p>" text
    let bold text = sprintf "<b>%s</b>" text
    let italic text = sprintf "<i>%s</i>" text
    let anchor name text = sprintf """<a name="%s">%s</a>""" name text
    let link content anchor text = match content, anchor with
                                   | Some content', Some anchor' -> sprintf """<a href="%s.html#%s">%s</a>""" content' anchor' text
                                   | Some content', None -> sprintf """<a href="%s.html">%s</a>""" content' text
                                   | None, Some anchor' -> sprintf """<a href="#%s">%s</a>""" anchor' text
                                   | None, None -> text
    let linkToContent content text = link (Some content) None text
    let linkToAnchor anchor text = link None (Some anchor) text
    let linkToContentAnchor content anchor text = link (Some content) (Some anchor) text
    let strike text = sprintf "<strike>%s</strike>" text
    let table width rows =
        let tag = match width with | Some width' -> sprintf """<table style="width:%d%%">""" width' | None -> "<table>"
        [ tag ] @ rows @ [ "</table>" ]
    let tr cells = [ "<tr>" ] @ cells @ [ "</tr>"]
    let td text = sprintf "\t\t<td>%s</td>" text

    let getLastUpdated () = para (italic (sprintf "Last updated: %s" (DateTime.Now.ToString ("dd-MMM-yyyy HH:mm:ss"))))

    let getStage stage = match stage with | Group (label, _) -> sprintf "Group %c" label
                                          | QuarterFinal ordinal -> sprintf "Quarter-final %d" ordinal
                                          | SemiFinal ordinal -> sprintf "Semi-final %d" ordinal
                                          | BronzeFinal -> "Bronze final"
                                          | Final -> "Final"

    let getGroupLabel group = match group with | Group (label, _) -> string label | _ -> ""
    let getGroupTeams group = match group with | Group (_, teams) -> teams | _ -> []

    let getTeamSeeding team = match team.Seeding with | Some seeding -> sprintf "%d" seeding | None -> "N/A"
    let getTeamNameWithSeeding (team: Team) = sprintf "%s (%s)" team.Name (getTeamSeeding team)
    let getTeamTextWithStrike (team: Team) text = match team.Status with | Active -> text | Eliminated -> strike text

    let getPlayerNameWithStrike (player: Player) =
        match player.Team.Status, player.Status with
        | Eliminated, _ -> strike player.Name
        | _, Withdrawn _ -> strike player.Name
        | _ -> player.Name
    let getPlayerTypeAndStatus player =
        let playerType = match player.Type with | Forward -> "Forward" | Back -> "Back"
        let playerStatus = match player.Status with
                           | Withdrawn date when date.IsSome -> Some (sprintf "Withdrawn (%s)" (date.Value.ToString ("dd-MMM-yyyy")))
                           | Withdrawn _ -> Some "Withdrawn"
                           | Replacement date when date.IsSome -> Some (sprintf "Replacement (%s)" (date.Value.ToString ("dd-MMM-yyyy")))
                           | Replacement _ -> Some "Replacement"
                           | _ -> None
        match playerStatus with | Some status -> sprintf "%s - %s" playerType status
                                | None -> playerType

    let teamScores2011 = getTotalScorePerTeam ``Data 2011``.teams ``Data 2011``.matches
    let teamScores2015 = getTotalScorePerTeam ``Data 2015``.teams ``Data 2015``.matches
    let getTeamScore (teamScores: (Team * int<score>) list) (team: Team) =
        match teamScores |> List.filter (fun (team', _) -> team'.Name = team.Name) with
        | h :: _ -> sprintf "%d" (snd h)
        | _ -> ""
    let getTeamScore2011 team = getTeamScore teamScores2011 team
    let getTeamScore2015 team = getTeamScore teamScores2015 team
    let getTeamPickedBy team =
        match ``Sweepstake 2015``.sweepstakers |> List.filter (fun sweepstaker -> sweepstaker.CoachTeam = team) with
        | h :: _ -> getParticipant h
        | _ -> ""

    let players2011 = ``Data 2011``.players |> List.map (fun player -> player, None)
    let playerScores2011 = getTotalScorePerPlayer players2011 ``Data 2011``.matches
    let players2015 = ``Data 2015``.players |> List.map (fun player -> player, None)
    let playerScores2015 = getTotalScorePerPlayer players2015 ``Data 2015``.matches
    let getPlayerScore playerScores player =
        match playerScores |> List.filter (fun (player', _) -> player'.Name = player.Name) with
        | h :: _ -> sprintf "%d" (snd h)
        | _ -> ""
    let getPlayerScore2011 player = getPlayerScore playerScores2011 player
    let getPlayerScore2015 player = getPlayerScore playerScores2015 player
    let getPlayerPickedBy player =
        match ``Sweepstake 2015``.pickedPlayers |> List.filter (fun (pick, _) -> pick.Player = player) with
        | h :: _ -> let pickedBy = snd h
                    match (fst h).OnlyScoresFrom with
                    | Some date -> sprintf "%s (from %s)" pickedBy (date.ToString ("dd-MMM-yyyy"))
                    | None -> pickedBy
        | _ -> ""

    (* let groups = [ ``Data 2011``.groupA; ``Data 2011``.groupB; ``Data 2011``.groupC; ``Data 2011``.groupD ]
    let players = ``Data 2011``.players
    let matches = ``Data 2011``.matches *)
    let groups = [ ``Data 2015``.groupA; ``Data 2015``.groupB; ``Data 2015``.groupC; ``Data 2015``.groupD ]
    let players = ``Data 2015``.players
    let matches = ``Data 2015``.matches

    // TODO [NMB]...
    let getIndexHtml () = [ getLastUpdated () ]
                          @ [ h2 "Coming soon..." ]
                          |> concatenateWithNewLine

    let linksHtml =
        let groupRow group =
            let groupCells =
                let teamCell (team: Team) = td (linkToAnchor team.Name (getTeamTextWithStrike team (getTeamNameWithSeeding team)))
                let teamCells = getGroupTeams group |> List.map teamCell
                let label = getGroupLabel group
                [ td (bold (sprintf "Group %s" label)) ]
                @ teamCells
                @ [ td (linkToAnchor (sprintf "Group-%s-fixtures" label) "fixtures") ]
            tr groupCells
        table (Some 100) (groups |> List.collect groupRow)
        @ [ para (linkToAnchor "Knockout-fixtures" "Knockout fixtures") ]

    let fixtureHtml ``match`` =
        let team1, team2 = getTeam ``match``.Team1Points, getTeam ``match``.Team2Points
        let team1Points, team2Points = getPoints ``match``.Team1Points, getPoints ``match``.Team2Points
        let result = if team1Points = 0<point> && team2Points = 0<point> then td (sprintf "%s vs %s" team1.Name team2.Name) // note: assume no genuine nil-nil results
                     else td (sprintf "%s %d - %s %d" team1.Name team1Points team2.Name team2Points)
        let kickOff = td (``match``.KickOff.ToString ("dd-MMM-yyyy HH:mm"))
        let stage = match ``match``.Stage with | Group _ -> []
                                               | _ -> [ td (getStage ``match``.Stage) ]
        tr (stage @ [ kickOff; result ])

    let groupsHtml =
        let teamHeaderRow = tr ( [ td (bold "Coach")
                                   td (bold "Seeding")
                                   td (bold (italic "2011 score"))
                                   td (bold "Picked by")
                                   td (bold "2015 score") ] )
        let playersHeaderRow = tr ( [ td (bold "Name")
                                      td (bold "Type")
                                      td (bold (italic "2011 score"))
                                      td (bold "Picked by")
                                      td (bold "2015 score") ] )
        let groupHtml group =
            let teamsHtml =
                let teamHtml (team: Team) =
                    let teamRow = tr ( [ td (getTeamTextWithStrike team team.Coach)
                                         td (getTeamSeeding team)
                                         td (italic (getTeamScore2011 team))
                                         td (getTeamPickedBy team)
                                         td (getTeamScore2015 team) ] )
                    let playerRow player = tr ( [ td (getPlayerNameWithStrike player)
                                                  td (getPlayerTypeAndStatus player)
                                                  td (italic (getPlayerScore2011 player))
                                                  td (getPlayerPickedBy player)
                                                  td (getPlayerScore2015 player) ] )
                    let players = players |> List.filter (fun player -> player.Team = team)
                    [ h3 (anchor team.Name (getTeamTextWithStrike team (getTeamNameWithSeeding team))) ]
                    @ table (Some 60) (teamHeaderRow @ teamRow)
                    @ table (Some 100) (playersHeaderRow @ (players |> List.collect playerRow))
                getGroupTeams group |> List.collect teamHtml
            let label = getGroupLabel group
            let fixturesHtml = matches |> List.filter (fun ``match`` -> getGroupLabel ``match``.Stage = label)
                                       |> List.sortBy (fun ``match`` -> ``match``.KickOff)
                                       |> List.collect fixtureHtml
            [ h2 (sprintf "Group %s" label) ]
            @ teamsHtml
            @ [ h3 (anchor (sprintf "Group-%s-fixtures" label) (sprintf "Group %s fixtures" label)) ]
            @ table (Some 80) fixturesHtml
        groups |> List.collect groupHtml

    let knockoutFixturesHtml =
        let fixturesHtml = matches |> List.filter (fun ``match`` -> getGroupLabel ``match``.Stage = "")
                                   |> List.sortBy (fun ``match`` -> ``match``.KickOff)
                                   |> List.collect fixtureHtml
        [ h2 (anchor "Knockout-fixtures" "Knockout fixtures") ]
        @ table (Some 100) fixturesHtml

    let getTeamsHtml () = [ getLastUpdated () ]
                          @ linksHtml @ groupsHtml @ knockoutFixturesHtml
                          |> concatenateWithNewLine

    // TODO [NMB]...
    let getScoringHtml () = [ getLastUpdated () ]
                            @ [ h2 "Coming soon..." ]
                            |> concatenateWithNewLine

    // TODO [NMB]...
    let getDraftHtml () = [ getLastUpdated () ]
                          @ [ h2 "Coming soon..." ]
                          |> concatenateWithNewLine

