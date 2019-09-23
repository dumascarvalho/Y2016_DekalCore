using System;
using System.Media;
using System.Windows.Forms;

namespace DekalCore
{
    public partial class frmPrincipal : Form
    {
        public int Nível, Contador;
        public double Atributo_Físico, Atributo_Mágico, HP;
        public bool Erro, Manter, Player;
        private SoundPlayer Tema;

        public frmPrincipal()
        {
            InitializeComponent();

            Tema = new SoundPlayer(Properties.Resources.Tema);
            Tema.PlayLooping();

            Player = true;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            picFalas.Image = Properties.Resources.Fala_Padrão;

            if (Manter == false)
            {
                Omitir();
            }

            Manter = true;
        }

        public void Omitir()
        {
            Físico.Hide();
            Mágico.Hide();
            HitPoints.Hide();

            lblFísico.Hide();
            lblMágico.Hide();
            lblHP.Hide();

            picFalas.Show();
        }

        public void Exibir()
        {
            Físico.Show();
            Mágico.Show();
            HitPoints.Show();

            lblFísico.Show();
            lblMágico.Show();
            lblHP.Show();

            picFalas.Hide();
        }

        public void Recolher_Atributos()
        {
            try
            {
                Erro = false;

                Atributo_Físico = Convert.ToDouble(txtFísico.Text);
                Atributo_Mágico = Convert.ToDouble(txtMágico.Text);
                HP = Convert.ToDouble(txtHP.Text);

                if (Nível == 0)
                {
                    picFalas.Image = Properties.Resources.Fala_Nível;

                }
            }
            catch (Exception)
            {
                Erro = true;

                picFalas.Image = Properties.Resources.Fala_Erro;
            }
        }

        public void Zerar_Atributos()
        {
            Nível = 0;
            lblRefino.Text = "+" + Nível.ToString();


            txtFísico.Clear();
            txtMágico.Clear();
            txtHP.Clear();

            lblFísico.Text = "";
            lblMágico.Text = "";
            lblHP.Text = "";

            txtFísico.Focus();

            Omitir();
        }

        private void picZerar_Click(object sender, EventArgs e)
        {
            picFalas.Image = Properties.Resources.Fala_Zerar;
            Zerar_Atributos();
        }

        private void txtFísico_MouseHover(object sender, EventArgs e)
        {
            Omitir();
            picFalas.Image = Properties.Resources.Fala_Físico;
        }

        private void txtMágico_MouseHover(object sender, EventArgs e)
        {
            Omitir();
            picFalas.Image = Properties.Resources.Fala_Mágico;
        }

        private void txtHP_MouseHover(object sender, EventArgs e)
        {
            Omitir();
            picFalas.Image = Properties.Resources.Fala_HP;
        }

        private void picRefinar_MouseHover(object sender, EventArgs e)
        {
            picFalas.Image = Properties.Resources.Fala_Refino;
        }

