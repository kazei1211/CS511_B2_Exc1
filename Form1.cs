namespace Exc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            //allow only number
            if (!float.TryParse(distanceRTb.Text, out _))
            {
                MessageBox.Show("Please enter ONLY number!");
                return;
            }

            //get distance
            float distance = float.Parse(distanceRTb.Text);
            double price = Program.calFee(distance);

            distanceDispl.Text = distance.ToString() + " Km";
            priceDispl.Text = price.ToString();

            priceDispl.Visible = true;
            distanceDispl.Visible = true;
            billLabel.Visible = true;
            feeLabel.Visible = true;
            distanceLabel.Visible = true;
        }

        private void distanceRTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //allow only number
                if (!float.TryParse(distanceRTb.Text, out _))
                {
                    MessageBox.Show("Please enter ONLY number!");
                    return;
                }
                float distance = float.Parse(distanceRTb.Text);
                double price = Program.calFee(distance);

                distanceDispl.Text = distance.ToString() + " Km";
                priceDispl.Text = price.ToString();

                priceDispl.Visible = true;
                distanceDispl.Visible = true;
                billLabel.Visible = true;
                feeLabel.Visible = true;
                distanceLabel.Visible = true;
            }
        }
    }
}