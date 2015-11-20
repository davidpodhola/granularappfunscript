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
        public MainWindow()
        {
            InitializeComponent();
        }

#if WEB
        [System.Runtime.CompilerServices.InlineCode("handleButtonClick({sender}, {e})")]
        private static void HandleButtonClick(object sender, RoutedEventArgs e)
        {
            //
        }
#else
        private static void HandleButtonClick(object sender, RoutedEventArgs e)
        {
        }
#endif

        private void MightyButton1_Click(object sender, RoutedEventArgs e)
        {
            HandleButtonClick(sender, e);
        }

    }
}
