namespace AOrNotA.Sweepstake2015.Tests.VS

open Microsoft.VisualStudio.TestTools.UnitTesting

open AOrNotA.Sweepstake2015.``Data 2011``
open AOrNotA.Sweepstake2015.Tests.``Data Tests``

[<TestClass>]
type ``Data 2011 Tests`` () =

    [<TestMethod>]
    member x.``Verify Player Team for all 2011 Squads`` () =
        let failed = ``Get Squads with Players for incorrect Team`` squads
        match failed with | squad :: t -> Assert.Fail (sprintf "One of more Squads have Players for incorrect Team (e.g. %A)" squad)
                          | [] -> ()

    [<TestMethod>]
    member x.``Verify total non-withdrawn Players for all 2011 Squads`` () =
        let failed = ``Get Squads with incorrect total non-withdrawn Player counts`` squads 30
        match failed with | squad :: t -> Assert.Fail (sprintf "One of more Squads have incorrect total non-withdrawn Player counts (e.g. %A)" squad)
                          | [] -> ()

    [<TestMethod>]
    member x.``Verify MatchEvent Teams for all 2011 Matches`` () =
        let failed = ``Get Matches with MatchEvents for incorrect Teams`` matches
        match failed with | ``match`` :: t -> Assert.Fail (sprintf "One of more Matches have MatchEvents for incorrect Teams (e.g. %A)" ``match``)
                          | [] -> ()

    [<TestMethod>]
    member x.``Verify TeamScores for all 2011 Matches`` () =
        let failed = ``Get Matches with incorrect TeamScores`` matches
        match failed with | ``match`` :: t -> Assert.Fail (sprintf "One of more Matches have incorrect TeamScores (e.g. %A)" ``match``)
                          | [] -> ()

    [<TestMethod>]
    member x.``Verify total Conversion attempts for all 2011 Matches`` () =
        let failed = ``Get Matches with incorrect total Conversion attempts`` matches
        match failed with | ``match`` :: t -> Assert.Fail (sprintf "One of more Matches have incorrect total Conversion attempts (e.g. %A)" ``match``)
                          | [] -> ()

