namespace AOrNotA.Sweepstake2015

open System

open AOrNotA.Sweepstake2015.Domain
open AOrNotA.Sweepstake2015.``Data 2015``
open AOrNotA.Sweepstake2015.Sweepstake

module ``Sweepstake 2015`` =

    let neph = Participant "Neph"
    let rosie = Participant "Rosie"
    let hugh = Participant "Hugh"
    let jack = Participant "Jack"
    let tom = Participant "Tom"
    let barbara = Participant "Barbara"
    let denis = Participant "Denis"

    let participants = [ neph; rosie; hugh; jack; tom; barbara; denis ]

    // Note: Test data only...
    let nephPicks = { Participant = neph;
                      CoachTeam = newZealand
                      Picks = [ { Player = kainoJerome; OnlyScoresFrom = None }
                                { Player = carterDan; OnlyScoresFrom = None }
                                { Player = duPreezFourie; OnlyScoresFrom = None }
                                { Player = folauIsrael; OnlyScoresFrom = Some (DateTime (2015, 10, 1)) }
                                { Player = jonesAlunWyn; OnlyScoresFrom = None }
                                { Player = morathKurt; OnlyScoresFrom = None } ] }

    //let sweepstakers = [ nephPicks ]
    let sweepstakers: Sweepstaker list = []

    let pickedPlayers = sweepstakers |> List.collect (fun sweepstaker -> let participant = getParticipant sweepstaker
                                                                         sweepstaker.Picks |> List.map (fun pick -> pick, participant))

