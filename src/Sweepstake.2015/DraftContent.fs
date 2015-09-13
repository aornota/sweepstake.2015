namespace AOrNotA.Sweepstake2015

open System
open System.Text

open AOrNotA.Sweepstake2015.Content
open AOrNotA.Sweepstake2015.Domain
open AOrNotA.Sweepstake2015.Sweepstake

module DraftContent =

    // TODO [NMB]: Step-by-step output of first (and subsequent) drafts?...
    let getDraftHtml () = [ h3 "Coming soon..." ]
                          |> concatenateWithNewLine

