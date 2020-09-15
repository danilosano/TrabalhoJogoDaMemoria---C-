using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TrabalhoJogoDaMemoria1
{
    public partial class Form1 : Form
    {
        int cartasEncontradas, img1,img2,img3,img4,img5,img6,img7,img8,checagem,par1,par2,par3,par4;
        int Play = 1;
        bool acabou;
        async Task EsperaDelay()
        {
            await Task.Delay(1500);
        }
        private void recomecar(object sender, EventArgs e)
        {
            
            Application.Restart();

        }

        private void Continuar(object sender, EventArgs e)
        {
          
                pictureBox11.Visible = false;
                pictureBox13.Visible = false;
                pictureBox11.Enabled = false;
                pictureBox13.Enabled = false;
        
        }

        private void Ganhou(object sender, EventArgs e)
        {
            if (acabou == true)
            {
                Application.Exit();
            }
        }

        private void PlayPause(object sender, EventArgs e)
        {
            Play++;
            if ( Play % 2 == 0 ) {

                pictureBox9.BackgroundImage = Properties.Resources.Mudo;
                
              
                Theme.Stop();
            }
            else
            {
                Theme.PlayLooping();
              
                pictureBox9.BackgroundImage = Properties.Resources.Normal;
            }
        }

        System.Media.SoundPlayer Theme = new System.Media.SoundPlayer("Sound/Theme.wav");
        private void Começar(object sender, EventArgs e)
        {
            Theme.PlayLooping();
        }

        public Form1()
        {
            InitializeComponent();
            
        }
     
          #region EventosClick
        
        private void virarCarta(object sender, EventArgs e)
        {
            img1++;
            
           
            compararImagemAsync();
            
        }
        private void virarCarta2(object sender, EventArgs e)
        {
            img2++;
            compararImagemAsync();
        }
        private void virarCarta3(object sender, EventArgs e)
        {
            img3++;
            compararImagemAsync();
        }
        private void virarCarta4(object sender, EventArgs e)
        {
            img4++;
            compararImagemAsync();
        }
        private void virarCarta5(object sender, EventArgs e)
        {
            img5++;
            compararImagemAsync();
        }
        private void virarCarta6(object sender, EventArgs e)
        {
            img6++;
            compararImagemAsync();
        }
        private void virarCarta7(object sender, EventArgs e)
        {
            img7++;
            compararImagemAsync();
        }
        private void virarCarta8(object sender, EventArgs e)
        {
            img8++;
            compararImagemAsync();
        }
        #endregion
        private async Task compararImagemAsync()
        {
          #region VirarCarta
            if (img1  == 1){
            pictureBox1.Image = TrabalhoJogoDaMemoria1.Properties.Resources.carta1;
                
                checagem = 1;
          }
          if (img6 == 1)
          {
              pictureBox6.Image = TrabalhoJogoDaMemoria1.Properties.Resources.carta1;
              checagem = 1;
          }
          if (img2 == 1)
          {
              pictureBox2.Image = TrabalhoJogoDaMemoria1.Properties.Resources.carta2;
              checagem = 1;
          }
          if (img3 == 1)
          {
              pictureBox3.Image = TrabalhoJogoDaMemoria1.Properties.Resources.carta2;
              checagem = 1;
          }
          if (img4 == 1)
          {
              pictureBox4.Image = TrabalhoJogoDaMemoria1.Properties.Resources.carta3;
              checagem = 1;
          }
          if (img8 == 1)
          {
              pictureBox8.Image = TrabalhoJogoDaMemoria1.Properties.Resources.carta3;
              checagem = 1;
          }
          if (img5 == 1)
          {
              pictureBox5.Image = TrabalhoJogoDaMemoria1.Properties.Resources.carta4;
              checagem = 1;
          }
          if (img7 == 1)
          {
              pictureBox7.Image = TrabalhoJogoDaMemoria1.Properties.Resources.carta4;
              checagem = 1;
          }
            #endregion
            #region Certo
            if (checagem == 1)
            {
                if (img1 == 1 && img6 == 1 && par1 == 0)
                {
                    cartasEncontradas++;
                    pictureBox1.Enabled = false;
                    pictureBox6.Enabled = false;
                    checagem = 0;
                    label2.Text = Convert.ToString(cartasEncontradas);
                    par1 = 1;
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;
                    await Task.Delay(1000);
                    pictureBox1.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                }

                if (img2 == 1 && img3 == 1 && par2 == 0)
                {
                    cartasEncontradas++;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    checagem = 0;
                    label2.Text = Convert.ToString(cartasEncontradas);
                    par2 = 1;
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;
                    await Task.Delay(1000);
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                }
                if (img4 == 1 && img8 == 1 && par3 == 0)
                {
                    cartasEncontradas++;
                    pictureBox4.Enabled = false;
                    pictureBox8.Enabled = false;
                    checagem = 0;
                    label2.Text = Convert.ToString(cartasEncontradas);
                    par3 = 1;
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;
                    await Task.Delay(1000);
                    pictureBox4.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                }
                if (img5 == 1 && img7 == 1 && par4 == 0)
                {
                    cartasEncontradas++;
                    pictureBox5.Enabled = false;
                    pictureBox7.Enabled = false;
                    checagem = 0;
                    label2.Text = Convert.ToString(cartasEncontradas);
                    par4 = 1;
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;
                    await Task.Delay(1000);
                    pictureBox5.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                }
                if (pictureBox1.Visible == false && pictureBox2.Visible == false && pictureBox3.Visible == false && pictureBox4.Visible == false && pictureBox5.Visible == false && pictureBox6.Visible == false && pictureBox7.Visible == false && pictureBox8.Visible == false) {
                    pictureBox11.Enabled = true;
                    pictureBox11.Visible = true;
                    acabou = true;
                    pictureBox11.Image = Properties.Resources.Ganhou;
                }
            }
            #endregion
            #region Errado
            if (checagem == 1)
            {
                if (img1 == 1 && img2 == 1 && (par1 == 0 && par2 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox1.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox2.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;

                    img1 = 0;
                    img2 = 0;
                    checagem = 0;

                }
                if (img1 == 1 && img3 == 1 && (par1 == 0 && par2 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox1.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox3.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img1 = 0;
                    img3 = 0;
                    checagem = 0;
                }
                if (img1 == 1 && img4 == 1 && (par1 == 0 && par3 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox1.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox4.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img1 = 0;
                    img4 = 0;
                    checagem = 0;
                }
                if (img1 == 1 && img5 == 1 && (par1 == 0 && par4 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox1.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox5.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img1 = 0;
                    img5 = 0;
                    checagem = 0;
                }
                if (img1 == 1 && img7 == 1 && (par1 == 0 && par4 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox1.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox7.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img1 = 0;
                    img7 = 0;
                    checagem = 0;
                }
                if (img1 == 1 && img8 == 1 && (par1 == 0 && par3 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox1.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox8.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img1 = 0;
                    img8 = 0;
                    checagem = 0;
                }
                if (img2 == 1 && img4 == 1 && (par2 == 0 && par3 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox2.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox4.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img2 = 0;
                    img4 = 0;
                    checagem = 0;
                }
                if (img2 == 1 && img5 == 1 && (par2 == 0 && par4 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox2.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox5.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img2 = 0;
                    img5 = 0;
                    checagem = 0;
                }
                if (img2 == 1 && img6 == 1 && (par2 == 0 && par1 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox2.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox6.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img2 = 0;
                    img6 = 0;
                    checagem = 0;
                }
                if (img2 == 1 && img7 == 1 && (par2 == 0 && par3 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox2.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox7.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img2 = 0;
                    img7 = 0;
                    checagem = 0;
                }
                if (img2 == 1 && img8 == 1 && (par2 == 0 && par3 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox2.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox8.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img2 = 0;
                    img8 = 0;
                    checagem = 0;
                }
                if (img3 == 1 && img4 == 1 && (par2 == 0 && par3 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox3.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox4.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img3 = 0;
                    img4 = 0;
                    checagem = 0;
                }
                if (img3 == 1 && img5 == 1 && (par2 == 0 && par4 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox3.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox5.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img3 = 0;
                    img5 = 0;
                    checagem = 0;
                }
                if (img3 == 1 && img6 == 1 && (par2 == 0 && par1 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox3.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox6.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img3 = 0;
                    img5 = 0;
                    checagem = 0;
                }
                if (img3 == 1 && img7 == 1 && (par2 == 0 && par4 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox3.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox7.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img3 = 0;
                    img7 = 0;
                    checagem = 0;
                }
                if (img3 == 1 && img8 == 1 && (par2 == 0 && par3 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox3.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox8.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img3 = 0;
                    img8 = 0;
                    checagem = 0;
                }
                if (img4 == 1 && img5 == 1 && (par3 == 0 && par4 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox4.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox5.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img4 = 0;
                    img5 = 0;
                    checagem = 0;
                }
                if (img4 == 1 && img6 == 1 && (par3 == 0 && par1 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox4.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox6.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img4 = 0;
                    img6 = 0;
                    checagem = 0;
                }
                if (img4 == 1 && img7 == 1 && (par3 == 0 && par4 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox4.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox7.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img4 = 0;
                    img7 = 0;
                    checagem = 0;
                }
                if (img5 == 1 && img6 == 1 && (par4 == 0 && par1 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox5.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox6.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img5 = 0;
                    img6 = 0;
                    checagem = 0;
                }
                if (img5 == 1 && img8 == 1 && (par4 == 0 && par3 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox5.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox8.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img5 = 0;
                    img8 = 0;
                    checagem = 0;
                }
                if (img6 == 1 && img7 == 1 && (par1 == 0 && par4 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox6.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox7.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img6 = 0;
                    img7 = 0;
                    checagem = 0;
                }
                if (img6 == 1 && img8 == 1 && (par1 == 0 && par3 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox6.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox8.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img6 = 0;
                    img8 = 0;
                    checagem = 0;
                }
                if (img7 == 1 && img8 == 1 && (par4 == 0 && par3 == 0))
                {
                    #region Desativar
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;

                    await Task.Delay(1500);
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    #endregion
                    pictureBox7.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    pictureBox8.Image = TrabalhoJogoDaMemoria1.Properties.Resources.Costas;
                    img7 = 0;
                    img8 = 0;
                    checagem = 0;
                }
            }
            #endregion
        }

    }
}
