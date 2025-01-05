﻿// See https://aka.ms/new-console-template for more information
using System.Drawing;
//Introducir las reglas del juego
ConsoleKey continuar;
do
{
    Console.WriteLine("IMPORTANTE LEER ANTES DE EMPEZAR");
    Console.WriteLine("Esto es un scape room en donde tendrás que superar ciertas pruebas para conseguir los dígitos de la clave de la puerta cerrada con un candado. \r\n");
    Console.WriteLine("Para superar estás pruebas, puedes pedir un total de 3 pistas en cada prueba.\nLa primera pista no tendrá penalización, pero las siguientes dos sí.\r\n");
    Console.WriteLine("Las soluciones  van a ser únicamente de responder con numeros o una palabra máximo. \n");
    Console.WriteLine("Algunas pruebas te dan objetos que vas a tener que utilizar más adelante. \nEstos objetos se utilizan escribiendo el nombre del objeto en las demás pruebas.\r\n");
    Console.WriteLine("Si tienes mala memoria recomendamos apuntar los numeros y objetos que consigas durante la partida. \n");


    //ClearScrean despues de dejar al usuario darle a siguiente y poner la pantalla inicial del scaperoom
    Console.WriteLine("Pulsa 'Enter' para comenzar.");

    continuar = Console.ReadKey().Key;
   
} while (continuar != ConsoleKey.Enter);


ConsoleKey volver;
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
do
{
    Console.Clear();
    Console.WriteLine("Estas en un despacho donde te llaman la atención unos cuantos objetos. ¿A cuál decides ir? \n1 - Cajón con cerradura \n2 - Cuadro  \n3 - Globo terráqueo \n4 - Mesa \n5 - Estanteria \n6 - Chimenea \n7 - Caja fuerte \n8 - Ordenador  \n9 - Lampara  \n10 - Salida");

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
                }else if (objetoCuadro == "pista" && pista2 == 0)
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

                if (llaveAvion == 1 && objetoGlobo == "avion"|| llaveAvion == 1 && objetoGlobo == "avión")
                {
                    Console.WriteLine("Sitúas el avión en el carril y se activa un mecanismo que abre el globo por la mitad. \nDentro del globo ves que hay  un 3 escrito en un papel.");
                }else if (objetoGlobo == "pista" && pista3 == 0)
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
                Console.WriteLine("Te acercas a la mesa y ves un cajon cerrado con un candado de 5 letras.");
                string objeto = Console.ReadLine();
                string objetoMesa = objeto.ToLower();
                if (objetoMesa == "mario")
                {
                    Console.WriteLine("Abres el cajon y encuentras un USB. Parece que puedes usarlo en el ordenador de aqui. \n (Has obtenido USB)");
                    USB = 1;
                }else if (objetoMesa == "pista" && pista4 == 0)
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
                }else if (objetoEstanteria == "pista" && pista5 == 0)
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
                    Console.WriteLine("Pista 3: Busca en el cuadro unas cerillas y luego vuelve a la chimenea y escribe “encender”.");
                }
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;
        case 7:
            do
            {
                Console.Clear();
                Console.WriteLine("Te acercas a la caja fuerte y ves que se abre con un pin de 4 numeros.");
                string objeto = Console.ReadLine();
                string objetoCaja = objeto.ToLower();
                if (objetoCaja == "3872")
                {
                    Console.WriteLine("Abres la caja fuerte y encuentras una bombilla morada y un trozo de papel, pero parece no parece tener nada escrito");
                    bombilla = 1;

                }else if (objetoCaja == "pista" && pista7 == 0)
                {
                    Console.WriteLine("Pista 1: El pin deberia estar guardado en algun sitio");
                    pista7 = 1;
                }else if (objetoCaja == "pista" && pista7 == 1)
                {
                    Console.WriteLine("Pista 2: Seguramente este en el ordenador o algun sitio parecido");
                    pista7 = 2;
                }else if (objetoCaja == "pista" && pista7 == 2){
                    Console.WriteLine("Pista 3: Abre el cajon de la mesa donde encontraras un USB, conectalo al ordenador y te saldra la combinacion");
                }else
                {
                    Console.WriteLine("parece que ese no es el pin, son 4 dijitos, pero cuales...");
                }
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;
        case 8:
            do
            {
                Console.Clear();
                Console.WriteLine("Solo hay una aplicacion en el ordenador 'Super Mario Bros.' pero parece no ejecutarse.");
                string objeto = Console.ReadLine();
                string objetoOrdenador = objeto.ToLower();
                if (objetoOrdenador == "usb")
                {
                    Console.WriteLine("Insertas el USB y se abre una carpeta con 4 numeros 3872.");

                }
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
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;
        case 9:
            do
            {
                Console.Clear();
                Console.WriteLine("La lampara parece importante, intentas encenderla pero no pasa nada.");
                string objeto = Console.ReadLine();
                string objetoLampara = objeto.ToLower();
                if (objetoLampara == "bombilla" && bombilla == 1)
                {
                    Console.WriteLine("Colocas la bombilla y la lampara empieza a emitir una luz ultravioleta, te fijas en el papel que antes estaba vacio y ves un numero escrito '9'");
                }else if (objetoLampara == "pista" && pista9 == 0)
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
                Console.WriteLine("(Pulse Enter para volver)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;

        case 10:
            do
            {
                Console.Clear();
                Console.WriteLine("La puerte para salir parece estar cerrada con un candado de 3 numeros, cual sera la combincacion correcta para salir?");
                string objeto = Console.ReadLine();
                string objetoSalida = objeto.ToLower();
                if (objetoSalida == "639")
                {
                    Console.WriteLine("Has introducido los 3 numeros y el candado se ha abierto. Ya puedes salir");
                    done = true;
                }
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
                Console.WriteLine("(Pulse Enter)");
                volver = Console.ReadKey().Key;
            } while (volver != ConsoleKey.Enter);
            break;
        default:
            Console.WriteLine("Porque estas aqui?...");
            Console.WriteLine("No te decides en que hacer?");
            Console.WriteLine("Piensa un poco.");
            //Go back to top of question
            break;
    }
} while (!done);
Console.WriteLine("ENHORABUENA!!! Has escapado!!!");
float puntuacion = 10;
float penalizaciones = 0;

penalizaciones = pista1 + pista2 + pista3 + pista4 + pista5 + pista6 + pista7 + pista8 + pista9 + pista0;
puntuacion = puntuacion - (penalizaciones/2);
Console.WriteLine("Tu puntuacion es de " + puntuacion +" sobre 10");