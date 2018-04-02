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

namespace SeeSharp_Apptionary
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

        private void Window_Deactivated(object wa, EventArgs e)
        {
           // this.Show();
            this.Deactivated += (sender, args) => { this.Hide(); };

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new PagingContext())
            {
                int id = 1;
                var t = "csarp";
                var c = "this is a fucking test for button";

                var page = new Page {
                    PageId = id,
                    Title = t,
                    Content = c 
                };

                db.Pages.Add(page);
                db.SaveChanges();
             
                

            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) {
                using (var db = new PagingContext())
                {
                    int id = 1;
                    var t = "torma";
                    var c = "this is a not a fucking test for text";

                    var page = new Page
                    {
                        PageId = id,
                        Title = t,
                        Content = c
                    };

                    db.Pages.Add(page);
                    db.SaveChanges();



                }

            }
        }
    }
}
