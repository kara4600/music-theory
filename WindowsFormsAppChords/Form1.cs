using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsAppChords
{

    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panelNav.Height = btnDashboard.Height;
            panelNav.Top = btnDashboard.Top;
            panelNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            labelTitle.Text = "Dashboard";
            this.panelFormLoader.Controls.Clear();
            FormDashboard formDashboard_Vrb = new FormDashboard
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            formDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(formDashboard_Vrb);
            formDashboard_Vrb.Show();

        }
        
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnDashboard.Height;
            panelNav.Top = btnDashboard.Top;
            panelNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            labelTitle.Text = "Dashboard";
            this.panelFormLoader.Controls.Clear();
            FormDashboard formDashboard_Vrb = new FormDashboard
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            formDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(formDashboard_Vrb);
            formDashboard_Vrb.Show();
        }
 
        private void btnChordFinder_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnChordFinder.Height;
            panelNav.Top = btnChordFinder.Top;
            btnChordFinder.BackColor = Color.FromArgb(46, 51, 73);

            labelTitle.Text = "Chord Finder";
            this.panelFormLoader.Controls.Clear();
            FormChordFinder FormChordFinder_Vrb = new FormChordFinder
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            FormChordFinder_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FormChordFinder_Vrb);
            FormChordFinder_Vrb.Show();
        }

        private void btnKeyFinder_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnKeyFinder.Height;
            panelNav.Top = btnKeyFinder.Top;
            btnKeyFinder.BackColor = Color.FromArgb(46, 51, 73);

            labelTitle.Text = "Key Finder";
            this.panelFormLoader.Controls.Clear();
            FormKeyFinder FormKeyFinder_Vrb = new FormKeyFinder
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            FormKeyFinder_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FormKeyFinder_Vrb);
            FormKeyFinder_Vrb.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnChordFinder_Leave(object sender, EventArgs e)
        {
            btnChordFinder.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnKeyFinder_Leave(object sender, EventArgs e)
        {
            btnKeyFinder.BackColor = Color.FromArgb(24, 30, 54);
        }

    }

}
