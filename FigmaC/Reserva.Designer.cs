
using MySql.Data.MySqlClient;

namespace FigmaC
{
    partial class Reserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserva));
            label1 = new Label();
            label3 = new Label();
            txtNombreCompleto = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            btnVerHorarios = new Button();
            LOGIN = new Button();
            btnregresaropciones = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Name = "label3";
            label3.Click += label3_Click;
            // 
            // txtNombreCompleto
            // 
            resources.ApplyResources(txtNombreCompleto, "txtNombreCompleto");
            txtNombreCompleto.BackColor = SystemColors.ActiveBorder;
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // txtTelefono
            // 
            resources.ApplyResources(txtTelefono, "txtTelefono");
            txtTelefono.BackColor = SystemColors.ActiveBorder;
            txtTelefono.Name = "txtTelefono";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Name = "label4";
            label4.Click += label4_Click;
            // 
            // txtCorreo
            // 
            resources.ApplyResources(txtCorreo, "txtCorreo");
            txtCorreo.BackColor = SystemColors.ActiveBorder;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // btnVerHorarios
            // 
            resources.ApplyResources(btnVerHorarios, "btnVerHorarios");
            btnVerHorarios.BackColor = SystemColors.HotTrack;
            btnVerHorarios.ForeColor = SystemColors.ButtonFace;
            btnVerHorarios.Name = "btnVerHorarios";
            btnVerHorarios.UseVisualStyleBackColor = false;
            btnVerHorarios.Click += btnVerHorarios_Click;
            // 
            // LOGIN
            // 
            resources.ApplyResources(LOGIN, "LOGIN");
            LOGIN.BackColor = SystemColors.ActiveCaption;
            LOGIN.Name = "LOGIN";
            LOGIN.UseVisualStyleBackColor = false;
            LOGIN.Click += LOGIN_Click;
            // 
            // btnregresaropciones
            // 
            resources.ApplyResources(btnregresaropciones, "btnregresaropciones");
            btnregresaropciones.BackColor = Color.Red;
            btnregresaropciones.Name = "btnregresaropciones";
            btnregresaropciones.UseVisualStyleBackColor = false;
            btnregresaropciones.Click += button2_Click;
            // 
            // Reserva
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnregresaropciones);
            Controls.Add(LOGIN);
            Controls.Add(btnVerHorarios);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtNombreCompleto);
            Controls.Add(label3);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Reserva";
            Load += Reserva_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        

        private Label label1;
        private Label label3;
        private TextBox txtNombreCompleto;
        private Label label2;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtCorreo;
        private Button btnVerHorarios;
        private Button LOGIN;
        private Button btnregresaropciones;
    }
}