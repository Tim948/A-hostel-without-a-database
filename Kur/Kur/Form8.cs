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
    public partial class Den : Form
    {
        public Den()
        {
            InitializeComponent();
        }

        private void jobBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jobBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kurDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kurDataSet.job". При необходимости она может быть перемещена или удалена.
            this.jobTableAdapter.Fill(this.kurDataSet.job);

        }
        private Dobav zaezd;
        private void button1_Click(object sender, EventArgs e)
        {
            zaezd = new Dobav();
            zaezd.Visible = true;
        }
        private Den Dni;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Dni = new Den();
            Dni.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
