namespace HesapMakinesi2
{
    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
        }

        //Deðerler
        string text;
        bool afterOperator = false;
        bool afterEqual = false;
        bool startWithMinus;
        bool moreThan2Operator;
        bool afterTorB = false;

        // tek tek bütün deðerleri kontrol et. Sýfýrlaman gerekenleri sýfýrla.

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
     



        private void btn0_Click(object sender, EventArgs e)
        {
            if (afterEqual || afterTorB)
            {
                textBox.Text = string.Empty;
                afterTorB = false;
            }
            textBox.Text += "0";
            afterOperator = false;
            afterEqual = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (afterEqual || afterTorB)
            {
                textBox.Text = string.Empty;
                afterTorB = false;
            }
            textBox.Text += "1";
            afterOperator = false;
            afterEqual = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (afterEqual || afterTorB)
            {
                textBox.Text = string.Empty;
                afterTorB = false;
            }
            textBox.Text += "2";
            afterOperator = false;
            afterEqual = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = string.Empty;
                afterTorB = false;
            }
            textBox.Text += "3";
            afterOperator = false;
            afterEqual = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = string.Empty;
                afterTorB = false;
            }
            textBox.Text += "4";
            afterOperator = false;
            afterEqual = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = string.Empty;
                afterTorB = false;
            }
            textBox.Text += "5";
            afterOperator = false;
            afterEqual = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = string.Empty;
                afterTorB = false;
            }
            textBox.Text += "6";
            afterOperator = false;
            afterEqual = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = string.Empty;
                afterTorB = false;
            }
            textBox.Text += "7";
            afterOperator = false;
            afterEqual = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = string.Empty;
                afterTorB = false;
            }
            textBox.Text += "8";
            afterOperator = false;
            afterEqual = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (afterEqual)
            {
                textBox.Text = string.Empty;
                afterTorB = false;
            }
            textBox.Text += "9";
            afterOperator = false;
            afterEqual = false;
        }




        private void btnComma_Click(object sender, EventArgs e)
        {
            if (afterTorB)
            {
                textBox.Text = string.Empty;
                afterTorB = false;
            }
            if (textBox.Text.Length > 0)
            {
                if (textBox.Text[^1] == '+' || textBox.Text[^1] == '-' || textBox.Text[^1] == 'X' || textBox.Text[^1] == '/')
                {
                    textBox.Text += "0,";
                    afterOperator = false;
                }
                else if (afterEqual)
                {
                    textBox.Text = "0,";
                }
                else
                {
                    textBox.Text += ",";
                }
            }
            else

            {
                textBox.Text = "0,";
            }
            afterTorB = false;
        }




        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (afterTorB)
            {
                textBox.Text = string.Empty;
                afterTorB = false;
            }
            if (textBox.Text.Length > 0)
            {
                if (textBox.Text[textBox.Text.Length - 1] == ',')
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                    textBox.Text += '+';
                    afterOperator = true;
                    afterEqual = false;

                }
                else if (!afterOperator)
                {
                    textBox.Text += "+";
                    afterOperator = true;
                    afterEqual = false;
                }
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (afterTorB)
            {
                textBox.Text = string.Empty;
                afterTorB = false;
            }
            if (textBox.Text.Length > 0)
            {

                if (textBox.Text[^1] == '-')
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                    textBox.Text += "+";
                    afterOperator = true;
                    afterEqual = false;
                }
                else if (textBox.Text[^1] == '+')
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                    textBox.Text += "-";
                    afterOperator = true;
                    afterEqual = false;
                }
                else if (textBox.Text[^1] == ',')
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                    textBox.Text += "-";
                    afterOperator = true;
                    afterEqual = false;
                }
                else
                {
                    textBox.Text += "-";
                    afterOperator = true;
                    afterEqual = false;
                }

            }
            else
            {
                textBox.Text += "-";
                afterOperator = true;
                afterEqual = false;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (afterTorB)
            {
                textBox.Text = string.Empty;
                afterTorB = false;
            }
            if (textBox.Text.Length > 0)
            {
                if (textBox.Text[textBox.Text.Length - 1] == ',')
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                    textBox.Text += 'x';
                    afterOperator = true;
                    afterEqual = false;

                }
                else if (!afterOperator)
                {
                    textBox.Text += "x";
                    afterOperator = true;
                    afterEqual = false;
                }
            }
        }

        private void btnDivisor_Click(object sender, EventArgs e)
        {
            if (afterTorB)
            {
                textBox.Text = string.Empty;
                afterTorB = false;
            }
            if (textBox.Text.Length > 0)
            {
                if (textBox.Text[textBox.Text.Length - 1] == ',')
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                    textBox.Text += '/';
                    afterOperator = true;
                    afterEqual = false;

                }
                else if (!afterOperator)
                {
                    textBox.Text += "/";
                    afterOperator = true;
                    afterEqual = false;
                }
            }
        }




        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (afterTorB)
            {
                textBox.Text = string.Empty;
                afterTorB = false;
            }
            text = textBox.Text;

            if (text.Length > 0 && text[^1] == ',')
            {
                text = text.Remove(text.Length - 1, 1);
            }
            if (text[0] == '-')
            {
                text = '0' + text;
                startWithMinus = true;
            }
            List<object> listOperators = new List<object>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text.Length - i > 1)
                {
                    if (text.Substring(i, 2) == "x-" || text.Substring(i, 2) == "/-")
                    {
                        listOperators.Add(text[i]);
                        i++;
                    }
                    else if (text[i] == '+' || text[i] == 'x' || text[i] == '/')
                    {
                        listOperators.Add(text[i]);
                    }
                    else if (text[i] == '-')
                    {
                        if (text.Substring(i - 1, 2) == "x-" || text.Substring(i - 1, 2) == "/-")
                        {

                        }
                        listOperators.Add('+');
                    }
                }
                else
                {
                    if (text[i] == '+' || text[i] == 'x' || text[i] == '/')
                    {
                        listOperators.Add(text[i]);
                    }
                }
            }
            string text1 = text.Replace("x-", "-").Replace("/-", "-");
            string text2 = text1.Replace('+', ' ').Replace('x', ' ').Replace('/', ' ').Replace("-", " -");
            string[] numbers = text2.Split(' ');
            List<object> listNumbers = new List<object>();
            foreach (string number in numbers)
            {
                listNumbers.Add(number);
            }

            if (startWithMinus == true && listNumbers.Count >= 3 && listNumbers[^1] != "")
            {
                moreThan2Operator = true;
            }
            else if (listNumbers.Count >= 2 && listNumbers[^1] != "")
            {
                moreThan2Operator = true;
            }
            startWithMinus = false;
            if (moreThan2Operator)
            {
                while (listOperators.Contains('x') || listOperators.Contains('/'))
                {
                    int mFind = listOperators.IndexOf('x');
                    int dFind = listOperators.IndexOf('/');
                    if ((mFind < dFind && mFind != -1) || (mFind != -1 && dFind == -1))
                    {

                        double mFindDouble = double.Parse((string)listNumbers[mFind]);
                        double mFindDouble1 = double.Parse((string)listNumbers[mFind + 1]);
                        double sonuçDouble = mFindDouble * mFindDouble1;
                        string sonuç = sonuçDouble.ToString();
                        listNumbers[mFind] = sonuç;
                        listNumbers.RemoveAt(mFind + 1);
                        listOperators.RemoveAt(mFind);

                    }
                    else if (((mFind > dFind) && dFind != -1) || mFind == -1)
                    {
                        float dFindDouble = float.Parse((string)listNumbers[dFind]);
                        float dFindDouble1 = float.Parse((string)listNumbers[dFind + 1]);
                        if (dFindDouble == 0 && dFindDouble1 == 0)
                        {
                            textBox.Text = "Hatalý iþlem 0/0: belirsiz";
                            listNumbers.Clear();
                            listOperators.Clear();
                            afterTorB = true;
                        }
                        else if (dFindDouble1 == 0)
                        {
                            textBox.Text = "Hatalý iþlem sayý/0: tanýmsýz";
                            listNumbers.Clear();
                            listOperators.Clear();
                            afterTorB = true;
                        }
                        else
                        {
                            float sonuçDouble = dFindDouble / dFindDouble1;
                            string sonuç = sonuçDouble.ToString();
                            listNumbers[dFind] = sonuç;
                            listNumbers.RemoveAt(dFind + 1);
                            listOperators.RemoveAt(dFind);
                        }
                    }
                }
                while (listOperators.Contains('+'))
                {
                    double pMDouble = double.Parse((string)listNumbers[0]);
                    double pMDouble1 = double.Parse((string)listNumbers[1]);

                    int pFind = listOperators.IndexOf('+');
                    if (pFind == 0)
                    {
                        double sonuçDouble = pMDouble + pMDouble1;
                        string sonuç = sonuçDouble.ToString();
                        listNumbers[0] = sonuç;
                        listNumbers.RemoveAt(1);
                        listOperators.RemoveAt(0);
                    }
                }
                if (!afterTorB)
                {
                    textBox.Text = listNumbers[0].ToString();
                }
                afterOperator = false;
                afterEqual = true;
            }
            moreThan2Operator = false;
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            afterEqual = false;
            if (afterTorB)
            {
                textBox.Text = string.Empty;
            }
            if (textBox.Text.Length > 1)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                if (textBox.Text[^1] == '+' || textBox.Text[^1] == '-' || textBox.Text[^1] == 'x' || textBox.Text[^1] == '/')
                {
                    afterOperator = true;
                }
                else
                {
                    afterOperator = false;
                }

            }
            else if (textBox.Text.Length == 1)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
            }
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            if (afterTorB)
            {
                textBox.Text = string.Empty;
                afterTorB = false;
            }
            textBox.Text = string.Empty;
            bool afterOperator = false;
            bool afterEqual = false;
        }
    }
}