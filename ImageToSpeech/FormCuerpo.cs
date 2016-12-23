﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace ImageToSpeech
{
    public partial class FormCuerpo : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        FormUrgencias padre = null;
        FormCuerpo2 frmCuerpo2 = null;
        FormPral frmPral = null;

        public FormUrgencias Padre
        {
            get { return padre; }
            set { padre = value; }
        }

        public FormCuerpo()
        {
            InitializeComponent();
        }
        
        private void FormCuerpo_Load(object sender, EventArgs e)
        {
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = 70;
            Prompt inicio = new Prompt("Panel del cuerpo");
            synth.SpeakAsync(inicio);

            synth.Volume = 100;
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            if (this.Padre != null)
            {
                this.Padre.Show();
                this.Padre.BringToFront();
                this.Hide();
            }
            else
            {
                FormUrgencias frmUrge = new FormUrgencias();
                frmUrge.Show();
                frmUrge.BringToFront();
                this.Hide();
            }
        }

        private void buttonCuerpo2_Click(object sender, EventArgs e)
        {
            if (frmCuerpo2 == null)
            {
                frmCuerpo2 = new FormCuerpo2();
                frmCuerpo2.Padre = this;
            }
            frmCuerpo2.Show();
            frmCuerpo2.BringToFront();
            this.Hide();
        }

        private void buttonMejor_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Me encuentro mejor");
            synth.Speak(frase);
        }

        private void buttonDolor_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("¡Me duele!");
            synth.Speak(frase);
        }

        private void buttonSi_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Síi");
            synth.Speak(frase);
        }

        private void buttonAveces_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("A veces");
            synth.Speak(frase);
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("¡Nooo!");
            synth.Speak(frase);
        }

        private void buttonPicor_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("¡Me pica!");
            synth.Speak(frase);
        }

        private void buttonWC_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quiero ir al baño");
            synth.Speak(frase);
        }

        private void buttonComer_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quiero comer");
            synth.Speak(frase);
        }

        private void buttonBeber_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quiero beber");
            synth.Speak(frase);
        }

        private void buttonOrinar_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quiero orinar");
            synth.Speak(frase);
        }

        private void buttonCaca_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Quiero hacer caca");
            synth.Speak(frase);
        }

        private void buttonPartesCuerpo_Click(object sender, EventArgs e)
        {
            FormPartesCuerpo frmPartesCuerpo = new FormPartesCuerpo();
            frmPartesCuerpo.Show();
            frmPartesCuerpo.BringToFront();
        }

        private void buttonPeor_Click(object sender, EventArgs e)
        {
            Prompt frase = new Prompt("Me encuentro peor");
            synth.Speak(frase);
        }

        private void FormCuerpo_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPral = new FormPral();
            frmPral.Show();
            frmPral.BringToFront();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
