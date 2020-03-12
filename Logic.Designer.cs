namespace LearnProgrammingTool
{
    partial class frmLogic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogic));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.logic_QuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exercisesDataSet = new LearnProgrammingTool.ExercisesDataSet();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnCheckResults = new System.Windows.Forms.Button();
            this.txtQuestionNumber = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLearning = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new LearnProgrammingTool.ExercisesDataSetTableAdapters.TableAdapterManager();
            this.logic_QuestionsTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.Logic_QuestionsTableAdapter();
            this.logic_AnswersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logic_AnswersTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.Logic_AnswersTableAdapter();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            labelAnswer = new System.Windows.Forms.Label();
            lblQuestion = new System.Windows.Forms.Label();
            answerLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logic_QuestionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logic_AnswersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAnswer
            // 
            labelAnswer.AutoSize = true;
            labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAnswer.Location = new System.Drawing.Point(439, 36);
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
            answerLabel.Location = new System.Drawing.Point(1307, 266);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new System.Drawing.Size(66, 20);
            answerLabel.TabIndex = 21;
            answerLabel.Text = "Answer:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.questionTextBox);
            this.groupBox2.Controls.Add(labelAnswer);
            this.groupBox2.Controls.Add(this.btnNextQuestion);
            this.groupBox2.Controls.Add(this.txtAnswer);
            this.groupBox2.Controls.Add(this.btnCheckResults);
            this.groupBox2.Controls.Add(this.txtQuestionNumber);
            this.groupBox2.Controls.Add(this.txtScore);
            this.groupBox2.Controls.Add(lblQuestion);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(184, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(827, 238);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exercise";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logic_QuestionsBindingSource, "Question", true));
            this.questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextBox.Location = new System.Drawing.Point(115, 33);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(301, 26);
            this.questionTextBox.TabIndex = 23;
            this.questionTextBox.TabStop = false;
            // 
            // logic_QuestionsBindingSource
            // 
            this.logic_QuestionsBindingSource.DataMember = "Logic_Questions";
            this.logic_QuestionsBindingSource.DataSource = this.exercisesDataSet;
            // 
            // exercisesDataSet
            // 
            this.exercisesDataSet.DataSetName = "ExercisesDataSet";
            this.exercisesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(221, 99);
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
            this.txtAnswer.Location = new System.Drawing.Point(522, 33);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(121, 26);
            this.txtAnswer.TabIndex = 1;
            // 
            // btnCheckResults
            // 
            this.btnCheckResults.Location = new System.Drawing.Point(468, 163);
            this.btnCheckResults.Name = "btnCheckResults";
            this.btnCheckResults.Size = new System.Drawing.Size(121, 52);
            this.btnCheckResults.TabIndex = 12;
            this.btnCheckResults.Text = "Check Results";
            this.btnCheckResults.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1164, 394);
            this.groupBox1.TabIndex = 18;
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
            this.txtLearning.Size = new System.Drawing.Size(1122, 363);
            this.txtLearning.TabIndex = 9;
            this.txtLearning.TabStop = false;
            this.txtLearning.Text = resources.GetString("txtLearning.Text");
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Input_Output_AnswersTableAdapter = null;
            this.tableAdapterManager.Input_Output_QuestionsTableAdapter = null;
            this.tableAdapterManager.Logic_AnswersTableAdapter = null;
            this.tableAdapterManager.Logic_QuestionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LearnProgrammingTool.ExercisesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Variables_AnswersTableAdapter = null;
            this.tableAdapterManager.Variables_QuestionsTableAdapter = null;
            // 
            // logic_QuestionsTableAdapter
            // 
            this.logic_QuestionsTableAdapter.ClearBeforeFill = true;
            // 
            // logic_AnswersBindingSource
            // 
            this.logic_AnswersBindingSource.DataMember = "Logic_Answers";
            this.logic_AnswersBindingSource.DataSource = this.exercisesDataSet;
            // 
            // logic_AnswersTableAdapter
            // 
            this.logic_AnswersTableAdapter.ClearBeforeFill = true;
            // 
            // answerTextBox
            // 
            this.answerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logic_AnswersBindingSource, "Answer", true));
            this.answerTextBox.Location = new System.Drawing.Point(1379, 263);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.ReadOnly = true;
            this.answerTextBox.Size = new System.Drawing.Size(100, 26);
            this.answerTextBox.TabIndex = 22;
            // 
            // frmLogic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 695);
            this.Controls.Add(answerLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogic";
            this.Text = "Logic";
            this.Load += new System.EventHandler(this.frmLogic_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logic_QuestionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logic_AnswersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnCheckResults;
        private System.Windows.Forms.TextBox txtQuestionNumber;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLearning;
        private ExercisesDataSet exercisesDataSet;
        private ExercisesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource logic_QuestionsBindingSource;
        private ExercisesDataSetTableAdapters.Logic_QuestionsTableAdapter logic_QuestionsTableAdapter;
        private System.Windows.Forms.BindingSource logic_AnswersBindingSource;
        private ExercisesDataSetTableAdapters.Logic_AnswersTableAdapter logic_AnswersTableAdapter;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.TextBox questionTextBox;
    }
}