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
    public partial class Form2 : Form
    {
        public Form2(Child child)
        {
            InitializeComponent();

            lstbxName.Text = child.Name.ToString();
            lstbxSport.Text = child.Sport.ToString();

            label2.Text = child.Name.ToString();


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
