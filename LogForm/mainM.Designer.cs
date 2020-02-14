namespace LogForm
{
    partial class mainM
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.учет_кадровDataSet = new LogForm.Учет_кадровDataSet();
            this.персоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.персоналTableAdapter = new LogForm.Учет_кадровDataSetTableAdapters.персоналTableAdapter();
            this.персональныйномерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фиоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.деньрожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.семейноеПоложениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.удостоверениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сНИЛСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серияПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учет_кадровDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.персональныйномерDataGridViewTextBoxColumn,
            this.фиоDataGridViewTextBoxColumn,
            this.деньрожденияDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.семейноеПоложениеDataGridViewTextBoxColumn,
            this.удостоверениеDataGridViewTextBoxColumn,
            this.сНИЛСDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn,
            this.серияПаспортаDataGridViewTextBoxColumn,
            this.номерПаспортаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.персоналBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // учет_кадровDataSet
            // 
            this.учет_кадровDataSet.DataSetName = "Учет_кадровDataSet";
            this.учет_кадровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // персоналBindingSource
            // 
            this.персоналBindingSource.DataMember = "персонал";
            this.персоналBindingSource.DataSource = this.учет_кадровDataSet;
            // 
            // персоналTableAdapter
            // 
            this.персоналTableAdapter.ClearBeforeFill = true;
            // 
            // персональныйномерDataGridViewTextBoxColumn
            // 
            this.персональныйномерDataGridViewTextBoxColumn.DataPropertyName = "персональный_номер";
            this.персональныйномерDataGridViewTextBoxColumn.HeaderText = "персональный_номер";
            this.персональныйномерDataGridViewTextBoxColumn.Name = "персональныйномерDataGridViewTextBoxColumn";
            this.персональныйномерDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фиоDataGridViewTextBoxColumn
            // 
            this.фиоDataGridViewTextBoxColumn.DataPropertyName = "фио";
            this.фиоDataGridViewTextBoxColumn.HeaderText = "фио";
            this.фиоDataGridViewTextBoxColumn.Name = "фиоDataGridViewTextBoxColumn";
            // 
            // деньрожденияDataGridViewTextBoxColumn
            // 
            this.деньрожденияDataGridViewTextBoxColumn.DataPropertyName = "день_рождения";
            this.деньрожденияDataGridViewTextBoxColumn.HeaderText = "день_рождения";
            this.деньрожденияDataGridViewTextBoxColumn.Name = "деньрожденияDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // семейноеПоложениеDataGridViewTextBoxColumn
            // 
            this.семейноеПоложениеDataGridViewTextBoxColumn.DataPropertyName = "семейное положение";
            this.семейноеПоложениеDataGridViewTextBoxColumn.HeaderText = "семейное положение";
            this.семейноеПоложениеDataGridViewTextBoxColumn.Name = "семейноеПоложениеDataGridViewTextBoxColumn";
            // 
            // удостоверениеDataGridViewTextBoxColumn
            // 
            this.удостоверениеDataGridViewTextBoxColumn.DataPropertyName = "удостоверение";
            this.удостоверениеDataGridViewTextBoxColumn.HeaderText = "удостоверение";
            this.удостоверениеDataGridViewTextBoxColumn.Name = "удостоверениеDataGridViewTextBoxColumn";
            // 
            // сНИЛСDataGridViewTextBoxColumn
            // 
            this.сНИЛСDataGridViewTextBoxColumn.DataPropertyName = "СНИЛС";
            this.сНИЛСDataGridViewTextBoxColumn.HeaderText = "СНИЛС";
            this.сНИЛСDataGridViewTextBoxColumn.Name = "сНИЛСDataGridViewTextBoxColumn";
            // 
            // иННDataGridViewTextBoxColumn
            // 
            this.иННDataGridViewTextBoxColumn.DataPropertyName = "ИНН";
            this.иННDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.иННDataGridViewTextBoxColumn.Name = "иННDataGridViewTextBoxColumn";
            // 
            // серияПаспортаDataGridViewTextBoxColumn
            // 
            this.серияПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Серия паспорта";
            this.серияПаспортаDataGridViewTextBoxColumn.HeaderText = "Серия паспорта";
            this.серияПаспортаDataGridViewTextBoxColumn.Name = "серияПаспортаDataGridViewTextBoxColumn";
            // 
            // номерПаспортаDataGridViewTextBoxColumn
            // 
            this.номерПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Номер паспорта";
            this.номерПаспортаDataGridViewTextBoxColumn.HeaderText = "Номер паспорта";
            this.номерПаспортаDataGridViewTextBoxColumn.Name = "номерПаспортаDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(457, 276);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 20);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(198, 276);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // mainM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "mainM";
            this.Text = "mainM";
            this.Load += new System.EventHandler(this.mainM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учет_кадровDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Учет_кадровDataSet учет_кадровDataSet;
        private System.Windows.Forms.BindingSource персоналBindingSource;
        private Учет_кадровDataSetTableAdapters.персоналTableAdapter персоналTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn персональныйномерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фиоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn деньрожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn семейноеПоложениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn удостоверениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сНИЛСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серияПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}