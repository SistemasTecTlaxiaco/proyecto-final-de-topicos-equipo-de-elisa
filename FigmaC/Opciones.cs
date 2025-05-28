using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigmaC
{
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void Opciones_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show(); // Abre la ventana de Login
            this.Hide(); // Esconde la ventana de Opciones
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reserva reservaForm = new Reserva();
            reservaForm.Show(); // Muestra la ventana de opciones
            this.Hide(); // Oculta la ventana actual en lugar de cerrarla
        }
    }
}
