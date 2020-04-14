//the form for learning Calculation section
using System;
using System.Windows.Forms;

namespace LearnProgrammingTool
{
    public partial class frmCalculation : Form
    {
        private int scoreAnswer;
        private int finalScore;
        private int counter;
        private int questionNumber;
        private int reset;
        private string progress;
        private string notReady;
        private string ready;
        private string answer;
        private bool canShowScore;

        public frmCalculation()
        {
            InitializeComponent();
            MaximizeBox = false; //stop the user making the form larger
        }

        private void frmCalculation_Load(object sender, EventArgs e)
        {
            calculation_QuestionsTableAdapter.Fill(exercisesDataSet.Calculation_Questions); //get the questions table from the database
            calculation_AnswersTableAdapter.Fill(exercisesDataSet.Calculation_Answers); //get the answers table from the database
           
            //set values of ints
            scoreAnswer = 0;
            finalScore = 0;
            reset = 0;
            counter = 0;
            questionNumber = 1;

            //set the question progress and show question number to the user
            progress = questionNumber + "/20";
            txtQuestionNumber.Text = progress.ToString();

            canShowScore = false; //don't show score until all the questions have been answered
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            answer = answerTextBox.Text; //get the current answer text loaded from the database

            //validation (warns user and stops user advancing if they haven't chosen an option)
            if (cmbQuestion.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose an option", "Error");
                return;
            }

            //user got question right so add 1 to their score
            else if (cmbQuestion.SelectedItem.Equals(answer) && !canShowScore)
            {
                scoreAnswer = 1;
            }

            //user got question wrong so add nothing to their score
            else
            {
                scoreAnswer = 0;
            }

            finalScore += scoreAnswer; //update score
            calculation_QuestionsBindingSource.MoveNext(); //show next question 
            calculation_AnswersBindingSource.MoveNext(); //update next answer

            counter++; //keep track of the button clicks
            questionNumber++; //keep count of questions

            //update the question progress and show current question number to the user
            progress = questionNumber + "/20";
            txtQuestionNumber.Text = progress.ToString();

            for (int i = 20; i <= counter; i++)
            {
                counter--; //stop keeping track of counter
                questionNumber--; //stop keeping track of questions count

                //let user know they can see the score when all 20 questions have been answered
                if (!canShowScore)
                {
                    ready = "Find out score";
                    txtScore.Text = ready.ToString();
                    canShowScore = true;
                }

                //set the final question progress and show final question number to the user
                progress = questionNumber + "/20";
                txtQuestionNumber.Text = progress.ToString();

                if (finalScore >= 20) //maximum final score and question number can be 20 (in case of error somewhere)
                {
                    finalScore = 20;
                    questionNumber = 20;
                }
            }
        }

        private void btnCheckResults_Click(object sender, EventArgs e)
        {
            //if all questions have been answered then show the score
            if (canShowScore)
            {
                txtScore.Text = finalScore.ToString(); //show score
                finalScore = reset; //reset score if user clicks on button again
            }

            //if all questions have not been answered then tell the user that they haven't finished
            else
            {
                notReady = "Answer all questions";
                txtScore.Text = notReady.ToString();
            }
        }
    }
}
