(*** hide ***)
#I "../../src/Sweepstake.2015/bin/Release"

#r "Sweepstake.2015.dll"
open AOrNotA.Sweepstake2015.HtmlContent

let teamsHtml = getTeamsHtml ()

(**
Teams, fixtures and results
===========================
*)

(*** include-value: teamsHtml ***)

