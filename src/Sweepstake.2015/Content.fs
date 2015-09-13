namespace AOrNotA.Sweepstake2015

open System
open System.Text

open AOrNotA.Sweepstake2015.Domain
open AOrNotA.Sweepstake2015.Sweepstake

module Content =

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
    let getPlayerType player = match player.Type with | Forward -> "Forward" | Back -> "Back"
    let getPlayerStatus player = match player.Status with
                                 | Withdrawn date when date.IsSome -> Some (sprintf "Withdrawn (%s)" (date.Value.ToString ("dd-MMM-yyyy")))
                                 | Withdrawn _ -> Some "Withdrawn"
                                 | Replacement date when date.IsSome -> Some (sprintf "Replacement (%s)" (date.Value.ToString ("dd-MMM-yyyy")))
                                 | Replacement _ -> Some "Replacement"
                                 | _ -> None
    let getPlayerTypeAndStatus player =
        match getPlayerStatus player with | Some status -> sprintf "%s - %s" (getPlayerType player) status
                                          | None -> (getPlayerType player)

    let teamScores2011 = getTotalScorePerTeam ``Data 2011``.teams ``Data 2011``.matches
    let teamScores2015 = getTotalScorePerTeam ``Data 2015``.teams ``Data 2015``.matches
    let getTeamScore (teamScores: (Team * int<score>) list) (team: Team) =
        match teamScores |> List.filter (fun (team', _) -> team'.Name = team.Name) with
        | h :: _ -> sprintf "%d" (snd h)
        | _ -> ""
    let getTeamScore2011 team = getTeamScore teamScores2011 team
    let getTeamScore2015 team = getTeamScore teamScores2015 team
    let getTeamPickedBy team =
        match ``Sweepstake 2015``.sweepstakers |> List.filter (fun sweepstaker ->
                                                                   match sweepstaker.CoachTeam with
                                                                   | Some team' when team' = team -> true
                                                                   | _ -> false) with
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