        private void picRefinar_Click(object sender, EventArgs e)
        {
            Recolher_Atributos();
            Manter = true;

            if ((Erro == false) && (Nível > 0))
            {
                switch (Nível)
                {
                    case 1:
                        {
                            lblFísico.Text = (Atributo_Físico * 1.03).ToString();
                            lblMágico.Text = (Atributo_Mágico * 1.03).ToString();
                            lblHP.Text = (HP * 1.03).ToString();
                            break;
                        }
                    case 2:
                        {
                            lblFísico.Text = (Atributo_Físico * 1.06).ToString();
                            lblMágico.Text = (Atributo_Mágico * 1.06).ToString();
                            lblHP.Text = (HP * 1.06).ToString();
                            break;
                        }
                    case 3:
                        {
                            lblFísico.Text = (Atributo_Físico * 1.09).ToString();
                            lblMágico.Text = (Atributo_Mágico * 1.09).ToString();
                            lblHP.Text = (HP * 1.09).ToString();
                            break;
                        }
                    case 4:
                        {
                            lblFísico.Text = (Atributo_Físico * 1.16).ToString();
                            lblMágico.Text = (Atributo_Mágico * 1.16).ToString();
                            lblHP.Text = (HP * 1.16).ToString();
                            break;
                        }
                    case 5:
                        {
                            lblFísico.Text = (Atributo_Físico * 1.23).ToString();
                            lblMágico.Text = (Atributo_Mágico * 1.23).ToString();
                            lblHP.Text = (HP * 1.23).ToString();
                            break;
                        }
                    case 6:
                        {
                            lblFísico.Text = (Atributo_Físico * 1.3).ToString();
                            lblMágico.Text = (Atributo_Mágico * 1.3).ToString();
                            lblHP.Text = (HP * 1.3).ToString();
                            break;
                        }
                    case 7:
                        {
                            lblFísico.Text = (Atributo_Físico * 1.45).ToString();
                            lblMágico.Text = (Atributo_Mágico * 1.45).ToString();
                            lblHP.Text = (HP * 1.45).ToString();
                            break;
                        }
                    case 8:
                        {
                            lblFísico.Text = (Atributo_Físico * 1.6).ToString();
                            lblMágico.Text = (Atributo_Mágico * 1.6).ToString();
                            lblHP.Text = (HP * 1.6).ToString();
                            break;
                        }
                    case 9:
                        {
                            lblFísico.Text = (Atributo_Físico * 1.75).ToString();
                            lblMágico.Text = (Atributo_Mágico * 1.75).ToString();
                            lblHP.Text = (HP * 1.75).ToString();
                            break;
                        }
                    case 10:
                        {
                            lblFísico.Text = (Atributo_Físico * 2.15).ToString();
                            lblMágico.Text = (Atributo_Mágico * 2.15).ToString();
                            lblHP.Text = (HP * 2.15).ToString();
                            break;
                        }
                    case 11:
                        {
                            lblFísico.Text = (Atributo_Físico * 2.55).ToString();
                            lblMágico.Text = (Atributo_Mágico * 2.55).ToString();
                            lblHP.Text = (HP * 2.95).ToString();
                            break;
                        }
                    case 12:
                        {
                            lblFísico.Text = (Atributo_Físico * 2.95).ToString();
                            lblMágico.Text = (Atributo_Mágico * 2.95).ToString();
                            lblHP.Text = (HP * 2.95).ToString();
                            break;
                        }
                }

                Exibir();
            }
        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void picFechar_MouseHover(object sender, EventArgs e)
        {
            Omitir();
            picFalas.Image = Properties.Resources.Fala_Fechar;
            picFechar.Image = Properties.Resources.Fechar_Hover;
        }

        private void picFechar_MouseLeave(object sender, EventArgs e)
        {
            picFechar.Image = Properties.Resources.Fechar_Leave;
        }

        private void refNível_01_Click(object sender, EventArgs e)
        {
            Nível = 1;
            lblRefino.Text = "+" + Nível.ToString();
        }

        private void refNível_02_Click(object sender, EventArgs e)
        {
            Nível = 2;
            lblRefino.Text = "+" + Nível.ToString();
        }

        private void refNível_03_Click(object sender, EventArgs e)
        {
            Nível = 3;
            lblRefino.Text = "+" + Nível.ToString();
        }

        private void refNível_04_Click(object sender, EventArgs e)
        {
            Nível = 4;
            lblRefino.Text = "+" + Nível.ToString();
        }

        private void refNível_05_Click(object sender, EventArgs e)
        {
            Nível = 5;
            lblRefino.Text = "+" + Nível.ToString();
        }

        private void refNível_06_Click(object sender, EventArgs e)
        {
            Nível = 6;
            lblRefino.Text = "+" + Nível.ToString();
        }

        private void refNível_07_Click(object sender, EventArgs e)
        {
            Nível = 7;
            lblRefino.Text = "+" + Nível.ToString();
        }

        private void refNível_08_Click(object sender, EventArgs e)
        {
            Nível = 8;
            lblRefino.Text = "+" + Nível.ToString();
        }

        private void refNível_09_Click(object sender, EventArgs e)
        {
            Nível = 9;
            lblRefino.Text = "+" + Nível.ToString();
        }

        private void refNível_10_Click(object sender, EventArgs e)
        {
            Nível = 10;
            lblRefino.Text = "+" + Nível.ToString();
        }

        private void refNível_11_Click(object sender, EventArgs e)
        {
            Nível = 11;
            lblRefino.Text = "+" + Nível.ToString();
        }

        private void refNível_12_Click(object sender, EventArgs e)
        {
            Nível = 12;
            lblRefino.Text = "+" + Nível.ToString();
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Contador++;

            if (Contador >= 3)
            {
                picFalas.Image = Properties.Resources.Fala_Vazia;
            }
        }

        private void frmPrincipal_MouseHover(object sender, EventArgs e)
        {
            if (Temporizador.Enabled == false)
            {
                Temporizador.Start();
            }
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (Temporizador.Enabled == false)
            {
                Temporizador.Start();
            }
        }

        private void frmPrincipal_MouseLeave(object sender, EventArgs e)
        {
            Contador = 0;
            Temporizador.Enabled = false;
            Temporizador.Stop();
        }

        private void picPlayPause_MouseHover(object sender, EventArgs e)
        {
            if (Player == true)
            {
                picFalas.Image = Properties.Resources.Fala_Pausar;
            }
            else
            {
                picFalas.Image = Properties.Resources.Fala_Tocar;
            }
        }

        private void picPlayPause_Click(object sender, EventArgs e)
        {
            if (Player == true)
            {
                Tema.Stop();
                Player = false;
            }
            else
            {
                Tema.PlayLooping();
                Player = true;
            }
        }
    }
}
