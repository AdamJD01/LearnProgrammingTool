using System;
using System.Windows.Forms;

namespace LearnProgrammingTool
{
    public partial class frmVariables : Form
    {
        private int scoreAnswer;
        private int finalScore;
        //private string answer;

        public frmVariables()
        {
            InitializeComponent();
            MaximizeBox = false; //stop the user making the form larger
        }

        private void btnQuestion1_Click(object sender, EventArgs e)
        {
            //answer = answerTextBox.Text;
            //validation
            if (cmbQuestion1.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose an option");
            }

            //calculation
            else if (cmbQuestion1.SelectedItem.Equals(answerTextBox/*"String"*/))
            {
                scoreAnswer = 1;
                finalScore = scoreAnswer;
                txtScore.Text = finalScore.ToString(); //for testing
            }

            else
            {
                scoreAnswer = 0;
                finalScore = scoreAnswer;
                txtScore.Text = finalScore.ToString(); //for testing
            }
        }

        private void btnVariableQuestion1_Click(object sender, EventArgs e)
        {
            //TO DO: For now this is hard coded but in future the options for the combo boxes will need to be connected to a database
            /*
            //validation
            if (cmbVariableQuestion1.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose an option");
                grpVariableQuestion1.Visible = true;
                grpVariableQuestion2.Visible = false;
            }

            //calculation
            else if (cmbVariableQuestion1.SelectedItem.Equals("String")) 
            {
                scoreAnswer = 1;
                finalScore = scoreAnswer;
                grpVariableQuestion1.Visible = false;
                grpVariableQuestion2.Visible = true;
            }

            else
            {
                scoreAnswer = 0;
                finalScore = scoreAnswer;
                grpVariableQuestion1.Visible = false;
                grpVariableQuestion2.Visible = true;
            }
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            //TO DO: For now this is hard coded but in future the options for the combo boxes will need to be connected to a database

            //validation
            if (cmbVariableQuestion1.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose an option");
                grpVariableQuestion2.Visible = true;
                //grpVariableQuestion3.Visible = false;
                grpVariableScore.Visible = false; //for testing
            }

            //calculation
            else if (cmbVariableQuestion1.SelectedItem.Equals("Boolean"))
            {
                scoreAnswer += 1;
                finalScore += scoreAnswer;
                grpVariableQuestion2.Visible = false;
                //grpVariableQuestion3.Visible = true;

                //for testing
                grpVariableScore.Visible = true;
                txtScore.Text = finalScore.ToString();
            }

            else
            {
                scoreAnswer += 0;
                finalScore += scoreAnswer;
                grpVariableQuestion2.Visible = false;
                //grpVariableQuestion3.Visible = true;

                //for testing
                grpVariableScore.Visible = true;
                txtScore.Text = finalScore.ToString();
            }
            */
        }
        
        private void frmVariables_Load(object sender, EventArgs e)
        {
            variables_QuestionsTableAdapter.Fill(exercisesDataSet.Variables_Questions);
            variables_AnswersTableAdapter.Fill(exercisesDataSet.Variables_Answers);
        }

        private void variablesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
        }

        private void variables_QuestionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            variables_QuestionsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(exercisesDataSet);
        }
    }
}
