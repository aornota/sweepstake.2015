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

    // Before first draft...
    let chadPicks0 = { Participant = chad; CoachTeam = None; Picks = [] }
    let chrisPicks0 = { Participant = chris; CoachTeam = None; Picks = [] }
    let denisPicks0 = { Participant = denis; CoachTeam = None; Picks = [] }
    let hughPicks0 = { Participant = hugh; CoachTeam = None; Picks = [] }
    let jackPicks0 = { Participant = jack; CoachTeam = None; Picks = [] }
    let jemPicks0 = { Participant = jem; CoachTeam = None; Picks = [] }
    let martynPicks0 = { Participant = martyn; CoachTeam = None; Picks = [] }
    let nephPicks0 = { Participant = neph; CoachTeam = None; Picks = [] }
    let rosiePicks0 = { Participant = rosie; CoachTeam = None; Picks = [] }
    let susiePicks0 = { Participant = susie; CoachTeam = None; Picks = [] }

    let sweepstakers0 = [ chadPicks0; chrisPicks0; denisPicks0; hughPicks0; jackPicks0; jemPicks0; martynPicks0; nephPicks0
                          rosiePicks0; susiePicks0 ]

    // Before second draft...
    let chadPicks1 = { Participant = chad
                       CoachTeam = None
                       Picks = [ { Player = hooperMichael (* Forward *); OnlyScoresFrom = None }
                                 { Player = smithAaron (* Back *); OnlyScoresFrom = None }
                                 { Player = deAllendeDamian (* Back *); OnlyScoresFrom = None }
                                 { Player = kirchnerZane (* Back *); OnlyScoresFrom = None }
                                 { Player = murrayConor (* Back *); OnlyScoresFrom = None }
                                 { Player = madiganIan (* Back *); OnlyScoresFrom = None }
                                 { Player = cuthbertAlex (* Back *); OnlyScoresFrom = None }
                                 { Player = matavesiJosh (* Back *); OnlyScoresFrom = None } ] }

    let chrisPicks1 = { Participant = chris
                        CoachTeam = Some australia
                        Picks = [ { Player = smithBen (* Back *); OnlyScoresFrom = None }
                                  { Player = naholoWaisake (* Back *); OnlyScoresFrom = None }
                                  { Player = hugetYoann (* Back *); OnlyScoresFrom = None }
                                  { Player = giteauMatt (* Back *); OnlyScoresFrom = None } ] }

    let denisPicks1 = { Participant = denis
                        CoachTeam = Some ireland
                        Picks = [ { Player = readKieran (* Forward *); OnlyScoresFrom = None }
                                  { Player = o'BrienSean (* Forward *); OnlyScoresFrom = None }
                                  { Player = healyCian (* Forward *); OnlyScoresFrom = None }
                                  { Player = hendersonIain (* Forward *); OnlyScoresFrom = None }
                                  { Player = franksOwen (* Forward *); OnlyScoresFrom = None }
                                  { Player = dentonDavid (* Forward *); OnlyScoresFrom = None }
                                  { Player = woodTom (* Forward *); OnlyScoresFrom = None }
                                  { Player = o'ConnellPaul (* Forward *); OnlyScoresFrom = None }
                                  { Player = northGeorge (* Back *); OnlyScoresFrom = None }
                                  { Player = brownMike (* Back *); OnlyScoresFrom = None }
                                  { Player = zeboSimon (* Back *); OnlyScoresFrom = None }
                                  { Player = fofanaWesley (* Back *); OnlyScoresFrom = None }
                                  { Player = williamsLiam (* Back *); OnlyScoresFrom = None }
                                  { Player = fitzgeraldLuke (* Back *); OnlyScoresFrom = None } ] }

    let hughPicks1 = { Participant = hugh
                       CoachTeam = None
                       Picks = [ { Player = milnerSkudderNehe (* Back *); OnlyScoresFrom = None }
                                 { Player = biggarDan (* Back *); OnlyScoresFrom = None }
                                 { Player = leRouxWillie (* Back *); OnlyScoresFrom = None }
                                 { Player = watsonAnthony (* Back *); OnlyScoresFrom = None }
                                 { Player = speightHenry (* Back *); OnlyScoresFrom = None }
                                 { Player = russellFinn (* Back *); OnlyScoresFrom = None }
                                 { Player = nakaitaciNoa (* Back *); OnlyScoresFrom = None } ] }

    let jackPicks1 = { Participant = jack
                       CoachTeam = Some england
                       Picks = [ { Player = pocockDavid (* Forward *); OnlyScoresFrom = None }
                                 { Player = vermeulenDuane (* Forward *); OnlyScoresFrom = None }
                                 { Player = pollardHandre (* Back *); OnlyScoresFrom = None }
                                 { Player = sanchezNicolas (* Back *); OnlyScoresFrom = None }
                                 { Player = mayJonny (* Back *); OnlyScoresFrom = None }
                                 { Player = toomuaMatt (* Back *); OnlyScoresFrom = None }
                                 { Player = williamsSonnyBill (* Back *); OnlyScoresFrom = None }
                                 { Player = youngsBen (* Back *); OnlyScoresFrom = None } ] }

    let jemPicks1 = { Participant = jem
                      CoachTeam = Some france
                      Picks = [ { Player = picamolesLouis (* Forward *); OnlyScoresFrom = None }
                                { Player = dusautoirThierry (* Forward *); OnlyScoresFrom = None }
                                { Player = vitoVictor (* Forward *); OnlyScoresFrom = None }
                                { Player = etzebethEben (* Forward *); OnlyScoresFrom = None }
                                { Player = parisseSergio (* Forward *); OnlyScoresFrom = None }
                                { Player = saveaJulian (* Back *); OnlyScoresFrom = None }
                                { Player = pietersenJP (* Back *); OnlyScoresFrom = None }
                                { Player = michalakFrederic (* Back *); OnlyScoresFrom = None }
                                { Player = barrettBeauden (* Back *); OnlyScoresFrom = None } ] }

    let martynPicks1 = { Participant = martyn
                         CoachTeam = None
                         Picks = [ { Player = kainoJerome (* Forward *); OnlyScoresFrom = None }
                                   { Player = lambiePat (* Back *); OnlyScoresFrom = None }
                                   { Player = farrellOwen (* Back *); OnlyScoresFrom = None }
                                   { Player = cooperQuade (* Back *); OnlyScoresFrom = None }
                                   { Player = mvovoLwazi (* Back *); OnlyScoresFrom = None }
                                   { Player = geniaWill (* Back *); OnlyScoresFrom = None }
                                   { Player = pienaarRuan (* Back *); OnlyScoresFrom = None } ] }

    let nephPicks1 = { Participant = neph
                       CoachTeam = Some argentina
                       Picks = [ { Player = louwFrancois (* Forward *); OnlyScoresFrom = None }
                                 { Player = carterDan (* Back *); OnlyScoresFrom = None }
                                 { Player = sextonJonathan (* Back *); OnlyScoresFrom = None }
                                 { Player = nonuMa'a (* Back *); OnlyScoresFrom = None }
                                 { Player = ashleyCooperAdam (* Back *); OnlyScoresFrom = None }
                                 { Player = smithConrad (* Back *); OnlyScoresFrom = None }
                                 { Player = nadoloNemani (* Back *); OnlyScoresFrom = None }
                                 { Player = williamsScott (* Back *); OnlyScoresFrom = None } ] }

    let rosiePicks1 = { Participant = rosie
                        CoachTeam = Some southAfrica
                        Picks = [ { Player = duPlessisBismarck (* Forward *); OnlyScoresFrom = None }
                                  { Player = ayerzaMarcos (* Forward *); OnlyScoresFrom = None }
                                  { Player = masNicolas (* Forward *); OnlyScoresFrom = None }
                                  { Player = habanaBryan (* Back *); OnlyScoresFrom = None }
                                  { Player = folauIsrael (* Back *); OnlyScoresFrom = None }
                                  { Player = tuilagiAlesana (* Back *); OnlyScoresFrom = None } ] }

    let susiePicks1 = { Participant = susie
                        CoachTeam = Some newZealand
                        Picks = [ { Player = coleDan (* Forward *); OnlyScoresFrom = None }
                                  { Player = jonesAlunWyn (* Forward *); OnlyScoresFrom = None }
                                  { Player = grayRichie (* Forward *); OnlyScoresFrom = None }
                                  { Player = mooreStephen (* Forward *); OnlyScoresFrom = None }
                                  { Player = heaslipJamie (* Forward *); OnlyScoresFrom = None }
                                  { Player = nyangaYannick (* Forward *); OnlyScoresFrom = None }
                                  { Player = retallickBrodie (* Forward *); OnlyScoresFrom = None }
                                  { Player = creevyAgustin (* Forward *); OnlyScoresFrom = None }
                                  { Player = fordGeorge (* Back *); OnlyScoresFrom = None }
                                  { Player = josephJonathan (* Back *); OnlyScoresFrom = None }
                                  { Player = hernandezJuanMartin (* Back *); OnlyScoresFrom = None }
                                  { Player = laidlawGreig (* Back *); OnlyScoresFrom = None }
                                  { Player = boweTommy (* Back *); OnlyScoresFrom = None } ] }

    let sweepstakers1 = [ chadPicks1; chrisPicks1; denisPicks1; hughPicks1; jackPicks1; jemPicks1; martynPicks1; nephPicks1
                          rosiePicks1; susiePicks1 ]

    let sweepstakers = sweepstakers1

    let pickedPlayers = sweepstakers |> List.collect (fun sweepstaker -> let participant = getParticipant sweepstaker
                                                                         sweepstaker.Picks |> List.map (fun pick -> pick, participant))

