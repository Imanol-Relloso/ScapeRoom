// See https://aka.ms/new-console-template for more information
using System.Drawing;
//Introducir las reglas del juego
ConsoleKey continuar;
do
{
    Console.WriteLine("Esto es un scape room en donde tendrás que superar ciertas pruebas para conseguir los dígitos de la clave del ordenador. \r\n");
    Console.WriteLine("Para superar estás pruebas, puedes pedir un total de 3 pistas en cada prueba.\nLa primera pista no tendrá penalización, pero las siguientes dos sí.\r\n");
    Console.WriteLine("Las soluciones  van a ser únicamente de responder con una letra o una palabra máximo. \nAunque para nombres específicos de más de una palabra se deberá poner varias palabras.\r\n");
    Console.WriteLine("Algunas pruebas te dan objetos que vas a tener que utilizar más adelante. \nEstos objetos se utilizan escribiendo el nombre del objeto en las demás pruebas.\r\n");

    //ClearScrean despues de dejar al usuario darle a siguiente y poner la pantalla inicial del scaperoom
    Console.WriteLine("Pulsa 's' para comenzar.");

    continuar = Console.ReadKey().Key;
   
} while (continuar != ConsoleKey.S);

//Poner la primera habitacion
ConsoleKey volver;
int llave = 0;
int cerillas = 0;
int llaveAvion = 0;
int pista1 = 0;
var done = false;
do
{
    Console.Clear();
    Console.WriteLine("Donde vas a mirar? \n1 - Cajón con cerradura \n2 - Cuadro  \n3 - Globo terráqueo \n4 - Mesa \n5 - Estanteria");

    var input = Console.ReadLine();

    int.TryParse(input, out var wants);

    switch (wants)
    {
        case 1:
            
            do
            {
                Console.Clear();
                Console.WriteLine("Te acercas al cajón que parece que requiere una llave para abrirlo.");
                string objeto = Console.ReadLine();
                string objetoCajon = objeto.ToLower();
               
                if (llave == 1 && objetoCajon == "llave")
                {
                    Console.WriteLine("Has logrado abrir el cajón. \nParece que hay un papel. En él pone un 6.");
                }else if (objetoCajon == "pista" && pista1 == 0)
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
                else
                {
                    Console.WriteLine("Intentas abrirlo a la fuerza pero parece imposible.");
                }

                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
                
            } while (volver != ConsoleKey.Enter);
            break;
        case 2:
            do
            {
                Console.Clear();
                Console.WriteLine("Te mueves al cuadro que hay al fondo de la habitación. Parece un cuadro algo viejo.");
                string objeto = Console.ReadLine();
                string objetoCuadro = objeto.ToLower();

                if(objetoCuadro == "mover")
                {
                    Console.WriteLine("Mueves el cuadro y hay una cajetilla de cerillas.\n (Has obtenido cerillas)");
                    cerillas = 1;
                }
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            Console.WriteLine("The line");
            break;
        case 3:
            do
            {
                Console.Clear();
                Console.WriteLine("Miras de cerca el globo terráqueo y te das cuenta de que hay un carril marcado en el que parece que se puede colocar un objeto. \nMiras más atentamente y ves que hay una ubicación marcada: Grecia.");
                string objeto = Console.ReadLine();
                string objetoGlobo = objeto.ToLower();

                if (llaveAvion == 1 && objetoGlobo == "avion")
                {
                    Console.WriteLine("Sitúas el avión en el carril y se activa un mecanismo que abre el globo por la mitad. \nDentro del globo ves que hay 3 escrito en un papel.");
                }
                else
                {
                    Console.WriteLine("Intentas abrir el globo a la fuerza, pero parece imposible.");
                }
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;
        case 4:
            do
            {
                Console.Clear();
                Console.WriteLine("Te acercas a la mesa y ves un cajon un poco abiero.");
                string objeto = Console.ReadLine();
                string objetoMesa = objeto.ToLower();
                if (objetoMesa == "abrir" || objetoMesa == "mirar")
                {
                    Console.WriteLine("Abres el cajon y encuentras una llave. Parece que puedes usarlo en alguna cerradura de por aqui. \n (Has obtenido una llave)");
                    llave = 1;
                }
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;
        case 5:
            do
            {
                Console.Clear();
                Console.WriteLine("Te acercas a la estantería y te fijas que todos los libros son de distintos países del mundo. \nPero no ves nada más fuera de lo común.");
                string objeto = Console.ReadLine();
                string objetoEstanteria = objeto.ToLower();
                if (objetoEstanteria == "grecia")
                {
                    Console.WriteLine("Abres el libro de Grecia y cae un avión de metal al suelo. \nDecides guardarte el avión por si te sirve en algún futuro.");
                    llaveAvion = 1;
                }
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;
        case 6:
            do
            {
                Console.Clear();
                Console.WriteLine("Te acercas a la chimenea. Crees que hace algo de frío en la habitación y que necesitas algo para encender la chimenea.");
                string objeto = Console.ReadLine();
                string objetoChimenea = objeto.ToLower();
                if (objetoChimenea == "encender" && cerillas == 1)
                {
                    Console.WriteLine("Vas a encender la chimenea y encuentras una llave debajo de los troncos. \nParece que te será útil para un futuro y decides cogerla.");
                    llave = 1;
                }
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;
        case 0:
            done = true;
            break;
       
        default:
            Console.WriteLine("Then why are you here...");
            Console.WriteLine("Because you cant decide?");
            Console.WriteLine("That must be it");
            //Go back to top of question
            break;
    }
} while (!done);
