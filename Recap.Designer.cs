namespace LearnProgrammingTool
{
    partial class frmRecap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecap));
            this.txtIntroduction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIntroduction
            // 
            this.txtIntroduction.Cursor = System.Windows.Forms.Cursors.No;
            this.txtIntroduction.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntroduction.Location = new System.Drawing.Point(12, 18);
            this.txtIntroduction.Multiline = true;
            this.txtIntroduction.Name = "txtIntroduction";
            this.txtIntroduction.ReadOnly = true;
            this.txtIntroduction.Size = new System.Drawing.Size(777, 415);
            this.txtIntroduction.TabIndex = 1;
            this.txtIntroduction.TabStop = false;
            this.txtIntroduction.Text = resources.GetString("txtIntroduction.Text");
            // 
            // frmRecap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIntroduction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecap";
            this.Text = "Recap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIntroduction;
    }
}