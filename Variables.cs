using System;
using System.Windows.Forms;

namespace LearnProgrammingTool
{
    public partial class frmVariables : Form
    {
        private int score = 0;
        //private int scoreDummy = 0;

        public frmVariables()
        {
            InitializeComponent();
            MaximizeBox = false; //stop the user making the form larger
        }

        private void btnNextQuestion1_Click(object sender, EventArgs e)
        {
            //TO DO: For now this is hard coded but in future the options for the combo boxes will need to be connected to a database

            //validation
            if (cmbQuestion1.Equals("") || cmbQuestion2.Equals(""))
            {
                MessageBox.Show("Please choose an option");
                txtScore.Text = score.ToString();
            }

            //calculation
            else if (cmbQuestion1.SelectedItem.Equals("String"))
            {
                score += 1;
            }

            else if (cmbQuestion2.SelectedItem.Equals("Boolean"))
            {
                score += 1;
            }

            //else
            //{
            //   score += scoreDummy;
            //}

            //output
            txtScore.Text = score.ToString();
        }
    }
}
