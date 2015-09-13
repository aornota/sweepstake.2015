namespace AOrNotA.Sweepstake2015

open System

open AOrNotA.Sweepstake2015.``Data 2015``
open AOrNotA.Sweepstake2015.Domain
open AOrNotA.Sweepstake2015.Sweepstake

module ``Sweepstake 2015`` =

    let neph = Participant "Neph"
    let jack = Participant "Jack"
    let rosie = Participant "Rosie"
    let hugh = Participant "Hugh"

    let participants = [ neph; jack; rosie; hugh ]

    (* TEMP [NMB]: test data... *)
    let nephPicks = { Participant = neph;
                      CoachTeam = Some wales
                      Picks = [ { Player = mayJonny (* Back *); OnlyScoresFrom = None }
                                { Player = nadoloNemani (* Back *); OnlyScoresFrom = None }
                                { Player = jonesAlunWyn (* Forward *); OnlyScoresFrom = None }
                                { Player = tipuricJustin (* Forward: Withdrawn 2015-09-12 *); OnlyScoresFrom = None }
                                { Player = biggarDan (* Back *); OnlyScoresFrom = None }
                                { Player = williamsScott (* Back *); OnlyScoresFrom = None }
                                { Player = josephJonathan (* Back *); OnlyScoresFrom = Some (DateTime (2015, 9, 12)) } ] }

    let jackPicks = { Participant = jack;
                      CoachTeam = Some england
                      Picks = [ { Player = morganBen (* Forward *); OnlyScoresFrom = None }
                                { Player = youngsBen (* Back *); OnlyScoresFrom = None }
                                { Player = fordGeorge (* Back *); OnlyScoresFrom = None }
                                { Player = gonevaVereniki (* Back *); OnlyScoresFrom = None }
                                { Player = cuthbertAlex (* Back *); OnlyScoresFrom = None }
                                { Player = leivasLeandro (* Back *); OnlyScoresFrom = None } ] }

    let rosiePicks = { Participant = rosie;
                       CoachTeam = Some newZealand
                       Picks = [ { Player = farrellOwen (* Back *); OnlyScoresFrom = None }
                                 { Player = watsonAnthony (* Back *); OnlyScoresFrom = None }
                                 { Player = nakarawaLeone (* Forward *); OnlyScoresFrom = None }
                                 { Player = taleiNetani (* Forward *); OnlyScoresFrom = None }
                                 { Player = jenkinsGethin (* Forward *); OnlyScoresFrom = None }
                                 { Player = warburtonSam (* Forward *); OnlyScoresFrom = None } ] }

    let sweepstakers = [ nephPicks; jackPicks; rosiePicks ]

    (* TEMP [NMB]... let sweepstakers: Sweepstaker list = [ (* TODO *) ] *)

    let pickedCoachTeams = sweepstakers |> List.choose (fun sweepstaker -> sweepstaker.CoachTeam)

    let pickedPlayers = sweepstakers |> List.collect (fun sweepstaker -> let participant = getParticipant sweepstaker
                                                                         sweepstaker.Picks |> List.map (fun pick -> pick, participant))

