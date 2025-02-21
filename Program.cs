using System;

class Program {
    static void Main() {
        // Crear jugadores
        Jugador jugador1 = new Jugador("Juan", 'X');
        Jugador jugador2 = new Jugador("Ana", 'O');

        // Mostrar información de los jugadores
        Console.WriteLine("Información de los Jugadores:");
        jugador1.MostrarInformacion();
        jugador2.MostrarInformacion();
        Console.WriteLine();

        // Crear juego de TresEnRaya
        TresEnRaya juego = new TresEnRaya(jugador1, jugador2);

        // Mostrar información del juego
        Console.WriteLine("Información del Juego:");
        juego.MostrarInformacion();
        juego.MostrarTablero();
        Console.WriteLine();

        

 

        // Mostrar la información del juego principal y sus juegos de mesa
        Console.WriteLine("Información del Juego Principal:");
       
        Console.WriteLine();

        // Mantener la consola abierta
        Console.WriteLine("Presiona ENTER para salir...");
        Console.ReadLine();
    }
}