namespace AOrNotA.Sweepstake2015

open System

open AOrNotA.Sweepstake2015.Content
open AOrNotA.Sweepstake2015.``Data 2015``
open AOrNotA.Sweepstake2015.Domain
open AOrNotA.Sweepstake2015.Sweepstake
open AOrNotA.Sweepstake2015.``Sweepstake 2015``

module DraftContent =

    type DraftPick = | CoachTeam of team: Team
                     | Player of player: Player

    type SweepstakerDraft = { Participant: Participant; DraftPicks: DraftPick list }

    let chad1 = { Participant = chad
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

    let chris1 = { Participant = chris
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

    let denis1 = { Participant = denis
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

    let hugh1 = { Participant = hugh
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

    let jack1 = { Participant = jack
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

    let jem1 = { Participant = jem
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

    let martyn1 = { Participant = martyn
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

    let neph1 = { Participant = neph
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

    let rosie1 = { Participant = rosie
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

    let susie1 = { Participant = susie
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

    (* TODO [NMB]: Second draft...
    let neph2 = { Participant = neph
                  DraftPicks = [ Player leguizamonJuanManuel
                                 Player gorgodzeMamuka
                                 Player leitchMichael
                                 Player lobbeJuanMartinFernandez
                                 Player tipuricJustin ] }

    let draft2 = [ neph2 ] *)

    let getDraftPickText draftPick = match draftPick with | CoachTeam team -> sprintf "%s (%s)" team.Name team.Coach
                                                          | Player player -> sprintf "%s (%s)" player.Name player.Team.Name

    let isCoachTeamNeeded sweepstaker = match sweepstaker.CoachTeam with | Some _ -> false | None -> true
    let isPlayerTypeNeeded sweepstaker playerType =
        let picksOfType = sweepstaker.Picks |> List.filter (fun pick -> pick.Player.Type = playerType)
                                            |> List.length
        match playerType with | Forward -> picksOfType < requiredForwards
                              | Back -> picksOfType < requiredBacks

    let isCoachTeamAvailable sweepstakers team =
        match sweepstakers |> List.choose (fun sweepstaker -> sweepstaker.CoachTeam)
                           |> List.filter (fun team' -> team' = team)
                           |> List.length with
        | 0 -> true
        | _ -> false
    let isPlayerAvailable sweepstakers player =
        match sweepstakers |> List.collect (fun sweepstaker -> sweepstaker.Picks)
                           |> List.filter (fun pick -> pick.Player = player)
                           |> List.length with
        | 0 -> true
        | _ -> false

    let getSweepstaker (sweepstakers: Sweepstaker list) participant = 
        sweepstakers |> List.find (fun sweepstaker' -> sweepstaker'.Participant = participant)

    let getUnneeded (sweepstakers: Sweepstaker list) drafts =
        drafts
        |> List.collect (fun draft -> let unavailable' = draft.DraftPicks
                                                         |> List.filter (fun draftPick -> let sweepstaker = getSweepstaker sweepstakers draft.Participant
                                                                                          match draftPick with
                                                                                          | CoachTeam _ -> not (isCoachTeamNeeded sweepstaker)
                                                                                          | Player player -> not (isPlayerTypeNeeded sweepstaker player.Type))
                                      unavailable' |> List.map (fun draftPick -> draft.Participant, draftPick)
        )
    let getUnavailable sweepstakers drafts =
        drafts
        |> List.collect (fun draft -> let unavailable' = draft.DraftPicks
                                                         |> List.filter (fun draftPick -> match draftPick with
                                                                                          | CoachTeam team -> not (isCoachTeamAvailable sweepstakers team) 
                                                                                          | Player player -> not (isPlayerAvailable sweepstakers player))
                                      unavailable' |> List.map (fun draftPick -> draft.Participant, draftPick))

    let removedHtml removed unneeded =
        let reasonHtml (participant, draftPick) =
            let reason = match unneeded, draftPick with
                         | true, CoachTeam _ -> "a team/coach has already been picked"
                         | true, Player player -> match player.Type with
                                                  | Forward -> "8 forwards have already been picked"
                                                  | Back -> "7 backs have already been picked"
                         | false, _ -> sprintf "%s was picked in an earlier draft / round" (getDraftPickText draftPick)
            let reason' = match unneeded with
                          | true -> sprintf "Removed %s for %s: %s" (getDraftPickText draftPick) (extractParticipant participant) reason
                          | false -> sprintf "Removed pick for %s: %s" (extractParticipant participant) reason
            para reason'
        let descriptionHtml =
            match removed |> List.length, unneeded with | 0, _ -> []
                                                        | _, true -> [ para (italic "Removing surplus picks...") ]
                                                        | _, false -> [ para (italic "Removing unavailable picks...") ]
        descriptionHtml @
        (removed |> List.map reasonHtml)

    let updateDraftsForRemoved drafts removed =
        drafts |> List.map (fun draft -> let draftPicks = draft.DraftPicks
                                                          |> List.filter (fun pick -> not (removed |> List.exists (fun (participant, pick') -> participant = draft.Participant && pick = pick')))
                                         { Participant = draft.Participant; DraftPicks = draftPicks })

    let topPicksHtml topPicks unique round =
        let uniqueText = match unique with | true -> "unique" | false -> "contested"
        let topPickHtml (participant, draftPick) =
            para (sprintf "%s has a %s pick for round %d: %s" (extractParticipant participant) uniqueText round (getDraftPickText draftPick))
        let descriptionHtml =
            match topPicks |> List.length, unique with | 0, _ -> []
                                                       | _, true -> [ para (italic "Processing unique picks...") ]
                                                       | _, false -> [ para (italic "Processing contested picks...") ]
        descriptionHtml @
        (topPicks |> List.map topPickHtml)

    let assignCoachTeam sweepstaker team = { Participant = Participant (getParticipant sweepstaker)
                                             CoachTeam = Some team
                                             Picks = sweepstaker.Picks }
    let assignPlayer sweepstaker player = { Participant = Participant (getParticipant sweepstaker)
                                            CoachTeam = sweepstaker.CoachTeam
                                            Picks = sweepstaker.Picks @ [ { Player = player; OnlyScoresFrom = None } ] }

    let assignmentHtml participant draftPick contested =
        match contested with
        | false -> para (sprintf "%s assigned to %s" (getDraftPickText draftPick) (extractParticipant participant))
        | true -> para (sprintf "%s randomly assigned to %s" (getDraftPickText draftPick) (extractParticipant participant))

    let assignPicks (sweepstakers: Sweepstaker list) picks =
        let assignments =
            sweepstakers
            |> List.map (fun sweepstaker ->
                             let pick = match picks
                                              |> List.filter (fun (participant, _, _) -> participant = sweepstaker.Participant) with
                                        | (_, draftPick, contested) :: _ -> Some (draftPick, contested)
                                        | [] -> None
                             let sweepstaker' = match pick with
                                                | Some (draftPick, _) -> match draftPick with
                                                                         | CoachTeam team -> assignCoachTeam sweepstaker team
                                                                         | Player player -> assignPlayer sweepstaker player
                                                | None -> sweepstaker
                             let assignedHtml = match pick with
                                                | Some (draftPick, contested) -> assignmentHtml sweepstaker.Participant draftPick contested
                                                | None -> ""
                             sweepstaker', assignedHtml)
        let sweepstakers' = assignments |> List.map fst
        let assignedPicksHtml = assignments |> List.map snd
                                            |> List.filter (fun line -> line <> "")
        sweepstakers', assignedPicksHtml

    let assignUniquePicks sweepstakers uniquePicks =
        let picks = uniquePicks |> List.map (fun (participant, draftPick) -> participant, draftPick, false)
        assignPicks sweepstakers picks

    let assignContestedPicks nextRandom (sweepstakers: Sweepstaker list) contestedPicks (priorities: (Participant * int) list) =
        let getPriority participant = priorities |> List.filter (fun (participant', _) -> participant' = participant)
                                                 |> List.map (fun (_, value) -> value)
                                                 |> List.head
        let assignContestedPick (contestedPick: DraftPick * Participant list) =
            let contestedPriorityHtml (participant, value) =
                [ para (sprintf "%s has pick priority %d" (extractParticipant participant) value) ]
            let highestPriorityHtml participant =
                [ para (sprintf "%s has highest pick priority" (extractParticipant participant)) ]
            let randomHtml (participant, value) =
                [ para (sprintf "%s assigned random number %f" (extractParticipant participant) value)]
            // Note: Intentional hiding of contestHtml.
            let contestHtml = [ para (italic (sprintf "Resolving contested pick %s..." (getDraftPickText (fst contestedPick)))) ]
            let contestedPriorities = snd contestedPick |> List.map (fun participant -> participant, getPriority participant)
            let contestHtml = contestHtml @
                              (contestedPriorities |> List.collect contestedPriorityHtml)
            let highestPriority = contestedPriorities |> List.map (fun (_, value) -> value)
                                                      |> List.max
            let candidates = contestedPriorities |> List.filter (fun (_, value) -> value = highestPriority)
                                                 |> List.map fst
            let contestHtml = contestHtml @
                              (candidates |> List.collect highestPriorityHtml)
            let winningCandidate, contested, winningHtml =
                if candidates |> List.length > 1 then
                    let randoms = candidates |> List.map (fun participant -> participant, nextRandom ())
                    let randomsHtml = randoms |> List.collect randomHtml
                    let highest = randoms |> List.sortBy snd
                                          |> List.rev
                                          |> List.map fst
                                          |> List.head
                    highest, true, randomsHtml @ [ para (sprintf "%s has the highest random number" (extractParticipant highest)) ]
                else candidates |> List.head, false, []
            let losingCandidates = snd contestedPick |> List.filter (fun participant -> participant <> winningCandidate)
            let winner = winningCandidate, fst contestedPick, contested
            let losers = losingCandidates |> List.map (fun participant -> participant, fst contestedPick)
            winner, losers, contestHtml @ winningHtml
        let outcome = contestedPicks |> List.map assignContestedPick
        let picks = outcome |> List.map (fun (winner, _, _) -> winner)
        let missedPicks = outcome |> List.collect (fun (_, losers, _) -> losers)
        let contestedPicksHtml = outcome |> List.collect (fun (_, _, contestedPickHtml) -> contestedPickHtml)
        let sweepstakers', assignedPicksHtml = assignPicks sweepstakers picks
        sweepstakers', contestedPicksHtml @ assignedPicksHtml, missedPicks

    let updatePriorities priorities missedPicks =
        let missedPickHtml participant pick value =
            para (sprintf "%s missed out on %s: pick priority now %d" (extractParticipant participant) (getDraftPickText pick) value)
        let missed = priorities |> List.map (fun (participant, value) ->
                                                 let missedPick = match missedPicks
                                                                        |> List.filter (fun (participant', _) -> participant' = participant) with
                                                                  | h :: _ -> Some (snd h)
                                                                  | [] -> None
                                                 let priority = match missedPick with
                                                                | Some _ -> participant, value + 1
                                                                | None -> participant, value
                                                 let missedHtml = match missedPick with
                                                                  | Some pick -> missedPickHtml participant pick (snd priority)
                                                                  | None -> ""
                                                 priority, missedHtml)
        let priorities' = missed |> List.map fst
        let prioritiesHtml = missed |> List.map snd
                                    |> List.filter (fun line -> line <> "")
        priorities', prioritiesHtml

    let processDraft ordinal seed (sweepstakers: Sweepstaker list) drafts =
        let getRandom seed =
            let random = match seed with | Some seed' -> Random seed' | None -> Random ()
            fun () -> random.NextDouble ()
        let nextRandom = getRandom seed
        let rec processRound sweepstakers drafts priorities draftHtml round =
            // Note: Intentional hiding of sweepstakers | drafts | missed | draftHtml.
            let draftHtml = draftHtml @ [ h3 (sprintf "Round %d" round)]
            let unneeded = getUnneeded sweepstakers drafts
            let draftHtml = draftHtml @ removedHtml unneeded true
            let drafts = updateDraftsForRemoved drafts unneeded
            let unavailable = getUnavailable sweepstakers drafts
            let draftHtml = draftHtml @ removedHtml unavailable false
            let drafts = updateDraftsForRemoved drafts unavailable
            let remainingPicks = drafts |> List.collect (fun draft -> draft.DraftPicks)
                                        |> List.length
            if remainingPicks = 0 then sweepstakers, draftHtml
            else let topPicks = drafts |> List.filter (fun draft -> draft.DraftPicks |> List.length > 0)
                                       |> List.map (fun draft -> draft.Participant, draft.DraftPicks |> List.head)
                 let uniquePicks = topPicks |> Seq.ofList |> Seq.groupBy snd |> List.ofSeq
                                            |> List.filter (fun (_, seq) -> seq |> Seq.length = 1)
                                            |> List.collect (fun (_, seq) -> seq |> List.ofSeq)
                 let draftHtml = draftHtml @ topPicksHtml uniquePicks true round
                 let sweepstakers, uniqueHtml = assignUniquePicks sweepstakers uniquePicks
                 let draftHtml = draftHtml @ uniqueHtml
                 let contestedPicks = topPicks |> Seq.ofList |> Seq.groupBy snd |> List.ofSeq
                                               |> List.filter (fun (_, seq) -> seq |> Seq.length > 1)
                                               |> List.map (fun (draftPick, seq) -> draftPick, seq |> List.ofSeq |> List.map fst)
                 let contestedPicks' = contestedPicks |> List.collect (fun (draftPick, participants) ->
                                                                           participants |> List.map (fun participant -> participant, draftPick))
                 let draftHtml = draftHtml @ topPicksHtml contestedPicks' false round
                 let sweepstakers, contestedHtml, missedPicks = assignContestedPicks nextRandom sweepstakers contestedPicks priorities
                 let draftHtml = draftHtml @ contestedHtml
                 let priorities, prioritiesHtml = updatePriorities priorities missedPicks
                 let draftHtml = draftHtml @ prioritiesHtml
                 let drafts = drafts |> List.filter (fun draft -> draft.DraftPicks |> List.length > 1)
                                     |> List.map (fun draft -> { Participant = draft.Participant
                                                                 DraftPicks = draft.DraftPicks |> List.tail } )
                 if drafts |> List.length = 0 then sweepstakers, draftHtml
                 else processRound sweepstakers drafts priorities draftHtml (round + 1)
        let priorities = sweepstakers |> List.map (fun sweepstaker -> sweepstaker.Participant, 0)
        let sweepstakers', draftHtml = processRound sweepstakers drafts priorities [] 1
        let seedHtml = match seed with | Some seed' -> [ para (italic (sprintf "Using random seed %d" seed')) ] | None -> []
        let processHtml = [ h2 (anchor (sprintf "Draft %d process" ordinal)) ] @
                          seedHtml @
                          draftHtml
        sweepstakers', processHtml
    
    let sweepstakerHtml sweepstaker =
        let isForward pick = match pick.Player.Type with | Forward -> true | Back -> false
        let pluralize noun count = if count = 1 then noun else sprintf "%ss" noun
        let getCoachTeamText (team: Team option) = match team with | Some team' -> sprintf "Team/coach: %s (%s)" team'.Name team'.Coach
                                                                   | None -> italic "Team/coach still to be picked..."
        let playersHtml =
            let playerHtml player = para (sprintf "%s (%s): %s" player.Name player.Team.Name (getPlayerType player))
            let forwards = sweepstaker.Picks |> List.filter (fun pick -> isForward pick)
            let backs = sweepstaker.Picks |> List.filter (fun pick -> not (isForward pick))
            let forwardsHtml = forwards |> List.map (fun pick -> playerHtml pick.Player)
            let backsHtml = backs |> List.map (fun pick -> playerHtml pick.Player)
            let forwardsToPick = requiredForwards - (forwards |> List.length)
            let backsToPick = requiredBacks - (backs |> List.length)
            let toPickHtml = match forwardsToPick, backsToPick with
                             | 0, 0 -> [ para (italic "The required number of backs and forwards have been picked") ]
                             | _, 0 -> [ para (italic (sprintf "%d %s still to be picked..." forwardsToPick (pluralize "forward" forwardsToPick))) ]
                             | 0, _ -> [ para (italic (sprintf "%d %s still to be picked..." backsToPick (pluralize "back" backsToPick))) ]
                             | _ -> [ para (italic (sprintf "%d %s and %d %s still to be picked..." forwardsToPick (pluralize "forward" forwardsToPick) backsToPick (pluralize "back" backsToPick))) ]
            forwardsHtml @ backsHtml @ toPickHtml
        [ h3 (sprintf "%s" (getParticipant sweepstaker)) ] @
        [ para (getCoachTeamText sweepstaker.CoachTeam) ] @
        playersHtml

    let sweepstakersPostDraftHtml ordinal sweepstakers = [ h2 (anchor (sprintf "Draft %d outcome" ordinal)) ] @
                                                         (sweepstakers |> List.collect sweepstakerHtml)

    let sweepstakerDraftHtml draft =
        let picksHtml = 
            orderedList (draft.DraftPicks |> List.map (fun pick -> listItem (getDraftPickText pick)))
        [ h3 (sprintf "%s picks" (extractParticipant draft.Participant)) ] @
        picksHtml

    let draftPicksHtml ordinal drafts = [ h2 (anchor (sprintf "Draft %d picks" ordinal)) ] @
                                        (drafts |> List.collect sweepstakerDraftHtml)

    let draftProcessHtml ordinal seed sweepstakers drafts =
        let sweepstakers', processHtml = processDraft ordinal seed sweepstakers drafts
        processHtml @
        sweepstakersPostDraftHtml ordinal sweepstakers'

    let getDraft1Html () = draftPicksHtml 1 draft1 @
                           draftProcessHtml 1 (Some 41428672) sweepstakers0 draft1
                           |> concatenateWithNewLine

    (* TODO [NMB]: Second draft...
    let getDraft2Html () = draftPicksHtml 2 draft2 @
                           draftProcessHtml 2 (Some 973974) sweepstakers1 draft2
                           |> concatenateWithNewLine *)

