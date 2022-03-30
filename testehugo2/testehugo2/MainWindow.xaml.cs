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

namespace testehugo2
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

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!this.IsLoaded)
                return;

            TextVisual1.Text = TextBox1.Text;

            RefreshText();
        }

        private void RefreshText()
        {
            
            TextVisual1.BeginInit();
            TextVisual1.Text = TextBox1.Text;
            TextVisual1.EndInit();

        }

    }
}
