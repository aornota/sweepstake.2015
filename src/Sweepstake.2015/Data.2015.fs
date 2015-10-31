namespace AOrNotA.Sweepstake2015

open System

open AOrNotA.Sweepstake2015.Domain

module ``Data 2015`` =

    // 2015 squads: https://en.wikipedia.org/wiki/2015_Rugby_World_Cup_squads...

    let newZealand = { Name = "New Zealand"; Status = Eliminated; Seeding = Some 1; Coach = "Steve Hansen" }

    let colesDane = { Name = "Dane Coles"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let mealamuKeven = { Name = "Keven Mealamu"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let taylorCodie = { Name = "Codie Taylor"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let crockettWyatt = { Name = "Wyatt Crockett"; Team = newZealand; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 10, 29))) }
    let faumuinaCharlie = { Name = "Charlie Faumuina"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let franksBen = { Name = "Ben Franks"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let franksOwen = { Name = "Owen Franks"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let manuPauliasi = { Name = "Pauliasi Manu"; Team = newZealand; Type = Forward; Status = Replacement (Some (DateTime (2015, 10, 29))) }
    let moodyJoe = { Name = "Joe Moody"; Team = newZealand; Type = Forward; Status = Replacement (Some (DateTime (2015, 10, 10))) }
    let woodcockTony = { Name = "Tony Woodcock"; Team = newZealand; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 10, 10))) }
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
                                        manuPauliasi; moodyJoe; woodcockTony; retallickBrodie; romanoLuke; whitelockSam; caneSam
                                        kainoJerome; mcCawRichie; messamLiam; readKieran; vitoVictor; kerrBarlowTawera; perenaraTJ
                                        smithAaron; barrettBeauden; carterDan; sladeColin; fekitoaMalakai; nonuMa'a; smithConrad
                                        williamsSonnyBill; naholoWaisake; saveaJulian; milnerSkudderNehe; smithBen ] }

    let southAfrica = { Name = "South Africa"; Status = Eliminated; Seeding = Some 2; Coach = "Heyneke Meyer" }

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
    let deVilliersJean = { Name = "Jean de Villiers"; Team = southAfrica; Type = Back; Status = Withdrawn (Some (DateTime (2015, 9, 27))) }
    let krielJesse = { Name = "Jesse Kriel"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let serfonteinJan = { Name = "Jan Serfontein"; Team = southAfrica; Type = Back; Status = Replacement (Some (DateTime (2015, 9, 27))) }
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
                                         serfonteinJan; habanaBryan; mvovoLwazi; pietersenJP; kirchnerZane; leRouxWillie ] }

    let australia = { Name = "Australia"; Status = Eliminated; Seeding = Some 3; Coach = "Michael Cheika" }

    let hansonJames = { Name = "James Hanson"; Team = australia; Type = Forward; Status = Replacement (Some (DateTime (2015, 9, 29))) }
    let mooreStephen = { Name = "Stephen Moore"; Team = australia; Type = Forward; Status = OriginalSquad }
    let polotaNauTatafu = { Name = "Tatafu Polota-Nau"; Team = australia; Type = Forward; Status = OriginalSquad }
    let holmesGreg = { Name = "Greg Holmes"; Team = australia; Type = Forward; Status = OriginalSquad }
    let kepuSekope = { Name = "Sekope Kepu"; Team = australia; Type = Forward; Status = OriginalSquad }
    let sioScott = { Name = "Scott Sio"; Team = australia; Type = Forward; Status = OriginalSquad }
    let slipperJames = { Name = "James Slipper"; Team = australia; Type = Forward; Status = OriginalSquad }
    let smithToby = { Name = "Toby Smith"; Team = australia; Type = Forward; Status = OriginalSquad }
    let carterSam = { Name = "Sam Carter"; Team = australia; Type = Forward; Status = Replacement (Some (DateTime (2015, 9, 29))) }
    let douglasKane = { Name = "Kane Douglas"; Team = australia; Type = Forward; Status = OriginalSquad }
    let mummDean = { Name = "Dean Mumm"; Team = australia; Type = Forward; Status = OriginalSquad }
    let simmonsRob = { Name = "Rob Simmons"; Team = australia; Type = Forward; Status = OriginalSquad }
    let skeltonWill = { Name = "Will Skelton"; Team = australia; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 9, 29))) }
    let fardyScott = { Name = "Scott Fardy"; Team = australia; Type = Forward; Status = OriginalSquad }
    let hooperMichael = { Name = "Michael Hooper"; Team = australia; Type = Forward; Status = OriginalSquad }
    let mcMahonSean = { Name = "Sean McMahon"; Team = australia; Type = Forward; Status = OriginalSquad }
    let pocockDavid = { Name = "David Pocock"; Team = australia; Type = Forward; Status = OriginalSquad }
    let mcCalmanBen = { Name = "Ben McCalman"; Team = australia; Type = Forward; Status = OriginalSquad }
    let paluWycliff = { Name = "Wycliff Palu"; Team = australia; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 9, 29))) }
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
                           Players = [ hansonJames; mooreStephen; polotaNauTatafu; holmesGreg; kepuSekope; sioScott; slipperJames
                                       smithToby; carterSam; douglasKane; mummDean; simmonsRob; skeltonWill; fardyScott; hooperMichael
                                       mcMahonSean; pocockDavid; mcCalmanBen; paluWycliff; geniaWill; phippsNick; cooperQuade; foleyBernard
                                       bealeKurtley; giteauMatt; kuridraniTevita; toomuaMatt; ashleyCooperAdam; horneRob; mitchellDrew;
                                       speightHenry; tomaneJoe; folauIsrael ] }

    let france = { Name = "France"; Status = Eliminated; Seeding = Some 4; Coach = "Philippe Saint-André" }

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
    let grossoRemy = { Name = "Rémy Grosso"; Team = france; Type = Back; Status = Replacement (Some (DateTime (2015, 9, 20))) }
    let guitouneSofiane = { Name = "Sofiane Guitoune"; Team = france; Type = Back; Status = OriginalSquad }
    let hugetYoann = { Name = "Yoann Huget"; Team = france; Type = Back; Status = Withdrawn (Some (DateTime (2015, 9, 20))) }
    let nakaitaciNoa = { Name = "Noa Nakaitaci"; Team = france; Type = Back; Status = OriginalSquad }
    let dulinBrice = { Name = "Brice Dulin"; Team = france; Type = Back; Status = OriginalSquad }
    let speddingScott = { Name = "Scott Spedding"; Team = france; Type = Back; Status = OriginalSquad }

    let franceSquad = { Team = france
                        Players = [ guiradoGuilhem; kayserBenjamin; szarzewskiDimitri; atoniaUini; benArousEddy; debatyVincent; masNicolas
                                    slimaniRabah; flanquartAlexandre; maestriYoann; papePascal; dusautoirThierry; leRouxBernard
                                    nyangaYannick; ouedraogoFulgence; choulyDamien; picamolesLouis; kockottRory; parraMorgan
                                    tillousBordeSebastien; michalakFrederic; talesRemi; bastareaudMathieu; dumoulinAlexandre; fickouGael
                                    fofanaWesley; grossoRemy; guitouneSofiane; hugetYoann; nakaitaciNoa; dulinBrice; speddingScott ] }

    let england = { Name = "England"; Status = Eliminated; Seeding = Some 5; Coach = "Stuart Lancaster" }

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
    let easterNick = { Name = "Nick Easter"; Team = england; Type = Forward; Status = Replacement (Some (DateTime (2015, 9, 28))) }
    let morganBen = { Name = "Ben Morgan"; Team = england; Type = Forward; Status = OriginalSquad }
    let vunipolaBilly = { Name = "Billy Vunipola"; Team = england; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 9, 28))) }
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
                                     easterNick; morganBen; vunipolaBilly; careDanny; wigglesworthRichard; youngsBen; farrellOwen
                                     fordGeorge; barrittBrad; burgessSam; josephJonathan; sladeHenry; mayJonny; nowellJack; watsonAnthony
                                     brownMike; goodeAlex ] }

    let ireland = { Name = "Ireland"; Status = Eliminated; Seeding = Some 6; Coach = "Joe Schmidt" }

    let bestRory = { Name = "Rory Best"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let croninSean = { Name = "Sean Cronin"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let straussRichardt = { Name = "Richardt Strauss"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let whiteNathan = { Name = "Nathan White"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let furlongTadhg = { Name = "Tadhg Furlong"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let healyCian = { Name = "Cian Healy"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let mcGrathJack = { Name = "Jack McGrath"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let rossMike = { Name = "Mike Ross"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let hendersonIain = { Name = "Iain Henderson"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let o'ConnellPaul = { Name = "Paul O'Connell"; Team = ireland; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 10, 13))) }
    let mcCarthyMike = { Name = "Mike McCarthy"; Team = ireland; Type = Forward; Status = Replacement (Some (DateTime (2015, 10, 13))) }
    let ryanDonnacha = { Name = "Donnacha Ryan"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let tonerDevin = { Name = "Devin Toner"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let henryChris = { Name = "Chris Henry"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let murphyJordi = { Name = "Jordi Murphy"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let o'BrienSean = { Name = "Seán O'Brien"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let o'MahonyPeter = { Name = "Peter O'Mahony"; Team = ireland; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 10, 12))) }
    let ruddockRhys = { Name = "Rhys Ruddock"; Team = ireland; Type = Forward; Status = Replacement (Some (DateTime (2015, 10, 12))) }
    let heaslipJamie = { Name = "Jamie Heaslip"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let murrayConor = { Name = "Conor Murray"; Team = ireland; Type = Back; Status = OriginalSquad }
    let bossIsaac = { Name = "Isaac Boss"; Team = ireland; Type = Back; Status = Replacement (Some (DateTime (2015, 10, 17))) }
    let reddanEoin = { Name = "Eoin Reddan"; Team = ireland; Type = Back; Status = OriginalSquad }
    let jacksonPaddy = { Name = "Paddy Jackson"; Team = ireland; Type = Back; Status = OriginalSquad }
    let madiganIan = { Name = "Ian Madigan"; Team = ireland; Type = Back; Status = OriginalSquad }
    let sextonJonathan = { Name = "Jonathan Sexton"; Team = ireland; Type = Back; Status = OriginalSquad }
    let caveDarren = { Name = "Darren Cave"; Team = ireland; Type = Back; Status = OriginalSquad }
    let earlsKeith = { Name = "Keith Earls"; Team = ireland; Type = Back; Status = OriginalSquad }
    let henshawRobbie = { Name = "Robbie Henshaw"; Team = ireland; Type = Back; Status = OriginalSquad }
    let payneJared = { Name = "Jared Payne"; Team = ireland; Type = Back; Status = Withdrawn (Some (DateTime (2015, 10, 10))) }
    let boweTommy = { Name = "Tommy Bowe"; Team = ireland; Type = Back; Status = OriginalSquad }
    let fitzgeraldLuke = { Name = "Luke Fitzgerald"; Team = ireland; Type = Back; Status = OriginalSquad }
    let kearneyDavid = { Name = "David Kearney"; Team = ireland; Type = Back; Status = OriginalSquad }
    let zeboSimon = { Name = "Simon Zebo"; Team = ireland; Type = Back; Status = OriginalSquad }
    let kearneyRob = { Name = "Rob Kearney"; Team = ireland; Type = Back; Status = OriginalSquad }

    let irelandSquad = { Team = ireland
                         Players = [ bestRory; croninSean; straussRichardt; whiteNathan; furlongTadhg; healyCian; mcGrathJack; rossMike
                                     hendersonIain; o'ConnellPaul; mcCarthyMike; ryanDonnacha; tonerDevin; henryChris; murphyJordi
                                     o'BrienSean; o'MahonyPeter; ruddockRhys; heaslipJamie; murrayConor; bossIsaac; reddanEoin
                                     jacksonPaddy; madiganIan; sextonJonathan; caveDarren; earlsKeith; henshawRobbie; payneJared
                                     boweTommy; fitzgeraldLuke; kearneyDavid; zeboSimon; kearneyRob ] }

    let samoa = { Name = "Samoa"; Status = Eliminated; Seeding = Some 7; Coach = "Stephan Betham" }

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

    let argentina = { Name = "Argentina"; Status = Eliminated; Seeding = Some 8; Coach = "Daniel Hourcade" }

    let creevyAgustin = { Name = "Agustín Creevy"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let montoyaJulian = { Name = "Julián Montoya"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let ayerzaMarcos = { Name = "Marcos Ayerza"; Team = argentina; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 10, 29))) }
    let figalloJuan = { Name = "Juan Figallo"; Team = argentina; Type = Forward; Status = Replacement (Some (DateTime (2015, 10, 15))) }
    let bottaSantiagoGarcia = { Name = "Santiago García Botta"; Team = argentina; Type = Forward; Status = Replacement (Some (DateTime (2015, 10, 29))) }
    let orlandiJuanPablo = { Name = "Juan Pablo Orlandi"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let herreraRamiro = { Name = "Ramiro Herrera"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let pazLucasNoguera = { Name = "Lucas Noguera Paz"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let chaparroNahuelTetaz = { Name = "Nahuel Tetaz Chaparro"; Team = argentina; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 10, 15))) }
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
    let moroniMatias = { Name = "Matías Moroni"; Team = argentina; Type = Back; Status = OriginalSquad }
    let socinoJuanPablo = { Name = "Juan Pablo Socino"; Team = argentina; Type = Back; Status = OriginalSquad }
    let agullaHoracio = { Name = "Horacio Agulla"; Team = argentina; Type = Back; Status = OriginalSquad }
    let corderoSantiago = { Name = "Santiago Cordero"; Team = argentina; Type = Back; Status = OriginalSquad }
    let imhoffJuan = { Name = "Juan Imhoff"; Team = argentina; Type = Back; Status = OriginalSquad }
    let amorosinoLucasGonzalez = { Name = "Lucas González Amorosino"; Team = argentina; Type = Back; Status = OriginalSquad }
    let tuculetJoaquin = { Name = "Joaquín Tuculet"; Team = argentina; Type = Back; Status = OriginalSquad }

    let argentinaSquad = { Team = argentina
                           Players = [ creevyAgustin; montoyaJulian; ayerzaMarcos; figalloJuan; bottaSantiagoGarcia; orlandiJuanPablo
                                       herreraRamiro; pazLucasNoguera; chaparroNahuelTetaz; alemannoMatias; galarzaMariano; lavaniniTomas
                                       pagadizabalGuidoPetti; lobbeJuanMartinFernandez; leguizamonJuanManuel; materaPablo
                                       desioJavierOrtega; isaFacundo; senatoreLeonardo; cubelliTomas; landajoMartin
                                       iglesiasSantiagoGonzalez; sanchezNicolas; boschMarcelo; delaFuenteJeronimo; hernandezJuanMartin
                                       moroniMatias; socinoJuanPablo; agullaHoracio; corderoSantiago; imhoffJuan; amorosinoLucasGonzalez
                                       tuculetJoaquin ] }

    let wales = { Name = "Wales"; Status = Eliminated; Seeding = Some 9; Coach = "Warren Gatland" }

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
    let anscombeGareth = { Name = "Gareth Anscombe"; Team = wales; Type = Back; Status = Replacement (Some (DateTime (2015, 9, 28))) }
    let biggarDan = { Name = "Dan Biggar"; Team = wales; Type = Back; Status = OriginalSquad }
    let priestlandRhys = { Name = "Rhys Priestland"; Team = wales; Type = Back; Status = OriginalSquad }
    let allenCory = { Name = "Cory Allen"; Team = wales; Type = Back; Status = Withdrawn (Some (DateTime (2015, 9, 21))) }
    let hookJames = { Name = "James Hook"; Team = wales; Type = Back; Status = Replacement (Some (DateTime (2015, 9, 28))) }
    let morganTyler = { Name = "Tyler Morgan"; Team = wales; Type = Back; Status = Replacement (Some (DateTime (2015, 9, 21))) }
    let robertsJamie = { Name = "Jamie Roberts"; Team = wales; Type = Back; Status = OriginalSquad }
    let williamsScott = { Name = "Scott Williams"; Team = wales; Type = Back; Status = Withdrawn (Some (DateTime (2015, 9, 28))) }
    let amosHallam = { Name = "Hallam Amos"; Team = wales; Type = Back; Status = Withdrawn (Some (DateTime (2015, 9, 28))) }
    let cuthbertAlex = { Name = "Alex Cuthbert"; Team = wales; Type = Back; Status = OriginalSquad }
    let northGeorge = { Name = "George North"; Team = wales; Type = Back; Status = OriginalSquad }
    let walkerEli = { Name = "Eli Walker"; Team = wales; Type = Back; Status = Replacement (Some (DateTime (2015, 10, 13))) }
    let williamsLiam = { Name = "Liam Williams"; Team = wales; Type = Back; Status = Withdrawn (Some (DateTime (2015, 10, 11))) }
    let morganMatthew = { Name = "Matthew Morgan"; Team = wales; Type = Back; Status = OriginalSquad }

    let walesSquad = { Team = wales
                       Players = [ baldwinScott; owensKen; francisTomas; jamesPaul; jarvisAaron; jenkinsGethin; leeSamson; ballJake
                                   charterisLuke; daviesBradley; dayDominic; jonesAlunWyn; kingJames; lydiateDan; tipuricJustin
                                   moriartyRoss; warburtonSam; faletauTaulupe; daviesGareth; phillipsMike; williamsLloyd; anscombeGareth
                                   biggarDan; priestlandRhys; allenCory; hookJames; morganTyler; robertsJamie; williamsScott; amosHallam
                                   cuthbertAlex; northGeorge; walkerEli; williamsLiam; morganMatthew ] }

    let italy = { Name = "Italy"; Status = Eliminated; Seeding = Some 10; Coach = "Jacques Brunel" }

    let ghiraldiniLeonardo = { Name = "Leonardo Ghiraldini"; Team = italy; Type = Forward; Status = OriginalSquad }
    let giazzonDavide = { Name = "Davide Giazzon"; Team = italy; Type = Forward; Status = OriginalSquad }
    let maniciAndrea = { Name = "Andrea Manici"; Team = italy; Type = Forward; Status = OriginalSquad }
    let agueroMatias = { Name = "Matías Agüero"; Team = italy; Type = Forward; Status = OriginalSquad }
    let castrogiovanniMartin = { Name = "Martin Castrogiovanni"; Team = italy; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 10, 5))) }
    let chistoliniDario = { Name = "Dario Chistolini"; Team = italy; Type = Forward; Status = OriginalSquad }
    let cittadiniLorenzo = { Name = "Lorenzo Cittadini"; Team = italy; Type = Forward; Status = OriginalSquad }
    let deMarchiAlberto = { Name = "Alberto De Marchi"; Team = italy; Type = Forward; Status = Replacement (Some (DateTime (2015, 10, 5))) }
    let lovottiAndrea = { Name = "Andrea Lovotti"; Team = italy; Type = Forward; Status = Replacement (Some (DateTime (2015, 10, 5))) }
    let rizzoMichele = { Name = "Michele Rizzo"; Team = italy; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 10, 5))) }
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
    let visentinMichele = { Name = "Michele Visentin"; Team = italy; Type = Back; Status = Replacement (Some (DateTime (2015, 9, 21))) }
    let masiAndrea = { Name = "Andrea Masi"; Team = italy; Type = Back; Status = Withdrawn (Some (DateTime (2015, 9, 21))) }
    let mcLeanLuke = { Name = "Luke McLean"; Team = italy; Type = Back; Status = OriginalSquad }

    let italySquad = { Team = italy
                       Players = [ ghiraldiniLeonardo; giazzonDavide; maniciAndrea; agueroMatias; castrogiovanniMartin; chistoliniDario
                                   cittadiniLorenzo; deMarchiAlberto; lovottiAndrea; rizzoMichele; bernaboValerio; furnoJoshua; fuserMarco
                                   geldenhuysQuintin; bergamascoMauro; favaroSimone; mintoFrancesco; vunisaSamuela; zanniAlessandro
                                   parisseSergio; goriEdoardo; palazzaniGuglielmo; violiMarcello; allanTommaso; cannaCarlo; bacchinEnrico
                                   benvenutiTommaso; campagnaroMichele; garciaGonzalo; sartoLeonardo; vendittiGiovanbattista; masiAndrea
                                   visentinMichele; mcLeanLuke ] }

    let tonga = { Name = "Tonga"; Status = Eliminated; Seeding = Some 11; Coach = "Mana Otai" }

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

    let scotland = { Name = "Scotland"; Status = Eliminated; Seeding = Some 12; Coach = "Vern Cotter" }

    let brownFraser = { Name = "Fraser Brown"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let bryceKevin = { Name = "Kevin Bryce"; Team = scotland; Type = Forward; Status = Replacement (Some (DateTime (2015, 9, 14))) }
    let fordRoss = { Name = "Ross Ford"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let mcInallyStuart = { Name = "Stuart McInally"; Team = scotland; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 9, 14))) }
    let dickinsonAlasdair = { Name = "Alasdair Dickinson"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let grantRyan = { Name = "Ryan Grant"; Team = scotland; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 9, 17))) }
    let nelWP = { Name = "WP Nel"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let reidGordon = { Name = "Gordon Reid"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let sutherlandRory = { Name = "Rory Sutherland"; Team = scotland; Type = Forward; Status = Replacement (Some (DateTime (2015, 9, 17))) }
    let welshJon = { Name = "Jon Welsh"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let gilchristGrant = { Name = "Grant Gilchrist"; Team = scotland; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 9, 29))) }
    let grayJonny = { Name = "Jonny Gray"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let grayRichie = { Name = "Richie Gray"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let swinsonTim = { Name = "Tim Swinson"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let cowanBlair = { Name = "Blair Cowan"; Team = scotland; Type = Forward; Status = Replacement (Some (DateTime (2015, 9, 29))) }
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
                                      sutherlandRory; welshJon; gilchristGrant; grayJonny; grayRichie; swinsonTim; cowanBlair; hardieJohn
                                      strokoschAlasdair; wilsonRyan; dentonDavid; straussJosh; hidalgoClyneSam; laidlawGreig; pyrgosHenry
                                      russellFinn; weirDuncan; bennettMark; hornePeter; scottMatt; vernonRichie; lamontSean; maitlandSean
                                      seymourTommy; visserTim; hoggStuart ] }

    let fiji = { Name = "Fiji"; Status = Eliminated; Seeding = None; Coach = "John McKee" }

    let kotoSunia = { Name = "Sunia Koto"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let tuapatiTalemaitoga = { Name = "Talemaitoga Tuapati"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let veikosoViliame = { Name = "Viliame Veikoso"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let atalifoLeeroy = { Name = "Lee-roy Atalifo"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let colatiIsei = { Name = "Isei Colati"; Team = fiji; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 9, 27))) }
    let koroiTaniela = { Name = "Taniela Koroi"; Team = fiji; Type = Forward; Status = Replacement (Some (DateTime (2015, 9, 27))) }
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
    let nayacalevuWaisea = { Name = "Waisea Nayacalevu"; Team = fiji; Type = Back; Status = Withdrawn (Some (DateTime (2015, 9, 25))) }
    let nagusaTimoci = { Name = "Timoci Nagusa"; Team = fiji; Type = Back; Status = Replacement (Some (DateTime (2015, 9, 25))) }
    let tikoirotumaAsaeli = { Name = "Asaeli Tikoirotuma"; Team = fiji; Type = Back; Status = OriginalSquad }
    let murimurivaluKini = { Name = "Kini Murimurivalu"; Team = fiji; Type = Back; Status = OriginalSquad }
    let talebulaMetuisela = { Name = "Metuisela Talebula"; Team = fiji; Type = Back; Status = OriginalSquad }

    let fijiSquad = { Team = fiji
                      Players = [ kotoSunia; tuapatiTalemaitoga; veikosoViliame; atalifoLeeroy; colatiIsei; koroiTaniela; ma'afuCampese
                                  ravaiPeni; sauloManasa; cavubatiTevita; nakarawaLeone; ratuniyarawaApi; soqetaNemia; qeraAkapusi
                                  ravuloMalakai; waqaniburotuDominiko; yatoPeceli; matadigoSakiusa; taleiNetani; kenataleNemia
                                  matawaluNikola; seniloliHenry; matavesiJosh; volavolaBen; botiaLevani; gonevaVereniki; lovobalavuGabiriele
                                  nadoloNemani; nayacalevuWaisea; nagusaTimoci; tikoirotumaAsaeli; murimurivaluKini; talebulaMetuisela ] }

    let uruguay = { Name = "Uruguay"; Status = Eliminated; Seeding = None; Coach = "Pablo Lemoine" }

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

    let japan = { Name = "Japan"; Status = Eliminated; Seeding = None; Coach = "Eddie Jones" }

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

    let unitedStates = { Name = "United States"; Status = Eliminated; Seeding = None; Coach = "Mike Tolkin" }

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

    let georgia = { Name = "Georgia"; Status = Eliminated; Seeding = None; Coach = "Milton Haig" }

    let bregvadzeJaba = { Name = "Jaba Bregvadze"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let mamukashviliShalva = { Name = "Shalva Mamukashvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let maisuradzeSimon = { Name = "Simon Maisuradze"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let asieshviliKakha = { Name = "Kakha Asieshvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let chilachavaLevan = { Name = "Levan Chilachava"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let kubriashviliDavit = { Name = "Davit Kubriashvili"; Team = georgia; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 9, 29))) }
    let nariashviliMikheil = { Name = "Mikheil Nariashvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let peikrishviliAnton = { Name = "Anton Peikrishvili"; Team = georgia; Type = Forward; Status = Replacement (Some (DateTime (2015, 9, 29))) }
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
                                     nariashviliMikheil; peikrishviliAnton; zirakashviliDavit; chkhaidzeGiorgi; datunashviliLevan
                                     mikautadzeKonstantin; nemsadzeGiorgi; gorgodzeMamuka; kolelishviliViktor; sutiashviliShalva
                                     tkhilaishviliGiorgi; lomidzeLasha; begadzeGiorgi; khutsishviliVazha; lobzhanidzeVasil; khmaladzeLasha
                                     malaghuradzeLasha; kacharavaDavit; sharikadzeMerab; aptsiauriGiorgi; mchedlidzeTamaz; giorgadzeMuraz
                                     pruidzeGiorgi; toduaAlexander; kvirikashviliMerab; tsiklauriBeka ] }

    let namibia = { Name = "Namibia"; Status = Eliminated; Seeding = None; Coach = "Phil Davies" }

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

    let canada = { Name = "Canada"; Status = Eliminated; Seeding = None; Coach = "Kieran Crowley" }

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
    let underwoodLiam = { Name = "Liam Underwood"; Team = canada; Type = Back; Status = Withdrawn (Some (DateTime (2015, 9, 24))) }
    let blevinsNick = { Name = "Nick Blevins"; Team = canada; Type = Back; Status = OriginalSquad }
    let braidConnor = { Name = "Connor Braid"; Team = canada; Type = Back; Status = Withdrawn (Some (DateTime (2015, 9, 28))) }
    let hearnCiaran = { Name = "Ciaran Hearn"; Team = canada; Type = Back; Status = OriginalSquad }
    let parfreyPat = { Name = "Pat Parfrey"; Team = canada; Type = Back; Status = Replacement (Some (DateTime (2015, 9, 28))) }
    let trainorConor = { Name = "Conor Trainor"; Team = canada; Type = Back; Status = OriginalSquad }
    let hasslerJeff = { Name = "Jeff Hassler"; Team = canada; Type = Back; Status = OriginalSquad }
    let mackenziePhil = { Name = "Phil Mackenzie"; Team = canada; Type = Back; Status = OriginalSquad }
    let vanderMerweDTH = { Name = "D. T. H. van der Merwe"; Team = canada; Type = Back; Status = OriginalSquad }
    let evansMatt = { Name = "Matt Evans"; Team = canada; Type = Back; Status = OriginalSquad }
    let jonesHarry = { Name = "Harry Jones"; Team = canada; Type = Back; Status = OriginalSquad }
    let pritchardJames = { Name = "James Pritchard"; Team = canada; Type = Back; Status = Replacement (Some (DateTime (2015, 9, 24))) }

    let canadaSquad = { Team = canada
                        Players = [ barkwillRay; carpenterAaron; pifferoBenoit; buydensHubert; ilnickiJake; searsDucDjustice
                                    tiedemannAndrew; wooldridgeDoug; beukeboomBrett; cudmoreJamie; olmsteadEvan; dalaNanyak; gilmourKyle
                                    moonlightJohn; sinclairJebb; ardronTyler; thorpeRichard; mackPhil; mackenzieJamie; mcRorieGordon
                                    hirayamaNathan; underwoodLiam; blevinsNick; braidConnor; hearnCiaran; parfreyPat; trainorConor
                                    hasslerJeff; mackenziePhil; vanderMerweDTH; evansMatt; jonesHarry; pritchardJames ] }

    let romania = { Name = "Romania"; Status = Eliminated; Seeding = None; Coach = "Lynn Howells" }

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
    let tonitaOvidiu = { Name = "Ovidiu Toniţa"; Team = romania; Type = Forward; Status = Withdrawn (Some (DateTime (2015, 9, 29))) }
    let nistorVlad = { Name = "Vlad Nistor"; Team = romania; Type = Forward; Status = Replacement (Some (DateTime (2015, 9, 29))) }
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
                                     lucaciViorel; macoveiMihai; carpoDaniel; tonitaOvidiu; nistorVlad; bratuTudorel; calafeteanuValentin
                                     surugiuFlorin; dumbravaDanut; wiringiMichael; galCsaba; kinikinilauPaula; vlaicuFlorin; apostolAdrian
                                     botezatuIonut; ionitaFlorin; lemnaruMadalin; fercuCatalin; stratilaSabin ] }

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

    let groupAEnglandVsFiji = { Team1Points = TeamPoints (england, 35<point>); Team2Points = TeamPoints (fiji, 11<point>)
                                Stage = groupA; KickOff = DateTime (2015, 9, 18, 20, 0, 0)
                                Events = [ ManOfTheMatch brownMike
                                           PenaltyTry (england, Some 13<min>) (* england *)
                                           Try (brownMike, Some 22<min>)
                                           Try (brownMike, Some 72<min>)
                                           Try (vunipolaBilly, Some 80<min>)
                                           Conversion fordGeorge
                                           Conversion farrellOwen
                                           Conversion farrellOwen
                                           MissedConversion fordGeorge
                                           Penalty fordGeorge
                                           Penalty fordGeorge
                                           Penalty farrellOwen
                                           MissedPenalty fordGeorge
                                           Try (nadoloNemani, Some 30<min>) (* fiji *)
                                           MissedConversion volavolaBen
                                           Penalty nadoloNemani
                                           Penalty volavolaBen
                                           MissedPenalty nadoloNemani
                                           MissedPenalty nadoloNemani
                                           MissedPenalty volavolaBen
                                           YellowCard (matawaluNikola, Some 13<min>) ] }

    let groupAWalesVsUruguay = { Team1Points = TeamPoints (wales, 54<point>); Team2Points = TeamPoints (uruguay, 9<point>)
                                 Stage = groupA; KickOff = DateTime (2015, 9, 20, 14, 30, 0)
                                 Events = [ ManOfTheMatch allenCory
                                            Try (leeSamson, Some 15<min>) (* wales *)
                                            Try (allenCory, Some 19<min>)
                                            Try (allenCory, Some 30<min>)
                                            Try (allenCory, Some 40<min>)
                                            Try (amosHallam, Some 50<min>)
                                            Try (daviesGareth, Some 60<min>)
                                            Try (tipuricJustin, Some 71<min>)
                                            Try (daviesGareth, Some 80<min>)
                                            Conversion priestlandRhys
                                            Conversion priestlandRhys
                                            Conversion priestlandRhys
                                            Conversion priestlandRhys
                                            Conversion priestlandRhys
                                            Conversion priestlandRhys
                                            Conversion priestlandRhys
                                            MissedConversion priestlandRhys
                                            Penalty berchisiFelipe (* uruguay *)
                                            Penalty berchisiFelipe
                                            Penalty berchisiFelipe
                                            MissedPenalty berchisiFelipe ] }

    let groupAAustraliaVsFiji = { Team1Points = TeamPoints (australia, 28<point>); Team2Points = TeamPoints (fiji, 13<point>)
                                  Stage = groupA; KickOff = DateTime (2015, 9, 23, 16, 45, 0)
                                  Events = [ ManOfTheMatch pocockDavid
                                             Try (pocockDavid, Some 26<min>) (* australia *)
                                             Try (pocockDavid, Some 31<min>)
                                             Try (kepuSekope, Some 43<min>)
                                             Conversion foleyBernard
                                             Conversion foleyBernard
                                             MissedConversion foleyBernard
                                             Penalty foleyBernard
                                             Penalty foleyBernard
                                             Penalty foleyBernard
                                             YellowCard (kuridraniTevita, Some 74<min>)
                                             Try (volavolaBen, Some 60<min>) (* fiji *)
                                             Conversion nadoloNemani
                                             Penalty nadoloNemani
                                             Penalty nadoloNemani                                         
                                             YellowCard (ma'afuCampese, Some 30<min>) ] }

    let groupAEnglandVsWales = { Team1Points = TeamPoints (england, 25<point>); Team2Points = TeamPoints (wales, 28<point>)
                                 Stage = groupA; KickOff = DateTime (2015, 9, 26, 20, 0, 0)
                                 Events = [ ManOfTheMatch biggarDan
                                            Try (mayJonny, Some 27<min>) (* england *)
                                            Conversion farrellOwen
                                            Penalty farrellOwen
                                            Penalty farrellOwen
                                            Penalty farrellOwen
                                            Penalty farrellOwen
                                            Penalty farrellOwen
                                            DropGoal farrellOwen
                                            Try (daviesGareth, Some 71<min>) (* wales *)
                                            Conversion biggarDan
                                            Penalty biggarDan
                                            Penalty biggarDan
                                            Penalty biggarDan
                                            Penalty biggarDan
                                            Penalty biggarDan
                                            Penalty biggarDan
                                            Penalty biggarDan ] }

    let groupAAustraliaVsUruguay = { Team1Points = TeamPoints (australia, 65<point>); Team2Points = TeamPoints (uruguay, 3<point>)
                                     Stage = groupA; KickOff = DateTime (2015, 9, 27, 12, 0, 0)
                                     Events = [ ManOfTheMatch mcMahonSean
                                                Try (mcMahonSean, Some 7<min>) (* australia *)
                                                Try (tomaneJoe, Some 9<min>)
                                                Try (mummDean, Some 26<min>)
                                                Try (speightHenry, Some 31<min>)
                                                Try (mcCalmanBen, Some 36<min>)
                                                Try (mitchellDrew, Some 47<min>)
                                                Try (mitchellDrew, Some 52<min>)
                                                Try (mcCalmanBen, Some 61<min>)
                                                Try (mcMahonSean, Some 69<min>)
                                                Try (toomuaMatt, Some 71<min>)
                                                Try (kuridraniTevita, Some 80<min>)
                                                Conversion cooperQuade
                                                Conversion cooperQuade
                                                Conversion cooperQuade
                                                Conversion cooperQuade
                                                Conversion cooperQuade
                                                MissedConversion cooperQuade
                                                MissedConversion cooperQuade
                                                MissedConversion cooperQuade
                                                MissedConversion cooperQuade
                                                MissedConversion cooperQuade
                                                MissedConversion cooperQuade
                                                YellowCard (cooperQuade, Some 15<min>)
                                                Penalty berchisiFelipe (* uruguay *) ] }

    let groupAWalesVsFiji = { Team1Points = TeamPoints (wales, 23<point>); Team2Points = TeamPoints (fiji, 13<point>)
                              Stage = groupA; KickOff = DateTime (2015, 10, 1, 16, 45, 0)
                              Events = [ ManOfTheMatch daviesGareth
                                         Try (daviesGareth, Some 7<min>) (* wales *)
                                         Try (baldwinScott, Some 32<min>)
                                         Conversion biggarDan
                                         Conversion biggarDan
                                         Penalty biggarDan
                                         Penalty biggarDan
                                         Penalty biggarDan
                                         Try (gonevaVereniki, Some 49<min>) (* fiji *)
                                         Conversion volavolaBen
                                         Penalty volavolaBen
                                         Penalty volavolaBen
                                         MissedPenalty volavolaBen
                                         MissedPenalty volavolaBen ] }

    let groupAEnglandVsAustralia = { Team1Points = TeamPoints (england, 13<point>); Team2Points = TeamPoints (australia, 33<point>)
                                     Stage = groupA; KickOff = DateTime (2015, 10, 3, 20, 0, 0)
                                     Events = [ ManOfTheMatch launchburyJoe
                                                Try (watsonAnthony, Some 56<min>) (* england *)
                                                Conversion farrellOwen
                                                Penalty farrellOwen
                                                Penalty farrellOwen
                                                YellowCard (farrellOwen, Some 71<min>)
                                                Try (foleyBernard, Some 20<min>) (* australia *)
                                                Try (foleyBernard, Some 35<min>)
                                                Try (giteauMatt, Some 80<min>)
                                                Conversion foleyBernard
                                                Conversion foleyBernard
                                                Conversion foleyBernard
                                                Penalty foleyBernard
                                                Penalty foleyBernard
                                                Penalty foleyBernard
                                                Penalty foleyBernard ] }

    let groupAFijiVsUruguay = { Team1Points = TeamPoints (fiji, 47<point>); Team2Points = TeamPoints (uruguay, 15<point>)
                                Stage = groupA; KickOff = DateTime (2015, 10, 6, 20, 0, 0)
                                Events = [ ManOfTheMatch nakarawaLeone
                                           PenaltyTry (fiji, Some 3<min>) (* fiji *)
                                           Try (kenataleNemia, Some 8<min>)
                                           PenaltyTry (fiji, Some 27<min>)
                                           Try (nakarawaLeone, Some 38<min>)
                                           Try (cavubatiTevita, Some 64<min>)
                                           Try (murimurivaluKini, Some 66<min>)
                                           Try (nadoloNemani, Some 79<min>)
                                           Conversion nadoloNemani
                                           Conversion nadoloNemani
                                           Conversion nadoloNemani
                                           Conversion nadoloNemani
                                           Conversion nadoloNemani
                                           Conversion nadoloNemani
                                           MissedConversion nadoloNemani
                                           YellowCard (ma'afuCampese, Some 66<min>)
                                           Try (arboleyaCarlos, Some 17<min>) (* uruguay *)
                                           Try (ormaecheaAgustin, Some 58<min>)
                                           Conversion ormaecheaAgustin
                                           MissedConversion ormaecheaAgustin
                                           Penalty duranAlejo
                                           MissedPenalty ormaecheaAgustin
                                           YellowCard (ormaecheaAgustin, Some 3<min>)
                                           YellowCard (ormaecheaAgustin, Some 66<min>) ] }

    let groupAAustraliaVsWales = { Team1Points = TeamPoints (australia, 15<point>); Team2Points = TeamPoints (wales, 6<point>)
                                   Stage = groupA; KickOff = DateTime (2015, 10, 10, 16, 45, 0)
                                   Events = [ ManOfTheMatch daviesGareth
                                              Penalty foleyBernard (* australia *)
                                              Penalty foleyBernard
                                              Penalty foleyBernard
                                              Penalty foleyBernard
                                              Penalty foleyBernard
                                              MissedPenalty foleyBernard
                                              MissedPenalty giteauMatt
                                              YellowCard (geniaWill, Some 57<min>)
                                              YellowCard (mummDean, Some 60<min>)
                                              Penalty biggarDan (* wales *)                                              
                                              Penalty biggarDan
                                              MissedPenalty biggarDan
                                              YellowCard (cuthbertAlex, Some 77<min>) ] }

    let groupAEnglandVsUruguay = { Team1Points = TeamPoints (england, 60<point>); Team2Points = TeamPoints (uruguay, 3<point>)
                                   Stage = groupA; KickOff = DateTime (2015, 10, 10, 20, 0, 0)
                                   Events = [ ManOfTheMatch easterNick
                                              Try (watsonAnthony, Some 7<min>) (* england *)
                                              Try (easterNick, Some 18<min>)
                                              Try (easterNick, Some 23<min>)
                                              Try (watsonAnthony, Some 42<min>)
                                              Try (sladeHenry, Some 54<min>)
                                              Try (nowellJack, Some 57<min>)
                                              Try (easterNick, Some 60<min>)
                                              Try (nowellJack, Some 70<min>)
                                              Try (nowellJack, Some 74<min>)
                                              PenaltyTry (england, Some 80<min>)
                                              Conversion farrellOwen
                                              Conversion farrellOwen
                                              Conversion farrellOwen
                                              Conversion farrellOwen
                                              Conversion fordGeorge
                                              MissedConversion farrellOwen
                                              MissedConversion farrellOwen
                                              MissedConversion fordGeorge
                                              MissedConversion fordGeorge
                                              MissedConversion fordGeorge
                                              Penalty berchisiFelipe (* uruguay *)
                                              YellowCard (vilasecaSantiago, Some 40<min>) ] }

    let groupAMatches = [ groupAEnglandVsFiji; groupAWalesVsUruguay; groupAAustraliaVsFiji; groupAEnglandVsWales; groupAAustraliaVsUruguay
                          groupAWalesVsFiji; groupAEnglandVsAustralia; groupAFijiVsUruguay; groupAAustraliaVsWales; groupAEnglandVsUruguay ]

    // Group B matches: https://en.wikipedia.org/wiki/2015_Rugby_World_Cup_Pool_B...

    let groupBSouthAfricaVsJapan = { Team1Points = TeamPoints (southAfrica, 32<point>); Team2Points = TeamPoints (japan, 34<point>)
                                     Stage = groupB; KickOff = DateTime (2015, 9, 19, 16, 45, 0)
                                     Events = [ ManOfTheMatch tanakaFumiaki
                                                Try (louwFrancois, Some 18<min>) (* southAfrica *)
                                                Try (duPlessisBismarck, Some 33<min>)
                                                Try (deJagerLood, Some 44<min>)
                                                Try (straussAdriaan, Some 62<min>)
                                                Conversion lambiePat
                                                Conversion lambiePat
                                                Conversion pollardHandre
                                                MissedConversion lambiePat
                                                Penalty lambiePat
                                                Penalty pollardHandre
                                                YellowCard (oosthuizenCoenie, None)
                                                Try (leitchMichael, Some 30<min>) (* japan *)
                                                Try (goromaruAyumu, Some 69<min>)
                                                Try (heskethKarne, Some 80<min>)
                                                Conversion goromaruAyumu
                                                Conversion goromaruAyumu
                                                MissedConversion goromaruAyumu
                                                Penalty goromaruAyumu
                                                Penalty goromaruAyumu
                                                Penalty goromaruAyumu
                                                Penalty goromaruAyumu
                                                Penalty goromaruAyumu
                                                MissedPenalty goromaruAyumu ] }

    let groupBSamoaVsUnitedStates = { Team1Points = TeamPoints (samoa, 25<point>); Team2Points = TeamPoints (unitedStates, 16<point>)
                                      Stage = groupB; KickOff = DateTime (2015, 9, 20, 12, 0, 0)
                                      Events = [ ManOfTheMatch nanaiWilliamsTim
                                                 Try (nanaiWilliamsTim, Some 20<min>) (* samoa *)
                                                 Try (treviranusOfisa, Some 46<min>)
                                                 MissedConversion pisiTusi
                                                 MissedConversion pisiTusi
                                                 Penalty pisiTusi
                                                 Penalty pisiTusi
                                                 Penalty pisiTusi
                                                 Penalty pisiTusi
                                                 Penalty stanleyMichael
                                                 MissedPenalty pisiTusi
                                                 Try (wylesChris, Some 34<min>) (* unitedStates *)
                                                 Try (baumannChris, Some 74<min>)
                                                 MissedConversion macGintyAJ
                                                 MissedConversion macGintyAJ
                                                 Penalty macGintyAJ
                                                 Penalty macGintyAJ ] }

    let groupBScotlandVsJapan = { Team1Points = TeamPoints (scotland, 45<point>); Team2Points = TeamPoints (japan, 10<point>)
                                  Stage = groupB; KickOff = DateTime (2015, 9, 23, 14, 30, 0)
                                  Events = [ ManOfTheMatch laidlawGreig
                                             Try (hardieJohn, Some 48<min>) (* scotland *)
                                             Try (bennettMark, Some 56<min>)
                                             Try (seymourTommy, Some 64<min>)
                                             Try (bennettMark, Some 69<min>)
                                             Try (russellFinn, Some 74<min>)
                                             Conversion laidlawGreig
                                             Conversion laidlawGreig
                                             Conversion laidlawGreig
                                             Conversion laidlawGreig
                                             MissedConversion laidlawGreig
                                             Penalty laidlawGreig
                                             Penalty laidlawGreig
                                             Penalty laidlawGreig
                                             Penalty laidlawGreig
                                             MissedPenalty laidlawGreig
                                             Try (mafiAmanakiLelei, Some 15<min>) (* japan *)
                                             Conversion goromaruAyumu
                                             Penalty goromaruAyumu
                                             MissedPenalty goromaruAyumu
                                             MissedPenalty goromaruAyumu
                                             YellowCard (matsushimaKotaro, Some 23<min>) ] }

    let groupBSouthAfricaVsSamoa = { Team1Points = TeamPoints (southAfrica, 46<point>); Team2Points = TeamPoints (samoa, 6<point>)
                                     Stage = groupB; KickOff = DateTime (2015, 9, 26, 16, 45, 0)
                                     Events = [ ManOfTheMatch pollardHandre
                                                Try (pietersenJP, Some 15<min>) (* southAfrica *)
                                                Try (pietersenJP, Some 47<min>)
                                                Try (burgerSchalk, Some 58<min>)
                                                Try (britsSchalk, Some 71<min>)
                                                Try (pietersenJP, Some 78<min>)
                                                Try (habanaBryan, Some 80<min>)
                                                Conversion pollardHandre
                                                Conversion lambiePat
                                                MissedConversion pollardHandre
                                                MissedConversion pollardHandre
                                                MissedConversion pollardHandre
                                                MissedConversion lambiePat
                                                Penalty pollardHandre
                                                Penalty pollardHandre
                                                Penalty pollardHandre
                                                Penalty pollardHandre
                                                Penalty stanleyMichael (* samoa *)
                                                Penalty stanleyMichael
                                                MissedPenalty stanleyMichael
                                                MissedPenalty stanleyMichael
                                                MissedPenalty stanleyMichael ] }

    let groupBScotlandVsUnitedStates = { Team1Points = TeamPoints (scotland, 39<point>); Team2Points = TeamPoints (unitedStates, 16<point>)
                                         Stage = groupB; KickOff = DateTime (2015, 9, 27, 14, 30, 0)
                                         Events = [ ManOfTheMatch hoggStuart
                                                    Try (visserTim, Some 42<min>) (* scotland *)
                                                    Try (maitlandSean, Some 47<min>)
                                                    Try (nelWP, Some 54<min>)
                                                    Try (scottMatt, Some 65<min>)
                                                    Try (weirDuncan, Some 79<min>)
                                                    Conversion russellFinn
                                                    Conversion laidlawGreig
                                                    Conversion laidlawGreig
                                                    Conversion laidlawGreig
                                                    MissedConversion russellFinn
                                                    Penalty hoggStuart
                                                    Penalty russellFinn
                                                    MissedPenalty hoggStuart
                                                    MissedPenalty russellFinn
                                                    Try (lamositeleTiti, Some 21<min>) (* unitedStates *)
                                                    Conversion macGintyAJ
                                                    Penalty macGintyAJ
                                                    Penalty macGintyAJ
                                                    Penalty macGintyAJ ] }

    let groupBSamoaVsJapan = { Team1Points = TeamPoints (samoa, 5<point>); Team2Points = TeamPoints (japan, 26<point>)
                               Stage = groupB; KickOff = DateTime (2015, 10, 3, 14, 30, 0)
                               Events = [ ManOfTheMatch goromaruAyumu
                                          Try (perezPaul, Some 64<min>) (* samoa *)
                                          MissedConversion pisiTusi
                                          YellowCard (levaveFaifili, Some 16<min>)
                                          YellowCard (taulafoSakaria, Some 19<min>)
                                          YellowCard (pauloFilo, Some 78<min>)
                                          PenaltyTry (japan, Some 24<min>) (* japan *)
                                          Try (yamadaAkihito, Some 40<min>)
                                          Conversion goromaruAyumu
                                          Conversion goromaruAyumu
                                          Penalty goromaruAyumu
                                          Penalty goromaruAyumu
                                          Penalty goromaruAyumu
                                          Penalty goromaruAyumu
                                          MissedPenalty goromaruAyumu
                                          MissedPenalty goromaruAyumu ] }

    let groupBSouthAfricaVsScotland = { Team1Points = TeamPoints (southAfrica, 34<point>); Team2Points = TeamPoints (scotland, 16<point>)
                                        Stage = groupB; KickOff = DateTime (2015, 10, 3, 16, 45, 0)
                                        Events = [ ManOfTheMatch deJagerLood
                                                   Try (burgerSchalk, Some 13<min>) (* southAfrica *)
                                                   Try (pietersenJP, Some 38<min>)
                                                   Try (habanaBryan, Some 73<min>)
                                                   Conversion pollardHandre
                                                   Conversion pollardHandre
                                                   MissedConversion pollardHandre
                                                   Penalty pollardHandre
                                                   Penalty pollardHandre
                                                   Penalty pollardHandre
                                                   Penalty pollardHandre
                                                   DropGoal pollardHandre
                                                   YellowCard (duPlessisJannie, Some 34<min>)
                                                   Try (seymourTommy, Some 49<min>) (* scotland *)
                                                   Conversion laidlawGreig
                                                   Penalty laidlawGreig
                                                   Penalty laidlawGreig
                                                   Penalty weirDuncan
                                                   MissedPenalty laidlawGreig
                                                   YellowCard (laidlawGreig, Some 53<min>) ] }

    let groupBSouthAfricaVsUnitedStates = { Team1Points = TeamPoints (southAfrica, 64<point>); Team2Points = TeamPoints (unitedStates, 0<point>)
                                            Stage = groupB; KickOff = DateTime (2015, 10, 7, 16, 45, 0)
                                            Events = [ ManOfTheMatch deAllendeDamian
                                                       Try (deAllendeDamian, Some 7<min>) (* southAfrica *)
                                                       PenaltyTry (southAfrica, Some 27<min>)
                                                       Try (habanaBryan, Some 42<min>)
                                                       Try (duPlessisBismarck, Some 47<min>)
                                                       Try (louwFrancois, Some 53<min>)
                                                       Try (habanaBryan, Some 59<min>)
                                                       Try (habanaBryan, Some 61<min>)
                                                       Try (louwFrancois, Some 69<min>)
                                                       Try (krielJesse, Some 73<min>)
                                                       Try (mvovoLwazi, Some 80<min>)
                                                       Conversion pollardHandre
                                                       Conversion pollardHandre
                                                       Conversion pollardHandre
                                                       Conversion pollardHandre
                                                       Conversion steynMorne
                                                       Conversion steynMorne
                                                       Conversion steynMorne
                                                       MissedConversion pollardHandre
                                                       MissedConversion steynMorne
                                                       MissedConversion steynMorne
                                                       MissedPenalty niuaFolau (* unitedStates *)
                                                       MissedPenalty krugerNiku ] }

    let groupBSamoaVsScotland = { Team1Points = TeamPoints (samoa, 33<point>); Team2Points = TeamPoints (scotland, 36<point>)
                                  Stage = groupB; KickOff = DateTime (2015, 10, 10, 14, 30, 0)
                                  Events = [ ManOfTheMatch hardieJohn
                                             Try (pisiTusi, Some 11<min>) (* samoa *)
                                             Try (leiatauaManu, Some 14<min>)
                                             Try (leeLoRey, Some 21<min>)
                                             Try (matu'uMotu, Some 78<min>)
                                             Conversion pisiTusi
                                             Conversion fa'apalePatrick
                                             MissedConversion pisiTusi
                                             MissedConversion pisiTusi
                                             Penalty pisiTusi
                                             Penalty pisiTusi
                                             Penalty pisiTusi
                                             Try (seymourTommy, Some 12<min>) (* scotland *)
                                             Try (hardieJohn, Some 32<min>)
                                             Try (laidlawGreig, Some 74<min>)
                                             Conversion laidlawGreig
                                             Conversion laidlawGreig
                                             Conversion laidlawGreig
                                             Penalty laidlawGreig
                                             Penalty laidlawGreig
                                             Penalty laidlawGreig
                                             Penalty laidlawGreig
                                             Penalty laidlawGreig
                                             MissedPenalty laidlawGreig
                                             MissedPenalty laidlawGreig
                                             YellowCard (wilsonRyan, Some 28<min>) ] }

    let groupBUnitedStatesVsJapan = { Team1Points = TeamPoints (unitedStates, 18<point>); Team2Points = TeamPoints (japan, 28<point>)
                                      Stage = groupB; KickOff = DateTime (2015, 10, 11, 20, 0, 0)
                                      Events = [ ManOfTheMatch goromaruAyumu
                                                 Try (ngwenyaTakudzwa, Some 24<min>) (* unitedStates *)
                                                 Try (wylesChris, Some 71<min>)
                                                 Conversion macGintyAJ
                                                 MissedConversion macGintyAJ
                                                 Penalty macGintyAJ
                                                 Penalty macGintyAJ
                                                 YellowCard (fryEric, Some 61<min>)
                                                 Try (matsushimaKotaro, Some 7<min>) (* japan *)
                                                 Try (fujitaYoshikazu, Some 28<min>)
                                                 Try (mafiAmanakiLelei, Some 62<min>)
                                                 Conversion goromaruAyumu
                                                 Conversion goromaruAyumu
                                                 MissedConversion goromaruAyumu
                                                 Penalty goromaruAyumu
                                                 Penalty goromaruAyumu
                                                 Penalty goromaruAyumu ] }

    let groupBMatches = [ groupBSouthAfricaVsJapan; groupBSamoaVsUnitedStates; groupBScotlandVsJapan; groupBSouthAfricaVsSamoa; groupBScotlandVsUnitedStates
                          groupBSamoaVsJapan; groupBSouthAfricaVsScotland; groupBSouthAfricaVsUnitedStates; groupBSamoaVsScotland; groupBUnitedStatesVsJapan ]

    // Group C matches: https://en.wikipedia.org/wiki/2015_Rugby_World_Cup_Pool_C...

    let groupCTongaVsGeorgia = { Team1Points = TeamPoints (tonga, 10<point>); Team2Points = TeamPoints (georgia, 17<point>)
                                 Stage = groupC; KickOff = DateTime (2015, 9, 19, 12, 0, 0)
                                 Events = [ ManOfTheMatch gorgodzeMamuka
                                            Try (vainikoloFetu'u, Some 72<min>) (* tonga *)
                                            Conversion morathKurt
                                            Penalty morathKurt
                                            Try (gorgodzeMamuka, Some 27<min>) (* georgia *)
                                            Try (tkhilaishviliGiorgi, Some 56<min>)
                                            Conversion kvirikashviliMerab
                                            Conversion kvirikashviliMerab
                                            Penalty kvirikashviliMerab
                                            MissedPenalty kvirikashviliMerab
                                            MissedPenalty kvirikashviliMerab
                                            MissedPenalty malaghuradzeLasha
                                            YellowCard (kvirikashviliMerab, Some 72<min>) ] }

    let groupCNewZealandVsArgentina = { Team1Points = TeamPoints (newZealand, 26<point>); Team2Points = TeamPoints (argentina, 16<point>)
                                        Stage = groupC; KickOff = DateTime (2015, 9, 20, 16, 45, 0)
                                        Events = [ ManOfTheMatch retallickBrodie
                                                   Try (smithAaron, Some 57<min>) (* newZealand *)
                                                   Try (caneSam, Some 67<min>)
                                                   Conversion carterDan
                                                   Conversion carterDan
                                                   Penalty carterDan
                                                   Penalty carterDan
                                                   Penalty carterDan
                                                   Penalty carterDan
                                                   YellowCard (mcCawRichie, Some 30<min>)
                                                   YellowCard (smithConrad, Some 37<min>)
                                                   Try (pagadizabalGuidoPetti, Some 21<min>) (* argentina *)
                                                   Conversion sanchezNicolas
                                                   Penalty sanchezNicolas
                                                   Penalty sanchezNicolas
                                                   Penalty sanchezNicolas
                                                   YellowCard (materaPablo, Some 10<min>) ] }

    let groupCNewZealandVsNamibia = { Team1Points = TeamPoints (newZealand, 58<point>); Team2Points = TeamPoints (namibia, 14<point>)
                                      Stage = groupC; KickOff = DateTime (2015, 9, 24, 20, 0, 0)
                                      Events = [ ManOfTheMatch milnerSkudderNehe
                                                 Try (vitoVictor, Some 6<min>) (* newZealand *)
                                                 Try (milnerSkudderNehe, Some 10<min>)
                                                 Try (fekitoaMalakai, Some 21<min>)
                                                 Try (barrettBeauden, Some 31<min>)
                                                 Try (milnerSkudderNehe, Some 40<min>)
                                                 Try (saveaJulian, Some 47<min>)
                                                 Try (smithBen, Some 61<min>)
                                                 Try (saveaJulian, Some 75<min>)
                                                 Try (taylorCodie, Some 80<min>)
                                                 Conversion barrettBeauden
                                                 Conversion barrettBeauden
                                                 Conversion barrettBeauden
                                                 Conversion barrettBeauden
                                                 Conversion barrettBeauden
                                                 MissedConversion barrettBeauden
                                                 MissedConversion barrettBeauden
                                                 MissedConversion barrettBeauden
                                                 MissedConversion barrettBeauden
                                                 Penalty barrettBeauden
                                                 Try (deyselJohan, Some 51<min>) (* namibia *)
                                                 MissedConversion kotzeTheuns
                                                 Penalty kotzeTheuns
                                                 Penalty kotzeTheuns
                                                 Penalty kotzeTheuns
                                                 YellowCard (engelsJaco, Some 57<min>) ] }

    let groupCArgentinaVsGeorgia = { Team1Points = TeamPoints (argentina, 54<point>); Team2Points = TeamPoints (georgia, 9<point>)
                                     Stage = groupC; KickOff = DateTime (2015, 9, 25, 16, 45, 0)
                                     Events = [ ManOfTheMatch corderoSantiago
                                                Try (lavaniniTomas, Some 10<min>) (* argentina *)
                                                Try (cubelliTomas, Some 47<min>)
                                                Try (imhoffJuan, Some 49<min>)
                                                Try (corderoSantiago, Some 53<min>)
                                                Try (landajoMartin, Some 70<min>)
                                                Try (corderoSantiago, Some 72<min>)
                                                Try (imhoffJuan, Some 76<min>)
                                                Conversion sanchezNicolas
                                                Conversion sanchezNicolas
                                                Conversion sanchezNicolas
                                                Conversion boschMarcelo
                                                Conversion boschMarcelo
                                                MissedConversion sanchezNicolas
                                                MissedConversion boschMarcelo
                                                Penalty sanchezNicolas
                                                Penalty sanchezNicolas
                                                DropGoal sanchezNicolas
                                                Penalty kvirikashviliMerab (* georgia *)
                                                Penalty kvirikashviliMerab
                                                Penalty kvirikashviliMerab
                                                YellowCard (gorgodzeMamuka, Some 45<min>) ] }

    let groupCTongaVsNamibia = { Team1Points = TeamPoints (tonga, 35<point>); Team2Points = TeamPoints (namibia, 21<point>)
                                 Stage = groupC; KickOff = DateTime (2015, 9, 29, 16, 45, 0)
                                 Events = [ ManOfTheMatch ramJack
                                            Try (veainuTelusa, Some 6<min>) (* tonga *)
                                            Try (ramJack, Some 12<min>)
                                            Try (fositaLatiume, Some 25<min>)
                                            Try (ramJack, Some 45<min>)
                                            Try (veainuTelusa, Some 55<min>)
                                            Conversion liloVunga
                                            Conversion liloVunga
                                            MissedConversion liloVunga
                                            MissedConversion liloVunga
                                            MissedConversion liloVunga
                                            Penalty liloVunga
                                            MissedPenalty liloVunga
                                            Penalty morathKurt
                                            Try (trompJohan, Some 18<min>) (* namibia *)
                                            Try (burgerJacques, Some 49<min>)
                                            Try (burgerJacques, Some 67<min>)
                                            Conversion kotzeTheuns
                                            Conversion kotzeTheuns
                                            Conversion kotzeTheuns ] }

    let groupCNewZealandVsGeorgia = { Team1Points = TeamPoints (newZealand, 43<point>); Team2Points = TeamPoints (georgia, 10<point>)
                                      Stage = groupC; KickOff = DateTime (2015, 10, 2, 20, 0, 0)
                                      Events = [ ManOfTheMatch gorgodzeMamuka
                                                 Try (naholoWaisake, Some 2<min>) (* newZealand *)
                                                 Try (saveaJulian, Some 8<min>)
                                                 Try (saveaJulian, Some 17<min>)
                                                 Try (colesDane, Some 22<min>)
                                                 Try (readKieran, Some 52<min>)
                                                 Try (saveaJulian, Some 74<min>)
                                                 Try (fekitoaMalakai, Some 77<min>)
                                                 Conversion carterDan
                                                 Conversion carterDan
                                                 Conversion carterDan
                                                 Conversion carterDan
                                                 MissedConversion carterDan
                                                 MissedConversion carterDan
                                                 MissedConversion carterDan
                                                 Try (tsiklauriBeka, Some 5<min>) (* georgia *)
                                                 Conversion malaghuradzeLasha
                                                 Penalty malaghuradzeLasha ] }

    let groupCArgentinaVsTonga = { Team1Points = TeamPoints (argentina, 45<point>); Team2Points = TeamPoints (tonga, 16<point>)
                                   Stage = groupC; KickOff = DateTime (2015, 10, 4, 14, 30, 0)
                                   Events = [ ManOfTheMatch sanchezNicolas
                                              Try (tuculetJoaquin, Some 20<min>) (* argentina *)
                                              Try (imhoffJuan, Some 22<min>)
                                              Try (sanchezNicolas, Some 64<min>)
                                              Try (montoyaJulian, Some 72<min>)
                                              Try (corderoSantiago, Some 80<min>)
                                              Conversion sanchezNicolas
                                              Conversion sanchezNicolas
                                              Conversion sanchezNicolas
                                              Conversion sanchezNicolas
                                              MissedConversion sanchezNicolas
                                              Penalty sanchezNicolas
                                              Penalty sanchezNicolas
                                              Penalty sanchezNicolas
                                              Penalty sanchezNicolas
                                              MissedPenalty sanchezNicolas
                                              Try (morathKurt, Some 7<min>) (* tonga *)
                                              Try (tonga'uihaSoane, Some 38<min>)
                                              MissedConversion morathKurt
                                              MissedConversion morathKurt
                                              Penalty morathKurt
                                              Penalty morathKurt
                                              MissedPenalty morathKurt
                                              MissedPenalty morathKurt ] }

    let groupCNamibiaVsGeorgia = { Team1Points = TeamPoints (namibia, 16<point>); Team2Points = TeamPoints (georgia, 17<point>)
                                   Stage = groupC; KickOff = DateTime (2015, 10, 7, 20, 0, 0)
                                   Events = [ ManOfTheMatch duPlessisTinus
                                              Try (kotzeTheuns, Some 74<min>) (* namibia *)
                                              Conversion kotzeTheuns
                                              Penalty kotzeTheuns
                                              Penalty kotzeTheuns
                                              Penalty kotzeTheuns
                                              YellowCard (larsonRaoul, Some 40<min>)
                                              YellowCard (coetzeeAranos, Some 40<min>)
                                              YellowCard (bothmaRenaldo, Some 50<min>)
                                              Try (gorgodzeMamuka, Some 50<min>) (* georgia *)
                                              Try (malaghuradzeLasha, Some 55<min>)
                                              Conversion kvirikashviliMerab
                                              Conversion kvirikashviliMerab
                                              Penalty kvirikashviliMerab
                                              YellowCard (bregvadzeJaba, Some 35<min>) ] }

    let groupCNewZealandVsTonga = { Team1Points = TeamPoints (newZealand, 47<point>); Team2Points = TeamPoints (tonga, 9<point>)
                                    Stage = groupC; KickOff = DateTime (2015, 10, 9, 20, 0, 0)
                                    Events = [ ManOfTheMatch milnerSkudderNehe
                                               Try (smithBen, Some 13<min>) (* newZealand *)
                                               Try (woodcockTony, Some 31<min>)
                                               Try (milnerSkudderNehe, Some 52<min>)
                                               Try (milnerSkudderNehe, Some 58<min>)
                                               Try (williamsSonnyBill, Some 66<min>)
                                               Try (caneSam, Some 70<min>)
                                               Try (nonuMa'a, Some 76<min>)
                                               Conversion carterDan
                                               Conversion carterDan
                                               Conversion carterDan
                                               Conversion carterDan
                                               Conversion carterDan
                                               Conversion carterDan
                                               MissedConversion carterDan
                                               YellowCard (readKieran, Some 38<min>)
                                               Penalty morathKurt (* tonga *)
                                               Penalty morathKurt
                                               Penalty morathKurt
                                               YellowCard (ngauamoPaul, Some 70<min>) ] }

    let groupCArgentinaVsNamibia = { Team1Points = TeamPoints (argentina, 64<point>); Team2Points = TeamPoints (namibia, 19<point>)
                                     Stage = groupC; KickOff = DateTime (2015, 10, 11, 12, 0, 0)
                                     Events = [ ManOfTheMatch agullaHoracio
                                                Try (hernandezJuanMartin, Some 7<min>) (* argentina *)
                                                Try (moroniMatias, Some 19<min>)
                                                Try (agullaHoracio, Some 24<min>)
                                                Try (isaFacundo, Some 34<min>)
                                                Try (pazLucasNoguera, Some 40<min>)
                                                Try (alemannoMatias, Some 49<min>)
                                                Try (senatoreLeonardo, Some 64<min>)
                                                Try (montoyaJulian, Some 69<min>)
                                                Try (cubelliTomas, Some 74<min>)
                                                Conversion iglesiasSantiagoGonzalez
                                                Conversion iglesiasSantiagoGonzalez
                                                Conversion iglesiasSantiagoGonzalez
                                                Conversion iglesiasSantiagoGonzalez
                                                Conversion socinoJuanPablo
                                                Conversion socinoJuanPablo
                                                Conversion socinoJuanPablo
                                                Conversion socinoJuanPablo
                                                MissedConversion iglesiasSantiagoGonzalez
                                                Penalty iglesiasSantiagoGonzalez
                                                MissedPenalty iglesiasSantiagoGonzalez
                                                YellowCard (boschMarcelo, Some 53<min>)
                                                Try (trompJohan, Some 13<min>) (* namibia *)
                                                Try (greylingJC, Some 46<min>)
                                                Try (jantjiesEugene, Some 80<min>)
                                                Conversion kotzeTheuns
                                                Conversion kotzeTheuns
                                                MissedConversion redelinghuysJohnny
                                                YellowCard (greylingJC, Some 11<min>)
                                                YellowCard (duPlessisTinus, Some 76<min>) ] }

    let groupCMatches = [ groupCTongaVsGeorgia; groupCNewZealandVsArgentina; groupCNewZealandVsNamibia; groupCArgentinaVsGeorgia; groupCTongaVsNamibia
                          groupCNewZealandVsGeorgia; groupCArgentinaVsTonga; groupCNamibiaVsGeorgia; groupCNewZealandVsTonga; groupCArgentinaVsNamibia ]

    // Group D matches: https://en.wikipedia.org/wiki/2015_Rugby_World_Cup_Pool_D...

    let groupDIrelandVsCanada = { Team1Points = TeamPoints (ireland, 50<point>); Team2Points = TeamPoints (canada, 7<point>)
                                  Stage = groupD; KickOff = DateTime (2015, 9, 19, 14, 30, 0)
                                  Events = [ ManOfTheMatch sextonJonathan
                                             Try (o'BrienSean, Some 18<min>) (* ireland *)
                                             Try (hendersonIain, Some 25<min>)
                                             Try (sextonJonathan, Some 28<min>)
                                             Try (kearneyDavid, Some 35<min>)
                                             Try (croninSean, Some 66<min>)
                                             Try (kearneyRob, Some 73<min>)
                                             Try (payneJared, Some 76<min>)
                                             Conversion sextonJonathan
                                             Conversion sextonJonathan
                                             Conversion sextonJonathan
                                             Conversion madiganIan
                                             Conversion madiganIan
                                             Conversion madiganIan
                                             MissedConversion sextonJonathan
                                             Penalty sextonJonathan
                                             YellowCard (o'ConnellPaul, Some 42<min>)
                                             Try (vanderMerweDTH, Some 68<min>) (* canada *)
                                             Conversion hirayamaNathan
                                             MissedPenalty mcRorieGordon
                                             YellowCard (cudmoreJamie, Some 17<min>) ] }

    let groupDFranceVsItaly = { Team1Points = TeamPoints (france, 32<point>); Team2Points = TeamPoints (italy, 10<point>)
                                Stage = groupD; KickOff = DateTime (2015, 9, 19, 20, 0, 0)
                                Events = [ ManOfTheMatch picamolesLouis
                                           Try (slimaniRabah, Some 44<min>) (* france *)
                                           Try (masNicolas, Some 69<min>)
                                           Conversion michalakFrederic
                                           Conversion michalakFrederic
                                           Penalty michalakFrederic
                                           Penalty michalakFrederic
                                           Penalty michalakFrederic
                                           Penalty michalakFrederic
                                           Penalty michalakFrederic
                                           MissedPenalty michalakFrederic
                                           MissedPenalty michalakFrederic
                                           Penalty speddingScott
                                           Try (vendittiGiovanbattista, Some 52<min>) (* italy *)
                                           Conversion allanTommaso
                                           Penalty allanTommaso
                                           MissedPenalty allanTommaso ] }

    let groupDFranceVsRomania = { Team1Points = TeamPoints (france, 38<point>); Team2Points = TeamPoints (romania, 11<point>)
                                  Stage = groupD; KickOff = DateTime (2015, 9, 23, 20, 0, 0)
                                  Events = [ ManOfTheMatch fofanaWesley
                                             Try (guitouneSofiane, Some 30<min>) (* france *)
                                             Try (nyangaYannick, Some 34<min>)
                                             Try (guitouneSofiane, Some 66<min>)
                                             Try (fofanaWesley, Some 69<min>)
                                             Try (fickouGael, Some 79<min>)
                                             Conversion parraMorgan
                                             Conversion parraMorgan
                                             Conversion parraMorgan
                                             Conversion kockottRory
                                             Conversion kockottRory
                                             Penalty parraMorgan
                                             Try (ursacheValentin, Some 74<min>) (* romania *)
                                             MissedConversion vlaicuFlorin
                                             Penalty vlaicuFlorin
                                             Penalty vlaicuFlorin
                                             MissedPenalty vlaicuFlorin
                                             YellowCard (paulicaIon, Some 30<min>) ] }

    let groupDItalyVsCanada = { Team1Points = TeamPoints (italy, 23<point>); Team2Points = TeamPoints (canada, 18<point>)
                                Stage = groupD; KickOff = DateTime (2015, 9, 26, 14, 30, 0)
                                Events = [ ManOfTheMatch vanderMerweDTH
                                           Try (rizzoMichele, Some 17<min>) (* italy *)
                                           Try (garciaGonzalo, Some 58<min>)
                                           Conversion allanTommaso
                                           Conversion allanTommaso
                                           Penalty allanTommaso
                                           Penalty allanTommaso
                                           Penalty allanTommaso
                                           MissedPenalty cannaCarlo
                                           Try (vanderMerweDTH, Some 15<min>) (* canada *)
                                           Try (evansMatt, Some 44<min>)
                                           Conversion hirayamaNathan
                                           MissedConversion hirayamaNathan
                                           Penalty hirayamaNathan
                                           Penalty hirayamaNathan
                                           MissedPenalty hirayamaNathan ] }

    let groupDIrelandVsRomania = { Team1Points = TeamPoints (ireland, 44<point>); Team2Points = TeamPoints (romania, 10<point>)
                                   Stage = groupD; KickOff = DateTime (2015, 9, 27, 16, 45, 0)
                                   Events = [ ManOfTheMatch earlsKeith
                                              Try (boweTommy, Some 19<min>) (* ireland *)
                                              Try (earlsKeith, Some 29<min>)
                                              Try (earlsKeith, Some 44<min>)
                                              Try (boweTommy, Some 62<min>)
                                              Try (kearneyRob, Some 65<min>)
                                              Try (henryChris, Some 74<min>)
                                              Conversion madiganIan
                                              Conversion madiganIan
                                              Conversion madiganIan
                                              Conversion madiganIan
                                              MissedConversion madiganIan
                                              MissedConversion madiganIan
                                              Penalty madiganIan
                                              Penalty madiganIan
                                              Try (tonitaOvidiu, Some 78<min>) (* romania *)
                                              Conversion vlaicuFlorin
                                              Penalty calafeteanuValentin
                                              YellowCard (galCsaba, Some 61<min>) ] }

    let groupDFranceVsCanada = { Team1Points = TeamPoints (france, 41<point>); Team2Points = TeamPoints (canada, 18<point>)
                                 Stage = groupD; KickOff = DateTime (2015, 10, 1, 20, 0, 0)
                                 Events = [ ManOfTheMatch michalakFrederic
                                            Try (fofanaWesley, Some 4<min>) (* france *)
                                            Try (guiradoGuilhem, Some 28<min>)
                                            Try (slimaniRabah, Some 38<min>)
                                            Try (papePascal, Some 67<min>)
                                            Try (grossoRemy, Some 74<min>)
                                            Conversion michalakFrederic
                                            Conversion michalakFrederic
                                            Conversion michalakFrederic
                                            Conversion michalakFrederic
                                            Conversion parraMorgan
                                            Penalty michalakFrederic
                                            Penalty michalakFrederic
                                            Try (vanderMerweDTH, Some 31<min>) (* canada *)
                                            Try (carpenterAaron, Some 34<min>)
                                            Conversion hirayamaNathan
                                            MissedConversion hirayamaNathan
                                            Penalty hirayamaNathan
                                            Penalty hirayamaNathan
                                            YellowCard (dalaNanyak, Some 72<min>) ] }

    let groupDIrelandVsItaly = { Team1Points = TeamPoints (ireland, 16<point>); Team2Points = TeamPoints (italy, 9<point>)
                                 Stage = groupD; KickOff = DateTime (2015, 10, 4, 16, 45, 0)
                                 Events = [ ManOfTheMatch hendersonIain
                                            Try (earlsKeith, Some 19<min>) (* ireland *)
                                            Conversion sextonJonathan
                                            Penalty sextonJonathan
                                            Penalty sextonJonathan
                                            Penalty sextonJonathan
                                            MissedPenalty sextonJonathan
                                            MissedPenalty sextonJonathan
                                            YellowCard (o'MahonyPeter, Some 72<min>)
                                            Penalty allanTommaso (* italy *)
                                            Penalty allanTommaso
                                            Penalty allanTommaso
                                            MissedPenalty cannaCarlo ] }

    let groupDCanadaVsRomania = { Team1Points = TeamPoints (canada, 15<point>); Team2Points = TeamPoints (romania, 17<point>)
                                  Stage = groupD; KickOff = DateTime (2015, 10, 6, 16, 45, 0)
                                  Events = [ ManOfTheMatch hasslerJeff
                                             Try (vanderMerweDTH, Some 33<min>) (* canada *)
                                             Try (hasslerJeff, Some 44<min>)
                                             Conversion hirayamaNathan
                                             MissedConversion mcRorieGordon
                                             Penalty mcRorieGordon
                                             MissedPenalty mcRorieGordon
                                             MissedPenalty mcRorieGordon
                                             MissedPenalty hirayamaNathan
                                             YellowCard (sinclairJebb, Some 72<min>)
                                             Try (macoveiMihai, Some 53<min>) (* romania *)
                                             Try (macoveiMihai, Some 74<min>)
                                             Conversion vlaicuFlorin
                                             Conversion vlaicuFlorin
                                             Penalty vlaicuFlorin
                                             MissedPenalty vlaicuFlorin
                                             MissedPenalty vlaicuFlorin
                                             YellowCard (fercuCatalin, Some 20<min>) ] }

    let groupDItalyVsRomania = { Team1Points = TeamPoints (italy, 32<point>); Team2Points = TeamPoints (romania, 22<point>)
                                 Stage = groupD; KickOff = DateTime (2015, 10, 11, 14, 30, 0)
                                 Events = [ ManOfTheMatch goriEdoardo
                                            Try (sartoLeonardo, Some 10<min>) (* italy *)
                                            Try (goriEdoardo, Some 24<min>)
                                            Try (allanTommaso, Some 39<min>)
                                            Try (zanniAlessandro, Some 46<min>)
                                            Conversion allanTommaso
                                            Conversion allanTommaso
                                            Conversion allanTommaso
                                            MissedConversion allanTommaso
                                            Penalty allanTommaso
                                            Penalty allanTommaso
                                            Try (apostolAdrian, Some 66<min>) (* romania *)
                                            Try (popirlanValentin, Some 75<min>)
                                            Try (apostolAdrian, Some 79<min>)
                                            Conversion vlaicuFlorin
                                            Conversion vlaicuFlorin
                                            MissedConversion vlaicuFlorin
                                            Penalty vlaicuFlorin
                                            YellowCard (vanHeerdenJohannes, Some 16<min>) ] }

    let groupDFranceVsIreland = { Team1Points = TeamPoints (france, 9<point>); Team2Points = TeamPoints (ireland, 24<point>)
                                  Stage = groupD; KickOff = DateTime (2015, 10, 11, 16, 45, 0)
                                  Events = [ ManOfTheMatch o'BrienSean
                                             Penalty speddingScott (* france *)
                                             Penalty speddingScott
                                             Penalty parraMorgan
                                             MissedPenalty michalakFrederic
                                             MissedPenalty speddingScott
                                             Try (kearneyRob, Some 50<min>) (* ireland *)
                                             Try (murrayConor, Some 72<min>)
                                             Conversion madiganIan
                                             MissedConversion madiganIan
                                             Penalty sextonJonathan
                                             Penalty sextonJonathan
                                             Penalty madiganIan
                                             Penalty madiganIan ] }

    let groupDMatches = [ groupDIrelandVsCanada; groupDFranceVsItaly; groupDFranceVsRomania; groupDItalyVsCanada; groupDIrelandVsRomania
                          groupDFranceVsCanada; groupDIrelandVsItaly; groupDCanadaVsRomania; groupDItalyVsRomania; groupDFranceVsIreland ]

    // Knockout matches: https://en.wikipedia.org/wiki/2015_Rugby_World_Cup_knockout_stage...

    let quarterFinal1B1VsA2 = { Team1Points = TeamPoints (southAfrica, 23<point>); Team2Points = TeamPoints (wales, 19<point>)
                                Stage = QuarterFinal 1; KickOff = DateTime (2015, 10, 17, 16, 0, 0)
                                Events = [ ManOfTheMatch burgerSchalk
                                           Try (duPreezFourie, Some 75<min>) (* southAfrica *)
                                           MissedConversion pollardHandre
                                           Penalty pollardHandre
                                           Penalty pollardHandre
                                           Penalty pollardHandre
                                           Penalty pollardHandre
                                           Penalty pollardHandre
                                           MissedPenalty pollardHandre
                                           MissedPenalty pollardHandre
                                           DropGoal pollardHandre
                                           Try (daviesGareth, Some 18<min>) (* wales *)
                                           Conversion biggarDan
                                           Penalty biggarDan
                                           Penalty biggarDan
                                           Penalty biggarDan
                                           MissedPenalty biggarDan
                                           DropGoal biggarDan ] }

    let quarterFinal2C1VsD2 = { Team1Points = TeamPoints (newZealand, 62<point>); Team2Points = TeamPoints (france, 13<point>)
                                Stage = QuarterFinal 2; KickOff = DateTime (2015, 10, 17, 20, 0, 0)
                                Events = [ ManOfTheMatch saveaJulian
                                           Try (retallickBrodie, Some 11<min>) (* newZealand *)
                                           Try (milnerSkudderNehe, Some 23<min>)
                                           Try (saveaJulian, Some 29<min>)
                                           Try (saveaJulian, Some 38<min>)
                                           Try (kainoJerome, Some 50<min>)
                                           Try (saveaJulian, Some 59<min>)
                                           Try (readKieran, Some 64<min>)
                                           Try (kerrBarlowTawera, Some 68<min>)
                                           Try (kerrBarlowTawera, Some 71<min>)
                                           Conversion carterDan
                                           Conversion carterDan
                                           Conversion carterDan
                                           Conversion carterDan
                                           Conversion carterDan
                                           Conversion carterDan
                                           Conversion carterDan
                                           MissedConversion carterDan
                                           MissedConversion carterDan
                                           Penalty carterDan
                                           Try (picamolesLouis, Some 36<min>) (* france *)
                                           Conversion parraMorgan
                                           Penalty speddingScott
                                           Penalty parraMorgan
                                           MissedPenalty parraMorgan
                                           YellowCard (picamolesLouis, Some 47<min>) ] }

    let quarterFinal3D1VsC2 = { Team1Points = TeamPoints (ireland, 20<point>); Team2Points = TeamPoints (argentina, 43<point>)
                                Stage = QuarterFinal 3; KickOff = DateTime (2015, 10, 18, 13, 0, 0)
                                Events = [ ManOfTheMatch sanchezNicolas
                                           Try (fitzgeraldLuke, Some 26<min>) (* ireland *)
                                           Try (murphyJordi, Some 44<min>)
                                           Conversion madiganIan
                                           Conversion madiganIan
                                           Penalty madiganIan
                                           Penalty madiganIan
                                           MissedPenalty madiganIan
                                           MissedPenalty madiganIan
                                           Try (moroniMatias, Some 3<min>) (* argentina *)
                                           Try (imhoffJuan, Some 10<min>)
                                           Try (tuculetJoaquin, Some 69<min>)
                                           Try (imhoffJuan, Some 73<min>)
                                           Conversion sanchezNicolas
                                           Conversion sanchezNicolas
                                           Conversion sanchezNicolas
                                           Conversion sanchezNicolas
                                           Penalty sanchezNicolas
                                           Penalty sanchezNicolas
                                           Penalty sanchezNicolas
                                           Penalty sanchezNicolas
                                           Penalty sanchezNicolas
                                           MissedPenalty sanchezNicolas
                                           YellowCard (herreraRamiro, Some 17<min>) ] }

    let quarterFinal4A1VsB2 = { Team1Points = TeamPoints (australia, 35<point>); Team2Points = TeamPoints (scotland, 34<point>)
                                Stage = QuarterFinal 4; KickOff = DateTime (2015, 10, 18, 16, 0, 0)
                                Events = [ ManOfTheMatch giteauMatt
                                           Try (ashleyCooperAdam, Some 9<min>) (* australia *)
                                           Try (mitchellDrew, Some 30<min>)
                                           Try (hooperMichael, Some 40<min>)
                                           Try (mitchellDrew, Some 43<min>)
                                           Try (kuridraniTevita, Some 64<min>)
                                           Conversion foleyBernard
                                           Conversion foleyBernard
                                           MissedConversion foleyBernard
                                           MissedConversion foleyBernard
                                           MissedConversion foleyBernard
                                           Penalty foleyBernard
                                           Penalty foleyBernard
                                           Try (hornePeter, Some 18<min>) (* scotland *)
                                           Try (seymourTommy, Some 59<min>)
                                           Try (bennettMark, Some 74<min>)
                                           Conversion laidlawGreig
                                           Conversion laidlawGreig
                                           MissedConversion laidlawGreig
                                           Penalty laidlawGreig
                                           Penalty laidlawGreig
                                           Penalty laidlawGreig
                                           Penalty laidlawGreig
                                           Penalty laidlawGreig
                                           YellowCard (maitlandSean, Some 42<min>) ] }

    let semiFinal1QF1VsQF2 = { Team1Points = TeamPoints (southAfrica, 18<point>); Team2Points = TeamPoints (newZealand, 20<point>)
                               Stage = SemiFinal 1; KickOff = DateTime (2015, 10, 24, 16, 0, 0)
                               Events = [ ManOfTheMatch smithBen
                                          Penalty pollardHandre (* southAfrica *)
                                          Penalty pollardHandre
                                          Penalty pollardHandre
                                          Penalty pollardHandre
                                          Penalty pollardHandre
                                          Penalty lambiePat
                                          YellowCard (habanaBryan, Some 52<min>)
                                          Try (kainoJerome, Some 6<min>) (* newZealand *)
                                          Try (barrettBeauden, Some 52<min>)
                                          Conversion carterDan
                                          Conversion carterDan
                                          Penalty carterDan
                                          MissedPenalty carterDan
                                          DropGoal carterDan
                                          YellowCard (kainoJerome, Some 39<min>) ] }

    let semiFinal2QF3VsQF4 = { Team1Points = TeamPoints (argentina, 15<point>); Team2Points = TeamPoints (australia, 29<point>)
                               Stage = SemiFinal 2; KickOff = DateTime (2015, 10, 25, 16, 0, 0)
                               Events = [ ManOfTheMatch ashleyCooperAdam
                                          Penalty sanchezNicolas (* argentina *)
                                          Penalty sanchezNicolas
                                          Penalty sanchezNicolas
                                          Penalty sanchezNicolas
                                          Penalty sanchezNicolas
                                          YellowCard (lavaniniTomas, Some 26<min>)
                                          Try (simmonsRob, Some 2<min>) (* australia *)
                                          Try (ashleyCooperAdam, Some 10<min>)
                                          Try (ashleyCooperAdam, Some 32<min>)
                                          Try (ashleyCooperAdam, Some 72<min>)
                                          Conversion foleyBernard
                                          Conversion foleyBernard
                                          Conversion foleyBernard
                                          MissedConversion foleyBernard
                                          Penalty foleyBernard
                                          MissedPenalty foleyBernard ] }

    let bronzeFinal1SF1VsSF2 = { Team1Points = TeamPoints (southAfrica, 24<point>); Team2Points = TeamPoints (argentina, 13<point>)
                                 Stage = BronzeFinal; KickOff = DateTime (2015, 10, 30, 20, 0, 0)
                                 Events = [ ManOfTheMatch deAllendeDamian
                                            Try (pietersenJP, Some 6<min>) (* southAfrica *)
                                            Try (etzebethEben, Some 43<min>)
                                            Conversion pollardHandre
                                            MissedConversion pollardHandre
                                            Penalty pollardHandre
                                            Penalty pollardHandre
                                            Penalty pollardHandre
                                            Penalty pollardHandre
                                            MissedPenalty pollardHandre
                                            Try (orlandiJuanPablo, Some 80<min>) (* argentina *)
                                            Conversion sanchezNicolas
                                            Penalty sanchezNicolas
                                            DropGoal sanchezNicolas
                                            YellowCard (cubelliTomas, Some 5<min>) ] }

    let final1SF1VsSF2 = { Team1Points = TeamPoints (newZealand, 34<point>); Team2Points = TeamPoints (australia, 17<point>)
                           Stage = Final; KickOff = DateTime (2015, 10, 31, 16, 0, 0)
                           Events = [ ManOfTheMatch carterDan
                                      Try (milnerSkudderNehe, Some 39<min>) (* newZealand *)
                                      Try (nonuMa'a, Some 42<min>)
                                      Try (barrettBeauden, Some 79<min>)
                                      Conversion carterDan
                                      Conversion carterDan
                                      MissedConversion carterDan
                                      Penalty carterDan
                                      Penalty carterDan
                                      Penalty carterDan
                                      Penalty carterDan
                                      DropGoal carterDan
                                      YellowCard (smithBen, Some 52<min>)
                                      Try (pocockDavid, Some 53<min>) (* australia *)
                                      Try (kuridraniTevita, Some 64<min>)
                                      Conversion foleyBernard
                                      Conversion foleyBernard
                                      Penalty foleyBernard ] }

    let knockoutMatches = [ quarterFinal1B1VsA2; quarterFinal2C1VsD2; quarterFinal3D1VsC2; quarterFinal4A1VsB2
                            semiFinal1QF1VsQF2; semiFinal2QF3VsQF4; bronzeFinal1SF1VsSF2; final1SF1VsSF2 ]

    let matches = groupAMatches @ groupBMatches @ groupCMatches @ groupDMatches @ knockoutMatches

