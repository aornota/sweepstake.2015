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
## Update #4

The second draft has now been completed: [submitted picks](draft.html#Draft 2 picks), [draft process](draft.html#Draft 2 process) and 
[outcome](draft.html#Draft 2 outcome).

TODO...

#### Upcoming fixtures

Friday 18th September at 20:00 -- [England](teams.html#England) vs [Fiji](teams.html#Fiji)

Saturday 19th September at 12:00 -- [Tonga](teams.html#Tonga) vs [Georgia](teams.html#Georgia)

Saturday 19th September at 14:30 -- [Ireland](teams.html#Ireland) vs [Canada](teams.html#Canada)

Saturday 19th September at 16:45 -- [South Africa](teams.html#South Africa) vs [Japan](teams.html#Japan)

Saturday 19th September at 20:00 -- [France](teams.html#France) vs [Italy](teams.html#Ireland)

Sunday 20th September at 12:00 -- [Samoa](teams.html#Samoa) vs [United States](teams.html#United States)

Sunday 20th September at 14:30 -- [Wales](teams.html#Wales) vs [Uruguay](teams.html#Uruguay)

Sunday 20th September at 16:45 -- [New Zealand](teams.html#New Zealand) vs [Argentina](teams.html#Argentina)

### A brief note on replacements

Once the tournament is underway, if one of your players is withdrawn, I'll try and let you know (or you can let me know). You can then pick 
any unpicked player as a replacement - with the proviso that you will only be credited with points that they score from that point onwards. 
(If there's a sudden spate of withdrawals, replacements will be allocated on a first-come first-served basis.)

### Payout structure

The payout structure will be: fifty quid for first place; thirty quid for second place; and twenty quid for third place. (Sorry, Denis, 
no wooden spoon prize this time.)

### Source code
If anyone wants to check that the drafting algorithm is above board, please feel free to take a look at 
[all of the code](https://github.com/aornota/sweepstake.2015).
*)

(*** include-value: indexHtml ***)

