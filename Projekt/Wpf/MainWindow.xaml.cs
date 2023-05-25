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


        /// <summary>
        /// This function inserts data to the database. n parameter is the id of book from database
        /// </summary>
        /// <param name="n"></param>

        public void Insert(int n)
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


            try
            {
                entities.Readers.Add(readers);
                entities.Rentals.Add(rentals);

                entities.SaveChanges();

                MessageBox.Show("Success");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Błąd " + ex.Message);
            }
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

        /// <summary>
        /// After clicking displays datagrid with rentals data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// After clicking displays datagrid with data from readers table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Displays data from authors table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutAuthors(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Authors", con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("Authors");
            adapter.Fill(dt);
            authors.ItemsSource = dt.DefaultView;


            adapter.Update(dt);

            con.Close();
        }


        /// <summary>
        /// Opens the new window, and closes the current
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void horrors_Selected(object sender, RoutedEventArgs e)
        {
            Horrors window = new Horrors();
            this.Close();
            window.Show();
        }

        /// <summary>
        /// This button resets to default settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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



        /// Settings, for changing background and foreground
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

        /// -----------
        private void AboutProgram(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This application allows to rent the books. You need to insert your information and choose the book you want to rent." +
                "Rents are for one month");
        }


        /// <summary>
        /// When other characters than letters are inserted it changes the foreground to red
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstname_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool isLetters = firstname.Text.Any(x => !char.IsLetter(x));

            if (isLetters)
                firstname.Foreground = Brushes.Red;
            else
                firstname.Foreground = Brushes.Green;
        }

        /// <summary>
        /// When other characters than letters are inserted it changes the foreground to red
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void surname_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool isLetters = surname.Text.Any(x => !char.IsLetter(x));

            if (isLetters)
                surname.Foreground = Brushes.Red;
            else
                surname.Foreground = Brushes.Green;
        }


        /// <summary>
        /// When other characters than digits are inserted it changes the foreground to red
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// closes the current window and open new
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fantasy_Selected(object sender, RoutedEventArgs e)
        {
            Fantasy fantasy = new Fantasy();
            this.Close();
            fantasy.Show();
        }

        /// <summary>
        /// Changes the format of date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyType == typeof(System.DateTime))
                (e.Column as DataGridTextColumn).Binding.StringFormat = "dd/MM/yyyy";
        }

        private void Sci_Selected(object sender, RoutedEventArgs e)
        {
            SciFi sci = new SciFi();
            this.Close();
            sci.Show();
        }
    }
}
