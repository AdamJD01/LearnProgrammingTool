namespace LearnProgrammingTool
{
    partial class frmValidation
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
            System.Windows.Forms.Label lblOptions;
            System.Windows.Forms.Label labelAnswer;
            System.Windows.Forms.Label lblQuestion;
            System.Windows.Forms.Label answerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValidation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLearning = new System.Windows.Forms.TextBox();
            this.lblOptionB = new System.Windows.Forms.Label();
            this.lblOptionC = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.lblOptionA = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnCheckResults = new System.Windows.Forms.Button();
            this.txtQuestionNumber = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.validation_QuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exercisesDataSet = new LearnProgrammingTool.ExercisesDataSet();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.validation_AnswersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ifStatements_AnswersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ifStatements_QuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ifStatements_AnswersTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.IfStatements_AnswersTableAdapter();
            this.tableAdapterManager = new LearnProgrammingTool.ExercisesDataSetTableAdapters.TableAdapterManager();
            this.ifStatements_QuestionsTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.IfStatements_QuestionsTableAdapter();
            this.validation_QuestionsTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.Validation_QuestionsTableAdapter();
            this.validation_AnswersTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.Validation_AnswersTableAdapter();
            lblOptions = new System.Windows.Forms.Label();
            labelAnswer = new System.Windows.Forms.Label();
            lblQuestion = new System.Windows.Forms.Label();
            answerLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validation_QuestionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validation_AnswersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ifStatements_AnswersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ifStatements_QuestionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOptions
            // 
            lblOptions.AutoSize = true;
            lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblOptions.Location = new System.Drawing.Point(19, 81);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new System.Drawing.Size(475, 20);
            lblOptions.TabIndex = 23;
            lblOptions.Text = "Options (Drag and drop the correct option into the answer textbox)";
            // 
            // labelAnswer
            // 
            labelAnswer.AutoSize = true;
            labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAnswer.Location = new System.Drawing.Point(363, 36);
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
            answerLabel.Location = new System.Drawing.Point(1267, 289);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new System.Drawing.Size(66, 20);
            answerLabel.TabIndex = 24;
            answerLabel.Text = "Answer:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLearning);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1164, 368);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Learning Section";
            // 
            // txtLearning
            // 
            this.txtLearning.Cursor = System.Windows.Forms.Cursors.No;
            this.txtLearning.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLearning.Location = new System.Drawing.Point(21, 25);
            this.txtLearning.Multiline = true;
            this.txtLearning.Name = "txtLearning";
            this.txtLearning.ReadOnly = true;
            this.txtLearning.Size = new System.Drawing.Size(1122, 307);
            this.txtLearning.TabIndex = 9;
            this.txtLearning.TabStop = false;
            this.txtLearning.Text = resources.GetString("txtLearning.Text");
            // 
            // lblOptionB
            // 
            this.lblOptionB.AllowDrop = true;
            this.lblOptionB.AutoSize = true;
            this.lblOptionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionB.Location = new System.Drawing.Point(169, 122);
            this.lblOptionB.Name = "lblOptionB";
            this.lblOptionB.Size = new System.Drawing.Size(135, 20);
            this.lblOptionB.TabIndex = 20;
            this.lblOptionB.Text = "Wrong Input Type";
            // 
            // lblOptionC
            // 
            this.lblOptionC.AllowDrop = true;
            this.lblOptionC.AutoSize = true;
            this.lblOptionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionC.Location = new System.Drawing.Point(361, 122);
            this.lblOptionC.Name = "lblOptionC";
            this.lblOptionC.Size = new System.Drawing.Size(59, 20);
            this.lblOptionC.TabIndex = 17;
            this.lblOptionC.Text = "Length";
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(173, 183);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(121, 39);
            this.btnNextQuestion.TabIndex = 16;
            this.btnNextQuestion.Text = "Next";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // lblOptionA
            // 
            this.lblOptionA.AllowDrop = true;
            this.lblOptionA.AutoSize = true;
            this.lblOptionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionA.Location = new System.Drawing.Point(19, 122);
            this.lblOptionA.Name = "lblOptionA";
            this.lblOptionA.Size = new System.Drawing.Size(100, 20);
            this.lblOptionA.TabIndex = 15;
            this.lblOptionA.Text = "White Space";
            // 
            // txtAnswer
            // 
            this.txtAnswer.AllowDrop = true;
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(435, 33);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(182, 26);
            this.txtAnswer.TabIndex = 10;
            // 
            // btnCheckResults
            // 
            this.btnCheckResults.Location = new System.Drawing.Point(670, 106);
            this.btnCheckResults.Name = "btnCheckResults";
            this.btnCheckResults.Size = new System.Drawing.Size(121, 52);
            this.btnCheckResults.TabIndex = 12;
            this.btnCheckResults.Text = "Check Results";
            this.btnCheckResults.UseVisualStyleBackColor = true;
            this.btnCheckResults.Click += new System.EventHandler(this.btnCheckResults_Click);
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
            this.txtScore.Location = new System.Drawing.Point(650, 196);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(152, 26);
            this.txtScore.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.questionTextBox);
            this.groupBox2.Controls.Add(lblOptions);
            this.groupBox2.Controls.Add(labelAnswer);
            this.groupBox2.Controls.Add(this.lblOptionB);
            this.groupBox2.Controls.Add(this.lblOptionC);
            this.groupBox2.Controls.Add(this.btnNextQuestion);
            this.groupBox2.Controls.Add(this.lblOptionA);
            this.groupBox2.Controls.Add(this.txtAnswer);
            this.groupBox2.Controls.Add(this.btnCheckResults);
            this.groupBox2.Controls.Add(this.txtQuestionNumber);
            this.groupBox2.Controls.Add(this.txtScore);
            this.groupBox2.Controls.Add(lblQuestion);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(182, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 242);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exercise";
            // 
            // questionTextBox
            // 
            this.questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.validation_QuestionsBindingSource, "Question", true));
            this.questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextBox.Location = new System.Drawing.Point(102, 33);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(232, 26);
            this.questionTextBox.TabIndex = 24;
            // 
            // validation_QuestionsBindingSource
            // 
            this.validation_QuestionsBindingSource.DataMember = "Validation_Questions";
            this.validation_QuestionsBindingSource.DataSource = this.exercisesDataSet;
            // 
            // exercisesDataSet
            // 
            this.exercisesDataSet.DataSetName = "ExercisesDataSet";
            this.exercisesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // answerTextBox
            // 
            this.answerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.validation_AnswersBindingSource, "Answer", true));
            this.answerTextBox.Location = new System.Drawing.Point(1339, 286);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.ReadOnly = true;
            this.answerTextBox.Size = new System.Drawing.Size(100, 26);
            this.answerTextBox.TabIndex = 25;
            // 
            // validation_AnswersBindingSource
            // 
            this.validation_AnswersBindingSource.DataMember = "Validation_Answers";
            this.validation_AnswersBindingSource.DataSource = this.exercisesDataSet;
            // 
            // ifStatements_AnswersBindingSource
            // 
            this.ifStatements_AnswersBindingSource.DataMember = "IfStatements_Answers";
            this.ifStatements_AnswersBindingSource.DataSource = this.exercisesDataSet;
            // 
            // ifStatements_QuestionsBindingSource
            // 
            this.ifStatements_QuestionsBindingSource.DataMember = "IfStatements_Questions";
            this.ifStatements_QuestionsBindingSource.DataSource = this.exercisesDataSet;
            // 
            // ifStatements_AnswersTableAdapter
            // 
            this.ifStatements_AnswersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Calculation_AnswersTableAdapter = null;
            this.tableAdapterManager.Calculation_QuestionsTableAdapter = null;
            this.tableAdapterManager.Cases_AnswersTableAdapter = null;
            this.tableAdapterManager.Cases_QuestionsTableAdapter = null;
            this.tableAdapterManager.IfStatements_AnswersTableAdapter = this.ifStatements_AnswersTableAdapter;
            this.tableAdapterManager.IfStatements_QuestionsTableAdapter = this.ifStatements_QuestionsTableAdapter;
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
            // ifStatements_QuestionsTableAdapter
            // 
            this.ifStatements_QuestionsTableAdapter.ClearBeforeFill = true;
            // 
            // validation_QuestionsTableAdapter
            // 
            this.validation_QuestionsTableAdapter.ClearBeforeFill = true;
            // 
            // validation_AnswersTableAdapter
            // 
            this.validation_AnswersTableAdapter.ClearBeforeFill = true;
            // 
            // frmValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 692);
            this.Controls.Add(answerLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmValidation";
            this.Text = "Validation";
            this.Load += new System.EventHandler(this.frmValidation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validation_QuestionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validation_AnswersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ifStatements_AnswersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ifStatements_QuestionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource ifStatements_AnswersBindingSource;
        private ExercisesDataSet exercisesDataSet;
        private ExercisesDataSetTableAdapters.IfStatements_AnswersTableAdapter ifStatements_AnswersTableAdapter;
        private ExercisesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ExercisesDataSetTableAdapters.IfStatements_QuestionsTableAdapter ifStatements_QuestionsTableAdapter;
        private System.Windows.Forms.BindingSource ifStatements_QuestionsBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLearning;
        private System.Windows.Forms.Label lblOptionB;
        private System.Windows.Forms.Label lblOptionC;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Label lblOptionA;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnCheckResults;
        private System.Windows.Forms.TextBox txtQuestionNumber;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource validation_QuestionsBindingSource;
        private ExercisesDataSetTableAdapters.Validation_QuestionsTableAdapter validation_QuestionsTableAdapter;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.BindingSource validation_AnswersBindingSource;
        private ExercisesDataSetTableAdapters.Validation_AnswersTableAdapter validation_AnswersTableAdapter;
        private System.Windows.Forms.TextBox answerTextBox;
    }
}