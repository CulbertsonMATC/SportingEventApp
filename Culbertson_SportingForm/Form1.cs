using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Culbertson_SportingForm
{
    public partial class Form1 : Form
    {
        Child child;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radBiking_CheckedChanged(object sender, EventArgs e)
        {
            previewBox.Visible = true;
            previewBox.Image = Properties.Resources.downhill_mtb_snow;
            lblCaption.Text = "Biking";
        }

        private void radSkating_CheckedChanged(object sender, EventArgs e)
        {
            previewBox.Visible = true;
            previewBox.Image = Properties.Resources.GettyImages_639374172;
            lblCaption.Text = "Skating";
        }

        private void radSnowboarding_CheckedChanged(object sender, EventArgs e)
        {
            previewBox.Visible = true;
            previewBox.Image = Properties.Resources.ski_resorts_snowbird_markewitz_dsc2227;
            lblCaption.Text = "Snowboarding";
        }

        private void radSkiing_CheckedChanged(object sender, EventArgs e)
        {
            previewBox.Visible = true;
            previewBox.Image = Properties.Resources.guided_backcountry_skiing_16_9;
            lblCaption.Text = "Skiing";
        }

        private void radSnowmobiling_CheckedChanged(object sender, EventArgs e)
        {
            previewBox.Visible = true;
            previewBox.Image = Properties.Resources.snowmobile_rentals_vail;
            lblCaption.Text = "Snowmobiling";
        }

        private void radHiking_CheckedChanged(object sender, EventArgs e)
        {
            previewBox.Visible = true;
            previewBox.Image = Properties.Resources.State_Park___Copper_Falls___Winter_People_2;
            lblCaption.Text = "Hiking";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string sport;
            if (radBiking.Checked)
                sport = "Mountain Biking";
            else if (radSkating.Checked)
                sport = "Ice Skating";
            else if (radSnowboarding.Checked)
                sport = "Snowboarding";
            else if (radSkiing.Checked)
                sport = "Skiing";
            else if (radSnowmobiling.Checked)
                sport = "Snowmobiling";
            else if (radHiking.Checked)
                sport = "Hiking";
            else
                sport = "TBD";

            child = new Child(txtbxName.Text, txtbxAddress.Text, txtbxCity.Text, cmbxState.Text, sport);
        }

        private void grpbxWinterSports_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            Form2 results = new Form2(child);
            results.ShowDialog();
        }
    }
}
