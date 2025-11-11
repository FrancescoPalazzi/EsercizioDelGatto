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
using System.Windows.Shapes;
using Application.UseCases;

namespace WpfConsole
{
    /// <summary>
    /// Logica di interazione per AddCat.xaml
    /// </summary>
    public partial class AddCat : Window
    {
        public AddCat(CatService catService)
        {
            InitializeComponent();
        }

        private void AddCat1_Click(object sender, RoutedEventArgs e)
        {
            string name = TxtBoxName.Text;
            string breed = Breed.Text;
            bool sex = false;
            if (M.IsChecked == true)
            {
                sex = true;
            }
            else 
            {
                sex = false;
            }
            string description = Description.Text;     
            
            DateOnly birth = DateOnly.FromDateTime(Born.SelectedDate.Value);
            DateOnly arrived = DateOnly.FromDateTime(Arrived.SelectedDate.Value);

        }

        private void F_Checked(object sender, RoutedEventArgs e)
        {
            M.IsChecked = false;
        }

        private void M_Checked(object sender, RoutedEventArgs e)
        {
            F.IsChecked = false;
        }
    }
}
