using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Add(1, "ON", "ON", "ON");
            dataGridView.Rows.Add(2, "ON", "ON", "ON");
            dataGridView.Rows.Add(3, "ON", "ON", "ON");
            dataGridView.Rows.Add(4, "ON", "ON", "ON");
            dataGridView.Rows.Add(5, "ON", "ON", "ON");

            
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                int index = e.RowIndex;
                if(MessageBox.Show("Are you sure want to delete this row ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                    == DialogResult.Yes)
                {
                    dataGridView.Rows.RemoveAt(index);
                }
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Add(numbertxt.Text, "ON", "ON", "ON");

        }
    }
}
