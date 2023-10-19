using DividersProject;
namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gB_Num.Enabled = false;
            gB_lineSeg.Enabled = false;
        }

        private void btn_GetPrimes_Click(object sender, EventArgs e)
        {
            txBx_Primes.Clear();
            int[] result = Dividers.AllPrimes(int.Parse(txBx_Start.Text), int.Parse(txBx_End.Text));
            foreach (int item in result)
                txBx_Primes.Text += item.ToString() + " ";
        }

        private void btn_PrimeCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dividers.IsPrime(int.Parse(txBx_Number.Text)))
                {
                    lbl_NumIsPrime.Text = "Число простое";
                }
                else { lbl_NumIsPrime.Text = "Число составное"; }
            } catch { MessageBox.Show("Требуется натуральное число!"); }
        }

        private void txBx_Number_TextChanged(object sender, EventArgs e)
        {
            lbl_NumIsPrime.Text = "Статус неопределен";
            txBx_PrimeDecomposition.Text = "";
            txBx_AllDividers.Text = "";
            lbl_IsDivider.Text = "Статус неопределен";
            if (txBx_Number.Text == String.Empty)
            {
                gB_Num.Enabled = false;
            } 
            else 
            { 
                gB_Num.Enabled = true;
                if (double.TryParse(txBx_Number.Text, out double number))
                {
                    btn_DivCheck.Enabled = true;
                    btn_GetDecomposition.Enabled = true;
                    btn_GetDivList.Enabled = true; 
                    btn_PrimeCheck.Enabled = true;
                }
                else
                {
                    btn_PrimeCheck.Enabled = false;
                    btn_GetDecomposition.Enabled = false;
                    btn_DivCheck.Enabled = false;
                    btn_GetDivList.Enabled = false;
                }
            } 
        }

        private void btn_GetDecomposition_Click(object sender, EventArgs e)
        {
            (int[] dividers, int[] powers) = Dividers.Factorize(int.Parse(txBx_Number.Text));
            txBx_PrimeDecomposition.Text = "";
            for (int i = 0; i < dividers.Length; i++)
            {
                txBx_PrimeDecomposition.Text += dividers[i].ToString();
                if (powers[i] > 1)
                    txBx_PrimeDecomposition.Text += "^" + powers[i].ToString();
                if (i < dividers.Length - 1)
                    txBx_PrimeDecomposition.Text += " * ";
            }
        }

        private void btn_DivCheck_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txBx_Divider.Text, out double number) && number > 0 )
            {
                if (Dividers.IsDivider(int.Parse(txBx_Number.Text), int.Parse(txBx_Divider.Text)))
                {
                    lbl_IsDivider.Text = "Является делителем";
                } else { lbl_IsDivider.Text = "Не является делителем"; }
            } else { MessageBox.Show("Требуется ввести число!"); }
        }

        private void txBx_Divider_TextChanged(object sender, EventArgs e)
        {
            lbl_IsDivider.Text = "Статус неопределен";
        }

        private void btn_GetDivList_Click(object sender, EventArgs e)
        {
            txBx_AllDividers.Text = "";
            int[] allDividers = Dividers.AllDividers(int.Parse(txBx_Number.Text));
            Array.Sort(allDividers);
            foreach (int item in allDividers)
            {
                txBx_AllDividers.Text += item.ToString() + " ";
            }
        }
        private bool lineCheck()
        {
            if (txBx_Start.Text != String.Empty && double.TryParse(txBx_Start.Text, out double number))
            {
                if (txBx_End.Text != String.Empty && double.TryParse(txBx_End.Text, out double number2))
                {
                    if (int.Parse(txBx_Start.Text) < int.Parse(txBx_End.Text))
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }

        private void txBx_Start_TextChanged(object sender, EventArgs e)
        {
            if (lineCheck()) 
            {
                gB_lineSeg.Enabled = true;
            } else { gB_lineSeg.Enabled = false; }
            txBx_Primes.Clear();
            txBx_lineDiv.Clear();
        }

        private void txBx_End_TextChanged(object sender, EventArgs e)
        {
            if (lineCheck())
            {
                gB_lineSeg.Enabled = true;
            }
            else { gB_lineSeg.Enabled = false; }
            txBx_Primes.Clear();
            txBx_lineDiv.Clear();
        }

        private void btn_lineDiv_Click(object sender, EventArgs e)
        {
            txBx_lineDiv.Clear();
            var result = Dividers.FindNumsWithDividers(int.Parse(textBox2.Text), int.Parse(txBx_Start.Text), int.Parse(txBx_End.Text));
            foreach (var item in result)
                txBx_lineDiv.Text += item.ToString() + " ";
        }
    }
}