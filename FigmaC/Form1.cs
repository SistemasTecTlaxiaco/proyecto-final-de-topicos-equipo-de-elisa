using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FigmaC
{
    //  se elimino la maximizacion
   

    public partial class Horario2 : Form
    {
        private Dictionary<int, CheckBox> checkBoxes = new();

        public Horario2()
        {
            InitializeComponent();
        }

        private void Horario2_Load(object sender, EventArgs e)
        {
            // Asignación de checkboxes a ID de horarios
            checkBoxes = new Dictionary<int, CheckBox>
            {
                { 1, checkBox1 }, // 09:00 - 10:00
                { 2, checkBox2 }, // 12:00 - 13:20
                { 3, checkBox3 }, // 13:00 - 14:30
                { 4, checkBox4 }  // 15:30 - 16:30
            };

            // ahora se muestran etiquetas
            Dictionary<int, string> etiquetas = new()
            {
                { 1, "09:00 - 10:00" },
                { 2, "12:00 - 13:20" },
                { 3, "13:00 - 14:30" },
                { 4, "15:30 - 16:30" }
            };

            foreach (var item in checkBoxes)
            {
                item.Value.Text = etiquetas[item.Key];
                item.Value.Enabled = true; // ❗ Importante: todas habilitadas siempre
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=goku11795;database=loginapp;";
            string nombre = DatosGlobales.NombreCompleto;
            string correo = DatosGlobales.Correo;

            bool algunaCancelada = false;
            bool algunaNoEncontrada = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                foreach (var pair in checkBoxes)
                {
                    int idHorario = pair.Key;
                    CheckBox chk = pair.Value;

                    if (chk.Checked)
                    {
                        // Verificar si existe la reserva
                        string checkQuery = @"SELECT COUNT(*) FROM reservas 
                                      WHERE nombre_completo = @nombre AND correo = @correo AND horario_id = @horarioId";
                        using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@nombre", nombre);
                            checkCmd.Parameters.AddWithValue("@correo", correo);
                            checkCmd.Parameters.AddWithValue("@horarioId", idHorario);

                            long count = (long)checkCmd.ExecuteScalar();

                            if (count > 0)
                            {
                                // Si existe, eliminar
                                string deleteQuery = @"DELETE FROM reservas 
                                               WHERE nombre_completo = @nombre AND correo = @correo AND horario_id = @horarioId";
                                using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn))
                                {
                                    deleteCmd.Parameters.AddWithValue("@nombre", nombre);
                                    deleteCmd.Parameters.AddWithValue("@correo", correo);
                                    deleteCmd.Parameters.AddWithValue("@horarioId", idHorario);
                                    deleteCmd.ExecuteNonQuery();
                                    algunaCancelada = true;
                                }
                            }
                            else
                            {
                                algunaNoEncontrada = true;
                            }
                        }
                    }
                }
            }

            if (algunaCancelada)
            {
                MessageBox.Show("Cita(s) cancelada(s) exitosamente.");
            }

            if (algunaNoEncontrada)
            {
                MessageBox.Show("No hay una cita registrada en uno o más horarios seleccionados.");
            }

            // ae puede abrir el formulario y cerrar
            Opciones opcionesForm = new Opciones();
            opcionesForm.Show();
            this.Hide();
        }
    }
}
