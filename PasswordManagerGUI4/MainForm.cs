using System;
using System.Windows.Forms;

namespace PasswordManagerGUI4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("MainForm loaded");
        }

        private void btnAdd_Click(object sender, EventArgs e) { }
        private void btnDelete_Click(object sender, EventArgs e) { }
        private void btnReveal_Click(object sender, EventArgs e) { }
    }
}
