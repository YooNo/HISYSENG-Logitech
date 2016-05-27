using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HISYSENG_Logitech
{
    class hGrid
    {
        public void SetCol(DataGridView Grd, string Caption, string Name, int colWidth)
        {
            DataGridViewTextBoxColumn Col = new DataGridViewTextBoxColumn();

            Col.HeaderText = Caption;
            Col.Name = Name;
            Col.Visible = true;
            Col.Width = colWidth;

            Grd.Columns.Add(Col);
        }

        public void SetCol(DataGridView Grd, string ColName, string Caption)
        {
            DataGridViewColumn Col = new DataGridViewTextBoxColumn();

            Col = Grd.Columns[ColName];

            Col.HeaderText = Caption;
        }

        public void SetCol(DataGridView Grd, string ColName, string Caption, int colWidth, bool colVisible)
        {
            DataGridViewColumn Col = new DataGridViewTextBoxColumn();

            Col = Grd.Columns[ColName];
            Col.Width = colWidth;
            Col.HeaderText = Caption;
            Col.Visible = colVisible;
        }

        public void SetCol(DataGridView Grd, string Caption, string Name, bool colVisible)
        {
            DataGridViewTextBoxColumn Col = new DataGridViewTextBoxColumn();

            Col.HeaderText = Caption;
            Col.Name = Name;
            Col.Visible = colVisible;

            Grd.Columns.Add(Col);
        }

        public void SetColCombo(DataGridView Grd, string Caption, string Name, int colWidth)
        {
            DataGridViewComboBoxColumn Col = new DataGridViewComboBoxColumn();

            Col.HeaderText = Caption;
            Col.Name = Name;
            Col.Visible = true;
            Col.Width = colWidth;

            Grd.Columns.Add(Col);
        }

        public void SetColCheck(DataGridView Grd, string Caption, string Name, int colWidth)
        {
            DataGridViewCheckBoxColumn Col = new DataGridViewCheckBoxColumn();

            Col.HeaderText = Caption;
            Col.Name = Name;
            Col.Visible = true;
            Col.Width = colWidth;

            Grd.Columns.Add(Col);
        }

        public void AlignCenter(DataGridView Grd, int Col)
        {
            Grd.Columns[Col].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void AlignCenter(DataGridView Grd, string Col)
        {
            Grd.Columns[Col].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void AlignLeft(DataGridView Grd, int Col)
        {
            Grd.Columns[Col].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        public void AlignLeft(DataGridView Grd, string Col)
        {
            Grd.Columns[Col].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        public void AlignRight(DataGridView Grd, int Col)
        {
            Grd.Columns[Col].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void AlignRight(DataGridView Grd, string Col)
        {
            Grd.Columns[Col].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }


        public void Init(DataGridView Grd)
        {
            Grd.RowCount = 1;
            Grd.ColumnCount = 0;
            
        }

        public void HeaderAlignment(DataGridView Grd)
        {
            foreach (DataGridViewColumn Col in Grd.Columns)
            {
                Col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

    }
}
