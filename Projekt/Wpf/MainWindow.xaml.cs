using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Wpf
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

        private void Empty_strings()
        {
            firstname.Text = string.Empty;
            surname.Text = string.Empty;
            phone.Text = string.Empty;
        }
        DateTime date = DateTime.Now;


        private void Insert(int n)
        {
            Book_LibraryEntities entities = new Book_LibraryEntities();


            Readers readers = new Readers()
            {
                first_name = firstname.Text,
                last_name = surname.Text,
                phone_number = phone.Text,
                return_date = date.AddMonths(1),
                book_id = n,
            };
            int k = 0;
            k = readers.reader_id;
            Rentals rentals = new Rentals()
            {
                book_id = n,
                reader_id = k,
            };

            entities.Readers.Add(readers);
            entities.Rentals.Add(rentals);

            entities.SaveChanges();

            MessageBox.Show("Success");
            /*catch(Exception ex)
            {
                using(var context = new Book_LibraryEntities())
                {
                    context.Database.ExecuteSqlCommand(@"DBCC CHECKIDENT ('[Readers]', RESEED, 0);");
                }
                MessageBox.Show("Błąd " + ex.Message);
            }*/
        }

        private void Book0_Click(object sender, RoutedEventArgs e)
        {
            Insert(3);
        }

        private void Book1_Click(object sender, RoutedEventArgs e)
        {
            Insert(2);
        }

        private void Book2_Click(object sender, RoutedEventArgs e)
        {
            Insert(4);
        }

        private void Rentals_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Rentals", con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("Rentals");
            adapter.Fill(dt);

            dataGridRentals.Visibility = Visibility.Visible;
            dataGridRentals.ItemsSource = dt.DefaultView;


            adapter.Update(dt);

            con.Close();
        }

        private void Readers_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Readers", con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("Readers");
            adapter.Fill(dt);

            dataGridReaders.Visibility = Visibility.Visible;
            dataGridReaders.ItemsSource = dt.DefaultView;


            adapter.Update(dt);

            con.Close();
        }

        private void horrors_Selected(object sender, RoutedEventArgs e)
        {
            Horrors window = new Horrors();
            this.Close();
            window.Show();
        }

        private void btnReset(object sender, RoutedEventArgs e)
        {
            Empty_strings();

            dataGridReaders.Visibility = Visibility.Hidden;
            dataGridRentals.Visibility = Visibility.Hidden;

            DefaultBackground(null, e);
            blackForeground(null, e);
            this.FontWeight = FontWeights.Regular;
            bold.IsChecked = false;
        }


        private void GreenBackground(object sender, RoutedEventArgs e)
        {
            window.Background = Brushes.LightGreen;
            green.IsChecked = true;
            this.@default.IsChecked = false;
            blue.IsChecked = false;
        }

        private void BlueBackground(object sender, RoutedEventArgs e)
        {
            window.Background = Brushes.LightBlue;
            blue.IsChecked = true;
            this.@default.IsChecked = false;
            green.IsChecked = false;
        }


        private void DefaultBackground(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Color.FromArgb(0xFF, 0xD1, 0xD9, 0xDC));

            window.Background = brush;
            this.@default.IsChecked = true;
            green.IsChecked = false;
            blue.IsChecked = false;
        }

        private void ItemBold(object sender, RoutedEventArgs e)
        {
            if (!bold.IsChecked)
            {
                this.FontWeight = FontWeights.Bold;
                bold.IsChecked = true;
            }
            else
            {
                this.FontWeight = FontWeights.Regular;
                bold.IsChecked = false;
            }
        }

        private void blueForeground(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Blue);

            foreach (UIElement child in window.Children)
            {
                if (child is Control)
                {
                    ((Control)child).Foreground = brush;
                }
            }

            blueF.IsChecked = true;
            blackF.IsChecked = false;
            redF.IsChecked = false;
        }

        private void blackForeground(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);

            foreach (UIElement child in window.Children)
            {
                if (child is Control)
                {
                    ((Control)child).Foreground = brush;
                }
            }

            blueF.IsChecked = false;
            blackF.IsChecked = true;
            redF.IsChecked = false;
        }

        private void redForeground(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Red);

            foreach (UIElement child in window.Children)
            {
                if (child is Control)
                {
                    ((Control)child).Foreground = brush;
                }
            }

            blueF.IsChecked = false;
            blackF.IsChecked = false;
            redF.IsChecked = true;
        }


        private void AboutProgram(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Program");
        }

        private void firstname_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool isLetters = firstname.Text.Any(x => !char.IsLetter(x));

            if (isLetters)
                firstname.Foreground = Brushes.Red;
            else
                firstname.Foreground = Brushes.Green;
        }

        private void surname_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool isLetters = surname.Text.Any(x => !char.IsLetter(x));

            if (isLetters)
                surname.Foreground = Brushes.Red;
            else
                surname.Foreground = Brushes.Green;
        }

        private void phone_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool isDigits = phone.Text.Any(x => !char.IsDigit(x));

            if (isDigits)
                phone.Foreground = Brushes.Red;
            else if (!isDigits && phone.Text.Length < 9)
            {
                phone.Foreground = Brushes.Black;
                lblmessage.Visibility = Visibility.Visible;
            }

            else if (!isDigits && phone.Text.Length == 9)
            {
                phone.Foreground = Brushes.Green;
                lblmessage.Visibility = Visibility.Hidden;
            }
        }

    }
}
