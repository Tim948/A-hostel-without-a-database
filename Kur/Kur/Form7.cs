﻿using System;
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
    public partial class Db_person : Form
    {
        public Db_person()
        {
            InitializeComponent();
        }

        private void personalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kurDataSet);

        }

        private void Db_person_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kurDataSet.personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.kurDataSet.personal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void otTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
