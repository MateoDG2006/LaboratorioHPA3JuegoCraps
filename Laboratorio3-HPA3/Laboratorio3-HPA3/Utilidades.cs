using System;
using System.Text.RegularExpressions;

namespace Laboratorio3_HPA3
{
    // Clase estática de soporte: agrupa métodos utilitarios de validación
    // reutilizables (no necesita instanciarse).
    public static class Utilidades
    {
        // Valida el formato de un correo electrónico mediante una expresión regular.
        public static bool EsCorreoValido(string email)
        {
            // Llama al método auxiliar para verificar si está en blanco.
            if (EstaEnBlanco(email))
            {
                return false;
            }

            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patron);
        }

        // Indica si un texto es nulo, vacío o solo espacios en blanco.
        public static bool EstaEnBlanco(string texto)
        {
            return string.IsNullOrWhiteSpace(texto);
        }
    } // Fin de la clase Utilidades.
}
