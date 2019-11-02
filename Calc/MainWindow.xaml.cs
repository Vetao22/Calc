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
        bool alternateButtons = false;
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

            if(!String.IsNullOrEmpty(equation))
            {
                string[] splits = equation.Split(new char[] { '+', '-', '*', '÷' });

                if (splits.Length > 1)
                {
                    return;
                }

                if(!alternateButtons)
                { 
                    equation = "sqrt(" + equation + ")";
                }
                else
                {
                    equation = "1 / " + equation;
                }

                txtEquation.Text = MathFunctions.ProcessResult(equation).ToString();
            }
        }

        private void btnPowerOfTwo_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;

            if (!String.IsNullOrEmpty(equation))
            {
                string[] splits = equation.Split(new char[] { '+', '-', '*', '÷' });

                if(splits.Length > 1)
                {
                    return;
                }

                if(!alternateButtons)
                { 
                    equation = equation + "^ 2";
                }
                else
                {
                    equation = equation + "^ 3";
                }

                txtEquation.Text = MathFunctions.ProcessResult(equation).ToString();
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
                    equation = "1 / " + equation;
                    dValue = MathFunctions.ProcessResult(equation);
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
            txtEquation.Text = "";
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
            string equation = txtEquation.Text;
            double dValue = 0;

            if (!String.IsNullOrEmpty(equation))
            {
                dValue = -MathFunctions.ProcessResult(equation);

                txtEquation.Text = dValue.ToString();
            }
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

            if (!String.IsNullOrEmpty(equation))
            {
                if (equation.Contains("÷"))
                {
                    equation = equation.Replace("÷", "/");
                }

                if(equation.Contains("yroot"))
                {
                    string[] split = equation.Replace("yroot", " ").Split(' ') ;
                    equation = split.First() + "^ (1 / " + split.Last() + ")";
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
            String equation = txtEquation.Text;

            if (e.Key == Key.Enter)
            {

                if (!String.IsNullOrEmpty(equation))
                {
                    if (equation.Contains("÷"))
                    {
                        equation = equation.Replace("÷", "/");
                    }

                    txtEquation.Text = MathFunctions.ProcessResult(equation).ToString();
                    return;
                }
            }
        }

        private void btnMemStore_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;
            double dValue = 0;

            if (!String.IsNullOrEmpty(equation))
            {
                string[] splits = equation.Split(new char[] { '+', '-', '*', '÷' });

                if (splits.Length > 1)
                {
                    return;
                }

                dValue = Convert.ToDouble(equation);

                MathFunctions.Mem = dValue;

                btnMemClear.IsEnabled = true;
                btnMemRecover.IsEnabled = true;
              
            }
        }

        private void btnMemSub_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;
            double dValue = 0;

            if (!String.IsNullOrEmpty(equation))
            {
                string[] splits = equation.Split(new char[] { '+', '-', '*', '÷' });

                if (splits.Length > 1)
                {
                    return;
                }

                dValue = Convert.ToDouble(equation);

                MathFunctions.SubFromMem(dValue);
            }
        }

        private void btnMemAdd_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;
            double dValue = 0;

            if (!String.IsNullOrEmpty(equation))
            {
                string[] splits = equation.Split(new char[] { '+', '-', '*', '÷' });

                if (splits.Length > 1)
                {
                    return;
                }

                dValue = Convert.ToDouble(equation);

                MathFunctions.AddToMem(dValue);              
            }
        }

        private void btnMemRecover_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;

            if(String.IsNullOrEmpty(equation))
            {
                equation += MathFunctions.Mem;

                txtEquation.Text = equation;
            }
            else
            {
                if(!Char.IsNumber(equation.Last()))
                {
                    equation += MathFunctions.Mem.ToString();

                    txtEquation.Text = equation;
                }
            }
        }

        private void btnMemClear_Click(object sender, RoutedEventArgs e)
        {
            MathFunctions.MemClear();

            btnMemClear.IsEnabled = false;
            btnMemRecover.IsEnabled = false;
        }

        private void btnXRaisedToY_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;

            if(!String.IsNullOrEmpty(equation))
            {
                if(Char.IsNumber(equation.Last()))
                {
                    equation = MathFunctions.ProcessResult(equation).ToString();

                    if (!alternateButtons)
                    {
                        equation += "^";
                    }
                    else
                    {
                        equation += " yroot ";
                    }
                    txtEquation.Text = equation;                   
                }
            }
        }

        private void btnSin_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;
            double value;

            if(!String.IsNullOrEmpty(equation))
            {
                value = MathFunctions.ProcessResult(equation);

                if (!alternateButtons)
                {
                    value = value * (Math.PI / 180);
                }

                if(value != 0)
                {
                    if(!alternateButtons)
                    { 
                        equation = "sin(" + value + ")";
                    }
                    else
                    {
                        equation = "asin(" + value + ")";                   
                    }

                    value = MathFunctions.ProcessResult(equation);
                    if(alternateButtons)
                    { 
                        value = value * (180 / Math.PI);
                    }

                    txtEquation.Text = value.ToString();
                }
            }

            
        }

        private void btnCos_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;
            double value;

            if (!String.IsNullOrEmpty(equation))
            {
                value = MathFunctions.ProcessResult(equation);

                if (!alternateButtons)
                {
                    value = value * (Math.PI / 180);
                }

                if (value != 0)
                {
                    if (!alternateButtons)
                    {
                        equation = "cos(" + value + ")";
                    }
                    else
                    {
                        equation = "acos(" + value + ")";
                    }

                    value = MathFunctions.ProcessResult(equation);
                    if (alternateButtons)
                    {
                        value = value * (180 / Math.PI);
                    }

                    txtEquation.Text = value.ToString();
                }
            }

        }

        private void btnTan_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;
            double value;

            if (!String.IsNullOrEmpty(equation))
            {
                value = MathFunctions.ProcessResult(equation);

                if (!alternateButtons)
                {
                    value = value * (Math.PI / 180);
                }

                if (value != 0)
                {
                    if (!alternateButtons)
                    {
                        equation = "tan(" + value + ")";
                    }
                    else
                    {
                        equation = "atan(" + value + ")";
                    }

                    value = MathFunctions.ProcessResult(equation);
                    if (alternateButtons)
                    {
                        value = value * (180 / Math.PI);
                    }

                    txtEquation.Text = value.ToString();
                }
            }

        }

        private void btnTenPowerOfX_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;
            double value;

            if (!String.IsNullOrEmpty(equation))
            {
                value = MathFunctions.ProcessResult(equation);
                
                if (value != 0)
                {
                    if(!alternateButtons)
                    { 
                        equation = "10 ^" + value;
                    }
                    else
                    {
                        equation = "e ^" + value;
                    }
                    txtEquation.Text = MathFunctions.ProcessResult(equation).ToString();
                }
            }
        }

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;
            double value;

            if (!String.IsNullOrEmpty(equation))
            {
                value = MathFunctions.ProcessResult(equation);

                if (value != 0)
                {
                    if(!alternateButtons)
                    { 
                        equation = "log10(" + value + ")";
                    }
                    else
                    {
                        equation = "ln(" + value + ")";
                    }
                    txtEquation.Text = MathFunctions.ProcessResult(equation).ToString();
                }
            }
        }

        private void btnExp_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;
            double value;

            if (!String.IsNullOrEmpty(equation))
            {
                value = MathFunctions.ProcessResult(equation);

                if (!alternateButtons) { 
                    if (value != 0)
                    {
                        equation = "exp(" + value + ")";

                        txtEquation.Text = MathFunctions.ProcessResult(equation).ToString();
                    }
                }
                else
                {
                    txtEquation.Text = MathFunctions.DMS(equation);
                }
            }
        }

        private void btnMod_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;

            if (!String.IsNullOrEmpty(equation))
            {
                if (!alternateButtons) { 
                   if(Char.IsNumber(equation.Last()))
                    {
                        equation += " # ";
                        txtEquation.Text = equation;
                    }
                }
                else
                {
                    txtEquation.Text = MathFunctions.DEG(equation);
                }
            }
        }

        private void btnPI_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;

            if(String.IsNullOrEmpty(equation))
            {
                equation = Math.PI.ToString();
                txtEquation.Text = equation;
            }
            else
            {
                if (!Char.IsNumber(equation.Last()))
                {
                    equation += Math.PI;
                    txtEquation.Text = equation;
                }
            }
        }

        private void btnFactorial_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;
            double value;

            if(!String.IsNullOrEmpty(equation))
            {
                value = MathFunctions.ProcessResult(equation);

                equation = value + "!";
                value = MathFunctions.ProcessResult(equation);

                txtEquation.Text = value.ToString();
            }
        }

        private void btnOpeningParenthesis_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;

            equation += "(";

            txtEquation.Text = equation;
        }

        private void btnClosingParenthesis_Click(object sender, RoutedEventArgs e)
        {
            string equation = txtEquation.Text;

            equation += ")";

            txtEquation.Text = equation;
        }

        private void btnAlternateButtons_Click(object sender, RoutedEventArgs e)
        {
            alternateButtons = !alternateButtons;

            if(alternateButtons)
            {
                btnPowerOfTwoMainView.Visibility = Visibility.Hidden;
                btnPowerOfTwoAlternateView.Visibility = Visibility.Visible;

                btnXRaisedToYMainView.Visibility = Visibility.Hidden;
                btnXRaisedToYAlternateView.Visibility = Visibility.Visible;

                btnSinMainView.Visibility = Visibility.Hidden;
                btnSinAlternateView.Visibility = Visibility.Visible;

                btnCosMainView.Visibility = Visibility.Hidden;
                btnCosAlternateView.Visibility = Visibility.Visible;

                btnTanMainView.Visibility = Visibility.Hidden;
                btnTanAlternateView.Visibility = Visibility.Visible;

                btnSqrtMainView.Visibility = Visibility.Hidden;
                btnSqrtAlternateView.Visibility = Visibility.Visible;

                btnTenPowerOfXMainView.Visibility = Visibility.Hidden;
                btnTenPowerOfXAlternateView.Visibility = Visibility.Visible;

                btnLogMainView.Visibility = Visibility.Hidden;
                btnLogAlternateView.Visibility = Visibility.Visible;

                btnExpMainView.Visibility = Visibility.Hidden;
                btnExpAlternateView.Visibility = Visibility.Visible;

                btnModMainView.Visibility = Visibility.Hidden;
                btnModAlternateView.Visibility = Visibility.Visible;
            }
            else
            {
                btnPowerOfTwoMainView.Visibility = Visibility.Visible;
                btnPowerOfTwoAlternateView.Visibility = Visibility.Hidden;

                btnXRaisedToYMainView.Visibility = Visibility.Visible;
                btnXRaisedToYAlternateView.Visibility = Visibility.Hidden;

                btnSinMainView.Visibility = Visibility.Visible;
                btnSinAlternateView.Visibility = Visibility.Hidden;

                btnCosMainView.Visibility = Visibility.Visible;
                btnCosAlternateView.Visibility = Visibility.Hidden;

                btnTanMainView.Visibility = Visibility.Visible;
                btnTanAlternateView.Visibility = Visibility.Hidden;

                btnSqrtMainView.Visibility = Visibility.Visible;
                btnSqrtAlternateView.Visibility = Visibility.Hidden;

                btnTenPowerOfXMainView.Visibility = Visibility.Visible;
                btnTenPowerOfXAlternateView.Visibility = Visibility.Hidden;

                btnLogMainView.Visibility = Visibility.Visible;
                btnLogAlternateView.Visibility = Visibility.Hidden;

                btnExpMainView.Visibility = Visibility.Visible;
                btnExpAlternateView.Visibility = Visibility.Hidden;

                btnModMainView.Visibility = Visibility.Visible;
                btnModAlternateView.Visibility = Visibility.Hidden;
            }
        }

        private void menuDefault_Click(object sender, RoutedEventArgs e)
        {
            defaultCalcGrid.Visibility = Visibility.Visible;
            scientificCalcGrid.Visibility = Visibility.Hidden;
            txtEquation.Text = "";
        }

        private void menuScientific_Click(object sender, RoutedEventArgs e)
        {
            defaultCalcGrid.Visibility = Visibility.Hidden;
            scientificCalcGrid.Visibility = Visibility.Visible;
            txtEquation.Text = "";
        }
    }
}
