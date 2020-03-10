//the main form for chosing a section
using System;
using System.Windows.Forms;

namespace LearnProgrammingTool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            MaximizeBox = false; //stop the user making the form larger
        }

        private void cmbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMain.SelectedIndex)
            {
                //show the Introduction section
                case 0:
                    cmbMain.SelectedItem.Equals("Introduction");
                    frmIntroduction introduction = new frmIntroduction();
                    introduction.ShowDialog(this);
                    break;

                //show the Variables section
                case 1:
                    cmbMain.SelectedItem.Equals("Variables");
                    frmVariables variables = new frmVariables();
                    variables.ShowDialog(this);
                    break;
                
                //show the Input and Output section
                case 2:
                    cmbMain.SelectedItem.Equals("Input and Output");
                    frmInputAndOutput inputAndOutput = new frmInputAndOutput();
                    inputAndOutput.ShowDialog(this);
                    break;
                
                //show the Logic section
                case 3:
                    cmbMain.SelectedItem.Equals("Logic");
                    frmLogic logic = new frmLogic();
                    logic.ShowDialog(this);
                    break;
                
                //show the Calculation section
                case 4:
                    cmbMain.SelectedItem.Equals("Calculation");
                    frmCalculation calculation = new frmCalculation();
                    calculation.ShowDialog(this);
                    break;

                //show the If Statements section
                case 5:
                    cmbMain.SelectedItem.Equals("If Statements");
                    frmIfStatements ifStatements = new frmIfStatements();
                    ifStatements.ShowDialog(this);
                    break;
                
                //show the Cases section
                case 6:
                    cmbMain.SelectedItem.Equals("Cases");
                    frmCases cases = new frmCases();
                    cases.ShowDialog(this);
                    break;
                
                //show the Loops section
                case 7:
                    cmbMain.SelectedItem.Equals("Loops");
                    frmLoops loops = new frmLoops();
                    loops.ShowDialog(this);
                    break;

                //show the Validation section
                case 8:
                    cmbMain.SelectedItem.Equals("Validation");
                    frmValidation validation = new frmValidation();
                    validation.ShowDialog(this);
                    break;
                
                //UPDATE: this is now deleted
                /*
                //show the Advanced section
                case 9:
                    cmbMain.SelectedItem.Equals("Advanced");
                    frmAdvanced advanced = new frmAdvanced();
                    advanced.ShowDialog(this);
                    break;
                */

                //show the Recap section
                case 9/*10*/:
                    cmbMain.SelectedItem.Equals("Recap");
                    frmRecap recap = new frmRecap();
                    recap.ShowDialog(this);
                    break;
                
                //just in case
                default:
                    break;
            }
        }
    }
}
