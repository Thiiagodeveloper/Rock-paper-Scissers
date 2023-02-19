///////////Juego de piedra papel y tijera////////////

//Instancia para crear objeto de tipo Random
System.Random rand = new System.Random();

//Variables
String jugador; // Jugador principal 
String star_Game = "menu"; // variable que contiene el inicio del juego 
String result_Game = ""; // Variable que contiene el resultado final

//Variable tipo array o matriz, donde almacenamos las opciones para escoger por la maquina.
string[] optionsCpu = { "rock", "paper", "scissors" };

//Condicion = Bucle
while (true)
{
    //Variable iniciacilizada a vacio
    jugador = "";

    //Creando variable y Genereamos el random, pasandondole como argumento la matriz que creamos, accediedo al Length que basicamente nos devuelve la longitud en caracteres del campo,osea nos devuelve toda la palabra
    int opIndex = rand.Next(optionsCpu.Length);

    //Creando y inicializando la variable cpu, que contiene el ramdon de la matriz
    string cpu = (optionsCpu[opIndex]); // Jugador Secundario(la maquina)
    
    
    switch (star_Game)
    {
        //#caso 1 = MENU
        case "menu":
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Do you want to Play, rock-paper-scissors?");
            Console.WriteLine("Write yes to play");
            star_Game = Console.ReadLine();
            break;

        //#caso 2 = Comenzar a Jugar
        case "yes":
            do
            {
                Console.WriteLine("\nWrite rock-paper-scissors\n");
                jugador = Console.ReadLine();
            } while (jugador == "Nada");

            //Condiciones del juego ((YA POR CULTURA DEBEN SABER EL JUEGO)) JAJA 
            if (jugador == cpu) // Empate si es escogen la misma opcion
            {
                result_Game = "Empate\n";
                    star_Game = "menu";
            }
            else if (jugador == "rock" && cpu == "paper") // Roca vs papel 
            {
                result_Game = "Game over, paper win to rock\n";
                    star_Game = "menu";
            }
            else if (jugador == "paper" && cpu == "scissors")// Papel vs Tijeras
            {
                result_Game = "Game over, scissors win to paper\n";
                    star_Game = "menu";
            }
            else if (jugador == "scissors" && cpu == "rock") // Tijeras vs Roca
            {
                result_Game = "Game over, rock win to scissors\n";
                    star_Game = "menu";
            }
            else // En tal caso de ninguna condicion se cumpla, el jugador principal GANA
            {
                result_Game = " You Win!, congratulations!\n";
                    star_Game = "menu";
            }
            //Imprime el resultado
            Console.WriteLine(result_Game);

            //Mostramos cual opcion escogio la maquina al finalizar, asi sabemos si fue correcto
            Console.WriteLine($"The cpu option was: {cpu}");
            break;

            //Si no ingresan bien los valores arrojara valor invalido
        default:
            Console.WriteLine("Invalid value");
            break;
    }
}








