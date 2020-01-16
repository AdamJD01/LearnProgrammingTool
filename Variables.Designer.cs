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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbQuestion1 = new System.Windows.Forms.ComboBox();
            this.btnNextQuestion1 = new System.Windows.Forms.Button();
            this.cmbQuestion2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Variable Types";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dim tutorName As _________";
            // 
            // cmbQuestion1
            // 
            this.cmbQuestion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestion1.FormattingEnabled = true;
            this.cmbQuestion1.Items.AddRange(new object[] {
            "Boolean",
            "Date",
            "Double",
            "Single",
            "String"});
            this.cmbQuestion1.Location = new System.Drawing.Point(295, 93);
            this.cmbQuestion1.Name = "cmbQuestion1";
            this.cmbQuestion1.Size = new System.Drawing.Size(158, 28);
            this.cmbQuestion1.TabIndex = 2;
            // 
            // btnNextQuestion1
            // 
            this.btnNextQuestion1.Location = new System.Drawing.Point(165, 291);
            this.btnNextQuestion1.Name = "btnNextQuestion1";
            this.btnNextQuestion1.Size = new System.Drawing.Size(163, 44);
            this.btnNextQuestion1.TabIndex = 3;
            this.btnNextQuestion1.Text = "Next";
            this.btnNextQuestion1.UseVisualStyleBackColor = true;
            this.btnNextQuestion1.Click += new System.EventHandler(this.btnNextQuestion1_Click);
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
            this.cmbQuestion2.Location = new System.Drawing.Point(295, 195);
            this.cmbQuestion2.Name = "cmbQuestion2";
            this.cmbQuestion2.Size = new System.Drawing.Size(158, 28);
            this.cmbQuestion2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dim isItRaining As _________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Score   =";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(260, 392);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(52, 26);
            this.txtScore.TabIndex = 7;
            // 
            // frmVariables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbQuestion2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNextQuestion1);
            this.Controls.Add(this.cmbQuestion1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVariables";
            this.Text = "Variables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbQuestion1;
        private System.Windows.Forms.Button btnNextQuestion1;
        private System.Windows.Forms.ComboBox cmbQuestion2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtScore;
    }
}