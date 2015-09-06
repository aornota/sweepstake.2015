namespace AOrNotA.Sweepstake2015

open System

open AOrNotA.Sweepstake2015.Domain

module ``Data 2011`` =

    // 2011 squads: https://en.wikipedia.org/wiki/2011_Rugby_World_Cup_squads...

    let newZealand = { Name = "New Zealand"; Status = Active; Seeding = Some 1; Coach = "Graham Henry" }

    let flynnCorey = { Name = "Corey Flynn"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let horeAndrew = { Name = "Andrew Hore"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let mealamuKevin = { Name = "Kevin Mealamu"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let afoaJohn = { Name = "John Afoa"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let franksBen = { Name = "Ben Franks"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let franksOwen = { Name = "Owen Franks"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let woodcockTony = { Name = "Tony Woodcock"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let boricAnthony = { Name = "Anthony Boric"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let thornBrad = { Name = "Brad Thorn"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let whitelockSam = { Name = "Sam Whitelock"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let williamsAli = { Name = "Ali Williams"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let kainoJerome = { Name = "Jerome Kaino"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let mcCawRichie = { Name = "Richie McCaw"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let thomsonAdam = { Name = "Adam Thomson"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let readKieran = { Name = "Kieran Read"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let vitoVictor = { Name = "Victor Vito"; Team = newZealand; Type = Forward; Status = OriginalSquad }
    let cowanJimmy = { Name = "Jimmy Cowan"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let ellisAndy = { Name = "Andy Ellis"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let weepuPiri = { Name = "Piri Weepu"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let kahuiRichard = { Name = "Richard Kahui"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let nonuMa'a = { Name = "Ma'a Nonu"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let smithConrad = { Name = "Conrad Smith"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let williamsSonnyBill = { Name = "Sonny Bill Williams"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let guildfordZac = { Name = "Zac Guildford"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let janeCory = { Name = "Cory Jane"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let daggIsrael = { Name = "Israel Dagg"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let toeavaIsaia = { Name = "Isaia Toeava"; Team = newZealand; Type = Back; Status = OriginalSquad }
    let carterDan = { Name = "Dan Carter"; Team = newZealand; Type = Back; Status = Withdrawn (Some (DateTime (2011, 10, 1))) }
    let muliainaMils = { Name = "Mils Muliaina"; Team = newZealand; Type = Back; Status = Withdrawn (Some (DateTime (2011, 10, 9))) }
    let sladeColin = { Name = "Colin Slade"; Team = newZealand; Type = Back; Status = Withdrawn (Some (DateTime (2011, 10, 9))) }
    let crudenAaron = { Name = "Aaron Cruden"; Team = newZealand; Type = Back; Status = Replacement (Some (DateTime (2011, 10, 1))) }
    let donaldStephen = { Name = "Stephen Donald"; Team = newZealand; Type = Back; Status = Replacement (Some (DateTime (2011, 10, 9))) }
    let gearHosea = { Name = "Hosea Gear"; Team = newZealand; Type = Back; Status = Replacement (Some (DateTime (2011, 10, 9))) }

    let newZealandSquad = { Team = newZealand
                            Players = [ flynnCorey; horeAndrew; mealamuKevin; afoaJohn; franksBen; franksOwen; woodcockTony
                                        boricAnthony; thornBrad; whitelockSam; williamsAli; kainoJerome; mcCawRichie; thomsonAdam
                                        readKieran; vitoVictor; cowanJimmy; ellisAndy; weepuPiri; kahuiRichard; nonuMa'a; smithConrad
                                        williamsSonnyBill; guildfordZac; janeCory; daggIsrael; toeavaIsaia; carterDan; muliainaMils
                                        sladeColin; crudenAaron; donaldStephen; gearHosea ] }

    let southAfrica = { Name = "South Africa"; Status = Eliminated; Seeding = Some 2; Coach = "Peter de Villiers" }

    let duPlessisBismarck = { Name = "Bismarck du Plessis"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let ralapelleChiliboy = { Name = "Chiliboy Ralepelle"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let smitJohn = { Name = "John Smit"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let duPlessisJannie = { Name = "Jannie du Plessis"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let mtawariraTendai = { Name = "Tendai Mtawarira"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let steenkampGurthro = { Name = "Gurthrö Steenkamp"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let vanderLindeCJ = { Name = "CJ van der Linde"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let bothaBakkies = { Name = "Bakkies Botha"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let matfieldVictor = { Name = "Victor Matfield"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let mullerJohann = { Name = "Johann Muller"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let rossouwDanie = { Name = "Danie Rossouw"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let albertsWillem = { Name = "Willem Alberts"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let brussowHeinrich = { Name = "Heinrich Brüssow"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let burgerSchalk = { Name = "Schalk Burger"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let louwFrancois = { Name = "Francois Louw"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let spiesPierre = { Name = "Pierre Spies"; Team = southAfrica; Type = Forward; Status = OriginalSquad }
    let duPreezFourie = { Name = "Fourie du Preez"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let hougaardFrancois = { Name = "Francois Hougaard"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let pienaarRuan = { Name = "Ruan Pienaar"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let jamesButch = { Name = "Butch James"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let steynMorne = { Name = "Morné Steyn"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let deJonghJuan = { Name = "Juan de Jongh"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let deVilliersJean = { Name = "Jean de Villiers"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let fourieJaque = { Name = "Jaque Fourie"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let aplonGio = { Name = "Gio Aplon"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let habanaBryan = { Name = "Bryan Habana"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let ndunganeOdaw = { Name = "Odwa Ndungane"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let pietersenJP = { Name = "JP Pietersen"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let lambiePatrick = { Name = "Patrick Lambie"; Team = southAfrica; Type = Back; Status = OriginalSquad }
    let steynFrancois = { Name = "François Steyn"; Team = southAfrica; Type = Back; Status = Withdrawn (Some (DateTime (2011, 10, 2))) }
    let kirchnerZane = { Name = "Zane Kirchner"; Team = southAfrica; Type = Back; Status = Replacement (Some (DateTime (2011, 10, 2))) }

    let southAfricaSquad = { Team = southAfrica
                             Players = [ duPlessisBismarck; ralapelleChiliboy; smitJohn; duPlessisJannie; mtawariraTendai
                                         steenkampGurthro; vanderLindeCJ; bothaBakkies; matfieldVictor; mullerJohann; rossouwDanie
                                         albertsWillem; brussowHeinrich; burgerSchalk; louwFrancois; spiesPierre; duPreezFourie
                                         hougaardFrancois; pienaarRuan; jamesButch; steynMorne; deJonghJuan; deVilliersJean
                                         fourieJaque; aplonGio; habanaBryan; ndunganeOdaw; pietersenJP; lambiePatrick
                                         steynFrancois; kirchnerZane ] }

    let australia = { Name = "Australia"; Status = Eliminated; Seeding = Some 3; Coach = "Robbie Deans" }

    let fainga'aSaia = { Name = "Saia Fainga'a"; Team = australia; Type = Forward; Status = OriginalSquad }
    let mooreStephen = { Name = "Stephen Moore"; Team = australia; Type = Forward; Status = OriginalSquad }
    let polotaNauTatafu = { Name = "Tatafu Polota-Nau"; Team = australia; Type = Forward; Status = OriginalSquad }
    let alexanderBen = { Name = "Ben Alexander"; Team = australia; Type = Forward; Status = OriginalSquad }
    let kepuSekope = { Name = "Sekope Kepu"; Team = australia; Type = Forward; Status = OriginalSquad }
    let ma'afuSalesi = { Name = "Salesi Ma'afu"; Team = australia; Type = Forward; Status = OriginalSquad }
    let slipperJames = { Name = "James Slipper"; Team = australia; Type = Forward; Status = OriginalSquad }
    let horwillJames = { Name = "James Horwill"; Team = australia; Type = Forward; Status = OriginalSquad }
    let sharpeNathan = { Name = "Nathan Sharpe"; Team = australia; Type = Forward; Status = OriginalSquad }
    let simmonsRob = { Name = "Rob Simmons"; Team = australia; Type = Forward; Status = OriginalSquad }
    let vickermanDan = { Name = "Dan Vickerman"; Team = australia; Type = Forward; Status = OriginalSquad }
    let elsomRocky = { Name = "Rocky Elsom"; Team = australia; Type = Forward; Status = OriginalSquad }
    let higginbothamScott = { Name = "Scott Higginbotham"; Team = australia; Type = Forward; Status = OriginalSquad }
    let pocockDavid = { Name = "David Pocock"; Team = australia; Type = Forward; Status = OriginalSquad }
    let mcCalmanBen = { Name = "Ben McCalman"; Team = australia; Type = Forward; Status = OriginalSquad }
    let samoRadike = { Name = "Radike Samo"; Team = australia; Type = Forward; Status = OriginalSquad }
    let burgessLuke = { Name = "Luke Burgess"; Team = australia; Type = Back; Status = OriginalSquad }
    let geniaWill = { Name = "Will Genia"; Team = australia; Type = Back; Status = OriginalSquad }
    let phippsNick = { Name = "Nick Phipps"; Team = australia; Type = Back; Status = OriginalSquad }
    let barnesBerrick = { Name = "Berrick Barnes"; Team = australia; Type = Back; Status = OriginalSquad }
    let cooperQuade = { Name = "Quade Cooper"; Team = australia; Type = Back; Status = OriginalSquad }
    let ashleyCooperAdam = { Name = "Adam Ashley-Cooper"; Team = australia; Type = Back; Status = OriginalSquad }
    let fainga'aAnthony = { Name = "Anthony Fainga'a"; Team = australia; Type = Back; Status = OriginalSquad }
    let horneRob = { Name = "Rob Horne"; Team = australia; Type = Back; Status = OriginalSquad }
    let mcCabePat = { Name = "Pat McCabe"; Team = australia; Type = Back; Status = OriginalSquad }
    let ioaneDigby = { Name = "Digby Ioane"; Team = australia; Type = Back; Status = OriginalSquad }
    let o'ConnorJames = { Name = "James O'Connor"; Team = australia; Type = Back; Status = OriginalSquad }
    let bealeKurtley = { Name = "Kurtley Beale"; Team = australia; Type = Back; Status = OriginalSquad }
    let paluWycliff = { Name = "Wycliff Palu"; Team = australia; Type = Forward; Status = Withdrawn (Some (DateTime (2011, 10, 1))) }
    let hodgsonMatt = { Name = "Matt Hodgson"; Team = australia; Type = Forward; Status = Replacement (Some (DateTime (2011, 10, 1))) }
    let mitchellDrew = { Name = "Drew Mitchell"; Team = australia; Type = Back; Status = Withdrawn (Some (DateTime (2011, 10, 1))) }
    let turnerLachie = { Name = "Lachie Turner"; Team = australia; Type = Back; Status = Replacement (Some (DateTime (2011, 10, 1))) }

    let australiaSquad = { Team = australia
                           Players = [ fainga'aSaia; mooreStephen; polotaNauTatafu; alexanderBen; kepuSekope; ma'afuSalesi
                                       slipperJames; horwillJames; sharpeNathan; simmonsRob; vickermanDan; elsomRocky
                                       higginbothamScott; pocockDavid; mcCalmanBen; samoRadike; burgessLuke; geniaWill; phippsNick
                                       barnesBerrick; cooperQuade; ashleyCooperAdam; fainga'aAnthony; horneRob; mcCabePat
                                       ioaneDigby; o'ConnorJames; bealeKurtley; paluWycliff; hodgsonMatt; mitchellDrew
                                       turnerLachie ] }

    let argentina = { Name = "Argentina"; Status = Eliminated; Seeding = Some 4; Coach = "Santiago Phelan" }

    let creevyAgustin = { Name = "Agustín Creevy"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let ledesmaMario = { Name = "Mario Ledesma"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let ayerzaMarcos = { Name = "Marcos Ayerza"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let bustosMaximiliano = { Name = "Maximiliano Bustos"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let figalloJuan = { Name = "Juan Figallo"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let ronceroRodrigo = { Name = "Rodrigo Roncero"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let scelzoMartin = { Name = "Martín Scelzo"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let albacetePatricio = { Name = "Patricio Albacete"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let carizzaManuel = { Name = "Manuel Carizza"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let galarzaMariano = { Name = "Mariano Galarza"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let vallejosTomas = { Name = "Tomas Vallejos"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let camposAlejandro = { Name = "Alejandro Campos"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let cabelloJulioFarias = { Name = "Julio Farías Cabello"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let fessiaGenaro = { Name = "Genaro Fessia"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let leguizamonJuanManuel = { Name = "Juan Manuel Leguizamón"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let lobbeJuanMartinFernandez = { Name = "Juan Martín Fernández Lobbe"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let senatoreLeonardo = { Name = "Leonardo Senatore"; Team = argentina; Type = Forward; Status = OriginalSquad }
    let lalanneAlfredo = { Name = "Alfredo Lalanne"; Team = argentina; Type = Back; Status = OriginalSquad }
    let vergalloNicolas = { Name = "Nicolás Vergallo"; Team = argentina; Type = Back; Status = OriginalSquad }
    let fernandezSantiago = { Name = "Santiago Fernández"; Team = argentina; Type = Back; Status = OriginalSquad }
    let sanchezNicolas = { Name = "Nicolás Sánchez"; Team = argentina; Type = Back; Status = OriginalSquad }
    let boschMarcelo = { Name = "Marcelo Bosch"; Team = argentina; Type = Back; Status = OriginalSquad }
    let contepomiFelipe = { Name = "Felipe Contepomi"; Team = argentina; Type = Back; Status = OriginalSquad }
    let gosioAgustin = { Name = "Agustin Gosio"; Team = argentina; Type = Back; Status = OriginalSquad }
    let agullaHoracio = { Name = "Horacio Agulla"; Team = argentina; Type = Back; Status = OriginalSquad }
    let camachaGonzalo = { Name = "Gonzalo Camacho"; Team = argentina; Type = Back; Status = OriginalSquad }
    let imhoffJuan = { Name = "Juan Imhoff"; Team = argentina; Type = Back; Status = OriginalSquad }
    let amorosinoLucasGonzalez = { Name = "Lucas González Amorosino"; Team = argentina; Type = Back; Status = OriginalSquad }
    let rodriguezMartin = { Name = "Martín Rodríguez"; Team = argentina; Type = Back; Status = OriginalSquad }
    let tiesiGonzalo = { Name = "Gonzalo Tiesi"; Team = argentina; Type = Back; Status = Withdrawn (Some (DateTime (2011, 9, 10))) }
    let borgesLucas = { Name = "Lucas Borges"; Team = argentina; Type = Back; Status = Replacement (Some (DateTime (2011, 9, 10))) }

    let argentinaSquad = { Team = argentina
                           Players = [ creevyAgustin; ledesmaMario; ayerzaMarcos; bustosMaximiliano; figalloJuan; ronceroRodrigo
                                       scelzoMartin; albacetePatricio; carizzaManuel; galarzaMariano; vallejosTomas
                                       camposAlejandro; cabelloJulioFarias; fessiaGenaro; leguizamonJuanManuel
                                       lobbeJuanMartinFernandez; senatoreLeonardo; lalanneAlfredo; vergalloNicolas
                                       fernandezSantiago; sanchezNicolas; boschMarcelo; contepomiFelipe; gosioAgustin; agullaHoracio
                                       camachaGonzalo; imhoffJuan; amorosinoLucasGonzalez; rodriguezMartin; tiesiGonzalo; borgesLucas ] }

    let wales = { Name = "Wales"; Status = Eliminated; Seeding = Some 5; Coach = "Warren Gatland" }

    let bennettHuw = { Name = "Huw Bennett"; Team = wales; Type = Forward; Status = OriginalSquad }
    let burnsLloyd = { Name = "Lloyd Burns"; Team = wales; Type = Forward; Status = OriginalSquad }
    let owensKen = { Name = "Ken Owens"; Team = wales; Type = Forward; Status = OriginalSquad }
    let bevingtonRyan = { Name = "Ryan Bevington"; Team = wales; Type = Forward; Status = OriginalSquad }
    let jamesPaul = { Name = "Paul James"; Team = wales; Type = Forward; Status = OriginalSquad }
    let jenkinsGethin = { Name = "Gethin Jenkins"; Team = wales; Type = Forward; Status = OriginalSquad }
    let jonesAdam = { Name = "Adam Jones"; Team = wales; Type = Forward; Status = OriginalSquad }
    let mitchellCraig = { Name = "Craig Mitchell"; Team = wales; Type = Forward; Status = OriginalSquad }
    let charterisLuke = { Name = "Luke Charteris"; Team = wales; Type = Forward; Status = OriginalSquad }
    let daviesBradley = { Name = "Bradley Davies"; Team = wales; Type = Forward; Status = OriginalSquad }
    let jonesAlunWyn = { Name = "Alun Wyn Jones"; Team = wales; Type = Forward; Status = OriginalSquad }
    let jonesRyan = { Name = "Ryan Jones"; Team = wales; Type = Forward; Status = OriginalSquad }
    let lydiateDan = { Name = "Dan Lydiate"; Team = wales; Type = Forward; Status = OriginalSquad }
    let warburtonSam = { Name = "Sam Warburton"; Team = wales; Type = Forward; Status = OriginalSquad }
    let faletauTaulupe = { Name = "Taulupe Faletau"; Team = wales; Type = Forward; Status = OriginalSquad }
    let powellAndy = { Name = "Andy Powell"; Team = wales; Type = Forward; Status = OriginalSquad }
    let knoyleTavis = { Name = "Tavis Knoyle"; Team = wales; Type = Back; Status = OriginalSquad }
    let phillipsMike = { Name = "Mike Phillips"; Team = wales; Type = Back; Status = OriginalSquad }
    let williamsLloyd = { Name = "Lloyd Williams"; Team = wales; Type = Back; Status = OriginalSquad }
    let hookJames = { Name = "James Hook"; Team = wales; Type = Back; Status = OriginalSquad }
    let jonesStephen = { Name = "Stephen Jones"; Team = wales; Type = Back; Status = OriginalSquad }
    let priestlandRhys = { Name = "Rhys Priestland"; Team = wales; Type = Back; Status = OriginalSquad }
    let daviesJonathan = { Name = "Jonathan Davies"; Team = wales; Type = Back; Status = OriginalSquad }
    let robertsJamie = { Name = "Jamie Roberts"; Team = wales; Type = Back; Status = OriginalSquad }
    let williamsScott = { Name = "Scott Williams"; Team = wales; Type = Back; Status = OriginalSquad }
    let brewAled = { Name = "Aled Brew"; Team = wales; Type = Back; Status = OriginalSquad }
    let northGeorge = { Name = "George North"; Team = wales; Type = Back; Status = OriginalSquad }
    let williamsShane = { Name = "Shane Williams"; Team = wales; Type = Back; Status = OriginalSquad }
    let byrneLee = { Name = "Lee Byrne"; Team = wales; Type = Back; Status = OriginalSquad }
    let halfpennyLeigh = { Name = "Leigh Halfpenny"; Team = wales; Type = Back; Status = OriginalSquad }

    let walesSquad = { Team = wales
                       Players = [ bennettHuw; burnsLloyd; owensKen; bevingtonRyan; jamesPaul; jenkinsGethin; jonesAdam
                                   mitchellCraig; charterisLuke; daviesBradley; jonesAlunWyn; jonesRyan; lydiateDan; warburtonSam;
                                   faletauTaulupe; powellAndy; knoyleTavis; phillipsMike; williamsLloyd; hookJames; jonesStephen
                                   priestlandRhys; daviesJonathan; robertsJamie; williamsScott; brewAled; northGeorge; williamsShane
                                   byrneLee; halfpennyLeigh ] }

    let england = { Name = "England"; Status = Eliminated; Seeding = Some 6; Coach = "Martin Johnson" }

    let hartleyDylan = { Name = "Dylan Hartley"; Team = england; Type = Forward; Status = OriginalSquad }
    let mearsLee = { Name = "Lee Mears"; Team = england; Type = Forward; Status = OriginalSquad }
    let thompsonSteve = { Name = "Steve Thompson"; Team = england; Type = Forward; Status = OriginalSquad }
    let coleDan = { Name = "Dan Cole"; Team = england; Type = Forward; Status = OriginalSquad }
    let corbisieroAlex = { Name = "Alex Corbisiero"; Team = england; Type = Forward; Status = OriginalSquad }
    let stevensMatt = { Name = "Matt Stevens"; Team = england; Type = Forward; Status = OriginalSquad }
    let wilsonDavid = { Name = "David Wilson"; Team = england; Type = Forward; Status = OriginalSquad }
    let deaconLouis = { Name = "Louis Deacon"; Team = england; Type = Forward; Status = OriginalSquad }
    let lawesCourtney = { Name = "Courtney Lawes"; Team = england; Type = Forward; Status = OriginalSquad }
    let palmerTom = { Name = "Tom Palmer"; Team = england; Type = Forward; Status = OriginalSquad }
    let shawSimon = { Name = "Simon Shaw"; Team = england; Type = Forward; Status = OriginalSquad }
    let croftTom = { Name = "Tom Croft"; Team = england; Type = Forward; Status = OriginalSquad }
    let haskellJames = { Name = "James Haskell"; Team = england; Type = Forward; Status = OriginalSquad }
    let moodyLewis = { Name = "Lewis Moody"; Team = england; Type = Forward; Status = OriginalSquad }
    let woodTom = { Name = "Tom Wood"; Team = england; Type = Forward; Status = OriginalSquad }
    let easterNick = { Name = "Nick Easter"; Team = england; Type = Forward; Status = OriginalSquad }
    let simpsonJoe = { Name = "Joe Simpson"; Team = england; Type = Back; Status = OriginalSquad }
    let wigglesworthRichard = { Name = "Richard Wigglesworth"; Team = england; Type = Back; Status = OriginalSquad }
    let youngsBen = { Name = "Ben Youngs"; Team = england; Type = Back; Status = OriginalSquad }
    let floodToby = { Name = "Toby Flood"; Team = england; Type = Back; Status = OriginalSquad }
    let wilkinsonJonny = { Name = "Jonny Wilkinson"; Team = england; Type = Back; Status = OriginalSquad }
    let hapeShontayne = { Name = "Shontayne Hape"; Team = england; Type = Back; Status = OriginalSquad }
    let tindallMike = { Name = "Mike Tindall"; Team = england; Type = Back; Status = OriginalSquad }
    let tuilagiManu = { Name = "Manu Tuilagi"; Team = england; Type = Back; Status = OriginalSquad }
    let armitageDelon = { Name = "Delon Armitage"; Team = england; Type = Back; Status = OriginalSquad }
    let ashtonChris = { Name = "Chris Ashton"; Team = england; Type = Back; Status = OriginalSquad }
    let banahanMatt = { Name = "Matt Banahan"; Team = england; Type = Back; Status = OriginalSquad }
    let cuetoMark = { Name = "Mark Cueto"; Team = england; Type = Back; Status = OriginalSquad }
    let fodenBen = { Name = "Ben Foden"; Team = england; Type = Back; Status = OriginalSquad }
    let sheridanAndrew = { Name = "Andrew Sheridan"; Team = england; Type = Forward; Status = Withdrawn (Some (DateTime (2011, 9, 25))) }
    let waldromThomas = { Name = "Thomas Waldrom"; Team = england; Type = Forward; Status = Replacement (Some (DateTime (2011, 9, 25))) }

    let englandSquad = { Team = england
                         Players = [ hartleyDylan; mearsLee; thompsonSteve; coleDan; corbisieroAlex; stevensMatt; wilsonDavid
                                     deaconLouis; lawesCourtney; palmerTom; shawSimon; croftTom; haskellJames; moodyLewis; woodTom
                                     easterNick; simpsonJoe; wigglesworthRichard; youngsBen; floodToby; wilkinsonJonny
                                     hapeShontayne; tindallMike; tuilagiManu; armitageDelon; ashtonChris; banahanMatt; cuetoMark
                                     fodenBen; sheridanAndrew; waldromThomas ] }

    let france = { Name = "France"; Status = Eliminated; Seeding = Some 7; Coach = "Marc Lièvremont" }

    let guiradoGuilhem = { Name = "Guilhem Guirado"; Team = france; Type = Forward; Status = OriginalSquad }
    let servatWilliam = { Name = "William Servat"; Team = france; Type = Forward; Status = OriginalSquad }
    let szarzewskiDimitri = { Name = "Dimitri Szarzewski"; Team = france; Type = Forward; Status = OriginalSquad }
    let barcellaFabien = { Name = "Fabien Barcella"; Team = france; Type = Forward; Status = OriginalSquad }
    let ducalconLuc = { Name = "Luc Ducalcon"; Team = france; Type = Forward; Status = OriginalSquad }
    let masNicolas = { Name = "Nicolas Mas"; Team = france; Type = Forward; Status = OriginalSquad }
    let pouxJeanBaptiste = { Name = "Jean-Baptiste Poux"; Team = france; Type = Forward; Status = OriginalSquad }
    let milloChluskiRomain = { Name = "Romain Millo-Chluski"; Team = france; Type = Forward; Status = OriginalSquad }
    let nalletLionel = { Name = "Lionel Nallet"; Team = france; Type = Forward; Status = OriginalSquad }
    let papePascal = { Name = "Pascal Papé"; Team = france; Type = Forward; Status = OriginalSquad }
    let pierreJulien = { Name = "Julien Pierre"; Team = france; Type = Forward; Status = OriginalSquad }
    let bonnaireJulien = { Name = "Julien Bonnaire"; Team = france; Type = Forward; Status = OriginalSquad }
    let dusautoirThierry = { Name = "Thierry Dusautoir"; Team = france; Type = Forward; Status = OriginalSquad }
    let harinordoquyImanol = { Name = "Imanol Harinordoquy"; Team = france; Type = Forward; Status = OriginalSquad }
    let ouedraogoFulgence= { Name = "Fulgence Ouedraogo"; Team = france; Type = Forward; Status = OriginalSquad }
    let lakafiaRaphael = { Name = "Raphaël Lakafia"; Team = france; Type = Forward; Status = OriginalSquad }
    let picamolesLouis = { Name = "Louis Picamoles"; Team = france; Type = Forward; Status = OriginalSquad }
    let parraMorgan = { Name = "Morgan Parra"; Team = france; Type = Back; Status = OriginalSquad }
    let yachviliDimitri = { Name = "Dimitri Yachvili"; Team = france; Type = Back; Status = OriginalSquad }
    let trinhDucFrancois = { Name = "François Trinh-Duc"; Team = france; Type = Back; Status = OriginalSquad }
    let estebanezFabrice = { Name = "Fabrice Estebanez"; Team = france; Type = Back; Status = OriginalSquad }
    let martyDavid = { Name = "David Marty"; Team = france; Type = Back; Status = OriginalSquad }
    let mermozMaxime = { Name = "Maxime Mermoz"; Team = france; Type = Back; Status = OriginalSquad }
    let rougerieAurelien = { Name = "Aurélien Rougerie"; Team = france; Type = Back; Status = OriginalSquad }
    let clercVincent = { Name = "Vincent Clerc"; Team = france; Type = Back; Status = OriginalSquad }
    let medardMaxime = { Name = "Maxime Médard"; Team = france; Type = Back; Status = OriginalSquad }
    let palissonAlexis = { Name = "Alexis Palisson"; Team = france; Type = Back; Status = OriginalSquad }
    let heymansCedric = { Name = "Cédric Heymans"; Team = france; Type = Back; Status = OriginalSquad }
    let trailleDamien = { Name = "Damien Traille"; Team = france; Type = Back; Status = OriginalSquad }
    let skrelaDavid = { Name = "David Skrela"; Team = france; Type = Back; Status = Withdrawn None }
    let doussainJeanMarc = { Name = "Jean-Marc Doussain"; Team = france; Type = Back; Status = Replacement None }

    let franceSquad = { Team = france
                        Players = [ guiradoGuilhem; servatWilliam; szarzewskiDimitri; barcellaFabien; ducalconLuc; masNicolas
                                    pouxJeanBaptiste; milloChluskiRomain; nalletLionel; papePascal; pierreJulien; bonnaireJulien
                                    dusautoirThierry; harinordoquyImanol; ouedraogoFulgence; lakafiaRaphael; picamolesLouis
                                    parraMorgan; yachviliDimitri; trinhDucFrancois; estebanezFabrice; martyDavid; mermozMaxime
                                    rougerieAurelien; clercVincent; medardMaxime; palissonAlexis; heymansCedric; trailleDamien
                                    skrelaDavid; doussainJeanMarc ] }

    let ireland = { Name = "Ireland"; Status = Eliminated; Seeding = Some 8; Coach = "Declan Kidney" }

    let bestRory = { Name = "Rory Best"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let croninSean = { Name = "Sean Cronin"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let buckleyTony = { Name = "Tony Buckley"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let courtTom = { Name = "Tom Court"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let healyCian = { Name = "Cian Healy"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let rossMike = { Name = "Mike Ross"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let cullenLeo = { Name = "Leo Cullen"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let o'CallaghanDonnacha = { Name = "Donncha O'Callaghan"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let o'ConnellPaul = { Name = "Paul O'Connell"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let ryanDonnacha = { Name = "Donnacha Ryan"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let ferrisStephen = { Name = "Stephen Ferris"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let jenningsShane = { Name = "Shane Jennings"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let o'BrienSean = { Name = "Sean O'Brien"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let heaslipJamie = { Name = "Jamie Heaslip"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let leamyDenis = { Name = "Denis Leamy"; Team = ireland; Type = Forward; Status = OriginalSquad }
    let bossIsaac = { Name = "Isaac Boss"; Team = ireland; Type = Back; Status = OriginalSquad }
    let murrayConor = { Name = "Conor Murray"; Team = ireland; Type = Back; Status = OriginalSquad }
    let reddanEoin = { Name = "Eoin Reddan"; Team = ireland; Type = Back; Status = OriginalSquad }
    let o'GaraRonan = { Name = "Ronan O'Gara"; Team = ireland; Type = Back; Status = OriginalSquad }
    let sextonJonathan = { Name = "Jonathan Sexton"; Team = ireland; Type = Back; Status = OriginalSquad }
    let d'ArcyGordon = { Name = "Gordon D'Arcy"; Team = ireland; Type = Back; Status = OriginalSquad }
    let mcFaddenFergus = { Name = "Fergus McFadden"; Team = ireland; Type = Back; Status = OriginalSquad }
    let o'DriscollBrian = { Name = "Brian O'Driscoll"; Team = ireland; Type = Back; Status = OriginalSquad }
    let wallacePaddy = { Name = "Paddy Wallace"; Team = ireland; Type = Back; Status = OriginalSquad }
    let boweTommy = { Name = "Tommy Bowe"; Team = ireland; Type = Back; Status = OriginalSquad }
    let earlsKeith = { Name = "Keith Earls"; Team = ireland; Type = Back; Status = OriginalSquad }
    let trimbleAndrew = { Name = "Andrew Trimble"; Team = ireland; Type = Back; Status = OriginalSquad }
    let kearneyRob = { Name = "Rob Kearney"; Team = ireland; Type = Back; Status = OriginalSquad }
    let murphyGeordan = { Name = "Geordan Murphy"; Team = ireland; Type = Back; Status = OriginalSquad }
    let flanneryJerry = { Name = "Jerry Flannery"; Team = ireland; Type = Forward; Status = Withdrawn (Some (DateTime (2011, 9, 14))) }
    let varleyDamien = { Name = "Damien Varley"; Team = ireland; Type = Forward; Status = Replacement (Some (DateTime (2011, 9, 14))) }

    let irelandSquad = { Team = ireland
                         Players = [ bestRory; croninSean; buckleyTony; courtTom; healyCian; rossMike; cullenLeo; o'CallaghanDonnacha
                                     o'ConnellPaul; ryanDonnacha; ferrisStephen; jenningsShane; o'BrienSean; heaslipJamie; leamyDenis
                                     bossIsaac; murrayConor; reddanEoin; o'GaraRonan; sextonJonathan; d'ArcyGordon; mcFaddenFergus
                                     o'DriscollBrian; wallacePaddy; boweTommy; earlsKeith; trimbleAndrew; kearneyRob; murphyGeordan
                                     flanneryJerry; varleyDamien ] }

    let scotland = { Name = "Scotland"; Status = Eliminated; Seeding = Some 9; Coach = "Andy Robinson" }

    let fordRoss = { Name = "Ross Ford"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let hallDougie = { Name = "Dougie Hall"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let lawsonScott = { Name = "Scott Lawson"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let crossGeoff = { Name = "Geoff Cross"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let dickinsonAlasdair = { Name = "Alasdair Dickinson"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let jacobsenAllan = { Name = "Allan Jacobsen"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let lowMoray = { Name = "Moray Low"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let murrayEuan = { Name = "Euan Murray"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let grayRichie = { Name = "Richie Gray"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let hamiltonJim = { Name = "Jim Hamilton"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let hinesNathan = { Name = "Nathan Hines"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let kellockAlastair = { Name = "Alastair Kellock"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let barclayJohn = { Name = "John Barclay"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let brownKelly = { Name = "Kelly Brown"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let rennieRoss = { Name = "Ross Rennie"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let strokoschAlasdair = { Name = "Alasdair Strokosch"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let vernonRichie = { Name = "Richie Vernon"; Team = scotland; Type = Forward; Status = OriginalSquad }
    let blairMike = { Name = "Mike Blair"; Team = scotland; Type = Back; Status = OriginalSquad }
    let cusiterChris = { Name = "Chris Cusiter"; Team = scotland; Type = Back; Status = OriginalSquad }
    let lawsonRory = { Name = "Rory Lawson"; Team = scotland; Type = Back; Status = OriginalSquad }
    let jacksonRuaridh = { Name = "Ruaridh Jackson"; Team = scotland; Type = Back; Status = OriginalSquad }
    let parksDan = { Name = "Dan Parks"; Team = scotland; Type = Back; Status = OriginalSquad }
    let ansbroJoe = { Name = "Joe Ansbro"; Team = scotland; Type = Back; Status = OriginalSquad }
    let deLucaNick = { Name = "Nick De Luca"; Team = scotland; Type = Back; Status = OriginalSquad }
    let morrisonGraeme = { Name = "Graeme Morrison"; Team = scotland; Type = Back; Status = OriginalSquad }
    let danielliSimon = { Name = "Simon Danielli"; Team = scotland; Type = Back; Status = OriginalSquad }
    let evansMax = { Name = "Max Evans"; Team = scotland; Type = Back; Status = OriginalSquad }
    let lamontSean = { Name = "Sean Lamont"; Team = scotland; Type = Back; Status = OriginalSquad }
    let lamontRory = { Name = "Rory Lamont"; Team = scotland; Type = Back; Status = OriginalSquad }
    let patersonChris = { Name = "Chris Paterson"; Team = scotland; Type = Back; Status = OriginalSquad }

    let scotlandSquad = { Team = scotland
                          Players = [ fordRoss; hallDougie; lawsonScott; crossGeoff; dickinsonAlasdair; jacobsenAllan; lowMoray
                                      murrayEuan; grayRichie; hamiltonJim; hinesNathan; kellockAlastair; barclayJohn; brownKelly
                                      rennieRoss; strokoschAlasdair; vernonRichie; blairMike; cusiterChris; lawsonRory
                                      jacksonRuaridh; parksDan; ansbroJoe; deLucaNick; morrisonGraeme; danielliSimon; evansMax
                                      lamontSean; lamontRory; patersonChris ] }

    let fiji = { Name = "Fiji"; Status = Eliminated; Seeding = Some 10; Coach = "Sam Domoni" }

    let kotoSunia = { Name = "Sunia Koto"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let tuapatiTalemaitoga = { Name = "Talemaitoga Tuapati"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let veikosoViliame = { Name = "Viliame Veikoso"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let davetaWaisea = { Name = "Waisea Daveta"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let ma'afuCampese = { Name = "Campese Ma'afu"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let manuDeacon = { Name = "Deacon Manu"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let somocaSetefano = { Name = "Setefano Somoca"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let kalouSekonaia = { Name = "Sekonaia Kalou"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let lewaravuWame = { Name = "Wame Lewaravu"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let nakarawaLeone = { Name = "Leone Nakarawa"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let nasigaRupeni = { Name = "Rupeni Nasiga"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let qeraAkapusi = { Name = "Akapusi Qera"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let ravuloMalakai = { Name = "Malakai Ravulo"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let taleiNetani = { Name = "Netani Talei"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let waqaniburotuDominiko = { Name = "Dominiko Waqaniburotu"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let koyamaiboleSisa = { Name = "Sisa Koyamaibole"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let matadigoSakiusa = { Name = "Sakiusa Matadigo"; Team = fiji; Type = Forward; Status = OriginalSquad }
    let buatavaVitori = { Name = "Vitori Buatava"; Team = fiji; Type = Back; Status = OriginalSquad }
    let kenataleNemia = { Name = "Nemia Kenatale"; Team = fiji; Type = Back; Status = OriginalSquad }
    let littleNicky = { Name = "Nicky Little"; Team = fiji; Type = Back; Status = OriginalSquad }
    let luveniyaliWaisea = { Name = "Waisea Luveniyali"; Team = fiji; Type = Back; Status = OriginalSquad }
    let baiSeremaia = { Name = "Seremaia Bai"; Team = fiji; Type = Back; Status = OriginalSquad }
    let fatiakiRavai = { Name = "Ravai Fatiaki"; Team = fiji; Type = Back; Status = OriginalSquad }
    let lovobalavuGabiriele = { Name = "Gabiriele Lovobalavu"; Team = fiji; Type = Back; Status = OriginalSquad }
    let vuliVuliAlbert = { Name = "Albert VuliVuli"; Team = fiji; Type = Back; Status = OriginalSquad }
    let gonevaVereniki = { Name = "Vereniki Goneva"; Team = fiji; Type = Back; Status = OriginalSquad }
    let nalagaNapolioni = { Name = "Napolioni Nalaga"; Team = fiji; Type = Back; Status = OriginalSquad }
    let tagicakibauMichael = { Name = "Michael Tagicakibau"; Team = fiji; Type = Back; Status = OriginalSquad }
    let keresoniIliesa = { Name = "Iliesa Keresoni"; Team = fiji; Type = Back; Status = OriginalSquad }
    let murimurivaluKini = { Name = "Kini Murimurivalu"; Team = fiji; Type = Back; Status = OriginalSquad }

    let fijiSquad = { Team = fiji
                      Players = [ kotoSunia; tuapatiTalemaitoga; veikosoViliame; davetaWaisea; ma'afuCampese; manuDeacon
                                  somocaSetefano; kalouSekonaia; lewaravuWame; nakarawaLeone; nasigaRupeni; qeraAkapusi
                                  ravuloMalakai; taleiNetani; waqaniburotuDominiko; koyamaiboleSisa; matadigoSakiusa; buatavaVitori
                                  kenataleNemia; littleNicky; luveniyaliWaisea; baiSeremaia; fatiakiRavai; lovobalavuGabiriele
                                  vuliVuliAlbert; gonevaVereniki; nalagaNapolioni; tagicakibauMichael; keresoniIliesa
                                  murimurivaluKini ] }

    let italy = { Name = "Italy"; Status = Eliminated; Seeding = Some 11; Coach = "Nick Mallett" }

    let ghiraldiniLeonardo = { Name = "Leonardo Ghiraldini"; Team = italy; Type = Forward; Status = OriginalSquad }
    let ongaroFabio = { Name = "Fabio Ongaro"; Team = italy; Type = Forward; Status = OriginalSquad }
    let sbaragliniFranco = { Name = "Franco Sbaraglini"; Team = italy; Type = Forward; Status = OriginalSquad }
    let castrogiovanniMartin = { Name = "Martin Castrogiovanni"; Team = italy; Type = Forward; Status = OriginalSquad }
    let cittadiniLorenzo = { Name = "Lorenzo Cittadini"; Team = italy; Type = Forward; Status = OriginalSquad }
    let loCiceroAndrea = { Name = "Andrea Lo Cicero"; Team = italy; Type = Forward; Status = OriginalSquad }
    let peruginiSalvatore = { Name = "Salvatore Perugini"; Team = italy; Type = Forward; Status = OriginalSquad }
    let bortolamiMarco = { Name = "Marco Bortolami"; Team = italy; Type = Forward; Status = OriginalSquad }
    let delFavaCarlo = { Name = "Carlo Del Fava"; Team = italy; Type = Forward; Status = OriginalSquad }
    let geldenhuysQuintin = { Name = "Quintin Geldenhuys"; Team = italy; Type = Forward; Status = OriginalSquad }
    let vanZylCorniel = { Name = "Corniel van Zyl"; Team = italy; Type = Forward; Status = OriginalSquad }
    let barbieriRobert = { Name = "Robert Barbieri"; Team = italy; Type = Forward; Status = OriginalSquad }
    let bergamascoMauro = { Name = "Mauro Bergamasco"; Team = italy; Type = Forward; Status = OriginalSquad }
    let derbyshirePaul = { Name = "Paul Derbyshire"; Team = italy; Type = Forward; Status = OriginalSquad }
    let zanniAlessandro = { Name = "Alessandro Zanni"; Team = italy; Type = Forward; Status = OriginalSquad }
    let parisseSergio = { Name = "Sergio Parisse"; Team = italy; Type = Forward; Status = OriginalSquad }
    let canavosioPablo = { Name = "Pablo Canavosio"; Team = italy; Type = Back; Status = OriginalSquad }
    let goriEdoardo = { Name = "Edoardo Gori"; Team = italy; Type = Back; Status = OriginalSquad }
    let semenzatoFabio = { Name = "Fabio Semenzato"; Team = italy; Type = Back; Status = OriginalSquad }
    let bocchinoRiccardo = { Name = "Riccardo Bocchino"; Team = italy; Type = Back; Status = OriginalSquad }
    let orqueraLuciano = { Name = "Luciano Orquera"; Team = italy; Type = Back; Status = OriginalSquad }
    let canaleGonzalo = { Name = "Gonzalo Canale"; Team = italy; Type = Back; Status = OriginalSquad }
    let garciaGonzalo = { Name = "Gonzalo Garcia"; Team = italy; Type = Back; Status = OriginalSquad }
    let pratichettiMatteo = { Name = "Matteo Pratichetti"; Team = italy; Type = Back; Status = OriginalSquad }
    let sgarbiAlberto = { Name = "Alberto Sgarbi"; Team = italy; Type = Back; Status = OriginalSquad }
    let benvenutiTommaso = { Name = "Tommaso Benvenuti"; Team = italy; Type = Back; Status = OriginalSquad }
    let bergamascoMirco = { Name = "Mirco Bergamasco"; Team = italy; Type = Back; Status = OriginalSquad }
    let toniolattiGiulio = { Name = "Giulio Toniolatti"; Team = italy; Type = Back; Status = OriginalSquad }
    let masiAndrea = { Name = "Andrea Masi"; Team = italy; Type = Back; Status = OriginalSquad }
    let mcLeanLuke = { Name = "Luke McLean"; Team = italy; Type = Back; Status = OriginalSquad }

    let italySquad = { Team = italy
                       Players = [ ghiraldiniLeonardo; ongaroFabio; sbaragliniFranco; castrogiovanniMartin; cittadiniLorenzo
                                   loCiceroAndrea; peruginiSalvatore; bortolamiMarco; delFavaCarlo; geldenhuysQuintin; vanZylCorniel
                                   barbieriRobert; bergamascoMauro; derbyshirePaul; zanniAlessandro; parisseSergio; canavosioPablo
                                   goriEdoardo; semenzatoFabio; bocchinoRiccardo; orqueraLuciano; canaleGonzalo; garciaGonzalo
                                   pratichettiMatteo; sgarbiAlberto; benvenutiTommaso; bergamascoMirco; toniolattiGiulio; masiAndrea
                                   mcLeanLuke ] }

    let tonga = { Name = "Tonga"; Status = Eliminated; Seeding = Some 12; Coach = "Isitolo Maka" }

    let lutuiAleki = { Name = "Aleki Lutui"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let ma'asiIlaisa = { Name = "Ilaisa Ma'asi"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let taukafaEphraim = { Name = "Ephraim Taukafa"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let aulikaHalani = { Name = "Halani Aulika"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let filiseTaufa'ao = { Name = "Taufa'ao Filise"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let puluKisi = { Name = "Kisi Pulu"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let taumaloloSona = { Name = "Sona Taumalolo"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let tonga'uihaSoane = { Name = "Soane Tonga'uiha"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let heheaPaino = { Name = "Paino Hehea"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let lokotuiTukulua = { Name = "Tukulua Lokotui"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let timaniSione = { Name = "Sione Timani"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let tuineauJoe = { Name = "Joe Tuineau"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let kalamafoniSione = { Name = "Sione Kalamafoni"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let makaFinau = { Name = "Finau Maka"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let vaiomo'ungaSione = { Name = "Sione Vaiomo'unga"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let ma'afuViliami = { Name = "Viliami Ma'afu"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let vahafolauSamiu = { Name = "Samiu Vahafolau"; Team = tonga; Type = Forward; Status = OriginalSquad }
    let fisilauSamisoni = { Name = "Samisoni Fisilau"; Team = tonga; Type = Back; Status = OriginalSquad }
    let moaTaniela = { Name = "Taniela Moa"; Team = tonga; Type = Back; Status = OriginalSquad }
    let paluThomas = { Name = "Thomas Palu"; Team = tonga; Type = Back; Status = OriginalSquad }
    let morathKurt = { Name = "Kurt Morath"; Team = tonga; Type = Back; Status = OriginalSquad }
    let fatafehiAlipate = { Name = "Alipate Fatafehi"; Team = tonga; Type = Back; Status = OriginalSquad }
    let hufangaSuka = { Name = "Suka Hufanga"; Team = tonga; Type = Back; Status = OriginalSquad }
    let ma'ileiAndrew = { Name = "Andrew Ma'ilei"; Team = tonga; Type = Back; Status = OriginalSquad }
    let piutauSiale = { Name = "Siale Piutau"; Team = tonga; Type = Back; Status = OriginalSquad }
    let heluWilliam = { Name = "William Helu"; Team = tonga; Type = Back; Status = OriginalSquad }
    let taufuAlaska = { Name = "Alaska Taufa"; Team = tonga; Type = Back; Status = OriginalSquad }
    let vainikoloFetu'u = { Name = "Fetu'u Vainikolo"; Team = tonga; Type = Back; Status = OriginalSquad }
    let iongiViliame = { Name = "Viliame Iongi"; Team = tonga; Type = Back; Status = OriginalSquad }
    let liloVunga = { Name = "Vunga Lilo"; Team = tonga; Type = Back; Status = OriginalSquad }

    let tongaSquad = { Team = tonga
                       Players = [ lutuiAleki; ma'asiIlaisa; taukafaEphraim; aulikaHalani; filiseTaufa'ao; puluKisi; taumaloloSona
                                   tonga'uihaSoane; heheaPaino; lokotuiTukulua; timaniSione; tuineauJoe; kalamafoniSione; makaFinau
                                   vaiomo'ungaSione; ma'afuViliami; vahafolauSamiu; fisilauSamisoni; moaTaniela; paluThomas
                                   morathKurt; fatafehiAlipate; hufangaSuka; ma'ileiAndrew; piutauSiale; heluWilliam; taufuAlaska
                                   vainikoloFetu'u; iongiViliame; liloVunga ] }

    let canada = { Name = "Canada"; Status = Eliminated; Seeding = None; Coach = "Kieran Crowley" }

    let hamiltonRyan = { Name = "Ryan Hamilton"; Team = canada; Type = Forward; Status = OriginalSquad }
    let riordanPat = { Name = "Pat Riordan"; Team = canada; Type = Forward; Status = OriginalSquad }
    let buydensHubert= { Name = "Hubert Buydens"; Team = canada; Type = Forward; Status = OriginalSquad }
    let franklinScott = { Name = "Scott Franklin"; Team = canada; Type = Forward; Status = OriginalSquad }
    let marshallJason = { Name = "Jason Marshall"; Team = canada; Type = Forward; Status = OriginalSquad }
    let tiedemannAndrew = { Name = "Andrew Tiedemann"; Team = canada; Type = Forward; Status = OriginalSquad }
    let walshFrank = { Name = "Frank Walsh"; Team = canada; Type = Forward; Status = OriginalSquad }
    let cudmoreJamie = { Name = "Jamie Cudmore"; Team = canada; Type = Forward; Status = OriginalSquad }
    let erichsenBrian = { Name = "Brian Erichsen"; Team = canada; Type = Forward; Status = OriginalSquad }
    let hotsonTyler = { Name = "Tyler Hotson"; Team = canada; Type = Forward; Status = OriginalSquad }
    let dalaNanyak = { Name = "Nanyak Dala"; Team = canada; Type = Forward; Status = OriginalSquad }
    let kleebergerAdam = { Name = "Adam Kleeberger"; Team = canada; Type = Forward; Status = OriginalSquad }
    let o'TooleChauncey = { Name = "Chauncey O'Toole"; Team = canada; Type = Forward; Status = OriginalSquad }
    let sinclairJebb = { Name = "Jebb Sinclair"; Team = canada; Type = Forward; Status = OriginalSquad }
    let carpenterAaron = { Name = "Aaron Carpenter"; Team = canada; Type = Forward; Status = OriginalSquad }
    let kyneJeremy = { Name = "Jeremy Kyne"; Team = canada; Type = Forward; Status = OriginalSquad }
    let fairhurstEd = { Name = "Ed Fairhurst"; Team = canada; Type = Back; Status = OriginalSquad }
    let mackenzieJamie = { Name = "Jamie Mackenzie"; Team = canada; Type = Back; Status = OriginalSquad }
    let whiteSean = { Name = "Sean White"; Team = canada; Type = Back; Status = OriginalSquad }
    let hirayamaNathan = { Name = "Nathan Hirayama"; Team = canada; Type = Back; Status = OriginalSquad }
    let monroAnder = { Name = "Ander Monro"; Team = canada; Type = Back; Status = OriginalSquad }
    let scholzMike = { Name = "Mike Scholz"; Team = canada; Type = Back; Status = OriginalSquad }
    let smithRyan = { Name = "Ryan Smith"; Team = canada; Type = Back; Status = OriginalSquad }
    let trainorConor = { Name = "Conor Trainor"; Team = canada; Type = Back; Status = OriginalSquad }
    let vanderMerweDTH = { Name = "DTH van der Merwe"; Team = canada; Type = Back; Status = OriginalSquad }
    let hearnCiaran = { Name = "Ciaran Hearn"; Team = canada; Type = Back; Status = OriginalSquad }
    let mackenziePhil = { Name = "Phil Mackenzie"; Team = canada; Type = Back; Status = OriginalSquad }
    let parisTaylor = { Name = "Taylor Paris"; Team = canada; Type = Back; Status = OriginalSquad }
    let evansMatt = { Name = "Matt Evans"; Team = canada; Type = Back; Status = OriginalSquad }
    let pritchardJames = { Name = "James Pritchard"; Team = canada; Type = Back; Status = OriginalSquad }

    let canadaSquad = { Team = canada
                        Players = [ hamiltonRyan; riordanPat; buydensHubert; franklinScott; marshallJason; tiedemannAndrew
                                    walshFrank; cudmoreJamie; erichsenBrian; hotsonTyler; dalaNanyak; kleebergerAdam; o'TooleChauncey
                                    sinclairJebb; carpenterAaron; kyneJeremy; fairhurstEd; mackenzieJamie; whiteSean; hirayamaNathan
                                    monroAnder; scholzMike; smithRyan; trainorConor; vanderMerweDTH; hearnCiaran; mackenziePhil
                                    parisTaylor; evansMatt; pritchardJames ] }

    let japan = { Name = "Japan"; Status = Eliminated; Seeding = None; Coach = "John Kirwan" }

    let aokiYusuke = { Name = "Yusuke Aoki"; Team = japan; Type = Forward; Status = OriginalSquad }
    let horieShota = { Name = "Shota Horie"; Team = japan; Type = Forward; Status = OriginalSquad }
    let yuharaHiroki = { Name = "Hiroki Yuhara"; Team = japan; Type = Forward; Status = OriginalSquad }
    let fujitaNozomu = { Name = "Nozomu Fujita"; Team = japan; Type = Forward; Status = OriginalSquad }
    let hatakeyamaKensuke = { Name = "Kensuke Hatakeyama"; Team = japan; Type = Forward; Status = OriginalSquad }
    let hirashimaHisateru = { Name = "Hisateru Hirashima"; Team = japan; Type = Forward; Status = OriginalSquad }
    let kawamataNaoki = { Name = "Naoki Kawamata"; Team = japan; Type = Forward; Status = OriginalSquad }
    let kitagawaToshizumi = { Name = "Toshizumi Kitagawa"; Team = japan; Type = Forward; Status = OriginalSquad }
    let kitagawaYuji = { Name = "Yuji Kitagawa"; Team = japan; Type = Forward; Status = OriginalSquad }
    let onoHitoshi = { Name = "Hitoshi Ono"; Team = japan; Type = Forward; Status = OriginalSquad }
    let thompsonLuke = { Name = "Luke Thompson"; Team = japan; Type = Forward; Status = OriginalSquad }
    let kikutaniTakashi = { Name = "Takashi Kikutani"; Team = japan; Type = Forward; Status = OriginalSquad }
    let leitchMichael = { Name = "Michael Leitch"; Team = japan; Type = Forward; Status = OriginalSquad }
    let vatuveiSione = { Name = "Sione Vatuvei"; Team = japan; Type = Forward; Status = OriginalSquad }
    let taniguchiItare = { Name = "Itaru Taniguchi"; Team = japan; Type = Forward; Status = OriginalSquad }
    let taufaToetu'u = { Name = "Toetu'u Taufa"; Team = japan; Type = Forward; Status = OriginalSquad }
    let asadaIppei = { Name = "Ippei Asada"; Team = japan; Type = Back; Status = OriginalSquad }
    let hiwasaAtsushi = { Name = "Atsushi Hiwasa"; Team = japan; Type = Back; Status = OriginalSquad }
    let tanakaFumiaki = { Name = "Fumiaki Tanaka"; Team = japan; Type = Back; Status = OriginalSquad }
    let arlidgeJames = { Name = "James Arlidge"; Team = japan; Type = Back; Status = OriginalSquad }
    let williamsMurray = { Name = "Murray Williams"; Team = japan; Type = Back; Status = OriginalSquad }
    let nicholasRyan = { Name = "Ryan Nicholas"; Team = japan; Type = Back; Status = OriginalSquad }
    let robinsBryce = { Name = "Bryce Robins"; Team = japan; Type = Back; Status = OriginalSquad }
    let tairaKoji = { Name = "Koji Taira"; Team = japan; Type = Back; Status = OriginalSquad }
    let tupuailaiAlisi = { Name = "Alisi Tupuailai"; Team = japan; Type = Back; Status = OriginalSquad }
    let endoKosuke = { Name = "Kosuke Endo"; Team = japan; Type = Back; Status = OriginalSquad }
    let onozawaHirotoki = { Name = "Hirotoki Onozawa"; Team = japan; Type = Back; Status = OriginalSquad }
    let usuzukiTakehisa = { Name = "Takehisa Usuzuki"; Team = japan; Type = Back; Status = OriginalSquad }
    let uedaTaihei = { Name = "Taihei Ueda"; Team = japan; Type = Back; Status = OriginalSquad }
    let webbShaun = { Name = "Shaun Webb"; Team = japan; Type = Back; Status = OriginalSquad }

    let japanSquad = { Team = japan
                       Players = [ aokiYusuke; horieShota; yuharaHiroki; fujitaNozomu; hatakeyamaKensuke; hirashimaHisateru
                                   kawamataNaoki; kitagawaToshizumi; kitagawaYuji; onoHitoshi; thompsonLuke; kikutaniTakashi
                                   leitchMichael; vatuveiSione; taniguchiItare; taufaToetu'u; asadaIppei; hiwasaAtsushi
                                   tanakaFumiaki; arlidgeJames; williamsMurray; nicholasRyan; robinsBryce; tairaKoji; tupuailaiAlisi
                                   endoKosuke; onozawaHirotoki; usuzukiTakehisa; uedaTaihei; webbShaun ] }

    let georgia = { Name = "Georgia"; Status = Eliminated; Seeding = None; Coach = "Richie Dixon" }

    let bregvadzeJaba = { Name = "Jaba Bregvadze"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let giorgadzeAkvsenti = { Name = "Akvsenti Giorgadze"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let kakovinVasil = { Name = "Vasil Kakovin"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let khinchagishviliDavit = { Name = "Davit Khinchagishvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let kubriashviliDavit = { Name = "Davit Kubriashvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let shvelidzeGoderdzi = { Name = "Goderdzi Shvelidze"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let zirakashviliDavit = { Name = "Davit Zirakashvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let datunashviliLevan = { Name = "Levan Datunashvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let maisuradzeVakhtang = { Name = "Vakhtang Maisuradze"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let nemsadzeGuirgi = { Name = "Giorgi Nemsadze"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let zedginidzeIlia = { Name = "Ilia Zedginidze"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let berishviliGivi = { Name = "Givi Berishvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let chkhaidzeGiorgi = { Name = "Giorgi Chkhaidze"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let kolelishviliViktor = { Name = "Viktor Kolelishvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let sutiashviliShalva = { Name = "Shalva Sutiashvili"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let basilaiaDimitri = { Name = "Dimitri Basilaia"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let gorgodzeMamuka = { Name = "Mamuka Gorgodze"; Team = georgia; Type = Forward; Status = OriginalSquad }
    let abuseridzeIrakli = { Name = "Irakli Abuseridze"; Team = georgia; Type = Back; Status = OriginalSquad }
    let samkharadzeBidzina = { Name = "Bidzina Samkharadze"; Team = georgia; Type = Back; Status = OriginalSquad }
    let khmaladzeLasha = { Name = "Lasha Khmaladze"; Team = georgia; Type = Back; Status = OriginalSquad }
    let kvirikashviliMerab = { Name = "Merab Kvirikashvili"; Team = georgia; Type = Back; Status = OriginalSquad }
    let malaghuradzeLasha = { Name = "Lasha Malaghuradze"; Team = georgia; Type = Back; Status = OriginalSquad }
    let kacharavaDavit = { Name = "Davit Kacharava"; Team = georgia; Type = Back; Status = OriginalSquad }
    let toduaAlexander = { Name = "Alexander Todua"; Team = georgia; Type = Back; Status = OriginalSquad }
    let zibzibadzeTedo = { Name = "Tedo Zibzibadze"; Team = georgia; Type = Back; Status = OriginalSquad }
    let chkhikvadzeItakli = { Name = "Irakli Chkhikvadze"; Team = georgia; Type = Back; Status = OriginalSquad }
    let gugavaLexo = { Name = "Lexo Gugava"; Team = georgia; Type = Back; Status = OriginalSquad }
    let machkhaneliIrakli = { Name = "Irakli Machkhaneli"; Team = georgia; Type = Back; Status = OriginalSquad }
    let gigauriRevaz = { Name = "Revaz Gigauri"; Team = georgia; Type = Back; Status = OriginalSquad }
    let urjukashviliMalkhaz = { Name = "Malkhaz Urjukashvili"; Team = georgia; Type = Back; Status = OriginalSquad }

    let georgiaSquad = { Team = georgia
                         Players = [ bregvadzeJaba; giorgadzeAkvsenti; kakovinVasil; khinchagishviliDavit; kubriashviliDavit
                                     shvelidzeGoderdzi; zirakashviliDavit; datunashviliLevan; maisuradzeVakhtang; nemsadzeGuirgi
                                     zedginidzeIlia; berishviliGivi; chkhaidzeGiorgi; kolelishviliViktor; sutiashviliShalva
                                     basilaiaDimitri; gorgodzeMamuka; abuseridzeIrakli; samkharadzeBidzina; khmaladzeLasha
                                     kvirikashviliMerab; malaghuradzeLasha; kacharavaDavit; toduaAlexander; zibzibadzeTedo
                                     chkhikvadzeItakli; gugavaLexo; machkhaneliIrakli; gigauriRevaz; urjukashviliMalkhaz ] }

    let romania = { Name = "Romania"; Status = Eliminated; Seeding = None; Coach = "Romeo Gontineac" }

    let tincuMarius = { Name = "Marius Tincu"; Team = romania; Type = Forward; Status = OriginalSquad }
    let zebegaBogdan = { Name = "Bogdan Zebega"; Team = romania; Type = Forward; Status = OriginalSquad }
    let dimaDragos = { Name = "Dragoş Dima"; Team = romania; Type = Forward; Status = OriginalSquad }
    let floreaSilviu = { Name = "Silviu Florea"; Team = romania; Type = Forward; Status = OriginalSquad }
    let ionPaulica = { Name = "Paulică Ion"; Team = romania; Type = Forward; Status = OriginalSquad }
    let lazarMihaita = { Name = "Mihaita Lazăr"; Team = romania; Type = Forward; Status = OriginalSquad }
    let nereNicolae = { Name = "Nicolae Nere"; Team = romania; Type = Forward; Status = OriginalSquad }
    let petreCristian = { Name = "Cristian Petre"; Team = romania; Type = Forward; Status = OriginalSquad }
    let popirlanValentin = { Name = "Valentin Popirlan"; Team = romania; Type = Forward; Status = OriginalSquad }
    let ratiuCosmin = { Name = "Cosmin Raţiu"; Team = romania; Type = Forward; Status = OriginalSquad }
    let ursacheValentin = { Name = "Valentin Ursache"; Team = romania; Type = Forward; Status = OriginalSquad }
    let burceaStelian = { Name = "Stelian Burcea"; Team = romania; Type = Forward; Status = OriginalSquad }
    let ianusDaniel = { Name = "Daniel Ianus"; Team = romania; Type = Forward; Status = OriginalSquad }
    let macoveiMihai = { Name = "Mihai Macovei"; Team = romania; Type = Forward; Status = OriginalSquad }
    let carpoDaneil = { Name = "Daniel Carpo"; Team = romania; Type = Forward; Status = OriginalSquad }
    let tonitaOvidiu = { Name = "Ovidiu Toniţa"; Team = romania; Type = Forward; Status = OriginalSquad }
    let calafeteanuValentin = { Name = "Valentin Calafeteanu"; Team = romania; Type = Back; Status = OriginalSquad }
    let sirbuLucian = { Name = "Lucian Sîrbu"; Team = romania; Type = Back; Status = OriginalSquad }
    let surugiuFlorin = { Name = "Florin Surugiu"; Team = romania; Type = Back; Status = OriginalSquad }
    let dimofteIonut = { Name = "Ionuţ Dimofte"; Team = romania; Type = Back; Status = OriginalSquad }
    let dumbravaDanut = { Name = "Dănuţ Dumbravă"; Team = romania; Type = Back; Status = OriginalSquad }
    let cazanIonel = { Name = "Ionel Cazan"; Team = romania; Type = Back; Status = OriginalSquad }
    let galCsaba = { Name = "Csaba Gál"; Team = romania; Type = Back; Status = OriginalSquad }
    let ghearaConstantin = { Name = "Constantin Gheara"; Team = romania; Type = Back; Status = OriginalSquad }
    let apostolAdrian = { Name = "Adrian Apostol"; Team = romania; Type = Back; Status = OriginalSquad }
    let ciuntuStefan = { Name = "Stefan Ciuntu"; Team = romania; Type = Back; Status = OriginalSquad }
    let lemnaruMadalin = { Name = "Mădălin Lemnaru"; Team = romania; Type = Back; Status = OriginalSquad }
    let nicolaeCatalin = { Name = "Cătălin Nicolae"; Team = romania; Type = Back; Status = OriginalSquad }
    let dumitrasIulian = { Name = "Iulian Dumitraș"; Team = romania; Type = Back; Status = OriginalSquad }
    let vlaicuFlorin = { Name = "Florin Vlaicu"; Team = romania; Type = Back; Status = OriginalSquad }

    let romaniaSquad = { Team = romania
                         Players = [ tincuMarius; zebegaBogdan; dimaDragos; floreaSilviu; ionPaulica; lazarMihaita; nereNicolae
                                     petreCristian; popirlanValentin; ratiuCosmin; ursacheValentin; burceaStelian; ianusDaniel
                                     macoveiMihai; carpoDaneil; tonitaOvidiu; calafeteanuValentin; sirbuLucian; surugiuFlorin
                                     dimofteIonut; dumbravaDanut; cazanIonel; galCsaba; ghearaConstantin; apostolAdrian
                                     ciuntuStefan; lemnaruMadalin; nicolaeCatalin; dumitrasIulian; vlaicuFlorin ] }

    let unitedStates = { Name = "United States"; Status = Eliminated; Seeding = None; Coach = "Eddie O'Sullivan" }

    let billerChris = { Name = "Chris Biller"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let mcClenahanBrian = { Name = "Brian McClenahan"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let thielPhil = { Name = "Phil Thiel"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let fryEric = { Name = "Eric Fry"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let macDonaldMike = { Name = "Mike MacDonald"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let moeakiolaMate = { Name = "Mate Moeakiola"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let pittmanShawn = { Name = "Shawn Pittman"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let laVallaScott = { Name = "Scott LaValla"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let smithHayden = { Name = "Hayden Smith"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let vanderGiessenJohn = { Name = "John van der Giessen"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let basauriInaki = { Name = "Inaki Basauri"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let cleverTodd = { Name = "Todd Clever"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let danahyPat = { Name = "Pat Danahy"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let stanfillLouis = { Name = "Louis Stanfill"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let gagianoJJ = { Name = "JJ Gagiano"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let johnsonNic = { Name = "Nic Johnson"; Team = unitedStates; Type = Forward; Status = OriginalSquad }
    let petriMike = { Name = "Mike Petri"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let usaszTim = { Name = "Tim Usasz"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let malifaValenese = { Name = "Valenese Malifa"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let suniulaRoland = { Name = "Roland Suniula"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let emerickPaul = { Name = "Paul Emerick"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let enosaTai = { Name = "Tai Enosa"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let sifaJunior = { Name = "Junior Sifa"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let suniulaAndrew = { Name = "Andrew Suniula"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let hawleyColin = { Name = "Colin Hawley"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let ngwenyaTakudzwa = { Name = "Takudzwa Ngwenya"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let patersonJames = { Name = "James Paterson"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let swirynKevin = { Name = "Kevin Swiryn"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let scullyBlaine = { Name = "Blaine Scully"; Team = unitedStates; Type = Back; Status = OriginalSquad }
    let wylesChris = { Name = "Chris Wyles"; Team = unitedStates; Type = Back; Status = OriginalSquad }

    let unitedStatesSquad = { Team = unitedStates
                              Players = [ billerChris; mcClenahanBrian; thielPhil; fryEric; macDonaldMike; moeakiolaMate
                                          pittmanShawn; laVallaScott; smithHayden; vanderGiessenJohn; basauriInaki; cleverTodd
                                          danahyPat; stanfillLouis; gagianoJJ; johnsonNic; petriMike; usaszTim; malifaValenese
                                          suniulaRoland; emerickPaul; enosaTai; sifaJunior; suniulaAndrew; hawleyColin
                                          ngwenyaTakudzwa; patersonJames; swirynKevin; scullyBlaine; wylesChris ] }

    let russia = { Name = "Russia"; Status = Eliminated; Seeding = None; Coach = "Nikolay Nerush" }

    let korshunovVladislav = { Name = "Vladislav Korshunov"; Team = russia; Type = Forward; Status = OriginalSquad }
    let matveyevYevgeny = { Name = "Yevgeny Matveyev"; Team = russia; Type = Forward; Status = OriginalSquad }
    let tsnobiladzeValeri = { Name = "Valeri Tsnobiladze"; Team = russia; Type = Forward; Status = OriginalSquad }
    let botvinnikovVladimir = { Name = "Vladimir Botvinnikov"; Team = russia; Type = Forward; Status = OriginalSquad }
    let khrokinAlexander = { Name = "Alexander Khrokin"; Team = russia; Type = Forward; Status = OriginalSquad }
    let popovSergey = { Name = "Sergey Popov"; Team = russia; Type = Forward; Status = OriginalSquad }
    let prishchepenkoIvan = { Name = "Ivan Prishchepenko"; Team = russia; Type = Forward; Status = OriginalSquad }
    let travkinAlexei = { Name = "Alexei Travkin"; Team = russia; Type = Forward; Status = OriginalSquad }
    let antonovDenis = { Name = "Denis Antonov"; Team = russia; Type = Forward; Status = OriginalSquad }
    let byrnesAdam = { Name = "Adam Byrnes"; Team = russia; Type = Forward; Status = OriginalSquad }
    let ostrikovAndrei = { Name = "Andrei Ostrikov"; Team = russia; Type = Forward; Status = OriginalSquad }
    let voytovAlexander = { Name = "Alexander Voytov"; Team = russia; Type = Forward; Status = OriginalSquad }
    let fatakhovArtem = { Name = "Artem Fatakhov"; Team = russia; Type = Forward; Status = OriginalSquad }
    let garbuzovAndrey = { Name = "Andrey Garbuzov"; Team = russia; Type = Forward; Status = OriginalSquad }
    let sidorovMikhail = { Name = "Mikhail Sidorov"; Team = russia; Type = Forward; Status = OriginalSquad }
    let grachevViacheslav = { Name = "Viacheslav Grachev"; Team = russia; Type = Forward; Status = OriginalSquad }
    let gresevVictor = { Name = "Victor Gresev"; Team = russia; Type = Forward; Status = OriginalSquad }
    let bykanovAndrei = { Name = "Andrei Bykanov"; Team = russia; Type = Back; Status = OriginalSquad }
    let shakirovAlexander = { Name = "Alexander Shakirov"; Team = russia; Type = Back; Status = OriginalSquad }
    let yanyushkinAlexander = { Name = "Alexander Yanyushkin"; Team = russia; Type = Back; Status = OriginalSquad }
    let kushnarevYuri = { Name = "Yuri Kushnarev"; Team = russia; Type = Back; Status = OriginalSquad }
    let rachkovKonstantin = { Name = "Konstantin Rachkov"; Team = russia; Type = Back; Status = OriginalSquad }
    let babaevMikhail = { Name = "Mikhail Babaev"; Team = russia; Type = Back; Status = OriginalSquad }
    let makovetskiyAlexey = { Name = "Alexey Makovetskiy"; Team = russia; Type = Back; Status = OriginalSquad }
    let trishinSergey = { Name = "Sergey Trishin"; Team = russia; Type = Back; Status = OriginalSquad }
    let artemievVasily = { Name = "Vasily Artemiev"; Team = russia; Type = Back; Status = OriginalSquad }
    let kuzinAndrei = { Name = "Andrei Kuzin"; Team = russia; Type = Back; Status = OriginalSquad }
    let ostroushkoVladimir = { Name = "Vladimir Ostroushko"; Team = russia; Type = Back; Status = OriginalSquad }
    let simplikevichDenis = { Name = "Denis Simplikevich"; Team = russia; Type = Back; Status = OriginalSquad }
    let klyuchnikovIgor = { Name = "Igor Klyuchnikov"; Team = russia; Type = Back; Status = OriginalSquad }

    let russiaSquad = { Team = russia
                        Players = [ korshunovVladislav; matveyevYevgeny; tsnobiladzeValeri; khrokinAlexander; botvinnikovVladimir
                                    popovSergey; prishchepenkoIvan; travkinAlexei; antonovDenis; byrnesAdam; ostrikovAndrei
                                    voytovAlexander; fatakhovArtem; garbuzovAndrey; sidorovMikhail; grachevViacheslav; gresevVictor
                                    bykanovAndrei; shakirovAlexander; yanyushkinAlexander; kushnarevYuri; rachkovKonstantin; babaevMikhail
                                    makovetskiyAlexey; trishinSergey; artemievVasily; kuzinAndrei; ostroushkoVladimir
                                    simplikevichDenis; klyuchnikovIgor ] }

    let samoa = { Name = "Samoa"; Status = Eliminated; Seeding = None; Coach = "Titimaea Tafua" }

    let aveiOle = { Name = "Ole Avei"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let pauloTi'i = { Name = "Ti’i Paulo"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let schwalgerMahonri = { Name = "Mahonri Schwalger"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let johnstonCensus = { Name = "Census Johnston"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let mulipolaLogovi'i = { Name = "Logovi'i Mulipola"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let perenisiAnthony = { Name = "Anthony Perenise"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let taulafoSakaria = { Name = "Sakaria Taulafo"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let leoDaniel = { Name = "Daniel Leo"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let leviFilipo = { Name = "Filipo Levi"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let tekoriJoe = { Name = "Joe Tekori"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let thompsonKane = { Name = "Kane Thompson"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let fa'asavaluMaurie = { Name = "Maurie Fa'asavalu"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let salaveaManaia = { Name = "Manaia Salavea"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let treviranusOfisa = { Name = "Ofisa Treviranus"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let tuifu'aTaiasina = { Name = "Taiasina Tuifu'a"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let stowersGeorge = { Name = "George Stowers"; Team = samoa; Type = Forward; Status = OriginalSquad }
    let fotuali'iKahn = { Name = "Kahn Fotuali'i"; Team = samoa; Type = Back; Status = OriginalSquad }
    let poluleuligagaJunior = { Name = "Junior Poluleuligaga"; Team = samoa; Type = Back; Status = OriginalSquad }
    let su'aJeremy = { Name = "Jeremy Su'a"; Team = samoa; Type = Back; Status = OriginalSquad }
    let laveaTasesa = { Name = "Tasesa Lavea"; Team = samoa; Type = Back; Status = OriginalSquad }
    let pisiTusi = { Name = "Tusi Pisi"; Team = samoa; Type = Back; Status = OriginalSquad }
    let fuimaonoSapoluEliota = { Name = "Eliota Fuimaono-Sapolu"; Team = samoa; Type = Back; Status = OriginalSquad }
    let leotaJohnny = { Name = "Johnny Leota"; Team = samoa; Type = Back; Status = OriginalSquad }
    let mapusuaSeilala = { Name = "Seilala Mapusua"; Team = samoa; Type = Back; Status = OriginalSquad }
    let pisiGeorge = { Name = "George Pisi"; Team = samoa; Type = Back; Status = OriginalSquad }
    let lemiDavid = { Name = "David Lemi"; Team = samoa; Type = Back; Status = OriginalSquad }
    let tagicakibauSailosi = { Name = "Sailosi Tagicakibau"; Team = samoa; Type = Back; Status = OriginalSquad }
    let tuilagiAlesana = { Name = "Alesana Tuilagi"; Team = samoa; Type = Back; Status = OriginalSquad }
    let so'oialoJames = { Name = "James So'oialo"; Team = samoa; Type = Back; Status = OriginalSquad }
    let williamsPaul = { Name = "Paul Williams"; Team = samoa; Type = Back; Status = OriginalSquad }

    let samoaSquad = { Team = samoa
                       Players = [ aveiOle; pauloTi'i; schwalgerMahonri; johnstonCensus; mulipolaLogovi'i; perenisiAnthony
                                   taulafoSakaria; leoDaniel; leviFilipo; tekoriJoe; thompsonKane; fa'asavaluMaurie; salaveaManaia
                                   treviranusOfisa; tuifu'aTaiasina; stowersGeorge; fotuali'iKahn; poluleuligagaJunior; su'aJeremy
                                   laveaTasesa; pisiTusi; fuimaonoSapoluEliota; leotaJohnny; mapusuaSeilala; pisiGeorge; lemiDavid
                                   tagicakibauSailosi; tuilagiAlesana; so'oialoJames; williamsPaul ] }

    let namibia = { Name = "Namibia"; Status = Eliminated; Seeding = None; Coach = "Johan Diergaardt" }

    let hornHugo = { Name = "Hugo Horn"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let o'CallaghanBertus = { Name = "Bertus O'Callaghan"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let duToitJane = { Name = "Jané du Toit"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let larsonRaoul = { Name = "Raoul Larson"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let redelinghuysJohnny = { Name = "Johnny Redelinghuys"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let visserMarius = { Name = "Marius Visser"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let esterhuyseNico = { Name = "Nico Esterhuyse"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let frankenHenk = { Name = "Henk Franken"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let kazombiazeUakazuwaka = { Name = "Uakazuwaka Kazombiaze"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let kollHeinz = { Name = "Heinz Koll"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let burgerJacques = { Name = "Jacques Burger"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let duPlessisTinus = { Name = "Tinus du Plessis"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let kitschoffRohan = { Name = "Rohan Kitshoff"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let vanNeelRenaud = { Name = "Renaud van Neel"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let nieuwenhiusJacques = { Name = "Jacques Nieuwenhuis"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let vanLillPieterJan = { Name = "Pieter-Jan van Lill"; Team = namibia; Type = Forward; Status = OriginalSquad }
    let delaHarpeRyan = { Name = "Ryan de la Harpe"; Team = namibia; Type = Back; Status = OriginalSquad }
    let jantjiesEugene = { Name = "Eugene Jantjies"; Team = namibia; Type = Back; Status = OriginalSquad }
    let kotzeTheuns = { Name = "Theuns Kotzé"; Team = namibia; Type = Back; Status = OriginalSquad }
    let losperTertius = { Name = "Tertius Losper"; Team = namibia; Type = Back; Status = OriginalSquad }
    let delaHarpeDarryl = { Name = "Darryl de la Harpe"; Team = namibia; Type = Back; Status = OriginalSquad }
    let philanderDavid = { Name = "David Philander"; Team = namibia; Type = Back; Status = OriginalSquad }
    let vanWykDanie = { Name = "Danie van Wyk"; Team = namibia; Type = Back; Status = OriginalSquad }
    let vanZylPiet = { Name = "Piet van Zyl"; Team = namibia; Type = Back; Status = OriginalSquad }
    let bockHeini = { Name = "Heini Bock"; Team = namibia; Type = Back; Status = OriginalSquad }
    let maraisConrad = { Name = "Conrad Marais"; Team = namibia; Type = Back; Status = OriginalSquad }
    let vanWykMcGrath = { Name = "McGrath van Wyk"; Team = namibia; Type = Back; Status = OriginalSquad }
    let winklerLlelwellyn = { Name = "Llelwellyn Winkler"; Team = namibia; Type = Back; Status = OriginalSquad }
    let bothaChrysander = { Name = "Chrysander Botha"; Team = namibia; Type = Back; Status = OriginalSquad }
    let damesDanie = { Name = "Danie Dames"; Team = namibia; Type = Back; Status = OriginalSquad }

    let namibiaSquad = { Team = namibia
                         Players = [ hornHugo; o'CallaghanBertus; duToitJane; larsonRaoul; redelinghuysJohnny; visserMarius
                                     esterhuyseNico; frankenHenk; kazombiazeUakazuwaka; kollHeinz; burgerJacques; duPlessisTinus
                                     kitschoffRohan; vanNeelRenaud; nieuwenhiusJacques; vanLillPieterJan; delaHarpeRyan
                                     jantjiesEugene; kotzeTheuns; losperTertius; delaHarpeDarryl; philanderDavid; vanWykDanie
                                     vanZylPiet; bockHeini; maraisConrad; vanWykMcGrath; winklerLlelwellyn; bothaChrysander
                                     damesDanie ] }

    let teams = [ newZealand; southAfrica; australia; argentina; wales; england; france; ireland; scotland; fiji; italy; tonga; canada
                  japan; georgia; romania; unitedStates; russia; samoa; namibia ]

    let coaches = teams |> List.map (fun team -> team.Coach, team)

    let squads = [ newZealandSquad; southAfricaSquad; australiaSquad; argentinaSquad; walesSquad; englandSquad; franceSquad; irelandSquad
                   scotlandSquad; fijiSquad; italySquad; tongaSquad; canadaSquad; japanSquad; georgiaSquad; romaniaSquad; unitedStatesSquad
                   russiaSquad; samoaSquad; namibiaSquad ]

    let players = squads |> List.collect (fun squad -> squad.Players |> List.map id)

    let groupA = Group ('A', [ newZealand; france; tonga; canada; japan ] )
    let groupB = Group ('B', [ argentina; england; scotland; georgia; romania ] )
    let groupC = Group ('C', [ australia; ireland; italy; unitedStates; russia ] )
    let groupD = Group ('D', [ southAfrica; wales; samoa; fiji; namibia ] )

    // Group A matches: https://en.wikipedia.org/wiki/2011_Rugby_World_Cup_Pool_A...

    let groupANewZealandVsTonga = { Team1Points = TeamPoints (newZealand, 41<point>); Team2Points = TeamPoints (tonga, 10<point>)
                                    Stage = groupA; KickOff = DateTime (2011, 9, 9)
                                    Events = [ ManOfTheMatch kahuiRichard
                                               Try (daggIsrael, Some 11<min>) (* newZealand *)
                                               Try (kahuiRichard, Some 20<min>)
                                               Try (daggIsrael, Some 29<min>)
                                               Try (kahuiRichard, Some 32<min>)
                                               Try (kainoJerome, Some 59<min>)
                                               Try (nonuMa'a, Some 77<min>)
                                               Conversion carterDan
                                               Conversion carterDan
                                               Conversion carterDan
                                               Conversion sladeColin
                                               MissedConversion carterDan
                                               MissedConversion carterDan
                                               Penalty carterDan
                                               Try (taumaloloSona, Some 72<min>) (* tonga *)
                                               Conversion morathKurt
                                               Penalty morathKurt
                                               MissedPenalty morathKurt ] }

    let groupAFranceVsJapan = { Team1Points = TeamPoints (france, 47<point>); Team2Points = TeamPoints (japan, 21<point>)
                                Stage = groupA; KickOff = DateTime (2011, 9, 10)
                                Events = [ ManOfTheMatch arlidgeJames
                                           Try (pierreJulien, Some 5<min>) (* france *)
                                           Try (trinhDucFrancois, Some 12<min>)
                                           Try (clercVincent, Some 34<min>)
                                           Try (nalletLionel, Some 71<min>)
                                           Try (papePascal, Some 77<min>)
                                           Try (parraMorgan, Some 80<min>)
                                           Conversion yachviliDimitri
                                           Conversion yachviliDimitri
                                           Conversion yachviliDimitri
                                           Conversion yachviliDimitri
                                           MissedConversion yachviliDimitri
                                           MissedConversion yachviliDimitri
                                           Penalty yachviliDimitri
                                           Penalty yachviliDimitri
                                           Penalty yachviliDimitri
                                           Try (arlidgeJames, Some 31<min>) (* japan *)
                                           Try (arlidgeJames, Some 49<min>)
                                           Conversion arlidgeJames
                                           MissedConversion arlidgeJames
                                           Penalty arlidgeJames
                                           Penalty arlidgeJames
                                           Penalty arlidgeJames ] }

    let groupATongaVsCanada = { Team1Points = TeamPoints (tonga, 20<point>); Team2Points = TeamPoints (canada, 25<point>)
                                Stage = groupA; KickOff = DateTime (2011, 9, 14)
                                Events = [ ManOfTheMatch kleebergerAdam
                                           Try (piutauSiale, Some 40<min>) (* tonga *)
                                           Try (piutauSiale, Some 53<min>)
                                           Conversion morathKurt
                                           Conversion morathKurt
                                           Penalty morathKurt
                                           Penalty morathKurt
                                           MissedPenalty morathKurt
                                           MissedPenalty morathKurt
                                           Try (sinclairJebb, Some 13<min>) (* canada *)
                                           Try (carpenterAaron, Some 67<min>)
                                           Try (mackenziePhil, Some 73<min>)
                                           Conversion pritchardJames
                                           Conversion pritchardJames
                                           MissedConversion pritchardJames
                                           Penalty pritchardJames
                                           Penalty pritchardJames ] }

    let groupANewZealandVsJapan = { Team1Points = TeamPoints (newZealand, 83<point>); Team2Points = TeamPoints (japan, 7<point>)
                                    Stage = groupA; KickOff = DateTime (2011, 9, 16)
                                    Events = [ ManOfTheMatch nonuMa'a
                                               Try (smithConrad, Some 4<min>) (* newZealand *)
                                               Try (kahuiRichard, Some 16<min>)
                                               Try (kainoJerome, Some 21<min>)
                                               Try (mealamuKevin, Some 30<min>)
                                               Try (ellisAndy, Some 34<min>)
                                               Try (sladeColin, Some 36<min>)
                                               Try (kahuiRichard, Some 45<min>)
                                               Try (williamsSonnyBill, Some 51<min>)
                                               Try (toeavaIsaia, Some 56<min>)
                                               Try (horeAndrew, Some 60<min>)
                                               Try (nonuMa'a, Some 62<min>)
                                               Try (thomsonAdam, Some 76<min>)
                                               Try (williamsSonnyBill, Some 79<min>)
                                               Conversion sladeColin
                                               Conversion sladeColin
                                               Conversion sladeColin
                                               Conversion sladeColin
                                               Conversion sladeColin
                                               Conversion sladeColin
                                               Conversion sladeColin
                                               Conversion sladeColin
                                               Conversion sladeColin
                                               MissedConversion sladeColin
                                               MissedConversion sladeColin
                                               MissedConversion sladeColin
                                               MissedConversion sladeColin
                                               Try (onozawaHirotoki, Some 58<min>) (* japan *)
                                               Conversion williamsMurray ] }

    let groupAFranceVsCanada = { Team1Points = TeamPoints (france, 46<point>); Team2Points = TeamPoints (canada, 19<point>)
                                 Stage = groupA; KickOff = DateTime (2011, 9, 18)
                                 Events = [ ManOfTheMatch picamolesLouis
                                            Try (clercVincent, Some 4<min>) (* france *)
                                            Try (trailleDamien, Some 64<min>)
                                            Try (clercVincent, Some 79<min>)
                                            Try (clercVincent, Some 80<min>)
                                            Conversion parraMorgan
                                            Conversion parraMorgan
                                            Conversion parraMorgan
                                            Conversion parraMorgan
                                            Penalty parraMorgan
                                            Penalty parraMorgan
                                            Penalty parraMorgan
                                            Penalty parraMorgan
                                            Penalty parraMorgan
                                            MissedPenalty parraMorgan
                                            DropGoal trinhDucFrancois
                                            Try (smithRyan, Some 7<min>) (* canada *)
                                            Conversion pritchardJames
                                            Penalty pritchardJames
                                            Penalty pritchardJames
                                            MissedPenalty pritchardJames
                                            MissedPenalty pritchardJames
                                            DropGoal monroAnder
                                            DropGoal monroAnder ] }

    let groupATongaVsJapan = { Team1Points = TeamPoints (tonga, 31<point>); Team2Points = TeamPoints (japan, 18<point>)
                               Stage = groupA; KickOff = DateTime (2011, 9, 21)
                               Events = [ ManOfTheMatch leitchMichael
                                          Try (ma'afuViliami, Some 7<min>) (* tonga *)
                                          Try (lokotuiTukulua, Some 14<min>)
                                          Try (vainikoloFetu'u, Some 54<min>)
                                          Conversion morathKurt
                                          Conversion morathKurt
                                          MissedConversion morathKurt
                                          Penalty morathKurt
                                          Penalty morathKurt
                                          Penalty morathKurt
                                          Penalty morathKurt
                                          YellowCard (aulikaHalani, Some 61<min>)
                                          YellowCard (lokotuiTukulua, Some 78<min>)
                                          Try (hatakeyamaKensuke, Some 13<min>) (* japan *)
                                          Try (leitchMichael, Some 25<min>)
                                          Try (tupuailaiAlisi, Some 63<min>)
                                          MissedConversion arlidgeJames
                                          MissedConversion arlidgeJames
                                          MissedConversion arlidgeJames
                                          Penalty webbShaun
                                          YellowCard (arlidgeJames, Some 30<min>) ] }

    let groupANewZealandVsFrance = { Team1Points = TeamPoints (newZealand, 37<point>); Team2Points = TeamPoints (france, 17<point>)
                                     Stage = groupA; KickOff = DateTime (2011, 9, 24)
                                     Events = [ ManOfTheMatch daggIsrael
                                                Try (thomsonAdam, Some 10<min>) (* newZealand *)
                                                Try (janeCory, Some 17<min>)
                                                Try (daggIsrael, Some 21<min>)
                                                Try (daggIsrael, Some 42<min>)
                                                Try (williamsSonnyBill, Some 77<min>)
                                                Conversion carterDan
                                                Conversion carterDan
                                                Conversion carterDan
                                                MissedConversion carterDan
                                                MissedConversion carterDan
                                                Penalty carterDan
                                                DropGoal carterDan
                                                Try (mermozMaxime, Some 54<min>) (* france *)
                                                Try (trinhDucFrancois, Some 76<min>)
                                                Conversion yachviliDimitri
                                                Conversion yachviliDimitri
                                                Penalty yachviliDimitri ] }

    let groupACanadaVsJapan = { Team1Points = TeamPoints (canada, 23<point>); Team2Points = TeamPoints (japan, 23<point>)
                                Stage = groupA; KickOff = DateTime (2011, 9, 27)
                                Events = [ ManOfTheMatch vatuveiSione
                                           Try (vanderMerweDTH, Some 7<min>) (* canada *)
                                           Try (mackenziePhil, Some 44<min>)
                                           Try (monroAnder, Some 75<min>)
                                           Conversion pritchardJames
                                           MissedConversion monroAnder
                                           MissedConversion monroAnder
                                           Penalty monroAnder
                                           Penalty monroAnder
                                           MissedPenalty monroAnder
                                           Try (horieShota, Some 10<min>) (* japan *)
                                           Try (endoKosuke, Some 40<min>)
                                           Conversion arlidgeJames
                                           Conversion arlidgeJames
                                           Penalty arlidgeJames
                                           Penalty arlidgeJames
                                           Penalty arlidgeJames ] }

    let groupAFranceVsTonga = { Team1Points = TeamPoints (france, 14<point>); Team2Points = TeamPoints (tonga, 19<point>)
                                Stage = groupA; KickOff = DateTime (2011, 10, 1)
                                Events = [ ManOfTheMatch kalamafoniSione
                                           Try (clercVincent, Some 80<min>) (* france *)
                                           MissedConversion yachviliDimitri
                                           Penalty yachviliDimitri
                                           Penalty yachviliDimitri
                                           Penalty yachviliDimitri
                                           YellowCard (estebanezFabrice, Some 65<min>)
                                           Try (hufangaSuka, Some 26<min>) (* tonga *)
                                           Conversion morathKurt
                                           Penalty morathKurt
                                           Penalty morathKurt
                                           Penalty morathKurt
                                           Penalty morathKurt
                                           MissedPenalty morathKurt
                                           MissedPenalty morathKurt
                                           MissedPenalty morathKurt
                                           MissedPenalty morathKurt
                                           YellowCard (hufangaSuka, Some 38<min>) ] }

    let groupANewZealandVsCanada = { Team1Points = TeamPoints (newZealand, 79<point>); Team2Points = TeamPoints (canada, 15<point>)
                                     Stage = groupA; KickOff = DateTime (2011, 10, 2)
                                     Events = [ ManOfTheMatch kainoJerome
                                                Try (guildfordZac, Some 7<min>) (* newZealand *)
                                                Try (vitoVictor, Some 11<min>)
                                                Try (daggIsrael, Some 20<min>)
                                                Try (guildfordZac, Some 25<min>)
                                                Try (muliainaMils, Some 29<min>)
                                                Try (guildfordZac, Some 35<min>)
                                                Try (cowanJimmy, Some 44<min>)
                                                Try (kainoJerome, Some 52<min>)
                                                Try (williamsSonnyBill, Some 60<min>)
                                                Try (kainoJerome, Some 68<min>)
                                                Try (guildfordZac, Some 77<min>)
                                                Try (vitoVictor, Some 80<min>)
                                                Conversion sladeColin
                                                Conversion sladeColin
                                                Conversion sladeColin
                                                Conversion sladeColin
                                                Conversion weepuPiri
                                                Conversion weepuPiri
                                                Conversion weepuPiri
                                                Conversion weepuPiri
                                                MissedConversion sladeColin
                                                MissedConversion sladeColin
                                                MissedConversion sladeColin
                                                MissedConversion sladeColin
                                                Penalty sladeColin
                                                Try (trainorConor, Some 40<min>) (* canada *)
                                                Try (trainorConor, Some 42<min>)
                                                Conversion monroAnder
                                                MissedConversion monroAnder
                                                Penalty monroAnder ] }

    let groupAMatches = [ groupANewZealandVsTonga; groupAFranceVsJapan; groupATongaVsCanada; groupANewZealandVsJapan; groupAFranceVsCanada
                          groupATongaVsJapan; groupANewZealandVsFrance; groupACanadaVsJapan; groupAFranceVsTonga; groupANewZealandVsCanada ]

    // Group B matches: https://en.wikipedia.org/wiki/2011_Rugby_World_Cup_Pool_B...

    let groupBScotlandVsRomania = { Team1Points = TeamPoints (scotland, 34<point>); Team2Points = TeamPoints (romania, 24<point>)
                                    Stage = groupB; KickOff = DateTime (2011, 9, 10)
                                    Events = [ ManOfTheMatch tincuMarius
                                               Try (blairMike, Some 8<min>) (* scotland *)
                                               Try (ansbroJoe, Some 21<min>)
                                               Try (danielliSimon, Some 75<min>)
                                               Try (danielliSimon, Some 78<min>)
                                               Conversion patersonChris
                                               MissedConversion patersonChris
                                               MissedConversion patersonChris
                                               MissedConversion patersonChris
                                               Penalty patersonChris
                                               Penalty patersonChris
                                               Penalty patersonChris
                                               Penalty patersonChris
                                               MissedPenalty patersonChris
                                               Try (lazarMihaita, Some 40<min>) (* romania *)
                                               Try (carpoDaneil, Some 67<min>)
                                               Conversion dimofteIonut
                                               MissedConversion dimofteIonut
                                               Penalty dumbravaDanut
                                               Penalty dumbravaDanut
                                               MissedPenalty dumbravaDanut
                                               MissedPenalty dumbravaDanut
                                               Penalty dimofteIonut
                                               Penalty dimofteIonut ] }

    let groupBArgentinaVsEngland = { Team1Points = TeamPoints (argentina, 9<point>); Team2Points = TeamPoints (england, 13<point>)
                                     Stage = groupB; KickOff = DateTime (2011, 9, 10)
                                     Events = [ ManOfTheMatch lobbeJuanMartinFernandez
                                                Penalty contepomiFelipe (* argentina *)                                               
                                                Penalty rodriguezMartin
                                                Penalty rodriguezMartin
                                                MissedPenalty contepomiFelipe
                                                MissedPenalty rodriguezMartin
                                                MissedPenalty rodriguezMartin
                                                MissedPenalty rodriguezMartin
                                                MissedPenalty rodriguezMartin
                                                MissedPenalty rodriguezMartin
                                                Try (youngsBen, Some 67<min>) (* england *)
                                                Conversion wilkinsonJonny
                                                Penalty wilkinsonJonny
                                                Penalty wilkinsonJonny
                                                MissedPenalty wilkinsonJonny
                                                MissedPenalty wilkinsonJonny
                                                MissedPenalty wilkinsonJonny
                                                MissedPenalty wilkinsonJonny
                                                MissedPenalty wilkinsonJonny
                                                YellowCard (coleDan, Some 35<min>) ] }

    let groupBScotlandVsGeorgia = { Team1Points = TeamPoints (scotland, 15<point>); Team2Points = TeamPoints (georgia, 6<point>)
                                    Stage = groupB; KickOff = DateTime (2011, 9, 14)
                                    Events = [ ManOfTheMatch brownKelly
                                               Penalty parksDan (* scotland *)
                                               Penalty parksDan
                                               Penalty parksDan
                                               Penalty parksDan
                                               MissedPenalty parksDan
                                               MissedPenalty parksDan
                                               MissedPenalty parksDan
                                               DropGoal parksDan
                                               Penalty kvirikashviliMerab(* georgia *)
                                               Penalty kvirikashviliMerab ] }

    let groupBArgentinaVsRomania = { Team1Points = TeamPoints (argentina, 43<point>); Team2Points = TeamPoints (romania, 8<point>)
                                     Stage = groupB; KickOff = DateTime (2011, 9, 17)
                                     Events = [ ManOfTheMatch amorosinoLucasGonzalez
                                                Try (fernandezSantiago, Some 5<min>) (* argentina *)
                                                Try (leguizamonJuanManuel, Some 9<min>)
                                                Try (figalloJuan, Some 20<min>)
                                                Try (amorosinoLucasGonzalez, Some 30<min>)
                                                Try (imhoffJuan, Some 64<min>)
                                                Try (fessiaGenaro, Some 72<min>)
                                                Conversion rodriguezMartin
                                                Conversion rodriguezMartin
                                                Conversion rodriguezMartin
                                                Conversion rodriguezMartin
                                                Conversion rodriguezMartin
                                                MissedConversion rodriguezMartin
                                                Penalty rodriguezMartin
                                                MissedPenalty rodriguezMartin
                                                MissedPenalty rodriguezMartin
                                                Try (cazanIonel, Some 32<min>) (* romania *)
                                                MissedConversion dimofteIonut
                                                Penalty dimofteIonut
                                                MissedPenalty dimofteIonut
                                                YellowCard (lazarMihaita, Some 54<min>) ] }

    let groupBEnglandVsGeorgia = { Team1Points = TeamPoints (england, 41<point>); Team2Points = TeamPoints (georgia, 10<point>)
                                   Stage = groupB; KickOff = DateTime (2011, 9, 18)
                                   Events = [ ManOfTheMatch gorgodzeMamuka
                                              Try (hapeShontayne, Some 4<min>) (* england *)
                                              Try (hapeShontayne, Some 21<min>)
                                              Try (armitageDelon, Some 47<min>)
                                              Try (tuilagiManu, Some 62<min>)
                                              Try (ashtonChris, Some 65<min>)
                                              Try (ashtonChris, Some 80<min>)
                                              Conversion floodToby
                                              Conversion floodToby
                                              Conversion floodToby
                                              Conversion floodToby
                                              MissedConversion floodToby
                                              MissedConversion floodToby
                                              Penalty floodToby
                                              YellowCard (hartleyDylan, Some 39<min>)
                                              Try (basilaiaDimitri, Some 40<min>) (* georgia *)
                                              Conversion kvirikashviliMerab
                                              Penalty kvirikashviliMerab
                                              MissedPenalty kvirikashviliMerab
                                              MissedPenalty kvirikashviliMerab
                                              MissedPenalty kvirikashviliMerab
                                              MissedPenalty kvirikashviliMerab
                                              MissedPenalty kvirikashviliMerab ] }

    let groupBEnglandVsRomania = { Team1Points = TeamPoints (england, 67<point>); Team2Points = TeamPoints (romania, 3<point>)
                                   Stage = groupB; KickOff = DateTime (2011, 9, 24)
                                   Events = [ ManOfTheMatch cuetoMark
                                              Try (cuetoMark, Some 15<min>) (* england *)
                                              Try (cuetoMark, Some 22<min>)
                                              Try (cuetoMark, Some 26<min>)
                                              Try (ashtonChris, Some 32<min>)
                                              Try (ashtonChris, Some 35<min>)
                                              Try (youngsBen, Some 41<min>)
                                              Try (fodenBen, Some 49<min>)
                                              Try (tuilagiManu, Some 61<min>)
                                              Try (croftTom, Some 67<min>)
                                              Try (ashtonChris, Some 70<min>)
                                              Conversion wilkinsonJonny
                                              Conversion wilkinsonJonny
                                              Conversion wilkinsonJonny
                                              Conversion floodToby
                                              Conversion floodToby
                                              Conversion floodToby
                                              Conversion floodToby
                                              MissedConversion wilkinsonJonny
                                              MissedConversion wilkinsonJonny
                                              MissedConversion floodToby
                                              Penalty wilkinsonJonny
                                              Penalty dumbravaDanut (* romania *)
                                              MissedPenalty dumbravaDanut
                                              MissedPenalty dumbravaDanut
                                              MissedPenalty dumbravaDanut
                                              MissedPenalty dumbravaDanut ] }

    let groupBArgentinaVsScotland = { Team1Points = TeamPoints (argentina, 13<point>); Team2Points = TeamPoints (scotland, 12<point>)
                                      Stage = groupB; KickOff = DateTime (2011, 9, 25)
                                      Events = [ ManOfTheMatch jacksonRuaridh
                                                 Try (amorosinoLucasGonzalez, Some 73<min>) (* argentina *)
                                                 Conversion contepomiFelipe
                                                 Penalty contepomiFelipe
                                                 Penalty contepomiFelipe
                                                 MissedPenalty contepomiFelipe
                                                 MissedPenalty contepomiFelipe
                                                 MissedPenalty contepomiFelipe
                                                 Penalty patersonChris (* scotland *)
                                                 Penalty jacksonRuaridh
                                                 MissedPenalty patersonChris
                                                 DropGoal jacksonRuaridh
                                                 DropGoal parksDan ] }

    let groupBGeorgiaVsRomania = { Team1Points = TeamPoints (georgia, 25<point>); Team2Points = TeamPoints (romania, 9<point>)
                                   Stage = groupB; KickOff = DateTime (2011, 9, 29)
                                   Events = [ ManOfTheMatch gorgodzeMamuka
                                              Try (gorgodzeMamuka, Some 56<min>) (* georgia *)
                                              Conversion kvirikashviliMerab
                                              Penalty kvirikashviliMerab
                                              Penalty kvirikashviliMerab
                                              Penalty kvirikashviliMerab
                                              Penalty kvirikashviliMerab
                                              Penalty kvirikashviliMerab
                                              Penalty urjukashviliMalkhaz
                                              MissedPenalty kvirikashviliMerab
                                              MissedPenalty kvirikashviliMerab
                                              Penalty dumbravaDanut (* romania *)
                                              Penalty dumbravaDanut
                                              Penalty vlaicuFlorin
                                              MissedPenalty dumbravaDanut
                                              MissedPenalty dumbravaDanut ] }

    let groupBEnglandVsScotland = { Team1Points = TeamPoints (england, 16<point>); Team2Points = TeamPoints (scotland, 12<point>)
                                    Stage = groupB; KickOff = DateTime (2011, 10, 1)
                                    Events = [ ManOfTheMatch parksDan
                                               Try (ashtonChris, Some 78<min>) (* england *)
                                               Conversion floodToby
                                               Penalty wilkinsonJonny
                                               Penalty wilkinsonJonny
                                               MissedPenalty wilkinsonJonny
                                               MissedPenalty wilkinsonJonny
                                               MissedPenalty wilkinsonJonny
                                               DropGoal wilkinsonJonny
                                               Penalty patersonChris (* scotland *)
                                               Penalty patersonChris
                                               Penalty parksDan
                                               DropGoal parksDan ] }

    let groupBArgentinaVsGeorgia = { Team1Points = TeamPoints (argentina, 25<point>); Team2Points = TeamPoints (georgia, 7<point>)
                                     Stage = groupB; KickOff = DateTime (2011, 10, 2)
                                     Events = [ ManOfTheMatch leguizamonJuanManuel
                                                Try (imhoffJuan, Some 32<min>) (* argentina *)
                                                Try (contepomiFelipe, Some 68<min>)
                                                Try (gosioAgustin, Some 79<min>)
                                                Conversion contepomiFelipe
                                                Conversion boschMarcelo
                                                MissedConversion contepomiFelipe
                                                Penalty contepomiFelipe
                                                Penalty contepomiFelipe
                                                MissedPenalty contepomiFelipe
                                                MissedPenalty contepomiFelipe
                                                Try (khmaladzeLasha, Some 39<min>) (* georgia *)
                                                Conversion urjukashviliMalkhaz ] }

    let groupBMatches = [ groupBScotlandVsRomania; groupBArgentinaVsEngland; groupBScotlandVsGeorgia; groupBArgentinaVsRomania; groupBEnglandVsGeorgia
                          groupBEnglandVsRomania; groupBArgentinaVsScotland; groupBGeorgiaVsRomania; groupBEnglandVsScotland; groupBArgentinaVsGeorgia ]

    // Group C matches: https://en.wikipedia.org/wiki/2011_Rugby_World_Cup_Pool_C...

    let groupCAustraliaVsItaly = { Team1Points = TeamPoints (australia, 32<point>); Team2Points = TeamPoints (italy, 6<point>)
                                   Stage = groupB; KickOff = DateTime (2011, 9, 11)
                                   Events = [ ManOfTheMatch horwillJames
                                              Try (alexanderBen, Some 50<min>) (* australia *)
                                              Try (ashleyCooperAdam, Some 55<min>)
                                              Try (o'ConnorJames, Some 58<min>)
                                              Try (ioaneDigby, Some 66<min>)
                                              Conversion o'ConnorJames
                                              Conversion o'ConnorJames
                                              Conversion o'ConnorJames
                                              MissedConversion o'ConnorJames
                                              Penalty cooperQuade
                                              Penalty cooperQuade
                                              MissedPenalty cooperQuade
                                              Penalty bergamascoMirco (* italy *)
                                              Penalty bergamascoMirco
                                              MissedPenalty bergamascoMirco ] }

    let groupCIrelandVsUnitedStates = { Team1Points = TeamPoints (ireland, 22<point>); Team2Points = TeamPoints (unitedStates, 10<point>)
                                        Stage = groupB; KickOff = DateTime (2011, 9, 11)
                                        Events = [ ManOfTheMatch o'ConnellPaul
                                                   Try (boweTommy, Some 40<min>) (* ireland *)
                                                   Try (bestRory, Some 56<min>)
                                                   Try (boweTommy, Some 60<min>)
                                                   Conversion sextonJonathan
                                                   Conversion o'GaraRonan
                                                   MissedConversion o'GaraRonan
                                                   Penalty sextonJonathan
                                                   MissedPenalty sextonJonathan
                                                   MissedPenalty sextonJonathan
                                                   MissedPenalty sextonJonathan
                                                   MissedPenalty sextonJonathan
                                                   Try (emerickPaul, Some 80<min>) (* unitedStates *)
                                                   Conversion malifaValenese
                                                   Penalty patersonJames
                                                   MissedPenalty patersonJames ] }

    let groupCRussiaVsUnitedStates = { Team1Points = TeamPoints (russia, 6<point>); Team2Points = TeamPoints (unitedStates, 13<point>)
                                       Stage = groupB; KickOff = DateTime (2011, 9, 15)
                                       Events = [ ManOfTheMatch macDonaldMike
                                                  Penalty kushnarevYuri (* russia *)
                                                  Penalty rachkovKonstantin
                                                  MissedPenalty kushnarevYuri
                                                  MissedPenalty kushnarevYuri
                                                  MissedPenalty kushnarevYuri
                                                  Try (petriMike, Some 19<min>) (* unitedStates *)
                                                  Conversion wylesChris
                                                  Penalty wylesChris
                                                  Penalty wylesChris
                                                  MissedPenalty wylesChris
                                                  MissedPenalty wylesChris
                                                  MissedPenalty wylesChris ] }

    let groupCAustraliaVsIreland = { Team1Points = TeamPoints (australia, 6<point>); Team2Points = TeamPoints (ireland, 15<point>)
                                     Stage = groupB; KickOff = DateTime (2011, 9, 17)
                                     Events = [ ManOfTheMatch healyCian
                                                Penalty o'ConnorJames (* australia *)
                                                Penalty o'ConnorJames
                                                MissedPenalty o'ConnorJames
                                                MissedPenalty o'ConnorJames
                                                Penalty sextonJonathan (* ireland *)
                                                Penalty sextonJonathan
                                                Penalty o'GaraRonan
                                                Penalty o'GaraRonan
                                                MissedPenalty sextonJonathan
                                                MissedPenalty sextonJonathan
                                                MissedPenalty sextonJonathan
                                                DropGoal sextonJonathan ] }

    let groupCItalyVsRussia = { Team1Points = TeamPoints (italy, 53<point>); Team2Points = TeamPoints (russia, 17<point>)
                                Stage = groupB; KickOff = DateTime (2011, 9, 20)
                                Events = [ ManOfTheMatch gresevVictor
                                           Try (parisseSergio, Some 6<min>) (* italy *)
                                           Try (toniolattiGiulio, Some 13<min>)
                                           Try (benvenutiTommaso, Some 16<min>)
                                           Try (toniolattiGiulio, Some 23<min>)
                                           PenaltyTry (italy, Some 29<min>)
                                           Try (goriEdoardo, Some 37<min>)
                                           Try (benvenutiTommaso, Some 48<min>)
                                           Try (mcLeanLuke, Some 64<min>)
                                           Try (zanniAlessandro, Some 77<min>)
                                           Conversion bocchinoRiccardo
                                           Conversion bocchinoRiccardo
                                           Conversion bocchinoRiccardo
                                           Conversion bocchinoRiccardo
                                           MissedConversion bocchinoRiccardo
                                           MissedConversion bocchinoRiccardo
                                           MissedConversion bocchinoRiccardo
                                           MissedConversion bocchinoRiccardo
                                           MissedConversion bocchinoRiccardo
                                           YellowCard (ongaroFabio, Some 33<min>)
                                           Try (yanyushkinAlexander, Some 34<min>) (* russia *)
                                           Try (ostroushkoVladimir, Some 50<min>)
                                           Try (makovetskiyAlexey, Some 71<min>)
                                           Conversion rachkovKonstantin
                                           MissedConversion rachkovKonstantin
                                           MissedConversion rachkovKonstantin ] }

    let groupCAustraliaVsUnitedStates = { Team1Points = TeamPoints (australia, 67<point>); Team2Points = TeamPoints (unitedStates, 5<point>)
                                          Stage = groupB; KickOff = DateTime (2011, 9, 23)
                                          Events = [ ManOfTheMatch ashleyCooperAdam
                                                     Try (horneRob, Some 8<min>) (* australia *)
                                                     Try (elsomRocky, Some 11<min>)
                                                     Try (bealeKurtley, Some 31<min>)
                                                     Try (fainga'aAnthony, Some 35<min>)
                                                     Try (mitchellDrew, Some 45<min>)
                                                     Try (mcCabePat, Some 48<min>)
                                                     Try (ashleyCooperAdam, Some 59<min>)
                                                     Try (ashleyCooperAdam, Some 64<min>)
                                                     Try (ashleyCooperAdam, Some 66<min>)
                                                     Try (fainga'aAnthony, Some 71<min>)
                                                     Try (samoRadike, Some 78<min>)
                                                     Conversion cooperQuade
                                                     Conversion cooperQuade
                                                     Conversion barnesBerrick
                                                     Conversion barnesBerrick
                                                     Conversion barnesBerrick
                                                     Conversion barnesBerrick
                                                     MissedConversion cooperQuade
                                                     MissedConversion cooperQuade
                                                     MissedConversion cooperQuade
                                                     MissedConversion barnesBerrick
                                                     MissedConversion barnesBerrick
                                                     Try (gagianoJJ, Some 23<min>) (* unitedStates *)
                                                     MissedConversion malifaValenese
                                                     YellowCard (scullyBlaine, Some 75<min>) ] }

    let groupCIrelandVsRussia = { Team1Points = TeamPoints (ireland, 62<point>); Team2Points = TeamPoints (russia, 12<point>)
                                  Stage = groupB; KickOff = DateTime (2011, 9, 25)
                                  Events = [ ManOfTheMatch o'GaraRonan
                                             Try (mcFaddenFergus, Some 10<min>) (* ireland *)
                                             Try (o'BrienSean, Some 13<min>)
                                             Try (bossIsaac, Some 38<min>)
                                             Try (earlsKeith, Some 38<min>)
                                             Try (trimbleAndrew, Some 40<min>)
                                             Try (earlsKeith, Some 48<min>)
                                             Try (kearneyRob, Some 65<min>)
                                             Try (jenningsShane, Some 73<min>)
                                             Try (buckleyTony, Some 79<min>)
                                             Conversion o'GaraRonan
                                             Conversion o'GaraRonan
                                             Conversion o'GaraRonan
                                             Conversion o'GaraRonan
                                             Conversion o'GaraRonan
                                             Conversion o'GaraRonan
                                             Conversion sextonJonathan
                                             MissedConversion o'GaraRonan
                                             MissedConversion sextonJonathan
                                             Penalty o'GaraRonan
                                             Try (artemievVasily, Some 50<min>) (* russia *)
                                             Try (simplikevichDenis, Some 59<min>)
                                             Conversion rachkovKonstantin
                                             MissedConversion rachkovKonstantin
                                             YellowCard (rachkovKonstantin, Some 8<min>) ] }

    let groupCItalyVsUnitedStates = { Team1Points = TeamPoints (italy, 27<point>); Team2Points = TeamPoints (unitedStates, 10<point>)
                                      Stage = groupB; KickOff = DateTime (2011, 9, 27)
                                      Events = [ ManOfTheMatch castrogiovanniMartin
                                                 Try (parisseSergio, Some 3<min>) (* italy *)
                                                 Try (orqueraLuciano, Some 30<min>)
                                                 Try (castrogiovanniMartin, Some 40<min>)
                                                 PenaltyTry (italy, Some 66<min>)
                                                 Conversion bergamascoMirco
                                                 Conversion bergamascoMirco
                                                 MissedConversion bergamascoMirco
                                                 MissedConversion bergamascoMirco
                                                 Penalty bergamascoMirco
                                                 Try (wylesChris, Some 18<min>) (* unitedStates *)
                                                 Conversion wylesChris
                                                 Penalty wylesChris
                                                 YellowCard (stanfillLouis, Some 59<min>) ] }

    let groupCAustraliaVsRussia = { Team1Points = TeamPoints (australia, 68<point>); Team2Points = TeamPoints (russia, 22<point>)
                                    Stage = groupB; KickOff = DateTime (2011, 10, 1)
                                    Events = [ ManOfTheMatch gresevVictor
                                               Try (barnesBerrick, Some 7<min>) (* australia *)
                                               Try (mitchellDrew, Some 9<min>)
                                               Try (mcCalmanBen, Some 12<min>)
                                               Try (pocockDavid, Some 15<min>)
                                               Try (pocockDavid, Some 22<min>)
                                               Try (mooreStephen, Some 36<min>)
                                               Try (ashleyCooperAdam, Some 39<min>)
                                               Try (ma'afuSalesi, Some 42<min>)
                                               Try (mitchellDrew, Some 49<min>)
                                               Try (barnesBerrick, Some 79<min>)
                                               Conversion o'ConnorJames
                                               Conversion o'ConnorJames
                                               Conversion o'ConnorJames
                                               Conversion o'ConnorJames
                                               Conversion o'ConnorJames
                                               Conversion o'ConnorJames
                                               Conversion o'ConnorJames
                                               Conversion o'ConnorJames
                                               Conversion o'ConnorJames
                                               MissedConversion o'ConnorJames
                                               Try (ostroushkoVladimir, Some 33<min>) (* russia *)
                                               Try (simplikevichDenis, Some 60<min>)
                                               Try (rachkovKonstantin, Some 68<min>)
                                               Conversion rachkovKonstantin
                                               Conversion rachkovKonstantin
                                               MissedConversion rachkovKonstantin
                                               Penalty rachkovKonstantin ] }

    let groupCIrelandVsItaly = { Team1Points = TeamPoints (ireland, 36<point>); Team2Points = TeamPoints (italy, 6<point>)
                                 Stage = groupB; KickOff = DateTime (2011, 10, 2)
                                 Events = [ ManOfTheMatch o'BrienSean
                                            Try (o'DriscollBrian, Some 47<min>) (* ireland *)
                                            Try (earlsKeith, Some 52<min>)
                                            Try (earlsKeith, Some 80<min>)
                                            Conversion o'GaraRonan
                                            Conversion o'GaraRonan
                                            Conversion sextonJonathan
                                            Penalty o'GaraRonan
                                            Penalty o'GaraRonan
                                            Penalty o'GaraRonan
                                            Penalty o'GaraRonan
                                            Penalty sextonJonathan
                                            MissedPenalty o'GaraRonan
                                            Penalty bergamascoMirco (* italy *)
                                            Penalty bergamascoMirco
                                            MissedPenalty bergamascoMirco ] }

    let groupCMatches = [ groupCAustraliaVsItaly; groupCIrelandVsUnitedStates; groupCRussiaVsUnitedStates; groupCAustraliaVsIreland; groupCItalyVsRussia
                          groupCAustraliaVsUnitedStates; groupCIrelandVsRussia; groupCItalyVsUnitedStates; groupCAustraliaVsRussia; groupCIrelandVsItaly ]

    // Group D matches: https://en.wikipedia.org/wiki/2011_Rugby_World_Cup_Pool_D...

    let groupDFijiVsNamibia = { Team1Points = TeamPoints (fiji, 49<point>); Team2Points = TeamPoints (namibia, 25<point>)
                                Stage = groupB; KickOff = DateTime (2011, 9, 10)
                                Events = [ ManOfTheMatch gonevaVereniki
                                           Try (gonevaVereniki, Some 6<min>) (* fiji *)
                                           Try (nakarawaLeone, Some 18<min>)
                                           Try (gonevaVereniki, Some 20<min>)
                                           Try (gonevaVereniki, Some 40<min>)
                                           Try (gonevaVereniki, Some 51<min>)
                                           Try (nalagaNapolioni, Some 77<min>)
                                           Conversion baiSeremaia
                                           Conversion baiSeremaia
                                           Conversion baiSeremaia
                                           Conversion baiSeremaia
                                           Conversion baiSeremaia
                                           MissedConversion baiSeremaia
                                           Penalty baiSeremaia
                                           Penalty baiSeremaia
                                           Penalty baiSeremaia
                                           Try (kollHeinz, Some 43<min>) (* namibia *)
                                           Try (bothaChrysander, Some 45<min>)
                                           MissedConversion kotzeTheuns
                                           MissedConversion kotzeTheuns
                                           Penalty kotzeTheuns
                                           Penalty kotzeTheuns
                                           MissedPenalty kotzeTheuns
                                           DropGoal kotzeTheuns
                                           DropGoal kotzeTheuns
                                           DropGoal kotzeTheuns ] }

    let groupDSouthAfricaVsWales = { Team1Points = TeamPoints (southAfrica, 17<point>); Team2Points = TeamPoints (wales, 16<point>)
                                     Stage = groupB; KickOff = DateTime (2011, 9, 11)
                                     Events = [ ManOfTheMatch warburtonSam
                                                Try (steynFrancois, Some 3<min>) (* southAfrica *)
                                                Try (hougaardFrancois, Some 65<min>)
                                                Conversion steynMorne
                                                Conversion steynMorne
                                                Penalty steynMorne
                                                Try (faletauTaulupe, Some 54<min>) (* wales *)
                                                Conversion hookJames
                                                Penalty hookJames
                                                Penalty hookJames
                                                Penalty hookJames
                                                MissedPenalty hookJames
                                                MissedPenalty hookJames ] }

    let groupDSamoaVsNamibia = { Team1Points = TeamPoints (samoa, 49<point>); Team2Points = TeamPoints (namibia, 12<point>)
                                 Stage = groupB; KickOff = DateTime (2011, 9, 14)
                                 Events = [ ManOfTheMatch stowersGeorge
                                            Try (fotuali'iKahn, Some 1<min>) (* samoa *)
                                            Try (tuilagiAlesana, Some 17<min>)
                                            Try (tuilagiAlesana, Some 35<min>)
                                            Try (tuilagiAlesana, Some 55<min>)
                                            Try (williamsPaul, Some 59<min>)
                                            PenaltyTry (samoa, Some 70<min>)
                                            Conversion pisiTusi
                                            Conversion pisiTusi
                                            Conversion williamsPaul
                                            Conversion williamsPaul
                                            Conversion williamsPaul
                                            MissedConversion williamsPaul
                                            Penalty pisiTusi
                                            Penalty pisiTusi
                                            Penalty williamsPaul
                                            YellowCard (williamsPaul, Some 40<min>)
                                            Try (vanWykDanie, Some 63<min>) (* namibia *)
                                            Try (kotzeTheuns, Some 79<min>)
                                            Conversion kotzeTheuns
                                            MissedConversion kotzeTheuns
                                            YellowCard (kitschoffRohan, Some 66<min>) ] }

    let groupDSouthAfricaVsFiji = { Team1Points = TeamPoints (southAfrica, 49<point>); Team2Points = TeamPoints (fiji, 3<point>)
                                    Stage = groupB; KickOff = DateTime (2011, 9, 17)
                                    Events = [ ManOfTheMatch rossouwDanie
                                               Try (steenkampGurthro, Some 26<min>) (* southAfrica *)
                                               Try (fourieJaque, Some 34<min>)
                                               Try (steynFrancois, Some 49<min>)
                                               Try (steynMorne, Some 61<min>)
                                               Try (mtawariraTendai, Some 70<min>)
                                               Try (rossouwDanie, Some 75<min>)
                                               Conversion steynMorne
                                               Conversion steynMorne
                                               Conversion steynMorne
                                               Conversion steynMorne
                                               Conversion steynMorne
                                               MissedConversion steynMorne
                                               Penalty steynMorne
                                               Penalty steynMorne
                                               Penalty steynFrancois
                                               MissedPenalty steynMorne
                                               MissedPenalty steynMorne
                                               Penalty baiSeremaia (* fiji *) ] }

    let groupDWalesVsSamoa = { Team1Points = TeamPoints (wales, 17<point>); Team2Points = TeamPoints (samoa, 10<point>)
                               Stage = groupB; KickOff = DateTime (2011, 9, 18)
                               Events = [ ManOfTheMatch jonesAlunWyn
                                          Try (williamsShane, Some 67<min>) (* wales *)
                                          MissedConversion priestlandRhys
                                          Penalty hookJames
                                          Penalty hookJames
                                          Penalty priestlandRhys
                                          Penalty priestlandRhys
                                          MissedPenalty hookJames
                                          Try (perenisiAnthony, Some 40<min>) (* samoa *)
                                          Conversion williamsPaul
                                          Penalty williamsPaul
                                          MissedPenalty williamsPaul
                                          MissedPenalty williamsPaul ] }

    let groupDSouthAfricaVsNamibia = { Team1Points = TeamPoints (southAfrica, 87<point>); Team2Points = TeamPoints (namibia, 0<point>)
                                       Stage = groupB; KickOff = DateTime (2011, 9, 22)
                                       Events = [ ManOfTheMatch albertsWillem
                                                  Try (aplonGio, Some 7<min>) (* southAfrica *)
                                                  Try (habanaBryan, Some 22<min>)
                                                  PenaltyTry (southAfrica, Some 30<min>)
                                                  Try (fourieJaque, Some 38<min>)
                                                  Try (steynFrancois, Some 49<min>)
                                                  Try (steynMorne, Some 61<min>)
                                                  Try (deJonghJuan, Some 63<min>)
                                                  Try (aplonGio, Some 65<min>)
                                                  Try (hougaardFrancois, Some 68<min>)
                                                  Try (deJonghJuan, Some 71<min>)
                                                  Try (rossouwDanie, Some 78<min>)
                                                  Try (hougaardFrancois, Some 80<min>)
                                                  Conversion steynMorne
                                                  Conversion steynMorne
                                                  Conversion steynMorne
                                                  Conversion steynMorne
                                                  Conversion steynMorne
                                                  Conversion steynMorne
                                                  Conversion pienaarRuan
                                                  Conversion pienaarRuan
                                                  Conversion pienaarRuan
                                                  Conversion pienaarRuan
                                                  Conversion pienaarRuan
                                                  Conversion pienaarRuan
                                                  Penalty steynMorne
                                                  (* namibia *) ] }

    let groupDFijiVsSamoa = { Team1Points = TeamPoints (fiji, 7<point>); Team2Points = TeamPoints (samoa, 27<point>)
                              Stage = groupB; KickOff = DateTime (2011, 9, 25)
                              Events = [ ManOfTheMatch williamsPaul
                                         Try (taleiNetani, Some 67<min>) (* fiji *)
                                         Conversion luveniyaliWaisea
                                         Try (fotuali'iKahn, Some 62<min>) (* samoa *)
                                         Try (stowersGeorge, Some 70<min>)
                                         Conversion williamsPaul
                                         MissedConversion pisiTusi
                                         Penalty pisiTusi
                                         Penalty pisiTusi
                                         Penalty pisiTusi
                                         Penalty pisiTusi
                                         MissedPenalty pisiTusi
                                         MissedPenalty pisiTusi
                                         DropGoal pisiTusi ] }

    let groupDWalesVsNamibia = { Team1Points = TeamPoints (wales, 81<point>); Team2Points = TeamPoints (namibia, 7<point>)
                                 Stage = groupB; KickOff = DateTime (2011, 9, 26)
                                 Events = [ ManOfTheMatch duPlessisTinus
                                            Try (williamsScott, Some 8<min>) (* wales *)
                                            Try (brewAled, Some 14<min>)
                                            Try (faletauTaulupe, Some 18<min>)
                                            Try (williamsScott, Some 47<min>)
                                            Try (jenkinsGethin, Some 50<min>)
                                            Try (northGeorge, Some 61<min>)
                                            Try (daviesJonathan, Some 62<min>)
                                            Try (northGeorge, Some 66<min>)
                                            Try (williamsScott, Some 70<min>)
                                            Try (williamsLloyd, Some 75<min>)
                                            Try (byrneLee, Some 77<min>)
                                            Try (jonesAlunWyn, Some 80<min>)
                                            Conversion jonesStephen
                                            Conversion jonesStephen
                                            Conversion jonesStephen
                                            Conversion jonesStephen
                                            Conversion jonesStephen
                                            Conversion jonesStephen
                                            Conversion priestlandRhys
                                            Conversion priestlandRhys
                                            Conversion priestlandRhys
                                            MissedConversion jonesStephen
                                            MissedConversion priestlandRhys
                                            MissedConversion priestlandRhys
                                            Penalty jonesStephen
                                            Try (kollHeinz, Some 53<min>) (* namibia *)
                                            Conversion kotzeTheuns
                                            YellowCard (larsonRaoul, Some 59<min>) ] }

    let groupDSouthAfricaVsSamoa = { Team1Points = TeamPoints (southAfrica, 13<point>); Team2Points = TeamPoints (samoa, 5<point>)
                                     Stage = groupB; KickOff = DateTime (2011, 9, 30)
                                     Events = [ ManOfTheMatch burgerSchalk
                                                Try (habanaBryan, Some 9<min>) (* southAfrica *)
                                                Conversion steynMorne
                                                Penalty steynFrancois
                                                Penalty steynMorne
                                                MissedPenalty steynFrancois
                                                MissedPenalty steynFrancois
                                                MissedPenalty steynMorne
                                                YellowCard (smitJohn, Some 71<min>)
                                                Try (stowersGeorge, Some 51<min>) (* samoa *)
                                                MissedConversion pisiTusi
                                                RedCard (williamsPaul, Some 70<min>) ] }

    let groupDWalesVsFiji = { Team1Points = TeamPoints (wales, 66<point>); Team2Points = TeamPoints (fiji, 0<point>)
                              Stage = groupB; KickOff = DateTime (2011, 10, 2)
                              Events = [ ManOfTheMatch northGeorge
                                         Try (robertsJamie, Some 6<min>) (* wales *)
                                         Try (williamsScott, Some 17<min>)
                                         Try (northGeorge, Some 32<min>)
                                         Try (warburtonSam, Some 39<min>)
                                         Try (robertsJamie, Some 51<min>)
                                         Try (burnsLloyd, Some 59<min>)
                                         Try (halfpennyLeigh, Some 68<min>)
                                         Try (williamsLloyd, Some 73<min>)
                                         Try (daviesJonathan, Some 80<min>)
                                         Conversion priestlandRhys
                                         Conversion priestlandRhys
                                         Conversion priestlandRhys
                                         Conversion priestlandRhys
                                         Conversion priestlandRhys
                                         Conversion jonesStephen
                                         Conversion jonesStephen
                                         Conversion jonesStephen
                                         Conversion jonesStephen
                                         Penalty priestlandRhys
                                         (* fiji *) ] }

    let groupDMatches = [ groupDFijiVsNamibia; groupDSouthAfricaVsWales; groupDSamoaVsNamibia; groupDSouthAfricaVsFiji; groupDWalesVsSamoa
                          groupDSouthAfricaVsNamibia; groupDFijiVsSamoa; groupDWalesVsNamibia; groupDSouthAfricaVsSamoa; groupDWalesVsFiji ]

    // Knockout matches: https://en.wikipedia.org/wiki/2011_Rugby_World_Cup_knockout_stage...

    let quarterFinal1IrelandVsWales = { Team1Points = TeamPoints (ireland, 10<point>); Team2Points = TeamPoints (wales, 22<point>)
                                        Stage = QuarterFinal 1; KickOff = DateTime (2011, 10, 8)
                                        Events = [ ManOfTheMatch phillipsMike
                                                   Try (earlsKeith, Some 45<min>) (* ireland *)
                                                   Conversion o'GaraRonan
                                                   Penalty o'GaraRonan
                                                   Try (williamsShane, Some 3<min>) (* wales *)
                                                   Try (phillipsMike, Some 51<min>)
                                                   Try (daviesJonathan, Some 64<min>)
                                                   Conversion priestlandRhys
                                                   Conversion priestlandRhys
                                                   MissedConversion priestlandRhys
                                                   Penalty halfpennyLeigh ] }

    let quarterFinal2EnglandVsFrance = { Team1Points = TeamPoints (england, 12<point>); Team2Points = TeamPoints (france, 19<point>)
                                         Stage = QuarterFinal 2; KickOff = DateTime (2011, 10, 8)
                                         Events = [ ManOfTheMatch harinordoquyImanol
                                                    Try (fodenBen, Some 55<min>) (* england *)
                                                    Try (cuetoMark, Some 77<min>)
                                                    Conversion wilkinsonJonny
                                                    MissedConversion floodToby
                                                    Try (clercVincent, Some 22<min>) (* france *)
                                                    Try (medardMaxime, Some 31<min>)
                                                    MissedConversion yachviliDimitri
                                                    MissedConversion yachviliDimitri
                                                    Penalty yachviliDimitri
                                                    Penalty yachviliDimitri
                                                    MissedPenalty yachviliDimitri
                                                    DropGoal trinhDucFrancois ] }

    let quarterFinal3SouthAfricaVsAustralia = { Team1Points = TeamPoints (southAfrica, 9<point>); Team2Points = TeamPoints (australia, 11<point>)
                                                Stage = QuarterFinal 3; KickOff = DateTime (2011, 10, 9)
                                                Events = [ ManOfTheMatch pocockDavid
                                                           Penalty steynMorne (* southAfrica *)
                                                           Penalty steynMorne
                                                           MissedPenalty steynMorne
                                                           MissedPenalty steynMorne
                                                           DropGoal steynMorne
                                                           Try (horwillJames, Some 11<min>) (* australia *)
                                                           MissedConversion o'ConnorJames
                                                           Penalty o'ConnorJames
                                                           Penalty o'ConnorJames ] }

    let quarterFinal4NewZealandVsArgentina = { Team1Points = TeamPoints (newZealand, 33<point>); Team2Points = TeamPoints (argentina, 10<point>)
                                               Stage = QuarterFinal 4; KickOff = DateTime (2011, 10, 9)
                                               Events = [ ManOfTheMatch weepuPiri
                                                          Try (readKieran, Some 69<min>) (* newZealand *)
                                                          Try (thornBrad, Some 79<min>)
                                                          Conversion crudenAaron
                                                          MissedConversion weepuPiri
                                                          Penalty weepuPiri
                                                          Penalty weepuPiri
                                                          Penalty weepuPiri
                                                          Penalty weepuPiri
                                                          Penalty weepuPiri
                                                          Penalty weepuPiri
                                                          Penalty weepuPiri
                                                          Try (cabelloJulioFarias, Some 32<min>) (* argentina *)
                                                          Conversion contepomiFelipe
                                                          Penalty boschMarcelo
                                                          YellowCard (vergalloNicolas, Some 58<min>) ] }

    let semiFinal1WalesVsFrance = { Team1Points = TeamPoints (wales, 8<point>); Team2Points = TeamPoints (france, 9<point>)
                                    Stage = SemiFinal 1; KickOff = DateTime (2011, 10, 15)
                                    Events = [ ManOfTheMatch bonnaireJulien
                                               Try (phillipsMike, Some 58<min>) (* wales *)
                                               MissedConversion jonesStephen
                                               Penalty hookJames
                                               MissedPenalty hookJames
                                               MissedPenalty hookJames
                                               RedCard (warburtonSam, Some 19<min>)
                                               Penalty parraMorgan (* france *)
                                               Penalty parraMorgan
                                               Penalty parraMorgan ] }

    let semiFinal2AustraliaVsNewZealand = { Team1Points = TeamPoints (australia, 6<point>); Team2Points = TeamPoints (newZealand, 20<point>)
                                            Stage = SemiFinal 2; KickOff = DateTime (2011, 10, 16)
                                            Events = [ ManOfTheMatch janeCory
                                                       Penalty o'ConnorJames (* australia *)
                                                       DropGoal cooperQuade
                                                       Try (nonuMa'a, Some 6<min>) (* newZealand *)
                                                       MissedConversion weepuPiri
                                                       Penalty weepuPiri
                                                       Penalty weepuPiri
                                                       Penalty weepuPiri
                                                       Penalty weepuPiri
                                                       MissedPenalty weepuPiri
                                                       MissedPenalty weepuPiri
                                                       MissedPenalty weepuPiri
                                                       DropGoal crudenAaron
                                                       YellowCard (williamsSonnyBill, Some 76<min>) ] }

    let bronzeFinalWalesVsAustralia = { Team1Points = TeamPoints (wales, 18<point>); Team2Points = TeamPoints (australia, 21<point>)
                                        Stage = BronzeFinal; KickOff = DateTime (2011, 10, 21)
                                        Events = [ ManOfTheMatch barnesBerrick
                                                   Try (williamsShane, Some 50<min>) (* wales *)
                                                   Try (halfpennyLeigh, Some 80<min>)
                                                   Conversion jonesStephen
                                                   MissedConversion hookJames
                                                   Penalty hookJames
                                                   Penalty jonesStephen
                                                   MissedPenalty hookJames
                                                   Try (barnesBerrick, Some 12<min>) (* australia *)
                                                   Try (mcCalmanBen, Some 76<min>)
                                                   Conversion o'ConnorJames
                                                   MissedConversion o'ConnorJames
                                                   Penalty o'ConnorJames
                                                   Penalty o'ConnorJames
                                                   MissedPenalty o'ConnorJames
                                                   MissedPenalty o'ConnorJames
                                                   DropGoal barnesBerrick ] }

    let finalFranceVsNewZealand = { Team1Points = TeamPoints (france, 7<point>); Team2Points = TeamPoints (newZealand, 8<point>)
                                    Stage = Final; KickOff = DateTime (2011, 10, 23)
                                    Events = [ ManOfTheMatch dusautoirThierry
                                               Try (dusautoirThierry, Some 47<min>) (* france *)
                                               Conversion trinhDucFrancois
                                               Try (woodcockTony, Some 15<min>) (* newZealand *)
                                               MissedConversion weepuPiri
                                               Penalty donaldStephen ] }

    let knockoutMatches = [ quarterFinal1IrelandVsWales; quarterFinal2EnglandVsFrance; quarterFinal3SouthAfricaVsAustralia; quarterFinal4NewZealandVsArgentina
                            semiFinal1WalesVsFrance; semiFinal2AustraliaVsNewZealand; bronzeFinalWalesVsAustralia; finalFranceVsNewZealand ]

    let matches = groupAMatches @ groupBMatches @ groupCMatches @ groupDMatches @ knockoutMatches

