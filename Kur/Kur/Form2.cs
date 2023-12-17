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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void klientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kurDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kurDataSet.klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.kurDataSet.klient);

        }

        private void iTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pasportTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void klientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private spisok_klientov Spisok_K;
        private void button1_Click(object sender, EventArgs e)
        {
            Spisok_K = new spisok_klientov();
            Spisok_K.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
    }
    }
}
