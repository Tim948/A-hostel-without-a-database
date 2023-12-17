using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kur
{
    public partial class Nomer : Form
    {
        public Nomer()
        {
            InitializeComponent();
        }

        private void nomerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nomerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kurDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kurDataSet.nomer". При необходимости она может быть перемещена или удалена.
            this.nomerTableAdapter.Fill(this.kurDataSet.nomer);

        }

        private void kmLabel_Click(object sender, EventArgs e)
        {

        }

        private void ccLabel_Click(object sender, EventArgs e)
        {

        }

        private void id_katTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private  Glav glav;
        private void button1_Click(object sender, EventArgs e)
        {
            glav = new Glav ();
            glav.Visible = true;
        }
        private  Db_Nomer nomer;
        private void button1_Click_1(object sender, EventArgs e)
        {
            nomer = new Db_Nomer();
            nomer.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private System.Windows.Forms.DataGridViewColumn COL;
        private void button3_Click(object sender, EventArgs e)
        {
            //создает переменную COL для хранения имени выбранного столбца таблицы
            
            //блок switch, записывающий в
            //переменную Col имя выбранного столбца таблицы в зависимости от номера
            //выбранного пункта списка (ListBox1.SelectedIndex).
            //Нумерация пунктов списка начинается с нуля, а нумерация столбцов с единицы.
            //Первый столбец в списке ListBox1 - «Фамилия» носит в таблице имя
            // DataGridViewTextBoxColumn3, указанное в свойствах полей
            //в Меню действий таблицы.
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn3;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn4;
                    break;
               
            }
            //Блок If выполняет следующую операцию: если включён

            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать
            //таблицу по полю, заданному в переменной Col по возрастанию
            //(studentsDataGridView.Sort (Col, System.ComponentModel.ListSortDirection.
            //Ascending)), иначе по убыванию (studentsDataGridView.Sort (Col, System.
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked) nomerDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else nomerDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nomerDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < nomerDataGridView.RowCount - 1; j++)
                {
                    nomerDataGridView[i, j].Style.BackColor = Color.White;
                    nomerDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < nomerDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < nomerDataGridView.RowCount - 1; j++)
                {
                    if (nomerDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        nomerDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        nomerDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }
        private Nomer NNomer;
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            NNomer = new Nomer();
            NNomer.Visible = true;
        }
    }
}
