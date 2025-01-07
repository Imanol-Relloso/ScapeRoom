// See https://aka.ms/new-console-template for more information
using System.Drawing;
//Introducir las reglas del juego.
ConsoleKey continuar;
do
{
    Console.WriteLine("IMPORTANTE LEER ANTES DE EMPEZAR");
    Console.WriteLine("Esto es un scape room en donde tendrás que superar ciertas pruebas para conseguir los dígitos de la clave de la puerta cerrada con un candado. \r\n");
    Console.WriteLine("Para superar estás pruebas, puedes pedir un total de 3 pistas en cada prueba.\nLa primera pista no tendrá penalización, pero las siguientes dos sí.\r\n");
    Console.WriteLine("Las soluciones  van a ser únicamente de responder con numeros o una palabra máximo. \n");
    Console.WriteLine("Algunas pruebas te dan objetos que vas a tener que utilizar más adelante. \nEstos objetos se utilizan escribiendo el nombre del objeto en las demás pruebas.\r\n");
    Console.WriteLine("Para una mejor experiencia, recomendamos poner la consola en pantalla completa y ajustar el zoom.");
    Console.WriteLine("Si tienes mala memoria recomendamos apuntar los numeros y objetos que consigas durante la partida. \n");


    //ClearScrean despues de dejar al usuario darle a siguiente y poner la pantalla inicial del scaperoom
    Console.WriteLine("Pulsa 'Enter' para comenzar.");

    continuar = Console.ReadKey().Key;
   
} while (continuar != ConsoleKey.Enter);

// stopwatch
var watch = System.Diagnostics.Stopwatch.StartNew();

ConsoleKey volver;

//Inicializar los objetos y las pistas.
int llave = 0;
int cerillas = 0;
int llaveAvion = 0;
int USB = 0;
int bombilla = 0;
int pista1 = 0;
int pista2 = 0;
int pista3 = 0;
int pista4 = 0;
int pista5 = 0;
int pista6 = 0;
int pista7 = 0;
int pista8 = 0;
int pista9 = 0;
int pista0 = 0;
var done = false;

