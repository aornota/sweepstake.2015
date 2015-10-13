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

    // Final teams...
    let chadPicks2 = { Participant = chad
                       CoachTeam = Some fiji
                       Picks = [ { Player = hooperMichael (* Forward *); OnlyScoresFrom = None }
                                 { Player = haskellJames (* Forward *); OnlyScoresFrom = None }
                                 { Player = caneSam (* Forward *); OnlyScoresFrom = None }
                                 { Player = mcMahonSean (* Forward *); OnlyScoresFrom = None }
                                 { Player = qeraAkapusi (* Forward *); OnlyScoresFrom = None }
                                 { Player = nakarawaLeone (* Forward *); OnlyScoresFrom = None }
                                 { Player = henryChris (* Forward *); OnlyScoresFrom = None }
                                 { Player = franksBen (* Forward *); OnlyScoresFrom = None }
                                 { Player = smithAaron (* Back *); OnlyScoresFrom = None }
                                 { Player = deAllendeDamian (* Back *); OnlyScoresFrom = None }
                                 { Player = kirchnerZane (* Back *); OnlyScoresFrom = None }
                                 { Player = murrayConor (* Back *); OnlyScoresFrom = None }
                                 { Player = madiganIan (* Back *); OnlyScoresFrom = None }
                                 { Player = cuthbertAlex (* Back *); OnlyScoresFrom = None }
                                 { Player = matavesiJosh (* Back *); OnlyScoresFrom = None } ] }

    let chrisPicks2 = { Participant = chris
                        CoachTeam = Some australia
                        Picks = [ { Player = mcCawRichie (* Forward *); OnlyScoresFrom = None }
                                  { Player = colesDane (* Forward *); OnlyScoresFrom = None }
                                  { Player = whitelockSam (* Forward *); OnlyScoresFrom = None }
                                  { Player = sioScott (* Forward *); OnlyScoresFrom = None }
                                  { Player = straussJosh (* Forward *); OnlyScoresFrom = None }
                                  { Player = tonerDevin (* Forward *); OnlyScoresFrom = None }
                                  { Player = faosilivaAlafoti (* Forward *); OnlyScoresFrom = None }
                                  { Player = vunisaSamuela (* Forward *); OnlyScoresFrom = None }
                                  { Player = smithBen (* Back *); OnlyScoresFrom = None }
                                  { Player = naholoWaisake (* Back *); OnlyScoresFrom = None }
                                  { Player = hugetYoann (* Back *); OnlyScoresFrom = None }
                                  { Player = giteauMatt (* Back *); OnlyScoresFrom = None }
                                  { Player = imhoffJuan (* Back *); OnlyScoresFrom = None }
                                  { Player = fekitoaMalakai (* Back *); OnlyScoresFrom = None }
                                  { Player = perenaraTJ (* Back *); OnlyScoresFrom = None }
                                  { Player = guitouneSofiane (* Back *); OnlyScoresFrom = Some (DateTime (2015, 9, 29)) } ] }

    let denisPicks2 = { Participant = denis
                        CoachTeam = Some ireland
                        Picks = [ { Player = readKieran (* Forward *); OnlyScoresFrom = None }
                                  { Player = o'BrienSean (* Forward *); OnlyScoresFrom = None }
                                  { Player = healyCian (* Forward *); OnlyScoresFrom = None }
                                  { Player = hendersonIain (* Forward *); OnlyScoresFrom = None }
                                  { Player = franksOwen (* Forward *); OnlyScoresFrom = None }
                                  { Player = dentonDavid (* Forward *); OnlyScoresFrom = None }
                                  { Player = woodTom (* Forward *); OnlyScoresFrom = None }
                                  { Player = o'ConnellPaul (* Forward *); OnlyScoresFrom = None }
                                  { Player = deJagerLood (* Forward *); OnlyScoresFrom = Some (DateTime (2015, 10, 13)) }
                                  { Player = northGeorge (* Back *); OnlyScoresFrom = None }
                                  { Player = brownMike (* Back *); OnlyScoresFrom = None }
                                  { Player = zeboSimon (* Back *); OnlyScoresFrom = None }
                                  { Player = fofanaWesley (* Back *); OnlyScoresFrom = None }
                                  { Player = williamsLiam (* Back *); OnlyScoresFrom = None }
                                  { Player = fitzgeraldLuke (* Back *); OnlyScoresFrom = None }
                                  { Player = priestlandRhys (* Back *); OnlyScoresFrom = None }
                                  { Player = kearneyRob (* Back *); OnlyScoresFrom = Some (DateTime (2015, 10, 12)) } ] }

    let hughPicks2 = { Participant = hugh
                       CoachTeam = Some scotland
                       Picks = [ { Player = robshawChris (* Forward *); OnlyScoresFrom = None }
                                 { Player = vunipolaBilly (* Forward *); OnlyScoresFrom = None }
                                 { Player = lawesCourtney (* Forward *); OnlyScoresFrom = None }
                                 { Player = warburtonSam (* Forward *); OnlyScoresFrom = None }
                                 { Player = senatoreLeonardo (* Forward *); OnlyScoresFrom = None }
                                 { Player = taleiNetani (* Forward *); OnlyScoresFrom = None }
                                 { Player = manoaSamu (* Forward *); OnlyScoresFrom = None }
                                 { Player = kolisiSiya (* Forward *); OnlyScoresFrom = None }
                                 { Player = materaPablo (* Forward *); OnlyScoresFrom = Some (DateTime (2015, 9, 29)) }
                                 { Player = milnerSkudderNehe (* Back *); OnlyScoresFrom = None }
                                 { Player = biggarDan (* Back *); OnlyScoresFrom = None }
                                 { Player = leRouxWillie (* Back *); OnlyScoresFrom = None }
                                 { Player = watsonAnthony (* Back *); OnlyScoresFrom = None }
                                 { Player = speightHenry (* Back *); OnlyScoresFrom = None }
                                 { Player = russellFinn (* Back *); OnlyScoresFrom = None }
                                 { Player = nakaitaciNoa (* Back *); OnlyScoresFrom = None } ] }

    let jackPicks2 = { Participant = jack
                       CoachTeam = Some england
                       Picks = [ { Player = pocockDavid (* Forward *); OnlyScoresFrom = None }
                                 { Player = vermeulenDuane (* Forward *); OnlyScoresFrom = None }
                                 { Player = burgerSchalk (* Forward *); OnlyScoresFrom = None }
                                 { Player = faletauTaulupe (* Forward *); OnlyScoresFrom = None }
                                 { Player = o'MahonyPeter (* Forward *); OnlyScoresFrom = None }
                                 { Player = bestRory (* Forward *); OnlyScoresFrom = None }
                                 { Player = gorgodzeMamuka (* Forward *); OnlyScoresFrom = None }
                                 { Player = tipuricJustin (* Forward *); OnlyScoresFrom = None }
                                 // TODO [NMB]: Confirm replacement for Peter O'Mahony...
                                 { Player = pollardHandre (* Back *); OnlyScoresFrom = None }
                                 { Player = sanchezNicolas (* Back *); OnlyScoresFrom = None }
                                 { Player = mayJonny (* Back *); OnlyScoresFrom = None }
                                 { Player = toomuaMatt (* Back *); OnlyScoresFrom = None }
                                 { Player = williamsSonnyBill (* Back *); OnlyScoresFrom = None }
                                 { Player = youngsBen (* Back *); OnlyScoresFrom = None }
                                 { Player = hoggStuart (* Back *); OnlyScoresFrom = None } ] }

    let jemPicks2 = { Participant = jem
                      CoachTeam = Some france
                      Picks = [ { Player = picamolesLouis (* Forward *); OnlyScoresFrom = None }
                                { Player = dusautoirThierry (* Forward *); OnlyScoresFrom = None }
                                { Player = vitoVictor (* Forward *); OnlyScoresFrom = None }
                                { Player = etzebethEben (* Forward *); OnlyScoresFrom = None }
                                { Player = parisseSergio (* Forward *); OnlyScoresFrom = None }
                                { Player = albertsWillem (* Forward *); OnlyScoresFrom = None }
                                { Player = choulyDamien (* Forward *); OnlyScoresFrom = None }
                                { Player = skeltonWill (* Forward *); OnlyScoresFrom = None }
                                { Player = taylorCodie (* Forward *); OnlyScoresFrom = Some (DateTime (2015, 9, 30)) }
                                { Player = saveaJulian (* Back *); OnlyScoresFrom = None }
                                { Player = pietersenJP (* Back *); OnlyScoresFrom = None }
                                { Player = michalakFrederic (* Back *); OnlyScoresFrom = None }
                                { Player = barrettBeauden (* Back *); OnlyScoresFrom = None }
                                { Player = kuridraniTevita (* Back *); OnlyScoresFrom = None }
                                { Player = pisiGeorge (* Back *); OnlyScoresFrom = None }
                                { Player = sladeColin (* Back *); OnlyScoresFrom = None } ] }

    let martynPicks2 = { Participant = martyn
                         CoachTeam = Some wales
                         Picks = [ { Player = kainoJerome (* Forward *); OnlyScoresFrom = None }
                                   { Player = messamLiam (* Forward *); OnlyScoresFrom = None }
                                   { Player = paluWycliff (* Forward *); OnlyScoresFrom = None }
                                   { Player = fardyScott (* Forward *); OnlyScoresFrom = None }
                                   { Player = leRouxBernard (* Forward *); OnlyScoresFrom = None }
                                   { Player = romanoLuke (* Forward *); OnlyScoresFrom = None }
                                   { Player = woodcockTony (* Forward *); OnlyScoresFrom = None }
                                   { Player = crockettWyatt (* Forward *); OnlyScoresFrom = None }
                                   { Player = mealamuKeven (* Forward *); OnlyScoresFrom = Some (DateTime (2015, 9, 29)) }
                                   { Player = mummDean (* Forward *); OnlyScoresFrom = Some (DateTime (2015, 10, 11)) }
                                   { Player = lambiePat (* Back *); OnlyScoresFrom = None }
                                   { Player = farrellOwen (* Back *); OnlyScoresFrom = None }
                                   { Player = cooperQuade (* Back *); OnlyScoresFrom = None }
                                   { Player = mvovoLwazi (* Back *); OnlyScoresFrom = None }
                                   { Player = geniaWill (* Back *); OnlyScoresFrom = None }
                                   { Player = pienaarRuan (* Back *); OnlyScoresFrom = None }
                                   { Player = krielJesse (* Back *); OnlyScoresFrom = None } ] }

    let nephPicks2 = { Participant = neph
                       CoachTeam = Some argentina
                       Picks = [ { Player = louwFrancois (* Forward *); OnlyScoresFrom = None }
                                 { Player = mcCalmanBen (* Forward *); OnlyScoresFrom = None }
                                 { Player = morganBen (* Forward *); OnlyScoresFrom = None }
                                 { Player = lobbeJuanMartinFernandez (* Forward *); OnlyScoresFrom = None }
                                 { Player = guiradoGuilhem (* Forward *); OnlyScoresFrom = None }
                                 { Player = leguizamonJuanManuel (* Forward *); OnlyScoresFrom = None }
                                 { Player = leitchMichael (* Forward *); OnlyScoresFrom = None }
                                 { Player = swinsonTim (* Forward *); OnlyScoresFrom = None }
                                 { Player = carterDan (* Back *); OnlyScoresFrom = None }
                                 { Player = sextonJonathan (* Back *); OnlyScoresFrom = None }
                                 { Player = nonuMa'a (* Back *); OnlyScoresFrom = None }
                                 { Player = ashleyCooperAdam (* Back *); OnlyScoresFrom = None }
                                 { Player = smithConrad (* Back *); OnlyScoresFrom = None }
                                 { Player = nadoloNemani (* Back *); OnlyScoresFrom = None }
                                 { Player = williamsScott (* Back *); OnlyScoresFrom = None }
                                 { Player = corderoSantiago (* Back *); OnlyScoresFrom = Some (DateTime (2015, 9, 29)) } ] }

    let rosiePicks2 = { Participant = rosie
                        CoachTeam = Some southAfrica
                        Picks = [ { Player = duPlessisBismarck (* Forward *); OnlyScoresFrom = None }
                                  { Player = ayerzaMarcos (* Forward *); OnlyScoresFrom = None }
                                  { Player = masNicolas (* Forward *); OnlyScoresFrom = None }
                                  { Player = whiteNathan (* Forward *); OnlyScoresFrom = None }
                                  { Player = straussAdriaan (* Forward *); OnlyScoresFrom = None }
                                  { Player = fordRoss (* Forward *); OnlyScoresFrom = None }
                                  { Player = flanquartAlexandre (* Forward *); OnlyScoresFrom = None }
                                  { Player = vunipolaMako (* Forward *); OnlyScoresFrom = None }
                                  { Player = habanaBryan (* Back *); OnlyScoresFrom = None }
                                  { Player = folauIsrael (* Back *); OnlyScoresFrom = None }
                                  { Player = tuilagiAlesana (* Back *); OnlyScoresFrom = None }
                                  { Player = parraMorgan (* Back *); OnlyScoresFrom = None }
                                  { Player = steynMorne (* Back *); OnlyScoresFrom = None }
                                  { Player = foleyBernard (* Back *); OnlyScoresFrom = None }
                                  { Player = sladeHenry (* Back *); OnlyScoresFrom = None } ] }

    let susiePicks2 = { Participant = susie
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
                                  { Player = boweTommy (* Back *); OnlyScoresFrom = None }
                                  { Player = fotuali'iKahn (* Back *); OnlyScoresFrom = None }
                                  { Player = speddingScott (* Back *); OnlyScoresFrom = None } ] }

    let sweepstakers2 = [ chadPicks2; chrisPicks2; denisPicks2; hughPicks2; jackPicks2; jemPicks2; martynPicks2; nephPicks2
                          rosiePicks2; susiePicks2 ]

    let sweepstakers = sweepstakers2

    let pickedPlayers = sweepstakers |> List.collect (fun sweepstaker -> let participant = getParticipant sweepstaker
                                                                         sweepstaker.Picks |> List.map (fun pick -> pick, participant))

