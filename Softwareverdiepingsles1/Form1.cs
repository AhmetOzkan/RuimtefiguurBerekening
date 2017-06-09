using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softwareverdiepingsles1
{
    public partial class Form1 : Form
    {
        string vorm = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Lengte, breedte, diameter;
            double oppervlakte, pi;

            switch (vorm)
            {
                case "balk":
                    Lengte = int.Parse(tbLengte1.Text);
                    breedte = int.Parse(tbBreedte1.Text);
                    oppervlakte = Lengte * breedte;
                    lblOppervlakte.Text = "De oppervlakte van een balk " +
                        " met lengte " + Lengte + " cm en breedte " + breedte + " cm is " + oppervlakte + " vierkante centimeter.";
                    break;
                case "cilinder":
                    diameter = int.Parse(tbDiameter.Text);
                    pi = Math.PI;
                    oppervlakte = Math.Round(pi * Math.Pow((diameter / 2),2),1);
                    lblOppervlakte.Text = " De oppervlakte van een cilinder " +
                        " met een diameter van " + diameter + " cm is " +
                        oppervlakte + " vierkante cm "; 
                    break;
                case "pyramide":
                    Lengte = int.Parse(tbLengte1.Text);
                    breedte = int.Parse(tbBreedte1.Text);
                    oppervlakte = Lengte * breedte;
                    lblOppervlakte.Text = "De oppervlakte van een pyramide " +
                        " met lengte " + Lengte + " cm en breedte " + breedte + " cm is " + oppervlakte + " vierkante centimeter.";
                    break;
                case "trapezium":
                    Lengte = int.Parse(tbLengte1.Text);
                    breedte = int.Parse(tbBreedte1.Text);
                    oppervlakte = Lengte * breedte;
                    lblOppervlakte.Text = "De oppervlakte van een trapezium " +
                        "met lengte " + Lengte + " cm en breedte " + breedte + " cm is " + oppervlakte + " vierkante centimeter.";
                    break;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            vorm = "cilinder";
            tbLengte1.Visible = false;
            lblLengte.Visible = false;
            tbLengte2.Visible = false;
            tbBreedte2.Visible = false;
            lblDiameter.Visible = true;
            tbDiameter.Visible = true;
            pbPlaatje.Image = (Image)Properties.Resources.tekening_cilinder;
            lblOppervlakte.Text = "";
            lblInhoud.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            vorm = "balk";
            tbLengte1.Visible = true;
            lblLengte.Visible = true;
            tbLengte2.Visible = false;
            tbBreedte2.Visible = false;
            lblDiameter.Visible = false;
            tbDiameter.Visible = false;
            pbPlaatje.Image = (Image)Properties.Resources.tekening_balk;
            lblOppervlakte.Text = "";
            lblInhoud.Text = "";
        }

        private void RBtrapezium_CheckedChanged(object sender, EventArgs e)
        {
            vorm = "trapezium"; 
            tbLengte1.Visible = true;
            lblLengte.Visible = true;
            tbLengte2.Visible = true;
            tbBreedte2.Visible = true;
            lblDiameter.Visible = false;
            tbDiameter.Visible = false;
            pbPlaatje.Image = (Image)Properties.Resources.images;
            lblOppervlakte.Text = "";
            lblInhoud.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Lengte, breedte, diameter, hoogte, Lengte2, breedte2;
            double inhoud, pi;

            switch (vorm)
            {
                case "balk":
                    Lengte = int.Parse(tbLengte1.Text);
                    breedte = int.Parse(tbBreedte1.Text);
                    hoogte = int.Parse(tbHoogte.Text);
                    inhoud = Lengte * breedte * hoogte;
                    lblInhoud.Text = "De inhoud van een balk " +
                        " met lengte " + Lengte + " cm en breedte " + breedte + " cm is " + inhoud + " vierkante centimeter.";
                    break;

                case "cilinder":
                    diameter = int.Parse(tbDiameter.Text);
                    pi = Math.PI;
                    hoogte = int.Parse(tbHoogte.Text);
                    inhoud = Math.Round((pi * Math.Pow((diameter / 2), 2) * hoogte), 1);
                    lblInhoud.Text = " De inhoud van een cilinder " +
                       " met een diameter van " + diameter + " cm en een hoogte van " + hoogte + " is " + 
                        inhoud + " vierkante cm ";
                    break;

                case "pyramide":
                    Lengte = int.Parse(tbLengte1.Text);
                    breedte = int.Parse(tbBreedte1.Text);
                    hoogte = int.Parse(tbHoogte.Text);
                    inhoud = (Lengte * breedte * hoogte) / 3;
                    lblInhoud.Text = "De inhoud van een pyramide " +
                        "met lengte " + Lengte + " cm en breedte " + breedte + " cm  en hoogte van "+ hoogte + " is " + inhoud + " vierkante centimeter.";
                    break;

                case "trapezium":
                    Lengte = int.Parse(tbLengte1.Text);
                    breedte = int.Parse(tbBreedte1.Text);
                    Lengte2 = int.Parse(tbLengte2.Text);
                    breedte2 = int.Parse(tbBreedte2.Text);
                    hoogte = int.Parse(tbHoogte.Text);
                    inhoud = (Lengte - Lengte2) * (breedte - breedte2) * hoogte;
                    lblInhoud.Text = " De inhoud van een trapezium " +
                        " met lengte " + Lengte + " en met een 2de lengte van " + Lengte2 +
                        " en breedte " + breedte + " en een 2de breedte van " + breedte2 +
                        " en hoogte " + hoogte + " = " + inhoud + " kubieke centimeter. ";
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RBpyramide_CheckedChanged(object sender, EventArgs e)
        {
            vorm = "pyramide";
            tbLengte1.Visible = true;
            lblLengte.Visible = true;
            tbLengte2.Visible = false;
            tbBreedte2.Visible = false;
            lblDiameter.Visible = false;
            tbDiameter.Visible = false;
            pbPlaatje.Image = (Image)Properties.Resources.piramide_inl;
            lblOppervlakte.Text = "";
            lblInhoud.Text = "";
        }

        private void lblDiameter_Click(object sender, EventArgs e)
        {

        }

        private void pbPlaatje_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
