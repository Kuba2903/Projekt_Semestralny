using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
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

namespace Wpf
{
    /// <summary>
    /// Interaction logic for Horrors.xaml
    /// </summary>
    public partial class Horrors : Window
    {
        public Horrors()
        {
            InitializeComponent();
            MainWindow window = new MainWindow();
            if (window.Background == Brushes.White)
                this.Background = Brushes.White;
            else if (window.Background == Brushes.Green)
                this.Background = Brushes.Green;
            else if (window.Background == Brushes.Red)
                this.Background = Brushes.Red;
            else
                this.Background = Brushes.Blue;
        }

        private void rbChecked(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.Show();
        }

        private void Books_Click(object sender, RoutedEventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Books where genre = 'Horror'",con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("Books");
            adapter.Fill(dt);

            dataGridBooks.Visibility = Visibility.Visible;
            dataGridBooks.ItemsSource = dt.DefaultView;
            

            adapter.Update(dt);

            con.Close();
        }

        private void Authors_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridAuthors.IsVisible)
                dataGridAuthors.Visibility = Visibility.Hidden;

            SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Authors", con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("Authors");
            adapter.Fill(dt);

            dataGridAuthors.Visibility = Visibility.Visible;
            dataGridAuthors.ItemsSource = dt.DefaultView;

            adapter.Update(dt);

            con.Close();
        }

        private void home_Selected(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.Show();
        }

        DateTime date = DateTime.Now;


        private void Empty_strings()
        {
            firstname.Text = string.Empty;
            surname.Text = string.Empty;
            phone.Text = string.Empty;
        }
        private void Book0_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Readers values (@first_name, @last_name,@phone_number,@return_date,@book_id)", con);
            cmd.Parameters.AddWithValue("@first_name", firstname.Text);
            cmd.Parameters.AddWithValue("@last_name", surname.Text);
            cmd.Parameters.AddWithValue("@phone_number", phone.Text);
            cmd.Parameters.AddWithValue("@return_date", date.AddMonths(1));
            cmd.Parameters.AddWithValue("@book_id", 7);

            SqlCommand cmd2 = new SqlCommand("Insert into Rentals values (@book_id)", con);
            cmd2.Parameters.AddWithValue("@book_id", 7);

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
            Empty_strings();
            MessageBox.Show("Success");
        }

        private void Book1_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Readers values (@first_name, @last_name,@phone_number,@return_date,@book_id)", con);
            cmd.Parameters.AddWithValue("@first_name", firstname.Text);
            cmd.Parameters.AddWithValue("@last_name", surname.Text);
            cmd.Parameters.AddWithValue("@phone_number", phone.Text);
            cmd.Parameters.AddWithValue("@return_date", date.AddMonths(1));
            cmd.Parameters.AddWithValue("@book_id", 8);

            SqlCommand cmd2 = new SqlCommand("Insert into Rentals values (@book_id)", con);
            cmd2.Parameters.AddWithValue("@book_id", 8);

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
            Empty_strings();
            MessageBox.Show("Success");
        }

        private void Book2_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Readers values (@first_name, @last_name,@phone_number,@return_date,@book_id)", con);
            cmd.Parameters.AddWithValue("@first_name", firstname.Text);
            cmd.Parameters.AddWithValue("@last_name", surname.Text);
            cmd.Parameters.AddWithValue("@phone_number", phone.Text);
            cmd.Parameters.AddWithValue("@return_date", date.AddMonths(1));
            cmd.Parameters.AddWithValue("@book_id", 9);

            SqlCommand cmd2 = new SqlCommand("Insert into Rentals values (@book_id)", con);
            cmd2.Parameters.AddWithValue("@book_id", 9);

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
            Empty_strings();
            MessageBox.Show("Success");
        }

        private void btnReset(object sender, RoutedEventArgs e)
        {
            firstname.Text = string.Empty;
            surname.Text = string.Empty;
            phone.Text = string.Empty;

            dataGridBooks .Visibility = Visibility.Hidden;
            dataGridAuthors .Visibility = Visibility.Hidden;
        }
    }
}
