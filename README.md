# Caso #2 — Juego de CRAPS (C# / .NET Consola)

Laboratorio #3: Clases en C# — Tema 1: Modelado de Clases y Lógica de Negocio (Consola).
Aplicación de consola en C# (.NET 8) que implementa el juego de dados **Craps** usando
clases, enumeraciones (`enum`), estructuras de control y aleatoriedad (`Random`).

## Estructura del proyecto

```
CasoJuegoCraps/
├── CasoJuegoCraps.csproj   Configuración del proyecto (net8.0, consola)
├── Program.cs              Punto de entrada: crea el objeto Craps y lo ejecuta
├── Craps.cs                Clase con toda la lógica del juego
└── README.md
```

## Cómo ejecutar

Desde la carpeta del proyecto:

```bash
dotnet run
```

O compilando primero:

```bash
dotnet build
dotnet run
```

## Reglas implementadas

El método `LanzarDados()` tira dos dados (valores 1–6 con `Random.Next(1, 7)`) y devuelve la suma.

**Primer tiro (come out roll):**
- Suma **7 u 11** → el jugador **gana** de inmediato.
- Suma **2, 3 o 12** → el jugador **pierde** de inmediato (craps).
- Cualquier otra suma (4, 5, 6, 8, 9, 10) → esa suma se convierte en el **"punto"** y el juego continúa.

**Tiros siguientes (mientras el estado sea `CONTINUA`):**
- Si repite el **punto** antes que un 7 → **gana**.
- Si sale un **7** antes de repetir el punto → **pierde**.

## Detalles de diseño (por qué está escrito así)

- **`enum NombreDados`**: constantes con nombre (`DOS_UNO = 2`, `TRES = 3`, `SIETE = 7`,
  `ONCE = 11`, `DOCE = 12`) que hacen legible el `switch` del primer tiro. Se usa una
  **conversión explícita (casting)** `(NombreDados)sumaDeDados` para comparar la suma
  numérica contra las constantes del enum.
- **`enum Estado`**: `CONTINUA`, `GANA`, `PIERDE` controlan el flujo del juego y la
  condición del bucle `while`.
- **`Random numerosAleatorios`**: un único generador reutilizado en cada lanzamiento
  (se declara como campo de la clase, no dentro del método, para no reiniciar la semilla).
- **Encapsulamiento**: los enums y el generador son `private`; solo `Jugar()` y
  `LanzarDados()` son `public`.
