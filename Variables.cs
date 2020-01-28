using System;
using System.Windows.Forms;

namespace LearnProgrammingTool
{
    public partial class frmVariables : Form
    {
        private int scoreAnswer1;
        private int scoreAnswer2;
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
                scoreAnswer1 = 0;
                scoreAnswer2 = 0;
            }

            //calculation
            else if (cmbQuestion1.SelectedItem.Equals("String") && cmbQuestion2.SelectedItem.Equals("Boolean"))
            {
                scoreAnswer1 = 1;
                scoreAnswer2 = 1;
            }

            else if (cmbQuestion1.SelectedItem.Equals("String") || cmbQuestion2.SelectedItem.Equals("Boolean"))
            {
                scoreAnswer1 = 1;
                scoreAnswer2 = 0;
            }

            else 
            {
                scoreAnswer1 = 0;
                scoreAnswer2 = 0;
            }

            finalScore = scoreAnswer1 + scoreAnswer2;

            //output
            txtScore.Text = finalScore.ToString();
        }
    }
}
