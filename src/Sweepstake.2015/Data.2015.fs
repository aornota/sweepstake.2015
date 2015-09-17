﻿namespace AOrNotA.Sweepstake2015

open System

open AOrNotA.Sweepstake2015.Domain

module ``Data 2015`` =

    // 2015 squads: https://en.wikipedia.org/wiki/2015_Rugby_World_Cup_squads...

    // TODO [NMB]: Update Status(es) as Teams are Eliminated...

    let newZealand = { Name = "New Zealand"; Status = Active; Seeding = Some 1; Coach = "Steve Hansen" }

    let colesDane = { Name = "Dane Coles"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let mealamuKeven = { Name = "Keven Mealamu"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let taylorCodie = { Name = "Codie Taylor"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let crockettWyatt = { Name = "Wyatt Crockett"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let faumuinaCharlie = { Name = "Charlie Faumuina"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let franksBen = { Name = "Ben Franks"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let franksOwen = { Name = "Owen Franks"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let woodcockTony = { Name = "Tony Woodcock"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let retallickBrodie = { Name = "Brodie Retallick"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let romanoLuke = { Name = "Luke Romano"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let whitelockSam = { Name = "Sam Whitelock"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let caneSam = { Name = "Sam Cane"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let kainoJerome = { Name = "Jerome Kaino"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let mcCawRichie = { Name = "Richie McCaw"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let messamLiam = { Name = "Liam Messam"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let readKieran = { Name = "Kieran Read"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let vitoVictor = { Name = "Victor Vito"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let kerrBarlowTawera = { Name = "Tawera Kerr-Barlow"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let perenaraTJ = { Name = "TJ Perenara"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let smithAaron = { Name = "Aaron Smith"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let barrettBeauden = { Name = "Beauden Barrett"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let carterDan = { Name = "Dan Carter"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let sladeColin = { Name = "Colin Slade"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let fekitoaMalakai = { Name = "Malakai Fekitoa"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let nonuMa'a = { Name = "Ma'a Nonu"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let smithConrad = { Name = "Conrad Smith"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let williamsSonnyBill = { Name = "Sonny Bill Williams"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let naholoWaisake = { Name = "Waisake Naholo"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let saveaJulian = { Name = "Julian Savea"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let milnerSkudderNehe = { Name = "Nehe Milner-Skudder"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let smithBen = { Name = "Ben Smith"; Team = newZealand; Type = Back; Status = OriginalSquad }

    let newZealandSquad = { Team = newZealand
                            Players = [ colesDane; mealamuKeven; taylorCodie; crockettWyatt; faumuinaCharlie; franksBen; franksOwen
                                        woodcockTony; retallickBrodie; romanoLuke; whitelockSam; caneSam; kainoJerome; mcCawRichie
                                        messamLiam; readKieran; vitoVictor; kerrBarlowTawera; perenaraTJ; smithAaron; barrettBeauden
                                        carterDan; sladeColin; fekitoaMalakai; nonuMa'a; smithConrad; williamsSonnyBill; naholoWaisake
                                        saveaJulian; milnerSkudderNehe; smithBen ] }

    let southAfrica = { Name = "South Africa"; Status = Active; Seeding = Some 2; Coach = "Heyneke Meyer" }

    let britsSchalk = { Name = "Schalk Brits"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let duPlessisBismarck = { Name = "Bismarck du Plessis"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let straussAdriaan = { Name = "Adriaan Strauss"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let duPlessisJannie = { Name = "Jannie du Plessis"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let malherbeFrans = { Name = "Frans Malherbe"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let mtawariraTendai = { Name = "Tendai Mtawarira"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let nyakaneTrevor = { Name = "Trevor Nyakane"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let oosthuizenCoenie = { Name = "Coenie Oosthuizen"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let deJagerLood = { Name = "Lood de Jager"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let duToitPieterSteph = { Name = "Pieter-Steph du Toit"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let etzebethEben = { Name = "Eben Etzebeth"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let matfieldVictor = { Name = "Victor Matfield"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let albertsWillem = { Name = "Willem Alberts"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let burgerSchalk = { Name = "Schalk Burger"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let kolisiSiya = { Name = "Siya Kolisi"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let louwFrancois = { Name = "Francois Louw"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let vermeulenDuane = { Name = "Duane Vermeulen"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let duPreezFourie = { Name = "Fourie du Preez"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let paigeRudy = { Name = "Rudy Paige"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let pienaarRuan = { Name = "Ruan Pienaar"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let lambiePat = { Name = "Pat Lambie"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let pollardHandre = { Name = "Handré Pollard"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let steynMorne = { Name = "Morné Steyn"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let deAllendeDamian = { Name = "Damian de Allende"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let deVilliersJean = { Name = "Jean de Villiers"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let krielJesse = { Name = "Jesse Kriel"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let habanaBryan = { Name = "Bryan Habana"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let mvovoLwazi = { Name = "Lwazi Mvovo"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let pietersenJP = { Name = "JP Pietersen"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let kirchnerZane = { Name = "Zane Kirchner"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let leRouxWillie = { Name = "Willie le Roux"; Team = southAfrica; Type = Back; Status = OriginalSquad }

    let southAfricaSquad = { Team = southAfrica
                             Players = [ britsSchalk; duPlessisBismarck; straussAdriaan; duPlessisJannie; malherbeFrans; mtawariraTendai
                                         nyakaneTrevor; oosthuizenCoenie; deJagerLood; duToitPieterSteph; etzebethEben; matfieldVictor
                                         albertsWillem; burgerSchalk; kolisiSiya; louwFrancois; vermeulenDuane; duPreezFourie; paigeRudy
                                         pienaarRuan; lambiePat; pollardHandre; steynMorne; deAllendeDamian; deVilliersJean; krielJesse
                                         habanaBryan; mvovoLwazi; pietersenJP; kirchnerZane; leRouxWillie ] }

    let australia = { Name = "Australia"; Status = Active; Seeding = Some 3; Coach = "Michael Cheika" }

    let mooreStephen = { Name = "Stephen Moore"; Team = australia; Type = Forward; Status = OriginalSquad }
    let polotaNauTatafu = { Name = "Tatafu Polota-Nau"; Team = australia; Type = Forward; Status = OriginalSquad }
    let holmesGreg = { Name = "Greg Holmes"; Team = australia; Type = Forward; Status = OriginalSquad }
    let kepuSekope = { Name = "Sekope Kepu"; Team = australia; Type = Forward; Status = OriginalSquad }
    let sioScott = { Name = "Scott Sio"; Team = australia; Type = Forward; Status = OriginalSquad }
    let slipperJames = { Name = "James Slipper"; Team = australia; Type = Forward; Status = OriginalSquad }
    let smithToby = { Name = "Toby Smith"; Team = australia; Type = Forward; Status = OriginalSquad }
    let douglasKane = { Name = "Kane Douglas"; Team = australia; Type = Forward; Status = OriginalSquad }
    let mummDean = { Name = "Dean Mumm"; Team = australia; Type = Forward; Status = OriginalSquad }
    let simmonsRob = { Name = "Rob Simmons"; Team = australia; Type = Forward; Status = OriginalSquad }
    let skeltonWill = { Name = "Will Skelton"; Team = australia; Type = Forward; Status = OriginalSquad }
    let fardyScott = { Name = "Scott Fardy"; Team = australia; Type = Forward; Status = OriginalSquad }
    let hooperMichael = { Name = "Michael Hooper"; Team = australia; Type = Forward; Status = OriginalSquad }
    let mcMahonSean = { Name = "Sean McMahon"; Team = australia; Type = Forward; Status = OriginalSquad }
    let pocockDavid = { Name = "David Pocock"; Team = australia; Type = Forward; Status = OriginalSquad }
    let mcCalmanBen = { Name = "Ben McCalman"; Team = australia; Type = Forward; Status = OriginalSquad }
    let paluWycliff = { Name = "Wycliff Palu"; Team = australia; Type = Forward; Status = OriginalSquad }
    let geniaWill = { Name = "Will Genia"; Team = australia; Type = Back; Status = OriginalSquad }
    let phippsNick = { Name = "Nick Phipps"; Team = australia; Type = Back; Status = OriginalSquad }
    let cooperQuade = { Name = "Quade Cooper"; Team = australia; Type = Back; Status = OriginalSquad }
    let foleyBernard = { Name = "Bernard Foley"; Team = australia; Type = Back; Status = OriginalSquad }
    let bealeKurtley = { Name = "Kurtley Beale"; Team = australia; Type = Back; Status = OriginalSquad }
    let giteauMatt = { Name = "Matt Giteau"; Team = australia; Type = Back; Status = OriginalSquad }
    let kuridraniTevita = { Name = "Tevita Kuridrani"; Team = australia; Type = Back; Status = OriginalSquad }
    let toomuaMatt = { Name = "Matt Toomua"; Team = australia; Type = Back; Status = OriginalSquad }
    let ashleyCooperAdam = { Name = "Adam Ashley-Cooper"; Team = australia; Type = Back; Status = OriginalSquad }
    let horneRob = { Name = "Rob Horne"; Team = australia; Type = Back; Status = OriginalSquad }
    let mitchellDrew = { Name = "Drew Mitchell"; Team = australia; Type = Back; Status = OriginalSquad }
    let speightHenry = { Name = "Henry Speight"; Team = australia; Type = Back; Status = OriginalSquad }
    let tomaneJoe = { Name = "Joe Tomane"; Team = australia; Type = Back; Status = OriginalSquad }
    let folauIsrael = { Name = "Israel Folau"; Team = australia; Type = Back; Status = OriginalSquad }

    let australiaSquad = { Team = australia
                           Players = [ mooreStephen; polotaNauTatafu; holmesGreg; kepuSekope; sioScott; slipperJames; smithToby
                                       douglasKane; mummDean; simmonsRob; skeltonWill; fardyScott; hooperMichael; mcMahonSean
                                       pocockDavid; mcCalmanBen; paluWycliff; geniaWill; phippsNick; cooperQuade; foleyBernard
                                       bealeKurtley; giteauMatt; kuridraniTevita; toomuaMatt; ashleyCooperAdam; horneRob
                                       mitchellDrew; speightHenry; tomaneJoe; folauIsrael ] }

    let france = { Name = "France"; Status = Active; Seeding = Some 4; Coach = "Philippe Saint-André" }

    let guiradoGuilhem = { Name = "Guilhem Guirado"; Team = france; Type = Forward; Status = OriginalSquad }
    let kayserBenjamin = { Name = "Benjamin Kayser"; Team = france; Type = Forward; Status = OriginalSquad }
    let szarzewskiDimitri = { Name = "Dimitri Szarzewski"; Team = france; Type = Forward; Status = OriginalSquad }
    let atoniaUini = { Name = "Uini Atonio"; Team = france; Type = Forward; Status = OriginalSquad }
    let benArousEddy = { Name = "Eddy Ben Arous"; Team = france; Type = Forward; Status = OriginalSquad }
    let debatyVincent = { Name = "Vincent Debaty"; Team = france; Type = Forward; Status = OriginalSquad }
    let masNicolas = { Name = "Nicolas Mas"; Team = france; Type = Forward; Status = OriginalSquad }
    let slimaniRabah = { Name = "Rabah Slimani"; Team = france; Type = Forward; Status = OriginalSquad }
    let flanquartAlexandre = { Name = "Alexandre Flanquart"; Team = france; Type = Forward; Status = OriginalSquad }
    let maestriYoann = { Name = "Yoann Maestri"; Team = france; Type = Forward; Status = OriginalSquad }
    let papePascal = { Name = "Pascal Papé"; Team = france; Type = Forward; Status = OriginalSquad }
    let dusautoirThierry = { Name = "Thierry Dusautoir"; Team = france; Type = Forward; Status = OriginalSquad }
    let leRouxBernard = { Name = "Bernard Le Roux"; Team = france; Type = Forward; Status = OriginalSquad }
    let nyangaYannick = { Name = "Yannick Nyanga"; Team = france; Type = Forward; Status = OriginalSquad }
    let ouedraogoFulgence = { Name = "Fulgence Ouedraogo"; Team = france; Type = Forward; Status = OriginalSquad }
    let choulyDamien = { Name = "Damien Chouly"; Team = france; Type = Forward; Status = OriginalSquad }
    let picamolesLouis = { Name = "Louis Picamoles"; Team = france; Type = Forward; Status = OriginalSquad }
    let kockottRory = { Name = "Rory Kockott"; Team = france; Type = Back; Status = OriginalSquad }
    let parraMorgan = { Name = "Morgan Parra"; Team = france; Type = Back; Status = OriginalSquad }
    let tillousBordeSebastien = { Name = "Sébastien Tillous-Borde"; Team = france; Type = Back; Status = OriginalSquad }
    let michalakFrederic = { Name = "Frédéric Michalak"; Team = france; Type = Back; Status = OriginalSquad }
    let talesRemi = { Name = "Rémi Tales"; Team = france; Type = Back; Status = OriginalSquad }
    let bastareaudMathieu = { Name = "Mathieu Bastareaud"; Team = france; Type = Back; Status = OriginalSquad }
    let dumoulinAlexandre = { Name = "Alexandre Dumoulin"; Team = france; Type = Back; Status = OriginalSquad }
    let fickouGael = { Name = "Gaël Fickou"; Team = france; Type = Back; Status = OriginalSquad }
    let fofanaWesley = { Name = "Wesley Fofana"; Team = france; Type = Back; Status = OriginalSquad }
    let guitouneSofiane = { Name = "Sofiane Guitoune"; Team = france; Type = Back; Status = OriginalSquad }
    let hugetYoann = { Name = "Yoann Huget"; Team = france; Type = Back; Status = OriginalSquad }
    let nakaitaciNoa = { Name = "Noa Nakaitaci"; Team = france; Type = Back; Status = OriginalSquad }
    let dulinBrice = { Name = "Brice Dulin"; Team = france; Type = Back; Status = OriginalSquad }
    let speddingScott = { Name = "Scott Spedding"; Team = france; Type = Back; Status = OriginalSquad }

    let franceSquad = { Team = france
                        Players = [ guiradoGuilhem; kayserBenjamin; szarzewskiDimitri; atoniaUini; benArousEddy; debatyVincent; masNicolas
                                    slimaniRabah; flanquartAlexandre; maestriYoann; papePascal; dusautoirThierry; leRouxBernard
                                    nyangaYannick; ouedraogoFulgence; choulyDamien; picamolesLouis; kockottRory; parraMorgan
                                    tillousBordeSebastien; michalakFrederic; talesRemi; bastareaudMathieu; dumoulinAlexandre; fickouGael
                                    fofanaWesley; guitouneSofiane; hugetYoann; nakaitaciNoa; dulinBrice; speddingScott ] }

    let england = { Name = "England"; Status = Active; Seeding = Some 5; Coach = "Stuart Lancaster" }

    let georgeJamie = { Name = "Jamie George"; Team = england; Type = Forward; Status = OriginalSquad }
    let webberRob = { Name = "Rob Webber"; Team = england; Type = Forward; Status = OriginalSquad }
    let youngsTom = { Name = "Tom Youngs"; Team = england; Type = Forward; Status = OriginalSquad }
    let brookesKieran = { Name = "Kieran Brookes"; Team = england; Type = Forward; Status = OriginalSquad }
    let coleDan = { Name = "Dan Cole"; Team = england; Type = Forward; Status = OriginalSquad }
    let marlerJoe = { Name = "Joe Marler"; Team = england; Type = Forward; Status = OriginalSquad }
    let vunipolaMako = { Name = "Mako Vunipola"; Team = england; Type = Forward; Status = OriginalSquad }
    let wilsonDavid = { Name = "David Wilson"; Team = england; Type = Forward; Status = OriginalSquad }
    let kruisGeorge = { Name = "George Kruis"; Team = england; Type = Forward; Status = OriginalSquad }
    let launchburyJoe = { Name = "Joe Launchbury"; Team = england; Type = Forward; Status = OriginalSquad }
    let lawesCourtney = { Name = "Courtney Lawes"; Team = england; Type = Forward; Status = OriginalSquad }
    let parlingGeoff = { Name = "Geoff Parling"; Team = england; Type = Forward; Status = OriginalSquad }
    let haskellJames = { Name = "James Haskell"; Team = england; Type = Forward; Status = OriginalSquad }
    let robshawChris = { Name = "Chris Robshaw"; Team = england; Type = Forward; Status = OriginalSquad }
    let woodTom = { Name = "Tom Wood"; Team = england; Type = Forward; Status = OriginalSquad }
    let morganBen = { Name = "Ben Morgan"; Team = england; Type = Forward; Status = OriginalSquad }
    let vunipolaBilly = { Name = "Billy Vunipola"; Team = england; Type = Forward; Status = OriginalSquad }
    let careDanny = { Name = "Danny Care"; Team = england; Type = Back; Status = OriginalSquad }
    let wigglesworthRichard = { Name = "Richard Wigglesworth"; Team = england; Type = Back; Status = OriginalSquad }
    let youngsBen = { Name = "Ben Youngs"; Team = england; Type = Back; Status = OriginalSquad }
    let farrellOwen = { Name = "Owen Farrell"; Team = england; Type = Back; Status = OriginalSquad }
    let fordGeorge = { Name = "George Ford"; Team = england; Type = Back; Status = OriginalSquad }
    let barrittBrad = { Name = "Brad Barritt"; Team = england; Type = Back; Status = OriginalSquad }
    let burgessSam = { Name = "Sam Burgess"; Team = england; Type = Back; Status = OriginalSquad }
    let josephJonathan = { Name = "Jonathan Joseph"; Team = england; Type = Back; Status = OriginalSquad }
    let sladeHenry = { Name = "Henry Slade"; Team = england; Type = Back; Status = OriginalSquad }
    let mayJonny = { Name = "Jonny May"; Team = england; Type = Back; Status = OriginalSquad }
    let nowellJack = { Name = "Jack Nowell"; Team = england; Type = Back; Status = OriginalSquad }
    let watsonAnthony = { Name = "Anthony Watson"; Team = england; Type = Back; Status = OriginalSquad }
    let brownMike = { Name = "Mike Brown"; Team = england; Type = Back; Status = OriginalSquad }
    let goodeAlex = { Name = "Alex Goode"; Team = england; Type = Back; Status = OriginalSquad }

    let englandSquad = { Team = england
                         Players = [ georgeJamie; webberRob; youngsTom; brookesKieran; coleDan; marlerJoe; vunipolaMako; wilsonDavid
                                     kruisGeorge; launchburyJoe; lawesCourtney; parlingGeoff; haskellJames; robshawChris; woodTom
                                     morganBen; vunipolaBilly; careDanny; wigglesworthRichard; youngsBen; farrellOwen; fordGeorge
                                     barrittBrad; burgessSam; josephJonathan; sladeHenry; mayJonny; nowellJack; watsonAnthony; brownMike
                                     goodeAlex ] }

    let ireland = { Name = "Ireland"; Status = Active; Seeding = Some 6; Coach = "Joe Schmidt" }

    let bestRory = { Name = "Rory Best"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let croninSean = { Name = "Sean Cronin"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let straussRichardt = { Name = "Richardt Strauss"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let whiteNathan = { Name = "Nathan White"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let furlongTadhg = { Name = "Tadhg Furlong"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let healyCian = { Name = "Cian Healy"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let mcGrathJack = { Name = "Jack McGrath"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let rossMike = { Name = "Mike Ross"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let hendersonIain = { Name = "Iain Henderson"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let o'ConnellPaul = { Name = "Paul O'Connell"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let ryanDonnacha = { Name = "Donnacha Ryan"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let tonerDevin = { Name = "Devin Toner"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let henryChris = { Name = "Chris Henry"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let murphyJordi = { Name = "Jordi Murphy"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let o'BrienSean = { Name = "Seán O'Brien"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let o'MahonyPeter = { Name = "Peter O'Mahony"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let heaslipJamie = { Name = "Jamie Heaslip"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let murrayConor = { Name = "Conor Murray"; Team = ireland; Type = Back; Status = OriginalSquad }
    let reddanEoin = { Name = "Eoin Reddan"; Team = ireland; Type = Back; Status = OriginalSquad }
    let jacksonPaddy = { Name = "Paddy Jackson"; Team = ireland; Type = Back; Status = OriginalSquad }
    let madiganIan = { Name = "Ian Madigan"; Team = ireland; Type = Back; Status = OriginalSquad }
    let sextonJonathan = { Name = "Jonathan Sexton"; Team = ireland; Type = Back; Status = OriginalSquad }
    let caveDarren = { Name = "Darren Cave"; Team = ireland; Type = Back; Status = OriginalSquad }
    let earlsKeith = { Name = "Keith Earls"; Team = ireland; Type = Back; Status = OriginalSquad }
    let henshawRobbie = { Name = "Robbie Henshaw"; Team = ireland; Type = Back; Status = OriginalSquad }
    let payneJared = { Name = "Jared Payne"; Team = ireland; Type = Back; Status = OriginalSquad }
    let boweTommy = { Name = "Tommy Bowe"; Team = ireland; Type = Back; Status = OriginalSquad }
    let fitzgeraldLuke = { Name = "Luke Fitzgerald"; Team = ireland; Type = Back; Status = OriginalSquad }
    let kearneyDavid = { Name = "David Kearney"; Team = ireland; Type = Back; Status = OriginalSquad }
    let zeboSimon = { Name = "Simon Zebo"; Team = ireland; Type = Back; Status = OriginalSquad }
    let kearneyRob = { Name = "Rob Kearney"; Team = ireland; Type = Back; Status = OriginalSquad }

    let irelandSquad = { Team = ireland
                         Players = [ bestRory; croninSean; straussRichardt; whiteNathan; furlongTadhg; healyCian; mcGrathJack; rossMike
                                     hendersonIain; o'ConnellPaul; ryanDonnacha; tonerDevin; henryChris; murphyJordi; o'BrienSean
                                     o'MahonyPeter; heaslipJamie; murrayConor; reddanEoin; jacksonPaddy; madiganIan; sextonJonathan
                                     caveDarren; earlsKeith; henshawRobbie; payneJared; boweTommy; fitzgeraldLuke; kearneyDavid; zeboSimon
                                     kearneyRob ] }

    let samoa = { Name = "Samoa"; Status = Active; Seeding = Some 7; Coach = "Stephan Betham" }

    let aveiOle = { Name = "Ole Avei"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let leiatauaManu = { Name = "Manu Leiataua"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let matu'uMotu = { Name = "Motu Matu'u"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let afatiaViliamu = { Name = "Viliamu Afatia"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let greyJake = { Name = "Jake Grey"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let johnstonCensus = { Name = "Census Johnston"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let pereniseAnthony = { Name = "Anthony Perenise"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let taulafoSakaria = { Name = "Sakaria Taulafo"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let pauloFilo = { Name = "Filo Paulo"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let tekoriJoe = { Name = "Joe Tekori"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let thompsonKane = { Name = "Kane Thompson"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let fa'asavaluMaurie = { Name = "Maurie Fa'asavalu"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let faosilivaAlafoti = { Name = "Alafoti Faosiliva"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let lamJack = { Name = "Jack Lam"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let levaveFaifili = { Name = "Faifili Levave"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let treviranusOfisa = { Name = "Ofisa Treviranus"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let ioaneTJ = { Name = "TJ Ioane"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let tuilagiSaneleVavae = { Name = "Sanele Vavae Tuilagi"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let afemaiVavao = { Name = "Vavao Afemai"; Team = samoa; Type = Back; Status = OriginalSquad }
    let fotuali'iKahn = { Name = "Kahn Fotuali'i"; Team = samoa; Type = Back; Status = OriginalSquad }
    let fa'apalePatrick = { Name = "Patrick Fa’apale"; Team = samoa; Type = Back; Status = OriginalSquad }
    let pisiTusi = { Name = "Tusi Pisi"; Team = samoa; Type = Back; Status = OriginalSquad }
    let stanleyMichael = { Name = "Michael Stanley"; Team = samoa; Type = Back; Status = OriginalSquad }
    let leeLoRey = { Name = "Rey Lee-Lo"; Team = samoa; Type = Back; Status = OriginalSquad }
    let leotaJohnny = { Name = "Johnny Leota"; Team = samoa; Type = Back; Status = OriginalSquad }
    let perezPaul = { Name = "Paul Perez"; Team = samoa; Type = Back; Status = OriginalSquad }
    let pisiGeorge = { Name = "George Pisi"; Team = samoa; Type = Back; Status = OriginalSquad }
    let autagavaiaFa'atoina = { Name = "Fa'atoina Autagavaia"; Team = samoa; Type = Back; Status = OriginalSquad }
    let pisiKen = { Name = "Ken Pisi"; Team = samoa; Type = Back; Status = OriginalSquad }
    let tuilagiAlesana = { Name = "Alesana Tuilagi"; Team = samoa; Type = Back; Status = OriginalSquad }
    let nanaiWilliamsTim = { Name = "Tim Nanai-Williams"; Team = samoa; Type = Back; Status = OriginalSquad }

    let samoaSquad = { Team = samoa
                       Players = [ aveiOle; leiatauaManu; matu'uMotu; afatiaViliamu; greyJake; johnstonCensus; pereniseAnthony
                                   taulafoSakaria; pauloFilo; tekoriJoe; thompsonKane; fa'asavaluMaurie; faosilivaAlafoti; lamJack
                                   levaveFaifili; treviranusOfisa; ioaneTJ; tuilagiSaneleVavae; afemaiVavao; fotuali'iKahn
                                   fa'apalePatrick; pisiTusi; stanleyMichael; leeLoRey; leotaJohnny; perezPaul; pisiGeorge
                                   autagavaiaFa'atoina; pisiKen; tuilagiAlesana; nanaiWilliamsTim ] }

    let argentina = { Name = "Argentina"; Status = Active; Seeding = Some 8; Coach = "Daniel Hourcade" }

    let creevyAgustin = { Name = "Agustín Creevy"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let montoyaJulian = { Name = "Julián Montoya"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let ayerzaMarcos = { Name = "Marcos Ayerza"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let orlandiJuanPablo = { Name = "Juan Pablo Orlandi"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let herreraRamiro = { Name = "Ramiro Herrera"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let pazLucasNoguera = { Name = "Lucas Noguera Paz"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let chaparroNahuelTetaz = { Name = "Nahuel Tetaz Chaparro"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let alemannoMatias = { Name = "Matías Alemanno"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let galarzaMariano = { Name = "Mariano Galarza"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let lavaniniTomas = { Name = "Tomás Lavanini"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let pagadizabalGuidoPetti = { Name = "Guido Petti Pagadizábal"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let lobbeJuanMartinFernandez = { Name = "Juan Martín Fernández Lobbe"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let leguizamonJuanManuel = { Name = "Juan Manuel Leguizamón"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let materaPablo = { Name = "Pablo Matera"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let desioJavierOrtega = { Name = "Javier Ortega Desio"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let isaFacundo = { Name = "Facundo Isa"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let senatoreLeonardo = { Name = "Leonardo Senatore"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let cubelliTomas = { Name = "Tomás Cubelli"; Team = argentina; Type = Back; Status = OriginalSquad }
    let landajoMartin = { Name = "Martín Landajo"; Team = argentina; Type = Back; Status = OriginalSquad }
    let iglesiasSantiagoGonzalez = { Name = "Santiago González Iglesias"; Team = argentina; Type = Back; Status = OriginalSquad }
    let sanchezNicolas = { Name = "Nicolás Sánchez"; Team = argentina; Type = Back; Status = OriginalSquad }
    let boschMarcelo = { Name = "Marcelo Bosch"; Team = argentina; Type = Back; Status = OriginalSquad }
    let delaFuenteJeronimo = { Name = "Jerónimo de la Fuente"; Team = argentina; Type = Back; Status = OriginalSquad }
    let hernandezJuanMartin = { Name = "Juan Martín Hernández"; Team = argentina; Type = Back; Status = OriginalSquad }
    let moronoMatias = { Name = "Matías Moroni"; Team = argentina; Type = Back; Status = OriginalSquad }
    let socinoJuanPablo = { Name = "Juan Pablo Socino"; Team = argentina; Type = Back; Status = OriginalSquad }
    let agullaHoracio = { Name = "Horacio Agulla"; Team = argentina; Type = Back; Status = OriginalSquad }
    let corderoSantiago = { Name = "Santiago Cordero"; Team = argentina; Type = Back; Status = OriginalSquad }
    let imhoffJuan = { Name = "Juan Imhoff"; Team = argentina; Type = Back; Status = OriginalSquad }
    let amorosinoLucasGonzalez = { Name = "Lucas González Amorosino"; Team = argentina; Type = Back; Status = OriginalSquad }
    let tuculetJoaquin = { Name = "Joaquín Tuculet"; Team = argentina; Type = Back; Status = OriginalSquad }

    let argentinaSquad = { Team = argentina
                           Players = [ creevyAgustin; montoyaJulian; ayerzaMarcos; orlandiJuanPablo; herreraRamiro; pazLucasNoguera
                                       chaparroNahuelTetaz; alemannoMatias; galarzaMariano; lavaniniTomas; pagadizabalGuidoPetti
                                       lobbeJuanMartinFernandez; leguizamonJuanManuel; materaPablo; desioJavierOrtega; isaFacundo
                                       senatoreLeonardo; cubelliTomas; landajoMartin; iglesiasSantiagoGonzalez; sanchezNicolas; boschMarcelo
                                       delaFuenteJeronimo; hernandezJuanMartin; moronoMatias; socinoJuanPablo; agullaHoracio
                                       corderoSantiago; imhoffJuan; amorosinoLucasGonzalez; tuculetJoaquin ] }

    (* TEMP [NMB]: test data...
    let wales = { Name = "Wales"; Status = Active; Seeding = Some 9; Coach = "Warren Gatland" }

    let baldwinScott = { Name = "Scott Baldwin"; Team = wales; Type = Forward; Status = OriginalSquad }
    let owensKen = { Name = "Ken Owens"; Team = wales; Type = Forward; Status = OriginalSquad }
    let francisTomas = { Name = "Tomas Francis"; Team = wales; Type = Forward; Status = OriginalSquad }
    let jamesPaul = { Name = "Paul James"; Team = wales; Type = Forward; Status = OriginalSquad }
    let jarvisAaron = { Name = "Aaron Jarvis"; Team = wales; Type = Forward; Status = OriginalSquad }
    let jenkinsGethin = { Name = "Gethin Jenkins"; Team = wales; Type = Forward; Status = OriginalSquad }
    let leeSamson = { Name = "Samson Lee"; Team = wales; Type = Forward; Status = OriginalSquad }
    let ballJake = { Name = "Jake Ball"; Team = wales; Type = Forward; Status = OriginalSquad }
    let charterisLuke = { Name = "Luke Charteris"; Team = wales; Type = Forward; Status = OriginalSquad }
    let daviesBradley = { Name = "Bradley Davies"; Team = wales; Type = Forward; Status = OriginalSquad }
    let dayDominic = { Name = "Dominic Day"; Team = wales; Type = Forward; Status = OriginalSquad }
    let jonesAlunWyn = { Name = "Alun Wyn Jones"; Team = wales; Type = Forward; Status = OriginalSquad }
    let kingJames = { Name = "James King"; Team = wales; Type = Forward; Status = OriginalSquad }
    let lydiateDan = { Name = "Dan Lydiate"; Team = wales; Type = Forward; Status = OriginalSquad }
    let warburtonSam = { Name = "Sam Warburton"; Team = wales; Type = Forward; Status = OriginalSquad }
    let faletauTaulupe = { Name = "Taulupe Faletau"; Team = wales; Type = Forward; Status = OriginalSquad }
    let daviesGareth = { Name = "Gareth Davies"; Team = wales; Type = Back; Status = OriginalSquad }
    let phillipsMike = { Name = "Mike Phillips"; Team = wales; Type = Back; Status = OriginalSquad }
    let williamsLloyd = { Name = "Lloyd Williams"; Team = wales; Type = Back; Status = OriginalSquad }
    let biggarDan = { Name = "Dan Biggar"; Team = wales; Type = Back; Status = OriginalSquad }
    let priestlandRhys = { Name = "Rhys Priestland"; Team = wales; Type = Back; Status = OriginalSquad }
    let allenCory = { Name = "Cory Allen"; Team = wales; Type = Back; Status = OriginalSquad }
    let robertsJamie = { Name = "Jamie Roberts"; Team = wales; Type = Back; Status = OriginalSquad }
    let williamsScott = { Name = "Scott Williams"; Team = wales; Type = Back; Status = OriginalSquad }
    let amosHallam = { Name = "Hallam Amos"; Team = wales; Type = Back; Status = OriginalSquad }
    let cuthbertAlex = { Name = "Alex Cuthbert"; Team = wales; Type = Back; Status = OriginalSquad }
    let northGeorge = { Name = "George North"; Team = wales; Type = Back; Status = OriginalSquad }
    let walkerEli = { Name = "Eli Walker"; Team = wales; Type = Back; Status = OriginalSquad }
    let williamsLiam = { Name = "Liam Williams"; Team = wales; Type = Back; Status = OriginalSquad }
    let morganMatthew = { Name = "Matthew Morgan"; Team = wales; Type = Back; Status = OriginalSquad }
    let tipuricJustin = { Name = "Justin Tipuric"; Team = wales; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 9, 12))) }
    let theEngineIvor = { Name = "Ivor the Engine"; Team = wales; Type = Forward; Status = Replacement (Some (DateTime (2015, 9, 12))) }

    let walesSquad = { Team = wales
                       Players = [ baldwinScott; owensKen; francisTomas; jamesPaul; jarvisAaron; jenkinsGethin; leeSamson; ballJake
                                   charterisLuke; daviesBradley; dayDominic; jonesAlunWyn; kingJames; lydiateDan; warburtonSam
                                   faletauTaulupe; daviesGareth; phillipsMike; williamsLloyd; biggarDan; priestlandRhys; allenCory
                                   robertsJamie; williamsScott; amosHallam; cuthbertAlex; northGeorge; walkerEli; williamsLiam
                                   morganMatthew; tipuricJustin; theEngineIvor ] } *)

    (* TEMP [NMB]... *)
    let wales = { Name = "Wales"; Status = Active; Seeding = Some 9; Coach = "Warren Gatland" }

    let baldwinScott = { Name = "Scott Baldwin"; Team = wales; Type = Forward; Status = OriginalSquad }
    let owensKen = { Name = "Ken Owens"; Team = wales; Type = Forward; Status = OriginalSquad }
    let francisTomas = { Name = "Tomas Francis"; Team = wales; Type = Forward; Status = OriginalSquad }
    let jamesPaul = { Name = "Paul James"; Team = wales; Type = Forward; Status = OriginalSquad }
    let jarvisAaron = { Name = "Aaron Jarvis"; Team = wales; Type = Forward; Status = OriginalSquad }
    let jenkinsGethin = { Name = "Gethin Jenkins"; Team = wales; Type = Forward; Status = OriginalSquad }
    let leeSamson = { Name = "Samson Lee"; Team = wales; Type = Forward; Status = OriginalSquad }
    let ballJake = { Name = "Jake Ball"; Team = wales; Type = Forward; Status = OriginalSquad }
    let charterisLuke = { Name = "Luke Charteris"; Team = wales; Type = Forward; Status = OriginalSquad }
    let daviesBradley = { Name = "Bradley Davies"; Team = wales; Type = Forward; Status = OriginalSquad }
    let dayDominic = { Name = "Dominic Day"; Team = wales; Type = Forward; Status = OriginalSquad }
    let jonesAlunWyn = { Name = "Alun Wyn Jones"; Team = wales; Type = Forward; Status = OriginalSquad }
    let kingJames = { Name = "James King"; Team = wales; Type = Forward; Status = OriginalSquad }
    let lydiateDan = { Name = "Dan Lydiate"; Team = wales; Type = Forward; Status = OriginalSquad }
    let tipuricJustin = { Name = "Justin Tipuric"; Team = wales; Type = Forward; Status = OriginalSquad }
    let moriartyRoss = { Name = "Ross Moriarty"; Team = wales; Type = Forward; Status = Replacement (Some (DateTime (2015, 9, 14))) }
    let warburtonSam = { Name = "Sam Warburton"; Team = wales; Type = Forward; Status = OriginalSquad }
    let faletauTaulupe = { Name = "Taulupe Faletau"; Team = wales; Type = Forward; Status = OriginalSquad }
    let daviesGareth = { Name = "Gareth Davies"; Team = wales; Type = Back; Status = OriginalSquad }
    let phillipsMike = { Name = "Mike Phillips"; Team = wales; Type = Back; Status = OriginalSquad }
    let williamsLloyd = { Name = "Lloyd Williams"; Team = wales; Type = Back; Status = OriginalSquad }
    let biggarDan = { Name = "Dan Biggar"; Team = wales; Type = Back; Status = OriginalSquad }
    let priestlandRhys = { Name = "Rhys Priestland"; Team = wales; Type = Back; Status = OriginalSquad }
    let allenCory = { Name = "Cory Allen"; Team = wales; Type = Back; Status = OriginalSquad }
    let robertsJamie = { Name = "Jamie Roberts"; Team = wales; Type = Back; Status = OriginalSquad }
    let williamsScott = { Name = "Scott Williams"; Team = wales; Type = Back; Status = OriginalSquad }
    let amosHallam = { Name = "Hallam Amos"; Team = wales; Type = Back; Status = OriginalSquad }
    let cuthbertAlex = { Name = "Alex Cuthbert"; Team = wales; Type = Back; Status = OriginalSquad }
    let northGeorge = { Name = "George North"; Team = wales; Type = Back; Status = OriginalSquad }
    let walkerEli = { Name = "Eli Walker"; Team = wales; Type = Back; Status = Withdrawn (Some (DateTime (2015, 9, 14))) }
    let williamsLiam = { Name = "Liam Williams"; Team = wales; Type = Back; Status = OriginalSquad }
    let morganMatthew = { Name = "Matthew Morgan"; Team = wales; Type = Back; Status = OriginalSquad }

    let walesSquad = { Team = wales
                       Players = [ baldwinScott; owensKen; francisTomas; jamesPaul; jarvisAaron; jenkinsGethin; leeSamson; ballJake
                                   charterisLuke; daviesBradley; dayDominic; jonesAlunWyn; kingJames; lydiateDan; tipuricJustin
                                   moriartyRoss; warburtonSam; faletauTaulupe; daviesGareth; phillipsMike; williamsLloyd; biggarDan
                                   priestlandRhys; allenCory; robertsJamie; williamsScott; amosHallam; cuthbertAlex; northGeorge
                                   walkerEli; williamsLiam; morganMatthew ] }

    let italy = { Name = "Italy"; Status = Active; Seeding = Some 10; Coach = "Jacques Brunel" }

    let ghiraldiniLeonardo = { Name = "Leonardo Ghiraldini"; Team = italy; Type = Forward; Status = OriginalSquad }
    let giazzonDavide = { Name = "Davide Giazzon"; Team = italy; Type = Forward; Status = OriginalSquad }
    let maniciAndrea = { Name = "Andrea Manici"; Team = italy; Type = Forward; Status = OriginalSquad }
    let agueroMatias = { Name = "Matías Agüero"; Team = italy; Type = Forward; Status = OriginalSquad }
    let castrogiovanniMartin = { Name = "Martin Castrogiovanni"; Team = italy; Type = Forward; Status = OriginalSquad }
    let chistoliniDario = { Name = "Dario Chistolini"; Team = italy; Type = Forward; Status = OriginalSquad }
    let cittadiniLorenzo = { Name = "Lorenzo Cittadini"; Team = italy; Type = Forward; Status = OriginalSquad }
    let rizzoMichele = { Name = "Michele Rizzo"; Team = italy; Type = Forward; Status = OriginalSquad }
    let bernaboValerio = { Name = "Valerio Bernabò"; Team = italy; Type = Forward; Status = OriginalSquad }
    let furnoJoshua = { Name = "Joshua Furno"; Team = italy; Type = Forward; Status = OriginalSquad }
    let fuserMarco = { Name = "Marco Fuser"; Team = italy; Type = Forward; Status = OriginalSquad }
    let geldenhuysQuintin = { Name = "Quintin Geldenhuys"; Team = italy; Type = Forward; Status = OriginalSquad }
    let bergamascoMauro = { Name = "Mauro Bergamasco"; Team = italy; Type = Forward; Status = OriginalSquad }
    let favaroSimone = { Name = "Simone Favaro"; Team = italy; Type = Forward; Status = OriginalSquad }
    let mintoFrancesco = { Name = "Francesco Minto"; Team = italy; Type = Forward; Status = OriginalSquad }
    let vunisaSamuela = { Name = "Samuela Vunisa"; Team = italy; Type = Forward; Status = OriginalSquad }
    let zanniAlessandro = { Name = "Alessandro Zanni"; Team = italy; Type = Forward; Status = OriginalSquad }
    let parisseSergio = { Name = "Sergio Parisse"; Team = italy; Type = Forward; Status = OriginalSquad }
    let goriEdoardo = { Name = "Edoardo Gori"; Team = italy; Type = Back; Status = OriginalSquad }
    let palazzaniGuglielmo = { Name = "Guglielmo Palazzani"; Team = italy; Type = Back; Status = OriginalSquad }
    let violiMarcello = { Name = "Marcello Violi"; Team = italy; Type = Back; Status = OriginalSquad }
    let allanTommaso = { Name = "Tommaso Allan"; Team = italy; Type = Back; Status = OriginalSquad }
    let cannaCarlo = { Name = "Carlo Canna"; Team = italy; Type = Back; Status = OriginalSquad }
    let bacchinEnrico = { Name = "Enrico Bacchin"; Team = italy; Type = Back; Status = OriginalSquad }
    let benvenutiTommaso = { Name = "Tommaso Benvenuti"; Team = italy; Type = Back; Status = OriginalSquad }
    let campagnaroMichele = { Name = "Michele Campagnaro"; Team = italy; Type = Back; Status = OriginalSquad }
    let garciaGonzalo = { Name = "Gonzalo Garcia"; Team = italy; Type = Back; Status = OriginalSquad }
    let sartoLeonardo = { Name = "Leonardo Sarto"; Team = italy; Type = Back; Status = OriginalSquad }
    let vendittiGiovanbattista = { Name = "Giovanbattista Venditti"; Team = italy; Type = Back; Status = OriginalSquad }
    let masiAndrea = { Name = "Andrea Masi"; Team = italy; Type = Back; Status = OriginalSquad }
    let mcLeanLuke = { Name = "Luke McLean"; Team = italy; Type = Back; Status = OriginalSquad }

    let italySquad = { Team = italy
                       Players = [ ghiraldiniLeonardo; giazzonDavide; maniciAndrea; agueroMatias; castrogiovanniMartin; chistoliniDario
                                   cittadiniLorenzo; rizzoMichele; bernaboValerio; furnoJoshua; fuserMarco; geldenhuysQuintin
                                   bergamascoMauro; favaroSimone; mintoFrancesco; vunisaSamuela; zanniAlessandro; parisseSergio; goriEdoardo
                                   palazzaniGuglielmo; violiMarcello; allanTommaso; cannaCarlo; bacchinEnrico; benvenutiTommaso
                                   campagnaroMichele; garciaGonzalo; sartoLeonardo; vendittiGiovanbattista; masiAndrea; mcLeanLuke ] }

    let tonga = { Name = "Tonga"; Status = Active; Seeding = Some 11; Coach = "Mana Otai" }

    let lutuiAleki = { Name = "Aleki Lutui"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let ngauamoPaul = { Name = "Paul Ngauamo"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let taioneElvis = { Name = "Elvis Taione"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let aulikaHalani = { Name = "Halani Aulika"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let mailauTevita = { Name = "Tevita Mailau"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let puafisiSila = { Name = "Sila Puafisi"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let taumaloloSona = { Name = "Sona Taumalolo"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let tonga'uihaSoane = { Name = "Soane Tonga'uiha"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let kolo'ofaiUili = { Name = "Uili Kolo'ofai"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let lokotuiTukulua = { Name = "Tukulua Lokotui"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let mafiSteve = { Name = "Steve Mafi"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let tuineauJoe = { Name = "Joe Tuineau"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let kalamafoniSione = { Name = "Sione Kalamafoni"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let latuNili = { Name = "Nili Latu "; Team = tonga; Type = Forward; Status = OriginalSquad }
    let ramJack = { Name = "Jack Ram"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let tPoleHale = { Name = "Hale T-Pole"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let fonuaOpeti = { Name = "Opeti Fonua"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let ma'afuViliami = { Name = "Viliami Ma'afu"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let fisilauSamisoni = { Name = "Samisoni Fisilau"; Team = tonga; Type = Back; Status = OriginalSquad }
    let ma'akeSosefo = { Name = "Sosefo Ma’ake"; Team = tonga; Type = Back; Status = OriginalSquad }
    let takaluaSonatane = { Name = "Sonatane Takulua"; Team = tonga; Type = Back; Status = OriginalSquad }
    let fositaLatiume = { Name = "Latiume Fosita"; Team = tonga; Type = Back; Status = OriginalSquad }
    let morathKurt = { Name = "Kurt Morath"; Team = tonga; Type = Back; Status = OriginalSquad }
    let piukalaSione = { Name = "Sione Piukala"; Team = tonga; Type = Back; Status = OriginalSquad }
    let piutauSiale = { Name = "Siale Piutau"; Team = tonga; Type = Back; Status = OriginalSquad }
    let tahitu'aViliami = { Name = "Viliami Tahitu'a"; Team = tonga; Type = Back; Status = OriginalSquad }
    let halaifonuaDavid = { Name = "David Halaifonua"; Team = tonga; Type = Back; Status = OriginalSquad }
    let heluWilliam = { Name = "William Helu"; Team = tonga; Type = Back; Status = OriginalSquad }
    let vainikoloFetu'u = { Name = "Fetu'u Vainikolo"; Team = tonga; Type = Back; Status = OriginalSquad }
    let veainuTelusa = { Name = "Telusa Veainu"; Team = tonga; Type = Back; Status = OriginalSquad }
    let liloVunga = { Name = "Vunga Lilo"; Team = tonga; Type = Back; Status = OriginalSquad }

    let tongaSquad = { Team = tonga
                       Players = [ lutuiAleki; ngauamoPaul; taioneElvis; aulikaHalani; mailauTevita; puafisiSila; taumaloloSona
                                   tonga'uihaSoane; kolo'ofaiUili; lokotuiTukulua; mafiSteve; tuineauJoe; kalamafoniSione; latuNili
                                   ramJack; tPoleHale; fonuaOpeti; ma'afuViliami; fisilauSamisoni; ma'akeSosefo; takaluaSonatane
                                   fositaLatiume; morathKurt; piukalaSione; piutauSiale; tahitu'aViliami; halaifonuaDavid; heluWilliam
                                   vainikoloFetu'u; veainuTelusa; liloVunga ] }

    let scotland = { Name = "Scotland"; Status = Active; Seeding = Some 12; Coach = "Vern Cotter" }

    let brownFraser = { Name = "Fraser Brown"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let bryceKevin = { Name = "Kevin Bryce"; Team = scotland; Type = Forward; Status = Replacement (Some (DateTime (2015, 9, 14))) }
    let fordRoss = { Name = "Ross Ford"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let mcInallyStuart = { Name = "Stuart McInally"; Team = scotland; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 9, 14))) }
    let dickinsonAlasdair = { Name = "Alasdair Dickinson"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let grantRyan = { Name = "Ryan Grant"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let nelWP = { Name = "WP Nel"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let reidGordon = { Name = "Gordon Reid"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let welshJon = { Name = "Jon Welsh"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let gilchristGrant = { Name = "Grant Gilchrist"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let grayJonny = { Name = "Jonny Gray"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let grayRichie = { Name = "Richie Gray"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let swinsonTim = { Name = "Tim Swinson"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let hardieJohn = { Name = "John Hardie"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let strokoschAlasdair = { Name = "Alasdair Strokosch"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let wilsonRyan = { Name = "Ryan Wilson"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let dentonDavid = { Name = "David Denton"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let straussJosh = { Name = "Josh Strauss"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let hidalgoClyneSam = { Name = "Sam Hidalgo-Clyne"; Team = scotland; Type = Back; Status = OriginalSquad }
    let laidlawGreig = { Name = "Greig Laidlaw"; Team = scotland; Type = Back; Status = OriginalSquad }
    let pyrgosHenry = { Name = "Henry Pyrgos"; Team = scotland; Type = Back; Status = OriginalSquad }
    let russellFinn = { Name = "Finn Russell"; Team = scotland; Type = Back; Status = OriginalSquad }
    let weirDuncan = { Name = "Duncan Weir"; Team = scotland; Type = Back; Status = OriginalSquad }
    let bennettMark = { Name = "Mark Bennett"; Team = scotland; Type = Back; Status = OriginalSquad }
    let hornePeter = { Name = "Peter Horne"; Team = scotland; Type = Back; Status = OriginalSquad }
    let scottMatt = { Name = "Matt Scott"; Team = scotland; Type = Back; Status = OriginalSquad }
    let vernonRichie = { Name = "Richie Vernon"; Team = scotland; Type = Back; Status = OriginalSquad }
    let lamontSean = { Name = "Sean Lamont"; Team = scotland; Type = Back; Status = OriginalSquad }
    let maitlandSean = { Name = "Sean Maitland"; Team = scotland; Type = Back; Status = OriginalSquad }
    let seymourTommy = { Name = "Tommy Seymour"; Team = scotland; Type = Back; Status = OriginalSquad }
    let visserTim = { Name = "Tim Visser"; Team = scotland; Type = Back; Status = OriginalSquad }
    let hoggStuart = { Name = "Stuart Hogg"; Team = scotland; Type = Back; Status = OriginalSquad }

    let scotlandSquad = { Team = scotland
                          Players = [ brownFraser; bryceKevin; fordRoss; mcInallyStuart; dickinsonAlasdair; grantRyan; nelWP; reidGordon
                                      welshJon; gilchristGrant; grayJonny; grayRichie; swinsonTim; hardieJohn; strokoschAlasdair
                                      wilsonRyan; dentonDavid; straussJosh; hidalgoClyneSam; laidlawGreig; pyrgosHenry; russellFinn
                                      weirDuncan; bennettMark; hornePeter; scottMatt; vernonRichie; lamontSean; maitlandSean; seymourTommy
                                      visserTim; hoggStuart ] }

    let fiji = { Name = "Fiji"; Status = Active; Seeding = None; Coach = "John McKee" }

    let kotoSunia = { Name = "Sunia Koto"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let tuapatiTalemaitoga = { Name = "Talemaitoga Tuapati"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let veikosoViliame = { Name = "Viliame Veikoso"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let atalifoLeeroy = { Name = "Lee-roy Atalifo"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let colatiIsei = { Name = "Isei Colati"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let ma'afuCampese = { Name = "Campese Ma'afu"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let ravaiPeni = { Name = "Peni Ravai"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let sauloManasa = { Name = "Manasa Saulo"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let cavubatiTevita = { Name = "Tevita Cavubati"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let nakarawaLeone = { Name = "Leone Nakarawa"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let ratuniyarawaApi = { Name = "Api Ratuniyarawa"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let soqetaNemia = { Name = "Nemia Soqeta"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let qeraAkapusi = { Name = "Akapusi Qera"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let ravuloMalakai = { Name = "Malakai Ravulo"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let waqaniburotuDominiko = { Name = "Dominiko Waqaniburotu"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let yatoPeceli = { Name = "Peceli Yato"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let matadigoSakiusa = { Name = "Sakiusa Matadigo"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let taleiNetani = { Name = "Netani Talei"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let kenataleNemia = { Name = "Nemia Kenatale"; Team = fiji; Type = Back; Status = OriginalSquad }
    let matawaluNikola = { Name = "Nikola Matawalu"; Team = fiji; Type = Back; Status = OriginalSquad }
    let seniloliHenry = { Name = "Henry Seniloli"; Team = fiji; Type = Back; Status = OriginalSquad }
    let matavesiJosh = { Name = "Josh Matavesi"; Team = fiji; Type = Back; Status = OriginalSquad }
    let volavolaBen = { Name = "Ben Volavola"; Team = fiji; Type = Back; Status = OriginalSquad }
    let botiaLevani = { Name = "Levani Botia"; Team = fiji; Type = Back; Status = OriginalSquad }
    let gonevaVereniki = { Name = "Vereniki Goneva"; Team = fiji; Type = Back; Status = OriginalSquad }
    let lovobalavuGabiriele = { Name = "Gabiriele Lovobalavu"; Team = fiji; Type = Back; Status = OriginalSquad }
    let nadoloNemani = { Name = "Nemani Nadolo"; Team = fiji; Type = Back; Status = OriginalSquad }
    let nayacalevuWaisea = { Name = "Waisea Nayacalevu"; Team = fiji; Type = Back; Status = OriginalSquad }
    let tikoirotumaAsaeli = { Name = "Asaeli Tikoirotuma"; Team = fiji; Type = Back; Status = OriginalSquad }
    let murimurivaluKini = { Name = "Kini Murimurivalu"; Team = fiji; Type = Back; Status = OriginalSquad }
    let talebulaMetuisela = { Name = "Metuisela Talebula"; Team = fiji; Type = Back; Status = OriginalSquad }

    let fijiSquad = { Team = fiji
                      Players = [ kotoSunia; tuapatiTalemaitoga; veikosoViliame; atalifoLeeroy; colatiIsei; ma'afuCampese; ravaiPeni
                                  sauloManasa; cavubatiTevita; nakarawaLeone; ratuniyarawaApi; soqetaNemia; qeraAkapusi; ravuloMalakai
                                  waqaniburotuDominiko; yatoPeceli; matadigoSakiusa; taleiNetani; kenataleNemia; matawaluNikola
                                  seniloliHenry; matavesiJosh; volavolaBen; botiaLevani; gonevaVereniki; lovobalavuGabiriele
                                  nadoloNemani; nayacalevuWaisea; tikoirotumaAsaeli; murimurivaluKini; talebulaMetuisela ] }

    let uruguay = { Name = "Uruguay"; Status = Active; Seeding = None; Coach = "Pablo Lemoine" }

    let arboleyaCarlos = { Name = "Carlos Arboleya"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let kesslerGerman = { Name = "Germán Kessler"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let klappenbachNicolas = { Name = "Nicolás Klappenbach"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let corralAlejo = { Name = "Alejo Corral"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let duranOscar = { Name = "Oscar Durán"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let sagarioMario = { Name = "Mario Sagario"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let sanguinettiMateo = { Name = "Mateo Sanguinetti"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let lamannaFranco = { Name = "Franco Lamanna"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let palomequeMathias = { Name = "Mathias Palomeque"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let vilasecaSantiago = { Name = "Santiago Vilaseca"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let zerbinoJorge = { Name = "Jorge Zerbino"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let alonsoAgustin = { Name = "Agustín Alonso"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let bascouFernando = { Name = "Fernando Bascou"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let beerMatias = { Name = "Matías Beer"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let deFreitasJuan = { Name = "Juan De Freitas"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let gaminaraJuanManuel = { Name = "Juan Manuel Gaminara"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let magnoDiego = { Name = "Diego Magno"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let nietoAlejandro = { Name = "Alejandro Nieto"; Team = uruguay; Type = Forward; Status = OriginalSquad }
    let duranAlejo = { Name = "Alejo Durán"; Team = uruguay; Type = Back; Status = OriginalSquad }
    let ormaecheaAgustin = { Name = "Agustín Ormaechea"; Team = uruguay; Type = Back; Status = OriginalSquad }
    let berchisiFelipe = { Name = "Felipe Berchesi"; Team = uruguay; Type = Back; Status = OriginalSquad }
    let blengioManuel = { Name = "Manuel Blengio"; Team = uruguay; Type = Back; Status = OriginalSquad }
    let silvaRodrigo = { Name = "Rodrigo Silva"; Team = uruguay; Type = Back; Status = OriginalSquad }
    let pradaJoaquin = { Name = "Joaquín Prada"; Team = uruguay; Type = Back; Status = OriginalSquad }
    let romanAlberto = { Name = "Alberto Román"; Team = uruguay; Type = Back; Status = OriginalSquad }
    let vilasecaAndres = { Name = "Andrés Vilaseca"; Team = uruguay; Type = Back; Status = OriginalSquad }
    let bulantiFrancisco = { Name = "Francisco Bulanti"; Team = uruguay; Type = Back; Status = OriginalSquad }
    let gilbernauSantiago = { Name = "Santiago Gilbernau"; Team = uruguay; Type = Back; Status = OriginalSquad }
    let leivasLeandro = { Name = "Leandro Leivas"; Team = uruguay; Type = Back; Status = OriginalSquad }
    let etcheverryJeronimo = { Name = "Jerónimo Etcheverry"; Team = uruguay; Type = Back; Status = OriginalSquad }
    let mieresGaston = { Name = "Gastón Mieres"; Team = uruguay; Type = Back; Status = OriginalSquad }

    let uruguaySquad = { Team = uruguay
                         Players = [ arboleyaCarlos; kesslerGerman; klappenbachNicolas; corralAlejo; duranOscar; sagarioMario
                                     sanguinettiMateo; lamannaFranco; palomequeMathias; vilasecaSantiago; zerbinoJorge; alonsoAgustin
                                     bascouFernando; beerMatias; deFreitasJuan; gaminaraJuanManuel; magnoDiego; nietoAlejandro; duranAlejo
                                     ormaecheaAgustin; berchisiFelipe; blengioManuel; silvaRodrigo; pradaJoaquin; romanAlberto
                                     vilasecaAndres; bulantiFrancisco; gilbernauSantiago; leivasLeandro; etcheverryJeronimo
                                     mieresGaston ] }

    let japan = { Name = "Japan"; Status = Active; Seeding = None; Coach = "Eddie Jones" }

    let horieShota = { Name = "Shota Horie"; Team = japan; Type = Forward; Status = OriginalSquad }
    let kizuTakeshi = { Name = "Takeshi Kizu"; Team = japan; Type = Forward; Status = OriginalSquad }
    let yuharaHiroki = { Name = "Hiroki Yuhara"; Team = japan; Type = Forward; Status = OriginalSquad }
    let hatakeyamaKensuke = { Name = "Kensuke Hatakeyama"; Team = japan; Type = Forward; Status = OriginalSquad }
    let inagakiKeita = { Name = "Keita Inagaki"; Team = japan; Type = Forward; Status = OriginalSquad }
    let mikamiMasataka = { Name = "Masataka Mikami"; Team = japan; Type = Forward; Status = OriginalSquad }
    let yamashitaHiroshi = { Name = "Hiroshi Yamashita"; Team = japan; Type = Forward; Status = OriginalSquad }
    let itoShoji = { Name = "Shoji Ito"; Team = japan; Type = Forward; Status = OriginalSquad }
    let makabeShinya = { Name = "Shinya Makabe"; Team = japan; Type = Forward; Status = OriginalSquad }
    let onoHitoshi = { Name = "Hitoshi Ono"; Team = japan; Type = Forward; Status = OriginalSquad }
    let thompsonLuke = { Name = "Luke Thompson"; Team = japan; Type = Forward; Status = OriginalSquad }
    let broadhurstMichael = { Name = "Michael Broadhurst"; Team = japan; Type = Forward; Status = OriginalSquad }
    let ivesJustin = { Name = "Justin Ives"; Team = japan; Type = Forward; Status = OriginalSquad }
    let leitchMichael = { Name = "Michael Leitch"; Team = japan; Type = Forward; Status = OriginalSquad }
    let tuiHendrik = { Name = "Hendrik Tui"; Team = japan; Type = Forward; Status = OriginalSquad }
    let holaniRyu = { Name = "Ryu Holani"; Team = japan; Type = Forward; Status = OriginalSquad }
    let mafiAmanakiLelei = { Name = "Amanaki Lelei Mafi"; Team = japan; Type = Forward; Status = OriginalSquad }
    let hiwasaAtsushi = { Name = "Atsushi Hiwasa"; Team = japan; Type = Back; Status = OriginalSquad }
    let tanakaFumiaki = { Name = "Fumiaki Tanaka"; Team = japan; Type = Back; Status = OriginalSquad }
    let tatekawaHarumichi = { Name = "Harumichi Tatekawa"; Team = japan; Type = Back; Status = OriginalSquad }
    let onoKosei = { Name = "Kosei Ono"; Team = japan; Type = Back; Status = OriginalSquad }
    let matsushimaKotaro = { Name = "Kotaro Matsushima"; Team = japan; Type = Back; Status = OriginalSquad }
    let sa'uMale = { Name = "Male Sa'u"; Team = japan; Type = Back; Status = OriginalSquad }
    let tamuraYu = { Name = "Yu Tamura"; Team = japan; Type = Back; Status = OriginalSquad }
    let wingCraig = { Name = "Craig Wing"; Team = japan; Type = Back; Status = OriginalSquad }
    let fujitaYoshikazu = { Name = "Yoshikazu Fujita"; Team = japan; Type = Back; Status = OriginalSquad }
    let fukuokaKenki = { Name = "Kenki Fukuoka"; Team = japan; Type = Back; Status = OriginalSquad }
    let heskethKarne = { Name = "Karne Hesketh"; Team = japan; Type = Back; Status = OriginalSquad }
    let hiroseToshiaki = { Name = "Toshiaki Hirose"; Team = japan; Type = Back; Status = OriginalSquad }
    let yamadaAkihito = { Name = "Akihito Yamada"; Team = japan; Type = Back; Status = OriginalSquad }
    let goromaruAyumu = { Name = "Ayumu Goromaru"; Team = japan; Type = Back; Status = OriginalSquad }

    let japanSquad = { Team = japan
                       Players = [ horieShota; kizuTakeshi; yuharaHiroki; hatakeyamaKensuke; inagakiKeita; mikamiMasataka; yamashitaHiroshi
                                   itoShoji; makabeShinya; onoHitoshi; thompsonLuke; broadhurstMichael; ivesJustin; leitchMichael
                                   tuiHendrik; holaniRyu; mafiAmanakiLelei; hiwasaAtsushi; tanakaFumiaki; tatekawaHarumichi; onoKosei
                                   matsushimaKotaro; sa'uMale; tamuraYu; wingCraig; fujitaYoshikazu; fukuokaKenki; heskethKarne
                                   hiroseToshiaki; yamadaAkihito; goromaruAyumu ] }

    let unitedStates = { Name = "United States"; Status = Active; Seeding = None; Coach = "Mike Tolkin" }

    let fenoglioZach = { Name = "Zach Fenoglio"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let thielPaul = { Name = "Phil Thiel"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let baumannChris = { Name = "Chris Baumann"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let fryEric = { Name = "Eric Fry"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let kilifiOlive = { Name = "Olive Kilifi"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let lamositeleTiti = { Name = "Titi Lamositele"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let moeakiolaMatekitonga = { Name = "Matekitonga Moeakiola"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let manoaSamu = { Name = "Samu Manoa"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let petersonGreg = { Name = "Greg Peterson"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let smithHayden = { Name = "Hayden Smith"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let stanfillLouis = { Name = "Louis Stanfill"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let durutaloAndrew = { Name = "Andrew Durutalo"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let trouvilleMatt = { Name = "Matt Trouville"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let mcFarlandAlastair = { Name = "Alastair McFarland"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let quillJohn = { Name = "John Quill"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let barrettDanny = { Name = "Danny Barrett"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let dolanCam = { Name = "Cam Dolan"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let taufete'eJoe = { Name = "Joe Taufete'e"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let krugerNiku = { Name = "Niku Kruger"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let petriMike = { Name = "Mike Petri"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let macGintyAJ = { Name = "AJ MacGinty"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let suniulaShalom = { Name = "Shalom Suniula"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let kellySeamus = { Name = "Seamus Kelly"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let niuaFolau = { Name = "Folau Niua"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let palamaThretton = { Name = "Thretton Palamo"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let suniulaAndrew = { Name = "Andrew Suniula"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let ngwenyaTakudzwa = { Name = "Takudzwa Ngwenya"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let scullyBlaine = { Name = "Blaine Scully"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let testZack = { Name = "Zack Test"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let thompsonBrett = { Name = "Brett Thompson"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let wylesChris = { Name = "Chris Wyles"; Team = unitedStates; Type = Back; Status = OriginalSquad }

    let unitedStatesSquad = { Team = unitedStates
                              Players = [ fenoglioZach; thielPaul; baumannChris; fryEric; kilifiOlive; lamositeleTiti; moeakiolaMatekitonga
                                          manoaSamu; petersonGreg; smithHayden; stanfillLouis; durutaloAndrew; trouvilleMatt
                                          mcFarlandAlastair; quillJohn; barrettDanny; dolanCam; taufete'eJoe; krugerNiku; petriMike
                                          macGintyAJ; suniulaShalom; kellySeamus; niuaFolau; palamaThretton; suniulaAndrew; ngwenyaTakudzwa
                                          scullyBlaine; testZack; thompsonBrett; wylesChris ] }

    let georgia = { Name = "Georgia"; Status = Active; Seeding = None; Coach = "Milton Haig" }

    let bregvadzeJaba = { Name = "Jaba Bregvadze"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let mamukashviliShalva = { Name = "Shalva Mamukashvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let maisuradzeSimon = { Name = "Simon Maisuradze"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let asieshviliKakha = { Name = "Kakha Asieshvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let chilachavaLevan = { Name = "Levan Chilachava"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let kubriashviliDavit = { Name = "Davit Kubriashvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let nariashviliMikheil = { Name = "Mikheil Nariashvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let zirakashviliDavit = { Name = "Davit Zirakashvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let chkhaidzeGiorgi = { Name = "Giorgi Chkhaidze"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let datunashviliLevan = { Name = "Levan Datunashvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let mikautadzeKonstantin = { Name = "Konstantin Mikautadze"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let nemsadzeGiorgi = { Name = "Giorgi Nemsadze"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let gorgodzeMamuka = { Name = "Mamuka Gorgodze"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let kolelishviliViktor = { Name = "Viktor Kolelishvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let sutiashviliShalva = { Name = "Shalva Sutiashvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let tkhilaishviliGiorgi = { Name = "Giorgi Tkhilaishvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let lomidzeLasha = { Name = "Lasha Lomidze"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let begadzeGiorgi = { Name = "Giorgi Begadze"; Team = georgia; Type = Back; Status = OriginalSquad }
    let khutsishviliVazha = { Name = "Vazha Khutsishvili"; Team = georgia; Type = Back; Status = OriginalSquad }
    let lobzhanidzeVasil = { Name = "Vasil Lobzhanidze"; Team = georgia; Type = Back; Status = OriginalSquad }
    let khmaladzeLasha = { Name = "Lasha Khmaladze"; Team = georgia; Type = Back; Status = OriginalSquad }
    let malaghuradzeLasha = { Name = "Lasha Malaghuradze"; Team = georgia; Type = Back; Status = OriginalSquad }
    let kacharavaDavit = { Name = "Davit Kacharava"; Team = georgia; Type = Back; Status = OriginalSquad }
    let sharikadzeMerab = { Name = "Merab Sharikadze"; Team = georgia; Type = Back; Status = OriginalSquad }
    let aptsiauriGiorgi = { Name = "Giorgi Aptsiauri"; Team = georgia; Type = Back; Status = OriginalSquad }
    let mchedlidzeTamaz = { Name = "Tamaz Mchedlidze"; Team = georgia; Type = Back; Status = OriginalSquad }
    let giorgadzeMuraz = { Name = "Muraz Giorgadze"; Team = georgia; Type = Back; Status = OriginalSquad }
    let pruidzeGiorgi = { Name = "Giorgi Pruidze"; Team = georgia; Type = Back; Status = OriginalSquad }
    let toduaAlexander = { Name = "Alexander Todua"; Team = georgia; Type = Back; Status = OriginalSquad }
    let kvirikashviliMerab = { Name = "Merab Kvirikashvili"; Team = georgia; Type = Back; Status = OriginalSquad }
    let tsiklauriBeka = { Name = "Beka Tsiklauri"; Team = georgia; Type = Back; Status = OriginalSquad }

    let georgiaSquad = { Team = georgia
                         Players = [ bregvadzeJaba; mamukashviliShalva; maisuradzeSimon; asieshviliKakha; chilachavaLevan; kubriashviliDavit
                                     nariashviliMikheil; zirakashviliDavit; chkhaidzeGiorgi; datunashviliLevan; mikautadzeKonstantin
                                     nemsadzeGiorgi; gorgodzeMamuka; kolelishviliViktor; sutiashviliShalva; tkhilaishviliGiorgi
                                     lomidzeLasha; begadzeGiorgi; khutsishviliVazha; lobzhanidzeVasil; khmaladzeLasha; malaghuradzeLasha
                                     kacharavaDavit; sharikadzeMerab; aptsiauriGiorgi; mchedlidzeTamaz; giorgadzeMuraz; pruidzeGiorgi
                                     toduaAlexander; kvirikashviliMerab; tsiklauriBeka ] }

    let namibia = { Name = "Namibia"; Status = Active; Seeding = None; Coach = "Phil Davies" }

    let vanJaarsveldTorsten = { Name = "Torsten van Jaarsveld"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let vanderWesthuizenLouis = { Name = "Louis van der Westhuizen"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let coetzeeAranos = { Name = "Aranos Coetzee"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let deKlerkAJ = { Name = "AJ de Klerk"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let engelsJaco = { Name = "Jaco Engels"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let larsonRaoul = { Name = "Raoul Larson"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let redelinghuysJohnny = { Name = "Johnny Redelinghuys"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let viviersCasper = { Name = "Casper Viviers"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let uaniviTjiuee = { Name = "Tjiuee Uanivi"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let venterJanco = { Name = "Janco Venter"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let bothmaRenaldo = { Name = "Renaldo Bothma"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let burgerJacques = { Name = "Jacques Burger"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let conradieWian = { Name = "Wian Conradie"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let duPlessisTinus = { Name = "Tinus du Plessis"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let kitshoffRohan = { Name = "Rohan Kitshoff"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let damensLeneve = { Name = "Leneve Damens"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let vanLillPieterJan = { Name = "Pieter-Jan van Lill"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let buitendagEniell = { Name = "Eniell Buitendag"; Team = namibia; Type = Back; Status = OriginalSquad }
    let jantjiesEugene = { Name = "Eugene Jantjies"; Team = namibia; Type = Back; Status = OriginalSquad }
    let stevensDamian = { Name = "Damian Stevens"; Team = namibia; Type = Back; Status = OriginalSquad }
    let kotzeTheuns = { Name = "Theuns Kotzé"; Team = namibia; Type = Back; Status = OriginalSquad }
    let delaHarpeDarryl = { Name = "Darryl de la Harpe"; Team = namibia; Type = Back; Status = OriginalSquad }
    let deyselJohan = { Name = "Johan Deysel"; Team = namibia; Type = Back; Status = OriginalSquad }
    let greylingJC = { Name = "JC Greyling"; Team = namibia; Type = Back; Status = OriginalSquad }
    let vanWykDanie = { Name = "Danie van Wyk"; Team = namibia; Type = Back; Status = OriginalSquad }
    let maraisConrad = { Name = "Conrad Marais"; Team = namibia; Type = Back; Status = OriginalSquad }
    let philanderDavid = { Name = "David Philander"; Team = namibia; Type = Back; Status = OriginalSquad }
    let smithHeinrich = { Name = "Heinrich Smit"; Team = namibia; Type = Back; Status = OriginalSquad }
    let vanWykRussell = { Name = "Russell van Wyk"; Team = namibia; Type = Back; Status = OriginalSquad }
    let bothaChrysander = { Name = "Chrysander Botha"; Team = namibia; Type = Back; Status = OriginalSquad }
    let trompJohan = { Name = "Johan Tromp"; Team = namibia; Type = Back; Status = OriginalSquad }

    let namibiaSquad = { Team = namibia
                         Players = [ vanJaarsveldTorsten; vanderWesthuizenLouis; coetzeeAranos; deKlerkAJ; engelsJaco; larsonRaoul
                                     redelinghuysJohnny; viviersCasper; uaniviTjiuee; venterJanco; bothmaRenaldo; burgerJacques;
                                     conradieWian; duPlessisTinus; kitshoffRohan; damensLeneve; vanLillPieterJan; buitendagEniell
                                     jantjiesEugene; stevensDamian; kotzeTheuns; delaHarpeDarryl; deyselJohan; greylingJC; vanWykDanie
                                     maraisConrad; philanderDavid; smithHeinrich; vanWykRussell; bothaChrysander; trompJohan ] }

    let canada = { Name = "Canada"; Status = Active; Seeding = None; Coach = "Kieran Crowley" }

    let barkwillRay = { Name = "Ray Barkwill"; Team = canada; Type = Forward; Status = OriginalSquad }
    let carpenterAaron = { Name = "Aaron Carpenter"; Team = canada; Type = Forward; Status = OriginalSquad }
    let pifferoBenoit = { Name = "Benoit Piffero"; Team = canada; Type = Forward; Status = OriginalSquad }
    let buydensHubert = { Name = "Hubert Buydens"; Team = canada; Type = Forward; Status = OriginalSquad }
    let ilnickiJake = { Name = "Jake Ilnicki"; Team = canada; Type = Forward; Status = OriginalSquad }
    let searsDucDjustice = { Name = "Djustice Sears-Duru"; Team = canada; Type = Forward; Status = OriginalSquad }
    let tiedemannAndrew = { Name = "Andrew Tiedemann"; Team = canada; Type = Forward; Status = OriginalSquad }
    let wooldridgeDoug = { Name = "Doug Wooldridge"; Team = canada; Type = Forward; Status = OriginalSquad }
    let beukeboomBrett = { Name = "Brett Beukeboom"; Team = canada; Type = Forward; Status = OriginalSquad }
    let cudmoreJamie = { Name = "Jamie Cudmore"; Team = canada; Type = Forward; Status = OriginalSquad }
    let olmsteadEvan = { Name = "Evan Olmstead"; Team = canada; Type = Forward; Status = OriginalSquad }
    let dalaNanyak = { Name = "Nanyak Dala"; Team = canada; Type = Forward; Status = OriginalSquad }
    let gilmourKyle = { Name = "Kyle Gilmour"; Team = canada; Type = Forward; Status = OriginalSquad }
    let moonlightJohn = { Name = "John Moonlight"; Team = canada; Type = Forward; Status = OriginalSquad }
    let sinclairJebb = { Name = "Jebb Sinclair"; Team = canada; Type = Forward; Status = OriginalSquad }
    let ardronTyler = { Name = "Tyler Ardron"; Team = canada; Type = Forward; Status = OriginalSquad }
    let thorpeRichard = { Name = "Richard Thorpe"; Team = canada; Type = Forward; Status = OriginalSquad }
    let mackPhil = { Name = "Phil Mack"; Team = canada; Type = Back; Status = OriginalSquad }
    let mackenzieJamie = { Name = "Jamie Mackenzie"; Team = canada; Type = Back; Status = OriginalSquad }
    let mcRorieGordon = { Name = "Gordon McRorie"; Team = canada; Type = Back; Status = OriginalSquad }
    let hirayamaNathan = { Name = "Nathan Hirayama"; Team = canada; Type = Back; Status = OriginalSquad }
    let underwoodLiam = { Name = "Liam Underwood"; Team = canada; Type = Back; Status = OriginalSquad }
    let blevinsNick = { Name = "Nick Blevins"; Team = canada; Type = Back; Status = OriginalSquad }
    let braidConnor = { Name = "Connor Braid"; Team = canada; Type = Back; Status = OriginalSquad }
    let hearnCiaran = { Name = "Ciaran Hearn"; Team = canada; Type = Back; Status = OriginalSquad }
    let trainorConor = { Name = "Conor Trainor"; Team = canada; Type = Back; Status = OriginalSquad }
    let hasslerJeff = { Name = "Jeff Hassler"; Team = canada; Type = Back; Status = OriginalSquad }
    let mackenziePhil = { Name = "Phil Mackenzie"; Team = canada; Type = Back; Status = OriginalSquad }
    let vanderMerweDTH = { Name = "D. T. H. van der Merwe"; Team = canada; Type = Back; Status = OriginalSquad }
    let evansMatt = { Name = "Matt Evans"; Team = canada; Type = Back; Status = OriginalSquad }
    let jonesHarry = { Name = "Harry Jones"; Team = canada; Type = Back; Status = OriginalSquad }

    let canadaSquad = { Team = canada
                        Players = [ barkwillRay; carpenterAaron; pifferoBenoit; buydensHubert; ilnickiJake; searsDucDjustice
                                    tiedemannAndrew; wooldridgeDoug; beukeboomBrett; cudmoreJamie; olmsteadEvan; dalaNanyak; gilmourKyle
                                    moonlightJohn; sinclairJebb; ardronTyler; thorpeRichard; mackPhil; mackenzieJamie; mcRorieGordon
                                    hirayamaNathan; underwoodLiam; blevinsNick; braidConnor; hearnCiaran; trainorConor; hasslerJeff
                                    mackenziePhil; vanderMerweDTH; evansMatt; jonesHarry ] }

    let romania = { Name = "Romania"; Status = Active; Seeding = None; Coach = "Lynn Howells" }

    let capatanaEugen = { Name = "Eugen Căpățână"; Team = romania; Type = Forward; Status = OriginalSquad }
    let radoiAndrei = { Name = "Andrei Rădoi"; Team = romania; Type = Forward; Status = OriginalSquad }
    let turashviliOtar = { Name = "Otar Turashvili"; Team = romania; Type = Forward; Status = OriginalSquad }
    let lazarMihai = { Name = "Mihai Lazăr"; Team = romania; Type = Forward; Status = OriginalSquad }
    let paulicaIon = { Name = "Ion Paulică"; Team = romania; Type = Forward; Status = OriginalSquad }
    let pungeaHoratiu = { Name = "Horațiu Pungea"; Team = romania; Type = Forward; Status = OriginalSquad }
    let tarusAlexandru = { Name = "Alexandru Țăruș"; Team = romania; Type = Forward; Status = OriginalSquad }
    let ursacheAndrei = { Name = "Andrei Ursache"; Team = romania; Type = Forward; Status = OriginalSquad }
    let antonescuMarius = { Name = "Marius Antonescu"; Team = romania; Type = Forward; Status = OriginalSquad }
    let popirlanValentin = { Name = "Valentin Popîrlan"; Team = romania; Type = Forward; Status = OriginalSquad }
    let ursacheValentin = { Name = "Valentin Ursache"; Team = romania; Type = Forward; Status = OriginalSquad }
    let vanHeerdenJohannes = { Name = "Johannes van Heerden"; Team = romania; Type = Forward; Status = OriginalSquad }
    let burceaStelian = { Name = "Stelian Burcea"; Team = romania; Type = Forward; Status = OriginalSquad }
    let lucaciViorel = { Name = "Viorel Lucaci"; Team = romania; Type = Forward; Status = OriginalSquad }
    let macoveiMihai = { Name = "Mihai Macovei"; Team = romania; Type = Forward; Status = OriginalSquad }
    let carpoDaniel = { Name = "Daniel Carpo"; Team = romania; Type = Forward; Status = OriginalSquad }
    let tonitaOvidiu = { Name = "Ovidiu Toniţa"; Team = romania; Type = Forward; Status = OriginalSquad }
    let bratuTudorel = { Name = "Tudorel Bratu"; Team = romania; Type = Back; Status = OriginalSquad }
    let calafeteanuValentin = { Name = "Valentin Calafeteanu"; Team = romania; Type = Back; Status = OriginalSquad }
    let surugiuFlorin = { Name = "Florin Surugiu"; Team = romania; Type = Back; Status = OriginalSquad }
    let dumbravaDanut = { Name = "Dănuţ Dumbravă"; Team = romania; Type = Back; Status = OriginalSquad }
    let wiringiMichael = { Name = "Michael Wiringi"; Team = romania; Type = Back; Status = OriginalSquad }
    let galCsaba = { Name = "Csaba Gál"; Team = romania; Type = Back; Status = OriginalSquad }
    let kinikinilauPaula = { Name = "Paula Kinikinilau"; Team = romania; Type = Back; Status = OriginalSquad }
    let vlaicuFlorin = { Name = "Florin Vlaicu"; Team = romania; Type = Back; Status = OriginalSquad }
    let apostolAdrian = { Name = "Adrian Apostol"; Team = romania; Type = Back; Status = OriginalSquad }
    let botezatuIonut = { Name = "Ionuț Botezatu"; Team = romania; Type = Back; Status = OriginalSquad }
    let ionitaFlorin = { Name = "Florin Ioniță"; Team = romania; Type = Back; Status = OriginalSquad }
    let lemnaruMadalin = { Name = "Mădălin Lemnaru"; Team = romania; Type = Back; Status = OriginalSquad }
    let fercuCatalin = { Name = "Cătălin Fercu"; Team = romania; Type = Back; Status = OriginalSquad }
    let stratilaSabin = { Name = "Sabin Strătilă"; Team = romania; Type = Back; Status = OriginalSquad }

    let romaniaSquad = { Team = romania
                         Players = [ capatanaEugen; radoiAndrei; turashviliOtar; lazarMihai; paulicaIon; pungeaHoratiu; tarusAlexandru
                                     ursacheAndrei; antonescuMarius; popirlanValentin; ursacheValentin; vanHeerdenJohannes; burceaStelian
                                     lucaciViorel; macoveiMihai; carpoDaniel; tonitaOvidiu; bratuTudorel; calafeteanuValentin; surugiuFlorin
                                     dumbravaDanut; wiringiMichael; galCsaba; kinikinilauPaula; vlaicuFlorin; apostolAdrian; botezatuIonut
                                     ionitaFlorin; lemnaruMadalin; fercuCatalin; stratilaSabin ] }

    let teams = [ newZealand; southAfrica; australia; france; england; ireland; samoa; argentina; wales; italy; tonga; scotland; fiji
                  uruguay; japan; unitedStates; georgia; namibia; canada; romania ]

    let coaches = teams |> List.map (fun team -> team.Coach, team)

    let squads = [ newZealandSquad; southAfricaSquad; australiaSquad; franceSquad; englandSquad; irelandSquad; samoaSquad; argentinaSquad
                   walesSquad; italySquad; tongaSquad; scotlandSquad; fijiSquad; uruguaySquad; japanSquad; unitedStatesSquad; georgiaSquad
                   namibiaSquad; canadaSquad; romaniaSquad ]

    let players = squads |> List.collect (fun squad -> squad.Players |> List.map id)

    let groupA = Group ('A', [ australia; england; wales; fiji; uruguay ] )
    let groupB = Group ('B', [ southAfrica; samoa; scotland; japan; unitedStates ] )
    let groupC = Group ('C', [ newZealand; argentina; tonga; georgia; namibia ] )
    let groupD = Group ('D', [ france; ireland; italy; canada; romania ] )

    // Group A matches: https://en.wikipedia.org/wiki/2015_Rugby_World_Cup_Pool_A...

    (* TEMP [NMB]: test data...
    let groupAEnglandVsFiji = { Team1Points = TeamPoints (england, 32<point>); Team2Points = TeamPoints (fiji, 31<point>)
                                Stage = groupA; KickOff = DateTime (2015, 9, 11, 20, 0, 0)
                                Events = [ ManOfTheMatch nadoloNemani
                                           Try (josephJonathan, Some 9<min>) (* england *)
                                           Try (morganBen, Some 37<min>)
                                           Try (mayJonny, Some 51<min>)
                                           Try (watsonAnthony, Some 73<min>)
                                           Try (mayJonny, Some 80<min>)
                                           Conversion farrellOwen
                                           Conversion farrellOwen
                                           MissedConversion fordGeorge
                                           MissedConversion fordGeorge
                                           MissedConversion fordGeorge
                                           Penalty farrellOwen
                                           YellowCard (fordGeorge, Some 61<min>)
                                           Try (nadoloNemani, Some 16<min>) (* fiji *)
                                           PenaltyTry (fiji, Some 43<min>)
                                           Try (gonevaVereniki, Some 64<min>)
                                           Try (nakarawaLeone, Some 77<min>)
                                           Conversion nadoloNemani
                                           Conversion nadoloNemani
                                           Conversion nadoloNemani
                                           Conversion nadoloNemani
                                           DropGoal nadoloNemani ] }

    let groupAWalesVsUruguay = { Team1Points = TeamPoints (wales, 54<point>); Team2Points = TeamPoints (uruguay, 8<point>)
                                 Stage = groupA; KickOff = DateTime (2015, 9, 13, 14, 30, 0) 
                                 Events = [ ManOfTheMatch jenkinsGethin
                                            Try ((* TODO [NMB]: Replace with jonesAlunWyn... *)tipuricJustin, Some 3<min>) (* wales *)
                                            Try (northGeorge, Some 27<min>)
                                            Try (northGeorge, Some 37<min>)
                                            Try (jenkinsGethin, Some 49<min>)
                                            Try (williamsScott, Some 66<min>)
                                            Try (cuthbertAlex, Some 69<min>)
                                            Try (warburtonSam, Some 74<min>)
                                            Conversion biggarDan
                                            Conversion biggarDan
                                            Conversion biggarDan
                                            Conversion biggarDan
                                            Conversion biggarDan
                                            MissedConversion biggarDan
                                            MissedConversion priestlandRhys
                                            Penalty biggarDan
                                            Penalty biggarDan
                                            MissedPenalty biggarDan
                                            DropGoal priestlandRhys
                                            YellowCard (northGeorge, Some 52<min>)
                                            Try (leivasLeandro, Some 58<min>) (* uruguay *)
                                            MissedConversion berchisiFelipe
                                            Penalty berchisiFelipe
                                            RedCard (etcheverryJeronimo, Some 67<min>) ] } *)

    (* TEMP [NMB]... *)
    let groupAEnglandVsFiji = { Team1Points = TeamPoints (england, (*TODO*)0<point>); Team2Points = TeamPoints (fiji, (*TODO*)0<point>)
                                Stage = groupA; KickOff = DateTime (2015, 9, 18, 20, 0, 0)
                                Events = [ (*ManOfTheMatch ...*)
                                           (* TODO *) (* england *)
                                           (* TODO *) (* fiji *)
                                            ] }

    let groupAWalesVsUruguay = { Team1Points = TeamPoints (wales, (*TODO*)0<point>); Team2Points = TeamPoints (uruguay, (*TODO*)0<point>)
                                 Stage = groupA; KickOff = DateTime (2015, 9, 20, 14, 30, 0) 
                                 Events = [ (*ManOfTheMatch ...*)
                                            (* TODO *) (* wales *)
                                            (* TODO *) (* uruguay *)
                                             ] }

    let groupAAustraliaVsFiji = { Team1Points = TeamPoints (australia, (*TODO*)0<point>); Team2Points = TeamPoints (fiji, (*TODO*)0<point>)
                                  Stage = groupA; KickOff = DateTime (2015, 9, 23, 16, 45, 0) 
                                  Events = [ (*ManOfTheMatch ...*)
                                             (* TODO *) (* australia *)
                                             (* TODO *) (* fiji *)
                                              ] }

    let groupAEnglandVsWales = { Team1Points = TeamPoints (england, (*TODO*)0<point>); Team2Points = TeamPoints (wales, (*TODO*)0<point>)
                                 Stage = groupA; KickOff = DateTime (2015, 9, 26, 20, 0, 0) 
                                 Events = [ (*ManOfTheMatch ...*)
                                            (* TODO *) (* england *)
                                            (* TODO *) (* wales *)
                                             ] }

    let groupAAustraliaVsUruguay = { Team1Points = TeamPoints (australia, (*TODO*)0<point>); Team2Points = TeamPoints (uruguay, (*TODO*)0<point>)
                                     Stage = groupA; KickOff = DateTime (2015, 9, 27, 12, 0, 0) 
                                     Events = [ (*ManOfTheMatch ...*)
                                                (* TODO *) (* australia *)
                                                (* TODO *) (* uruguay *)
                                                 ] }

    let groupAWalesVsFiji = { Team1Points = TeamPoints (wales, (*TODO*)0<point>); Team2Points = TeamPoints (fiji, (*TODO*)0<point>)
                              Stage = groupA; KickOff = DateTime (2015, 10, 1, 16, 45, 0) 
                              Events = [ (*ManOfTheMatch ...*)
                                         (* TODO *) (* wales *)
                                         (* TODO *) (* fiji *)
                                          ] }

    let groupAEnglandVsAustralia = { Team1Points = TeamPoints (england, (*TODO*)0<point>); Team2Points = TeamPoints (australia, (*TODO*)0<point>)
                                     Stage = groupA; KickOff = DateTime (2015, 10, 3, 20, 0, 0) 
                                     Events = [ (*ManOfTheMatch ...*)
                                                (* TODO *) (* england *)
                                                (* TODO *) (* australia *)
                                                 ] }

    let groupAFijiVsUruguay = { Team1Points = TeamPoints (fiji, (*TODO*)0<point>); Team2Points = TeamPoints (uruguay, (*TODO*)0<point>)
                                Stage = groupA; KickOff = DateTime (2015, 10, 7, 20, 0, 0) 
                                Events = [ (*ManOfTheMatch ...*)
                                           (* TODO *) (* fiji *)
                                           (* TODO *) (* uruguay *)
                                            ] }

    let groupAAustraliaVsWales = { Team1Points = TeamPoints (australia, (*TODO*)0<point>); Team2Points = TeamPoints (wales, (*TODO*)0<point>)
                                   Stage = groupA; KickOff = DateTime (2015, 10, 10, 16, 45, 0) 
                                   Events = [ (*ManOfTheMatch ...*)
                                              (* TODO *) (* australia *)
                                              (* TODO *) (* wales *)
                                               ] }

    let groupAEnglandVsUruguay = { Team1Points = TeamPoints (england, (*TODO*)0<point>); Team2Points = TeamPoints (uruguay, (*TODO*)0<point>)
                                   Stage = groupA; KickOff = DateTime (2015, 10, 10, 20, 0, 0) 
                                   Events = [ (*ManOfTheMatch ...*)
                                              (* TODO *) (* england *)
                                              (* TODO *) (* uruguay *)
                                               ] }

    let groupAMatches = [ groupAEnglandVsFiji; groupAWalesVsUruguay; groupAAustraliaVsFiji; groupAEnglandVsWales; groupAAustraliaVsUruguay
                          groupAWalesVsFiji; groupAEnglandVsAustralia; groupAFijiVsUruguay; groupAAustraliaVsWales; groupAEnglandVsUruguay ]

    // Group B matches: https://en.wikipedia.org/wiki/2015_Rugby_World_Cup_Pool_B...

    let groupBSouthAfricaVsJapan = { Team1Points = TeamPoints (southAfrica, (*TODO*)0<point>); Team2Points = TeamPoints (japan, (*TODO*)0<point>)
                                     Stage = groupB; KickOff = DateTime (2015, 9, 19, 16, 45, 0)
                                     Events = [ (*ManOfTheMatch ...*)
                                                (* TODO *) (* southAfrica *)
                                                (* TODO *) (* japan *)
                                                 ] }

    let groupBSamoaVsUnitedStates = { Team1Points = TeamPoints (samoa, (*TODO*)0<point>); Team2Points = TeamPoints (unitedStates, (*TODO*)0<point>)
                                      Stage = groupB; KickOff = DateTime (2015, 9, 20, 12, 0, 0)
                                      Events = [ (*ManOfTheMatch ...*)
                                                 (* TODO *) (* samoa *)
                                                 (* TODO *) (* unitedStates *)
                                                  ] }

    let groupBScotlandVsJapan = { Team1Points = TeamPoints (scotland, (*TODO*)0<point>); Team2Points = TeamPoints (japan, (*TODO*)0<point>)
                                  Stage = groupB; KickOff = DateTime (2015, 9, 23, 14, 30, 0)
                                  Events = [ (*ManOfTheMatch ...*)
                                             (* TODO *) (* scotland *)
                                             (* TODO *) (* japan *)
                                              ] }

    let groupBSouthAfricaVsSamoa = { Team1Points = TeamPoints (southAfrica, (*TODO*)0<point>); Team2Points = TeamPoints (samoa, (*TODO*)0<point>)
                                     Stage = groupB; KickOff = DateTime (2015, 9, 26, 16, 45, 0)
                                     Events = [ (*ManOfTheMatch ...*)
                                                (* TODO *) (* southAfrica *)
                                                (* TODO *) (* samoa *)
                                                 ] }

    let groupBScotlandVsUnitedStates = { Team1Points = TeamPoints (scotland, (*TODO*)0<point>); Team2Points = TeamPoints (unitedStates, (*TODO*)0<point>)
                                         Stage = groupB; KickOff = DateTime (2015, 9, 27, 14, 30, 0)
                                         Events = [ (*ManOfTheMatch ...*)
                                                    (* TODO *) (* scotland *)
                                                    (* TODO *) (* unitedStates *)
                                                     ] }

    let groupBSamoaVsJapan = { Team1Points = TeamPoints (samoa, (*TODO*)0<point>); Team2Points = TeamPoints (japan, (*TODO*)0<point>)
                               Stage = groupB; KickOff = DateTime (2015, 10, 3, 14, 30, 0)
                               Events = [ (*ManOfTheMatch ...*)
                                          (* TODO *) (* samoa *)
                                          (* TODO *) (* japan *)
                                           ] }

    let groupBSouthAfricaVsScotland = { Team1Points = TeamPoints (southAfrica, (*TODO*)0<point>); Team2Points = TeamPoints (scotland, (*TODO*)0<point>)
                                        Stage = groupB; KickOff = DateTime (2015, 10, 3, 16, 45, 0)
                                        Events = [ (*ManOfTheMatch ...*)
                                                   (* TODO *) (* southAfrica *)
                                                   (* TODO *) (* scotland *)
                                                    ] }

    let groupBSouthAfricaVsUnitedStates = { Team1Points = TeamPoints (southAfrica, (*TODO*)0<point>); Team2Points = TeamPoints (unitedStates, (*TODO*)0<point>)
                                            Stage = groupB; KickOff = DateTime (2015, 10, 7, 16, 45, 0)
                                            Events = [ (*ManOfTheMatch ...*)
                                                       (* TODO *) (* southAfrica *)
                                                       (* TODO *) (* unitedStates *)
                                                        ] }

    let groupBSamoaVsScotland = { Team1Points = TeamPoints (samoa, (*TODO*)0<point>); Team2Points = TeamPoints (scotland, (*TODO*)0<point>)
                                  Stage = groupB; KickOff = DateTime (2015, 10, 10, 14, 30, 0)
                                  Events = [ (*ManOfTheMatch ...*)
                                             (* TODO *) (* samoa *)
                                             (* TODO *) (* scotland *)
                                              ] }

    let groupBUnitedStatesVsJapan = { Team1Points = TeamPoints (unitedStates, (*TODO*)0<point>); Team2Points = TeamPoints (japan, (*TODO*)0<point>)
                                      Stage = groupB; KickOff = DateTime (2015, 10, 11, 20, 0, 0)
                                      Events = [ (*ManOfTheMatch ...*)
                                                 (* TODO *) (* unitedStates *)
                                                 (* TODO *) (* japan *)
                                                  ] }

    let groupBMatches = [ groupBSouthAfricaVsJapan; groupBSamoaVsUnitedStates; groupBScotlandVsJapan; groupBSouthAfricaVsSamoa; groupBScotlandVsUnitedStates
                          groupBSamoaVsJapan; groupBSouthAfricaVsScotland; groupBSouthAfricaVsUnitedStates; groupBSamoaVsScotland; groupBUnitedStatesVsJapan ]

    // Group C matches: https://en.wikipedia.org/wiki/2015_Rugby_World_Cup_Pool_C...

    let groupCTongaVsGeorgia = { Team1Points = TeamPoints (tonga, (*TODO*)0<point>); Team2Points = TeamPoints (georgia, (*TODO*)0<point>)
                                 Stage = groupC; KickOff = DateTime (2015, 9, 19, 12, 0, 0)
                                 Events = [ (*ManOfTheMatch ...*)
                                            (* TODO *) (* tonga *)
                                            (* TODO *) (* georgia *)
                                             ] }

    let groupCNewZealandVsArgentina = { Team1Points = TeamPoints (newZealand, (*TODO*)0<point>); Team2Points = TeamPoints (argentina, (*TODO*)0<point>)
                                        Stage = groupC; KickOff = DateTime (2015, 9, 20, 16, 45, 0)
                                        Events = [ (*ManOfTheMatch ...*)
                                                   (* TODO *) (* newZealand *)
                                                   (* TODO *) (* argentina *)
                                                    ] }

    let groupCNewZealandVsNamibia = { Team1Points = TeamPoints (newZealand, (*TODO*)0<point>); Team2Points = TeamPoints (namibia, (*TODO*)0<point>)
                                      Stage = groupC; KickOff = DateTime (2015, 9, 24, 20, 0, 0)
                                      Events = [ (*ManOfTheMatch ...*)
                                                 (* TODO *) (* newZealand *)
                                                 (* TODO *) (* namibia *)
                                                  ] }

    let groupCArgentinaVsGeorgia = { Team1Points = TeamPoints (argentina, (*TODO*)0<point>); Team2Points = TeamPoints (georgia, (*TODO*)0<point>)
                                     Stage = groupC; KickOff = DateTime (2015, 9, 25, 16, 45, 0)
                                     Events = [ (*ManOfTheMatch ...*)
                                                (* TODO *) (* argentina *)
                                                (* TODO *) (* georgia *)
                                                 ] }

    let groupCTongaVsNamibia = { Team1Points = TeamPoints (tonga, (*TODO*)0<point>); Team2Points = TeamPoints (namibia, (*TODO*)0<point>)
                                 Stage = groupC; KickOff = DateTime (2015, 9, 29, 16, 45, 0)
                                 Events = [ (*ManOfTheMatch ...*)
                                            (* TODO *) (* tonga *)
                                            (* TODO *) (* namibia *)
                                             ] }

    let groupCNewZealandVsGeorgia = { Team1Points = TeamPoints (newZealand, (*TODO*)0<point>); Team2Points = TeamPoints (georgia, (*TODO*)0<point>)
                                      Stage = groupC; KickOff = DateTime (2015, 10, 2, 20, 0, 0)
                                      Events = [ (*ManOfTheMatch ...*)
                                                 (* TODO *) (* newZealand *)
                                                 (* TODO *) (* georgia *)
                                                  ] }

    let groupCArgentinaVsTonga = { Team1Points = TeamPoints (argentina, (*TODO*)0<point>); Team2Points = TeamPoints (tonga, (*TODO*)0<point>)
                                   Stage = groupC; KickOff = DateTime (2015, 10, 4, 14, 30, 0)
                                   Events = [ (*ManOfTheMatch ...*)
                                              (* TODO *) (* argentina *)
                                              (* TODO *) (* tonga *)
                                               ] }

    let groupCNamibiaVsGeorgia = { Team1Points = TeamPoints (namibia, (*TODO*)0<point>); Team2Points = TeamPoints (georgia, (*TODO*)0<point>)
                                   Stage = groupC; KickOff = DateTime (2015, 10, 7, 20, 0, 0)
                                   Events = [ (*ManOfTheMatch ...*)
                                              (* TODO *) (* namibia *)
                                              (* TODO *) (* georgia *)
                                               ] }

    let groupCNewZealandVsTonga = { Team1Points = TeamPoints (newZealand, (*TODO*)0<point>); Team2Points = TeamPoints (tonga, (*TODO*)0<point>)
                                    Stage = groupC; KickOff = DateTime (2015, 10, 9, 20, 0, 0)
                                    Events = [ (*ManOfTheMatch ...*)
                                               (* TODO *) (* newZealand *)
                                               (* TODO *) (* tonga *)
                                                ] }

    let groupCArgentinaVsNamibia = { Team1Points = TeamPoints (argentina, (*TODO*)0<point>); Team2Points = TeamPoints (namibia, (*TODO*)0<point>)
                                     Stage = groupC; KickOff = DateTime (2015, 10, 11, 12, 0, 0)
                                     Events = [ (*ManOfTheMatch ...*)
                                                (* TODO *) (* argentina *)
                                                (* TODO *) (* namibia *)
                                                 ] }

    let groupCMatches = [ groupCTongaVsGeorgia; groupCNewZealandVsArgentina; groupCNewZealandVsNamibia; groupCArgentinaVsGeorgia; groupCTongaVsNamibia
                          groupCNewZealandVsGeorgia; groupCArgentinaVsTonga; groupCNamibiaVsGeorgia; groupCNewZealandVsTonga; groupCArgentinaVsNamibia ]

    // Group D matches: https://en.wikipedia.org/wiki/2015_Rugby_World_Cup_Pool_D...

    let groupDIrelandVsCanada = { Team1Points = TeamPoints (ireland, (*TODO*)0<point>); Team2Points = TeamPoints (canada, (*TODO*)0<point>)
                                  Stage = groupD; KickOff = DateTime (2015, 9, 19, 14, 30, 0)
                                  Events = [ (*ManOfTheMatch ...*)
                                             (* TODO *) (* ireland *)
                                             (* TODO *) (* canada *)
                                              ] }

    let groupDFranceVsItaly = { Team1Points = TeamPoints (france, (*TODO*)0<point>); Team2Points = TeamPoints (italy, (*TODO*)0<point>)
                                Stage = groupD; KickOff = DateTime (2015, 9, 19, 20, 0, 0)
                                Events = [ (*ManOfTheMatch ...*)
                                           (* TODO *) (* france *)
                                           (* TODO *) (* italy *)
                                            ] }

    let groupDFranceVsRomania = { Team1Points = TeamPoints (france, (*TODO*)0<point>); Team2Points = TeamPoints (romania, (*TODO*)0<point>)
                                  Stage = groupD; KickOff = DateTime (2015, 9, 23, 20, 0, 0)
                                  Events = [ (*ManOfTheMatch ...*)
                                             (* TODO *) (* france *)
                                             (* TODO *) (* romania *)
                                              ] }

    let groupDItalyVsCanada = { Team1Points = TeamPoints (italy, (*TODO*)0<point>); Team2Points = TeamPoints (canada, (*TODO*)0<point>)
                                Stage = groupD; KickOff = DateTime (2015, 9, 26, 14, 30, 0)
                                Events = [ (*ManOfTheMatch ...*)
                                           (* TODO *) (* italy *)
                                           (* TODO *) (* canada *)
                                            ] }

    let groupDIrelandVsRomania = { Team1Points = TeamPoints (ireland, (*TODO*)0<point>); Team2Points = TeamPoints (romania, (*TODO*)0<point>)
                                   Stage = groupD; KickOff = DateTime (2015, 9, 27, 16, 45, 0)
                                   Events = [ (*ManOfTheMatch ...*)
                                              (* TODO *) (* ireland *)
                                              (* TODO *) (* romania *)
                                               ] }

    let groupDFranceVsCanada = { Team1Points = TeamPoints (france, (*TODO*)0<point>); Team2Points = TeamPoints (canada, (*TODO*)0<point>)
                                 Stage = groupD; KickOff = DateTime (2015, 10, 1, 20, 0, 0)
                                 Events = [ (*ManOfTheMatch ...*)
                                            (* TODO *) (* france *)
                                            (* TODO *) (* canada *)
                                             ] }

    let groupDIrelandVsItaly = { Team1Points = TeamPoints (ireland, (*TODO*)0<point>); Team2Points = TeamPoints (italy, (*TODO*)0<point>)
                                 Stage = groupD; KickOff = DateTime (2015, 10, 4, 16, 45, 0)
                                 Events = [ (*ManOfTheMatch ...*)
                                            (* TODO *) (* ireland *)
                                            (* TODO *) (* italy *)
                                             ] }

    let groupDCanadaVsRomania = { Team1Points = TeamPoints (canada, (*TODO*)0<point>); Team2Points = TeamPoints (romania, (*TODO*)0<point>)
                                  Stage = groupD; KickOff = DateTime (2015, 10, 6, 16, 45, 0)
                                  Events = [ (*ManOfTheMatch ...*)
                                             (* TODO *) (* canada *)
                                             (* TODO *) (* romania *)
                                              ] }

    let groupDItalyVsRomania = { Team1Points = TeamPoints (italy, (*TODO*)0<point>); Team2Points = TeamPoints (romania, (*TODO*)0<point>)
                                 Stage = groupD; KickOff = DateTime (2015, 10, 11, 14, 30, 0)
                                 Events = [ (*ManOfTheMatch ...*)
                                            (* TODO *) (* italy *)
                                            (* TODO *) (* romania *)
                                             ] }

    let groupDFranceVsIreland = { Team1Points = TeamPoints (france, (*TODO*)0<point>); Team2Points = TeamPoints (ireland, (*TODO*)0<point>)
                                  Stage = groupD; KickOff = DateTime (2015, 10, 11, 16, 45, 0)
                                  Events = [ (*ManOfTheMatch ...*)
                                             (* TODO *) (* france *)
                                             (* TODO *) (* ireland *)
                                              ] }

    let groupDMatches = [ groupDIrelandVsCanada; groupDFranceVsItaly; groupDFranceVsRomania; groupDItalyVsCanada; groupDIrelandVsRomania
                          groupDFranceVsCanada; groupDIrelandVsItaly; groupDCanadaVsRomania; groupDItalyVsRomania; groupDFranceVsIreland ]

    // Knockout matches: https://en.wikipedia.org/wiki/2015_Rugby_World_Cup_knockout_stage...

    // TODO [NMB]: Remove these once known...
    let groupAWinner = { Name = "Group A winner"; Status = Active; Seeding = None; Coach = "N/A" }
    let groupARunnerUp = { Name = "Group A runner-up"; Status = Active; Seeding = None; Coach = "N/A" }
    let groupBWinner = { Name = "Group B winner"; Status = Active; Seeding = None; Coach = "N/A" }
    let groupBRunnerUp = { Name = "Group B runner-up"; Status = Active; Seeding = None; Coach = "N/A" }
    let groupCWinner = { Name = "Group C winner"; Status = Active; Seeding = None; Coach = "N/A" }
    let groupCRunnerUp = { Name = "Group C runner-up"; Status = Active; Seeding = None; Coach = "N/A" }
    let groupDWinner = { Name = "Group D winner"; Status = Active; Seeding = None; Coach = "N/A" }
    let groupDRunnerUp = { Name = "Group D runner-up"; Status = Active; Seeding = None; Coach = "N/A" }
    let quarterFinal1Winner = { Name = "Quarter-final 1 winner"; Status = Active; Seeding = None; Coach = "N/A" }
    let quarterFinal2Winner = { Name = "Quarter-final 2 winner"; Status = Active; Seeding = None; Coach = "N/A" }
    let quarterFinal3Winner = { Name = "Quarter-final 3 winner"; Status = Active; Seeding = None; Coach = "N/A" }
    let quarterFinal4Winner = { Name = "Quarter-final 4 winner"; Status = Active; Seeding = None; Coach = "N/A" }
    let semiFinal1Winner = { Name = "Semi-final 1 winner"; Status = Active; Seeding = None; Coach = "N/A" }
    let semiFinal1Loser = { Name = "Semi-final 1 loser"; Status = Active; Seeding = None; Coach = "N/A" }
    let semiFinal2Winner = { Name = "Semi-final 2 winner"; Status = Active; Seeding = None; Coach = "N/A" }
    let semiFinal2Loser = { Name = "Semi-final 2 loser"; Status = Active; Seeding = None; Coach = "N/A" }

    let quarterFinal1B1VsA2 = { Team1Points = TeamPoints (groupBWinner, (*TODO*)0<point>); Team2Points = TeamPoints (groupARunnerUp, (*TODO*)0<point>)
                                Stage = QuarterFinal 1; KickOff = DateTime (2015, 10, 17, 16, 0, 0)
                                Events = [ (*ManOfTheMatch ...*)
                                           (* TODO *) (* B1 [TBC] *)
                                           (* TODO *) (* A2 [TBC] *)
                                            ] }

    let quarterFinal2C1VsD2 = { Team1Points = TeamPoints (groupCWinner, (*TODO*)0<point>); Team2Points = TeamPoints (groupDRunnerUp, (*TODO*)0<point>)
                                Stage = QuarterFinal 2; KickOff = DateTime (2015, 10, 17, 20, 0, 0)
                                Events = [ (*ManOfTheMatch ...*)
                                           (* TODO *) (* C1 [TBC] *)
                                           (* TODO *) (* D2 [TBC] *)
                                            ] }

    let quarterFinal3D1VsC2 = { Team1Points = TeamPoints (groupDWinner, (*TODO*)0<point>); Team2Points = TeamPoints (groupCRunnerUp, (*TODO*)0<point>)
                                Stage = QuarterFinal 3; KickOff = DateTime (2015, 10, 18, 13, 0, 0)
                                Events = [ (*ManOfTheMatch ...*)
                                           (* TODO *) (* D1 [TBC] *)
                                           (* TODO *) (* C2 [TBC] *)
                                            ] }

    let quarterFinal4A1VsB2 = { Team1Points = TeamPoints (groupAWinner, (*TODO*)0<point>); Team2Points = TeamPoints (groupBRunnerUp, (*TODO*)0<point>)
                                Stage = QuarterFinal 4; KickOff = DateTime (2015, 10, 18, 16, 0, 0)
                                Events = [ (*ManOfTheMatch ...*)
                                           (* TODO *) (* A1 [TBC] *)
                                           (* TODO *) (* B2 [TBC] *)
                                            ] }

    let semiFinal1QF1VsQF2 = { Team1Points = TeamPoints (quarterFinal1Winner, (*TODO*)0<point>); Team2Points = TeamPoints (quarterFinal2Winner, (*TODO*)0<point>)
                               Stage = SemiFinal 1; KickOff = DateTime (2015, 10, 24, 16, 0, 0)
                               Events = [ (*ManOfTheMatch ...*)
                                          (* TODO *) (* QF1 [TBC] *)
                                          (* TODO *) (* QF2 [TBC] *)
                                           ] }

    let semiFinal2QF3VsQF4 = { Team1Points = TeamPoints (quarterFinal3Winner, (*TODO*)0<point>); Team2Points = TeamPoints (quarterFinal4Winner, (*TODO*)0<point>)
                               Stage = SemiFinal 2; KickOff = DateTime (2015, 10, 25, 16, 0, 0)
                               Events = [ (*ManOfTheMatch ...*)
                                          (* TODO *) (* QF3 [TBC] *)
                                          (* TODO *) (* QF4 [TBC] *)
                                           ] }

    let bronzeFinal1SF1VsSF2 = { Team1Points = TeamPoints (semiFinal1Loser, (*TODO*)0<point>); Team2Points = TeamPoints (semiFinal2Loser, (*TODO*)0<point>)
                                 Stage = BronzeFinal; KickOff = DateTime (2015, 10, 30, 20, 0, 0)
                                 Events = [ (*ManOfTheMatch ...*)
                                            (* TODO *) (* SF1 [TBC] *)
                                            (* TODO *) (* SF2 [TBC] *)
                                             ] }

    let final1SF1VsSF2 = { Team1Points = TeamPoints (semiFinal1Winner, (*TODO*)0<point>); Team2Points = TeamPoints (semiFinal2Winner, (*TODO*)0<point>)
                           Stage = Final; KickOff = DateTime (2015, 10, 31, 16, 0, 0)
                           Events = [ (*ManOfTheMatch ...*)
                                      (* TODO *) (* SF1 [TBC] *)
                                      (* TODO *) (* SF2 [TBC] *)
                                       ] }

    let knockoutMatches = [ quarterFinal1B1VsA2; quarterFinal2C1VsD2; quarterFinal3D1VsC2; quarterFinal4A1VsB2
                            semiFinal1QF1VsQF2; semiFinal2QF3VsQF4; bronzeFinal1SF1VsSF2; final1SF1VsSF2 ]

    let matches = groupAMatches @ groupBMatches @ groupCMatches @ groupDMatches @ knockoutMatches
