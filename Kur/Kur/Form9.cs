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
    public partial class Dobav : Form
    {
        public Dobav()
        {
            InitializeComponent();
        }

        private void jobBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jobBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kurDataSet);

        }

        private void Dobav_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kurDataSet.personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.kurDataSet.personal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kurDataSet.klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.kurDataSet.klient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kurDataSet.klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.kurDataSet.klient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kurDataSet.nomer". При необходимости она может быть перемещена или удалена.
            this.nomerTableAdapter.Fill(this.kurDataSet.nomer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kurDataSet.job". При необходимости она может быть перемещена или удалена.
            this.jobTableAdapter.Fill(this.kurDataSet.job);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
