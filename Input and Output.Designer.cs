namespace LearnProgrammingTool
{
    partial class frmInputAndOutput
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
            System.Windows.Forms.Label lblQuestion;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInputAndOutput));
            System.Windows.Forms.Label answerLabel;
            System.Windows.Forms.Label labelAnswer;
            System.Windows.Forms.Label lblOptions;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLearning = new System.Windows.Forms.TextBox();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnCheckResults = new System.Windows.Forms.Button();
            this.txtQuestionNumber = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblOptionA = new System.Windows.Forms.Label();
            this.exercisesDataSet = new LearnProgrammingTool.ExercisesDataSet();
            this.input_Output_AnswersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.input_Output_AnswersTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.Input_Output_AnswersTableAdapter();
            this.tableAdapterManager = new LearnProgrammingTool.ExercisesDataSetTableAdapters.TableAdapterManager();
            this.input_Output_QuestionsTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.Input_Output_QuestionsTableAdapter();
            this.input_Output_QuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.variables_QuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.variables_QuestionsTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.Variables_QuestionsTableAdapter();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.lblOptionC = new System.Windows.Forms.Label();
            this.lblOptionD = new System.Windows.Forms.Label();
            this.lblOptionE = new System.Windows.Forms.Label();
            this.lblOptionB = new System.Windows.Forms.Label();
            this.lblOptionF = new System.Windows.Forms.Label();
            lblQuestion = new System.Windows.Forms.Label();
            answerLabel = new System.Windows.Forms.Label();
            labelAnswer = new System.Windows.Forms.Label();
            lblOptions = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_Output_AnswersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_Output_QuestionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variables_QuestionsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLearning);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1246, 431);
            this.groupBox1.TabIndex = 11;
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
            this.txtLearning.Size = new System.Drawing.Size(1207, 379);
            this.txtLearning.TabIndex = 9;
            this.txtLearning.Text = resources.GetString("txtLearning.Text");
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(224, 208);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(121, 52);
            this.btnNextQuestion.TabIndex = 16;
            this.btnNextQuestion.Text = "Next";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(lblOptions);
            this.groupBox2.Controls.Add(labelAnswer);
            this.groupBox2.Controls.Add(this.lblOptionF);
            this.groupBox2.Controls.Add(this.lblOptionB);
            this.groupBox2.Controls.Add(this.lblOptionE);
            this.groupBox2.Controls.Add(this.lblOptionD);
            this.groupBox2.Controls.Add(this.lblOptionC);
            this.groupBox2.Controls.Add(this.btnNextQuestion);
            this.groupBox2.Controls.Add(this.questionTextBox);
            this.groupBox2.Controls.Add(this.lblOptionA);
            this.groupBox2.Controls.Add(this.txtAnswer);
            this.groupBox2.Controls.Add(this.btnCheckResults);
            this.groupBox2.Controls.Add(this.txtQuestionNumber);
            this.groupBox2.Controls.Add(this.txtScore);
            this.groupBox2.Controls.Add(lblQuestion);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(299, 481);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 284);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exercise";
            // 
            // txtAnswer
            // 
            this.txtAnswer.AllowDrop = true;
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(522, 33);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(121, 26);
            this.txtAnswer.TabIndex = 14;
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
            this.txtQuestionNumber.Location = new System.Drawing.Point(705, 36);
            this.txtQuestionNumber.Name = "txtQuestionNumber";
            this.txtQuestionNumber.ReadOnly = true;
            this.txtQuestionNumber.Size = new System.Drawing.Size(73, 26);
            this.txtQuestionNumber.TabIndex = 12;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(650, 196);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(152, 26);
            this.txtScore.TabIndex = 8;
            // 
            // lblOptionA
            // 
            this.lblOptionA.AllowDrop = true;
            this.lblOptionA.AutoSize = true;
            this.lblOptionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionA.Location = new System.Drawing.Point(25, 122);
            this.lblOptionA.Name = "lblOptionA";
            this.lblOptionA.Size = new System.Drawing.Size(81, 20);
            this.lblOptionA.TabIndex = 15;
            this.lblOptionA.Text = "CheckBox";
            // 
            // exercisesDataSet
            // 
            this.exercisesDataSet.DataSetName = "ExercisesDataSet";
            this.exercisesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // input_Output_AnswersBindingSource
            // 
            this.input_Output_AnswersBindingSource.DataMember = "Input&Output_Answers";
            this.input_Output_AnswersBindingSource.DataSource = this.exercisesDataSet;
            // 
            // input_Output_AnswersTableAdapter
            // 
            this.input_Output_AnswersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Input_Output_AnswersTableAdapter = this.input_Output_AnswersTableAdapter;
            this.tableAdapterManager.Input_Output_QuestionsTableAdapter = this.input_Output_QuestionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = LearnProgrammingTool.ExercisesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Variables_AnswersTableAdapter = null;
            this.tableAdapterManager.Variables_QuestionsTableAdapter = null;
            // 
            // input_Output_QuestionsTableAdapter
            // 
            this.input_Output_QuestionsTableAdapter.ClearBeforeFill = true;
            // 
            // input_Output_QuestionsBindingSource
            // 
            this.input_Output_QuestionsBindingSource.DataMember = "Input&Output_Questions";
            this.input_Output_QuestionsBindingSource.DataSource = this.exercisesDataSet;
            // 
            // variables_QuestionsBindingSource
            // 
            this.variables_QuestionsBindingSource.DataMember = "Variables_Questions";
            this.variables_QuestionsBindingSource.DataSource = this.exercisesDataSet;
            // 
            // variables_QuestionsTableAdapter
            // 
            this.variables_QuestionsTableAdapter.ClearBeforeFill = true;
            // 
            // questionTextBox
            // 
            this.questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.input_Output_QuestionsBindingSource, "Question", true));
            this.questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextBox.Location = new System.Drawing.Point(102, 33);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(312, 26);
            this.questionTextBox.TabIndex = 16;
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Location = new System.Drawing.Point(1529, 348);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new System.Drawing.Size(66, 20);
            answerLabel.TabIndex = 17;
            answerLabel.Text = "Answer:";
            // 
            // answerTextBox
            // 
            this.answerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.input_Output_AnswersBindingSource, "Answer", true));
            this.answerTextBox.Location = new System.Drawing.Point(1601, 345);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.ReadOnly = true;
            this.answerTextBox.Size = new System.Drawing.Size(100, 26);
            this.answerTextBox.TabIndex = 18;
            // 
            // lblOptionC
            // 
            this.lblOptionC.AllowDrop = true;
            this.lblOptionC.AutoSize = true;
            this.lblOptionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionC.Location = new System.Drawing.Point(321, 122);
            this.lblOptionC.Name = "lblOptionC";
            this.lblOptionC.Size = new System.Drawing.Size(99, 20);
            this.lblOptionC.TabIndex = 17;
            this.lblOptionC.Text = "RadioButton";
            // 
            // lblOptionD
            // 
            this.lblOptionD.AllowDrop = true;
            this.lblOptionD.AutoSize = true;
            this.lblOptionD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionD.Location = new System.Drawing.Point(25, 157);
            this.lblOptionD.Name = "lblOptionD";
            this.lblOptionD.Size = new System.Drawing.Size(66, 20);
            this.lblOptionD.TabIndex = 18;
            this.lblOptionD.Text = "TextBox";
            // 
            // lblOptionE
            // 
            this.lblOptionE.AllowDrop = true;
            this.lblOptionE.AutoSize = true;
            this.lblOptionE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionE.Location = new System.Drawing.Point(173, 157);
            this.lblOptionE.Name = "lblOptionE";
            this.lblOptionE.Size = new System.Drawing.Size(43, 20);
            this.lblOptionE.TabIndex = 19;
            this.lblOptionE.Text = ".Text";
            // 
            // lblOptionB
            // 
            this.lblOptionB.AllowDrop = true;
            this.lblOptionB.AutoSize = true;
            this.lblOptionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionB.Location = new System.Drawing.Point(173, 122);
            this.lblOptionB.Name = "lblOptionB";
            this.lblOptionB.Size = new System.Drawing.Size(87, 20);
            this.lblOptionB.TabIndex = 20;
            this.lblOptionB.Text = "ComboBox";
            // 
            // lblOptionF
            // 
            this.lblOptionF.AllowDrop = true;
            this.lblOptionF.AutoSize = true;
            this.lblOptionF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionF.Location = new System.Drawing.Point(321, 157);
            this.lblOptionF.Name = "lblOptionF";
            this.lblOptionF.Size = new System.Drawing.Size(73, 20);
            this.lblOptionF.TabIndex = 21;
            this.lblOptionF.Text = ".ToString";
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
            // lblOptions
            // 
            lblOptions.AutoSize = true;
            lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblOptions.Location = new System.Drawing.Point(19, 88);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new System.Drawing.Size(475, 20);
            lblOptions.TabIndex = 23;
            lblOptions.Text = "Options (Drag and drop the correct option into the answer textbox)";
            // 
            // frmInputAndOutput
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 777);
            this.Controls.Add(answerLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInputAndOutput";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input and Output";
            this.Load += new System.EventHandler(this.frmInputAndOutput_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_Output_AnswersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_Output_QuestionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variables_QuestionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLearning;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCheckResults;
        private System.Windows.Forms.TextBox txtQuestionNumber;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblOptionA;
        private System.Windows.Forms.TextBox txtAnswer;
        private ExercisesDataSet exercisesDataSet;
        private System.Windows.Forms.BindingSource input_Output_AnswersBindingSource;
        private ExercisesDataSetTableAdapters.Input_Output_AnswersTableAdapter input_Output_AnswersTableAdapter;
        private ExercisesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ExercisesDataSetTableAdapters.Input_Output_QuestionsTableAdapter input_Output_QuestionsTableAdapter;
        private System.Windows.Forms.BindingSource input_Output_QuestionsBindingSource;
        private System.Windows.Forms.BindingSource variables_QuestionsBindingSource;
        private ExercisesDataSetTableAdapters.Variables_QuestionsTableAdapter variables_QuestionsTableAdapter;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label lblOptionF;
        private System.Windows.Forms.Label lblOptionB;
        private System.Windows.Forms.Label lblOptionE;
        private System.Windows.Forms.Label lblOptionD;
        private System.Windows.Forms.Label lblOptionC;
    }
}