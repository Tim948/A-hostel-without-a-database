namespace Kur
{
    partial class Clients
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
            System.Windows.Forms.Label fLabel;
            System.Windows.Forms.Label iLabel;
            System.Windows.Forms.Label oLabel;
            System.Windows.Forms.Label drLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label pasportLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.kurDataSet = new Kur.KurDataSet();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientTableAdapter = new Kur.KurDataSetTableAdapters.klientTableAdapter();
            this.tableAdapterManager = new Kur.KurDataSetTableAdapters.TableAdapterManager();
            this.klientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.klientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fTextBox = new System.Windows.Forms.TextBox();
            this.iTextBox = new System.Windows.Forms.TextBox();
            this.oTextBox = new System.Windows.Forms.TextBox();
            this.drDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.telMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pasportMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            fLabel = new System.Windows.Forms.Label();
            iLabel = new System.Windows.Forms.Label();
            oLabel = new System.Windows.Forms.Label();
            drLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            pasportLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kurDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingNavigator)).BeginInit();
            this.klientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fLabel
            // 
            fLabel.AutoSize = true;
            fLabel.Location = new System.Drawing.Point(12, 69);
            fLabel.Name = "fLabel";
            fLabel.Size = new System.Drawing.Size(69, 16);
            fLabel.TabIndex = 1;
            fLabel.Text = "Фамилия:";
            // 
            // iLabel
            // 
            iLabel.AutoSize = true;
            iLabel.Location = new System.Drawing.Point(12, 97);
            iLabel.Name = "iLabel";
            iLabel.Size = new System.Drawing.Size(36, 16);
            iLabel.TabIndex = 3;
            iLabel.Text = "Имя:";
            // 
            // oLabel
            // 
            oLabel.AutoSize = true;
            oLabel.Location = new System.Drawing.Point(12, 129);
            oLabel.Name = "oLabel";
            oLabel.Size = new System.Drawing.Size(73, 16);
            oLabel.TabIndex = 5;
            oLabel.Text = "Отчество:";
            // 
            // drLabel
            // 
            drLabel.AutoSize = true;
            drLabel.Location = new System.Drawing.Point(12, 161);
            drLabel.Name = "drLabel";
            drLabel.Size = new System.Drawing.Size(109, 16);
            drLabel.TabIndex = 7;
            drLabel.Text = "Дата рождения:";
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new System.Drawing.Point(12, 194);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(138, 16);
            telLabel.TabIndex = 9;
            telLabel.Text = "Мобильный телфон:";
            // 
            // pasportLabel
            // 
            pasportLabel.AutoSize = true;
            pasportLabel.Location = new System.Drawing.Point(12, 227);
            pasportLabel.Name = "pasportLabel";
            pasportLabel.Size = new System.Drawing.Size(143, 16);
            pasportLabel.TabIndex = 11;
            pasportLabel.Text = "Паспортные данные:";
            // 
            // kurDataSet
            // 
            this.kurDataSet.DataSetName = "KurDataSet";
            this.kurDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "klient";
            this.klientBindingSource.DataSource = this.kurDataSet;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.jobTableAdapter = null;
            this.tableAdapterManager.kategoriya_nomerTableAdapter = null;
            this.tableAdapterManager.klientTableAdapter = this.klientTableAdapter;
            this.tableAdapterManager.Kol_dnTableAdapter = null;
            this.tableAdapterManager.nomerTableAdapter = null;
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kur.KurDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // klientBindingNavigator
            // 
            this.klientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.klientBindingNavigator.BindingSource = this.klientBindingSource;
            this.klientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.klientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.klientBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.klientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.klientBindingNavigatorSaveItem});
            this.klientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.klientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.klientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.klientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.klientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.klientBindingNavigator.Name = "klientBindingNavigator";
            this.klientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.klientBindingNavigator.Size = new System.Drawing.Size(979, 31);
            this.klientBindingNavigator.TabIndex = 0;
            this.klientBindingNavigator.Text = "bindingNavigator1";
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
            // klientBindingNavigatorSaveItem
            // 
            this.klientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.klientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("klientBindingNavigatorSaveItem.Image")));
            this.klientBindingNavigatorSaveItem.Name = "klientBindingNavigatorSaveItem";
            this.klientBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.klientBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.klientBindingNavigatorSaveItem.Click += new System.EventHandler(this.klientBindingNavigatorSaveItem_Click);
            // 
            // fTextBox
            // 
            this.fTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "f", true));
            this.fTextBox.Location = new System.Drawing.Point(171, 63);
            this.fTextBox.Name = "fTextBox";
            this.fTextBox.Size = new System.Drawing.Size(200, 22);
            this.fTextBox.TabIndex = 2;
            // 
            // iTextBox
            // 
            this.iTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "i", true));
            this.iTextBox.Location = new System.Drawing.Point(171, 94);
            this.iTextBox.Name = "iTextBox";
            this.iTextBox.Size = new System.Drawing.Size(200, 22);
            this.iTextBox.TabIndex = 4;
            this.iTextBox.TextChanged += new System.EventHandler(this.iTextBox_TextChanged);
            // 
            // oTextBox
            // 
            this.oTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "o", true));
            this.oTextBox.Location = new System.Drawing.Point(171, 126);
            this.oTextBox.Name = "oTextBox";
            this.oTextBox.Size = new System.Drawing.Size(200, 22);
            this.oTextBox.TabIndex = 6;
            // 
            // drDateTimePicker
            // 
            this.drDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.klientBindingSource, "dr", true));
            this.drDateTimePicker.Location = new System.Drawing.Point(171, 161);
            this.drDateTimePicker.Name = "drDateTimePicker";
            this.drDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.drDateTimePicker.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(98, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "Показать список всех клиентов";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(377, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 387);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Фото наших гостей";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(98, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Закрыть добавление клиентов";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // telMaskedTextBox
            // 
            this.telMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "tel", true));
            this.telMaskedTextBox.Location = new System.Drawing.Point(171, 191);
            this.telMaskedTextBox.Mask = "00000000000";
            this.telMaskedTextBox.Name = "telMaskedTextBox";
            this.telMaskedTextBox.Size = new System.Drawing.Size(200, 22);
            this.telMaskedTextBox.TabIndex = 17;
            this.telMaskedTextBox.ValidatingType = typeof(int);
            // 
            // pasportMaskedTextBox
            // 
            this.pasportMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "pasport", true));
            this.pasportMaskedTextBox.Location = new System.Drawing.Point(171, 227);
            this.pasportMaskedTextBox.Mask = "0000-000000";
            this.pasportMaskedTextBox.Name = "pasportMaskedTextBox";
            this.pasportMaskedTextBox.Size = new System.Drawing.Size(200, 22);
            this.pasportMaskedTextBox.TabIndex = 18;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(979, 471);
            this.Controls.Add(this.pasportMaskedTextBox);
            this.Controls.Add(this.telMaskedTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(pasportLabel);
            this.Controls.Add(telLabel);
            this.Controls.Add(drLabel);
            this.Controls.Add(this.drDateTimePicker);
            this.Controls.Add(oLabel);
            this.Controls.Add(this.oTextBox);
            this.Controls.Add(iLabel);
            this.Controls.Add(this.iTextBox);
            this.Controls.Add(fLabel);
            this.Controls.Add(this.fTextBox);
            this.Controls.Add(this.klientBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clients";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kurDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingNavigator)).EndInit();
            this.klientBindingNavigator.ResumeLayout(false);
            this.klientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KurDataSet kurDataSet;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private KurDataSetTableAdapters.klientTableAdapter klientTableAdapter;
        private KurDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator klientBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton klientBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox fTextBox;
        private System.Windows.Forms.TextBox iTextBox;
        private System.Windows.Forms.TextBox oTextBox;
        private System.Windows.Forms.DateTimePicker drDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox telMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox pasportMaskedTextBox;
    }
}