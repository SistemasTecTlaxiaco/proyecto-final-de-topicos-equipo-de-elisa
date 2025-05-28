using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FigmaC
{
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show(); // Abre la ventana de Login
            this.Hide(); // Esconde la ventana de Opciones
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Opciones opcionesForm = new Opciones();
            opcionesForm.Show(); // Muestra la ventana de opciones
            this.Hide(); // Oculta la ventana actual en lugar de cerrarla
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnVerHorarios_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCompleto.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Por favor, completa al menos el nombre y teléfono.");
                return;
            }

            // Guardar los datos globalmente, sin insertar aún
            DatosGlobales.NombreCompleto = nombre;
            DatosGlobales.Telefono = telefono;
            DatosGlobales.Correo = correo;

            // Ir directamente a la selección de horarios
            Horarios horariosForm = new Horarios();
            horariosForm.Show();
            this.Hide();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

