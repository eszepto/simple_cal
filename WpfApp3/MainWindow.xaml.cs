using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<CalculationLog> calLog = new List<CalculationLog>();
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            float valueX = float.Parse(textBox_x.Text);
            float valueY = float.Parse(textBox_y.Text);
            float valueResult = valueX + valueY;
            textBox_result.Text = valueResult.ToString();

            calLog.Add(new CalculationLog { X = textBox_x.Text, Op = "+", Y = textBox_y.Text, Result=valueResult});
            
            historyBox.ItemsSource = null;
            historyBox.ItemsSource = calLog;
            
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            float valueX = float.Parse(textBox_x.Text);
            float valueY = float.Parse(textBox_y.Text);
            float valueResult = valueX - valueY;
            textBox_result.Text = valueResult.ToString();

            calLog.Add(new CalculationLog { X = textBox_x.Text, Op = "-", Y = textBox_y.Text, Result = valueResult });

            historyBox.ItemsSource = null;
            historyBox.ItemsSource = calLog;
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            float valueX = float.Parse(textBox_x.Text);
            float valueY = float.Parse(textBox_y.Text);
            float valueResult = valueX * valueY;
            textBox_result.Text = valueResult.ToString();

            calLog.Add(new CalculationLog { X = textBox_x.Text, Op = "×", Y = textBox_y.Text, Result = valueResult });
            historyBox.ItemsSource = null;
            historyBox.ItemsSource = calLog;
        }

        private void ButtonDevide_Click(object sender, RoutedEventArgs e)
        {
            float valueX = float.Parse(textBox_x.Text);
            float valueY = float.Parse(textBox_y.Text);
            float valueResult = valueX / valueY;
            textBox_result.Text = valueResult.ToString();

            calLog.Add(new CalculationLog { X = textBox_x.Text, Op = "÷", Y = textBox_y.Text, Result = valueResult });

            historyBox.ItemsSource = null;
            historyBox.ItemsSource = calLog;
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            textBox_x.Text = "";
            textBox_y.Text = "";
            textBox_result.Text = "";
        }

        private void ButtonHistoryClear_Click(object sender, RoutedEventArgs e)
        {
            calLog = new List<CalculationLog>();
            historyBox.ItemsSource = null;
            historyBox.ItemsSource = calLog;

        }
    }
    public class CalculationLog
    {
        public string X { get; set; }

        public string Op { get; set; }

        public string Y { get; set; }

        public string Statement
        {
            get
            {
                return String.Format("{0}  {1}  {2}", this.X, this.Op, this.Y);
            }
        }

        public float Result { get; set; }
    }
}
