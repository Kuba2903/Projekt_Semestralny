using System;
using System.Collections.Generic;
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
            data.Text = string.Empty;
        }
        int reader_id = 1;
        private void Button_Click1(object sender, RoutedEventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Readers values (@first_name, @last_name,@phone_number,@return_date,@book_id)", con);
            cmd.Parameters.AddWithValue("@first_name", firstname.Text);
            cmd.Parameters.AddWithValue("@last_name", surname.Text);
            cmd.Parameters.AddWithValue("@phone_number", phone.Text);
            cmd.Parameters.AddWithValue("@return_date", data.Text);
            cmd.Parameters.AddWithValue("@book_id", 1);

            SqlCommand cmd2 = new SqlCommand("Insert into Rentals values (@book_id, @reader_id)", con);
            cmd2.Parameters.AddWithValue("@book_id", 1);
            cmd2.Parameters.AddWithValue("@reader_id", reader_id);


            reader_id++;
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
            Empty_strings();
            MessageBox.Show("Success");
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Readers values (@first_name, @last_name,@phone_number,@return_date,@book_id)", con);
            cmd.Parameters.AddWithValue("@first_name", firstname.Text);
            cmd.Parameters.AddWithValue("@last_name", surname.Text);
            cmd.Parameters.AddWithValue("@phone_number", phone.Text);
            cmd.Parameters.AddWithValue("@return_date", data.Text);
            cmd.Parameters.AddWithValue("@book_id", 2);

            SqlCommand cmd2 = new SqlCommand("Insert into Rentals values (@book_id, @reader_id)", con);
            cmd2.Parameters.AddWithValue("@book_id", 2);
            cmd2.Parameters.AddWithValue("@reader_id", reader_id);
            reader_id++;
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
            Empty_strings();
            MessageBox.Show("Success");
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Readers values (@first_name, @last_name,@phone_number,@return_date,@book_id)", con);
            cmd.Parameters.AddWithValue("@first_name", firstname.Text);
            cmd.Parameters.AddWithValue("@last_name", surname.Text);
            cmd.Parameters.AddWithValue("@phone_number", phone.Text);
            cmd.Parameters.AddWithValue("@return_date", data.Text);
            cmd.Parameters.AddWithValue("@book_id", 3);

            SqlCommand cmd2 = new SqlCommand("Insert into Rentals values (@book_id, @reader_id)", con);
            cmd2.Parameters.AddWithValue("@book_id", 3);
            cmd2.Parameters.AddWithValue("@reader_id", reader_id);
            reader_id++;
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
            Empty_strings();
            MessageBox.Show("Success");
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Readers values (@first_name, @last_name,@phone_number,@return_date,@book_id)", con);
            cmd.Parameters.AddWithValue("@first_name", firstname.Text);
            cmd.Parameters.AddWithValue("@last_name", surname.Text);
            cmd.Parameters.AddWithValue("@phone_number", phone.Text);
            cmd.Parameters.AddWithValue("@return_date", data.Text);
            cmd.Parameters.AddWithValue("@book_id", 4);

            SqlCommand cmd2 = new SqlCommand("Insert into Rentals values (@book_id, @reader_id)", con);
            cmd2.Parameters.AddWithValue("@book_id", 4);
            cmd2.Parameters.AddWithValue("@reader_id", reader_id);
            reader_id++;
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
            Empty_strings();
            MessageBox.Show("Success");
        }

        private void horrors_Selected(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(new Uri("Authors.xaml", UriKind.Relative));
        }
    }
}
