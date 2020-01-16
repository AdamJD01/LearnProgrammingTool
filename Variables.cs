using System;
using System.Windows.Forms;

namespace LearnProgrammingTool
{
    public partial class frmVariables : Form
    {
        private int scoreQuestion1;
        private int scoreQuestion2;
        private int finalScore;

        public frmVariables()
        {
            InitializeComponent();
            MaximizeBox = false; //stop the user making the form larger
    }

        private void btnNextQuestion1_Click(object sender, EventArgs e)
        {
            //TO DO: For now this is hard coded but in future the options for the combo boxes will need to be connected to a database

            //validation
            if (cmbQuestion1.SelectedIndex < 0 || cmbQuestion2.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose an option");
            }

            //calculation
            else if (cmbQuestion1.SelectedItem.Equals("String"))
            {
                scoreQuestion1++;
            }

            else if (cmbQuestion2.SelectedItem.Equals("Boolean"))
            {
                scoreQuestion2++;
            }

            finalScore = scoreQuestion1 + scoreQuestion2;

            if(finalScore > 2)
            {
               finalScore = 2;
            }

            //output
            txtScore.Text = finalScore.ToString();
        }
    }
}
