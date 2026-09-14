using System;

namespace Laboratorio3_HPA3
{
    // Entidad del dominio. Sus propiedades públicas se muestran como columnas
    // automáticamente cuando la lista se enlaza al DataGridView (AutoGenerateColumns).
    public class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public decimal Salario { get; set; }
    }
}
