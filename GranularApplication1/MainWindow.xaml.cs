using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace GranularApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Action onMightyButton1Click;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MightyButton1_Click(object sender, RoutedEventArgs e)
        {
            if (onMightyButton1Click != null)
                onMightyButton1Click();
        }

        public void SetOnMightyButton1Click(Action OnMightyButton1Click)
        {
            onMightyButton1Click = OnMightyButton1Click;
        }
    }
}
