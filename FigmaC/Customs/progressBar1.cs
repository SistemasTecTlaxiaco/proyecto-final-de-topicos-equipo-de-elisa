using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigmaC.Customs
{
    public partial class progressBar1 : Form
    {
        public static int Value { get; private set; }

        public progressBar1()
        {
            InitializeComponent();
        }

        private async void progressBar1_Load(object sender, EventArgs e)
        {
            // Llama a la tarea de cargar los datos
            await CargarDatosAsync();
        }

        private async Task CargarDatosAsync()
        {
            for (int i = 0; i <= 100; i++)
            {
                // Actualiza la ProgressBar y el label en el hilo principal
                progressBar1.Value = i;
                label2.Text = $"{i}%";

                // Simula un retraso (en lugar de bloquear la UI)
                await Task.Delay(30); // Simula carga, puedes ajustar el tiempo
            }

            this.Close(); // Cierra la ventana de progreso
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}