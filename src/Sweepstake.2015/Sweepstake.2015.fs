namespace AOrNotA.Sweepstake2015

open AOrNotA.Sweepstake2015.Domain
open AOrNotA.Sweepstake2015.``Data 2015``
open AOrNotA.Sweepstake2015.Sweepstake

module ``Sweepstake 2015`` =

    let neph = Participant "Nathan-Madonna"
    let rosie = Participant "Rosie"
    let hugh = Participant "Hugh"
    let jack = Participant "Jack"
    let tom = Participant "Tom"
    let mike = Participant "Mike"
    let barbara = Participant "Barbara"
    let denis = Participant "Denis"

    let participants = [ neph; rosie; hugh; jack; tom; mike; barbara; denis ]

    let nephPicks = { Participant = neph;
                      CoachTeam = newZealand
                      Picks = [ { Player = kainoJerome; OnlyScoresFrom = None }
                                { Player = carterDan; OnlyScoresFrom = None }
                                { Player = duPreezFourie; OnlyScoresFrom = None }
                                { Player = folauIsrael; OnlyScoresFrom = None }
                                { Player = jonesAlunWyn; OnlyScoresFrom = None }
                                { Player = morathKurt; OnlyScoresFrom = None } ] }

    let sweepstakers = [ nephPicks ]

