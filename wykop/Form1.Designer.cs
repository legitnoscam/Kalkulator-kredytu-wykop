namespace wykop
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
            this.components = new System.ComponentModel.Container();
            this.textbox_Month = new System.Windows.Forms.ComboBox();
            this.monthCalendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.textBox_margin = new System.Windows.Forms.TextBox();
            this.textBox_wibor = new System.Windows.Forms.TextBox();
            this.textBox_installment = new System.Windows.Forms.TextBox();
            this.textBox_overpayment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_Output = new System.Windows.Forms.DataGridView();
            this.checkBox_wibor = new System.Windows.Forms.CheckBox();
            this.checkBox_overpayment = new System.Windows.Forms.CheckBox();
            this.dataGridView_Wibor = new System.Windows.Forms.DataGridView();
            this.Column_wibor_month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_wibor_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_Overpayment = new System.Windows.Forms.DataGridView();
            this.Column_overpayment_month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_overpayment_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.monthCalendarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Wibor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Overpayment)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_Month
            // 
            this.textbox_Month.FormattingEnabled = true;
            this.textbox_Month.Location = new System.Drawing.Point(12, 44);
            this.textbox_Month.Name = "textbox_Month";
            this.textbox_Month.Size = new System.Drawing.Size(121, 23);
            this.textbox_Month.TabIndex = 0;
            // 
            // monthCalendarBindingSource
            // 
            this.monthCalendarBindingSource.DataSource = typeof(System.Windows.Forms.MonthCalendar);
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(12, 105);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(121, 23);
            this.textBox_Amount.TabIndex = 1;
            this.textBox_Amount.Text = "1000,0";
            // 
            // textBox_margin
            // 
            this.textBox_margin.Location = new System.Drawing.Point(12, 160);
            this.textBox_margin.Name = "textBox_margin";
            this.textBox_margin.Size = new System.Drawing.Size(121, 23);
            this.textBox_margin.TabIndex = 2;
            this.textBox_margin.Text = "2,0";
            // 
            // textBox_wibor
            // 
            this.textBox_wibor.Location = new System.Drawing.Point(12, 219);
            this.textBox_wibor.Name = "textBox_wibor";
            this.textBox_wibor.Size = new System.Drawing.Size(121, 23);
            this.textBox_wibor.TabIndex = 3;
            this.textBox_wibor.Text = "2,0";
            // 
            // textBox_installment
            // 
            this.textBox_installment.Location = new System.Drawing.Point(12, 281);
            this.textBox_installment.Name = "textBox_installment";
            this.textBox_installment.Size = new System.Drawing.Size(121, 23);
            this.textBox_installment.TabIndex = 4;
            this.textBox_installment.Text = "100,0";
            // 
            // textBox_overpayment
            // 
            this.textBox_overpayment.Location = new System.Drawing.Point(12, 345);
            this.textBox_overpayment.Name = "textBox_overpayment";
            this.textBox_overpayment.Size = new System.Drawing.Size(121, 23);
            this.textBox_overpayment.TabIndex = 5;
            this.textBox_overpayment.Text = "0,0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aktualny miesiac";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kapitał do spłaty [zł]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "marża banku [%]";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "WIBOR [%]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "część kapitałowa raty [zł]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "comiesięczna nadpłata kapitału stałą kwotą [zł]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Oblicz!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_Output
            // 
            this.dataGridView_Output.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView_Output.Location = new System.Drawing.Point(670, 3);
            this.dataGridView_Output.Name = "dataGridView_Output";
            this.dataGridView_Output.RowTemplate.Height = 25;
            this.dataGridView_Output.Size = new System.Drawing.Size(446, 600);
            this.dataGridView_Output.TabIndex = 13;
            this.dataGridView_Output.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Output_CellContentClick);
            // 
            // checkBox_wibor
            // 
            this.checkBox_wibor.AutoSize = true;
            this.checkBox_wibor.Location = new System.Drawing.Point(12, 390);
            this.checkBox_wibor.Name = "checkBox_wibor";
            this.checkBox_wibor.Size = new System.Drawing.Size(111, 19);
            this.checkBox_wibor.TabIndex = 14;
            this.checkBox_wibor.Text = "Zmienny wibor?";
            this.checkBox_wibor.UseVisualStyleBackColor = true;
            this.checkBox_wibor.CheckedChanged += new System.EventHandler(this.checkBox_wibor_CheckedChanged);
            // 
            // checkBox_overpayment
            // 
            this.checkBox_overpayment.AutoSize = true;
            this.checkBox_overpayment.Location = new System.Drawing.Point(12, 415);
            this.checkBox_overpayment.Name = "checkBox_overpayment";
            this.checkBox_overpayment.Size = new System.Drawing.Size(156, 19);
            this.checkBox_overpayment.TabIndex = 15;
            this.checkBox_overpayment.Text = "Zmienna kwota nadpłat?";
            this.checkBox_overpayment.UseVisualStyleBackColor = true;
            this.checkBox_overpayment.CheckedChanged += new System.EventHandler(this.checkBox_overpayment_CheckedChanged);
            // 
            // dataGridView_Wibor
            // 
            this.dataGridView_Wibor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_wibor_month,
            this.Column_wibor_value});
            this.dataGridView_Wibor.Location = new System.Drawing.Point(271, 3);
            this.dataGridView_Wibor.Name = "dataGridView_Wibor";
            this.dataGridView_Wibor.RowTemplate.Height = 25;
            this.dataGridView_Wibor.Size = new System.Drawing.Size(193, 542);
            this.dataGridView_Wibor.TabIndex = 16;
            this.dataGridView_Wibor.Visible = false;
            // 
            // Column_wibor_month
            // 
            this.Column_wibor_month.HeaderText = "Miesiac";
            this.Column_wibor_month.Name = "Column_wibor_month";
            this.Column_wibor_month.Width = 50;
            // 
            // Column_wibor_value
            // 
            this.Column_wibor_value.HeaderText = "Wartość WIBOR [%]";
            this.Column_wibor_value.Name = "Column_wibor_value";
            // 
            // dataGridView_Overpayment
            // 
            this.dataGridView_Overpayment.ColumnHeadersHeight = 20;
            this.dataGridView_Overpayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Overpayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_overpayment_month,
            this.Column_overpayment_amount});
            this.dataGridView_Overpayment.Location = new System.Drawing.Point(470, 3);
            this.dataGridView_Overpayment.Name = "dataGridView_Overpayment";
            this.dataGridView_Overpayment.RowTemplate.Height = 25;
            this.dataGridView_Overpayment.Size = new System.Drawing.Size(194, 542);
            this.dataGridView_Overpayment.TabIndex = 17;
            this.dataGridView_Overpayment.Visible = false;
            // 
            // Column_overpayment_month
            // 
            this.Column_overpayment_month.HeaderText = "Miesiac";
            this.Column_overpayment_month.Name = "Column_overpayment_month";
            this.Column_overpayment_month.Width = 50;
            // 
            // Column_overpayment_amount
            // 
            this.Column_overpayment_amount.HeaderText = "Kwota";
            this.Column_overpayment_amount.Name = "Column_overpayment_amount";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(271, 551);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(393, 52);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numer raty";
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kwota kapitałowa";
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kwota odsetek";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Pozostało";
            this.Column4.Name = "Column4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 607);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView_Overpayment);
            this.Controls.Add(this.dataGridView_Wibor);
            this.Controls.Add(this.checkBox_overpayment);
            this.Controls.Add(this.checkBox_wibor);
            this.Controls.Add(this.dataGridView_Output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_overpayment);
            this.Controls.Add(this.textBox_installment);
            this.Controls.Add(this.textBox_wibor);
            this.Controls.Add(this.textBox_margin);
            this.Controls.Add(this.textBox_Amount);
            this.Controls.Add(this.textbox_Month);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.monthCalendarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Wibor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Overpayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox textbox_Month;
        private TextBox textBox_Amount;
        private TextBox textBox_margin;
        private TextBox textBox_wibor;
        private TextBox textBox_installment;
        private TextBox textBox_overpayment;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private DataGridView dataGridView_Output;
        private CheckBox checkBox_wibor;
        private CheckBox checkBox_overpayment;
        private DataGridView dataGridView_Wibor;
        private DataGridView dataGridView_Overpayment;
        private DataGridViewTextBoxColumn Column_wibor_month;
        private DataGridViewTextBoxColumn Column_wibor_value;
        private DataGridViewTextBoxColumn Column_overpayment_month;
        private DataGridViewTextBoxColumn Column_overpayment_amount;
        private RichTextBox richTextBox1;
        private BindingSource monthCalendarBindingSource;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}