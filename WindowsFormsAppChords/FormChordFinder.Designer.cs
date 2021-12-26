namespace WindowsFormsAppChords
{
    partial class FormChordFinder
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
            this.buttonFindChord = new System.Windows.Forms.Button();
            this.textBoxEnterChordNotes = new System.Windows.Forms.TextBox();
            this.labelEnterChordNotes = new System.Windows.Forms.Label();
            this.panelChordFound = new System.Windows.Forms.Panel();
            this.textBoxChordResult = new System.Windows.Forms.TextBox();
            this.labelChordFound = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelChordFound.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.buttonFindChord);
            this.panel1.Controls.Add(this.textBoxEnterChordNotes);
            this.panel1.Controls.Add(this.labelEnterChordNotes);
            this.panel1.Location = new System.Drawing.Point(39, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 194);
            this.panel1.TabIndex = 0;
            // 
            // buttonFindChord
            // 
            this.buttonFindChord.AutoSize = true;
            this.buttonFindChord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindChord.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.buttonFindChord.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFindChord.Location = new System.Drawing.Point(24, 98);
            this.buttonFindChord.Name = "buttonFindChord";
            this.buttonFindChord.Size = new System.Drawing.Size(111, 45);
            this.buttonFindChord.TabIndex = 2;
            this.buttonFindChord.Text = "Find Chord";
            this.buttonFindChord.UseVisualStyleBackColor = true;
            this.buttonFindChord.Click += new System.EventHandler(this.buttonFindChord_Click);
            // 
            // textBoxEnterChordNotes
            // 
            this.textBoxEnterChordNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEnterChordNotes.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxEnterChordNotes.Location = new System.Drawing.Point(24, 59);
            this.textBoxEnterChordNotes.Name = "textBoxEnterChordNotes";
            this.textBoxEnterChordNotes.Size = new System.Drawing.Size(243, 22);
            this.textBoxEnterChordNotes.TabIndex = 1;
            this.textBoxEnterChordNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEnterChordNotes_KeyDown);
            // 
            // labelEnterChordNotes
            // 
            this.labelEnterChordNotes.AutoSize = true;
            this.labelEnterChordNotes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterChordNotes.ForeColor = System.Drawing.Color.White;
            this.labelEnterChordNotes.Location = new System.Drawing.Point(19, 18);
            this.labelEnterChordNotes.Name = "labelEnterChordNotes";
            this.labelEnterChordNotes.Size = new System.Drawing.Size(248, 28);
            this.labelEnterChordNotes.TabIndex = 0;
            this.labelEnterChordNotes.Text = "Enter notes of the chord:";
            // 
            // panelChordFound
            // 
            this.panelChordFound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChordFound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelChordFound.Controls.Add(this.textBoxChordResult);
            this.panelChordFound.Controls.Add(this.labelChordFound);
            this.panelChordFound.Location = new System.Drawing.Point(415, 40);
            this.panelChordFound.Name = "panelChordFound";
            this.panelChordFound.Size = new System.Drawing.Size(283, 392);
            this.panelChordFound.TabIndex = 1;
            // 
            // textBoxChordResult
            // 
            this.textBoxChordResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.textBoxChordResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChordResult.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChordResult.ForeColor = System.Drawing.Color.White;
            this.textBoxChordResult.Location = new System.Drawing.Point(18, 62);
            this.textBoxChordResult.MinimumSize = new System.Drawing.Size(100, 100);
            this.textBoxChordResult.Name = "textBoxChordResult";
            this.textBoxChordResult.ReadOnly = true;
            this.textBoxChordResult.Size = new System.Drawing.Size(249, 24);
            this.textBoxChordResult.TabIndex = 1;
            // 
            // labelChordFound
            // 
            this.labelChordFound.AutoSize = true;
            this.labelChordFound.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChordFound.ForeColor = System.Drawing.Color.White;
            this.labelChordFound.Location = new System.Drawing.Point(13, 18);
            this.labelChordFound.Name = "labelChordFound";
            this.labelChordFound.Size = new System.Drawing.Size(192, 28);
            this.labelChordFound.TabIndex = 0;
            this.labelChordFound.Text = "Chord Information:";
            // 
            // FormChordFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.panelChordFound);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChordFinder";
            this.Text = "formChordFinder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelChordFound.ResumeLayout(false);
            this.panelChordFound.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxEnterChordNotes;
        private System.Windows.Forms.Label labelEnterChordNotes;
        private System.Windows.Forms.Panel panelChordFound;
        private System.Windows.Forms.Label labelChordFound;
        private System.Windows.Forms.TextBox textBoxChordResult;
        private System.Windows.Forms.Button buttonFindChord;
    }
}