namespace WindowsFormsAppChords
{
    partial class Form1
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnKeyFinder = new System.Windows.Forms.Button();
            this.btnChordFinder = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelNameApp = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelSideMenu.Controls.Add(this.panelNav);
            this.panelSideMenu.Controls.Add(this.btnKeyFinder);
            this.panelSideMenu.Controls.Add(this.btnChordFinder);
            this.panelSideMenu.Controls.Add(this.btnDashboard);
            this.panelSideMenu.Controls.Add(this.panel2);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(186, 577);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelNav.Location = new System.Drawing.Point(0, 193);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(3, 100);
            this.panelNav.TabIndex = 1;
            // 
            // btnKeyFinder
            // 
            this.btnKeyFinder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnKeyFinder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKeyFinder.FlatAppearance.BorderSize = 0;
            this.btnKeyFinder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyFinder.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyFinder.ForeColor = System.Drawing.Color.White;
            this.btnKeyFinder.Location = new System.Drawing.Point(0, 264);
            this.btnKeyFinder.Name = "btnKeyFinder";
            this.btnKeyFinder.Size = new System.Drawing.Size(186, 60);
            this.btnKeyFinder.TabIndex = 3;
            this.btnKeyFinder.Text = "Key Finder";
            this.btnKeyFinder.UseVisualStyleBackColor = false;
            this.btnKeyFinder.Click += new System.EventHandler(this.btnKeyFinder_Click);
            this.btnKeyFinder.Leave += new System.EventHandler(this.btnKeyFinder_Leave);
            // 
            // btnChordFinder
            // 
            this.btnChordFinder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnChordFinder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChordFinder.FlatAppearance.BorderSize = 0;
            this.btnChordFinder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChordFinder.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChordFinder.ForeColor = System.Drawing.Color.White;
            this.btnChordFinder.Location = new System.Drawing.Point(0, 204);
            this.btnChordFinder.Name = "btnChordFinder";
            this.btnChordFinder.Size = new System.Drawing.Size(186, 60);
            this.btnChordFinder.TabIndex = 2;
            this.btnChordFinder.Text = "Chord Finder";
            this.btnChordFinder.UseVisualStyleBackColor = false;
            this.btnChordFinder.Click += new System.EventHandler(this.btnChordFinder_Click);
            this.btnChordFinder.Leave += new System.EventHandler(this.btnChordFinder_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 144);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(186, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelNameApp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // labelNameApp
            // 
            this.labelNameApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNameApp.AutoSize = true;
            this.labelNameApp.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelNameApp.ForeColor = System.Drawing.Color.White;
            this.labelNameApp.Location = new System.Drawing.Point(23, 16);
            this.labelNameApp.Name = "labelNameApp";
            this.labelNameApp.Size = new System.Drawing.Size(138, 123);
            this.labelNameApp.TabIndex = 0;
            this.labelNameApp.Text = "Music\r\nTheory \r\nMachine";
            this.labelNameApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelTitle.Location = new System.Drawing.Point(209, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(195, 39);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Dashboard";
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFormLoader.Location = new System.Drawing.Point(186, 100);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(765, 477);
            this.panelFormLoader.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(951, 577);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelNameApp;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnKeyFinder;
        private System.Windows.Forms.Button btnChordFinder;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelFormLoader;
    }
}

