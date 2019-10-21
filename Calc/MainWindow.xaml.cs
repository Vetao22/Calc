using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtEquation.Focus();
        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            txtEquation.Text += "0";
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            txtEquation.Text += "3";
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            txtEquation.Text += "2";
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            txtEquation.Text += "1";
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            txtEquation.Text += "6";
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            txtEquation.Text += "5";
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            txtEquation.Text += "4";
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            txtEquation.Text += "9";
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            txtEquation.Text += "8";
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            txtEquation.Text += "7";
        }    

        private void btnPercent_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;
            double dValue = 0;

            if(!String.IsNullOrEmpty(equation))
            {
                string[] splits = equation.Split(new char[] { '+', '-', '*', '÷' });

                if (splits.Length > 1)
                {
                    return;
                }

                dValue = Convert.ToDouble(equation);

                dValue = MathFunctions.Percent(dValue);

                txtEquation.Text = dValue.ToString();
            }
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;
            double dValue = 0;

            if(!String.IsNullOrEmpty(equation))
            {
                string[] splits = equation.Split(new char[] { '+', '-', '*', '÷' });

                if (splits.Length > 1)
                {
                    return;
                }

                dValue = Convert.ToDouble(equation);

                dValue = Convert.ToDouble(dValue);

                if(dValue >= 1)
                {
                    dValue = MathFunctions.Sqrt(dValue);
                    txtEquation.Text = dValue.ToString();
                }
            }
        }

        private void btnPowerOfTwo_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;
            double dValue = 0;

            if (!String.IsNullOrEmpty(equation))
            {
                string[] splits = equation.Split(new char[] { '+', '-', '*', '÷' });

                if(splits.Length > 1)
                {
                    return;
                }

                dValue = Convert.ToDouble(equation);

                txtEquation.Text = MathFunctions.PowerOfTwo(dValue).ToString();
            }
        }

        private void btnOneDivideByX_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;
            double dValue = 0;

            if(!String.IsNullOrEmpty(equation))
            {
                string[] splits = equation.Split(new char[] { '+', '-', '*', '÷' });

                if (splits.Length > 1)
                {
                    return;
                }

                dValue = Convert.ToDouble(equation);

                if(dValue > 0)
                {
                    dValue = MathFunctions.OneDividedByN(dValue);
                    txtEquation.Text = dValue.ToString();
                }
            }
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            txtEquation.Text = "";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            MathFunctions.ClearResult();
        }

        private void btnErase_Click(object sender, RoutedEventArgs e)
        {
            string value = txtEquation.Text;

            if(!String.IsNullOrEmpty(value))
            {
                int index = value.IndexOf(value.Last());
                value = value.Remove(index);

                txtEquation.Text = value;
            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;

            if(!String.IsNullOrEmpty(equation))
            {
                if(Char.IsDigit(equation.Last()))
                {
                    equation += "÷";
                    txtEquation.Text = equation;
                }
            }
        }

        private void btnSwitchSign_Click(object sender, RoutedEventArgs e)
        {
            string value = txtEquation.Text;
            double dValue = Convert.ToDouble(value);
            dValue *= -1;

            txtEquation.Text = dValue.ToString();
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            string value = txtEquation.Text;

            if(String.IsNullOrEmpty(value))
            {
                txtEquation.Text += "0.";
            }
            else
            {
                if(!value.Contains("."))
                {
                    txtEquation.Text += ".";
                }
            }
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;

            if (!String.IsNullOrEmpty(equation))
            {
                if (Char.IsDigit(equation.Last()))
                {
                    equation += "*";
                    txtEquation.Text = equation;
                }
            }
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;

            if (!String.IsNullOrEmpty(equation))
            {
                if (Char.IsDigit(equation.Last()))
                {
                    equation += "-";
                    txtEquation.Text = equation;
                }
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;

            if (!String.IsNullOrEmpty(equation))
            {
                if (Char.IsDigit(equation.Last()))
                {
                    equation += "+";
                    txtEquation.Text = equation;
                }
            }
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;

            if(!String.IsNullOrEmpty(equation))
            {
                if(!Char.IsNumber(equation.Last()))
                {
                    equation = equation.Substring(0, equation.Length - 1);
                }


                txtEquation.Text = MathFunctions.ProcessResult(equation).ToString();
            }
        }

        private void txtEquation_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            e.Handled = true;
        }


        void HandleKey(string s)
        {
            if (char.IsDigit(s.Last()))
            {
                txtEquation.Text += s.Last();
                return;
            }

            if (s == "," || s == ".")
            {
                if (String.IsNullOrEmpty(txtEquation.Text))
                {
                    txtEquation.Text += "0";
                }

                if (!txtEquation.Text.Contains("."))
                {
                    txtEquation.Text += ".";
                    return;
                }
            }

            if (s == "/")
            {
                if (!String.IsNullOrEmpty(txtEquation.Text))
                {
                    if (txtEquation.Text.Last() == '.')
                    {
                        int index = txtEquation.Text.IndexOf(txtEquation.Text.Last());
                        txtEquation.Text = txtEquation.Text.Remove(index);
                    }

                    txtEquation.Text += "÷";
                    return;
                }
            }

            if (s == "*")
            {
                if (!String.IsNullOrEmpty(txtEquation.Text))
                {
                    if (txtEquation.Text.Last() == '.')
                    {
                        int index = txtEquation.Text.IndexOf(txtEquation.Text.Last());
                        txtEquation.Text = txtEquation.Text.Remove(index);
                    }

                    txtEquation.Text += "*";
                    return;
                }
            }

            if (s == "+")
            {
                if (!String.IsNullOrEmpty(txtEquation.Text))
                {
                    if (txtEquation.Text.Last() == '.')
                    {
                        int index = txtEquation.Text.IndexOf(txtEquation.Text.Last());
                        txtEquation.Text = txtEquation.Text.Remove(index);
                    }

                    txtEquation.Text += "+";
                    return;
                }
            }

            if (s == "-")
            {
                if (!String.IsNullOrEmpty(txtEquation.Text))
                {
                    if (txtEquation.Text.Last() == '.')
                    {
                        int index = txtEquation.Text.IndexOf(txtEquation.Text.Last());
                        txtEquation.Text = txtEquation.Text.Remove(index);
                    }

                    txtEquation.Text += "-";
                    return;
                }
            }
        }

        private void txtEquation_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = true;

            HandleKey(e.Text);
        }

        private void txtEquation_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (!String.IsNullOrEmpty(txtEquation.Text))
                {
                    txtEquation.Text = MathFunctions.ProcessResult(txtEquation.Text).ToString();
                    return;
                }
            }
        }
    }
}
