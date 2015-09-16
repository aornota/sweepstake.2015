namespace AOrNotA.Sweepstake2015

open System
open System.Text

open AOrNotA.Sweepstake2015.Content
open AOrNotA.Sweepstake2015.``Data 2015``
open AOrNotA.Sweepstake2015.Domain
open AOrNotA.Sweepstake2015.Sweepstake
open AOrNotA.Sweepstake2015.``Sweepstake 2015``

module DraftContent =

    type DraftPick = | CoachTeam of team: Team
                     | Player of player: Player

    type SweepstakerDraft = { Participant: Participant; Ordinal: int; DraftPicks: DraftPick list }

    let chad1 = { Participant = chad ; Ordinal = 1
                  DraftPicks = [ Player smithAaron
                                 Player saveaJulian
                                 Player milnerSkudderNehe
                                 Player carterDan
                                 Player deAllendeDamian
                                 Player habanaBryan
                                 Player kirchnerZane
                                 Player josephJonathan
                                 Player watsonAnthony
                                 Player fordGeorge
                                 Player folauIsrael
                                 Player hooperMichael
                                 Player giteauMatt
                                 Player sextonJonathan
                                 Player murrayConor
                                 Player madiganIan
                                 Player cuthbertAlex
                                 Player northGeorge
                                 Player nadoloNemani
                                 Player matavesiJosh ] }

    let chris1 = { Participant = chris; Ordinal = 1
                   DraftPicks = [ CoachTeam newZealand
                                  Player saveaJulian
                                  Player milnerSkudderNehe
                                  Player smithBen
                                  Player naholoWaisake
                                  Player carterDan
                                  Player habanaBryan
                                  CoachTeam england
                                  CoachTeam australia
                                  Player folauIsrael
                                  Player barrettBeauden
                                  Player fordGeorge
                                  Player pollardHandre
                                  Player sextonJonathan
                                  Player leRouxWillie
                                  Player watsonAnthony
                                  Player nonuMa'a
                                  Player hugetYoann
                                  Player giteauMatt
                                  Player mvovoLwazi ] }

    let denis1 = { Participant = denis ; Ordinal = 1
                   DraftPicks = [ CoachTeam ireland
                                  Player sextonJonathan
                                  Player readKieran
                                  Player northGeorge
                                  Player lambiePat
                                  Player o'BrienSean
                                  Player healyCian
                                  Player folauIsrael
                                  Player brownMike
                                  Player picamolesLouis
                                  Player hendersonIain
                                  Player zeboSimon
                                  Player fofanaWesley
                                  Player franksOwen
                                  Player dentonDavid
                                  Player williamsLiam
                                  Player woodTom
                                  Player pocockDavid
                                  Player o'ConnellPaul
                                  Player fitzgeraldLuke ] }

    let hugh1 = { Participant = hugh ; Ordinal = 1
                  DraftPicks = [ Player saveaJulian
                                 Player milnerSkudderNehe
                                 Player biggarDan
                                 Player habanaBryan
                                 Player leRouxWillie
                                 Player folauIsrael
                                 Player northGeorge
                                 Player watsonAnthony
                                 Player speightHenry
                                 Player josephJonathan
                                 Player hugetYoann
                                 Player russellFinn
                                 Player sextonJonathan
                                 Player nakaitaciNoa
                                 Player smithBen
                                 Player carterDan
                                 Player smithAaron
                                 Player mvovoLwazi
                                 Player krielJesse
                                 Player mayJonny ] }

    let jack1 = { Participant = jack ; Ordinal = 1
                  DraftPicks = [ Player pollardHandre
                                 CoachTeam england
                                 Player sanchezNicolas
                                 Player mayJonny
                                 Player toomuaMatt
                                 Player nonuMa'a
                                 Player habanaBryan
                                 Player pietersenJP
                                 Player leRouxWillie
                                 Player pocockDavid
                                 Player folauIsrael
                                 Player vermeulenDuane
                                 Player williamsSonnyBill
                                 Player ashleyCooperAdam
                                 Player youngsBen
                                 Player kainoJerome
                                 Player brownMike
                                 Player hooperMichael
                                 Player readKieran
                                 Player watsonAnthony ] }

    let jem1 = { Participant = jem ; Ordinal = 1 (* Awaiting possible additions/changes?... *)
                 DraftPicks = [ Player saveaJulian
                                Player pietersenJP
                                Player pollardHandre
                                Player michalakFrederic
                                Player folauIsrael
                                Player barrettBeauden
                                Player sextonJonathan
                                CoachTeam france
                                Player pocockDavid
                                Player picamolesLouis
                                Player o'BrienSean
                                Player readKieran
                                Player dusautoirThierry
                                Player vitoVictor
                                Player etzebethEben
                                Player parisseSergio ] }

    let martyn1 = { Participant = martyn ; Ordinal = 1
                    DraftPicks = [ CoachTeam newZealand
                                   Player carterDan
                                   Player lambiePat
                                   Player farrellOwen
                                   Player cooperQuade
                                   Player folauIsrael
                                   Player milnerSkudderNehe
                                   Player saveaJulian
                                   Player pietersenJP
                                   Player mvovoLwazi
                                   Player smithBen
                                   Player kirchnerZane
                                   CoachTeam southAfrica
                                   CoachTeam england
                                   CoachTeam australia
                                   Player smithAaron
                                   Player geniaWill
                                   Player pienaarRuan
                                   Player readKieran
                                   Player kainoJerome ] }

    let neph1 = { Participant = neph ; Ordinal = 1
                  DraftPicks = [ Player carterDan
                                 Player sextonJonathan
                                 CoachTeam southAfrica
                                 Player nonuMa'a
                                 Player milnerSkudderNehe
                                 Player ashleyCooperAdam
                                 Player mayJonny
                                 Player smithConrad
                                 Player josephJonathan
                                 Player folauIsrael
                                 Player biggarDan
                                 Player michalakFrederic
                                 CoachTeam argentina
                                 Player smithBen
                                 Player nadoloNemani
                                 Player williamsScott
                                 Player hugetYoann
                                 Player deAllendeDamian
                                 Player louwFrancois
                                 Player picamolesLouis ] }

    let rosie1 = { Participant = rosie ; Ordinal = 1
                   DraftPicks = [ CoachTeam southAfrica
                                  Player habanaBryan
                                  Player folauIsrael
                                  Player naholoWaisake
                                  Player saveaJulian
                                  Player fordGeorge
                                  Player leRouxWillie
                                  Player duPlessisBismarck
                                  Player barrettBeauden
                                  Player pollardHandre
                                  Player ayerzaMarcos
                                  Player masNicolas
                                  CoachTeam argentina
                                  Player milnerSkudderNehe
                                  Player josephJonathan
                                  Player lambiePat
                                  Player sanchezNicolas
                                  Player giteauMatt
                                  Player murrayConor
                                  Player tuilagiAlesana ] }

    let susie1 = { Participant = susie ; Ordinal = 1 (* Awaiting possible additions/changes?... *)
                   DraftPicks = [ CoachTeam newZealand
                                  Player carterDan
                                  Player fordGeorge
                                  Player josephJonathan
                                  Player hernandezJuanMartin
                                  Player habanaBryan
                                  Player laidlawGreig
                                  Player boweTommy
                                  Player coleDan
                                  Player jonesAlunWyn
                                  Player grayRichie
                                  Player mooreStephen
                                  Player heaslipJamie
                                  Player nyangaYannick
                                  Player retallickBrodie
                                  Player creevyAgustin ] }

    let draft1 = [ chad1; chris1; denis1; hugh1; jack1; jem1; martyn1; neph1; rosie1; susie1 ]




    // TODO [NMB]: Step-by-step output of first (and subsequent) drafts?...
    let getDraftHtml () = [ h3 "Coming soon..." ]
                          |> concatenateWithNewLine

