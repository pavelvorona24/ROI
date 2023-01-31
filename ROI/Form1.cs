using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ROI
{
    public partial class Form1 : Form
    {
        //define global variables
        public int PCost, ClosingCost, DPaymentAmount, PropertyTax, InsuranceExpenses, MaintenanceExpenses, OtherExpenses, DPayment, AmortYears, MonthlyRent, Vacancy, NetRentalIncome, GrossRentalIncome;
        public double MortgageRate, ROI;
        public string[] ROISumElements = new string[4] {"GrossRentalIncome", "Mortgage", " NetRentalIncome", "ROI"};
        public string[] ROIElementsValue = new string[4];
       

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

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
            PropertyTax_box.Text = "2500";
            InsuranceExpenses_box.Text = "1000";
            MaintenanceExpenses_box.Text = "2000";
            OtherExpenses_box.Text = "500";
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
            PropertyCost_label.Text = ('$' + trackBar2.Value.ToString("0,00.00"));
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
            //assign value to mortgage label, give array value and output calculation
            int Mortgage = AmortYears;
            ROIElementsValue[1] = Mortgage.ToString();
            MortgagePrincipal_label.Text = Mortgage.ToString();
            //assign values to variables
            MonthlyRent = Convert.ToInt32(MonthlyRent_box.Text);
            Vacancy = Convert.ToInt32(Vacancy_box.Text);
            //calculations for gross rental income
            GrossRentalIncome = (MonthlyRent * 12 * (1 - (Vacancy / 100)));
            ROIElementsValue[0] = GrossRentalIncome.ToString(); 
            //print the output
            GrossRentalIncome_label.Text = GrossRentalIncome.ToString();
            
            DPaymentAmount = (DPayment / PCost) * 100;
            PropertyTax = Convert.ToInt32(PropertyTax_box.Text);
            InsuranceExpenses = Convert.ToInt32(InsuranceExpenses_box.Text);
            MaintenanceExpenses = Convert.ToInt32(MaintenanceExpenses_box.Text);
            OtherExpenses = Convert.ToInt32(OtherExpenses_box.Text);
            NetRentalIncome = GrossRentalIncome - (PropertyTax + InsuranceExpenses + MaintenanceExpenses + OtherExpenses);
            ROIElementsValue[2] = NetRentalIncome.ToString();
            NetRentalIncome_label.Text = NetRentalIncome.ToString();
            
            //ROI calculations
            ROI_label.Text = (NetRentalIncome / (ClosingCost + DPaymentAmount)).ToString() + "." + (NetRentalIncome % (ClosingCost + DPaymentAmount)).ToString();
            ROI = Convert.ToDouble(ROI_label.Text);
            ROIElementsValue[3] = ROI.ToString();
            
            

            //array to show ROI summary, just for the purpose of assignment requirements 
            int i;
            i = 0;
            lblOutput.Items.Clear();
            while (i < 4)
            {

                
               
                   
                    lblOutput.Items.Add(ROISumElements[i] + ": " + ROIElementsValue[i] + "\r\n");
                    
                   
                
                i = i + 1;
            }

            //use if, else if, else to display images corresponding to given parameters
            if (ROI < 1)
            {

                using (var g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.DrawLine(new Pen(Color.Red, 10), 110, 110, 180, 180);
                     

                    g.DrawLine(new Pen(Color.Red, 10),110, 180, 180, 110);
                    pictureBox1.Refresh();
                    g.Clear(Color.White);

                }
                
                

            }
            else if (ROI > 1 && ROI < 4)
            {
                using (var g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.DrawLine(new Pen(Color.FromArgb(50, 205, 50), 10),
                    70, 150, 110, 180);

                    g.DrawLine(new Pen(Color.FromArgb(50, 205, 50), 10),
                        110, 180, 180, 100);
                    pictureBox1.Refresh();
                    g.Clear(Color.White);

                }
                
            }
            else
            {
                using (var g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.DrawLine(new Pen(Color.FromArgb(50, 205, 50), 10),
                      70, 150, 110, 180);

                    g.DrawLine(new Pen(Color.FromArgb(50, 205, 50), 10),
                        110, 180, 180, 100);

                    g.DrawLine(new Pen(Color.FromArgb(50, 205, 50), 10),
                    170, 150, 210, 180);

                    g.DrawLine(new Pen(Color.FromArgb(50, 205, 50), 10),
                        210, 180, 280, 100);
                    pictureBox1.Refresh();
                    g.Clear(Color.White);
                }



            }
        }
    }
}