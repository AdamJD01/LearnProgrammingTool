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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.cmbQuestion2 = new System.Windows.Forms.ComboBox();
            this.grpQuestion2 = new System.Windows.Forms.Label();
            this.grpVariableScore = new System.Windows.Forms.GroupBox();
            //this.btnBackScore = new System.Windows.Forms.Button();
            this.txtShowResult = new System.Windows.Forms.TextBox();
            this.grpVariableQuestion2 = new System.Windows.Forms.GroupBox();
            //this.btnBackVariableQuestion2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btnNextVariableQuestion2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.grpVariableQuestion1 = new System.Windows.Forms.GroupBox();
            this.cmbVariableQuestion1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNextVariableQuestion1 = new System.Windows.Forms.Button();
            this.grpVariableScore.SuspendLayout();
            this.grpVariableQuestion2.SuspendLayout();
            this.grpVariableQuestion1.SuspendLayout();
            this.SuspendLayout();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Score   =";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(277, 57);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(52, 26);
            this.txtScore.TabIndex = 7;
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
            // grpVariableScore
            // 
            //this.grpVariableScore.Controls.Add(this.btnBackScore);
            this.grpVariableScore.Controls.Add(this.txtShowResult);
            this.grpVariableScore.Controls.Add(this.txtScore);
            this.grpVariableScore.Controls.Add(this.label4);
            this.grpVariableScore.Location = new System.Drawing.Point(32, 21);
            this.grpVariableScore.Name = "grpVariableScore";
            this.grpVariableScore.Size = new System.Drawing.Size(463, 215);
            this.grpVariableScore.TabIndex = 13;
            this.grpVariableScore.TabStop = false;
            this.grpVariableScore.Text = "Score";
            this.grpVariableScore.Visible = false;
            // 
            // btnBackScore
            // 
            /*
            this.btnBackScore.Location = new System.Drawing.Point(11, 132);
            this.btnBackScore.Name = "btnBackScore";
            this.btnBackScore.Size = new System.Drawing.Size(163, 44);
            this.btnBackScore.TabIndex = 24;
            this.btnBackScore.Text = "Back";
            this.btnBackScore.UseVisualStyleBackColor = true;
            this.btnBackScore.Click += new System.EventHandler(this.btnBackScore_Click);
            */
            // 
            // txtShowResult
            // 
            this.txtShowResult.Location = new System.Drawing.Point(281, 141);
            this.txtShowResult.Name = "txtShowResult";
            this.txtShowResult.ReadOnly = true;
            this.txtShowResult.Size = new System.Drawing.Size(158, 26);
            this.txtShowResult.TabIndex = 8;
            // 
            // grpVariableQuestion2
            // 
            //this.grpVariableQuestion2.Controls.Add(this.btnBackVariableQuestion2);
            this.grpVariableQuestion2.Controls.Add(this.label1);
            this.grpVariableQuestion2.Controls.Add(this.comboBox3);
            this.grpVariableQuestion2.Controls.Add(this.btnNextVariableQuestion2);
            this.grpVariableQuestion2.Controls.Add(this.label7);
            this.grpVariableQuestion2.Location = new System.Drawing.Point(32, 21);
            this.grpVariableQuestion2.Name = "grpVariableQuestion2";
            this.grpVariableQuestion2.Size = new System.Drawing.Size(463, 215);
            this.grpVariableQuestion2.TabIndex = 14;
            this.grpVariableQuestion2.TabStop = false;
            this.grpVariableQuestion2.Text = "Question2";
            this.grpVariableQuestion2.Visible = false;
            // 
            // btnBackVariableQuestion2
            // 
            /*
            this.btnBackVariableQuestion2.Location = new System.Drawing.Point(10, 138);
            this.btnBackVariableQuestion2.Name = "btnBackVariableQuestion2";
            this.btnBackVariableQuestion2.Size = new System.Drawing.Size(163, 44);
            this.btnBackVariableQuestion2.TabIndex = 25;
            this.btnBackVariableQuestion2.Text = "Back";
            this.btnBackVariableQuestion2.UseVisualStyleBackColor = true;
            this.btnBackVariableQuestion2.Click += new System.EventHandler(this.btnBackVariableQuestion2_Click_1);
            */
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Variable Types";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Boolean",
            "Date",
            "Double",
            "Single",
            "String"});
            this.comboBox3.Location = new System.Drawing.Point(280, 80);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(158, 28);
            this.comboBox3.TabIndex = 11;
            // 
            // btnNextVariableQuestion2
            // 
            this.btnNextVariableQuestion2.Location = new System.Drawing.Point(270, 138);
            this.btnNextVariableQuestion2.Name = "btnNextVariableQuestion2";
            this.btnNextVariableQuestion2.Size = new System.Drawing.Size(163, 44);
            this.btnNextVariableQuestion2.TabIndex = 3;
            this.btnNextVariableQuestion2.Text = "Next";
            this.btnNextVariableQuestion2.UseVisualStyleBackColor = true;
            this.btnNextVariableQuestion2.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Dim isItRaining As _________";
            // 
            // grpVariableQuestion1
            // 
            this.grpVariableQuestion1.Controls.Add(this.cmbVariableQuestion1);
            this.grpVariableQuestion1.Controls.Add(this.label12);
            this.grpVariableQuestion1.Controls.Add(this.label11);
            this.grpVariableQuestion1.Controls.Add(this.btnNextVariableQuestion1);
            this.grpVariableQuestion1.Location = new System.Drawing.Point(26, 21);
            this.grpVariableQuestion1.Name = "grpVariableQuestion1";
            this.grpVariableQuestion1.Size = new System.Drawing.Size(463, 215);
            this.grpVariableQuestion1.TabIndex = 8;
            this.grpVariableQuestion1.TabStop = false;
            this.grpVariableQuestion1.Text = "Question1";
            this.grpVariableQuestion1.Visible = false;
            // 
            // cmbVariableQuestion1
            // 
            this.cmbVariableQuestion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariableQuestion1.FormattingEnabled = true;
            this.cmbVariableQuestion1.Items.AddRange(new object[] {
            "Boolean",
            "Date",
            "Double",
            "Single",
            "String"});
            this.cmbVariableQuestion1.Location = new System.Drawing.Point(282, 95);
            this.cmbVariableQuestion1.Name = "cmbVariableQuestion1";
            this.cmbVariableQuestion1.Size = new System.Drawing.Size(158, 28);
            this.cmbVariableQuestion1.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(158, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 22);
            this.label12.TabIndex = 18;
            this.label12.Text = "Variable Types";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 22);
            this.label11.TabIndex = 19;
            this.label11.Text = "Dim tutorName As _________";
            // 
            // btnNextVariableQuestion1
            // 
            this.btnNextVariableQuestion1.Location = new System.Drawing.Point(140, 154);
            this.btnNextVariableQuestion1.Name = "btnNextVariableQuestion1";
            this.btnNextVariableQuestion1.Size = new System.Drawing.Size(163, 44);
            this.btnNextVariableQuestion1.TabIndex = 21;
            this.btnNextVariableQuestion1.Text = "Next";
            this.btnNextVariableQuestion1.UseVisualStyleBackColor = true;
            this.btnNextVariableQuestion1.Click += new System.EventHandler(this.btnVariableQuestion1_Click);
            // 
            // frmVariables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 275);
            this.Controls.Add(this.grpVariableQuestion1);
            this.Controls.Add(this.grpVariableQuestion2);
            this.Controls.Add(this.grpVariableScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVariables";
            this.Text = "Variables";
            this.grpVariableScore.ResumeLayout(false);
            this.grpVariableScore.PerformLayout();
            this.grpVariableQuestion2.ResumeLayout(false);
            this.grpVariableQuestion2.PerformLayout();
            this.grpVariableQuestion1.ResumeLayout(false);
            this.grpVariableQuestion1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.ComboBox cmbQuestion2;
        private System.Windows.Forms.Label grpQuestion2;
        //private System.Windows.Forms.GroupBox grpVariableQuestion2;
        //private System.Windows.Forms.Button btnNextVariableQuestion2;
        private System.Windows.Forms.GroupBox grpVariableScore;
        private System.Windows.Forms.TextBox txtShowResult;
        private System.Windows.Forms.GroupBox grpVariableQuestion2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btnNextVariableQuestion2;
        private System.Windows.Forms.Label label7;
        //private System.Windows.Forms.Button btnBackVariableQuestion2;
        private System.Windows.Forms.Button btnBackScore;
        private System.Windows.Forms.Button btnNextVariableQuestion1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbVariableQuestion1;
        private System.Windows.Forms.GroupBox grpVariableQuestion1;
        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Button btnBackVariableQuestion2;
    }
}