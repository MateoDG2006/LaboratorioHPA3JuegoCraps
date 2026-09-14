using System;
using System.Collections; // ArrayList pertenece al espacio de nombres System.Collections.

namespace Laboratorio3_HPA3
{
    public partial class Form1 : Form
    {
        // ArrayList para almacenar los objetos Persona en memoria.
        ArrayList listaPersonas = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Registro de ejemplo para que la cuadrícula no inicie vacía.
            Persona miColaborador1 = new Persona();

            miColaborador1.Id = 1;
            miColaborador1.Nombres = "Elena Carolina";
            miColaborador1.Apellidos = "Gonzalez Rodríguez";
            miColaborador1.Correo = "elena.gonzalez@ejemplo.com";
            miColaborador1.FechaNacimiento = new DateTime(1990, 5, 15);
            miColaborador1.Salario = 1500m;

            listaPersonas.Add(miColaborador1);
            dgvdatos.DataSource = listaPersonas;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            // Validación del ID: no puede estar vacío.
            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Ingrese un ID");
                txtID.Focus();
                return; // <-- Interrumpe y finaliza la ejecución del método actual.
            }
            else
            {
                errorProvider1.SetError(txtID, "");
            }

            // Validación del ID: debe ser un número entero válido (parseo defensivo).
            int idIngresado;
            if (!int.TryParse(txtID.Text, out idIngresado))
            {
                errorProvider1.SetError(txtID, "El ID debe ser un número entero");
                txtID.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtID, "");
            }

            // Validación de ID único: no debe existir otro colaborador con el mismo ID.
            foreach (Persona persona in listaPersonas)
            {
                if (persona.Id == idIngresado)
                {
                    errorProvider1.SetError(txtID, "Ya existe un colaborador con ese ID");
                    txtID.Focus();
                    return;
                }
            }
            errorProvider1.SetError(txtID, "");

            // Validación de los nombres.
            if (txtNombres.Text == "")
            {
                errorProvider1.SetError(txtNombres, "Ingrese los nombres del Colaborador");
                txtNombres.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombres, "");
            }

            // Validación de los apellidos.
            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "Ingrese los apellidos del Colaborador");
                txtApellidos.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtApellidos, "");
            }

            // Validación del correo con expresión regular (clase Utilidades).
            if (Utilidades.EsCorreoValido(txtCorreo.Text) == false)
            {
                errorProvider1.SetError(txtCorreo, "Ingrese un correo válido");
                txtCorreo.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
            }

            // Validación del salario con conversión segura (parseo defensivo).
            decimal salario1;
            if (!decimal.TryParse(txtSalario.Text, out salario1))
            {
                errorProvider1.SetError(txtSalario, "Ingrese un salario válido");
                txtSalario.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtSalario, "");
            }

            // Validación de la fecha de nacimiento: no puede ser posterior a hoy.
            if (dtpFechaNacimiento.Value.Date > DateTime.Today)
            {
                errorProvider1.SetError(dtpFechaNacimiento, "La fecha de nacimiento no puede ser posterior a hoy");
                dtpFechaNacimiento.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(dtpFechaNacimiento, "");
            }

            // Validación de la edad: el colaborador debe ser mayor de edad (18 años o más).
            if (CalcularEdad(dtpFechaNacimiento.Value) < 18)
            {
                errorProvider1.SetError(dtpFechaNacimiento, "El colaborador debe ser mayor de 18 años");
                dtpFechaNacimiento.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(dtpFechaNacimiento, "");
            }

            // Todas las validaciones pasaron: se crea el objeto y se agrega a la lista.
            Persona colaborador1 = new Persona();
            colaborador1.Id = idIngresado;
            colaborador1.Nombres = txtNombres.Text;
            colaborador1.Apellidos = txtApellidos.Text;
            colaborador1.Correo = txtCorreo.Text;
            colaborador1.Salario = salario1;
            colaborador1.FechaNacimiento = dtpFechaNacimiento.Value.Date; // Solo la fecha (sin la hora).

            listaPersonas.Add(colaborador1);

            dgvdatos.DataSource = null;           // Limpiar el DataSource antes de asignar la nueva lista.
            dgvdatos.DataSource = listaPersonas;  // Reenlazar para refrescar la cuadrícula.

            LimpiarCampos(); // Deja el formulario listo para el siguiente registro.
        }

        // Limpia las cajas de texto luego de agregar un registro.
        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtSalario.Clear();
            txtID.Focus();
        }

        // Calcula la edad en años cumplidos a partir de la fecha de nacimiento.
        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - fechaNacimiento.Year;

            // Si aún no ha cumplido años en la fecha actual, resta un año.
            if (fechaNacimiento.Date > hoy.AddYears(-edad))
                edad--;

            return edad;
        }
    }
}
