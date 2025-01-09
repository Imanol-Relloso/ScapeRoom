// See https://aka.ms/new-console-template for more information
using System.Drawing;
//Introducir las reglas del juego.
ConsoleKey continuar;
do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.DarkRed;


    Console.WriteLine("IMPORTANTE LEER ANTES DE EMPEZAR");
    Console.ResetColor();
    Console.WriteLine("Esto es un scape room en donde tendrás que superar ciertas pruebas para conseguir los dígitos de la clave de la puerta cerrada con un candado. \r\n");
    Console.WriteLine("Para superar estás pruebas, puedes pedir un total de 3 pistas en cada prueba.\nLa primera pista no tendrá penalización, pero las siguientes dos sí.\r\n");
    Console.WriteLine("Las soluciones  van a ser únicamente de responder con numeros o una palabra máximo. \n");
    Console.WriteLine("Algunas pruebas te dan objetos que vas a tener que utilizar más adelante. \nEstos objetos se utilizan escribiendo el nombre del objeto en las demás pruebas.\r\n");
    Console.WriteLine("Si tienes mala memoria recomendamos apuntar los numeros y objetos que consigas durante la partida. \n");


    //ClearScrean despues de dejar al usuario darle a siguiente y poner la pantalla inicial del scaperoom
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine("Pulsa 'Enter' para comenzar.");

    continuar = Console.ReadKey().Key;
   
} while (continuar != ConsoleKey.Enter);

// stopwatch
var watch = System.Diagnostics.Stopwatch.StartNew();

ConsoleKey volver;

