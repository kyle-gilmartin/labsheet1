using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace labsheet1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Band> bandinfo;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var e1 = new Band()
            {
                Year = new DateTime(2019, 6, 30),
                BandName = "Travis scott",
                Members = "kyle"
                

            };
            var e2 = new Band()
            {
                Year = new DateTime(2019, 6, 30),
                BandName = "",
                Members = "mark"

            };
            var e3 = new Band()
            {
                Year = new DateTime(2019, 6, 30),
                BandName = "Travel",
                Members = "bob"

            };
            bandinfo = new ObservableCollection<Band>();
            bandinfo.Add(e1);
            bandinfo.Add(e2);
            bandinfo.Add(e3);

            // Display list in listbox
            Left_textBox.ItemsSource = bandinfo;
        }
    }
}
