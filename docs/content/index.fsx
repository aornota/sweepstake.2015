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
## Update #5: Friday 18th September

One game down; forty-seven to go...

Denis races out to an early lead thanks to a deserved man-of-the-match performance from Mike Brown in, frankly, a pretty scrappy game. Jack 
gets a bonus point English win and a penalty try to boot. Hugh scores via the slimmed-down Billy Vunipola; Neph via man-mountain Nemani 
Nadolo (or "Nandolo", as Nick Mullins insists on calling him; maybe he's thinking of Nando's?). Martyn and Susie pick up points from the 
boots of Owen Farrell and George Ford respectively. And a yellow card for Nikola Matawalu (who almost redeemed himself with what would have 
been a brilliant try) leave Chad stuck in reverse gear.

The final picks were Siya Kolisi (South Africa) for Hugh and Mako Vunipola (England) for Rosie.

Now for a busy Saturday. Come on Canada!

#### Latest results

Friday 18th September -- [England](teams.html#England) 35 - 11 [Fiji](teams.html#Fiji)

#### Upcoming fixtures

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

The payout structure will be: fifty quid for first place; thirty quid for second place; and twenty quid for third place. (Sorry, 
<strike>Denis</strike> Chad, no wooden spoon prize this time.)

### Source code
If anyone wants to check that the drafting algorithm is above board, please feel free to take a look at 
[all of the code](https://github.com/aornota/sweepstake.2015).
*)

(*** include-value: indexHtml ***)