//Bucle del scaperoom
do
{
    //Descripción
    Console.Clear();
    Console.Write("\u001bc\x1b[3J");
    Console.WriteLine("Estas en un despacho donde te llaman la atención unos cuantos objetos. ¿A cuál decides ir? \n1 - Cajón con cerradura \n2 - Cuadro  \n3 - Globo terráqueo \n4 - Mesa \n5 - Estanteria \n6 - Chimenea \n7 - Caja fuerte \n8 - Ordenador  \n9 - Lampara  \n10 - Salida");
    //Escenario
    Console.WriteLine("...',;;,;cc:cllllloooooooooooooollccc;,'........',,:llcodddxkkkkkkkkkkkkkkkkkkkxddddlcll:,'''..........'..',,''''''................                   \r\n.....',:::ccoddxxxxxxxkkkkkkkkkkkkxxxdc:;.......',,:odlokkkOOOOOOOOO00OOOO000OOOOkkdlodl:,,'.........',;;::ccc:::::::;;;;;;,,'''..........    .....   \r\n........,;;::codddxxxxxxkkkkOOkkkkkkkxxlc:'....''',;cddlxkkOOO0O0000000000000OOOkkxoldo:,,'.........',;:ccccccccc:::;;;;;,,,''......  ............    \r\n'.........',;;::codddxxxkkOKXXK0Okkkkkxxoc:,'''',,,,;lxookOOOO000000000000000OOkkkdlodc,''.........,;:ccclloxOOkdlc:;;;,,,,'......  ........''..   ..'\r\n.............',;;::lodddxxOKNNNKOkkkkkkxxoc:;''',,,'';odldkkO0000000000OOOOOOOOkxxlldl;,'........',;:cccclo0NWWXklc:;;,,,'.....  .......'','..  .'cdk0\r\n................',,;;clooddxxkkkxxxxxxxxxxdc:;',,,,,'.:dolxkOO0000OOOOOOOOOOkkkxxocll;'''.......',;:cccc:cldkOkdl:;;,,'......  .......''...  ..'ckKX0x\r\n.........'..........',;:ccllooooddddddddddool:;,,,,,,.':oloxxkOOOOOOOOkkkkkkxxddo:cl;''........',,:::::::::::::;;,,,'.....   ..........   ....,;::;'. \r\n.................. ....'',,;;;::::ccccccccccc:;;,',,,'.':ccllloooooooolllllllc:c:;:;'..........''',,,,,,,,,,,,'''......    ........     ........     .\r\n  ................     ........'''''''''''','',''..'''...,,,,,,,,,,'''''''''''.......................................    .......     ......        ...\r\n     ..............      ...............''''..............................................   ........                   ...       .......        .    \r\n         .......         ........''''',;cddo:,''..........',,,,,,,,'''''''''''''...............',;,'....                       ....     .       .,....\r\n             .....       ........''''',;cxkxl;''.......';;:cclllloollccclllllllcc:,,'.''......':odl;'......                ....         .       ..... \r\n      ......  ..          ............'',;:c:;,'....''.':clllloddxxxdoodooodddocc:;,'',,'.....',,,........                   .      ......            \r\n..   ...':c'  ..      .    ..............';;;;,'...',,';clooooddxxkxddxddooddolccc::;,,;'......''.........                   .      ......  .''.......\r\n,.   . ...'.....      .     ...   .................',;';ldddddxxkkkkxkkkxdoooolllc:c:,,;,....           .                  ....     .   ..  .::,..',..\r\n,.   ..,:;,........   .    .',...,,...,ll,........'',;',cdddddxkkxxoldxxdoooooollc;,,,,;,........       ....               ....        ...   ,l;'..',.\r\n..   .,;cdd:,...      .    ..'.,,.....,::,........'',;'';clllcloodo::ddoooooolc:;'.''',,,.........     ......   .            ..     ......  ..,'....  \r\n... .....,:;,'..       ........  ...     .,:,.....'',,',:cc:cc:c:;,';c:clcc::::;'..,;',,'....  ..  .......     ..           ... ...':'..'. .',,','    \r\nc:. .'.     ......    ..';''',,..',.  ...,cd:.....'',,';:,,''',,,,,',,''''....'....;:,,,'....  .'...'...''..  .. .   .    ...........   ,' .:oo:l,    \r\nlc. .;.  'c,....'........',:;:oxc;,. .....';,.......',',,..................       .,;','..... .''''''...','..... .  ..       ..       .':, .cdolo, .,.\r\n::' .;. .l0o...';,...... ;OXXXNNKO0x,.'.    .........'''...........................''.'........     ..  ..   .      ...      ..      .:ol, .colcc;.,;,\r\n;;. .;...';,...';c,......xWMMMMMWNWNx:;. ....'... . ......',,,,,........',,,,,,,,'........ .'ll:;c:..'. .. .....    .....'..''.      ;dl:, .:c'.      \r\noc. .,.       .. ..  ...lXMMMMMMWNWWKc............   .''''..'''........',,,'''.''..''..    ..''.,,...'. ..  ...     .........'....  .:l::' .:xc...... \r\noc. .,.       ..     .'oKWWMWWWMWXNWNk'  ......'......',,,'',,..........',,;,''''''''....  ..        .  ..     ........     ........;odoc' .:x:.co,.. \r\nl:. .,.....   ..    .cOXXNNNNNNNNK0KKKO:.......'..''..'',,,,,..... .........',,''''''..'''.....,'.. 'dl...';:,.,ccc,....   ........;:'..,' .cxc'cl,...\r\n.'. .'...     .'....;OXKKK0KKXXKK00000XXd::::,''.........................................,;;;;;;,'. .:;..................  ....    :l::.'' .;,..,,'...\r\n ,. .''',.... .';;,..','.,,;lxkd:';;';ll::cc:;,'. ......................................;c:::cccclc,.   ..         ......  ....    :lcc.'. .;.  :o.   \r\n.,. .'..'''c;...'''.  .  ...';;'......;,';c:::,'. .....................................:olllccccloll;.  ..   ..  .....     ....  ..:lcc''. .;.  l0x,  \r\n;;. ......'c;...      ..;,. .;l,...............................   ........  ..........,loccc::;;clll:.  ..   ..    ....'.    ..  .......,. .:::lkOx;  \r\n.   ..'...... ......  ..do.  ;l;.......,,...'.... ....                               ..colll:;,,;:::,.  .........  ...:d:......        .,. .',,,;:;'.'\r\n.    ..       .....    .;d, .;c,......':;.,:c,... .',.                                ..;cool:,',;,'.   ......',,,....;dc'',,..  ......,;.   .'.'.'.''\r\n.    ......   .....     .....:c'.......'....';coooxOOxol:,.                           ....',,,'....... ............  ..:;.';,..  .,;'.,;;.   .:cc:c::c\r\n.    .......          ..  . .;,.............,::loddxkkkkxxo.                          ...  ............... ..           .........'::'',,,.   .:c:::::c\r\n'........       .    .....  .......''..'''..,;,..''':lc:col,..                      .......... .....''.........   ......     ..',;;;,,,',..  .::;::;:c\r\n''......     .....   ........,;,...;;,,;'..........,:cc::c;...                      ..''....      ...',,.........................',,''''''',',;;;::;::\r\n........  . ......   ....   'cc;'..,;,,'.'',,,'....',,'.......                      ...................,,,'.....  ......  ......''''''.....','',,,,,,,\r\n...  .......... .           .....;cl,........,'.'''...........                     ..,'..................',,'....              ...','.......'',,,,,,,,\r\n...   .........              ':coo:'.......................''.                     .';;....................';;'.               ...',,..... ..''''''',,\r\n...   .....  .          ..   .:ll:,;;;;;;;;,'',,,,;;;;;;;;,...............................'',,,'',,,,''.....',,'.              ...',,..... ..''',''...\r\n...   .......     ............  ........................................................................................       ....''..... ..'''',,'..\r\n.... .....    ................     ..          ...... ...................................... ...         ..     ...........    ..'','..... ..''''','..\r\n......    .....'',,,,,''''',;,.    ..     ...  ... ..   ...............................................  ..     .'''''.........  ..'''......'''''''...\r\n....  ....''''',,,,,,,,,,,,;;'.      ........................................................................   .'''''''..................',,;,,'',,'.\r\n.   ........'''',,,,,,,;,,;:c'             ........                                    ...................     .odc;,,''''................'',;;;;;,,,.\r\n........'''',,,,,,,,;;;;;:lxkc.                                                        ....  ...........       ;0X0kl;'........'''''''.......',,,,;;;,\r\n.....''',,,;;;;;;;;;;::coxOOkl.          .........                                     .... ..............     :0XXXXOd:,.......................'',,,,\r\n'''''',,,,;;;;;:::::cldxkkkOko,.      ............                                    ....................  . .l00KXXXXKkl;,''',,,,,,,,,,',,'''...'''.\r\n''''',,;;;::::cccclodxkOkdoddoc.      ............   ..                               ....................  . .xX00KKXXXKKOdc;,,,,,,,,,,,,,,,,,,,'''..\r\n..''',;;;::ccccclodkOOOOxol:;;'.      .............  ..                               .... ...............    'x0KXXXXKKKKKKOdc;,,,,,,,,,,,,,;;,,,,,,'\r\n...',,;;:cccllloxkOOOKXK00Okkxo' .   ..............  ..                               ....................   .;kkO0KKKXXXXX00OOdl:,'''''''',,,,,,''',,\r\n''',,,;;::clodxkOOOkO0OO00KXK0k:.    ..............  ..                               .... ..............    .ckkkk0KK0OO000OO0Okxl:'......'''''''''''\r\n''',,,,;;:loxxkOxddxxdxkxk0K0xxl.     .............   .                 .             .... ..............    .okkkkkkOOkxxxxkkxkOOOko;......''''''',''\r\n");
    var input = Console.ReadLine();

    int.TryParse(input, out var wants);

    switch (wants)
    {
        //Elige ir hacia el cajón con cerradura
        case 1:
            
            do
            {
                //Presentación de la prueba
                Console.Clear();
                Console.Write("\u001bc\x1b[3J");
                Console.WriteLine("Te acercas al cajón que parece que requiere una llave para abrirlo.");
                //Escenario
                Console.WriteLine("\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWMMMMMMMMMMMM\r\nMMMMMMMMMMMNxloooooooooooodddddddddddddddxxxxxxxxxxxxxxxxxxxxxxxxxxxxxkkkxxxxxxxxxxxxxxONMMMMMMMMMMM\r\nMMMMMMMMMMMKc,,,,,;;;;;;;;;;::::::::::cccccccccccccclllllllllllllllllllllllllllllllccccdXMMMMMMMMMMM\r\nMMMMMMMMMMMKl,,,,;;;;;;;;;;::::::::::ccccccccccccllllllllllllllllllooooooolllllllllccccdXMMMMMMMMMMM\r\nMMMMMMMMMMMXl,,;;;;;;;;;;:::::::::ccccccccllllllllllllllllllooooooooooooooooooolllllllcdXMMMMMMMMMMM\r\nMMMMMMMMMMMKc',,,,,,,,,;;;;;;;;;;::::::::::cccccccccccccccccclllllllllllllllllcccccccc:dXMMMMMMMMMMM\r\nMMMMMMMMMMMNxll;.....'''''''''''''',,,,,,,,,,,,,,,,,;;;;;;;;;;;;;;;;;;;;;;;;;;;;;,'':odONMMMMMMMMMMM\r\nMMMMMMMMMMMMMMNl...................'''''''''''''''',,,,,,,,,,,,,,,,,,,,,,,,,,,'''...lNMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo...''''''',,,,,,,,,;;;;;;;;;:::::::::::::::::ccccccccccc:::::::::,..oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..',,;;;;;;;:::::::cccccccclllllllllllllooooooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..',,;;;;;;;;::::::cccccccclllccccclllllooooooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..,,,;;;;;;;;:::::::cccccc:;,,,''',,,,;;:cloooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..',,;;;;;;;;:::::::cccc:,'.............';coooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..',,;;;;;;;;:::::::ccccc;,,'''''''''',;:cloooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..',,;;;;;;;;:::::::cccccccccc::::ccccllooooooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..',,;;;;;;;:::::::ccccccccllllllllllllloooooooooooooooooooolllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..''',',,,,,,,,,,,,,,;;;;;;;;;;;;;;;;;;::::::::::::::::::::;;;;;;,..oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..''''''''''',,,,,,,,,,,,,,,,,,,,;;;;,;;;;;;;;;;;;;;;;;;;;;;;;,,,'..oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..',,;;;;;;;:::::::cccccccclllllllllllllloooooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..,,,;;;;;;;;:::::::ccccccccllllllllllllloooooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..,,,;;;;;;;;:::::::ccccccccllllllllllllllooooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..,,,;;;;;;;;:::::::ccccccccc:::::::::ccloooooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..',,;;;;;;;;:::::::ccccc:;,''........'',;loooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..,,,;;;;;;;;:::::::cccc:,..............';coooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..,,,;;;;;;;;:::::::ccccc::;,,,,,,,,,;;:clooooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..,,,;;;;;;;;:::::::ccccccccllccclllllllllloooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..',,;;;;;;;;:::::::ccccccclllllllllllllllooooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..',,,;;;;;;;;:::::::ccccccccccllllllllllllllooooooooooollllllllc;'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..''''''''''''''''''',,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,'..oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..',,,,,,,,,,;;;;;;;;;;:::::::::::::::::ccccccccccccccccccc::::::,..oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..',,;;;;;;;:::::::cccccccclllllllllllllloooooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..,,,;;;;;;;;:::::::ccccccccllllllllllloooooooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..,,,;;;;;;;;:::::::ccccccc:;;;,,,,;;;;:clooooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..,,,;;;;;;;;:::::::cccc:;'..............,coooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..,,,;;;;;;;;:::::::cccc:,''..........'',:loooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..,,,;;;;;;;;::::::cccccccc::;;;;;;;::ccloooooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..,,,;;;;;;;;::::::cccccccccllllllllllllloooooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..,,,;;;;;;;;::::::cccccccccllllllllllllloooooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..,,,;;;;;;;;::::::cccccccclllllllllllllloooooooooooooooooollllll:'.oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo..',,,,,,,,,,,;;;;;;;;;;;::::::::::::::::::ccccccccccccccc:::::::,..oWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWo....................................................................oNMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWOooc'..'cooooooooooooooooooooooooooooooooooooooooooooooooooooo:...,loOWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMO,..;0MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMx...lNMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMM0,..;KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMx'..lNMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMNkc...'cONMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXx;...,o0WMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMNo'......'dNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMKc.......,OWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMN0OOOOOOOO0WMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXOOOOOOOOOXWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\n");
                //Recoger lo que dice el usuario
                string objeto = Console.ReadLine();
                string objetoCajon = objeto.ToLower();
                
                //si pasa la prueba
                if (llave == 1 && objetoCajon == "llave")
                {
                    Console.WriteLine("Has logrado abrir el cajón. \nParece que hay un papel. En él pone un 6.");
                }
                //si pide pista
                else if (objetoCajon == "pista" && pista1 == 0)
                {
                    Console.WriteLine("Pista 1: Se requiere una llave.");
                    pista1 = 1;
                }else if (objetoCajon == "pista" && pista1 == 1)
                {
                    Console.WriteLine("Pista 2: Parece que hace frío en la habitación. La chimenea está sin encender.");
                    pista1 = 2;
                }else if (objetoCajon == "pista" && pista1 == 2)
                {
                    Console.WriteLine("Pista 3: Enciende la chimenea, parece que ahí está la llave para abrir el cajón. Y luego vuelve aquí y escribe “abrir”.");
                }
                //Si no pasa la prueba
                else
                {
                    Console.WriteLine("Intentas abrirlo a la fuerza pero parece imposible.");
                }
                //Volver a la habitación o no
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
                
            } while (volver != ConsoleKey.Enter);
            break;
        //Cuadro
        case 2:
            do
            {
                //Descripción
                Console.Clear();
                Console.Write("\u001bc\x1b[3J");
                Console.WriteLine("Te mueves al cuadro que hay al fondo de la habitación. Parece un cuadro algo viejo.");
                //Escenario
                Console.WriteLine("\n'''',,,,''.   ..',,''..''...'....''..''''''''...............',,,,'.......'''',;:lddxxxxxdodddoc;'..........,;',;,;:ccclodxk00XXKKXXNNXXK0OO000KXKK000O\r\n,''''',,''.. .':coddoolll,.......''....'''.............','.',;;,,'''.'',,,'''''',:coooooolc:c:,'''............',,,;:cclloxOOKXXKXXXXXK0OO0KXXXNNXXKK0O\r\n..'''.''','. .:xxxOOOOkkxc'.....'','...''',,,,,,;;;,,'',;;;;:::::;;;,,',,,''''...,::;;;c:;',;,......'''.''.'...,,,:;;:loox0OKXXXNNXK0OOOKXNNXXNNXXKKK0\r\n'''''..'','  'dOO0K0O00Oko:'....'''...',,,,;:::;::;;;::cloolodollll:,;;;::c::,',,,,,,,'',,''''...',,,,'.',;,''.',;::;:ccok00KXXNNXK000O0XNNNXXNNNX00XK\r\n,,''''''','. ,xOO0KOO0OOOx:'''.'''..'',,,;;:;,;:lodkO000OkkkO0KKK0ko::ollodddoooc::;,,''',.''''.'':clc:ccoo:;;,';:;:::cldOKKXNXNNX0000O0KNNNNNNNXXXKKK\r\n',''''''',.  ,okOO000000Od;.'..';,',,,;;;;;;:cokO0000kkxodxkkkO00K0d:::ccldxxxxdddxxl:'..''.''';;:oxxdddddxdoc;;::;;;:cloOKXXXXNNXK0OOOO0KXNNXXXXKK0OK\r\n,,''''''''. .'::lxxdxkkdc;,'..',:;,;:;;:c:;;cok000Oxollllloddddooool:::cc::c:clllx00koc;,'...'':ldk00OkkOkxxddo:;;;;;;ldxO0KKKXXXNXK0OOOkO0KKXXKK0kk0X\r\n',''''.'''.  .'',,,,,,;,'.'',,,:c:;:l::c::::clxkOOdc;;:cclloolccccllodol::clc::ccdOxdddoc;'...':ok00KKXNNX0Oxol:,,,,;;:coddkKOOKXNNXK0OkkOOOOOOOOkxOKK\r\n'','''.....  .',,,;;,,;::::cc;;clclolcc::ododxOOOxc;,;;::::::;,,;:clclk0xl;;::;::coxkdoxxl,'..,:okK0KXXNNXK00xol:;;;;;;clccdOO00XXXXXXKOOkkkOkkkOkO00k\r\n....''''.''. .;cc:lllloddolcclodkxool:cccoxOOkdoc;,,',,;;;;;;,,,,;:lc,cxxxocc:;,,;;lkklldo:,,',,;dOkkkOKK000Oxol:;;;,;,'cdc:lloOKKKXNXNXXKKKKXXKKKKKOk\r\n:;;;,,;;;::;. 'cllooolclooloxkkkkdlllccldkko:,''....,,,,,;::cc:;:::;:;,:dxxkxolcc::,,llldo:;;,,;,:oxdxxxkOOkdlll::c::,'';lolllloOKKXXXXKXNNNNNXXKKK00O\r\nxddoddxdoocc' .'cdxkkxoldddxkkdolc:clldxdl,......,;::;:ll:;;::llc:c:,,;;:ooclxdcodoc,'';oo:;;,,;;;clcloooolllccc::cl:,''';clc::oOKKKKXKKKXXKK00Okkkkdl\r\nodddllloolol'.  'oxolloddoodxoc:cooodxo:'.....';:llcccoxxoldolc:cllll:;c;;lc:lo;;lddc:,';;;,;:,,;,,;;::c:;;:clll:::;;;,',,:lc:cdkOOOkxkO00KOxxxxxoloc:\r\nloooccldxddc.   .:occoxdlcodl:::lkkkOkxl,'...,:llooclllcodlloolc:lllodc::;cllldd:oOxclc,;c,';:;,;,',;;,,;;;:::c:::;;;;;:;,;:ll::ccclc:::loxdccccc:;;;;\r\nlddxocllol,.     ,ooodoc:oxlcc:cdkKXXKOx:...;:cdocoddollod0kldolllccokocl:;cldkxdxxkOkdc:c'.'::;,,'',;;,;;;;,;:::;,'',;::cc;,;;;;;;;;:cl:::cc:;;,'',;;\r\ncodko;lol;.   .  'lddoodkOkl;,,cxkOK0Okd:,',:::llloollloclkkkxccl::lcolclccoddxodxxkOxxl,;'..::;,,''',;;;;;;;:::::;,''',;;;:;,',;;;:::cc:,,,;,'.',,,',\r\noodxl.:do;.  ..  'dkxxxxdc,..,',lxxkxddc,',;:c:clloocccc:::odddcc:coc;:dooxxxdxdoxxxkxdc;c:,;::;;;;,,;;;;,,;;;;;;;;,,,,,;;,;;;,;:::;;:;,,,;;;,,,,;;;,,\r\ndddxc.,oo;.  ....,ooc;,,:,.....',:ccl:;''',:ldodollccl::cc,:lcll::::codocldddkkdxxodolc:ccl::::::cccc:;:;,,,,,,,;,,,;;,,,:;;;;;;;;;,;;;,,;,;:;,''''.',\r\nxxdko..;l,.     .,:,'.',,..  ...','..''',,cocdOkxolcllc::c;.,lc::;:;;coolllooldkdlcc;';:coo::lodddddoooolccc:;;:;;,';:::::;;,;;;;,,;;;;;;;;,,,,'..',;c\r\nddodl. .'..    ...',,,;;'......','...'''';:oodkkkxlodoolll:'.;c;,,:lc;;lllllcldxlcdoccllccccok0KOxxkOOOOOxdlc:cc:;;,,,,,:c::;;:::;,;:::;;;;;;,,;cloxOK\r\nllcc:.   .     ....'.'','.''......',''.',;;cdxdxkxocdxolodoc,.';;'',;:cllllllcc:;;:;;:::clooxxk0xclllodldxkOdllcc:,'',,,;;;:c:::;,,,;::cclodolldO0KKXX\r\n::::'.      ..    ...''..','''....''''',;:::cxdlxxdl:oocoxdoo:,;:,...';;;;,',,,;;,;::clloolc:;coc;;cc:::;;lxxxl::l:,,,;;,;:;;:;;,;coddxkO0KXXKKKKK0O0K\r\nlodo:..        ..  ......',,,,''',,,,,,;;;::coxdlddkdcllodddxdllol;;,''.',,,,,,;;:cclolccll:;;;;;,,:c:,'',coxxl::::;,,,;,,;;:;:ldkOOOOOO00KXXXKXXXKKKK\r\n0OOOkl..            .'...,;::;,;;;:looddxdooloool:ldxdolooodolcc::cccclolc;;;;;:;;::::;;;:cc::cccc:cc:cc;;looddl::,,,,;,,,;;cokK00K000KK0KXXKXKXXNNNKO\r\nXXX0Kk,..           .;;'';:;;::ldooO0kxO00K0Oxdddl::cccloodoollcllolccloddocccc:;;:;;,;;;;::odkkxoc:::cooldxc:do;,,''',,;;:cxKK00KXXXKO0KKXKKXXXXXK0kd\r\nXXXK0O:..           .''..,;;:cokO0KKKXXXKKXX00KK0dc::::,,;lllddlc:cclooolc;,,;;;,;:cl:;',:clxkkdddc;:ccldxkdl:ld:;,..',;lxxOX0kk0KKO00O0KXXXXXX0Okkxxk\r\nKKXK0x;..     ........',,;;;;lkO00XXXNNNNNNNXXXXXxcc;;;,..,,;lol:;,,,;::;''',;;:::c:c:,',:lldkxolc::c:cllooclool:,'..,cxOkOKKKOkOkdkOkkOO0OOOOkddkOOOk\r\nkkOkd;..      .  .  ..',,::ccoO00XNNNWNNNNNNNWNNNKkc,''','',:lolc:,''''.'',,;;;;,.',,,;,',:ccoodxocclloocccclccc,...'l0KOOKKXK0OxxOOxxddxxdxkkdddddl:,\r\n:;;c,.       ..     ..,;;;:cldOXXNNNNNNNKKNWNNNX0kkd:,''''..';:lol:;:;,,,,,,;:;,..',,;::,,,:ccllodxxxxoooolccc:,.';lxO0OO0KKKKKO00xdxo;;codo:,;;..    \r\n,,,,.   .           ..,;,,;:cod0XNNXXNNXXXNNNNNXOxddl;,,;:::,,,,,;;,;:;;;,,,,''''.',,,,;,;:clllc:::cclcccc::c:,;cdk00KX0kxOKXK0kxoool::;;:c:,. .      \r\n,,,'.              ...''.'.';cdOKNNNXXXNNNXXNWNN0xdoc;:ccldo;,;:;;;;:cc:;,,,''';:;:c:,,;::lodxxxxxxolllloollldxkOOO00OOOxkOOOOkl:lcclloc,..,,.        \r\n,,,,.    ..        ...,',,'';:cx0KNNNNNWWNXXNNNX0xdol;:::col;,,;;;;:llc:,,,'',:lddkkdddooodkO0KXXNWNXX00000OxOKKOkkOOOOOOkooddlcdxoll:..              \r\n,,,.      . .      . .,;,'.';;,lO0KXNXXNNNXXKK0Okdc::::::cloooodxddxOxl:,,::lxOOO0000000kodxk0K0KKK0OkkkxxOkxkOOkddkxdxxd:;cloclddodl. .              \r\n,;,.      ..      .....'...,;..,lkO0KK0XX0OkkkoldxxxxxddxkOOOxdxkkkO0Oxolldxk000000000K0kxkOOOkkkkkxxdodddoodlclll::;;cccccoxdc::,;,.                 \r\n;,,'.              .......,;'..,;coolloddoooooxk0K0OkkkOxddxOOkkxdxxkkkkkxxxxxkOkdc:cloddxOkxxxxkkxkkxdxkdololccll:;:cc:;,,,'..             ........ .\r\nlc:;.               .......'. .',,,;ccloodxOO00OkOkkkkkkxdxxxxolooldkkOkkkkkkkxl;,,;:::clllc:;;::;;;;:lkxc,,,,'',,.....     ..        ......''...'....\r\nxdl;.               ...  ...  .'clllododxkkxxkOkkxdoddollc:::::cdxxxdollllc:loccol:;;,''...........   .'..''''''...               ....................\r\n::;,.          .. . ...   ..   .,clcclldxxddooll:,,;::;;;,,;::clooo:,,,;;::cll;:c,..........'''....... .. ......... ..     .    ......................\r\n:cc:,.          ...  .   ...   . .':cclodddoc:;,,,,,,,,;;:clc;;,,;;,;::::::::;'...........'.........      ..... ... ..................''....''........\r\n;::;;.           .  ..  ....   .   ..;c;,,,;;,;;,,;;'..''';;;clc:;;;;::;,,...'''''.....','...........   .............................,,''',,;,,'......\r\nlc;:c,     .    ..  ...   .'. ... .  ......',,,,,,,'...     ..'::::,........',;,,''........''...........'..........................'..,,,',::,''......\r\n:lc:;'.         .   ..     ...       .....''..'............    ..........''''';,''''''...............','..'''''.....'.......... ..';;,,,,,,,,,'''.....\r\n.',...         ..            ..          ................................''''',;''''............',,'.......,,,,,'..,;,'.''''''....',lc;;'..;:,....  ..\r\n                               ..  .   ...  ..         . ..',''...... ..''...',;.....................''.   ....................'....',.... .'..','....\r\n             .   .     .           .    ..                 .,;::;,','.....'''';:..,;,,'',,'..,,'.....''.... .......',............. .,,''...'''';,''...\r\n                   ..   .   ..            .     .     .........';,''..''..','.:c,';::;,,,,'.','''......'....',,;,;:;;;;;cl;...........';;,';;;cc,'....\r\n        ..     .           ..             ..  ...     ..'''........ ...'......;;',c:;''';,'.............   .....''....';c:,..........,;;'....:c,...''.\r\n             .        ..  ...              .  .     ....'',,'..'......... ........',....,'',,.......'......           .... ....... ...;;,'........'.''\r\n             ....      . .. ..               ..  .................;:;..';'....'.  ..    ...,''''''..''........    .    .   ...........',',,...  .....'\r\n                          .       .              ..... .. .      'lo:.'.':,..;o: .........,'....... .. ....';'... .         .....''.. ................\r\n                           .   .           .     ....  ....  ... ';..'..,'..,::. .. .',,.....   .       ..  ','''....           .','.'.   ...... .... \r\n               ..             ..    .             ..          ':':l.,; .;;..,;.. .,'.....        .':'...... .'''.....            .....                \r\n                             ..                       ..      .,.';..   ';..:c'...''             .',.. ...  .  .........            .                 \r\n");
                //Recoger lo que dice el usuario
                string objeto = Console.ReadLine();
                string objetoCuadro = objeto.ToLower();
                //Si pasa la prueba
                if(objetoCuadro == "mover")
                {
                    Console.WriteLine("Mueves el cuadro y hay una cajetilla de cerillas.\n (Has obtenido cerillas)");
                    cerillas = 1;
                }
                //Pistas
                else if (objetoCuadro == "pista" && pista2 == 0)
                {
                    Console.WriteLine("Pista 1: Parece que el cuadro está hueco.");
                    pista2 = 1;
                }else if (objetoCuadro == "pista" && pista2 == 1){
                    Console.WriteLine("Pista 2: Tiene como algún mecanismo para moverlo.");
                    pista2 = 2; 
                }else if (objetoCuadro == "pista" && pista2 == 2)
                {
                    Console.WriteLine("Pista 3: Escribe “mover” para mover el cuadro.");
                }
                //Para salir de la habitación
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            Console.WriteLine("The line");
            break;
        //Globo terráqueo
        case 3:
            do
            {
                //Descripción.
                Console.Clear();
                Console.Write("\u001bc\x1b[3J");
                Console.WriteLine("Miras de cerca el globo terráqueo y te das cuenta de que hay un carril marcado en el que parece que se puede colocar un objeto. \nMiras más atentamente y ves que hay una ubicación marcada: Grecia.");
                //Escenario
                Console.WriteLine("\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNXKXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNXKOkxdodkkkO0KXWMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMNKOxdolc:::::cooooooodxOXWMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMN0koc::cclllllccoxkkkkkxdoooxOXWMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMWKkoccccccccloddoooodxkkOOxxxdddddkXWMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMWKxlcccc:::cllodddddddddolodddooooddddONMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMXxc:cccc:cloodxxxxxxxxolccccllllloooodxdxKWMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMW0l:clc::cooodxkkkkxdddol::cllcclooloddddxdd0WMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMNkc;cc:;:clooddxkkkdllololc::lddddxkdllodddxdd0WMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMNk:;:c::clooooddxxkxoccclooccccloxxxkxocldxxxxdd0WMMMMMMMMMMMM\r\nMMMMMMMMMMMMWO:;::;;loddoddxddddoc::lloooolccldddddoccoddxxxoxXMMMMMMMMMMMM\r\nMMMMMMMMMMMMKl;:c;,:llloooddooolccccllododddoooooolooooddxxxddOWMMMMMMMMMMM\r\nMMMMMMMMMMMNx::c;',cllclolllooolccclooooodxxxxxxdoooddddddxxxdxXMMMMMMMMMMM\r\nMMMMMMMMMMW0l:c:,,:lllcllllddolcccllllllodxxxkOOkxoodddddxxxxdxKMMMMMMMMMMM\r\nMMWNXXK0OOko::c:;:lollllllooooollloooooodddxxkkOkxdooddddxxxxxxKMMMMMMMMMMM\r\nXOxdolllllc::cc;;cllllllllooloolllllloooddddddxxxdollooodxddddx0NWWMMMMMMMM\r\ndllcccccccc;:cc,,:cccclllooollllcclllllloollldddooooooooooooddodxxkO0XNWWMM\r\nocllcllccc:;:c:'',;;:cllcccccccccclllccllllllodooolloolllollllclodoooddxO0X\r\nKxlcccllll::llc,,,,;::c:;;:;;;:;;;clc::cccccllllllllcccclllllloooxxddddoodd\r\nMW0l,,;;:::::cc::::ccccc::c::::;::cllcclllccclllllllllcccccllldddxxxxxddooo\r\nMMWx;,,'ckkc'','',,;;;:;;;;;:::::cclllllllllllllllllllcclllllllooooolllc:o0\r\nMMMKl,;,;OWk;',,'',,,;;;,''''',,,,,;;;;;;;::;:::::::::;;;;;;:clloddo:;;;:xW\r\nMMMWO:,,,cKXo',,,',,;:::;,,'.';,,,,;;,,,;;;,,,,,,,,,,,,,,;cx0XXNWWWOc;::oKM\r\nMMMMNx;,,,lKKc',,',,;::;;,,'',;;;;;::;;;;;;;;;;;;;;:::;::lkNMMMMMMXd:::ckWM\r\nMMMMMXo;,,,l00c,,,,;,,;;;;,',;;:::::::;;;;;;;:::::::cccclOWMMMMMMNxc:::dNMM\r\nMMMMMMXd;,,,:O0l,,;:cc:;;;,',;;;::::;,,,,,,;::;;;::clccxKWMMMMMWXdc:ccdXMMM\r\nMMMMMMMNk:,,';dOd;,;coddl:,',;;;,,''''',,,,:c:;;;::::oONMMMMMMN0occccxXMMMM\r\nMMMMMMMMW0l,''':dxl;;:cldxo;,::;,'..',;:::::ccc::::oONMMMMMMWXxcccclkNMMMMM\r\nMMMMMMMMMMNk:,''';lolc;;:cc;,cooolc,..',;;;;;;:cokKWMMMMMMWXklcccco0WMMMMMM\r\nMMMMMMMMMMMWXxc,''',cllllc;,,:ccccc:;;;;;;;:lxOXWMMMMMMWN0xlccccoONMMMMMMMM\r\nMMMMMMMMMMMMMWXkl;,,,',:cll:,:cc:,'..'':dk0XWMMMMMMWNKOxocc::coOXWMMMMMMMMM\r\nMMMMMMMMMMMMMMMMWKxl;,,'..''';cc'......l0XXXXXK0Okxdlcccc:clx0NMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMNKko:,'...';:,.......;::::::::::::ccldk0NWMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMWNKOxoc,':;'......,,,,;;;::cloxO0XWMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMW0o:;'.....,oxxxkkOOKXNWMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMW0c.....:OWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWOc'.  ..'ckNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXo.   .....lKMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMW0;.   ...,kWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNd.     .oXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNl.  ..:XMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMx.  .'dWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMO'  ':kMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWk'  ':xWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMWNXK00kc. ...cOKKXNNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMNKkdlc;,'..... ....''',;:lodOKNMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMWXOo:'..........   ..............':oONWMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMXd:'...........           ......'....'cxKWMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMM0c..............      .................''cKMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMWd'............       ....................;OMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMWk,..........           .................;dXMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMWOc'..........       ................,cdKWMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMN0xl;'......................'';:ldOKNMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMWXOdl:,'........'''',;:ldk0XNWMMMMMMMMMMMMMMMMMMMMMMMMMM\r\n");
                //Recoger lo que dice el usuario
                string objeto = Console.ReadLine();
                string objetoGlobo = objeto.ToLower();
                //Si pasa la prueba
                if (llaveAvion == 1 && objetoGlobo == "avion"|| llaveAvion == 1 && objetoGlobo == "avión")
                {
                    Console.WriteLine("Sitúas el avión en el carril y se activa un mecanismo que abre el globo por la mitad. \nDentro del globo ves que hay  un 3 escrito en un papel.");
                }
                //Pistas
                else if (objetoGlobo == "pista" && pista3 == 0)
                {
                    Console.WriteLine("Pista 1: En algún lugar tendrá que haber un objeto");
                    pista3 = 1;
                }else if (objetoGlobo == "pista" && pista3 == 1)
                {
                    Console.WriteLine("Pista 2: Ves a lo lejos en las estanterías un libro en el que pone “Grecia”.");
                    pista3 = 2;
                }else if (objetoGlobo == "pista" && pista3 == 2)
                {
                    Console.WriteLine("Pista 3: Ve a la estantería y escribe “Grecia”. Luego, vuelve y escribe “Avión”.");
                }
                //Si no pasa la prueba
                else
                {
                    Console.WriteLine("Intentas abrir el globo a la fuerza, pero parece imposible.");
                }
                //Volver atrás
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;
        //Mesa
        case 4:
            do
            {
                //Mesa
                Console.Clear();
                Console.Write("\u001bc\x1b[3J");
                Console.WriteLine("Te acercas a la mesa y ves un cajon cerrado con un candado de 5 letras.");
                //Escenario
                Console.WriteLine("\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWN0xlccccloooooddoollooodooddooddddddddddddoodddddxxxxkkkkkxdxKWM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMWNK0Oxdllc:ccllcccccccccc:::::ccc:ccc:::::::::::::::c::c::cc:;,'..',:':KM\r\nMMMMMMMMMMMMMMMMMMMWNX0Oxolc:::cldxO0XWWWWWWWWWWWWWWWWWWWWWWWWWNNNNNNNNWWWWWWWWWWWNX0xl:;,:ldOXX:.kW\r\nMMMMMMMMMMMMWXKOkdlc::::codk0KNWWWWWWWWWWWWWWWWWWWWWWWWWWMMMWWWWWWWWWWWWWWWWWWN0xoc::cldOKNWWWWXc.dW\r\nMMMWXKK0kdolc::ccldk0KNWWMMWWWWWWWWWWWWWWWWMWWWWWMMMMWWWWWWWWWWWWWWWWWWWWNKkoc:;:lx0XWMWWWWWWWMNc.xM\r\ndlc;,'.....';:lododddddddooodoooodoooooooooooooooooododddoooddodododddddl:;cldOXWMMWWWWWWWWN0koc'cXM\r\n.;dddooooollllllloolllllllllolllllllllllllllllllllllolloolllllllllooool''dKNWMMMMWWWWWN0kol:;,'.:OWM\r\n.lNMWWWWWWWWWWWWWWWWWWMWWWWWWWWWWWWMMMMMWWWWWWMWWWWWWMWWMMWWWWWWWWWWWWK;,0WWWWWWWX0xoc;;:clood;.l0NM\r\n';KWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW0,,0MWNKkdc;;coxkkkxdddd;.cxKM\r\n;,OWWWWWWWWWWWWWWWWWWWWNNWWWWWWWWWWWWWNNNWNNNNNNNNNNNNNNNNNNNNNNNXXNNN0,'xxl:,;ox0XXKOxddddddo;.cONM\r\nd,;:clccclllcccccc:cccc:;cccc::c::::::::::::::;:;:::::::::;;;;::;,,;::;..,,;cxNWX0kxdddddddddo,.lXMM\r\nW0c.;llokkdlcccllcccccccloolllk0kdoccccccccodlclllccldkxolccccclolccc:.'ldddk00kxddddddddddddo,.oKWM\r\nMMd.cxlccc:::::::cllc:ccloolccoolcc:cllcc::c::cldolccllc:cclodxddooxkl.,dxdddddddddddddddddddo,.lONM\r\nMWd.cl',llcccccc::cccccc:::::::::cc::cc::::::cc:ccc:ccc:ccclcccclc;oXx.'oddddddddddddddddddddd;.dWMM\r\nMMd.;c.lNWWMWWWWWWWWWWWWWWWWWWWWWWNKKXNNWWWWWWWWWWWWWWWWWWWWWWWWWX:;ko.'lddddddddddddddddddddd;.dWMM\r\nMNo.;c.cXWWWWWWWWWWWWWWWWWWWWWWWWOc:,;o0WWWWWWWWWWWWWWWWWWWWWWWWWX:,xo..lddddddddddddddddddddd;.kMMM\r\nMNl.;c.cXWWWWWWWWWWWWWWWWWWWWWWWNo.,.'dNWWWWWWWWWWWWWWWWWWWWWWWWWX;,xo..lddddddddddddddddddxkk:.dWMM\r\nMNl.;c.lNWWWWWWWWWWWWWWWWWWWWWWWWXkod0NWWWWWWWWWWWWWWWWWWWWWWWWWMX;,kd..lddddddddddddddddxxxxo,.oXWM\r\nMWo.cd,cKXXXXXXXXXKXKKKKKKKKK0000000000OOOOOOOOkkOOkkkkkxxxxxxxddo,'do..lddddddddddddddddddddo,.ckXM\r\nMKc.;o:;cclllccc:;;::;;;,,,,;::::;,,,;::,'''',;;,'''''','',,'''..',:ol..lddddxxxdddddddddddddo,.dXWM\r\nMNo.;dddk0K0OxdxdooooooooooddxO0OdoooxxxdooodkOxdoooooooodddoooooodddl'.cdxkkkxddddddddddddddo,.oKWM\r\nMMx.;dddOOkddddooooddooodkO0koodoooooodxkxoooooooooooooooooddxkkxxdddl'.oOOkdddddddddddddddddo,.lKWM\r\nMMx.;dl;;;;;;;;,'',;,,,,,;;,,'''''''',,;;''''''''''''''',,',;:cc::cxxl..oxdddddddddddddddddddo,.dNMM\r\nW0c.;d:.l000000OOOOOOO00OOOOOkOOOOxxkOOOOOOOOOOOOOOOOOOOOOOOOOOOO:,O0o'.lddddddddddddddddddddo,.dWMM\r\nNOc.;d:.oWWWWWWWWWWWWWWWWWWWWWWWNx;;ldONMWMMMMMWWWWWWWWWWWWWWWWWNl'okl'.cddddddddddddddddddddo,.lNMM\r\nWKc.;d:.dWWWWWWWWWWWWWWWWWWWWWWWNl...oKWMMMWWWWWWWWWWWWWWWWWWWWMNl'oxl'.lddddddddddddddddddol:..xWMM\r\nW0:.;o:.dWWWWWWWWWWWWWWWWWWWWWWWWXxokXMMWWWWWWMWMMMMWWWWMMWWMWWMNl'oxl'.ldddddddddddddddlc;,'.cONMMM\r\nMNo.,xl.cOOOOOOOOOOOOOOkOOkkOOkkkkkkkkkkkkkxkkkkkkkkkkxxkkkkkkkkx;.okl'.ldddddddddddlc;,'.:kd'cXMMMM\r\nWKc.,xkc,,;;:;,::;::;,,:lc;,;,,;:c:;,;:::;;,,;cc:;;;,,,,,;,,;;;;;;:ldl'.ldddddddl:;'';lxO:'oo'.xMMMM\r\nMNd.:ddddddddddxxdxxdddO0xddddddkOkxdxkxxkkddOK0kxxddddddddddddddddddl''oxdolc;,,:lx0NMMMKolloxKMMMM\r\nMMk';dddxxddddddxOKOdodddooododkO0xooodk0XOddddodddddddddddddddddddddl''lc,,;coOKWMMMMMMMMMMMMMMMMMM\r\nMMO,';;;:;,,,,,,;::;,''''''',,,;:;'''',;:;,'''',,''',,,,,,,,',,,''',,,..,cdOXWMMMMMMMMMMMMMMMMMMMMMM\r\nMMW0l.,dd,.lkOOOOkkOkkkxddkOOOOOOOOOkkkOOOOxddxkkkxkkkOOkdddxkOkc.,xOk;.xWMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMNl.dNd'lNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMK:'xWWx'lNMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMO,,xd'cXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM0;,xOo':XMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMM0:...:KMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWk,''.'dWMMMMMMMMMMMMMMMMMMMMMMMMMM\r\n");
                //Recoger lo que dice el usuario
                string objeto = Console.ReadLine();
                string objetoMesa = objeto.ToLower();
                //Si supera la prueba
                if (objetoMesa == "mario")
                {
                    Console.WriteLine("Abres el cajon y encuentras un USB. Parece que puedes usarlo en el ordenador de aqui. \n (Has obtenido USB)");
                    USB = 1;
                }
                //Pistas
                else if (objetoMesa == "pista" && pista4 == 0)
                {
                    Console.WriteLine("Parece que un nombre puede entrar en ese candado");
                    pista4 = 1;
                }else if (objetoMesa == "pista" && pista4 == 1)
                {
                    Console.WriteLine("Tiene que haber un nombre importante por la habitacion.");
                }else if (objetoMesa == "pista" && pista4 == 2)
                {
                    Console.WriteLine("Intentas abrir el cajon a la fuerza, pero parece imposible.");
                }
                //Volver
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;
        //Estantería
        case 5:
            do
            {
                //descripción
                Console.Clear();
                Console.Write("\u001bc\x1b[3J");
                Console.WriteLine("Te acercas a la estantería y te fijas que todos los libros son de distintos países del mundo. \nPero no ves nada más fuera de lo común.");
                //Escenario
                Console.WriteLine("\ndxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\r\nddolcccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccclodd\r\noo;..............................................................................................:oo\r\noo:..............................................................................................:oo\r\noo:',''......:lllc:'.......',,''......................,::;,........''...........'................:oo\r\nooclddl;....,dOOkxd;','.,,'ckkdo:'''..;cc::;',;,.,:;,.;loc;';odl;',;,,'...,::,.,;..,;,,''coc;'''.;oo\r\nllccddl;';:',dOOkxd;,:'.;;'l0Okxc;lc,;x00Okd:,;,',;;'.:olc;'c00kc'',,'....oOko,,;..',,''.lkoc'''.;oo\r\nloc:llc,.',.'lxxdlc',:'.:;'oK0Okl:oc,;xOOkxo:,;,.':;'.lOkdl,cO0kc',;,''...oOko,';..,;,,''oOdc''..;oo\r\nlo:,c:;'.''..:olc;'.'c'.:;'l00Okc;lc,;x00Okd:';,..:;'.lkxol;cOOx:'';,'....lxoc'',..,;;,''dK0d,''.;oo\r\nloc:lc:,.''.'oxxdol,,c,.:;':xkxd:;l:';ldolc:;,;,.':;'.;lc:;'cOOxc',;;,'...cdo:',;..,;;,''dXKx,'..;oo\r\nllllddl;.',.,dOOkxd;,:'.:;'cxkdo;:oc,;oxxdlc;,;,.,;;'.;l:;,.c00kc'',,'....oOkl,,;..,,,,''o0ko,'..;ll\r\nllllddl;'''.,dOOkxo;,:'.;;'ckkdo::oc,;x0Okxo:,;,.,:;,';c:;,.cO0kc''''.....oOko,';..,;;,''lko:''..;ll\r\nllllxdl;.''.,dOOkxd;,;'.;;'ckkdo;;l:';xK0Okd:,;,.,:;'.;c::;'c00kc'';,'....oOko,',..,,,,''lkoc'''.;ll\r\nllllxdl;.''.,dOOkxo;';'.;;'ckkdo:;lc,;x0OOxo:,;,.,c;'';l::;'cO0kc'',''....oOkl,';..,;;,''lkoc,''.;ll\r\nllllxdl;.',.,dOOkxd;';'.,,'lOkdo::oc,:x00Okd:,;,.,:;'';ll:,.cO0kc',;,,'...oOko,,;..,,,,''lkoc'...;ll\r\nllllxxo;';:',dOOkxo;';'.,;'lkkxd::lc,;x00Oxo:,;,.,c;'.,lol:'cO0kc'',,'....oOko,';..,;;,''okdc'...;ll\r\nllooddlc:cc::dxxxxdc:c:;:c:ldxddcclc:cdxxxdoc:c:;:cc:;coool:lxkxl:::::;;,;okxo::c;;:cc:::oxdl:;;,cll\r\nccllllcllllllcclccllllllllllllcllllllllccllllllllllllllllllllllllllllllllllcclllllllllllllllllllllcl\r\ncc;..............................................................................................;cl\r\ncc;..............................................................................................;ll\r\ncc;....';;,,,.................;;'.....................'''........................................;ll\r\ncc;',''lO0kkd,...'::;,.......;k0o;;;,,'':c:,,cc:'.''.'loo:......''..''..'..';;;;,.''...','.';'';,:cc\r\ncc::lc;l00kkd,...,odo;',;'...;k0o;;:;,.,kkxooOkxc,;;''col:'','';ddccdo,','.lXXXKx,,;'..','.;l;;l::cl\r\ncc::lc,:xxddc'...,lol;,cc;..':k0o;,;,'.,xkxlokkd:.''.'ldo:,lxd::ddcldo;,;,.oNNXXx,.'...',,.;o:;o::cc\r\ncc::dl,,ooll;.''.,llc;':c,..':k0o,,::,.,xkxlokxd:';;''oxdc,lkd:,cc;;c:',;,.oNNNXx,.'...:o:';l;;l::cc\r\ncc::lc,:dxdoc,,,.;odo:'::,..':k0o;:llc',k0kooOOk:'''.'oxd:,dkx:,cc,;l:'''..oXXKXx,.'...cdc';l;;l::cc\r\ncc:;c:,l00kOd;,,.;xkxc';;'..':k0o;;;,,.,kKOoo00k:.''.'oxd:,odo:,cc,;c:.''..oX0O0x,.'...,:;.,l;;l::cc\r\ncc:;c:,l00Okd;...;xkxc';;'..':k0o;,;,'.,kKOoo00k:.''.'ldo:,odo:;ll:clc,','.oXK0Kx,.'...','.,c;;c;:cc\r\ncc:;c:,l00kkd,...,ool;';;'..':k0o;,;,'.,kKOoo00k:',,.'lol:,cdo;:dxllxd;''..oXXXXx,.'...','.,c;,c;:cc\r\n:c:;c:,l00kkd,...,llc;',,'..':k0o,,;,'.,kKOoo00k:';;''lol:,col;:ddclxo;''..oNNNXx,.'...','.,:,,:;;cc\r\n:c:;c:,l00kkd,...,lol;';:,..':k0o;,,,'.,kKOoo00k:.'..'lol:'coc,:ddclxo,.'..oNNNXk,':;..','.,c;,:;;:c\r\n:c::oc;l00Okd,...,odo;,:c;..':k0o;;:;;';k0Ooo0Oxc,;;''lol:';::,;llc:cc,',''ckkkko,':;..,;,',;,,;;;:c\r\n:cc:lc;cxxddl;''.;ccc:,;;,'',:dkl:::::,;dxdllxxd:,,,',clc:,',:ccodolc:;;;::colll:,,,,,,,;;,;:;;:;:::\r\n::cccccccccccccccccccccccccccccccccccccccccccccccccccccccc:,;dxooodxocc::cloolc:;:::;;;;;;:::::::c::\r\n::,.........................................................'::;;:c::::;;;::::,'''''.......''''',;::\r\n::,..........................................................,,,;::;,::::::::c;''............'''';::\r\n::,...............................................'..',:::;:c:...................................;::\r\n::,..................,ooolcllo:....':;,,,,......'lxccld0KOkKWK:......,dxxxxl;:::;;l:cc:c:....,,,';::\r\n::;............lxo:..cXWW0k0O0x'...,oclkkk:..,c;;lxccllxxod0N0ocl:''.cKK0XNOoxOkclkodkokd'..'cxd;;::\r\n::;....,c,...'oO0Kd'.lXWW0kOk0x,',';ocokkxdkdclc;lxcclcxkooOXOkXM0k0xxKOkKXkox0klo0kkOxOx,,''lkd;;::\r\n::;...'ll,..'oOOOx:,'lXWW0kOk0x;;:,;lcoOOkxKkclc;okllocxkooKWKOXW00N0k00kKXkoxOxlo0kO0kOk;,''lxd;;::\r\n::;...:o:..,dOOOdldxodXWNOkOk0x;;;,;lcokOkxKkcol;oOllolxkodKMXOXW00WKk0kx0XkoxOxlo0kkOxOk;,''cxd;;::\r\n;:;'.,ll,.,dOkOo':kOxdKK0xk00Kx;;:,,ccoO0Ox0xcxd;okllolxxodKMXOXW00WKk0xdKNOoxkxclkodkokd,,''lkd;;::\r\n;::'':o:',dkkOo'.:k0xdkO0kkKKKxdO0d:::xXXKkOxcxd;oOllookOkx0N0kKNO0NKkKK0K0dlkOkllkodkokd',''coo;;::\r\n;::';oo,;dOkko'..:kOxdOXN0k0KKkOWM0c;:kXXXk0xcxd;lklcokWWXkOXOdkOxONKddxolc;ck0kllkodklxd,,,l0O0d:;:\r\n;::,cd:;dkxkl....:k0xxKWW0x0KKxkWM0c;:kNXKO0kcol;lxcclkMMNOOXOooxoOWKc;ccc:;lkOkllkodklxd,,,dX0Kkc;:\r\n;:::ol:d0Okl.....;k0xxKWW0dk0OdkWM0c;:kNXKOKkclc;lxccokWMNOKWKoldlOWKl:lllc;lxkxloOxxkdkx,',dX0Kkc;:\r\n;:cloldOOOc......;k0xxKWN0odxdlx00Oc;:kXXKOKkclc;lxcloxXNKO0X0dodlkNKl;ccc:;cxkxldKOO0k0k;,,lK0Kx:;:\r\n;:clc;cdxl'......;xkdoOKKkc:cc:dOOxcc:dKK0xOx:cc;cdcclokkxxk0kolold0kc;c:::;coooclxoddlxo,''lOO0d:;:\r\n:clllcclol:;;;;;;::c::cccc:::::cccc::::cccccc::::::::::ccc:ccc::::ccc::::::::::::::::::::;;::cccc:;;\r\nc:cc::::c::;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;c\r\n");
                //Recoger respuesta de usuario
                string objeto = Console.ReadLine();
                string objetoEstanteria = objeto.ToLower();
                //Si acierta el libro
                if (objetoEstanteria == "grecia")
                {
                    Console.WriteLine("Abres el libro de Grecia y cae un avión de metal al suelo. \nDecides guardarte el avión por si te sirve en algún futuro.");
                    llaveAvion = 1;
                }
                //Pistas
                else if (objetoEstanteria == "pista" && pista5 == 0)
                {
                    Console.WriteLine("Pista 1: A lo mejor esto tiene algo que ver con alguna otra prueba.");
                    pista5 = 1;
                }else if (objetoEstanteria == "pista" && pista5 == 1)
                {
                    Console.WriteLine("Pista 2: El globo terráqueo tendrá algo que ver con los libros.");
                    pista5 = 2;
                }else if (objetoEstanteria == "pista" && pista5 == 2)
                {
                    Console.WriteLine("Pista 3: Si escribes “grecia” abriras el libro de Grecia que te dará un objeto.");  
                }
                //Volver
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;
        //Chimenea
        case 6:
            do
            {
                //Descripción
                Console.Clear();
                Console.Write("\u001bc\x1b[3J");
                Console.WriteLine("Te acercas a la chimenea. Crees que hace algo de frío en la habitación y que necesitas algo para encender la chimenea.");
                //escenario
                Console.WriteLine("\n               ____________________________________\r\n              I___|___|___|___|___|__|____|___|__|_I\r\n              I_|___|___|               |___|___|__I\r\n        )\\    I___|__ | ..,a@@@a,a@@@a,.. |___|____I      /(\r\n       ( ))   I_|__  .,;*;;@@@@@a@@@@@;;;;,. ___|__I     (( )\r\n        :     I__|  ;;;;;;;;;a@@^@@a;;;*;;;;;  __|_I       :\r\n       ,uU    I_|  ;;;;*;;;a@@@   @@@a;;;;*;;;  |__I      Uu.\r\n       :Uu    I__|;;;;;;;a@@@@   .@@@@@;;;;;;;; __|I      uU:\r\n       | |    I_| ;;*;;;a@@@@@   @@'`@@@;;;;;*; _|_I      | |\r\n       |_|    I__ ;;;;;;@@;;@@   `@  `@;;;*;;;; ___I      |_|\r\n    _ (___) _ I_|_ ;;;*;;@;;;;@;;;;;*;;;;;;;;; _|__I___  (___)\r\n  ,-' )   (   ~~~~~ `;;;;;;*;;;;;;;;;;;*;;;;'  ~~~~~     )   (`-.\r\n,-____=====_____________`;;;;;;;;*;;;;;;;'_______________=====___`.\r\n|~~|  _________________________________________________/o\\___   |~~|\r\n|_||  ||____|____|____|____|____|____|____|____|____|_/ /,\\__|  ||_|\r\n|__|  |___|____|____|____|____|____|____|____|____|__/ /,,,\\||  ||_|\r\n|_||__||____|____|____|____|____|____|____|____|____|\\/,,,,,\\|__|__|\r\n|____|____|____|____|____|____|____|____|____|____|___\\,,,,,,\\___|_|\r\n|_|____|__I####I..........  /%%%%%%%%%%%\\ ..........I##\\,,,,( )|___|\r\n|____|____I####I.......... .%%%%%( )%%%%%. .........I###\\,,,,\\/__|_|\r\n|_|____|__I####I..........  /%%%%%%%%%%%\\ ..........I##\\,,,,( )|___|\r\n|____|____I####I.......... .%%%%%( )%%%%%. .........I###\\,,,,\\/__|_|\r\n|_|____|__I####I.......... @@%%%%0%0%%%%@@  ........I## /,,,,/_|___|\r\n|____|____I####I.......... `@@@@@@@@@@@@@@' ........I# /,,,,/____|_|\r\n|_|____|__I####I............ \\\\\\\\\\\\\\\\\\\\\\\\\\) ........I ( \\,,/___|___|\r\n|____|____I####I.............  `\\\\\\\\\\\\\\\\\\\\) ........I  \\_)/_|____|_|\r\n|_|____|__I####I............  A   `\\\\\\\\\\\\\\' ..   .. I#  :_|____|___|\r\n|____|____I####I.........    AAA  .. `\\\\\\' ..  A.  .I###I___|____|_|\r\n|_|____|__I####I......   .A  `AAA ....  *  ..  AAA. I ##I_|____|___|\r\n|____|____I####I....    AAA  AA;AA  ...   ...  `AAA.I ##I___|____|_|\r\n|_|____|__I####/~~~,-.A;;A'-A;;;;;A-----A-----,A;;;A  ##I_|____|___|\r\n|____|____I###/    I.;;;;;  ;;;;;;;   AAA     I;;;A'\\###I___|____|_|\r\n|_|____|__I##/     I;;;;;; ;;;;;;;   A;;;A    I;;;;  \\##I_|____|___|\r\n|____|____I#/     !~;;;;;;~~~~~~~~~~~;;;;;;~~~~~!;'   \\#I___|____|_|\r\n|_|____|__I/______!  ::::;;           ;;;;;;    !______\\I_|____|___|\r\n~~~~~~~~~/       ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~       \\~~~~~~~~~~\r\n        /_______________________________________________\\\r\n                       /\\____/\\    __\r\n                     .'  \"\"\"\"  `,-'  `--.__\r\n                __,- :   -  -  ;  \" ::     `-. -.__\r\n             ,-sssss `._  `' _,'\"     ,'~~~::`.sssss-.\r\n            |ssssss ,' ,_`--'_    __,' ::  `  `.ssssss|\r\n           |sssssss `-._____~ `,,'_______,---_;; ssssss|\r\n            |ssssssssss     `--'~{__   ____   ,'ssssss|\r\n             `-ssssssssssssssssss ~~~~~~~~~~~~ ssss.-'\r\n                  `---.sssssssssssssssssssss.---'");
                //Recoger la respuesta del usuario
                string objeto = Console.ReadLine();
                string objetoChimenea = objeto.ToLower();
                //Si pasa la prueba
                if (objetoChimenea == "cerillas" && cerillas == 1)
                {
                    Console.WriteLine("Vas a encender la chimenea y encuentras una llave debajo de los troncos. \nParece que te será útil para un futuro y decides cogerla.");
                    llave = 1;
                }
                //Pistas
                else if (objetoChimenea == "pista" && pista6 == 0)
                {
                    Console.WriteLine("Pista 1: Necesitas algo para encender la chimenea.");
                    pista6 = 1;
                }
                else if (objetoChimenea == "pista" && pista6 == 1)
                {
                    Console.WriteLine("Pista 2: Puede que el cuadro de arriba de la chimenea oculte algo.");
                    pista6 = 2;
                }else if (objetoChimenea == "pista" && pista6 == 2)
                {
                    Console.WriteLine("Pista 3: Busca en el cuadro unas cerillas y luego vuelve a la chimenea y escribe “cerillas”.");
                }
                //Volver
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;
        //Caja fuerte
        case 7:
            do
            {
                //Descripción
                Console.Clear();
                Console.Write("\u001bc\x1b[3J");
                Console.WriteLine("Te acercas a la caja fuerte y ves que se abre con un pin de 4 numeros.");
                //Escenario
                Console.WriteLine("\nO,..';;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;,;:cdOXWMMMMMMMMMMMMMMMMM\r\nx. ..o0KKKKKKKKKKKKKKKKKKKKKKKKKKXKKKKKKK0000000000Oxl:;;:cdOXWMMMMMMMMMMMM\r\nd.';..:OXXXXXXXXXXXXXXXXXXXXXXXXKKKKK0000000000000000KK0Odl;,,:lkKNMMMMMMMM\r\nd.,lc,..dKXXXXXXXXXXXXXXXKKKKKKK0000000000000000000000000000Oxo:,';lx0NMMMM\r\no.,lloc..:OXKKKKK000OOOOkkkkkkkkkkkxxxxxxxxxxxxxxxxxxxxkkxkkkkkkkdl;..,l0WM\r\nl.,llool. .;;;;;;;;;;;;;;;;;;;;;,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,'.  ;XM\r\nc.;llooo, .lddxxxxxxxkkkkkkkOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOkkkkxxxddo' '0M\r\nc.;loooo' ;kkkkkkkkkkkkkkkkkkkkkkOOOOOOOOOOOOO0000000OOOOOOOOOkkkkkkkx, .OM\r\n:.;ooool' :kkkkkOOOOOkkkkkkkkkkkkkkkkkkkkxxxxxxxxxxxxxxxxxxxxxxxkkkkOk; .kM\r\n:.;ooool. :kkkkOko:c:;::::::::::::::::::::::;;;;;;;;;;;::::;;,.,dOkkkk: .xM\r\n;.:ooool..cOkkkOx,'odddxxxxxxxxxxkkOOOOOOOOOOOOOOOOOOOOOO0OO0x..dOkkkk: .dM\r\n;.:ooool..lOOOkOd.,xkkkkkkkkkkkkkkkkOOO0000000000KKKK00000000k'.oOkkkkc  oW\r\n;.:ooooc..lOOkkOd.,kOkkkkkkkkkkkkkkkkkkkOO000000KKKK00000000Kk,.oOkkkkc. lW\r\n,.:ooodl..oOkkkkl.;kOkkkkkkkkkkkkkkkkkkkkkkOOO000KK000000000KO,.lOkkkOl. cN\r\n,.:ooodl..lOxc,,..;kOkkkkkkkkkkkkkkkkkkkkkkkOOOOOO0000000000KO;.cOkkkOl. :N\r\n,.cdoddc..lOo':x;.:kkkkkkkkkkkkkkkkkkkkkkkOOOOkkkkkOOO00000000:.ckkkkOo. ;X\r\n'.cooodc..lOo'oKc.:kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkOOO0000:.:kkkkOo. ;K\r\n'.cooooc..oOo,o0c.:kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkOOOc.:kkkkOo. ,K\r\n'.cooooc..oOo,lOc.:kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkOl.;kkkkOd. '0\r\n..cdoooc..oOo,lOc.:kkkkkkkkkkkkkkkkkkkkkOOkkxxxxxkkOOkkkkkkkkOl.,kkkkOd. '0\r\n..cdooo:..oOd,cOc.:kkkkkkkkkkkkkkkkkkkxl:;,,,,,,,,;;:ldkOkkkkOo.,kOkkOx' .O\r\n..cdood:..oOkc,:'.:kkkkkkkkkkOOOkkko;'..',::::::::;;,'',:okOkOo.'xOkOOx' .k\r\n..cdooo:..oOkxoo:.:kkkkkkkkOOOkkkd,.',:c:,',;;;;;,,,,;c:,.'cxOo.'xOOOOx, .k\r\n..coooo:..oOkxdxl.:kkkkkkOOOkkkkl..:cc;..;oxkkxddol;''.':c,.'od.'xOkkOx, .x\r\n..coooo:..oOkxdxl.:kkkkOOOOkkkOo..:c,..'lxkkkxl:;;;;cc:,.,c:..:.'xOkkOk; .x\r\n..coooo:..oOkxdxl.:kkkOOkkkkkOk;.;l;. .loddo:.......':lc,.'cc'. .dOkkOk; .d\r\n..coooo:..oOkkxxl':OkkkkkkkkkOx,.:l'..,cccc' .;;;;;. 'lod:.,l;. .dOkkkk;  d\r\n..coooo:..oOkkxxo'cOOkkkkkkkkOk,.:l'..;llc:. .:c:::' .lddl''c:. .dOkkkk:  o\r\n..coooo:..oOkkxxo,cOOkkkkkkkkkk:.,l;..'clc:,...'''. .;lool..cc. .dOkkkk:  o\r\n..coooo:..lOkOkko':kkkkkkkkkkkOd..:c'..'cccc:,,'...,cllll,.,l:. .dOkkkkc  l\r\n..coooo:..lOOOkOd';kkkkkkkkkkkkko..:c:,..;c:coollloolllc,.'cc'  .oOkkkkc. c\r\n .cdooo:..lOkkkOd';kkkkkkkkkkkkkko'.,:c:'..';:ccllcc:,'..;cc'.'..oOkkkOc. c\r\n .coooo:..lOkkkOd';xxkkkkkkkkkkkkkxc'..,:c:,'''''.....';c:,..co'.oOkkkOl. :\r\n .cdooo:..lOkkkOd';xxxxkkkkkkkkkkkkkxol,'.',:cccc:cccc:,...;dkx'.oOkkkOl. :\r\n .cdoll:..cOkkkOd',xxddxkkkkkkkkkkkkkkkkxoc:;,,'''''''',:lxkkOx'.oOkkkOo. ;\r\n .colll:. ckkkkOd',xxdxxxxkkkkkkkkkkkkkkkkkOkkxxdddddxkkOkkkkOx,.lOkkkOo. ;\r\n .colll:. ckkkkOx',xxdddddxxkkkkkkkkkkkkkkkkkkkkkkkkkkkOkkkkkOk,.lOkkkOo. ,\r\n .:llll:. ckOd::;.,xxddxddddxxkkkkkkkkkkkkkkkkkkkkkOkl;;okOkkOk,.lOkkkOo. ,\r\n .:llll:. :kkc:kc ,dxdxxdddddxxkkkkkkkkkkkkkkkkkkkkOk:. ;kOkkOk;.cOkkkOd. ,\r\n .:llll:. :kk:c0o.'dxddxddddddxxxkkkkkkkkkkkkkkkkkkkOo. :kkkkkk;.ckkOkOd. '\r\n .:llll:. :kk::Oo.'dxddddddxxxxxxxxkkkkkkkkkkkkkkkkOx;..'dOkkkk;.cOOOOOd' '\r\n .:llllc. ;kk:;kl.'dxddddxxxxxxddddxkkkkkkkkkkkkkkkkkxxxxkkkkkk:.cOOOkOx' .\r\n .;llllc. ;kkc;xl.'dxddxxxxxxdddddddxxxkkkkkkkkkkkkkkkkkkkkkkkk:.ckkkkOx' .\r\n: .:lllc. ;kOc'c; 'dxdxxxxxddddddddddddxxkkkkkkkkkkkkkkkkkkkkOO:.:kkkkOx, .\r\nK, .cllc. ,xOx:,'.'dxxxxxddddddddddddddddxxkkkkkkkkkkkkkkkkkkOk:.;kkkkOx, .\r\nM0' .clc. ,xOkkOd'.loooooddddddddddddddddddxxxxxxxxxxxxxxxxdddd; ;kkkkOx, .\r\nMWO' .cc. 'xOkkOkc;:;,,,,,,,,,,,,,,,,,,,,,,,,,,,,''''',,,;;,''''.ckkkkOx, .\r\nMMMO' .:' 'xOkkkkkkxxdddddddddddddddddoooooooooooooooodddddddddddxkkkkOk; .\r\nMMMWO, .. .dOOkkkkkkkkkxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxkkkkkkk; .\r\nMMMMM0;   .okkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkOOOOOkkkkkkkkkkkkkxxxxxd, .\r\nMMMMMMXl. .......''''''''',,,,,,,,,,,,,,,,,,,,,;;,,,,,,''''''''''.......  .\r\nMMMMMMMNo.......                               .                ..........:\r\n");
                //Recoger la respuesta 
                string objeto = Console.ReadLine();
                string objetoCaja = objeto.ToLower();
                //Si pasa la prueba
                if (objetoCaja == "3872")
                {
                    Console.WriteLine("Abres la caja fuerte y encuentras una bombilla morada y un trozo de papel, pero no parece tener nada escrito");
                    bombilla = 1;

                }
                //Pistas
                else if (objetoCaja == "pista" && pista7 == 0)
                {
                    Console.WriteLine("Pista 1: El pin deberia estar guardado en algun sitio");
                    pista7 = 1;
                }else if (objetoCaja == "pista" && pista7 == 1)
                {
                    Console.WriteLine("Pista 2: Seguramente este en el ordenador o algun sitio parecido");
                    pista7 = 2;
                }else if (objetoCaja == "pista" && pista7 == 2){
                    Console.WriteLine("Pista 3: Abre el cajon de la mesa donde encontraras un USB, conectalo al ordenador y te saldra la combinacion");
                }
                //Si no acierta el código
                else
                {
                    Console.WriteLine("parece que ese no es el pin, son 4 dijitos, pero cuales...");
                }
                //Volver
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;
        //Ordenador
        case 8:
            do
            {
                //Descripción
                Console.Clear();
                Console.Write("\u001bc\x1b[3J");
                Console.WriteLine("Solo hay una aplicacion en el ordenador 'Super Mario Bros.' pero parece no ejecutarse.");
                //Escenario
                Console.WriteLine("\nNNNNNWWMMMMMWWWNNNNNWWWWWWNNNNNNNWWWWWWNNNNNNNWWWWWWWWNNNNNNNWWWWWWNNNNNNNWWWWWWNNNNNWWWMMMMMWWNNWWW\r\nWWWWWWWWWWWWW0o:;::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::o0WWWMMWWWWWWWW\r\nMMMMMMWWNNNWK:.;c:;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;:c;.:KWWWWWWMMMMMM\r\nMMMMMMWWNNNW0,.ll.';;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;'.ll.,0WNWNNWMMMMMM\r\nMMMMMWWWWWWW0,.lc.cKXXXXXXXXXNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNXXXNNNNNNXXXXXXXXXKc.:l.,0WWWWWWWMMMMM\r\nWWWWWWWMMMWM0,.lc.cXNNNNNNWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWMMMMWWNNNNNNNNNNXl.:l.,0MMMMMWWWWWWW\r\nWNWWNWWMMMMM0,.lc.cXNNNNWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWWMMMMWWNNNNNNNNNNNNXl.:l.,0MMMMMWWNNWWW\r\nNNWWNWWMMMMM0,.lc.cXNNWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWWMMMMWWNNNNNNNNNNNNNNXl.:l.,0MMMMMWWWWWWW\r\nWWWWWWWWWWWW0,.lc.cXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWNWWMMMMWWNNNNNNNNNNNNNNNNXl.:l.,0WWWWWWWWWWWW\r\nMMMMMMWWWNNW0,.lc.cNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWNWWMMMMWNNNNNNNNNNNNNNNNNNNXl.:l.,0WNNNWWMMMMMM\r\nMMMMMMWWWNNW0,.lc.cNMMMMMMMMMMMMMMMMMMMMMMMMMMMWWNNNWWMMMMWNNNNNNNNNNNNNNNNNNNNNXl.:l.,0WNWNNWMMMMMM\r\nWWWWWWWWWWWW0,.lc.cNMMMMMMMMMMMMMMMMMMMMMMMMMWWNNWWMMMMMWNNNNNNNNNNNNNNNNNNNNNNNXl.:l.,0WWWWWWWWWWWW\r\nNNNWNWWMMMMM0,.lc.cNMMMMMMMMMMMMMMMMMMMMMMMWWNNWMMMMMMWNNNNNNNNNNNNNNNNNNNNNNNNNXl.:l.,0MMMMMWNNWNNN\r\nWWWNNWWMMMMM0,.lc.cNMMMMMMMMMMMMMMMMMMMMMWNNNWMMMMMMWNNNNNNNNNNNNNNNNNNNNNNNNNNNXl.:l.,0MMMMMMWNWWWW\r\nWWWWWWWMMMWM0,.lc.cNMMMMMMMMMMMMMMMMMMWWNNWWMMMMWWNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNXl.:l.,0MMMMMWWWWWWW\r\nMMMMMWWWWWWW0,.lc.cNMMMMMMMMMMMMMMMMWWNNWWMMMMWWNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNXl.:l.,0WWWWWWWMMMMM\r\nMMMMMMWNNWWW0,.lc.lNMMMMMMMMMMMMMMWWNNWWMMMMWWNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNXl.:l.,0WNWWNWMMMMMM\r\nMMMMMMWNNNNW0,.lc.cNMMMMMMMMMMMMWWNNWWMMMMWWNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNXl.:l.,0WNWNNWMMMMMM\r\nWWWWWWWWWWWW0,.lc.cNMMMMMMMMMWWNNNWWMMMMWNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNXc.:l.,0WWWWWWWWWWWW\r\nNNWWNWWMMMMM0,.lc.cNMMMMMMMMWWNNWMMMMMWWNNNNNWNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNWXl.:l.,0MMMMMWWNNWWW\r\nNNNNNWWMMMMM0,.;,.,looooooooooooooooooooooooooooooooooooooooooooooooooooooooooool,.,;.,0MMMMMWWNNWWW\r\nWWWWWWWWWWWW0,.,;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;,,;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;:,.;0WWWWWWWWWWWW\r\nMMMMMMWWWNNW0,.okkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkl;,,;okkkkkkkkkkkkkkkkkkkkkkkkkkkkkkko.,0WNWWWWMMMMMM\r\nMMMMMMWNWWNW0,.lkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkxc...'lkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkko.,0WNWNNWMMMMMM\r\nMMMMMWWWWWNWK:.;oooooooooooooooooooooooooooooool:;:clooooooooooooooooooooooooooooooo;.:KWNWWWWMMMMMM\r\nWWWWWWWMMMWWW0l;;;;;;;;;;;;;;;;;;;;;;;;;;,..',,,,,,,,,,'..,;;;;;;;;;;;;;;;;;;;;;;;;;;l0WWWMMWWWWWWWW\r\nWNWWNWWMMMMMWWNXXXXXNNNNNNXXXXXXXNNNNNNXX0:.:xxxxxxxxxx:.;0NXNNNNNNXXXXXXXNNNNNNNXXXNNWWMMMMMWWNNWWW\r\nNNWWNWWMMMMMWWNNNNWWMMMMMWWNNNWWWWMMMMMWWK:.ckkkkkkkkkkc.:KWWMMMMMWWNNNNWWMMMMMMWNNWNNWWMMMMMWWNWWWW\r\nWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWKxooool'.,::::::::::,.'looodONWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW\r\nMMMMMMWWWWNNWMMMMMMWNNWNNWWMMMMMWW0;.....'...'..''..'..'........oXWWMMMMMWWNNWWWWMMMMMMWWWWNNWMMMMMM\r\nMMMMMMWNWWNNWMMMMMMWNNWWWWWMMMMMWWx..,;,;;;;,;;,;;;;;;;;,;;,,;'.;KWWMMMMMWWNWWNNWMMMMMMWNWWNNWMMMMMM\r\nWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWKc'..........................,xNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW\r\nNNNWNWWMMMMMWWWWWWWWMMMMMMWNNWWNWWWN0kkkxxxxxxkkkkkkkkxxxxxxxkOKWMMWNNWWNWMMMMMMWNNNWNWWMMMMMWWWWNNN\n");
                //Recoger la respuesta del usuario
                string objeto = Console.ReadLine();
                string objetoOrdenador = objeto.ToLower();
                //Si pasas la prueba
                if (objetoOrdenador == "usb" && USB == 1)
                {
                    Console.WriteLine("Insertas el USB y se abre una carpeta con 4 numeros 3872.");

                }
                //Pistas
                else if (objetoOrdenador == "pista" && pista8 == 0)
                {
                    Console.WriteLine("Pista 1: Tendras que abrir algun archivo.");
                    pista8 = 1;
                }
                else if (objetoOrdenador == "pista" && pista8 == 1)
                {
                    Console.WriteLine("Pista 2: Tendras que meter un USB.");
                    pista8 = 2;
                }
                else if (objetoOrdenador == "pista" && pista8 == 2)
                {
                    Console.WriteLine("Pista 3: Mete el nombre de 'Mario' en el candado del cajon de la mesa, ahi obtendras un USB que podras usar escribiendo 'USB'.");
                }
                //Volver
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;
        //Lámpara
        case 9:
            do
            {
                //Descripción
                Console.Clear();
                Console.Write("\u001bc\x1b[3J");
                Console.WriteLine("La lámpara parece importante, intentas encenderla pero no pasa nada.");
                //Escenario
                Console.WriteLine("\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWMMMMMMMMMMMMMMMWWMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWWWWWWWWWWWWWMMMMWMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMWMMMMMMMMMMMMMMMMMWWX000OOOOOOOOOOOOOOOOO0KWMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMN0kxkkOO000KKKKKK00OOkdooONMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMWN0xkkkxxkkkkkkkkkxxxddddoloONWMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMWW0xxOOOkkkkxxxxxxxdddddddolooOWWMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMWWKkxkOOOkxxxxxxxxxxxdddddddoood0WMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMWKkxkOOOOkxxxxkxxxxxxdddddodoooldKWMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMWWMWKkxkOOOOOkxxxxxxxxxxxdddddodddolodKWMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMWMWXkxkkOOOOOkxxxxxxxxxxxxddddddddoooldKWMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMWXkxkOOOOOOkkxxxxxxxxxxxxdddddddodolooxKWMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMW0xxkOOOOOOkxxxxxxxxxxxxxddddddddddoollOWMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMWXK0OOOkkkkkxxxxxxxxxxxkxxddodddddxxxO0XWMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMWWWNXXXKK000000OkxxdxO0OOOO00KKXXNWWWMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMWMMWWMMMMMMMWWN0kkxONWWMMMMWWMMMMMMMMMMMMMMMMMMMWMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMWMMMMMMMMMWNKOOxONWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKOkdOWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKOkdOWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKOkdOWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKOkdOWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKOkdOWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKOkdOWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKOkdOWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMWWMMMMMMMMMMMMMMMMMMMMMMMMMMWKOkdOWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKOkxOWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKOOxOWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWMMMMWKOOxOWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKOOxOWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWKOOxOWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWMMWNKOOxOWMMMMMMWMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWWNNXKOOdkXNNWWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMWNX00OOkkkkxxOOxoxkkkOO000KNWWMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMWNX0kdxxdxxxxdxkOdoxxxxdxxxxxkOKNWMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMWN00K0kxxxxxxxxdxxddxxxxxxxxxkkxkXWWMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMWMWKOOOOOOOOOkkOkkkkkkkkkkkkkkkkOKWMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMWNXK000OOOOOOOOOOOOOOOO0KKXNWMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWWWWWWWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\nMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\r\n");
                //Recoger respuesta del usuario
                string objeto = Console.ReadLine();
                string objetoLampara = objeto.ToLower();
                //Si pasas la prueba
                if (objetoLampara == "bombilla" && bombilla == 1)
                {
                    Console.WriteLine("Colocas la bombilla y la lampara empieza a emitir una luz ultravioleta, te fijas en el papel que antes estaba vacio y ves un numero escrito '9'");
                }
                //Pistas
                else if (objetoLampara == "pista" && pista9 == 0)
                {
                    Console.WriteLine("Pista 1: Le falta la bombilla");
                    pista9 = 1;
                }
                else if (objetoLampara == "pista" && pista9 == 1)
                {
                    Console.WriteLine("Pista 2: La bombilla deberia estar guardada en algun lugar");
                    pista9 = 2;
                }
                else if (objetoLampara == "pista" && pista9 == 2)
                {
                    Console.WriteLine("Pista 3: Abre la caja fuerte y encontraras la bombilla ahi.");

                }
                //Volver
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;
        //Salida
        case 10:
            do
            {
                //Descripción.
                Console.Clear();
                Console.Write("\u001bc\x1b[3J");
                Console.WriteLine("La puerte para salir parece estar cerrada con un candado de 3 numeros, cual sera la combincacion correcta para salir?");
                //Escenario
                Console.WriteLine("\n,,,,,,;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;,,,,;;;,,,\r\n,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,\r\n,,',,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,\r\n,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,\r\n,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,\r\n,,,,,,,,,,,,,;,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,\r\n,,,,,,,,,,,,,,,,,''',,,,,,,,,,'''',,,,,,,,,,,,,,,,\r\n,,,,,,,,,,''''',,,,,;;;;;;;;;,,,,,,,'''',,,,,,,,,,\r\n,,,,,,,,,,'',,,,;;;;;;;;;;;;;;;;;;,,,,'',,,,,,,,,,\r\n,,,,,,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,,,,,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,,,,,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,,,,,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,,,,,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,,,,,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,,,,,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,,,,,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,,,,,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,,,,,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,,,,,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,,,,,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,,,,,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,,,,,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,,,,,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,',;,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,,,,,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,,,,,,,,,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n;,,,cll:;,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n;,';col:;,'',,;;;;;;;;;;;;;;;;;;;;;;,,'',,,,,,,,,,\r\n,,,,;;;,,,'',,,,,,,,,,,,,,,,,,,,,,,,,,'',,,,,,,,,,\r\n,,,,,,,,,,'''''''''''''''''''''''''''''',,,,,,,,,,\r\n,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,\r\n,,,,,,,,,,,,',,',,,,,,,,,,,,,,,,,'',,'',,,,,,,,,,,\r\n,,,,,,,,,,'',,,,,,,,,,,,,,,,,,,,,,,,,,'',,,,,,,,,,\r\n,,,,,,,,,,',,;;;;;;;;;;;;;;;;;;;;;;;;,,',,,,,,,,,,\r\n,,,,,,,,,,',,;;;;;;;;;;;;;;;;;;;;;;;,,,',,,,,,,,,,\r\n,,,,,,,,,,',,;;;;;;;;;;;;;;;;;;;;;;;;,,',,,,,,,,,,\r\n,,,,,,,,,,',,;;;;;;;;;;;;;;;;;;;;;;;;,,',,,,,,,,,,\r\n,,,,,,,,,,',,;;;;;;;;;;;;;;;;;;;;;;;;,,',,,,,,,,,,\r\n,,,,,,,,,,',,;;;;;;;;;;;;;;;;;;;;;;;;,,',,,,,,,,,,\r\n,,,,,,,,,,',,;;;;;;;;;;;;;;;;;;;;;;;;,,',,,,,,,,,,\r\n,,,,,,,,,,'',,,,,,,,,,,,,,,,,,,,,,,,,,'',,,,,,,,,,\r\n,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,\r\n,,,,,,,,,,,,;,,,,,,,,,,,,,,,,,,,,;;;,,,;,,,,,,,,,,\r\n,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,\r\n,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,\r\n");
                //Recoger lo que dice el usuario
                string objeto = Console.ReadLine();
                string objetoSalida = objeto.ToLower();
                //Si acierta el código.
                if (objetoSalida == "639")
                {
                    Console.WriteLine("Has introducido los 3 numeros y el candado se ha abierto. Ya puedes salir");
                    done = true;
                }
                //Pistas
                else if (objetoSalida == "pista" && pista0 == 0)
                {
                    Console.WriteLine("Pista 1: Los numeros deben estar por la habitacion");
                    pista0 = 1;
                }else if (objetoSalida == "pista" && pista0 == 1){
                    Console.WriteLine("Pista 2: Deberias hacer el resto de puzles primero");
                    pista0 = 2;
                }else if (objetoSalida == "pista" && pista0 == 2)
                {
                    Console.WriteLine("Pista 3: Uno de los numeros esta en el cajon.");
                }
                //Volver
                Console.WriteLine("(Pulse Enter)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;
        //si no pone ningún número de los que hay.
        default:
            //Poner a pensar al jugador.
            Console.WriteLine("Porque estas aqui?...");
            Console.WriteLine("No te decides en que hacer?");
            Console.WriteLine("Piensa un poco.");
            Thread.Sleep(5000);
            //Go back to top of question
            break;
    }
//Si aciertas el código sales del bucle
} while (!done);
//Mensaje de victoria
Console.WriteLine("ENHORABUENA!!! Has escapado!!!");
//stopwatch stop
watch.Stop();
var elapsedMs = watch.ElapsedMilliseconds;

if (elapsedMs < 60000)
{
    var tiempoSeg = elapsedMs / 1000;
    Console.WriteLine("Tu tiempo final es de " + elapsedMs);
}else if (elapsedMs >= 60000){
    var tiempoMin = elapsedMs / 60000;
    int minutos = (int) tiempoMin;

    var tiempoSeg = (elapsedMs - (tiempoMin * 60000))/ 1000;
    Console.WriteLine("Tu tiempo final es de " + minutos + "min " + tiempoSeg +"seg.");
}



//Puntuaje final recuento
int puntuacion = 10;
int penalizaciones = 0;

penalizaciones = pista1 + pista2 + pista3 + pista4 + pista5 + pista6 + pista7 + pista8 + pista9 + pista0;
puntuacion = puntuacion - (penalizaciones/2);
//Mostrar puntuaje final
Console.WriteLine("Tu puntuacion es de " + puntuacion +" sobre 10");