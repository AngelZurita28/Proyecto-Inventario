﻿namespace PROYECTO_INVENTARIO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvBoard = new DataGridView();
            label15 = new Label();
            txtCodeStock = new TextBox();
            label14 = new Label();
            btnStreamReader = new Button();
            rtxtboxmost = new RichTextBox();
            label13 = new Label();
            textBox1 = new TextBox();
            label12 = new Label();
            txtexit = new TextBox();
            btnSave2 = new Button();
            label11 = new Label();
            label = new Label();
            btnmost = new Button();
            txttotal2 = new TextBox();
            txttotal1 = new TextBox();
            label10 = new Label();
            label7 = new Label();
            txtentries = new TextBox();
            label9 = new Label();
            btnDelete = new Button();
            txtsale_price = new TextBox();
            label8 = new Label();
            txtcode = new TextBox();
            txtamount = new TextBox();
            txtname = new TextBox();
            txtpurchase_price = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            btnSave1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Code = new DataGridViewTextBoxColumn();
            Date_Entry = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Purchase_Price = new DataGridViewTextBoxColumn();
            Sale_Price = new DataGridViewTextBoxColumn();
            Exit = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBoard).BeginInit();
            SuspendLayout();
            // 
            // dgvBoard
            // 
            dgvBoard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoard.Columns.AddRange(new DataGridViewColumn[] { Code, Date_Entry, NameColumn, Amount, Purchase_Price, Sale_Price, Exit, Stock });
            dgvBoard.Location = new Point(20, 228);
            dgvBoard.Name = "dgvBoard";
            dgvBoard.RowTemplate.Height = 25;
            dgvBoard.Size = new Size(829, 300);
            dgvBoard.TabIndex = 110;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(676, 136);
            label15.Name = "label15";
            label15.Size = new Size(52, 15);
            label15.TabIndex = 109;
            label15.Text = "CODIGO";
            // 
            // txtCodeStock
            // 
            txtCodeStock.Location = new Point(737, 137);
            txtCodeStock.Margin = new Padding(3, 2, 3, 2);
            txtCodeStock.Name = "txtCodeStock";
            txtCodeStock.Size = new Size(112, 23);
            txtCodeStock.TabIndex = 108;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(862, 235);
            label14.Name = "label14";
            label14.Size = new Size(258, 25);
            label14.TabIndex = 107;
            label14.Text = "PRODUCTOS REGISTRADOS";
            // 
            // btnStreamReader
            // 
            btnStreamReader.Location = new Point(1171, 240);
            btnStreamReader.Margin = new Padding(3, 2, 3, 2);
            btnStreamReader.Name = "btnStreamReader";
            btnStreamReader.Size = new Size(82, 22);
            btnStreamReader.TabIndex = 106;
            btnStreamReader.Text = "MOSTRAR";
            btnStreamReader.UseVisualStyleBackColor = true;
            btnStreamReader.Click += btnStreamReader_Click;
            // 
            // rtxtboxmost
            // 
            rtxtboxmost.Location = new Point(862, 266);
            rtxtboxmost.Margin = new Padding(3, 2, 3, 2);
            rtxtboxmost.Name = "rtxtboxmost";
            rtxtboxmost.Size = new Size(392, 242);
            rtxtboxmost.TabIndex = 105;
            rtxtboxmost.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(673, 165);
            label13.Name = "label13";
            label13.Size = new Size(55, 15);
            label13.TabIndex = 104;
            label13.Text = "SALIDAS:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(886, 64);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 103;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(772, 65);
            label12.Name = "label12";
            label12.Size = new Size(97, 15);
            label12.TabIndex = 102;
            label12.Text = "TOTAL DE STOCK:";
            // 
            // txtexit
            // 
            txtexit.Location = new Point(737, 163);
            txtexit.Margin = new Padding(3, 2, 3, 2);
            txtexit.Name = "txtexit";
            txtexit.Size = new Size(112, 23);
            txtexit.TabIndex = 101;
            // 
            // btnSave2
            // 
            btnSave2.Location = new Point(738, 198);
            btnSave2.Margin = new Padding(3, 2, 3, 2);
            btnSave2.Name = "btnSave2";
            btnSave2.Size = new Size(111, 22);
            btnSave2.TabIndex = 100;
            btnSave2.Text = "MOSTRAR STOCK";
            btnSave2.UseVisualStyleBackColor = true;
            btnSave2.Click += btnSave2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveBorder;
            label11.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(21, 11);
            label11.Name = "label11";
            label11.Size = new Size(197, 16);
            label11.TabIndex = 99;
            label11.Text = "REGISTRO DE PRODUCTOS";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = SystemColors.ButtonShadow;
            label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(683, 30);
            label.Name = "label";
            label.Size = new Size(89, 25);
            label.TabIndex = 98;
            label.Text = "TOTALES";
            // 
            // btnmost
            // 
            btnmost.Location = new Point(1077, 93);
            btnmost.Margin = new Padding(3, 2, 3, 2);
            btnmost.Name = "btnmost";
            btnmost.Size = new Size(82, 22);
            btnmost.TabIndex = 97;
            btnmost.Text = "MOSTRAR";
            btnmost.UseVisualStyleBackColor = true;
            btnmost.Click += btnmost_Click;
            // 
            // txttotal2
            // 
            txttotal2.Location = new Point(1077, 58);
            txttotal2.Margin = new Padding(3, 2, 3, 2);
            txttotal2.Name = "txttotal2";
            txttotal2.Size = new Size(137, 23);
            txttotal2.TabIndex = 96;
            // 
            // txttotal1
            // 
            txttotal1.Location = new Point(1077, 28);
            txttotal1.Margin = new Padding(3, 2, 3, 2);
            txttotal1.Name = "txttotal1";
            txttotal1.Size = new Size(137, 23);
            txttotal1.TabIndex = 95;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1016, 64);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 94;
            label10.Text = "VENTAS:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1001, 33);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 93;
            label7.Text = "COMPRAS:";
            // 
            // txtentries
            // 
            txtentries.Location = new Point(862, 31);
            txtentries.Margin = new Padding(3, 2, 3, 2);
            txtentries.Name = "txtentries";
            txtentries.Size = new Size(134, 23);
            txtentries.TabIndex = 92;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(781, 35);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 91;
            label9.Text = "ENTRADAS:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(594, 78);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 90;
            btnDelete.Text = "ELIMINAR";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtsale_price
            // 
            txtsale_price.Location = new Point(471, 90);
            txtsale_price.Name = "txtsale_price";
            txtsale_price.Size = new Size(100, 23);
            txtsale_price.TabIndex = 89;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(350, 66);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 88;
            label8.Text = "PRECIO DE COMPRA:";
            // 
            // txtcode
            // 
            txtcode.Location = new Point(159, 66);
            txtcode.Name = "txtcode";
            txtcode.Size = new Size(161, 23);
            txtcode.TabIndex = 87;
            // 
            // txtamount
            // 
            txtamount.Location = new Point(471, 35);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(100, 23);
            txtamount.TabIndex = 86;
            // 
            // txtname
            // 
            txtname.Location = new Point(159, 90);
            txtname.Name = "txtname";
            txtname.Size = new Size(161, 23);
            txtname.TabIndex = 85;
            // 
            // txtpurchase_price
            // 
            txtpurchase_price.Location = new Point(471, 61);
            txtpurchase_price.Name = "txtpurchase_price";
            txtpurchase_price.Size = new Size(100, 23);
            txtpurchase_price.TabIndex = 84;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(159, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(161, 23);
            dateTimePicker1.TabIndex = 83;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveBorder;
            label6.Font = new Font("Corbel", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 172);
            label6.Name = "label6";
            label6.Size = new Size(463, 42);
            label6.TabIndex = 82;
            label6.Text = "INVENTARIO DE PRODUCTOS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 48);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 81;
            label5.Text = "FECHA DE ENTRADA:";
            // 
            // btnSave1
            // 
            btnSave1.Location = new Point(594, 36);
            btnSave1.Name = "btnSave1";
            btnSave1.Size = new Size(75, 23);
            btnSave1.TabIndex = 80;
            btnSave1.Text = "AGREGAR";
            btnSave1.UseVisualStyleBackColor = true;
            btnSave1.Click += btnSave1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 90);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 79;
            label4.Text = "PRECIO DE VENTA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 42);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 78;
            label3.Text = "ENTRADAS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 71);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 77;
            label2.Text = "CÓDIGO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 93);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 76;
            label1.Text = "DESCRIPCION:";
            // 
            // Code
            // 
            Code.HeaderText = "Code";
            Code.Name = "Code";
            // 
            // Date_Entry
            // 
            Date_Entry.HeaderText = "Date_Entry";
            Date_Entry.Name = "Date_Entry";
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.Name = "NameColumn";
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            // 
            // Purchase_Price
            // 
            Purchase_Price.HeaderText = "Purchase_Price";
            Purchase_Price.Name = "Purchase_Price";
            // 
            // Sale_Price
            // 
            Sale_Price.HeaderText = "Sale_Price";
            Sale_Price.Name = "Sale_Price";
            // 
            // Exit
            // 
            Exit.HeaderText = "Exit";
            Exit.Name = "Exit";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1282, 536);
            Controls.Add(dgvBoard);
            Controls.Add(label15);
            Controls.Add(txtCodeStock);
            Controls.Add(label14);
            Controls.Add(btnStreamReader);
            Controls.Add(rtxtboxmost);
            Controls.Add(label13);
            Controls.Add(textBox1);
            Controls.Add(label12);
            Controls.Add(txtexit);
            Controls.Add(btnSave2);
            Controls.Add(label11);
            Controls.Add(label);
            Controls.Add(btnmost);
            Controls.Add(txttotal2);
            Controls.Add(txttotal1);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(txtentries);
            Controls.Add(label9);
            Controls.Add(btnDelete);
            Controls.Add(txtsale_price);
            Controls.Add(label8);
            Controls.Add(txtcode);
            Controls.Add(txtamount);
            Controls.Add(txtname);
            Controls.Add(txtpurchase_price);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnSave1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvBoard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSave2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dgvBoard;
        private Label label15;
        private TextBox txtCodeStock;
        private Label label14;
        private Button btnStreamReader;
        private RichTextBox rtxtboxmost;
        private Label label13;
        private TextBox textBox1;
        private Label label12;
        private TextBox txtexit;
        private Button btnSave2;
        private Label label11;
        private Label label;
        private Button btnmost;
        private TextBox txttotal2;
        private TextBox txttotal1;
        private Label label10;
        private Label label7;
        private TextBox txtentries;
        private Label label9;
        private Button btnDelete;
        private TextBox txtsale_price;
        private Label label8;
        private TextBox txtcode;
        private TextBox txtamount;
        private TextBox txtname;
        private TextBox txtpurchase_price;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label5;
        private Button btnSave1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Date_Entry;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Purchase_Price;
        private DataGridViewTextBoxColumn Sale_Price;
        private DataGridViewTextBoxColumn Exit;
        private DataGridViewTextBoxColumn Stock;
    }
}