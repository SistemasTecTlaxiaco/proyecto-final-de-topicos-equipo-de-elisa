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
    public partial class Horarios : Form
    {
        public Horarios()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Horarios_Load);


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Horarios_Load(object? sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=goku11795;database=loginapp;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                cmbHorarios.Items.Clear(); // Limpia antes de cargar

                string query = "SELECT id, hora FROM horarios";//aguegue la validacion 


                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        TimeSpan hora = reader.GetTimeSpan("hora");

                        cmbHorarios.Items.Add(new ComboBoxItem(id, hora.ToString(@"hh\:mm")));
                    }
                }
            }

            // Establecer selección predeterminada
            if (cmbHorarios.Items.Count > 0)
            {
                cmbHorarios.SelectedIndex = 0;
            }
        }


        class ComboBoxItem
        {
            public int Id { get; }
            public string Text { get; }

            public ComboBoxItem(int id, string text)
            {
                Id = id;
                Text = text;
            }

            public override string ToString() => Text;
        }




        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cmbHorarios.SelectedItem == null || !(cmbHorarios.SelectedItem is ComboBoxItem itemSeleccionado))
            {
                MessageBox.Show("Por favor selecciona un horario válido.");
                return;
            }

            int idHorario = itemSeleccionado.Id;
            string nombre = DatosGlobales.NombreCompleto;
            string telefono = DatosGlobales.Telefono;
            string correo = DatosGlobales.Correo;

            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=goku11795;database=loginapp;"))
            {
                conn.Open();
                string query = @"INSERT INTO reservas (nombre_completo, telefono, correo, horario_id)
                         VALUES (@nombre, @telefono, @correo, @horarioId)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@horarioId", idHorario);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Tu cita ha sido reservada exitosamente");

            Opciones opcionesForm = new Opciones();
            opcionesForm.Show();
            this.Hide();
        }





        private void button5_Click(object sender, EventArgs e)
        {
            Opciones opcionesForm = new Opciones();
            opcionesForm.Show(); // Muestra la ventana de opciones
            this.Hide(); // Oculta la ventana actual en lugar de cerrarla
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
