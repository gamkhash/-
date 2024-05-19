namespace Аптека
{
    partial class Form4
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
            this.buyersTableAdapter1 = new Аптека.АптекаDataSet5TableAdapters.BuyersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.аптекаDataSet8 = new Аптека.АптекаDataSet8();
            this.buyersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyersTableAdapter = new Аптека.АптекаDataSet8TableAdapters.BuyersTableAdapter();
            this.idBuyersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofpurhaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idofthedrugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Add_ID = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Delete_ID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buyersTableAdapter1
            // 
            this.buyersTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBuyersDataGridViewTextBoxColumn,
            this.buyersDataGridViewTextBoxColumn,
            this.dateofpurhaseDataGridViewTextBoxColumn,
            this.idofthedrugDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.buyersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // аптекаDataSet8
            // 
            this.аптекаDataSet8.DataSetName = "АптекаDataSet8";
            this.аптекаDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buyersBindingSource
            // 
            this.buyersBindingSource.DataMember = "Buyers";
            this.buyersBindingSource.DataSource = this.аптекаDataSet8;
            // 
            // buyersTableAdapter
            // 
            this.buyersTableAdapter.ClearBeforeFill = true;
            // 
            // idBuyersDataGridViewTextBoxColumn
            // 
            this.idBuyersDataGridViewTextBoxColumn.DataPropertyName = "id_Buyers";
            this.idBuyersDataGridViewTextBoxColumn.HeaderText = "id_Buyers";
            this.idBuyersDataGridViewTextBoxColumn.Name = "idBuyersDataGridViewTextBoxColumn";
            this.idBuyersDataGridViewTextBoxColumn.Width = 155;
            // 
            // buyersDataGridViewTextBoxColumn
            // 
            this.buyersDataGridViewTextBoxColumn.DataPropertyName = "Buyers";
            this.buyersDataGridViewTextBoxColumn.HeaderText = "Buyers";
            this.buyersDataGridViewTextBoxColumn.Name = "buyersDataGridViewTextBoxColumn";
            this.buyersDataGridViewTextBoxColumn.Width = 155;
            // 
            // dateofpurhaseDataGridViewTextBoxColumn
            // 
            this.dateofpurhaseDataGridViewTextBoxColumn.DataPropertyName = "Date_of_purhase";
            this.dateofpurhaseDataGridViewTextBoxColumn.HeaderText = "Date_of_purhase";
            this.dateofpurhaseDataGridViewTextBoxColumn.Name = "dateofpurhaseDataGridViewTextBoxColumn";
            this.dateofpurhaseDataGridViewTextBoxColumn.Width = 155;
            // 
            // idofthedrugDataGridViewTextBoxColumn
            // 
            this.idofthedrugDataGridViewTextBoxColumn.DataPropertyName = "id_of_the_drug";
            this.idofthedrugDataGridViewTextBoxColumn.HeaderText = "id_of_the_drug";
            this.idofthedrugDataGridViewTextBoxColumn.Name = "idofthedrugDataGridViewTextBoxColumn";
            this.idofthedrugDataGridViewTextBoxColumn.Width = 155;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(439, 347);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 33;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(200, 373);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 32;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(200, 293);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(51, 370);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 29;
            // 
            // button_Add_ID
            // 
            this.button_Add_ID.Location = new System.Drawing.Point(437, 373);
            this.button_Add_ID.Name = "button_Add_ID";
            this.button_Add_ID.Size = new System.Drawing.Size(102, 23);
            this.button_Add_ID.TabIndex = 28;
            this.button_Add_ID.Text = "Изменить по ID";
            this.button_Add_ID.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(353, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Цена препарата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Купленный препарат";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Дата покупки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ФИО Покупателя";
            // 
            // button_Delete_ID
            // 
            this.button_Delete_ID.Location = new System.Drawing.Point(557, 373);
            this.button_Delete_ID.Name = "button_Delete_ID";
            this.button_Delete_ID.Size = new System.Drawing.Size(92, 23);
            this.button_Delete_ID.TabIndex = 21;
            this.button_Delete_ID.Text = "Удалить по ID";
            this.button_Delete_ID.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 407);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Add_ID);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Delete_ID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекаDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private АптекаDataSet5TableAdapters.BuyersTableAdapter buyersTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private АптекаDataSet8 аптекаDataSet8;
        private System.Windows.Forms.BindingSource buyersBindingSource;
        private АптекаDataSet8TableAdapters.BuyersTableAdapter buyersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBuyersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofpurhaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idofthedrugDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Add_ID;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Delete_ID;
    }
}