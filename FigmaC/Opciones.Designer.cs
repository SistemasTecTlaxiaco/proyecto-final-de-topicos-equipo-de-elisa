
namespace FigmaC
{
    partial class Opciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opciones));
            label1 = new Label();
            btnloginback = new Button();
            label2 = new Label();
            label3 = new Label();
            btnreserva = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 55);
            label1.Name = "label1";
            label1.Size = new Size(316, 25);
            label1.TabIndex = 2;
            label1.Text = "ELIGE UNA DE LAS OPCIONES";
            // 
            // btnloginback
            // 
            btnloginback.BackColor = Color.Transparent;
            btnloginback.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnloginback.ForeColor = SystemColors.ActiveCaptionText;
            btnloginback.Location = new Point(626, 11);
            btnloginback.Margin = new Padding(3, 2, 3, 2);
            btnloginback.Name = "btnloginback";
            btnloginback.Size = new Size(101, 22);
            btnloginback.TabIndex = 16;
            btnloginback.Text = "LOGIN";
            btnloginback.UseVisualStyleBackColor = false;
            btnloginback.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(129, 120);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 17;
            label2.Text = "RESERVAR CITA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(468, 120);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 18;
            label3.Text = "CANCELAR CITA";
            // 
            // btnreserva
            // 
            btnreserva.BackColor = Color.Transparent;
            btnreserva.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnreserva.ForeColor = SystemColors.ActiveCaptionText;
            btnreserva.Image = (Image)resources.GetObject("btnreserva.Image");
            btnreserva.Location = new Point(111, 137);
            btnreserva.Margin = new Padding(3, 2, 3, 2);
            btnreserva.Name = "btnreserva";
            btnreserva.Size = new Size(150, 134);
            btnreserva.TabIndex = 19;
            btnreserva.UseVisualStyleBackColor = false;
            btnreserva.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(468, 145);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(122, 116);
            button4.TabIndex = 20;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Opciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(728, 340);
            Controls.Add(button4);
            Controls.Add(btnreserva);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnloginback);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Opciones";
            Text = "Opciones";
            Load += Opciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Horario2 horario2Form = new Horario2();
            horario2Form.Show(); // Muestra la ventana de opciones
            this.Hide(); // Oculta la ventana actual en lugar de cerrarla
        }

        #endregion

        private Label label1;
        private Button btnloginback;
        private Label label2;
        private Label label3;
        private Button btnreserva;
        private Button button4;
    }
}