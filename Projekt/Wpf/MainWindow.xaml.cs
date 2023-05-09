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


        private void Book0_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Readers values (@first_name, @last_name,@phone_number,@return_date,@book_id)", con);
                cmd.Parameters.AddWithValue("@first_name", firstname.Text);
                cmd.Parameters.AddWithValue("@last_name", surname.Text);
                cmd.Parameters.AddWithValue("@phone_number", phone.Text);
                cmd.Parameters.AddWithValue("@return_date", date.AddMonths(1));
                cmd.Parameters.AddWithValue("@book_id", 3);

                SqlCommand cmd2 = new SqlCommand("Insert into Rentals values (@book_id)", con);
                cmd2.Parameters.AddWithValue("@book_id", 3);

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
                Empty_strings();
                MessageBox.Show("Success");
            }catch(Exception ex)
            {
                MessageBox.Show("You must enter the proper information!");
            }
        }

        private void Book1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Readers values (@first_name, @last_name,@phone_number,@return_date,@book_id)", con);
                cmd.Parameters.AddWithValue("@first_name", firstname.Text);
                cmd.Parameters.AddWithValue("@last_name", surname.Text);
                cmd.Parameters.AddWithValue("@phone_number", phone.Text);
                cmd.Parameters.AddWithValue("@return_date", date.AddMonths(1));
                cmd.Parameters.AddWithValue("@book_id", 2);

                SqlCommand cmd2 = new SqlCommand("Insert into Rentals values (@book_id)", con);
                cmd2.Parameters.AddWithValue("@book_id", 2);

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
                Empty_strings();
                MessageBox.Show("Success");
            }catch(Exception exception)
            {
                MessageBox.Show("You must enter the proper information!");
            }
        }

        private void Book2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Readers values (@first_name, @last_name,@phone_number,@return_date,@book_id)", con);
                cmd.Parameters.AddWithValue("@first_name", firstname.Text);
                cmd.Parameters.AddWithValue("@last_name", surname.Text);
                cmd.Parameters.AddWithValue("@phone_number", phone.Text);
                cmd.Parameters.AddWithValue("@return_date", date.AddMonths(1));
                cmd.Parameters.AddWithValue("@book_id", 4);

                SqlCommand cmd2 = new SqlCommand("Insert into Rentals values (@book_id)", con);
                cmd2.Parameters.AddWithValue("@book_id", 4);

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
                Empty_strings();
                MessageBox.Show("Success");
            }catch(Exception ex)
            {
                MessageBox.Show("You must enter the proper information!");
            }
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
            firstname.Text = string.Empty;
            surname.Text = string.Empty;
            phone.Text = string.Empty;

            dataGridReaders.Visibility = Visibility.Hidden;
            dataGridRentals.Visibility = Visibility.Hidden;
        }

    }
}
