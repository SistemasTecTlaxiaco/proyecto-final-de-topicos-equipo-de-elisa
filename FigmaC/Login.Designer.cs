
namespace FigmaC
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtusuario = new TextBox();
            txtcontrasena = new TextBox();
            label5 = new Label();
            btningresar = new Button();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnregistrate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 58);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 58);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(136, 109);
            label3.Name = "label3";
            label3.Size = new Size(69, 16);
            label3.TabIndex = 2;
            label3.Text = "USUARIO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(136, 161);
            label4.Name = "label4";
            label4.Size = new Size(103, 16);
            label4.TabIndex = 3;
            label4.Text = "CONTRASEÑA:";
            label4.Click += label4_Click;
            // 
            // txtusuario
            // 
            txtusuario.BackColor = SystemColors.ActiveBorder;
            txtusuario.Location = new Point(220, 106);
            txtusuario.Margin = new Padding(3, 2, 3, 2);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(275, 23);
            txtusuario.TabIndex = 4;
            txtusuario.TextChanged += txtusuario_TextChanged;
            // 
            // txtcontrasena
            // 
            txtcontrasena.BackColor = SystemColors.ActiveBorder;
            txtcontrasena.Location = new Point(252, 158);
            txtcontrasena.Margin = new Padding(3, 2, 3, 2);
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.PasswordChar = '*';
            txtcontrasena.Size = new Size(244, 23);
            txtcontrasena.TabIndex = 5;
            txtcontrasena.TextChanged += txtcontrasena_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(74, 65);
            label5.Name = "label5";
            label5.Size = new Size(0, 18);
            label5.TabIndex = 6;
            label5.Click += label5_Click;
            // 
            // btningresar
            // 
            btningresar.BackColor = SystemColors.HotTrack;
            btningresar.ForeColor = SystemColors.ButtonFace;
            btningresar.Location = new Point(176, 234);
            btningresar.Margin = new Padding(3, 2, 3, 2);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(277, 22);
            btningresar.TabIndex = 7;
            btningresar.Text = "INGRESAR";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(144, 196);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(27, 22);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(176, 202);
            label6.Name = "label6";
            label6.Size = new Size(143, 14);
            label6.TabIndex = 9;
            label6.Text = "RECORDAR CONTRASEÑA";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(338, 202);
            label7.Name = "label7";
            label7.Size = new Size(156, 14);
            label7.TabIndex = 10;
            label7.Text = "¿OLVIIDO SU CONTRASEÑA?";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Lucida Sans", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(152, 280);
            label8.Name = "label8";
            label8.Size = new Size(120, 14);
            label8.TabIndex = 11;
            label8.Text = "¿NO TIENES CUENTA?";
            label8.Click += label8_Click;
            // 
            // btnregistrate
            // 
            btnregistrate.BackColor = Color.White;
            btnregistrate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnregistrate.ForeColor = SystemColors.ActiveCaptionText;
            btnregistrate.Location = new Point(297, 274);
            btnregistrate.Margin = new Padding(3, 2, 3, 2);
            btnregistrate.Name = "btnregistrate";
            btnregistrate.Size = new Size(101, 22);
            btnregistrate.TabIndex = 12;
            btnregistrate.Text = "REGISTRATE";
            btnregistrate.UseVisualStyleBackColor = false;
            btnregistrate.Click += button3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(728, 340);
            Controls.Add(btnregistrate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(btningresar);
            Controls.Add(label5);
            Controls.Add(txtcontrasena);
            Controls.Add(txtusuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(100, 100);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.Manual;
            Text = "Login";
            Load += Form1_Load;
            Resize += Login_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtusuario;
        private TextBox txtcontrasena;
        private Label label5;
        private Button btningresar;
        private Button button2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnregistrate;
    }
}
