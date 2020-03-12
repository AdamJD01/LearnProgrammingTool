namespace LearnProgrammingTool
{
    partial class frmVariables
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
            System.Windows.Forms.Label questionLabel;
            System.Windows.Forms.Label answerLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVariables));
            this.label3 = new System.Windows.Forms.Label();
            this.cmbQuestion2 = new System.Windows.Forms.ComboBox();
            this.grpQuestion2 = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.cmbQuestion = new System.Windows.Forms.ComboBox();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtLearning = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCheckResults = new System.Windows.Forms.Button();
            this.txtQuestionNumber = new System.Windows.Forms.TextBox();
            this.variables_AnswersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exercisesDataSet = new LearnProgrammingTool.ExercisesDataSet();
            this.variables_QuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.variables_QuestionsTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.Variables_QuestionsTableAdapter();
            this.tableAdapterManager = new LearnProgrammingTool.ExercisesDataSetTableAdapters.TableAdapterManager();
            this.variables_AnswersTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.Variables_AnswersTableAdapter();
            questionLabel = new System.Windows.Forms.Label();
            answerLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variables_AnswersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variables_QuestionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new System.Drawing.Point(423, 517);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new System.Drawing.Size(77, 20);
            questionLabel.TabIndex = 1;
            questionLabel.Text = "Question:";
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Location = new System.Drawing.Point(1333, 307);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new System.Drawing.Size(66, 20);
            answerLabel.TabIndex = 3;
            answerLabel.Text = "Answer:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(423, 561);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 20);
            label1.TabIndex = 6;
            label1.Text = "Options:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dim isItRaining As _________";
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
            this.cmbQuestion2.Location = new System.Drawing.Point(280, 80);
            this.cmbQuestion2.Name = "cmbQuestion2";
            this.cmbQuestion2.Size = new System.Drawing.Size(158, 28);
            this.cmbQuestion2.TabIndex = 11;
            // 
            // grpQuestion2
            // 
            this.grpQuestion2.AutoSize = true;
            this.grpQuestion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQuestion2.Location = new System.Drawing.Point(158, 22);
            this.grpQuestion2.Name = "grpQuestion2";
            this.grpQuestion2.Size = new System.Drawing.Size(145, 22);
            this.grpQuestion2.TabIndex = 9;
            this.grpQuestion2.Text = "Variable Types";
            // 
            // questionTextBox
            // 
            this.questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.variables_QuestionsBindingSource, "Question", true));
            this.questionTextBox.Location = new System.Drawing.Point(506, 514);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(180, 26);
            this.questionTextBox.TabIndex = 2;
            // 
            // answerTextBox
            // 
            this.answerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.variables_AnswersBindingSource, "Answer", true));
            this.answerTextBox.Location = new System.Drawing.Point(1405, 304);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.ReadOnly = true;
            this.answerTextBox.Size = new System.Drawing.Size(100, 26);
            this.answerTextBox.TabIndex = 4;
            // 
            // cmbQuestion
            // 
            this.cmbQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestion.FormattingEnabled = true;
            this.cmbQuestion.Items.AddRange(new object[] {
            "Boolean",
            "Byte",
            "Char",
            "Date",
            "Double",
            "Single",
            "String"});
            this.cmbQuestion.Location = new System.Drawing.Point(506, 558);
            this.cmbQuestion.Name = "cmbQuestion";
            this.cmbQuestion.Size = new System.Drawing.Size(180, 28);
            this.cmbQuestion.TabIndex = 5;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(496, 615);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(121, 52);
            this.btnNextQuestion.TabIndex = 7;
            this.btnNextQuestion.Text = "Next";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(445, 157);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(152, 26);
            this.txtScore.TabIndex = 8;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLearning);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1246, 431);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Learning Section";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCheckResults);
            this.groupBox2.Controls.Add(this.txtQuestionNumber);
            this.groupBox2.Controls.Add(this.txtScore);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(363, 484);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 205);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exercise";
            // 
            // btnCheckResults
            // 
            this.btnCheckResults.Location = new System.Drawing.Point(461, 77);
            this.btnCheckResults.Name = "btnCheckResults";
            this.btnCheckResults.Size = new System.Drawing.Size(121, 52);
            this.btnCheckResults.TabIndex = 12;
            this.btnCheckResults.Text = "Check Results";
            this.btnCheckResults.UseVisualStyleBackColor = true;
            this.btnCheckResults.Click += new System.EventHandler(this.btnCheckResults_Click);
            // 
            // txtQuestionNumber
            // 
            this.txtQuestionNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.variables_QuestionsBindingSource, "Question", true));
            this.txtQuestionNumber.Location = new System.Drawing.Point(348, 30);
            this.txtQuestionNumber.Name = "txtQuestionNumber";
            this.txtQuestionNumber.ReadOnly = true;
            this.txtQuestionNumber.Size = new System.Drawing.Size(73, 26);
            this.txtQuestionNumber.TabIndex = 12;
            // 
            // variables_AnswersBindingSource
            // 
            this.variables_AnswersBindingSource.DataMember = "Variables_Answers";
            this.variables_AnswersBindingSource.DataSource = this.exercisesDataSet;
            // 
            // exercisesDataSet
            // 
            this.exercisesDataSet.DataSetName = "ExercisesDataSet";
            this.exercisesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Input_Output_AnswersTableAdapter = null;
            this.tableAdapterManager.Input_Output_QuestionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LearnProgrammingTool.ExercisesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Variables_AnswersTableAdapter = null;
            this.tableAdapterManager.Variables_QuestionsTableAdapter = this.variables_QuestionsTableAdapter;
            // 
            // variables_AnswersTableAdapter
            // 
            this.variables_AnswersTableAdapter.ClearBeforeFill = true;
            // 
            // frmVariables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 703);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(label1);
            this.Controls.Add(this.cmbQuestion);
            this.Controls.Add(answerLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(questionLabel);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVariables";
            this.Text = "Variables";
            this.Load += new System.EventHandler(this.frmVariables_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variables_AnswersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variables_QuestionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbQuestion2;
        private System.Windows.Forms.Label grpQuestion2;
        private ExercisesDataSet exercisesDataSet;
        private System.Windows.Forms.BindingSource variables_QuestionsBindingSource;
        private ExercisesDataSetTableAdapters.Variables_QuestionsTableAdapter variables_QuestionsTableAdapter;
        private ExercisesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.BindingSource variables_AnswersBindingSource;
        private ExercisesDataSetTableAdapters.Variables_AnswersTableAdapter variables_AnswersTableAdapter;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.ComboBox cmbQuestion;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtLearning;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQuestionNumber;
        private System.Windows.Forms.Button btnCheckResults;
    }
}