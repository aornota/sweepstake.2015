namespace AOrNotA.Sweepstake2015

open System

open AOrNotA.Sweepstake2015.Domain
open AOrNotA.Sweepstake2015.``Data 2011``
open AOrNotA.Sweepstake2015.``Data 2015``
open AOrNotA.Sweepstake2015.Sweepstake

module Console =

    [<EntryPoint>]
    let main argv = 
        
        Console.WriteLine "Work in progress..."

        (* let players' = players |> List.map (fun player -> player, None)
        let playerScores = getTotalScorePerPlayer players' matches
        let top15Forwards = playerScores |> List.filter (fun (player, _) -> match player.Type with | Back -> false | Forward -> true)
                                         |> List.take 15
        let top15Backs = playerScores |> List.filter (fun (player, _) -> match player.Type with | Back -> true | Forward -> false)
                                      |> List.take 15
        Console.WriteLine "\nTop 15 Forwards:"
        top15Forwards
        |> List.iter (fun (player, score) -> Console.WriteLine (sprintf "\t%s [%s]: %d" player.Name player.Team.Name score))
        Console.WriteLine "\nTop 15 Backs:"
        top15Backs
        |> List.iter (fun (player, score) -> Console.WriteLine (sprintf "\t%s [%s]: %d" player.Name player.Team.Name score)) *)

        (* let teamScores = getTotalScorePerTeam teams matches
        Console.WriteLine "\nTeams:"
        teamScores
        |> List.iter (fun (team, score) -> Console.WriteLine (sprintf "\t%s [%s]: %d" team.Name team.Coach score)) *)

        // TODO [NMB]: More statistics...

        Console.Write "\nPress any key to exit..."
        Console.ReadKey () |> ignore
        0
