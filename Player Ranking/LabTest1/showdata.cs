using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTest1
{
    public partial class showdata : Form
    {

        public showdata(int x, Player[] arr)
        {
            InitializeComponent();
            DGVShowData.ColumnCount = 4;
            DGVShowData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DGVShowData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGVShowData.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DGVShowData.GridColor = Color.Black;
            DGVShowData.RowHeadersVisible = false;
            DGVShowData.Columns[0].Name = "RANK";
            DGVShowData.Columns[1].Name = "PLAYER";
            DGVShowData.Columns[2].Name = "SCORE1";
            DGVShowData.Columns[3].Name = "SCORE2";
            DGVShowData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < x; i++)
            {
                for (int i2 = 0; i2 < x; i2++)
                {
                    if (arr[i2].PlayerRank == (i+1))
                    {
                        DGVShowData.Rows.Add(arr[i2].PlayerRank, arr[i2].PlayerName, arr[i2].PlayerScore1, arr[i2].PlayerScore2);
                    }
                }
            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
