using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_avulso_2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();            
        }

        string num1 = "", num2 = "";
        string candidato = "";
        int candidato12 = 0, candidato22 = 0, candidato30 = 0, candidato13 = 0, candidato15 = 0, candidato44 = 0, votoBranco = 0, votoNulo = 0;
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (candidato == "12")
            {
                candidato12++;
                lblMostraCiro.Visible = true;
                lblMostraCiro.Text = candidato12.ToString();
            }
            else if (candidato == "22")
            {
                candidato22++;
                lblMostraBolsonaro.Visible = true;
                lblMostraBolsonaro.Text = candidato22.ToString();
            } 
            else if (candidato == "30")
            {
                candidato30++;
                lblMostradAvila.Visible = true;
                lblMostradAvila.Text = candidato30.ToString();
            }
            else if (candidato == "13")
            {
                candidato13++;
                lblMostraLula.Visible = true;
                lblMostraLula.Text = candidato13.ToString();
            } 
            else if (candidato == "15")
            {
                candidato15++;
                lblMostraSimone.Visible = true;
                lblMostraSimone.Text = candidato15.ToString();
            } 
            else if (candidato == "44")
            {
                candidato44++;
                lblMostraSoraya.Visible = true;
                lblMostraSoraya.Text = candidato44.ToString();
            } 
            else if (candidato == "--")
            {
                votoBranco++;
                lblMostraBranco.Visible = true;
                lblMostraBranco.Text = votoBranco.ToString();

            }
            else
            {
                votoNulo++;
                lblMostraNulos.Visible = true;
                lblMostraNulos.Text = votoNulo.ToString();
            }
            num1 = "";
            num2 = "";
            candidato = "";
            imgCandidato.Image = null;
            lblMostraNomeCand.Visible = false;
            lblMostraNomeCand.Text = "";
            lblMostraPartidoCand.Visible = false;
            lblMostraPartidoCand.Text = "";
            lblMostraNumeroCand.Text = candidato;
        }

        private void validaCandidato(string numDigitado)
        {
            if (num1 == "")
            {
                num1 = numDigitado;
                lblMostraNumeroCand.Visible = true;
                lblMostraNumeroCand.Text = num1;
                return;
            } 
            else if (num2 == "")
            {
                num2 = numDigitado;
                lblMostraNumeroCand.Visible = true;
                lblMostraNumeroCand.Text = num1 + num2;
            } 
            else
            {
                return;
            }

            candidato = num1 + num2;
            lblMostraPartidoCand.Visible = true;
            lblMostraPartidoCand.Text = candidato;

            if (candidato == "12")
            {
                imgCandidato.Image = imageList.Images[0];
                lblMostraNomeCand.Visible = true;
                lblMostraNomeCand.Text = "CIRO GOMES";
                lblMostraPartidoCand.Visible = true;
                lblMostraPartidoCand.Text = "PDT";

            }
            else if (candidato == "22")
            {
                imgCandidato.Image = imageList.Images[1];
                lblMostraNomeCand.Visible = true;
                lblMostraNomeCand.Text = "JAIR BOLSONARO";
                lblMostraPartidoCand.Visible = true;
                lblMostraPartidoCand.Text = "PL";
            }
            else if (candidato == "30")
            {
                imgCandidato.Image = imageList.Images[2];
                lblMostraNomeCand.Visible = true;
                lblMostraNomeCand.Text = "LUIZ FELIPE D'AVILA";
                lblMostraPartidoCand.Visible = true;
                lblMostraPartidoCand.Text = "NOVO";
            }
            else if (candidato == "13")
            {
                imgCandidato.Image = imageList.Images[3];
                lblMostraNomeCand.Visible = true;
                lblMostraNomeCand.Text = "LULA";
                lblMostraPartidoCand.Visible = true;
                lblMostraPartidoCand.Text = "PT";
            }
            else if (candidato == "15")
            {
                imgCandidato.Image = imageList.Images[4];
                lblMostraNomeCand.Visible = true;
                lblMostraNomeCand.Text = "SIMONE TEBET";
                lblMostraPartidoCand.Visible = true;
                lblMostraPartidoCand.Text = "PMDB";
            }
            else if (candidato == "44")
            {
                imgCandidato.Image = imageList.Images[5];
                lblMostraNomeCand.Visible = true;
                lblMostraNomeCand.Text = "SORAYA THRONICKE";
                lblMostraPartidoCand.Visible = true;
                lblMostraPartidoCand.Text = "UNIÃO BRASIL";
            }
            else if (candidato == "--")
            {
                imgCandidato.Image = null;
                lblMostraNumeroCand.Visible = true;
                lblMostraNumeroCand.Text = "Voto em Branco!";
                lblMostraNomeCand.Visible = false;
                lblMostraPartidoCand.Visible = false;
            }
            else
            {
                imgCandidato.Image = null;
                lblMostraNumeroCand.Visible = true;
                lblMostraNumeroCand.Text = "Voto nulo!";
                lblMostraPartidoCand.Visible = false;
                lblMostraNomeCand.Visible = false;
            }
        }
        private void btnNum1_Click(object sender, EventArgs e)
        {
            validaCandidato("1");

        }
        private void btnNum2_Click(object sender, EventArgs e)
        {
            validaCandidato("2");
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            validaCandidato("3");
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            validaCandidato("4");
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            validaCandidato("5");
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            validaCandidato("6");
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            validaCandidato("7");
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            validaCandidato("8");
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            validaCandidato("9");
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            validaCandidato("0");
        }
        private void btnBranco_Click(object sender, EventArgs e)
        {
            num1 = "";
            num2 = "";
            validaCandidato("-");
            validaCandidato("-");
        }
        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            if (num2 != "")
            {
                num2 = "";
            } 
            else
            {
                num1 = "";
            }
            candidato = num1 + num2;

            imgCandidato.Image = null;
            lblMostraNomeCand.Visible = false;
            lblMostraNomeCand.Text = "";
            lblMostraPartidoCand.Visible = false;
            lblMostraPartidoCand.Text = "";
            lblMostraNumeroCand.Text = candidato;
        }        
    }
}
