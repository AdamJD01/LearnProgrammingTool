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
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.variables_QuestionsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.variables_AnswersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.variables_AnswersTableAdapter = new LearnProgrammingTool.ExercisesDataSetTableAdapters.Variables_AnswersTableAdapter();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.cmbQuestion1 = new System.Windows.Forms.ComboBox();
            this.btnQuestion1 = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            questionLabel = new System.Windows.Forms.Label();
            answerLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variables_QuestionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variables_QuestionsBindingNavigator)).BeginInit();
            this.variables_QuestionsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variables_AnswersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new System.Drawing.Point(12, 59);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new System.Drawing.Size(77, 20);
            questionLabel.TabIndex = 1;
            questionLabel.Text = "Question:";
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Location = new System.Drawing.Point(246, 59);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new System.Drawing.Size(66, 20);
            answerLabel.TabIndex = 3;
            answerLabel.Text = "Answer:";
            answerLabel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 103);
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
            this.variables_QuestionsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.variables_QuestionsBindingNavigator.DeleteItem = null;
            this.variables_QuestionsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.variables_QuestionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.variables_QuestionsBindingNavigatorSaveItem});
            this.variables_QuestionsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.variables_QuestionsBindingNavigator.MoveFirstItem = null;
            this.variables_QuestionsBindingNavigator.MoveLastItem = null;
            this.variables_QuestionsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.variables_QuestionsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.variables_QuestionsBindingNavigator.Name = "variables_QuestionsBindingNavigator";
            this.variables_QuestionsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.variables_QuestionsBindingNavigator.Size = new System.Drawing.Size(248, 33);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // variables_QuestionsBindingNavigatorSaveItem
            // 
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
            this.questionTextBox.Location = new System.Drawing.Point(95, 56);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(121, 26);
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
            this.answerTextBox.Location = new System.Drawing.Point(318, 56);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(100, 26);
            this.answerTextBox.TabIndex = 4;
            this.answerTextBox.Visible = false;
            // 
            // cmbQuestion1
            // 
            this.cmbQuestion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestion1.FormattingEnabled = true;
            this.cmbQuestion1.Items.AddRange(new object[] {
            "Boolean",
            "Double",
            "Single",
            "String"});
            this.cmbQuestion1.Location = new System.Drawing.Point(95, 100);
            this.cmbQuestion1.Name = "cmbQuestion1";
            this.cmbQuestion1.Size = new System.Drawing.Size(121, 28);
            this.cmbQuestion1.TabIndex = 5;
            // 
            // btnQuestion1
            // 
            this.btnQuestion1.Location = new System.Drawing.Point(80, 158);
            this.btnQuestion1.Name = "btnQuestion1";
            this.btnQuestion1.Size = new System.Drawing.Size(121, 52);
            this.btnQuestion1.TabIndex = 7;
            this.btnQuestion1.Text = "Next";
            this.btnQuestion1.UseVisualStyleBackColor = true;
            this.btnQuestion1.Click += new System.EventHandler(this.btnQuestion1_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(80, 240);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(121, 26);
            this.txtScore.TabIndex = 8;
            // 
            // frmVariables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 290);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnQuestion1);
            this.Controls.Add(label1);
            this.Controls.Add(this.cmbQuestion1);
            this.Controls.Add(answerLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(questionLabel);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.variables_QuestionsBindingNavigator);
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
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton variables_QuestionsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.BindingSource variables_AnswersBindingSource;
        private ExercisesDataSetTableAdapters.Variables_AnswersTableAdapter variables_AnswersTableAdapter;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.ComboBox cmbQuestion1;
        private System.Windows.Forms.Button btnQuestion1;
        private System.Windows.Forms.TextBox txtScore;
    }
}