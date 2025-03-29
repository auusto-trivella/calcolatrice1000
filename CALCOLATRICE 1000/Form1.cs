namespace CALCOLATRICE_1000
{
    public partial class Form1 : Form
    {

        public double num1 = 0;
        public double num2 = 0;
        public bool operatore = false;
        public int operazione = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
          
            if (operatore == true) 
            {
                ope.Text = ""+1;
                operatore = false;
            }
            else
            {
                ope.Text += +1;
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                ope.Text = "" + 2;
                operatore = false;
            }
            else
            {
                ope.Text += +2;
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                ope.Text = "" + 3;
                operatore = false;
            }
            else
            {
                ope.Text += +3;
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                ope.Text = "" + 4;
                operatore = false;
            }
            else
            {
                ope.Text += +4;
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                ope.Text = "" + 5;
                operatore = false;
            }
            else
            {
                ope.Text += +5;
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                ope.Text = "" + 6;
                operatore = false;
            }
            else
            {
                ope.Text += +6;
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                ope.Text = "" + 7;
                operatore = false;
            }
            else
            {
                ope.Text += +7;
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if(operatore == true)
            {
                ope.Text = "" + 8;
                operatore = false;
            }
            else
            {
                ope.Text += +8;
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                ope.Text = "" + 9;
                operatore = false;
            }
            else
            {
                ope.Text += +9;
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                ope.Text = "" + 0;
                operatore = false;
            }
            else
            {
                ope.Text += +0;
            }
        }

        private void somm_Click(object sender, EventArgs e)
        {
            

            if (num1 == 0) 
            {
                if (ope.Text == "")
                {
                    ope.Text = "0";

                }
                num1 = Convert.ToDouble(ope.Text);
                ope.Text = Convert.ToString(num1);
                operatore = true;
                operazione = 1;
            }

            else
            {
                num2 = Convert.ToDouble(ope.Text);
                num1 = num1 + num2;
                ope.Text = Convert.ToString(num1);
                operatore = true;
                operazione = 1;
            }
        }

             

        private void sott_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                if (ope.Text == "")
                {
                    ope.Text = "0";

                }
                num1 = Convert.ToDouble(ope.Text);
                ope.Text = Convert.ToString(num1);
                operatore = true;
                operazione = 2;
            }

            else
            {
                num2 = Convert.ToDouble(ope.Text);
                num1 = num1 + num2;
                ope.Text = Convert.ToString(num1);
                operatore = true;
                operazione = 2;
            }
        }

        private void mol_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                if (ope.Text == "")
                {
                    ope.Text = "0";

                }
                num1 = Convert.ToDouble(ope.Text);
                ope.Text = Convert.ToString(num1);
                operatore = true;
                operazione = 4;
            }

            else
            {
                num2 = Convert.ToDouble(ope.Text);
                num1 = num1 + num2;
                ope.Text = Convert.ToString(num1);
                operatore = true;
                operazione = 4;
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                if (ope.Text == "")
                {
                    ope.Text = "0";

                }
                num1 = Convert.ToDouble(ope.Text);
                ope.Text = Convert.ToString(num1);
                operatore = true;
                operazione = 3;
            }

            else
            {
                num2 = Convert.ToDouble(ope.Text);
                num1 = num1 + num2;
                ope.Text = Convert.ToString(num1);
                operatore = true;
                operazione = 3;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            final = null;
            ope.Text = null;
            operazione = 0;
            operatore=false;
            num1 = 0;
            num2 = 0;
        }

        private void ris_Click(object sender, EventArgs e)
        {
            switch (operazione)
            {
                case 1:
                    num2 = Convert.ToDouble(ope.Text);
                    num1 = num1 + num2;
                    ope.Text = Convert.ToString(num1);
                    num1 = 0;
                    num2 = 0;
                    operatore = true;
                    break;
                case 2:
                    num2 = Convert.ToDouble(ope.Text);
                    num1 = num1 - num2;
                    ope.Text = Convert.ToString(num1);
                    num1 = 0;
                    num2 = 0;
                    operatore = true;
                    break;
                case 3:
                    num2 = Convert.ToDouble(ope.Text);
                    num1 = num1 / num2;
                    ope.Text = Convert.ToString(num1);
                    num1 = 0;
                    num2 = 0;
                    operatore = true;
                    break;
                case 4:
                    num2 = Convert.ToDouble(ope.Text);
                    num1 = num1 * num2;
                    ope.Text = Convert.ToString(num1);
                    num1 = 0;
                    num2 = 0;
                    operatore = true;
                    break;
            }
        }
    }
}