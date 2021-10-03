using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class table : Form
    {
        public int id;
        public List<RootObject> myObj;
        public table(List<RootObject> obj)
        {
            InitializeComponent();
            myObj = obj;
        }

        private void Table_Load(object sender, EventArgs e)
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "№";
            column1.Name = "Number";
            column1.ReadOnly = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Наименование";
            column2.Name = "Name";
            column2.ReadOnly = true;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Административный округ";
            column3.Name = "AdmArea";
            column3.ReadOnly = true;
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Район";
            column4.Name = "District";
            column4.ReadOnly = true;
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Адрес";
            column5.Name = "Address";
            column5.ReadOnly = true;
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Координаты";
            column6.Name = "Coordinates";
            column6.ReadOnly = true;
            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "global_id";
            column7.Name = "global_id";
            column7.ReadOnly = true;
            column7.CellTemplate = new DataGridViewTextBoxCell();

            mData.Columns.Add(column1);
            mData.Columns.Add(column2);
            mData.Columns.Add(column3);
            mData.Columns.Add(column4);
            mData.Columns.Add(column5);
            mData.Columns.Add(column6);
            mData.Columns.Add(column7);

            mData.AllowUserToAddRows = false;

            foreach(var el in myObj)
            {
                mData.Rows.Add(el.Number, el.Cells.Name, el.Cells.AdmArea, el.Cells.District, el.Cells.Address, (el.Cells.geoData.coordinates.ElementAt(1) + ", " +
                    el.Cells.geoData.coordinates.ElementAt(0)), el.global_id);
            }
            mData.CellContentDoubleClick += MData_CellContentDoubleClick;
        }

        private void MData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = e.RowIndex;
            selected f = new selected(this);
            f.ShowDialog();
        }
    }
}
