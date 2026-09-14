# Laboratorio #3: Clases en C# (.NET)

**Universidad Tecnológica de Panamá — Facultad de Ingeniería en Sistemas**
Módulo II: Elementos Básicos del Lenguaje Orientada a Objetos y Windows Forms
Grupo: 1IL133 · II Semestre 2026 · Instructor: Ing. Irina Fong

Este repositorio contiene los dos casos del laboratorio:

1. **Caso #2 — Juego de CRAPS**: aplicación de **consola** que modela la lógica de negocio del juego con clases, enumeraciones y aleatoriedad.
2. **Registro de Colaboradores**: aplicación de **Windows Forms** que aplica enlace de datos a un `DataGridView`, validaciones con `ErrorProvider` y expresiones regulares, y clases utilitarias.

Ambos casos cubren los objetivos de aprendizaje del laboratorio: modelado de clases con encapsulamiento, aplicaciones de escritorio con colecciones y controles visuales, y validación de entradas a nivel profesional.

---

## Estructura del repositorio

```
CasoJuegoCraps/
├── CasoJuegoCraps.csproj        Proyecto de CONSOLA (net8.0) — Juego de Craps
├── Program.cs                   Punto de entrada del juego de Craps
├── Craps.cs                     Clase con la lógica del juego
├── README.md                    Este archivo
│
└── Laboratorio3-HPA3/
    └── Laboratorio3-HPA3/       Proyecto de WINDOWS FORMS (net10.0-windows)
        ├── Laboratorio3-HPA3.csproj
        ├── Program.cs           Punto de entrada de la app de escritorio
        ├── Form1.cs             Lógica del formulario y validaciones
        ├── Form1.Designer.cs    Definición visual de los controles
        ├── Persona.cs           Entidad del dominio (modelo)
        └── Utilidades.cs        Clase estática de validación (Regex)
```

Son dos proyectos independientes: cada uno se compila y ejecuta por separado.

---

## Parte 1 — Caso #2: Juego de CRAPS (Consola)

