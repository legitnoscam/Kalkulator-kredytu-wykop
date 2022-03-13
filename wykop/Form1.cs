using Timer = System.Windows.Forms.Timer;

namespace wykop
{
    public partial class Form1 : Form
    {
        static System.Windows.Forms.Timer Timer1 = new System.Windows.Forms.Timer();
        const Int32 numberOfCalculations = 100000;
        public enum Months : short
        {
            Styczeñ,
            Luty,
            Marzec,
            Kwiecieñ,
            Maj,
            Czerwiec,
            Lipiec,
            Sierpieñ,
            Wrzesieñ,
            PaŸdziernik,
            Listopad,
            Grudzieñ
        }

        private void InitializeTimer()
        {
            // Call this procedure when the application starts.  
            // Set to 1 second.  
            Timer1.Interval = 250;
            Timer1.Tick += new EventHandler(Timer1_Tick);

            
        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            // Set the caption to the current time.  
            this.BackgroundImage = Image.FromFile("C:/Users/Boguœ/source/repos/wykop/wykop/Properties/DataSources/clean.png");
            Timer1.Enabled = false;
        }

        public Form1()
        {
            InitializeComponent();
            //ComboBox textbox_month = new ComboBox();
            textbox_Month.DataSource = Enum.GetValues(typeof(Months));
            dataGridView_Wibor.ColumnHeadersHeight = 25;
            dataGridView_Overpayment.ColumnHeadersHeight = 25;
            dataGridView_Output.ColumnHeadersHeight = 25;
            InitializeTimer();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_wibor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_wibor.Checked)
            {
                dataGridView_Wibor.Visible = true;

                this.BackgroundImage = Image.FromFile("C:/Users/Boguœ/source/repos/wykop/wykop/Properties/DataSources/glapcia.jpg");
                // Enable timer.  
                Timer1.Enabled = true;
                
            }
            else
            {
                dataGridView_Wibor.Visible = false;
                
            }
        }

        private void checkBox_overpayment_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_overpayment.Checked)
            {
                dataGridView_Overpayment.Visible = true;
            }
            else
                dataGridView_Overpayment.Visible = false;
        }

        private void dataGridView_Output_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 currentMonth = textbox_Month.SelectedIndex;
            double initialValue = Convert.ToDouble(textBox_Amount.Text);
            double margin = Convert.ToDouble(textBox_margin.Text);
            double wibor = Convert.ToDouble(textBox_wibor.Text);
            double fixedd = Convert.ToDouble(textBox_installment.Text);
            double overpayment = Convert.ToDouble(textBox_overpayment.Text);
            
            double value = initialValue;
            double currentPercentage = margin + wibor;
            Int32 monthCount = 0;
            double sum = 0.0;

            Dictionary<int, double> wiborDictionary = new Dictionary<int, double>();
            Dictionary<int, double> overpaymentDictionary = new Dictionary<int, double>();
            if (checkBox_wibor.Checked)
            {
                Int32 numOfRowsWibor=dataGridView_Wibor.Rows.Count;
                if (numOfRowsWibor>1)
                {
                    for (int i = 0; i < numOfRowsWibor-1; i++)
                    {

                        wiborDictionary.Add(Convert.ToInt16(dataGridView_Wibor[0, i].Value), Convert.ToDouble(dataGridView_Wibor[1, i].Value));
                        //richTextBox1.Text += dataGridView_Wibor[0, i];

                    }
                }
                //foreach (KeyValuePair<int, double> pair in wiborDictionary)
                //{
                //    MessageBox.Show(pair.Key.ToString() + "  -  " + pair.Value.ToString());
                //    //richTextBox1.Text += pair.Key.ToString() + "  -  " + pair.Value.ToString();
                //}
                //richTextBox1.Text += x;
            }

            if (checkBox_overpayment.Checked)
            {
                Int32 numOfRowsOverpayment = dataGridView_Overpayment.Rows.Count;
                if (numOfRowsOverpayment > 1)
                {
                    for (int i = 0; i < numOfRowsOverpayment - 1; i++)
                    {
                        overpaymentDictionary.Add(Convert.ToInt16(dataGridView_Overpayment[0, i].Value), Convert.ToDouble(dataGridView_Overpayment[1, i].Value));
                    }
                }
            }

            for (int i = 0; i < numberOfCalculations; i++)
            {
                dataGridView_Output.Rows.Add();
                if (checkBox_wibor.Checked && wiborDictionary.ContainsKey(i))
                {
                    currentPercentage = wiborDictionary[i] + margin;
                }
                if (checkBox_overpayment.Checked && overpaymentDictionary.ContainsKey(i))
                {
                    value -= overpaymentDictionary[i];
                }
                double monthInitialValue = value;

                for (int j = 0; j < DateTime.DaysInMonth(2022,currentMonth+1); j++)
                {
                    value += ((value / 365.0) * (currentPercentage / 100.0));
                }

                double interests = value - monthInitialValue;
                value = value - fixedd - overpayment - interests;
                //numer miesiaca
                dataGridView_Output[0, i].Value = i;
                //kwota kapita³owa
                dataGridView_Output[1, i].Value = fixedd+overpayment;
                //kwota odsetek
                dataGridView_Output[2, i].Value = Math.Round(interests,2);
                //pozosta³o
                dataGridView_Output[3, i].Value = value;

                currentMonth = (currentMonth + 1) % 12;
                sum += interests;

                if (value<(fixedd+overpayment))
                {
                    monthCount = i + 1;
                    richTextBox1.Text = "kredyt sp³acono w " + monthCount + "miesiêcy," +
                        " ca³kowita kwota odsetek wynios³a: " + Math.Round(sum) + "z³";
                    break;
                }
            }
        }
    }
}