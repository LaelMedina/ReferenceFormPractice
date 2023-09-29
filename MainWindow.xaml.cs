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

using System.IO;
using ReferenceForm.Classes;
using System.Linq.Expressions;

namespace ReferenceForm;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    User myUser = new();


    private void btnLogIn_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            myUser.ReferenceId = int.Parse(txtIdReference.Text);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}", "Warning");
        }
        
        if (!string.IsNullOrEmpty(txtIdentification.Text) &&
            !string.IsNullOrEmpty(txtName.Text) &&
            !string.IsNullOrEmpty(txtLastName.Text) &&
            !string.IsNullOrEmpty(txtEmail.Text) &&
            !string.IsNullOrEmpty(txtAddress.Text) &&
            !string.IsNullOrEmpty(txtPhone.Text) &&
            !string.IsNullOrEmpty(txtModifiedDate.Text) &&
            !string.IsNullOrEmpty(txtDeletedDate.Text))
        {
            myUser.Identification = txtIdentification.Text;

            myUser.Name = txtName.Text;

            myUser.LastName = txtLastName.Text;

            myUser.Email = txtEmail.Text;

            myUser.Address = txtAddress.Text;

            myUser.Phone = txtPhone.Text;

            myUser.ModifiedDate = txtModifiedDate.Text;

            myUser.DeletedDate = txtDeletedDate.Text;

            if (rbnMale.IsChecked == true)
            {
                myUser.Gender = "Male";
            }
            else
            {
                myUser.Gender = "Female";
            }

        }
        else
        {
            MessageBox.Show("The field cannot be empty or null", "Invalid Input");
        }

        Serialize(myUser);

        btnSeeInfo.IsEnabled = true;

    }

    private static void Serialize(User myUser)
    {
        string path = @"C:\Users\medin\OneDrive\Documentos\Coding\WPF\ReferenceForm\ReferenceForm\Files\FormInfo.txt";

        if (File.Exists(path))
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(myUser.ToString());
            }
        }
    }

    private void BtnSeeInfo_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show(
                $"Reference Id: \t{myUser.ReferenceId} \n" +
                $"Identification: \t{myUser.Identification} \n" +
                $"Name: \t\t{myUser.Name} \n" +
                $"Last Name: \t{myUser.LastName} \n" +
                $"Gender: \t\t{myUser.Gender} \n" +
                $"Phone: \t\t{myUser.Phone} \n" +
                $"Email: \t\t{myUser.Email} \n" +
                $"Address: \t\t{myUser.Address} \n" +
                $"Created Date: \t{myUser.CreatedDate} \n" +
                $"Modified Date: \t{myUser.ModifiedDate} \n" +
                $"Deleted Date: \t{myUser.DeletedDate} \n"
           );
    }
}


//notes:
//Study: Using statement