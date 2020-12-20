using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Project
{
    public partial class Visualization : Form
    {
        public Visualization(ref int[,] arrayD, int first, int second, string StrFirst, string StrSecond)
        {
            InitializeComponent();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns.Add($"00", " ");
            dataGridView1.Rows.Add(first);


            for (int i = 0; i < second; i++)
            {
                dataGridView1.Columns.Add($"1{StrSecond[i]}", StrSecond[i].ToString());
            }

            for (int i = 0; i < first; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = StrFirst[i];
            }

            for (var i = 1; i < arrayD.GetLength(0); i++)
            {
                for (var j = 1; j < arrayD.GetLength(1); j++)
                {
                    dataGridView1.Rows[i - 1].Cells[j].Value = arrayD[i, j];
                }
            }
        }
    }
}
