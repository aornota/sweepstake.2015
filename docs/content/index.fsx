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
## Update #1

After various problems - lack of reliable broadband for the last week; technical challenges too numerous to detail; &c. - progress has been 
made ;~D

Given the delays, the deadline for the [first draft](#First-draft) has been changed to **8pm** (UK time) on **Tuesday 14th September**. The 
outcome of this first draft will be available by Wednesday morning at the latest.

The provisional deadline for the second draft is 8pm on the Thursday. If required, a third draft will happen before the [first 
match](teams.html#Group-A-fixtures) kicks-off on Friday evening.

Before submitting your picks for the first draft, you may wish to review the [scoring system](scoring.html) and the [teams, fixtures and 
results](teams.html).

### First draft

Once the entire draft process has been completed, each sweepstake team will consist of a team/coach, 8 forwards and 7 backs.

For the first draft, each participant will need to supply an **ordered** list of **20** picks. These can include more than one team/coach 
(though listing all 20 teams/coaches would be perverse).

For example:

 1. [Canada](teams.html#Canada) (Kieran Crowley)
 2. Jeronimo Etcheverry ([Uruguay](teams.html#Uruguay))
 3. Frans Malherbe ([South Africa](teams.html#South Africa))
 4. Craig Wing ([Japan](teams.html#Japan))
 5. Matekitonga Moeakiola ([United States](teams.html#United States))
 6. Jack Lam ([Samoa](teams.html#Samoa))
 7. Jack Ram ([Tonga](teams.html#Tonga))
 8. Hale T-Pole ([Tonga](teams.html#Tonga))
 9. Djustice Sears-Duru ([Canada](teams.html#Canada))
 10. John Moonlight ([Canada](teams.html#Canada))
 11. &c.

(Disclaimer: I wouldn't recommend those particular picks - though they are some of my favourite names...)

An algorithm will assign teams/coaches and players [forwards and backs] to sweepstakers. (Roughly, if no-one else has the same top 
selection as you, you'll get it; otherwise, the selection will be assigned randomly. And similarly for second selections, though if your 
second selection was assigned to someone else in the first round, your third [or fourth &c.] will be used on the second round. [If you've 
already filled your quota of forwards, any further forwards will likewise be ignored.] And for the second and subsequent rounds, where 
multiple participants have the same selection, priority will be given to the one with the most "unsuccessful" picks up to that point. And 
so on...)

Please e-mail your list of 20 picks to **djnarration@gmail.com** before 8pm on Tuesday. Thanks!

*)

(*** include-value: indexHtml ***)

