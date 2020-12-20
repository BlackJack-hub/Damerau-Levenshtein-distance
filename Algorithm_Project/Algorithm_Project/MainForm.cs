using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Project
{
    public partial class MainForm : Form
    {
        private DamerauLevenshteinDistance damerauLevenshteinDistance=new DamerauLevenshteinDistance();
        private int[,] arrayD;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckText())
            {
                return;
            }

            string first=textBoxFirst.Text;
            string second = textBoxSecond.Text;

            labelResult.Visible = true;
            labedistance.Visible = true;
            buttonVisualization.Visible = true;

            arrayD = new int[first.Length+1, second.Length+1];

            labedistance.Text = damerauLevenshteinDistance.DamerauLevenshteinDistanceResult(ref arrayD,first, second).ToString();
        }

        private bool CheckText()
        {
            bool check = true;

            if (textBoxFirst.Text == "")
            {
                labelError1.Visible = true;
                check = false;
            }
            else
            {
                labelError1.Visible = false;
            }

            if (textBoxSecond.Text == "")
            {
                labelError2.Visible = true;
                check = false;
            }
            else
            {
                labelError2.Visible = false;
            }

            if (!check)
            {
                labelResult.Visible = false;
                labedistance.Visible = false;
                buttonVisualization.Visible = false;
            }
            
            return check;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visualization visualization = new Visualization(ref arrayD,textBoxFirst.Text.Length,textBoxSecond.Text.Length,textBoxFirst.Text,textBoxSecond.Text);
            visualization.Show();
        }

        private void textBoxFirst_TextChanged(object sender, EventArgs e)
        {
            buttonVisualization.Visible = false;
        }

        private void textBoxSecond_TextChanged(object sender, EventArgs e)
        {
            buttonVisualization.Visible = false;
        }
    }
}
