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
## Update #3

Well, that took a lot longer than intended - not helped by my perfectionist tendencies ;) - but the first draft has now been completed: 
[submitted picks](draft.html#Draft 1 picks), [draft process](draft.html#Draft 1 process) and [outcome](draft.html#Draft 1 outcome).

Hopefully everyone will be reasonably happy with the results. (Some players have ended up with more players than others - either as a 
result of including plenty of forwards in their first draft picks, or of picking less popular players. Or, indeed, of doing both and 
picking a half-Irish team...)

The deadline for the second draft will be **8pm** (UK time) on **Thursday**.

Please again e-mail djnarration@gmail.com with an **ordered** list of players - including teams/coaches if you still need one of those 
(which Chad, Hugh and Martyn do). 

The [teams](teams.html) page has up-to-date details of which players &c. are still available.

For this second draft, you can submit as many picks as you like. Given that you'll be picking less well-know players, there should be 
a smaller risk of everyone picking the same ones - but as time is against us and I'm really keen to avoid having to squeeze in a third 
draft on Friday, please err on the side of picking more players than you think you need. (At a guess, I'd suggest picking at least 
twice as many players as you need; maybe even three times as many.)

And now that I've got the necessary code in place, I'm confident that processing the second draft will be significantly quicker.

(If a third draft does turn out to be required, the provisional deadline for that will be 6pm on Friday.)

### Payout structure

The payout structure will be: fifty quid for first place; thirty quid for second place; and twenty quid for third place. (Sorry, Denis, 
no wooden spoon prize this time.)
*)

(*** include-value: indexHtml ***)

