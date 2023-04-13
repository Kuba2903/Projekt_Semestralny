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
    /// Interaction logic for Authors.xaml
    /// </summary>
    public partial class Authors : Page
    {
        public Authors()
        {
            InitializeComponent();
        }

        private void EmptyStrings()
        {
            firstname.Text = string.Empty;
            surname.Text = string.Empty;
            date.Text = string.Empty;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Authors values (@first_name, @surname,@date_of_birth)", con);
            cmd.Parameters.AddWithValue("@first_name", firstname.Text);
            cmd.Parameters.AddWithValue("@surname", surname.Text);
            cmd.Parameters.AddWithValue("@date_of_birth", date.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Success");
            EmptyStrings();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Authors Set first_name = @first_name, surname = @surname,date_of_birth = @date_of_birth where author_id = @author_id", con);
            cmd.Parameters.AddWithValue("@first_name", firstname.Text);
            cmd.Parameters.AddWithValue("@surname", surname.Text);
            cmd.Parameters.AddWithValue("@date_of_birth", date.Text);
            cmd.Parameters.AddWithValue("@author_id",int.Parse( idT.Text));

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Success");
            EmptyStrings();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HP;Initial Catalog=Book_Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Authors Where author_id = @author_id", con);
            cmd.Parameters.AddWithValue("@author_id", int.Parse(idT.Text));

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Success");
            EmptyStrings();
        }
    }
}
