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
    public partial class Db_Nomer : Form
    {
        public Db_Nomer()
        {
            InitializeComponent();
        }

        private void nomerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nomerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kurDataSet);

        }

        private void Db_Nomer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kurDataSet.nomer". При необходимости она может быть перемещена или удалена.
            this.nomerTableAdapter.Fill(this.kurDataSet.nomer);

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
           
           
        }
    }
    
}
