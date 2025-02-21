using System;

public class TresEnRaya {
    // Atributos
    public char[,] Tablero { get; set; }
    public Jugador TurnoActual { get; set; }
    public Jugador Ganador { get; set; }
    public Jugador Jugador1 { get; set; }
    public Jugador Jugador2 { get; set; }

    // Constructor
    public TresEnRaya(Jugador jugador1, Jugador jugador2) {
        Tablero = new char[3, 3]; // Inicialización del tablero de 3x3
        Jugador1 = jugador1;
        Jugador2 = jugador2;
        TurnoActual = jugador1; // Empezamos con el jugador1
        Ganador = jugador1; // No hay ganador al inicio
    }

    // Método para mostrar la información del juego
    public void MostrarInformacion() {
        Console.WriteLine($"Jugador 1: {Jugador1.Nombre}, Símbolo: {Jugador1.Simbolo}");
        Console.WriteLine($"Jugador 2: {Jugador2.Nombre}, Símbolo: {Jugador2.Simbolo}");
        Console.WriteLine($"Turno actual: {TurnoActual.Nombre}");
        if (Ganador != null) {
            Console.WriteLine($"Ganador: {Ganador.Nombre}");
        } else {
            Console.WriteLine("No hay ganador aún.");
        }
    }

    // Método para mostrar el tablero
    public void MostrarTablero() {
        Console.WriteLine("Tablero:");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                Console.Write(Tablero[i, j] == '\0' ? "-" : Tablero[i, j].ToString());
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    // Métodos adicionales (vacíos para modelar)
    public void Jugar() {
        // Lógica de juego vacía para modelar
    }

    public bool VerificarGanador() {
        // Lógica para verificar ganador vacía para modelar
        return false;
    }
}

