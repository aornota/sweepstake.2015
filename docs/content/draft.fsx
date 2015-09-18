(*** hide ***)
#I "../../src/Sweepstake.2015/bin/Release"

#r "Sweepstake.2015.dll"
open AOrNotA.Sweepstake2015.Content
open AOrNotA.Sweepstake2015.DraftContent

let lastUpdated = getLastUpdated ()
let draft2Html = getDraft2Html ()
let draft1Html = getDraft1Html ()

(**
Draft details
=============
*)

(*** include-value: lastUpdated ***)

(*** include-value: draft2Html ***)

(*** include-value: draft1Html ***)

