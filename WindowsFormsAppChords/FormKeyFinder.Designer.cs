namespace WindowsFormsAppChords
{
    partial class FormKeyFinder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxEnterKeyNotes = new System.Windows.Forms.TextBox();
            this.labelEnterKeyNotes = new System.Windows.Forms.Label();
            this.panelKeyFound = new System.Windows.Forms.Panel();
            this.labelKeyFound = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelKeyFound.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.textBoxEnterKeyNotes);
            this.panel1.Controls.Add(this.labelEnterKeyNotes);
            this.panel1.Location = new System.Drawing.Point(39, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 194);
            this.panel1.TabIndex = 0;
            // 
            // textBoxEnterKeyNotes
            // 
            this.textBoxEnterKeyNotes.Location = new System.Drawing.Point(24, 59);
            this.textBoxEnterKeyNotes.Name = "textBoxEnterKeyNotes";
            this.textBoxEnterKeyNotes.Size = new System.Drawing.Size(243, 22);
            this.textBoxEnterKeyNotes.TabIndex = 1;
            // 
            // labelEnterKeyNotes
            // 
            this.labelEnterKeyNotes.AutoSize = true;
            this.labelEnterKeyNotes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterKeyNotes.ForeColor = System.Drawing.Color.White;
            this.labelEnterKeyNotes.Location = new System.Drawing.Point(19, 18);
            this.labelEnterKeyNotes.Name = "labelEnterKeyNotes";
            this.labelEnterKeyNotes.Size = new System.Drawing.Size(125, 28);
            this.labelEnterKeyNotes.TabIndex = 0;
            this.labelEnterKeyNotes.Text = "Enter notes:";
            // 
            // panelKeyFound
            // 
            this.panelKeyFound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKeyFound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelKeyFound.Controls.Add(this.labelKeyFound);
            this.panelKeyFound.Location = new System.Drawing.Point(415, 40);
            this.panelKeyFound.Name = "panelKeyFound";
            this.panelKeyFound.Size = new System.Drawing.Size(283, 392);
            this.panelKeyFound.TabIndex = 1;
            // 
            // labelKeyFound
            // 
            this.labelKeyFound.AutoSize = true;
            this.labelKeyFound.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeyFound.ForeColor = System.Drawing.Color.White;
            this.labelKeyFound.Location = new System.Drawing.Point(13, 18);
            this.labelKeyFound.Name = "labelKeyFound";
            this.labelKeyFound.Size = new System.Drawing.Size(171, 28);
            this.labelKeyFound.TabIndex = 0;
            this.labelKeyFound.Text = "Key Information:";
            // 
            // FormKeyFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.panelKeyFound);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKeyFinder";
            this.Text = "FormKeyFinder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelKeyFound.ResumeLayout(false);
            this.panelKeyFound.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEnterKeyNotes;
        private System.Windows.Forms.TextBox textBoxEnterKeyNotes;
        private System.Windows.Forms.Panel panelKeyFound;
        private System.Windows.Forms.Label labelKeyFound;
    }
}