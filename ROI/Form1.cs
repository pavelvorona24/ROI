namespace ROI
{
    public partial class Form1 : Form
    {
        //define global variables
        public int PCost,ClosingCost, DPaymentAmount, DPayment,AmortYears,MonthlyRent,Vacancy,GrossRentalIncome;
        public double MortgageRate, ROI;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
         
                    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //define trackbar values and set starting parameters for text boxes
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            trackBar1.TickStyle = TickStyle.BottomRight;
            trackBar1.TickFrequency = 1;
            trackBar1.Value = 10;
            trackBar2.Minimum = 0;
            trackBar2.Maximum = 5000000;
            trackBar2.TickStyle = TickStyle.BottomRight;
            trackBar2.TickFrequency = 1000;
            trackBar2.Value = 500000;
            Vacancy_box.Text = "3";
            MonthlyRent_box.Text = "1000";
            MortgageRate_box.Text = "5";
            AmortYears_box.Text = "25";
            ClosingCost_box.Text = "5000";
        }



        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            //output trackbar value to label
            PropertyCost_label.Text = ( '$' + trackBar2.Value.ToString("0,00.00"));
             PCost = trackBar2.Value;
        }

        private void ClosingCost_box_TextChanged(object sender, EventArgs e)
        {
            //make sure the text box value is greater than 0 to then continue calculations
            if (!String.IsNullOrEmpty(ClosingCost_box.Text))
            {
                ClosingCost = Convert.ToInt32(ClosingCost_box.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //make sure the text box value is greater than 0 to then continue calculations
            if (!String.IsNullOrEmpty(AmortYears_box.Text))
            {
                AmortYears = Convert.ToInt32(AmortYears_box.Text);
            }
            
        }

        private void GrossRentalIncome_label_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            //output trackbar value to label
            DownPayment_label.Text = trackBar1.Value.ToString("00");
             DPayment = trackBar1.Value;
            
            
            

        }

        private void MortgageRate_box_TextChanged(object sender, EventArgs e)
        {
            //make sure the text box value is greater than 0 to then continue calculations
            if (!String.IsNullOrEmpty(MortgageRate_box.Text))
            {
                MortgageRate = Convert.ToDouble(MortgageRate_box.Text);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //assign value to mortgage label and output calculation
            int Mortgage = AmortYears;
            MortgagePrincipal_label.Text = Mortgage.ToString();
            //assign values to variables
            MonthlyRent = Convert.ToInt32(MonthlyRent_box.Text);    
            Vacancy = Convert.ToInt32(Vacancy_box.Text);
            //calculations for gross rental income
            GrossRentalIncome = (MonthlyRent * 12* (1-(Vacancy/100)));
            //print the output
            GrossRentalIncome_label.Text = GrossRentalIncome.ToString();
            //ROI calculations
            DPaymentAmount = (DPayment / PCost) * 100;
            //print output
            ROI_label.Text = (GrossRentalIncome / (ClosingCost + DPaymentAmount)).ToString()+ "." + (GrossRentalIncome % (ClosingCost + DPaymentAmount)).ToString();
        }
    }
}