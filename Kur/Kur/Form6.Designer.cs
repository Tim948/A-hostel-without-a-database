namespace Kur
{
    partial class Db_Nomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_katLabel;
            System.Windows.Forms.Label kmLabel;
            System.Windows.Forms.Label ccLabel;
            System.Windows.Forms.Label id_katLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Db_Nomer));
            this.kurDataSet = new Kur.KurDataSet();
            this.nomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomerTableAdapter = new Kur.KurDataSetTableAdapters.nomerTableAdapter();
            this.tableAdapterManager = new Kur.KurDataSetTableAdapters.TableAdapterManager();
            this.nomerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nomerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ccTextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kmTextBox = new System.Windows.Forms.TextBox();
            this.id_katMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            id_katLabel = new System.Windows.Forms.Label();
            kmLabel = new System.Windows.Forms.Label();
            ccLabel = new System.Windows.Forms.Label();
            id_katLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kurDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomerBindingNavigator)).BeginInit();
            this.nomerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_katLabel
            // 
            id_katLabel.AutoSize = true;
            id_katLabel.Location = new System.Drawing.Point(125, 48);
            id_katLabel.Name = "id_katLabel";
            id_katLabel.Size = new System.Drawing.Size(105, 16);
            id_katLabel.TabIndex = 15;
            id_katLabel.Text = "Код категории:";
            // 
            // kmLabel
            // 
            kmLabel.AutoSize = true;
            kmLabel.Location = new System.Drawing.Point(71, 198);
            kmLabel.Name = "kmLabel";
            kmLabel.Size = new System.Drawing.Size(213, 16);
            kmLabel.TabIndex = 14;
            kmLabel.Text = "Колличество мест проживания:";
            // 
            // ccLabel
            // 
            ccLabel.AutoSize = true;
            ccLabel.Location = new System.Drawing.Point(115, 124);
            ccLabel.Name = "ccLabel";
            ccLabel.Size = new System.Drawing.Size(131, 16);
            ccLabel.TabIndex = 12;
            ccLabel.Text = "Стоимость в сутки:";
            // 
            // id_katLabel1
            // 
            id_katLabel1.AutoSize = true;
            id_katLabel1.Location = new System.Drawing.Point(115, 290);
            id_katLabel1.Name = "id_katLabel1";
            id_katLabel1.Size = new System.Drawing.Size(0, 16);
            id_katLabel1.TabIndex = 18;
            // 
            // kurDataSet
            // 
            this.kurDataSet.DataSetName = "KurDataSet";
            this.kurDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nomerBindingSource
            // 
            this.nomerBindingSource.DataMember = "nomer";
            this.nomerBindingSource.DataSource = this.kurDataSet;
            // 
            // nomerTableAdapter
            // 
            this.nomerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.jobTableAdapter = null;
            this.tableAdapterManager.kategoriya_nomerTableAdapter = null;
            this.tableAdapterManager.klientTableAdapter = null;
            this.tableAdapterManager.Kol_dnTableAdapter = null;
            this.tableAdapterManager.nomerTableAdapter = this.nomerTableAdapter;
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kur.KurDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nomerBindingNavigator
            // 
            this.nomerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nomerBindingNavigator.BindingSource = this.nomerBindingSource;
            this.nomerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nomerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nomerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.nomerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.nomerBindingNavigatorSaveItem});
            this.nomerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nomerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nomerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nomerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nomerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nomerBindingNavigator.Name = "nomerBindingNavigator";
            this.nomerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nomerBindingNavigator.Size = new System.Drawing.Size(372, 31);
            this.nomerBindingNavigator.TabIndex = 18;
            this.nomerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // nomerBindingNavigatorSaveItem
            // 
            this.nomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nomerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nomerBindingNavigatorSaveItem.Image")));
            this.nomerBindingNavigatorSaveItem.Name = "nomerBindingNavigatorSaveItem";
            this.nomerBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.nomerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.nomerBindingNavigatorSaveItem.Click += new System.EventHandler(this.nomerBindingNavigatorSaveItem_Click);
            // 
            // ccTextBox1
            // 
            this.ccTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nomerBindingSource, "cc", true));
            this.ccTextBox1.Location = new System.Drawing.Point(96, 152);
            this.ccTextBox1.Name = "ccTextBox1";
            this.ccTextBox1.Size = new System.Drawing.Size(162, 22);
            this.ccTextBox1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 27);
            this.button1.TabIndex = 22;
            this.button1.Text = "Вернуться к списку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(137, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Статус номера";
            // 
            // kmTextBox
            // 
            this.kmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nomerBindingSource, "km", true));
            this.kmTextBox.Location = new System.Drawing.Point(96, 229);
            this.kmTextBox.Name = "kmTextBox";
            this.kmTextBox.Size = new System.Drawing.Size(162, 22);
            this.kmTextBox.TabIndex = 24;
            // 
            // id_katMaskedTextBox
            // 
            this.id_katMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nomerBindingSource, "id_kat", true));
            this.id_katMaskedTextBox.Location = new System.Drawing.Point(96, 99);
            this.id_katMaskedTextBox.Mask = "0";
            this.id_katMaskedTextBox.Name = "id_katMaskedTextBox";
            this.id_katMaskedTextBox.Size = new System.Drawing.Size(162, 22);
            this.id_katMaskedTextBox.TabIndex = 25;
            // 
            // Db_Nomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(372, 349);
            this.Controls.Add(this.id_katMaskedTextBox);
            this.Controls.Add(this.kmTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ccTextBox1);
            this.Controls.Add(id_katLabel1);
            this.Controls.Add(this.nomerBindingNavigator);
            this.Controls.Add(id_katLabel);
            this.Controls.Add(kmLabel);
            this.Controls.Add(ccLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Db_Nomer";
            this.Text = "Номера";
            this.Load += new System.EventHandler(this.Db_Nomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kurDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomerBindingNavigator)).EndInit();
            this.nomerBindingNavigator.ResumeLayout(false);
            this.nomerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private KurDataSet kurDataSet;
        private System.Windows.Forms.BindingSource nomerBindingSource;
        private KurDataSetTableAdapters.nomerTableAdapter nomerTableAdapter;
        private KurDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nomerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton nomerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ccTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kmTextBox;
        private System.Windows.Forms.MaskedTextBox id_katMaskedTextBox;
    }
}