//Inicializar los objetos y las pistas.
bool llave = false;
bool cerillas = false;
bool llaveAvion = false;
bool USB = false;
bool bombilla = false;
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
    Console.ResetColor();
    Console.Clear();
    Console.Write("\u001bc\x1b[3J");
    Console.WriteLine("Estas en un despacho donde te llaman la atención unos cuantos objetos. ¿A cuál decides ir? \n1 - Cajón con cerradura \n2 - Cuadro  \n3 - Globo terráqueo \n4 - Mesa \n5 - Estanteria \n6 - Chimenea \n7 - Caja fuerte \n8 - Ordenador  \n9 - Lampara  \n10 - Salida");
    var input = Console.ReadLine();

    int.TryParse(input, out var wants);

    switch (wants)
    {
        //Elige ir hacia el cajón con cerradura
        case 1:
            
            do
            {
                //Presentación de la prueba
                Console.ResetColor();

                Console.Clear();
                Console.Write("\u001bc\x1b[3J");
                Console.WriteLine("Te acercas al cajón que parece que requiere una llave para abrirlo.");
                //Escenario
                Console.WriteLine("    /\r\n   /\r\n  /____________________\r\n  |________  __________\r\n  /_____  /||   |\r\n |\".___.\"| ||   |\r\n |_______|/ |   |\r\n  || .___.\"||  /\r\n  ||_______|| /\r\n  |_________|/");
                //Recoger lo que dice el usuario
                string objeto = Console.ReadLine();
                string objetoCajon = objeto.ToLower();
                
                //si pasa la prueba
                if ((llave) && (objetoCajon == "llave"))
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
                    pista1 = 3;
                }
                //Si no pasa la prueba
                else
                {
                    Console.WriteLine("Intentas abrirlo a la fuerza pero parece imposible.");
                }
                //Volver a la habitación o no
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("(Pulse Enter para volver)"); 
                Console.ResetColor();
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
                Console.WriteLine(" ________________________\r\n|.----------------------.|\r\n||                      ||\r\n||       ______         ||\r\n||     .;;;;;;;;.       ||\r\n||    /;;;;;;;;;;;\\     ||\r\n||   /;/`    `-;;;;; . .||\r\n||   |;|__  __  \\;;;|   ||\r\n||.-.|;| e`/e`  |;;;|   ||\r\n||   |;|  |     |;;;|'--||\r\n||   |;|  '-    |;;;|   ||\r\n||   |;;\\ --'  /|;;;|   ||\r\n||   |;;;;;---'\\|;;;|   ||\r\n||   |;;;;|     |;;;|   ||\r\n||   |;;.-'     |;;;|   ||\r\n||'--|/`        |;;;|--.||\r\n||;;;;    .     ;;;;.\\;;||\r\n||;;;;;-.;_    /.-;;;;;;||\r\n||;;;;;;;;;;;;;;;;;;;;;;||\r\n||jgs;;;;;;;;;;;;;;;;;;;||\r\n'------------------------'");
                //Recoger lo que dice el usuario
                string objeto = Console.ReadLine();
                string objetoCuadro = objeto.ToLower();
                //Si pasa la prueba
                if(objetoCuadro == "mover")
                {
                    Console.WriteLine("Mueves el cuadro y hay una cajetilla de cerillas.\n (Has obtenido cerillas)");
                    cerillas = true;
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
                    pista2 = 3;
                }
                //Para salir de la habitación
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("(Pulse Enter para volver)");
                Console.ResetColor();
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
                Console.WriteLine("            ___,\r\n       _.-'` __|__\r\n     .'  ,-:` \\;',`'-,\r\n    /  .'-;_,;  ':-;_,'.\r\n   /  /;   '/    ,  _`.-\\\r\n  |  | '`. (`     /` ` \\`|\r\n  |  |:.  `\\`-.   \\_   / |\r\n  |  |     (   `,  .`\\ ;'|\r\n   \\  \\     | .'     `-'/\r\n    \\  `.   ;/        .'\r\n     '._ `'-._____.-'`\r\n        `-.____|\r\n          _____|_____\r\n         /___________\\");
                //Recoger lo que dice el usuario
                string objeto = Console.ReadLine();
                string objetoGlobo = objeto.ToLower();
                //Si pasa la prueba
                if ((llaveAvion) && (objetoGlobo == "avion")|| (llaveAvion) && (objetoGlobo == "avión"))
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
                    pista3 = 3;
                }
                //Si no pasa la prueba
                else
                {
                    Console.WriteLine("Intentas abrir el globo a la fuerza, pero parece imposible.");
                }
                //Volver atrás
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("(Pulse Enter para volver)");
                Console.ResetColor();
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
                Console.WriteLine("              .........\r\n            .'------.' |\r\n           | .-----. | |\r\n           | |     | | |\r\n         __| |     | | |;. _______________\r\n        /  |*`-----'.|.' `;              //\r\n       /   `---------' .;'              //\r\n /|   /  .''''////////;'               //\r\n|=|  .../ ######### /;/               //|\r\n|/  /  / ######### //                //||\r\n   /   `-----------'                // ||\r\n  /________________________________//| ||\r\n  `--------------------------------' | ||\r\n  /_____  /||   |           | ||     `\"\"'\r\n |\".___.\"| ||   |           | ||     \r\n |_______|/ |   |           | ||     \r\n  || .___.\"||  /            | ||\r\n  ||_______|| /             | ||\r\n  |_________|/              `\"\"'\r\n   ");
                //Recoger lo que dice el usuario
                string objeto = Console.ReadLine();
                string objetoMesa = objeto.ToLower();
                //Si supera la prueba
                if (objetoMesa == "mario")
                {
                    Console.WriteLine("Abres el cajon y encuentras un USB. Parece que puedes usarlo en el ordenador de aqui. \n (Has obtenido USB)");
                    USB = true;
                }
                //Pistas
                else if (objetoMesa == "pista" && pista4 == 0)
                {
                    Console.WriteLine("Parece que un nombre puede entrar en ese candado");
                    pista4 = 1;
                }else if (objetoMesa == "pista" && pista4 == 1)
                {
                    Console.WriteLine("Tiene que haber un nombre importante por la habitacion.");
                    pista4 = 2;
                }else if (objetoMesa == "pista" && pista4 == 2)
                {
                    Console.WriteLine("Intentas abrir el cajon a la fuerza, pero parece imposible.");
                    pista4 = 3;
                }
                //Volver
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("(Pulse Enter para volver)");
                Console.ResetColor();
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
                Console.WriteLine("        _________________________________________________________\r\n       ||-------------------------------------------------------||\r\n       ||.--.    .-._                        .----.             ||\r\n       |||==|____|G|E|___            .---.___|\"\"\"\"|_____.--.___ ||\r\n       |||  |====|R|S|xxx|_          |+C+|=-=|_  _|-=+=-|==|---|||\r\n       |||  |    |E|P| U | \\         | H |   |_\\/_|Monte|  | P |||\r\n       |||  |    |C|A| S |\\ \\   .--. | I |=-=|_/\\_|-=+=-|  | E |||\r\n       |||  |    |I|Ñ| A |_\\ \\_( oo )| N |   |    |Negro|  | R |||\r\n       |||==|====|A|A|xxx|  \\ \\ |''| |+A+|=-=|\"\"\"\"|-=+=-|==| Ú |||\r\n       ||`--^----'-^-^---'   `-' \"\"  '---^---^----^-----^--^---^||\r\n       ||-------------------------------------------------------||\r\n       ||-------------------------------------------------------||\r\n       ||               ___                   .-.__        .---.||\r\n       ||              |=A=| .---.   __   .---|T|XX|-----._|^^^|||\r\n       ||         ,  /(| U |_| I |__|''|__|:x:|E|  |<(*)>|C| I |||\r\n       ||      _a'{ / (|=S=|+| N |++|  |==|   |R|  | FIL |O| R |||\r\n       ||      '/\\\\/ _(|=T=|-| D |  |''|  |:x:|U|  | IPI |R| Á |||\r\n       ||_____  -\\{___(| R |-| I |  |  |  |   |E|  | NAS |E| N |||\r\n       ||       _(____)|=I=|+| A |UK|''|==|:x:|L|XX|<(*)>|A|^^^|||\r\n       ||              `---^-^---^--^--'--^---^-^--^-----^-^---^||\r\n       ||-------------------------------------------------------||\r\n       ||_______________________________________________________||");
                //Recoger respuesta de usuario
                string objeto = Console.ReadLine();
                string objetoEstanteria = objeto.ToLower();
                //Si acierta el libro
                if (objetoEstanteria == "grecia")
                {
                    Console.WriteLine("Abres el libro de Grecia y cae un avión de metal al suelo. \nDecides guardarte el avión por si te sirve en algún futuro.");
                    llaveAvion = true;
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
                    pista5 = 3;
                }
                //Volver
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green; 
                Console.WriteLine("(Pulse Enter para volver)");
                Console.ResetColor();
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
                Console.WriteLine("\n               |(r)|               ._.\r\n       ________|...|_______________)_(________\r\n      {___________________________________cgmm}\r\n      |__|___o==o___|_O===O___|xxxx|___,--.|___\r\n      ____|__|  |_|___|   |__|_|  |__|_|  |__|_\r\n      |__|___|  |____||   |_|__`.  \\|__|  |_|__\r\n      _|___|_`.  \\|___|   `._|___`-'__.'  ;__|_\r\n      __|___|__`._)_|_`.    :___|___|<._/'__|__\r\n      |__|__|__|__|___|_`.__;_|___|___|___|___|\r\n      __|____|__|___|___|___|___|__|_____|__|__\r\n      _|___|___|___|_|__|____|___|___|___|___|_\r\n      __|___|___.---\"\"\"'______`\"\"\"---.__|___|__\r\n      _|__|___O---\"\"\"\"\"\"      \"\"\"\"\"\"---O__|____\r\n      ___|__|__]   A  A  A  A  A  A   [__|___|_\r\n      |___|__|_]   |  |  |  |  |  |   [___|___|\r\n      __|___|__] --|--|--|--|--|--|-- [__|__|__\r\n      _|___|___]   |  |  |  |  |  |   [_|__|___\r\n      ___|___|_]___|__|__|__|__|__|___[__|___|_");
                //Recoger la respuesta del usuario
                string objeto = Console.ReadLine();
                string objetoChimenea = objeto.ToLower();
                //Si pasa la prueba
                if (objetoChimenea == "cerillas" && (cerillas))
                {
                    Console.WriteLine("Vas a encender la chimenea y encuentras una llave debajo de los troncos. \nParece que te será útil para un futuro y decides cogerla.");
                    llave = true;
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
                    pista6 = 3;
                }
                //Volver
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green; 
                Console.WriteLine("(Pulse Enter para volver)");
                Console.ResetColor();
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
                Console.WriteLine("Te acercas a la caja fuerte y ves que se abre con un pin de 4 dígitos.");
                //Escenario
                Console.WriteLine("\r\n     .---------.\r\n    / .-------. \\\r\n   / /         \\ \\\r\n   | |         | |\r\n  _| |_________| |_\r\n.' |_|         |_| '.\r\n'._____ _____ _____.'\r\n|     .'_____'.     |\r\n'.__.'.'     '.'.__.'\r\n'.__  | _____ |  __.'\r\n|   '.'._____.'.'   |\r\n'.____'._____.'____.'\r\n'._________________.'");
                //Recoger la respuesta 
                string objeto = Console.ReadLine();
                string objetoCaja = objeto.ToLower();
                //Si pasa la prueba
                if (objetoCaja == "3872")
                {
                    Console.WriteLine("Abres la caja fuerte y encuentras una bombilla morada y un trozo de papel, pero no parece tener nada escrito");
                    bombilla = true;

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
                    pista7 = 3;
                }
                //Si no acierta el código
                else
                {
                    Console.WriteLine("parece que ese no es el pin, son 4 dijitos, pero cuales...");
                }
                //Volver
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green; 
                Console.WriteLine("(Pulse Enter para volver)");
                Console.ResetColor();
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
                Console.WriteLine("   ._________________.\r\n   |.---------------.|\r\n   || SUPER         ||\r\n   || MARIO         ||\r\n   || BROS.         ||\r\n   ||               ||\r\n   ||               ||\r\n   ||_______________||  \r\n   /.-.-.-.-.-.-.-.-.\\\r\n  /.-.-.-.-.-.-.-.-.-.\\\r\n /.-.-.-.-.-.-.-.-.-.-.\\\r\n/______/__________\\___o_\\ \r\n\\_______________________/\r\n");
                //Recoger la respuesta del usuario
                string objeto = Console.ReadLine();
                string objetoOrdenador = objeto.ToLower();
                //Si pasas la prueba
                if ((objetoOrdenador == "usb") && (USB))
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
                    pista8 = 3;
                }
                //Volver
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green; 
                Console.WriteLine("(Pulse Enter para volver)");
                Console.ResetColor();
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
                Console.WriteLine("         _________\r\n        d         b\r\n       d           b\r\n      d             b\r\n     d               b\r\n    d                 b\r\n     ''':::.....:::'''\r\n            fff\r\n          .'   '.\r\n         ^       ^.'--.\r\n         b       d     ,\r\n          czzzzzd       ..oOo");
                //Recoger respuesta del usuario
                string objeto = Console.ReadLine();
                string objetoLampara = objeto.ToLower();
                //Si pasas la prueba
                if (objetoLampara == "bombilla" && (bombilla))
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
                    pista9 = 3;

                }
                //Volver
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green; 
                Console.WriteLine("(Pulse Enter para volver)");
                Console.ResetColor();
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
                Console.WriteLine(" __________\r\n|  __  __  |\r\n| |  ||  | |\r\n| |  ||  | |\r\n| |__||__| | \r\n|  __  __()|\r\n| |  ||  | |\r\n| |  ||  | |  \r\n| |__||__| |\r\n|__________| ");
                //Recoger lo que dice el usuario
                string objeto = Console.ReadLine();
                string objetoSalida = objeto.ToLower();
                //Si acierta el código.
                if (objetoSalida == "639")
                {
                    Console.WriteLine("Has introducido los 3 numeros y el candado se ha abierto. Ya puedes salir");
                    done = true;
                    //Detener el cronometro interno
                    watch.Stop();
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
                    pista0 = 3;
                }
                //Volver
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green; 
                Console.WriteLine("(Pulse Enter)");
                Console.ResetColor();
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;
        //si no pone ningún número de los que hay.
        default:
            //Poner a pensar al jugador.
            Console.Clear();
            Console.Write("\u001bc\x1b[3J");
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
Console.Clear();
Console.Write("\u001bc\x1b[3J");

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine("ENHORABUENA!!! Has escapado!!!");
Console.ResetColor();

