namespace Kur
{
    partial class Dobav
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
            System.Windows.Forms.Label id_nLabel;
            System.Windows.Forms.Label id_kLabel;
            System.Windows.Forms.Label dzLabel;
            System.Windows.Forms.Label dvLabel;
            System.Windows.Forms.Label id_pLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dobav));
            this.kurDataSet = new Kur.KurDataSet();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobTableAdapter = new Kur.KurDataSetTableAdapters.jobTableAdapter();
            this.tableAdapterManager = new Kur.KurDataSetTableAdapters.TableAdapterManager();
            this.klientTableAdapter = new Kur.KurDataSetTableAdapters.klientTableAdapter();
            this.nomerTableAdapter = new Kur.KurDataSetTableAdapters.nomerTableAdapter();
            this.personalTableAdapter = new Kur.KurDataSetTableAdapters.personalTableAdapter();
            this.jobBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.jobBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dzDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dvDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_nComboBox = new System.Windows.Forms.ComboBox();
            this.nomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_kComboBox = new System.Windows.Forms.ComboBox();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_pComboBox = new System.Windows.Forms.ComboBox();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            id_nLabel = new System.Windows.Forms.Label();
            id_kLabel = new System.Windows.Forms.Label();
            dzLabel = new System.Windows.Forms.Label();
            dvLabel = new System.Windows.Forms.Label();
            id_pLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kurDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingNavigator)).BeginInit();
            this.jobBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_nLabel
            // 
            id_nLabel.AutoSize = true;
            id_nLabel.Location = new System.Drawing.Point(170, 64);
            id_nLabel.Name = "id_nLabel";
            id_nLabel.Size = new System.Drawing.Size(86, 16);
            id_nLabel.TabIndex = 1;
            id_nLabel.Text = "Код номера:";
            // 
            // id_kLabel
            // 
            id_kLabel.AutoSize = true;
            id_kLabel.Location = new System.Drawing.Point(165, 118);
            id_kLabel.Name = "id_kLabel";
            id_kLabel.Size = new System.Drawing.Size(91, 16);
            id_kLabel.TabIndex = 3;
            id_kLabel.Text = "Код клиента:";
            // 
            // dzLabel
            // 
            dzLabel.AutoSize = true;
            dzLabel.Location = new System.Drawing.Point(163, 162);
            dzLabel.Name = "dzLabel";
            dzLabel.Size = new System.Drawing.Size(93, 16);
            dzLabel.TabIndex = 5;
            dzLabel.Text = "День заезда:";
            // 
            // dvLabel
            // 
            dvLabel.AutoSize = true;
            dvLabel.Location = new System.Drawing.Point(162, 219);
            dvLabel.Name = "dvLabel";
            dvLabel.Size = new System.Drawing.Size(94, 16);
            dvLabel.TabIndex = 7;
            dvLabel.Text = "День выезда:";
            // 
            // id_pLabel
            // 
            id_pLabel.AutoSize = true;
            id_pLabel.Location = new System.Drawing.Point(93, 285);
            id_pLabel.Name = "id_pLabel";
            id_pLabel.Size = new System.Drawing.Size(226, 16);
            id_pLabel.TabIndex = 9;
            id_pLabel.Text = "Код  обслуживающего работника:";
            // 
            // kurDataSet
            // 
            this.kurDataSet.DataSetName = "KurDataSet";
            this.kurDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "job";
            this.jobBindingSource.DataSource = this.kurDataSet;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.jobTableAdapter = this.jobTableAdapter;
            this.tableAdapterManager.kategoriya_nomerTableAdapter = null;
            this.tableAdapterManager.klientTableAdapter = this.klientTableAdapter;
            this.tableAdapterManager.Kol_dnTableAdapter = null;
            this.tableAdapterManager.nomerTableAdapter = this.nomerTableAdapter;
            this.tableAdapterManager.personalTableAdapter = this.personalTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kur.KurDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // nomerTableAdapter
            // 
            this.nomerTableAdapter.ClearBeforeFill = true;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // jobBindingNavigator
            // 
            this.jobBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jobBindingNavigator.BindingSource = this.jobBindingSource;
            this.jobBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jobBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.jobBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.jobBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.jobBindingNavigatorSaveItem});
            this.jobBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jobBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jobBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jobBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jobBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jobBindingNavigator.Name = "jobBindingNavigator";
            this.jobBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jobBindingNavigator.Size = new System.Drawing.Size(431, 31);
            this.jobBindingNavigator.TabIndex = 0;
            this.jobBindingNavigator.Text = "bindingNavigator1";
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
            // jobBindingNavigatorSaveItem
            // 
            this.jobBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jobBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("jobBindingNavigatorSaveItem.Image")));
            this.jobBindingNavigatorSaveItem.Name = "jobBindingNavigatorSaveItem";
            this.jobBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.jobBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.jobBindingNavigatorSaveItem.Click += new System.EventHandler(this.jobBindingNavigatorSaveItem_Click);
            // 
            // dzDateTimePicker
            // 
            this.dzDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jobBindingSource, "dz", true));
            this.dzDateTimePicker.Location = new System.Drawing.Point(104, 194);
            this.dzDateTimePicker.Name = "dzDateTimePicker";
            this.dzDateTimePicker.Size = new System.Drawing.Size(212, 22);
            this.dzDateTimePicker.TabIndex = 6;
            // 
            // dvDateTimePicker
            // 
            this.dvDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jobBindingSource, "dv", true));
            this.dvDateTimePicker.Location = new System.Drawing.Point(104, 250);
            this.dvDateTimePicker.Name = "dvDateTimePicker";
            this.dvDateTimePicker.Size = new System.Drawing.Size(212, 22);
            this.dvDateTimePicker.TabIndex = 8;
            // 
            // id_nComboBox
            // 
            this.id_nComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "id_n", true));
            this.id_nComboBox.DataSource = this.nomerBindingSource;
            this.id_nComboBox.DisplayMember = "id_n";
            this.id_nComboBox.FormattingEnabled = true;
            this.id_nComboBox.Location = new System.Drawing.Point(104, 91);
            this.id_nComboBox.Name = "id_nComboBox";
            this.id_nComboBox.Size = new System.Drawing.Size(212, 24);
            this.id_nComboBox.TabIndex = 15;
            // 
            // nomerBindingSource
            // 
            this.nomerBindingSource.DataMember = "nomer";
            this.nomerBindingSource.DataSource = this.kurDataSet;
            // 
            // id_kComboBox
            // 
            this.id_kComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "id_k", true));
            this.id_kComboBox.DataSource = this.klientBindingSource;
            this.id_kComboBox.DisplayMember = "id_k";
            this.id_kComboBox.FormattingEnabled = true;
            this.id_kComboBox.Location = new System.Drawing.Point(104, 137);
            this.id_kComboBox.Name = "id_kComboBox";
            this.id_kComboBox.Size = new System.Drawing.Size(212, 24);
            this.id_kComboBox.TabIndex = 16;
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "klient";
            this.klientBindingSource.DataSource = this.kurDataSet;
            // 
            // id_pComboBox
            // 
            this.id_pComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "id_p", true));
            this.id_pComboBox.DataSource = this.personalBindingSource;
            this.id_pComboBox.DisplayMember = "id_p";
            this.id_pComboBox.FormattingEnabled = true;
            this.id_pComboBox.Location = new System.Drawing.Point(104, 319);
            this.id_pComboBox.Name = "id_pComboBox";
            this.id_pComboBox.Size = new System.Drawing.Size(212, 24);
            this.id_pComboBox.TabIndex = 17;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "personal";
            this.personalBindingSource.DataSource = this.kurDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(130, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Вернуться к списку";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dobav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id_pComboBox);
            this.Controls.Add(this.id_kComboBox);
            this.Controls.Add(this.id_nComboBox);
            this.Controls.Add(id_pLabel);
            this.Controls.Add(dvLabel);
            this.Controls.Add(this.dvDateTimePicker);
            this.Controls.Add(dzLabel);
            this.Controls.Add(this.dzDateTimePicker);
            this.Controls.Add(id_kLabel);
            this.Controls.Add(id_nLabel);
            this.Controls.Add(this.jobBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dobav";
            this.Text = "Даты вьезда и выезда";
            this.Load += new System.EventHandler(this.Dobav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kurDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingNavigator)).EndInit();
            this.jobBindingNavigator.ResumeLayout(false);
            this.jobBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KurDataSet kurDataSet;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private KurDataSetTableAdapters.jobTableAdapter jobTableAdapter;
        private KurDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator jobBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton jobBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker dzDateTimePicker;
        private System.Windows.Forms.DateTimePicker dvDateTimePicker;
        private System.Windows.Forms.ComboBox id_nComboBox;
        private KurDataSetTableAdapters.nomerTableAdapter nomerTableAdapter;
        private System.Windows.Forms.BindingSource nomerBindingSource;
        private KurDataSetTableAdapters.klientTableAdapter klientTableAdapter;
        private System.Windows.Forms.ComboBox id_kComboBox;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private KurDataSetTableAdapters.personalTableAdapter personalTableAdapter;
        private System.Windows.Forms.ComboBox id_pComboBox;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private System.Windows.Forms.Button button1;
    }
}