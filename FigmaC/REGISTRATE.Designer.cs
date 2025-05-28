
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;

namespace FigmaC
{
    partial class REGISTRATE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTRATE));
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtNombreCompleto = new TextBox();
            txtNuevoUsuario = new TextBox();
            txtNuevaContrasena = new TextBox();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            btnRegistrar = new Button();
            label8 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 40);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 1;
            label1.Text = "REGISTRATE";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(54, 90);
            label3.Name = "label3";
            label3.Size = new Size(144, 16);
            label3.TabIndex = 3;
            label3.Text = "NOMBRE COMPLETO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(131, 130);
            label2.Name = "label2";
            label2.Size = new Size(69, 16);
            label2.TabIndex = 4;
            label2.Text = "USUARIO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(105, 175);
            label4.Name = "label4";
            label4.Size = new Size(103, 16);
            label4.TabIndex = 5;
            label4.Text = "CONTRASEÑA:";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.BackColor = SystemColors.ActiveBorder;
            txtNombreCompleto.Location = new Point(216, 84);
            txtNombreCompleto.Margin = new Padding(3, 2, 3, 2);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(275, 23);
            txtNombreCompleto.TabIndex = 6;
            txtNombreCompleto.TextChanged += textBox1_TextChanged;
            // 
            // txtNuevoUsuario
            // 
            txtNuevoUsuario.BackColor = SystemColors.ActiveBorder;
            txtNuevoUsuario.Location = new Point(216, 128);
            txtNuevoUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNuevoUsuario.Name = "txtNuevoUsuario";
            txtNuevoUsuario.Size = new Size(275, 23);
            txtNuevoUsuario.TabIndex = 7;
            txtNuevoUsuario.TextChanged += textBox2_TextChanged;
            // 
            // txtNuevaContrasena
            // 
            txtNuevaContrasena.BackColor = SystemColors.ActiveBorder;
            txtNuevaContrasena.Location = new Point(216, 172);
            txtNuevaContrasena.Margin = new Padding(3, 2, 3, 2);
            txtNuevaContrasena.Name = "txtNuevaContrasena";
            txtNuevaContrasena.PasswordChar = '*';
            txtNuevaContrasena.Size = new Size(275, 23);
            txtNuevaContrasena.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(105, 228);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(27, 22);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(145, 234);
            label6.Name = "label6";
            label6.Size = new Size(143, 14);
            label6.TabIndex = 10;
            label6.Text = "RECORDAR CONTRASEÑA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(318, 234);
            label7.Name = "label7";
            label7.Size = new Size(156, 14);
            label7.TabIndex = 11;
            label7.Text = "¿OLVIIDO SU CONTRASEÑA?";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.HotTrack;
            btnRegistrar.ForeColor = SystemColors.ButtonFace;
            btnRegistrar.Location = new Point(214, 258);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(277, 22);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;

            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(228, 302);
            label8.Name = "label8";
            label8.Size = new Size(117, 14);
            label8.TabIndex = 13;
            label8.Text = "¿YA TIENES CUENTA?";
            label8.Click += label8_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(359, 296);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(101, 22);
            button3.TabIndex = 14;
            button3.Text = "INGRESA";
            button3.UseVisualStyleBackColor = false;
            // 
            // REGISTRATE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 338);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(btnRegistrar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(txtNuevaContrasena);
            Controls.Add(txtNuevoUsuario);
            Controls.Add(txtNombreCompleto);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "REGISTRATE";
            Text = "REGISTRATE";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nuevoUsuario = txtNuevoUsuario.Text.Trim();
            string nuevaContrasena = txtNuevaContrasena.Text.Trim();
            string contrasenaEncriptada = EncriptarSHA256(nuevaContrasena);

            if (string.IsNullOrEmpty(nuevoUsuario) || string.IsNullOrEmpty(nuevaContrasena))
            {
                MessageBox.Show("⚠️ Por favor, completa los campos de usuario y contraseña.");
                return;
            }

            try
            {
                Database db = new Database();
                using (MySqlConnection conexion = db.GetConnection())
                {
                    conexion.Open();

                    // Verificar si el usuario ya existe
                    string checkQuery = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conexion);
                    checkCmd.Parameters.AddWithValue("@usuario", nuevoUsuario);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("❌ El usuario ya existe. Elige otro.");
                        return;
                    }

                    // Insertar nuevo usuario
                    string insertQuery = "INSERT INTO usuarios (usuario, contraseña) VALUES (@usuario, @password)";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, conexion);
                    cmd.Parameters.AddWithValue("@usuario", nuevoUsuario);
                    cmd.Parameters.AddWithValue("@password", contrasenaEncriptada);
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("✅ Usuario registrado correctamente.");

                        this.Hide();
                        Login loginForm = new Login();
                        loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("❌ No se pudo registrar el usuario.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al registrar: " + ex.Message);
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
                    resultado.Append(b.ToString("x2")); // Convierte cada byte en hexadecimal
                }

                return resultado.ToString();
            }
        }


        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtNombreCompleto;
        private TextBox txtNuevoUsuario;
        private TextBox txtNuevaContrasena;
        private Button button2;
        private Label label6;
        private Label label7;
        private Button btnRegistrar;
        private Label label8;
        private Button button3;
    }
}