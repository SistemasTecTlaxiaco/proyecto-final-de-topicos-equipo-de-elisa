namespace FigmaC
{
    partial class Horarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Horarios));
            label3 = new Label();
            label1 = new Label();
            btnopciones = new Button();
            button6 = new Button();
            cmbHorarios = new ComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MidnightBlue;
            label3.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(48, 35);
            label3.Name = "label3";
            label3.Size = new Size(146, 16);
            label3.TabIndex = 5;
            label3.Text = " Horarios disponibles";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(48, 50);
            label1.Name = "label1";
            label1.Size = new Size(249, 16);
            label1.TabIndex = 6;
            label1.Text = "Seleccione el que mejor le convenga";
            label1.Click += label1_Click;
            // 
            // btnopciones
            // 
            btnopciones.BackColor = SystemColors.HotTrack;
            btnopciones.ForeColor = SystemColors.ButtonFace;
            btnopciones.Location = new Point(468, 9);
            btnopciones.Margin = new Padding(3, 2, 3, 2);
            btnopciones.Name = "btnopciones";
            btnopciones.Size = new Size(214, 22);
            btnopciones.TabIndex = 24;
            btnopciones.Text = "Volver al menú de opciones";
            btnopciones.UseVisualStyleBackColor = false;
            btnopciones.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.OliveDrab;
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(450, 260);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(224, 47);
            button6.TabIndex = 25;
            button6.Text = "Pulse aqui para confirmar tu horario y reservar tu cita";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // cmbHorarios
            // 
            cmbHorarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHorarios.FormattingEnabled = true;
            cmbHorarios.Location = new Point(94, 118);
            cmbHorarios.Name = "cmbHorarios";
            cmbHorarios.Size = new Size(121, 23);
            cmbHorarios.TabIndex = 26;
            cmbHorarios.SelectedIndexChanged += cmbHorarios_SelectedIndexChanged;
            // 
            // Horarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(684, 340);
            Controls.Add(cmbHorarios);
            Controls.Add(button6);
            Controls.Add(btnopciones);
            Controls.Add(label1);
            Controls.Add(label3);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Horarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Horarios";
            Load += Horarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Button btnopciones;
        private Button button6;
        private ComboBox cmbHorarios;
    }
}