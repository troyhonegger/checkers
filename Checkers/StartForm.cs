using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            radioButton4.Checked = true;
            SetNewGameEnabled();
        }

        private void SetNewGameEnabled() => startButton.Enabled = (radioButton1.Checked || comboBox1.SelectedIndex != -1) && (radioButton3.Checked || comboBox2.SelectedIndex != -1);

        private void startButton_Click(object sender, EventArgs e)
        {
            int p1Diff = radioButton1.Checked ? -1 : comboBox1.SelectedIndex;
            int p2Diff = radioButton3.Checked ? -1 : comboBox2.SelectedIndex;
            new BoardForm(this, p1Diff, p2Diff).Show();
            this.Hide();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = !radioButton1.Checked;
            comboBox1.Visible = !radioButton1.Checked;
            SetNewGameEnabled();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = !radioButton3.Checked;
            comboBox2.Visible = !radioButton3.Checked;
            SetNewGameEnabled();
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e) => SetNewGameEnabled();
    }
}