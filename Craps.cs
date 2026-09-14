namespace CasoJuegoCraps;

public class Craps
{
    // Crea el generador de números aleatorios para usarlo en el método.
    private Random numerosAleatorios = new Random();

    // Enumeración con constantes que representan los tiros clave del primer lanzamiento.
    private enum NombreDados
    {
        DOS_UNO = 2,
        TRES = 3,
        SIETE = 7,
        ONCE = 11,
        DOCE = 12
    }

    // Enumeración con los posibles estados del juego.
    private enum Estado
    {
        CONTINUA,
        GANA,
        PIERDE
    }

    // Ejecuta el juego de Craps.
    public void Jugar()
    {
        // El estado del juego puede contener CONTINUA, GANA o PIERDE.
        Estado estadoJuego = Estado.CONTINUA;

        int miPunto = 0;                    // Punto si no se gana o pierde en el primer lanzamiento.
        int sumaDeDados = LanzarDados();    // Primer lanzamiento de los dados.

        // Determina el estado del juego con base en el primer tiro.
        // Conversión explícita (o casting).
        switch ((NombreDados)sumaDeDados)
        {
            case NombreDados.SIETE:
            case NombreDados.ONCE:
                estadoJuego = Estado.GANA;
                break;

            case NombreDados.DOS_UNO:
            case NombreDados.TRES:
            case NombreDados.DOCE:
                estadoJuego = Estado.PIERDE;
                break;

            default: // No ganó ni perdió, por lo que recuerda el punto.
                estadoJuego = Estado.CONTINUA;  // El juego no ha terminado.
                miPunto = sumaDeDados;          // Recuerda el punto.
                Console.WriteLine($"El punto es {miPunto}");
                break;
        } // Fin del switch.

        // Mientras el juego no termine.
        while (estadoJuego == Estado.CONTINUA)
        {
            sumaDeDados = LanzarDados(); // Lanzamiento de los dados otra vez.

            // Determina el estado del juego.
            if (sumaDeDados == miPunto)                      // Gana por hacer su punto.
                estadoJuego = Estado.GANA;
            else if (sumaDeDados == (int)NombreDados.SIETE)  // Pierde al tirar 7 antes de hacer su punto.
                estadoJuego = Estado.PIERDE;
        } // Fin del while.

        // Muestra el mensaje de que ganó o perdió.
        if (estadoJuego == Estado.GANA)
            Console.WriteLine("El jugador gana");
        else
            Console.WriteLine("El jugador pierde");
    } // Fin del método Jugar.

    public int LanzarDados()
    {
        // Elige valores aleatorios para los dados.
        int dado1 = numerosAleatorios.Next(1, 7); // Primer dado.
        int dado2 = numerosAleatorios.Next(1, 7); // Segundo dado.

        int suma = dado1 + dado2; // Suma de los dados.

        // Muestra los resultados de este lanzamiento.
        Console.WriteLine($"El jugador lanzó {dado1} + {dado2} = {suma}");

        return suma; // Devuelve la suma de los dados.
    } // Fin del método LanzarDados.
}
