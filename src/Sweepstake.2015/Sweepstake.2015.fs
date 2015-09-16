namespace AOrNotA.Sweepstake2015

open System

open AOrNotA.Sweepstake2015.``Data 2015``
open AOrNotA.Sweepstake2015.Domain
open AOrNotA.Sweepstake2015.Sweepstake

module ``Sweepstake 2015`` =

    let chad = Participant "Chad"
    let chris = Participant "Chris"
    let denis = Participant "Denis"
    let hugh = Participant "Hugh"
    let jack = Participant "Jack"
    let jem = Participant "Jem"
    let martyn = Participant "Martyn"
    let neph = Participant "Neph"
    let rosie = Participant "Rosie"
    let susie = Participant "Susie"

    (* TEMP [NMB]: test data...
    let denisPicks = { Participant = denis
                       CoachTeam = Some england
                       Picks = [ { Player = morganBen (* Forward *); OnlyScoresFrom = None }
                                 { Player = youngsBen (* Back *); OnlyScoresFrom = None }
                                 { Player = fordGeorge (* Back *); OnlyScoresFrom = None }
                                 { Player = gonevaVereniki (* Back *); OnlyScoresFrom = None }
                                 { Player = cuthbertAlex (* Back *); OnlyScoresFrom = None }
                                 { Player = leivasLeandro (* Back *); OnlyScoresFrom = None } ] }

    let jackPicks = { Participant = jack
                      CoachTeam = Some australia
                      Picks = [  ] }

    let nephPicks = { Participant = neph
                      CoachTeam = Some wales
                      Picks = [ { Player = mayJonny (* Back *); OnlyScoresFrom = None }
                                { Player = nadoloNemani (* Back *); OnlyScoresFrom = None }
                                { Player = jonesAlunWyn (* Forward *); OnlyScoresFrom = None }
                                { Player = tipuricJustin (* Forward: Withdrawn 2015-09-12 *); OnlyScoresFrom = None }
                                { Player = biggarDan (* Back *); OnlyScoresFrom = None }
                                { Player = williamsScott (* Back *); OnlyScoresFrom = None }
                                { Player = josephJonathan (* Back *); OnlyScoresFrom = Some (DateTime (2015, 9, 12)) } ] }

    let susiePicks = { Participant = susie
                       CoachTeam = Some newZealand
                       Picks = [ { Player = farrellOwen (* Back *); OnlyScoresFrom = None }
                                 { Player = watsonAnthony (* Back *); OnlyScoresFrom = None }
                                 { Player = nakarawaLeone (* Forward *); OnlyScoresFrom = None }
                                 { Player = taleiNetani (* Forward *); OnlyScoresFrom = None }
                                 { Player = jenkinsGethin (* Forward *); OnlyScoresFrom = None }
                                 { Player = warburtonSam (* Forward *); OnlyScoresFrom = None } ] }

    let sweepstakers = [ denisPicks; jackPicks; nephPicks; susiePicks ] *)

    (* TEMP [NMB]... *)
    let chadPicks = { Participant = chad
                      CoachTeam = (* TODO *) None
                      Picks = [ (* TODO *) ] }

    let chrisPicks = { Participant = chris
                       CoachTeam = (* TODO *) None
                       Picks = [ (* TODO *) ] }

    let denisPicks = { Participant = denis
                       CoachTeam = (* TODO *) None
                       Picks = [ (* TODO *) ] }

    let hughPicks = { Participant = hugh
                      CoachTeam = (* TODO *) None
                      Picks = [ (* TODO *) ] }

    let jackPicks = { Participant = jack
                      CoachTeam = (* TODO *) None
                      Picks = [ (* TODO *) ] }

    let jemPicks = { Participant = jem
                     CoachTeam = (* TODO *) None
                     Picks = [ (* TODO *) ] }

    let martynPicks = { Participant = martyn
                        CoachTeam = (* TODO *) None
                        Picks = [ (* TODO *) ] }

    let nephPicks = { Participant = neph
                      CoachTeam = (* TODO *) None
                      Picks = [ (* TODO *) ] }

    let rosiePicks = { Participant = rosie
                       CoachTeam = (* TODO *) None
                       Picks = [ (* TODO *) ] }

    let susiePicks = { Participant = susie
                       CoachTeam = (* TODO *) None
                       Picks = [ (* TODO *) ] }

    let sweepstakers: Sweepstaker list = [ chadPicks; chrisPicks; denisPicks; hughPicks; jackPicks; jemPicks; martynPicks; nephPicks
                                           rosiePicks; susiePicks ]

    let pickedPlayers = sweepstakers |> List.collect (fun sweepstaker -> let participant = getParticipant sweepstaker
                                                                         sweepstaker.Picks |> List.map (fun pick -> pick, participant))

