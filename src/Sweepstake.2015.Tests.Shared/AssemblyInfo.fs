﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Sweepstake.2015.Tests.Shared")>]
[<assembly: AssemblyProductAttribute("Sweepstake.2015")>]
[<assembly: AssemblyDescriptionAttribute("The inaugural world-famous Rugby World Cup sweepstake")>]
[<assembly: AssemblyVersionAttribute("0.1.0")>]
[<assembly: AssemblyFileVersionAttribute("0.1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.0"
