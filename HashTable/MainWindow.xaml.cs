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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HashTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;

        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!hashtable.ContainsKey(txtKey.Text))
            {
                hashtable.Add(txtKey.Text, txtValue.Text);
                MessageBox.Show("Add: [\"" + txtKey.Text + "\"] = \"" + txtValue.Text +"\"");
            }
            else
            {
                MessageBox.Show("Key already exists");
            }
            txtKey.Clear();
            txtValue.Clear();
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (hashtable.ContainsKey(txtKey.Text))
            {
                hashtable.Remove(txtKey.Text);
            }
            else
            {
                MessageBox.Show("Not found");
            }
            txtKey.Clear();
            txtValue.Clear();
        }

        private void showBtn_Click(object sender, RoutedEventArgs e)
        {
            if (hashtable.Count == 0)
            {
                MessageBox.Show("null");
                return;
            }

            string result = "";
            foreach (string key in hashtable.Keys)
            {
                result += "[" + key + "] = " + hashtable[key] + "\n";
            }
            MessageBox.Show(result + "Count: " + hashtable.Count);
        }

        private void txtKey_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
