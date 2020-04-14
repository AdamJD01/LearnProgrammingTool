namespace LearnProgrammingTool
{
    partial class frmCalculation
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label answerLabel;
            System.Windows.Forms.Label questionLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculation));
            this.btnCheckResults = new System.Windows.Forms.Button();
            this.txtQuestionNumber = new System.Windows.Forms.TextBox();
            this.variables_QuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exercisesDataSet = new LearnProgrammingTool.ExercisesDataSet();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.cmbQuestion = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLearning = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.calculation_QuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbQuestion2 = new System.Windows.Forms.ComboBox();
            this.variables_AnswersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new LearnProgrammingTool.ExercisesDataSetTableAdapters.TableAdapterManager();
            this.calculation_QuestionsTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.Calculation_QuestionsTableAdapter();
            this.calculation_AnswersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculation_AnswersTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.Calculation_AnswersTableAdapter();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            answerLabel = new System.Windows.Forms.Label();
            questionLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.variables_QuestionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculation_QuestionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variables_AnswersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculation_AnswersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(256, 494);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 20);
            label1.TabIndex = 18;
            label1.Text = "Options:";
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Location = new System.Drawing.Point(1637, 295);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new System.Drawing.Size(66, 20);
            answerLabel.TabIndex = 15;
            answerLabel.Text = "Answer:";
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new System.Drawing.Point(256, 450);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new System.Drawing.Size(77, 20);
            questionLabel.TabIndex = 12;
            questionLabel.Text = "Question:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(51, 30);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 20);
            label2.TabIndex = 13;
            label2.Text = "Question:";
            // 
            // btnCheckResults
            // 
            this.btnCheckResults.Location = new System.Drawing.Point(658, 77);
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
            this.txtQuestionNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.variables_QuestionsBindingSource, "Question", true));
            this.txtQuestionNumber.Location = new System.Drawing.Point(549, 30);
            this.txtQuestionNumber.Name = "txtQuestionNumber";
            this.txtQuestionNumber.ReadOnly = true;
            this.txtQuestionNumber.Size = new System.Drawing.Size(73, 26);
            this.txtQuestionNumber.TabIndex = 12;
            // 
            // variables_QuestionsBindingSource
            // 
            this.variables_QuestionsBindingSource.DataMember = "Variables_Questions";
            this.variables_QuestionsBindingSource.DataSource = this.exercisesDataSet;
            // 
            // exercisesDataSet
            // 
            this.exercisesDataSet.DataSetName = "ExercisesDataSet";
            this.exercisesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtScore
            // 
            this.txtScore.Cursor = System.Windows.Forms.Cursors.No;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(642, 157);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(152, 26);
            this.txtScore.TabIndex = 8;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(294, 131);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(121, 52);
            this.btnNextQuestion.TabIndex = 19;
            this.btnNextQuestion.Text = "Next";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // cmbQuestion
            // 
            this.cmbQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuestion.FormattingEnabled = true;
            this.cmbQuestion.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division",
            "Brackets"});
            this.cmbQuestion.Location = new System.Drawing.Point(143, 74);
            this.cmbQuestion.Name = "cmbQuestion";
            this.cmbQuestion.Size = new System.Drawing.Size(180, 28);
            this.cmbQuestion.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLearning);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1206, 373);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Learning Section";
            // 
            // txtLearning
            // 
            this.txtLearning.Cursor = System.Windows.Forms.Cursors.No;
            this.txtLearning.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLearning.Location = new System.Drawing.Point(17, 25);
            this.txtLearning.Multiline = true;
            this.txtLearning.Name = "txtLearning";
            this.txtLearning.ReadOnly = true;
            this.txtLearning.Size = new System.Drawing.Size(1159, 308);
            this.txtLearning.TabIndex = 9;
            this.txtLearning.TabStop = false;
            this.txtLearning.Text = resources.GetString("txtLearning.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.questionTextBox);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(this.btnCheckResults);
            this.groupBox2.Controls.Add(this.cmbQuestion);
            this.groupBox2.Controls.Add(this.btnNextQuestion);
            this.groupBox2.Controls.Add(this.txtQuestionNumber);
            this.groupBox2.Controls.Add(this.txtScore);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(196, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 205);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exercise";
            // 
            // questionTextBox
            // 
            this.questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calculation_QuestionsBindingSource, "Question", true));
            this.questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextBox.Location = new System.Drawing.Point(143, 30);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(377, 26);
            this.questionTextBox.TabIndex = 14;
            // 
            // calculation_QuestionsBindingSource
            // 
            this.calculation_QuestionsBindingSource.DataMember = "Calculation_Questions";
            this.calculation_QuestionsBindingSource.DataSource = this.exercisesDataSet;
            // 
            // cmbQuestion2
            // 
            this.cmbQuestion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestion2.FormattingEnabled = true;
            this.cmbQuestion2.Items.AddRange(new object[] {
            "Boolean",
            "Date",
            "Double",
            "Single",
            "String"});
            this.cmbQuestion2.Location = new System.Drawing.Point(254, 58);
            this.cmbQuestion2.Name = "cmbQuestion2";
            this.cmbQuestion2.Size = new System.Drawing.Size(158, 28);
            this.cmbQuestion2.TabIndex = 23;
            // 
            // variables_AnswersBindingSource
            // 
            this.variables_AnswersBindingSource.DataMember = "Variables_Answers";
            this.variables_AnswersBindingSource.DataSource = this.exercisesDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Calculation_AnswersTableAdapter = null;
            this.tableAdapterManager.Calculation_QuestionsTableAdapter = null;
            this.tableAdapterManager.Cases_AnswersTableAdapter = null;
            this.tableAdapterManager.Cases_QuestionsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // calculation_QuestionsTableAdapter
            // 
            this.calculation_QuestionsTableAdapter.ClearBeforeFill = true;
            // 
            // calculation_AnswersBindingSource
            // 
            this.calculation_AnswersBindingSource.DataMember = "Calculation_Answers";
            this.calculation_AnswersBindingSource.DataSource = this.exercisesDataSet;
            // 
            // calculation_AnswersTableAdapter
            // 
            this.calculation_AnswersTableAdapter.ClearBeforeFill = true;
            // 
            // answerTextBox
            // 
            this.answerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calculation_AnswersBindingSource, "Answer", true));
            this.answerTextBox.Location = new System.Drawing.Point(1709, 295);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.ReadOnly = true;
            this.answerTextBox.Size = new System.Drawing.Size(100, 26);
            this.answerTextBox.TabIndex = 24;
            // 
            // frmCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 653);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(answerLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbQuestion2);
            this.Controls.Add(questionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculation";
            this.Text = "Calculation";
            this.Load += new System.EventHandler(this.frmCalculation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.variables_QuestionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculation_QuestionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variables_AnswersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculation_AnswersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheckResults;
        private System.Windows.Forms.TextBox txtQuestionNumber;
        private System.Windows.Forms.BindingSource variables_QuestionsBindingSource;
        private ExercisesDataSet exercisesDataSet;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.ComboBox cmbQuestion;
        private System.Windows.Forms.BindingSource variables_AnswersBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLearning;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbQuestion2;
        private ExercisesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource calculation_QuestionsBindingSource;
        private ExercisesDataSetTableAdapters.Calculation_QuestionsTableAdapter calculation_QuestionsTableAdapter;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.BindingSource calculation_AnswersBindingSource;
        private ExercisesDataSetTableAdapters.Calculation_AnswersTableAdapter calculation_AnswersTableAdapter;
        private System.Windows.Forms.TextBox answerTextBox;
    }
}