Aplicación de consola (C# / .NET 8) que implementa el juego de dados **Craps** usando
clases, enumeraciones (`enum`), estructuras de control y aleatoriedad (`Random`).

### Cómo ejecutar

Desde la carpeta raíz del repositorio:

```bash
dotnet run
```

### Reglas implementadas

El método `LanzarDados()` tira dos dados (valores 1–6 con `Random.Next(1, 7)`) y devuelve la suma.

**Primer tiro (come out roll):**

- Suma **7 u 11** → el jugador **gana** de inmediato.
- Suma **2, 3 o 12** → el jugador **pierde** de inmediato (craps).
- Cualquier otra suma (4, 5, 6, 8, 9, 10) → esa suma se convierte en el **"punto"** y el juego continúa.

**Tiros siguientes (mientras el estado sea `CONTINUA`):**

- Si repite el **punto** antes que un 7 → **gana**.
- Si sale un **7** antes de repetir el punto → **pierde**.

### Detalles de diseño (por qué está escrito así)

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

### Salida de ejemplo

```
Bienvenido al juego de Craps!

El jugador lanzó 6 + 3 = 9
El punto es 9
El jugador lanzó 3 + 5 = 8
El jugador lanzó 4 + 2 = 6
El jugador lanzó 3 + 6 = 9
El jugador gana
```

---

## Parte 2 — Registro de Colaboradores (Windows Forms)

Aplicación de escritorio (C# / .NET, Windows Forms) que registra colaboradores en memoria,
los muestra en una tabla y valida cada campo antes de aceptarlo.

### Cómo ejecutar

Abre la solución en **Visual Studio** y presiona **F5**, o desde la carpeta del proyecto
(`Laboratorio3-HPA3/Laboratorio3-HPA3/`):

```bash
dotnet run
```

> Nota: este proyecto usa `net10.0-windows` con `UseWindowsForms`, por lo que solo compila
> y se ejecuta en **Windows**.

### Componentes utilizados

- **`ToolStrip` + `ToolStripButton` (`tsbNuevo`)**: barra de herramientas con el botón "Nuevo"
  que dispara el registro.
- **`TextBox`**: `txtID`, `txtNombres`, `txtApellidos`, `txtCorreo`, `txtSalario` para la
  captura de datos.
- **`DateTimePicker` (`dtpFechaNacimiento`)**: selección de la fecha de nacimiento.
- **`DataGridView` (`dgvdatos`)**: muestra la lista de colaboradores. Sus columnas se generan
  automáticamente a partir de las propiedades públicas de `Persona`.
- **`ErrorProvider` (`errorProvider1`)**: muestra un ícono de error al lado del control cuando
  un dato es inválido, y lo limpia cuando es correcto.

### Clases del proyecto

**`Persona.cs`** — entidad del dominio. Propiedades: `Id`, `Nombres`, `Apellidos`, `Correo`,
`FechaNacimiento` y `Salario`. Al enlazar la lista al `DataGridView`, cada propiedad pública
se convierte en una columna (AutoGenerateColumns).

**`Utilidades.cs`** — clase **estática** de soporte con dos métodos:

- `EsCorreoValido(string)`: valida el formato del correo con la expresión regular
  `^[^@\s]+@[^@\s]+\.[^@\s]+$` (un texto antes del `@`, un dominio y una extensión).
- `EstaEnBlanco(string)`: envuelve `string.IsNullOrWhiteSpace`.

**`Form1.cs`** — el formulario principal:

- Mantiene un **`ArrayList` (`listaPersonas`)** con los colaboradores en memoria.
- `Form1_Load` carga un registro de ejemplo y enlaza la lista al grid
  (`dgvdatos.DataSource = listaPersonas`).
- `tsbNuevo_Click` ejecuta todas las validaciones; si pasan, crea el `Persona`, lo agrega a la
  lista y refresca el grid (asignando `DataSource = null` y luego la lista otra vez).

### Validaciones implementadas

Al pulsar **Nuevo**, los datos se validan en orden. Si alguno falla, se marca con el
`ErrorProvider`, se coloca el foco en el control y se interrumpe el registro (`return`):

1. **ID no vacío** — no se permite dejar el ID en blanco.
2. **ID numérico** — el ID debe poder convertirse a entero (`int.TryParse`), evitando que un
   texto no numérico provoque una excepción.
3. **ID único** — se recorre `listaPersonas` y se rechaza si ya existe un colaborador con ese ID.
4. **Nombres no vacíos.**
5. **Apellidos no vacíos.**
6. **Correo válido** — mediante `Utilidades.EsCorreoValido` (Regex).
7. **Salario válido** — conversión segura con `decimal.TryParse` (parseo defensivo).
8. **Fecha de nacimiento no futura** — se rechaza cualquier fecha posterior al día de hoy.
9. **Mayor de 18 años** — un método auxiliar `CalcularEdad` calcula los años cumplidos y se
   rechaza a quien tenga menos de 18.

Cuando todas las validaciones pasan, el colaborador se agrega y las cajas de texto se limpian
para el siguiente registro. La fecha se guarda con `.Date` (sin la hora), por lo que la columna
`FechaNacimiento` muestra solo la fecha.

---

## Conceptos del laboratorio aplicados

| Tema del laboratorio | Dónde se aplica |
| --- | --- |
| Modelado de clases y objetos, encapsulamiento, propiedades | `Craps`, `Persona`, `Utilidades` |
| Enumeraciones (`enum`) y aleatoriedad | `Craps` (juego de dados) |
| Estructuras de control (`switch`, `while`, `if`) | `Craps.Jugar()`, validaciones de `Form1` |
| Enlace de datos (Data Binding) con colecciones hacia un `DataGridView` | `Form1` + `ArrayList` |
| `ErrorProvider`, `DateTimePicker`, `ToolStrip` | `Form1` (Windows Forms) |
| Validación con expresiones regulares (Regex) | `Utilidades.EsCorreoValido` |
| Conversión segura de tipos (`TryParse`) | Validación de ID y salario |
| Clases estáticas de soporte | `Utilidades` |