var elapsedMs = watch.ElapsedMilliseconds;

//Pistas que penalizan
if (pista1 != 0) { pista1 = pista1 - 1; }
if (pista2 != 0) { pista2 = pista2 - 1; }
if (pista3 != 0) { pista3 = pista3 - 1; }
if (pista4 != 0) { pista4 = pista4 - 1; }
if (pista5 != 0) { pista5 = pista5 - 1; }
if (pista6 != 0) { pista6 = pista6 - 1; }
if (pista7 != 0) { pista7 = pista7 - 1; }
if (pista8 != 0) { pista8 = pista8 - 1; }
if (pista9 != 0) { pista9 = pista9 - 1; }
if (pista0 != 0) { pista0 = pista0 - 1; }

//Penalización total
int penalizaciones = pista1 + pista2 + pista3 + pista4 + pista5 + pista6 + pista7 + pista8 + pista9 + pista0;

//Sumar 30 segundos por pista usada
elapsedMs = elapsedMs + (penalizaciones * 30000);

if (elapsedMs < 60000)
{
    var tiempoSeg = elapsedMs / 1000;
    Console.WriteLine("Tu tiempo final es de " + tiempoSeg + "seg.");
}else if (elapsedMs >= 60000){
    var tiempoMin = elapsedMs / 60000;
    int minutos = (int) tiempoMin;

    var tiempoSeg = (elapsedMs - (tiempoMin * 60000))/ 1000;
    Console.WriteLine("Tu tiempo final es de " + minutos + "min " + tiempoSeg +"seg.");
}

//Puntuaje final recuento
int puntuacion = 100;
penalizaciones = penalizaciones * 10;

puntuacion = puntuacion - (penalizaciones/2);
//Mostrar puntuaje final
Console.WriteLine("Tu puntuacion es de " + puntuacion +" sobre 100");