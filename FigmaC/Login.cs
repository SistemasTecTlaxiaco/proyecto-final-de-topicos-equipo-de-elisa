using System.Text;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;
using MySql.Data.MySqlClient;


namespace FigmaC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                MySqlConnection conexion = db.GetConnection();
                conexion.Open();
                MessageBox.Show("✅ Conexión exitosa a la base de datos.");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error de conexión: " + ex.Message);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string password = EncriptarSHA256(txtcontrasena.Text); // Aquí encriptamos la contraseña ingresada

            try
            {
                Database db = new Database();
                using (MySqlConnection conexion = db.GetConnection())
                {
                    conexion.Open();
                    string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND contraseña = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        this.Hide();

                        FigmaC.Customs.progressBar1 progreso = new FigmaC.Customs.progressBar1();
                        progreso.ShowDialog();

                        Opciones opcionesForm = new Opciones();
                        opcionesForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("❌ Usuario o contraseña incorrectos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al intentar iniciar sesión: " + ex.Message);
            }
        }


        private string EncriptarSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder resultado = new StringBuilder();

                foreach (byte b in hash)
                {
                    resultado.Append(b.ToString("x2"));
                }

                return resultado.ToString();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            REGISTRATE registrateForm = new REGISTRATE();  // Cambia el nombre aquí
            registrateForm.Show();  // Muestra la ventana de registro sin cerrar la actual
            this.Hide();  // Esconde la ventana de Login
        }


        private void txtcontrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Resize(object sender, EventArgs e)
        {
            // Verificamos si la ventana está maximizada
            if (this.WindowState == FormWindowState.Maximized)
            {
                CenterControls();
            }
        }
            private void CenterControls()
        {
            int anchoFormulario = this.ClientSize.Width;

            // Centrado horizontal
            txtusuario.Left = (anchoFormulario - txtusuario.Width) / 2;
            txtcontrasena.Left = (anchoFormulario - txtcontrasena.Width) / 2;
            btningresar.Left = (anchoFormulario - btningresar.Width) / 2;

            // Puedes ajustar el centrado vertical si quieres (opcional)
            // txtusuario.Top = 150;
            // txtcontrasena.Top = txtusuario.Bottom + 10;
            // btningresar.Top = txtcontrasena.Bottom + 20;
        }

    }

}



