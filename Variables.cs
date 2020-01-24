using System;
using System.Windows.Forms;

namespace LearnProgrammingTool
{
    public partial class frmVariables : Form
    {
        private int scoreQuestion1;
        private int scoreQuestion2;
        private int finalScore;
        private string answer1;
        private string answer2;

        public frmVariables()
        {
            InitializeComponent();
            MaximizeBox = false; //stop the user making the form larger
        }

        private void btnNextQuestion1_Click(object sender, EventArgs e)
        {
            //TO DO: For now this is hard coded but in future the options for the combo boxes will need to be connected to a database

            answer1 = "String";
            answer2 = "Boolean";

            //validation
            if (cmbQuestion1.SelectedIndex < 0 || cmbQuestion2.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose an option");
            }

            //calculation
            else if (cmbQuestion1.SelectedItem.Equals("String"))
            {
                scoreQuestion1 = 1;
            }

            else if (cmbQuestion1.Text != answer1)
            {
                scoreQuestion1 = 0;
            }

            else if (cmbQuestion2.SelectedItem.Equals("Boolean"))
            {
                scoreQuestion2 = 1;
            }

            else if (cmbQuestion2.Text != answer2)
            {
                scoreQuestion2 = 0;
            }

            finalScore = scoreQuestion1 + scoreQuestion2;

            //output
            txtScore.Text = finalScore.ToString();
        }
    }
}
