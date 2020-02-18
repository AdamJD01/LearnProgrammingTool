using System;
using System.Windows.Forms;

namespace LearnProgrammingTool
{
    public partial class frmVariables : Form
    {
        private int scoreAnswer;
        private int finalScore;
        private string answer;

        public frmVariables()
        {
            InitializeComponent();
            MaximizeBox = false; //stop the user making the form larger
        }

        private void frmVariables_Load(object sender, EventArgs e)
        {
            variables_QuestionsTableAdapter.Fill(exercisesDataSet.Variables_Questions); //get the questions table from the database
            variables_AnswersTableAdapter.Fill(exercisesDataSet.Variables_Answers); //get the answers table from the database
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            answer = answerTextBox.Text; //get the current text in the database

            //validation
            if (cmbQuestion.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose an option");
            }

            //user got question right
            else if (cmbQuestion.SelectedItem.Equals(answer)) 
            {
                scoreAnswer = 1;
                finalScore += scoreAnswer;
                variables_QuestionsBindingSource.MoveNext(); //show next question 
                variables_AnswersBindingSource.MoveNext(); //show next answer

                if (finalScore >= 20) //maximum questions are 20
                {
                    finalScore = 20;
                }
                txtScore.Text = finalScore.ToString(); //for testing
            }

            //user got question wrong
            else
            {
                scoreAnswer = 0;
                finalScore += scoreAnswer;
                variables_QuestionsBindingSource.MoveNext(); //show next question
                variables_AnswersBindingSource.MoveNext(); // show next answer

                if (finalScore >= 20) //maximum questions are 20
                {
                    finalScore = 20;
                }
                txtScore.Text = finalScore.ToString(); //for testing
            }
        }

        //OLD
        /*
        private void btnVariableQuestion1_Click(object sender, EventArgs e)
        {
            //TO DO: For now this is hard coded but eventually the options for the combo boxes will be connected to a database
  
            //validation
            if (cmbVariableQuestion1.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose an option");
                grpVariableQuestion1.Visible = true;
                grpVariableQuestion2.Visible = false;
            }

            //first question
            else if (cmbVariableQuestion1.SelectedItem.Equals("String")) 
            {
                scoreAnswer = 1;
                finalScore += scoreAnswer;
                grpVariableQuestion1.Visible = false;
                grpVariableQuestion2.Visible = true;
            }

            //second question
            else if (cmbVariableQuestion2.SelectedItem.Equals("Boolean"))
            {
                scoreAnswer = 1;
                finalScore += scoreAnswer;
                grpVariableQuestion2.Visible = false;

                //for testing
                grpVariableScore.Visible = true;
                txtScore.Text = finalScore.ToString();
            }
            
            //got question wrong
            else
            {
                scoreAnswer = 0;
                finalScore += scoreAnswer;
                grpVariableQuestion1.Visible = false;
                grpVariableQuestion2.Visible = false;

                //for testing
                grpVariableScore.Visible = true;
                txtScore.Text = finalScore.ToString();
            }
        }
        */

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
