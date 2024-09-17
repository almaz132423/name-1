using System;
using System.Collections;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ArrayList arrayList = new ArrayList() {1,2,3,4,5 };

        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Add(tb1.Text);
            Load();
        }
        
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(tb1.Text);
            Load();


        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Load();
        }

        void Load()
        {
            list1.Items.Clear();

            foreach (var item in arrayList)
            {
                list1.Items.Add(item);
            }
        }

        
    }
}
