using System.Linq.Expressions;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HarmadikNap_Feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void multipleNumber_Click(object sender, EventArgs e)
        {
            working.Value = 0;
            if (szamMezo.Text.Length > 0 && isNumberValue(szamMezo.Text))
            {
                working.Maximum = Convert.ToInt32(szamMezo.Text);
                eredmenyMezo.Clear();
                int i = 2;
                int primCount = 1;
                for (int j = 1; j <= Convert.ToInt32(szamMezo.Text); j++)
                {
                    if (isPrime(j, i))
                    {
                        eredmenyMezo.Text += $"A(z) {primCount}. primsz�m : {j} \r\n";
                        primCount++;

                    }

                    if (working.Value < working.Maximum)
                    {
                        working.Value += 1;
                    }



                }
                eredmeny.Text = $"A megadott sz�mig {szamMezo.Text} :\r\n{primCount - 1} prim sz�m tal�lhat�!";
            }
        }

        private void singleNumber_Click(object sender, EventArgs e)
        {
            int i = 2;
            if (szamMezo.Text.Length > 0 && isNumberValue(szamMezo.Text))
            {
                eredmenyMezo.Clear();
                working.Value = 0;
                if (isPrime(Convert.ToInt32(szamMezo.Text), i))
                {
                    eredmeny.Text = $"A megadott sz�m : {szamMezo.Text}\r\nPRIMSZ�M!";
                }
                else
                {
                    eredmeny.Text = $"A megadott sz�m : {szamMezo.Text}\r\n NEM PRIMSZ�M!";
                }
            }
        }

        private bool isNumberValue(string getTextValue)
        {
            try
            {
                if (getTextValue.Length <= 0)
                {
                    szamVizsgalat.Text = "Nem adt�l meg �rt�ket";
                    return false;
                }
                int getNumber = Convert.ToInt32(getTextValue);

                if (getNumber < 0)
                {
                    szamVizsgalat.Text = $"A megadott sz�m negativ!";
                    return false;
                }
            }
            catch (FormatException)
            {
                szamVizsgalat.Text = $"Nem sz�mot adt�l meg";
                return false;
            }
            catch (OverflowException)
            {
                szamVizsgalat.Text = $"A sz�m t�l nagy!";
                return false;
            }

            return true;

        }

        static bool isPrime(int number, int i)
        {

            if (number <= 1)
            {
                return false;
            }

            if (number <= 3)
            {
                return true;
            }

            else if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            return IsPrimeRecursive(number, 5);
        }

        static bool IsPrimeRecursive(int number, int divisor)
        {
            if (divisor * divisor > number)
            {
                return true;
            }
            if (number % divisor == 0 || number % (divisor + 2) == 0)
            {
                return false;
            }
            return IsPrimeRecursive(number, divisor + 6);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void szamMezo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                singleNumber_Click(sender, e);
            }
        }
    }
}