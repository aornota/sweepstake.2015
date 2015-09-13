namespace AOrNotA.Sweepstake2015

open System
open System.Text

open AOrNotA.Sweepstake2015.Content
open AOrNotA.Sweepstake2015.Domain

module TeamsContent =

    let linksHtml =
        let groupRow group =
            let groupCells =
                let teamCell (team: Team) = td (linkToAnchor team.Name (getTeamTextWithStrike team (getTeamNameWithSeeding team)))
                let teamCells = getGroupTeams group |> List.map teamCell
                let label = getGroupLabel group
                [ td (bold (sprintf "Group %s" label)) ] @
                teamCells @
                [ td (linkToAnchor (sprintf "Group-%s-fixtures" label) "fixtures") ]
            tr groupCells
        table (Some 100) (groups |> List.collect groupRow) @
        [ para (linkToAnchor "Knockout-fixtures" "Knockout fixtures") ]

    let getTeamsLinksHtml () = linksHtml
                               |> concatenateWithNewLine

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
                                         td (italic (getTeamScoreText2011 team))
                                         td (getTeamPickedBy team)
                                         td (getTeamScoreText2015 team) ] )
                    let playerRow player = tr ( [ td (getPlayerNameWithStrike player)
                                                  td (getPlayerTypeAndStatus player)
                                                  td (italic (getPlayerScoreText2011 player))
                                                  td (getPlayerPickedBy player)
                                                  td (getPlayerScoreText2015 player) ] )
                    let players = players |> List.filter (fun player -> player.Team = team)
                    [ h3 (anchor team.Name (getTeamTextWithStrike team (getTeamNameWithSeeding team))) ] @
                    table (Some 80) (teamHeaderRow @ teamRow) @
                    table (Some 100) (playersHeaderRow @ (players |> List.collect playerRow))
                getGroupTeams group |> List.collect teamHtml
            let label = getGroupLabel group
            let fixturesHtml = matches |> List.filter (fun ``match`` -> getGroupLabel ``match``.Stage = label)
                                       |> List.sortBy (fun ``match`` -> ``match``.KickOff)
                                       |> List.collect fixtureHtml
            [ h2 (sprintf "Group %s" label) ] @
            teamsHtml @
            [ h3 (anchor (sprintf "Group-%s-fixtures" label) (sprintf "Group %s fixtures" label)) ] @
            table (Some 80) fixturesHtml
        groups |> List.collect groupHtml

    let knockoutFixturesHtml =
        let fixturesHtml = matches |> List.filter (fun ``match`` -> getGroupLabel ``match``.Stage = "")
                                   |> List.sortBy (fun ``match`` -> ``match``.KickOff)
                                   |> List.collect fixtureHtml
        [ h3 (anchor "Knockout-fixtures" "Knockout fixtures") ] @
        table (Some 100) fixturesHtml

    let getTeamsHtml () = groupsHtml @ knockoutFixturesHtml
                          |> concatenateWithNewLine

