namespace AOrNotA.Sweepstake2015

open System

module Domain =

    [<Measure>]
    type min
    [<Measure>]
    type point

    type TeamStatus = | Active | Eliminated

    type Team = { Name: string; Status: TeamStatus; Seeding: int option; Coach: string }

    type Stage = | Group of label: char * teams: Team list
                 | QuarterFinal of ordinal: int
                 | SemiFinal of ordinal: int
                 | BronzeFinal | Final

    type PlayerType = | Forward | Back

    type PlayerStatus = | OriginalSquad
                        | Withdrawn of DateTime option | Replacement of DateTime option

    type Player = { Name: string; Team: Team; Type: PlayerType; Status: PlayerStatus }

    type Squad = { Team: Team; Players: Player list }

    type MatchEvent = | Try of player: Player * at: int<min> option
                      | PenaltyTry of team: Team * at: int<min> option
                      | Conversion of player: Player
                      | Penalty of player: Player
                      | DropGoal of player: Player
                      | MissedConversion of player: Player
                      | MissedPenalty of player: Player
                      | YellowCard of player: Player * at: int<min> option
                      | RedCard of player: Player * at: int<min> option
                      | ManOfTheMatch of player: Player

    type TeamPoints = | TeamPoints of team: Team * points: int<point>

    type Match = { Team1Points: TeamPoints; Team2Points: TeamPoints; Stage: Stage; KickOff: DateTime; Events: MatchEvent list }

    let getTeam teamPoints = match teamPoints with | TeamPoints (team, _) -> team
    let getPoints teamPoints = match teamPoints with | TeamPoints (_, points) -> points

    let getTryCount team matchEvents = 
        matchEvents
        |> List.filter (fun matchEvent -> match matchEvent with
                                          | Try (player, _) when player.Team = team -> true
                                          | PenaltyTry (team', _) when team' = team -> true
                                          | _ -> false)
        |> List.length

    let getConversionAttemptCount team matchEvents =
        matchEvents
        |> List.filter (fun matchEvent -> match matchEvent with
                                          | Conversion player when player.Team = team -> true
                                          | MissedConversion player when player.Team = team -> true
                                          | _ -> false)
        |> List.length

    let getTeamForMatchEvent matchEvent = match matchEvent with
                                          | Try (player, _) -> player.Team
                                          | PenaltyTry (team, _) -> team
                                          | Conversion player | Penalty player | DropGoal player -> player.Team
                                          | MissedConversion player | MissedPenalty player -> player.Team
                                          | YellowCard (player, _) | RedCard (player, _) | ManOfTheMatch player -> player.Team

    let getTeamScoresFromMatchEvents ``match`` =
        let getPoints team matchEvents =
            matchEvents
            |> List.map (fun matchEvent -> match matchEvent with
                                           | Try (player, _) when player.Team = team -> 5<point>
                                           | PenaltyTry (team', _) when team' = team -> 5<point>
                                           | Conversion player when player.Team = team -> 2<point>
                                           | Penalty player when player.Team = team -> 3<point>
                                           | DropGoal player when player.Team = team -> 3<point>
                                           | _ -> 0<point>)
            |> List.sum
        let team1, team2 = getTeam ``match``.Team1Points, getTeam ``match``.Team2Points
        let team1Points = TeamPoints (team1, getPoints team1 ``match``.Events)
        let team2Points = TeamPoints (team2, getPoints team2 ``match``.Events)
        team1Points, team2Points

    let getTeamBonusCounts ``match`` =
        let getBonusCount triesBonus lossBonus = match triesBonus, lossBonus with | true, true -> 2
                                                                                  | true, false | false, true -> 1
                                                                                  | false, false -> 0
        let team1, team2 = getTeam ``match``.Team1Points, getTeam ``match``.Team2Points
        let team1TriesBonus = getTryCount team1 ``match``.Events >= 4
        let team2TriesBonus = getTryCount team2 ``match``.Events >= 4
        let team1Score, team2Score = getPoints ``match``.Team1Points, getPoints ``match``.Team2Points
        let team1LossBonus = team1Score < team2Score && team2Score - team1Score <= 7<point>
        let team2LossBonus = team2Score < team1Score && team1Score - team2Score <= 7<point>
        System.Diagnostics.Debug.WriteLine (sprintf "%s %A %A %s %A %A" team1.Name team1TriesBonus team1LossBonus team2.Name team2TriesBonus team2LossBonus) 
        (team1, getBonusCount team1TriesBonus team1LossBonus), (team2, getBonusCount team2TriesBonus team2LossBonus)

