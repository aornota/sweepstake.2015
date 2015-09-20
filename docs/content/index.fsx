(*** hide ***)
#I "../../src/Sweepstake.2015/bin/Release"

#r "Sweepstake.2015.dll"
open AOrNotA.Sweepstake2015.Content
open AOrNotA.Sweepstake2015.IndexContent

let lastUpdated = getLastUpdated ()
let indexStandingsAndLinksHtml = getIndexStandingsAndLinksHtml ()
let indexHtml = getIndexHtml ()

(**
Latest news
===========
*)

(*** include-value: lastUpdated ***)

(*** include-value: indexStandingsAndLinksHtml ***)

(**
## Sunday 20th September

### Update #12

**Group C: [New Zealand](teams.html#New Zealand) 26 - 16 [Argentina](teams.html#Argentina)**

Eight matches down, forty to go - and everything still to play for...

A New Zealand win and man-of-the-match Brodie Retallick help Susie pull away from the bottom two, whilst Chad likewise keeps moving in the 
right direction with tries from Sam Cane and Aaron Smith. Solid kicking from the impressive Nicolas Sanchez allows Jack to make up ground 
on Denis. Neph edges back in front, albeit with Dan Carter's ever-reliable kicking offset by Argentine (Pablo Matera) and Kiwi (Conrad 
Smith, of all people) indiscipline. And a yellow card for Richie McCaw leaves Chris hoping for better things when we resume on Wednesday.

### Update #11

**Group A: [Wales](teams.html#Wales) 54 - 9 [Uruguay](teams.html#Uruguay)**

Probably not quite the points difference Wales were hoping for - and more injury concerns to boot (though Matthew Morgan looks like a 
decent player).

Martyn continues creeping up the table thanks to a bonus point Welsh win; Jack consolidates third place with a try from Justin Tipuric 
(when he remembered not to drop the ball); and Denis retakes the lead via the reliable kicking of Rhys Priestland.

(Man-of-the-match was eventually announced as Cory Allen, so no points for anyone on that front.)

### Update #10

**Group B: [Samoa](teams.html#Samoa) 25 - 16 [United States](teams.html#United States)**

Nice and easy, this one: no points for anyone!

I suspect that the next match will be a different story...

## Saturday 19th September

### Update #9

**Group D: [France](teams.html#France) 32 - 10 [Italy](teams.html#Ireland)**

Damn, I really though Guilhem Guirado was going to confirm my lucky bastard status by scoring there. Ah well, musn't grumble.

Anyway, Jem races up the table thanks to the French team - and to Frederick Michalak and Louis Picamoles in particular. Nicolas Mas scores 
a try for Rosie; Scott Spedding gives Susie a small boost.

Tomorrow will see Samoa, United States, Wales, Uruguay, New Zealand and Argentina play their first matches; Scotland and Australia have to 
wait until Wednesday...

### Update #8

**Group B: [South Africa](teams.html#South Africa) 32 - 34 [Japan](teams.html#Japan)**

Wow! A stunning performance from Japan in one of the best games I've even seen. (Shane Williams wasn't wrong when he said that Japan would 
play for the full eighty minutes.)

Mixed results for Rosie: tries from Bismarck du Plessis and Adriaan Strauss - but nil points for South Africa (their two bonus points being 
offset by Coenie Oosthuizen's yellow card). Francois Louw and Michael Leitch do the business for Neph; Pat Lambie and Handre Pollard keep 
things ticking over for Martyn and Jack.

### Update #7

**Group D: [Ireland](teams.html#Ireland) 50 - 7 [Canada](teams.html#Canada)**

A solid Irish performance sees Denis retake the lead with a bonus point win (slightly marred by Paul O'Connell's yellow card) and tries 
from Sean O'Brien and Iain Henderson. Jonathan Sexton takes Neph up to second; Ian Madigan moves Chad into positive territory.</p>
 
### Update #6

**Group C: [Tonga](teams.html#Tonga) 10 - 17 [Georgia](teams.html#Georgia)**

A typically barnstorming performance from Marmuka Gorgodze sees Jack take the lead - though Denis will be expecting a bucketload of points 
from the next game.

## Friday 18th September

### Update #5

**Group A: [England](teams.html#England) 35 - 11 [Fiji](teams.html#Fiji)**

Denis races out to an early lead thanks to a deserved man-of-the-match performance from Mike Brown in, frankly, a pretty scrappy game. Jack 
gets a bonus point English win and a penalty try to boot. Hugh scores via the slimmed-down Billy Vunipola; Neph via man-mountain Nemani 
Nadolo (or "Nandolo", as Nick Mullins insists on calling him; maybe he's thinking of Nando's?). Martyn and Susie pick up points from the 
boots of Owen Farrell and George Ford respectively. And a yellow card for Nikola Matawalu (who almost redeemed himself with what would have 
been a brilliant try) leave Chad stuck in reverse gear.

#### Upcoming fixtures

Wednesday 23rd September at 14:30 -- Group B: [Scotland](teams.html#Scotland) vs [Japan](teams.html#Japan)

Wednesday 23rd September at 16:45 -- Group A: [Australia](teams.html#Australia) vs [Fiji](teams.html#Fiji)

Wednesday 23rd September at 20:00 -- Group D: [France](teams.html#France) vs [Romania](teams.html#Romania)

Thursday 24th September at 20:00 -- Group C: [New Zealand](teams.html#New Zealand) vs [Namibia](teams.html#Namibia)

Friday 25th September at 16:45 -- Group C: [Argentina](teams.html#Argentina) vs [Georgia](teams.html#Georgia)

#### A brief note on replacements

Once the tournament is underway, if one of your players is withdrawn, I'll try and let you know (or you can let me know). You can then pick 
any unpicked player as a replacement - with the proviso that you will only be credited with points that they score from that point onwards. 
(If there's a sudden spate of withdrawals, replacements will be allocated on a first-come first-served basis.)

#### Payout structure

The payout structure will be: fifty quid for first place; thirty quid for second place; and twenty quid for third place. (Sorry, 
<strike>Denis</strike> <strike>Chad</strike> Chris, no wooden spoon prize this time.)

#### Source code
If anyone wants to check that the drafting algorithm is above board, please feel free to take a look at 
[all of the code](https://github.com/aornota/sweepstake.2015).
*)

(*** include-value: indexHtml ***)

