using System;
using System.Windows.Forms;

namespace LearnProgrammingTool
{
    public partial class frmVariables : Form
    {
        private int scoreAnswer;
        private int finalScore;
        private int counter;
        private int questionNumber;
        private int reset;
        private string progress;
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
            //set values of ints
            scoreAnswer = 0;
            finalScore = 0;
            reset = 0;
            questionNumber = 1;
            counter = 1;

            //set the question progress and show current question number to the user
            //questionNumber = counter; 
            progress = questionNumber + "" + "/20";

            txtQuestionNumber.Text = progress.ToString();
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            answer = answerTextBox.Text; //get the current answer text loaded from the database

            //validation
            if (cmbQuestion.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose an option");
            }

            //user got question right
            else if (cmbQuestion.SelectedItem.Equals(answer) && counter < 20) 
            {
                scoreAnswer = 1;
                //reset = 0;
                finalScore += scoreAnswer;
                variables_QuestionsBindingSource.MoveNext(); //show next question 
                variables_AnswersBindingSource.MoveNext(); //update next answer
 
                counter++; //keep track of the button clicks
                questionNumber++; //keep count of questions

                //questionNumber = counter;
                progress = questionNumber + "" + "/20";
                txtQuestionNumber.Text = progress.ToString();

                for (int i = 20; i < counter; i++)
                {
                    counter--; //reset counter
                    questionNumber--; //reset questions count
                    txtScore.Text = finalScore.ToString(); //show score

                    finalScore = reset; //reset score if button is clicked after showing score

                    //questionNumber = counter;
                    progress = questionNumber + "" + "/20";
                    txtQuestionNumber.Text = progress.ToString();

                    if (finalScore >= 20) //maximum final score and question number can be 20 (in case of error somewhere)
                    {
                        finalScore = 20;
                        questionNumber = 20;
                    }

                    /*
                    if (questionNumber >= 20) //reset score if finished 
                    {
                        finalScore = reset;
                        scoreAnswer = reset;
                    }
                    */
                }
            }

            //user got question wrong
            else
            {
                scoreAnswer = 0;
                //reset = 0;
                finalScore += scoreAnswer;
                variables_QuestionsBindingSource.MoveNext(); //show next question
                variables_AnswersBindingSource.MoveNext(); //update next answer

                counter++; //keep track of the button clicks
                questionNumber++; //keep count of questions

                //questionNumber = counter;
                progress = questionNumber + "" + "/20";
                txtQuestionNumber.Text = progress.ToString();

                for (int i = 20; i < counter; i++)
                {
                    counter--; //reset counter
                    questionNumber--; //rest question count
                    txtScore.Text = finalScore.ToString(); //show score

                    finalScore = reset; //reset score if button is clicked after showing score

                    //questionNumber = counter;
                    progress = questionNumber + "" + "/20";
                    txtQuestionNumber.Text = progress.ToString();

                    if (finalScore >= 20) //maximum final score and question number can be 20 (in case of error somewhere)
                    {
                        finalScore = 20;
                        questionNumber = 20;
                    }

                    /*
                    if (questionNumber >= 20) //reset score if finished 
                    {
                        finalScore = reset;
                        scoreAnswer = reset;
                    }
                    */
                }
            }
        }

        //OLD
        /*
        private void btnVariableQuestion_Click(object sender, EventArgs e)
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
