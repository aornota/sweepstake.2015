(*** hide ***)
#I "../../src/Sweepstake.2015/bin/Release"

#r "Sweepstake.2015.dll"
open AOrNotA.Sweepstake2015.Content
open AOrNotA.Sweepstake2015.IndexContent

let lastUpdated = getLastUpdated ()
let indexLinksHtml = getIndexLinksHtml ()
let indexHtml = getIndexHtml ()

(**
Latest news
===========
*)

(*** include-value: lastUpdated ***)

(*** include-value: indexLinksHtml ***)

(**
## Update #2

Thanks everyone for submitting your first draft picks in a timely fashion - even if some of you didn't quite understand my instructions ;)

Processing of the first draft is running a bit behind schedule. (I wasn't intending to do any real work today but a minor crisis put paid 
tothat plan.) The algorithm will be implemented over the next few hours; I'll send an e-mail to let y'all know when the results are in...

Having seen everyone's picks, I can say that some teams/coaches and players have been more popular than others (unsurpisingly), so in all 
likelihood, you'll only get assigned a relatively small number of players each.

The arrangements for the second draft will be confirmed once the outcome of the first draft is known - and once I've had time to discuss 
with Rosie. A provisional deadline of 8pm on Thursday still seems likely (and should allow for a quick third draft if required). The second 
draft will again involve an **ordered** list of picks - but I'm tempted to say that you can submit as many picks as you like because that 
should minimize the need for subsequent drafts. (After all, it's only fifty or so hours until the 
[first match](teams.html#Group-A-fixtures) kicks-off.)

The payout structure will also be confirmed once I've consulted with Rosie.
*)

(*** include-value: indexHtml ***)

