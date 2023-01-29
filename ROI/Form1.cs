namespace ROI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int DownPayment_label, PropertyCost_label;
            DownPayment_label = 10;
            PropertyCost_label = 500000;
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
         
                    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            trackBar1.TickStyle = TickStyle.BottomRight;
            trackBar1.TickFrequency = 1;
            trackBar2.Minimum = 0;
            trackBar2.Maximum = 5000000;
            trackBar2.TickStyle = TickStyle.BottomRight;
            trackBar2.TickFrequency = 1000;
        }



        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            PropertyCost_label.Text = ( '$' + trackBar2.Value.ToString("0,00.00"));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            DownPayment_label.Text = trackBar1.Value.ToString("00");
            int DPayment = DownPayment_label;
            int PCost = PropertyCost_label;
            int DPaymentAmount = (DPayment / 100 * PCost);
            int MortgageP = (DPaymentAmount - PCost);
            MortgagePrincipal_label.Text = "123";
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MortgagePrincipal_label.Text = "123";
        }
    }
}