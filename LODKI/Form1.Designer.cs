namespace LODKI
{
    partial class Form1
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
            this.choiceAssort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.choiceObor = new System.Windows.Forms.ComboBox();
            this.choiceColor = new System.Windows.Forms.ComboBox();
            this.choiceSheap = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.orderNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sheapColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oborColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.SuspendLayout();
            // 
            // choiceAssort
            // 
            this.choiceAssort.FormattingEnabled = true;
            this.choiceAssort.Location = new System.Drawing.Point(14, 36);
            this.choiceAssort.Name = "choiceAssort";
            this.choiceAssort.Size = new System.Drawing.Size(135, 24);
            this.choiceAssort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ассортимент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(194, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дерево";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(382, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Цвет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(568, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Доп. оборудование";
            // 
            // choiceObor
            // 
            this.choiceObor.FormattingEnabled = true;
            this.choiceObor.Location = new System.Drawing.Point(571, 36);
            this.choiceObor.Name = "choiceObor";
            this.choiceObor.Size = new System.Drawing.Size(135, 24);
            this.choiceObor.TabIndex = 9;
            // 
            // choiceColor
            // 
            this.choiceColor.FormattingEnabled = true;
            this.choiceColor.Location = new System.Drawing.Point(385, 36);
            this.choiceColor.Name = "choiceColor";
            this.choiceColor.Size = new System.Drawing.Size(135, 24);
            this.choiceColor.TabIndex = 10;
            this.choiceColor.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // choiceSheap
            // 
            this.choiceSheap.FormattingEnabled = true;
            this.choiceSheap.Location = new System.Drawing.Point(197, 36);
            this.choiceSheap.Name = "choiceSheap";
            this.choiceSheap.Size = new System.Drawing.Size(135, 24);
            this.choiceSheap.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(803, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Заказать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableView
            // 
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumColumn,
            this.assortColumn,
            this.treeColumn,
            this.sheapColumn,
            this.colorColumn,
            this.oborColumn});
            this.tableView.Location = new System.Drawing.Point(-4, 225);
            this.tableView.Name = "tableView";
            this.tableView.RowHeadersWidth = 51;
            this.tableView.RowTemplate.Height = 24;
            this.tableView.Size = new System.Drawing.Size(801, 226);
            this.tableView.TabIndex = 14;
            // 
            // orderNumColumn
            // 
            this.orderNumColumn.HeaderText = "Номер";
            this.orderNumColumn.MinimumWidth = 6;
            this.orderNumColumn.Name = "orderNumColumn";
            this.orderNumColumn.Width = 125;
            // 
            // assortColumn
            // 
            this.assortColumn.HeaderText = "Ассортимент";
            this.assortColumn.MinimumWidth = 6;
            this.assortColumn.Name = "assortColumn";
            this.assortColumn.Width = 125;
            // 
            // treeColumn
            // 
            this.treeColumn.HeaderText = "Дерево";
            this.treeColumn.MinimumWidth = 6;
            this.treeColumn.Name = "treeColumn";
            this.treeColumn.Width = 125;
            // 
            // sheapColumn
            // 
            this.sheapColumn.HeaderText = "Лодка";
            this.sheapColumn.MinimumWidth = 6;
            this.sheapColumn.Name = "sheapColumn";
            this.sheapColumn.Width = 125;
            // 
            // colorColumn
            // 
            this.colorColumn.HeaderText = "Цвет";
            this.colorColumn.MinimumWidth = 6;
            this.colorColumn.Name = "colorColumn";
            this.colorColumn.Width = 125;
            // 
            // oborColumn
            // 
            this.oborColumn.HeaderText = "Доп. оборуд";
            this.oborColumn.MinimumWidth = 6;
            this.oborColumn.Name = "oborColumn";
            this.oborColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.tableView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.choiceSheap);
            this.Controls.Add(this.choiceColor);
            this.Controls.Add(this.choiceObor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choiceAssort);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox choiceAssort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox choiceObor;
        private System.Windows.Forms.ComboBox choiceColor;
        private System.Windows.Forms.ComboBox choiceSheap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assortColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sheapColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oborColumn;
    }
}

