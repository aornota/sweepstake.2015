(*** hide ***)
#I "../../src/Sweepstake.2015/bin/Release"

#r "Sweepstake.2015.dll"
open AOrNotA.Sweepstake2015.Content
open AOrNotA.Sweepstake2015.TeamsContent

let lastUpdated = getLastUpdated ()
let teamsLinksHtml = getTeamsLinksHtml ()
let teamsHtml = getTeamsHtml ()

(**
Teams, fixtures and results
===========================
*)

(*** include-value: lastUpdated ***)

(*** include-value: teamsLinksHtml ***)

(*** include-value: teamsHtml ***)

