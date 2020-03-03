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
            this.exercisesDataSet = new LearnProgrammingTool.ExercisesDataSet();
            this.variables_QuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.variables_QuestionsTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.Variables_QuestionsTableAdapter();
            this.tableAdapterManager = new LearnProgrammingTool.ExercisesDataSetTableAdapters.TableAdapterManager();
            this.variables_QuestionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.variables_QuestionsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.variables_AnswersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.variables_AnswersTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.Variables_AnswersTableAdapter();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.cmbQuestion = new System.Windows.Forms.ComboBox();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            questionLabel = new System.Windows.Forms.Label();
            answerLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variables_QuestionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variables_QuestionsBindingNavigator)).BeginInit();
            this.variables_QuestionsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variables_AnswersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new System.Drawing.Point(306, 314);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new System.Drawing.Size(77, 20);
            questionLabel.TabIndex = 1;
            questionLabel.Text = "Question:";
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Location = new System.Drawing.Point(1040, 300);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new System.Drawing.Size(66, 20);
            answerLabel.TabIndex = 3;
            answerLabel.Text = "Answer:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(306, 358);
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
            this.tableAdapterManager.UpdateOrder = LearnProgrammingTool.ExercisesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Variables_AnswersTableAdapter = null;
            this.tableAdapterManager.Variables_QuestionsTableAdapter = this.variables_QuestionsTableAdapter;
            // 
            // variables_QuestionsBindingNavigator
            // 
            this.variables_QuestionsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.variables_QuestionsBindingNavigator.BindingSource = this.variables_QuestionsBindingSource;
            this.variables_QuestionsBindingNavigator.CountItem = null;
            this.variables_QuestionsBindingNavigator.DeleteItem = null;
            this.variables_QuestionsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.variables_QuestionsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.variables_QuestionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.variables_QuestionsBindingNavigatorSaveItem});
            this.variables_QuestionsBindingNavigator.Location = new System.Drawing.Point(0, 570);
            this.variables_QuestionsBindingNavigator.MoveFirstItem = null;
            this.variables_QuestionsBindingNavigator.MoveLastItem = null;
            this.variables_QuestionsBindingNavigator.MoveNextItem = null;
            this.variables_QuestionsBindingNavigator.MovePreviousItem = null;
            this.variables_QuestionsBindingNavigator.Name = "variables_QuestionsBindingNavigator";
            this.variables_QuestionsBindingNavigator.PositionItem = null;
            this.variables_QuestionsBindingNavigator.Size = new System.Drawing.Size(979, 33);
            this.variables_QuestionsBindingNavigator.TabIndex = 0;
            this.variables_QuestionsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // variables_QuestionsBindingNavigatorSaveItem
            // 
            this.variables_QuestionsBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.variables_QuestionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.variables_QuestionsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("variables_QuestionsBindingNavigatorSaveItem.Image")));
            this.variables_QuestionsBindingNavigatorSaveItem.Name = "variables_QuestionsBindingNavigatorSaveItem";
            this.variables_QuestionsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.variables_QuestionsBindingNavigatorSaveItem.Text = "Save Data";
            this.variables_QuestionsBindingNavigatorSaveItem.Click += new System.EventHandler(this.variables_QuestionsBindingNavigatorSaveItem_Click);
            // 
            // questionTextBox
            // 
            this.questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.variables_QuestionsBindingSource, "Question", true));
            this.questionTextBox.Location = new System.Drawing.Point(389, 311);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(180, 26);
            this.questionTextBox.TabIndex = 2;
            // 
            // variables_AnswersBindingSource
            // 
            this.variables_AnswersBindingSource.DataMember = "Variables_Answers";
            this.variables_AnswersBindingSource.DataSource = this.exercisesDataSet;
            // 
            // variables_AnswersTableAdapter
            // 
            this.variables_AnswersTableAdapter.ClearBeforeFill = true;
            // 
            // answerTextBox
            // 
            this.answerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.variables_AnswersBindingSource, "Answer", true));
            this.answerTextBox.Location = new System.Drawing.Point(1112, 297);
            this.answerTextBox.Name = "answerTextBox";
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
            "Double",
            "Single",
            "String"});
            this.cmbQuestion.Location = new System.Drawing.Point(389, 355);
            this.cmbQuestion.Name = "cmbQuestion";
            this.cmbQuestion.Size = new System.Drawing.Size(180, 28);
            this.cmbQuestion.TabIndex = 5;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(379, 412);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(121, 52);
            this.btnNextQuestion.TabIndex = 7;
            this.btnNextQuestion.Text = "Next";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(379, 502);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(121, 26);
            this.txtScore.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(922, 159);
            this.textBox1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 205);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Learning Section";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(246, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 283);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exercise";
            // 
            // frmVariables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 603);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(label1);
            this.Controls.Add(this.cmbQuestion);
            this.Controls.Add(answerLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(questionLabel);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.variables_QuestionsBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVariables";
            this.Text = "Variables";
            this.Load += new System.EventHandler(this.frmVariables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variables_QuestionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variables_QuestionsBindingNavigator)).EndInit();
            this.variables_QuestionsBindingNavigator.ResumeLayout(false);
            this.variables_QuestionsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variables_AnswersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.BindingNavigator variables_QuestionsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton variables_QuestionsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.BindingSource variables_AnswersBindingSource;
        private ExercisesDataSetTableAdapters.Variables_AnswersTableAdapter variables_AnswersTableAdapter;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.ComboBox cmbQuestion;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}