namespace LearnProgrammingTool
{
    partial class frmMain
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
            this.cmbMain = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbMain
            // 
            this.cmbMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMain.FormattingEnabled = true;
            this.cmbMain.Items.AddRange(new object[] {
            "Introduction",
            "Variables",
            "Input and Output",
            "Logic",
            "Calculation",
            "If Statements",
            "Cases",
            "Loops",
            "Validation",
            "Recap"});
            this.cmbMain.Location = new System.Drawing.Point(320, 75);
            this.cmbMain.MaxDropDownItems = 11;
            this.cmbMain.Name = "cmbMain";
            this.cmbMain.Size = new System.Drawing.Size(182, 28);
            this.cmbMain.TabIndex = 0;
            this.cmbMain.SelectedIndexChanged += new System.EventHandler(this.cmbMain_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose the topic you want to learn about:\r\n";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMain);
            this.Name = "frmMain";
            this.Text = "Learn VB Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMain;
        private System.Windows.Forms.Label label1;
    }
}

