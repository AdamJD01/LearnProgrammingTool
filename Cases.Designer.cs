namespace LearnProgrammingTool
{
    partial class frmCases
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label labelAnswer;
            System.Windows.Forms.Label lblQuestion;
            System.Windows.Forms.Label answerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCases));
            this.txtLearning = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.cases_QuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exercisesDataSet = new LearnProgrammingTool.ExercisesDataSet();
            this.btnCheckResults = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtQuestionNumber = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cases_QuestionsTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.Cases_QuestionsTableAdapter();
            this.tableAdapterManager = new LearnProgrammingTool.ExercisesDataSetTableAdapters.TableAdapterManager();
            this.cases_AnswersTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.Cases_AnswersTableAdapter();
            this.cases_AnswersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.answerTextBox = new System.Windows.Forms.TextBox();
            labelAnswer = new System.Windows.Forms.Label();
            lblQuestion = new System.Windows.Forms.Label();
            answerLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cases_QuestionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cases_AnswersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAnswer
            // 
            labelAnswer.AutoSize = true;
            labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAnswer.Location = new System.Drawing.Point(423, 39);
            labelAnswer.Name = "labelAnswer";
            labelAnswer.Size = new System.Drawing.Size(66, 20);
            labelAnswer.TabIndex = 22;
            labelAnswer.Text = "Answer:";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblQuestion.Location = new System.Drawing.Point(19, 36);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new System.Drawing.Size(77, 20);
            lblQuestion.TabIndex = 12;
            lblQuestion.Text = "Question:";
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Location = new System.Drawing.Point(1270, 322);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new System.Drawing.Size(66, 20);
            answerLabel.TabIndex = 24;
            answerLabel.Text = "Answer:";
            // 
            // txtLearning
            // 
            this.txtLearning.Cursor = System.Windows.Forms.Cursors.No;
            this.txtLearning.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLearning.Location = new System.Drawing.Point(21, 25);
            this.txtLearning.Multiline = true;
            this.txtLearning.Name = "txtLearning";
            this.txtLearning.ReadOnly = true;
            this.txtLearning.Size = new System.Drawing.Size(1122, 378);
            this.txtLearning.TabIndex = 9;
            this.txtLearning.TabStop = false;
            this.txtLearning.Text = resources.GetString("txtLearning.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.questionTextBox);
            this.groupBox2.Controls.Add(this.btnCheckResults);
            this.groupBox2.Controls.Add(labelAnswer);
            this.groupBox2.Controls.Add(this.btnNextQuestion);
            this.groupBox2.Controls.Add(this.txtAnswer);
            this.groupBox2.Controls.Add(this.txtQuestionNumber);
            this.groupBox2.Controls.Add(this.txtScore);
            this.groupBox2.Controls.Add(lblQuestion);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(184, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(827, 239);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exercise";
            // 
            // questionTextBox
            // 
            this.questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cases_QuestionsBindingSource, "Question", true));
            this.questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextBox.Location = new System.Drawing.Point(102, 33);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(199, 26);
            this.questionTextBox.TabIndex = 25;
            // 
            // cases_QuestionsBindingSource
            // 
            this.cases_QuestionsBindingSource.DataMember = "Cases_Questions";
            this.cases_QuestionsBindingSource.DataSource = this.exercisesDataSet;
            // 
            // exercisesDataSet
            // 
            this.exercisesDataSet.DataSetName = "ExercisesDataSet";
            this.exercisesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCheckResults
            // 
            this.btnCheckResults.Location = new System.Drawing.Point(474, 159);
            this.btnCheckResults.Name = "btnCheckResults";
            this.btnCheckResults.Size = new System.Drawing.Size(119, 60);
            this.btnCheckResults.TabIndex = 24;
            this.btnCheckResults.Text = "Check Results";
            this.btnCheckResults.UseVisualStyleBackColor = true;
            this.btnCheckResults.Click += new System.EventHandler(this.btnCheckResults_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(139, 113);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(121, 39);
            this.btnNextQuestion.TabIndex = 16;
            this.btnNextQuestion.Text = "Next";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.AllowDrop = true;
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(506, 36);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(121, 26);
            this.txtAnswer.TabIndex = 1;
            // 
            // txtQuestionNumber
            // 
            this.txtQuestionNumber.Cursor = System.Windows.Forms.Cursors.No;
            this.txtQuestionNumber.Location = new System.Drawing.Point(705, 36);
            this.txtQuestionNumber.Name = "txtQuestionNumber";
            this.txtQuestionNumber.ReadOnly = true;
            this.txtQuestionNumber.Size = new System.Drawing.Size(73, 26);
            this.txtQuestionNumber.TabIndex = 12;
            // 
            // txtScore
            // 
            this.txtScore.Cursor = System.Windows.Forms.Cursors.No;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(655, 176);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(152, 26);
            this.txtScore.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLearning);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1164, 414);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Learning Section";
            // 
            // cases_QuestionsTableAdapter
            // 
            this.cases_QuestionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Calculation_AnswersTableAdapter = null;
            this.tableAdapterManager.Calculation_QuestionsTableAdapter = null;
            this.tableAdapterManager.Cases_AnswersTableAdapter = this.cases_AnswersTableAdapter;
            this.tableAdapterManager.Cases_QuestionsTableAdapter = this.cases_QuestionsTableAdapter;
            this.tableAdapterManager.IfStatements_AnswersTableAdapter = null;
            this.tableAdapterManager.IfStatements_QuestionsTableAdapter = null;
            this.tableAdapterManager.Input_Output_AnswersTableAdapter = null;
            this.tableAdapterManager.Input_Output_QuestionsTableAdapter = null;
            this.tableAdapterManager.Logic_AnswersTableAdapter = null;
            this.tableAdapterManager.Logic_QuestionsTableAdapter = null;
            this.tableAdapterManager.Loops_AnswersTableAdapter = null;
            this.tableAdapterManager.Loops_QuestionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LearnProgrammingTool.ExercisesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Validation_AnswersTableAdapter = null;
            this.tableAdapterManager.Validation_QuestionsTableAdapter = null;
            this.tableAdapterManager.Variables_AnswersTableAdapter = null;
            this.tableAdapterManager.Variables_QuestionsTableAdapter = null;
            // 
            // cases_AnswersTableAdapter
            // 
            this.cases_AnswersTableAdapter.ClearBeforeFill = true;
            // 
            // cases_AnswersBindingSource
            // 
            this.cases_AnswersBindingSource.DataMember = "Cases_Answers";
            this.cases_AnswersBindingSource.DataSource = this.exercisesDataSet;
            // 
            // answerTextBox
            // 
            this.answerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cases_AnswersBindingSource, "Answer", true));
            this.answerTextBox.Location = new System.Drawing.Point(1342, 319);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.ReadOnly = true;
            this.answerTextBox.Size = new System.Drawing.Size(100, 26);
            this.answerTextBox.TabIndex = 25;
            // 
            // frmCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 687);
            this.Controls.Add(answerLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCases";
            this.Text = "Cases";
            this.Load += new System.EventHandler(this.frmCases_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cases_QuestionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cases_AnswersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLearning;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCheckResults;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtQuestionNumber;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.GroupBox groupBox1;
        private ExercisesDataSet exercisesDataSet;
        private System.Windows.Forms.BindingSource cases_QuestionsBindingSource;
        private ExercisesDataSetTableAdapters.Cases_QuestionsTableAdapter cases_QuestionsTableAdapter;
        private ExercisesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox questionTextBox;
        private ExercisesDataSetTableAdapters.Cases_AnswersTableAdapter cases_AnswersTableAdapter;
        private System.Windows.Forms.BindingSource cases_AnswersBindingSource;
        private System.Windows.Forms.TextBox answerTextBox;
    }
}