///Lab 4 Week 4(Graded Assignment)    
/// File Name: Lab_Week4_GradedAssignment_Lab1
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Akola
///
///This is a GUI program that takes in first and last name. The program should then create a new string
/// that contains the full name in pig latin with the first letter capitalized for the first and last name
/// only the pig latin rule of moving the first letter 
/// to the end of the word and adding "ay" to the end.The pig latin name to the screen is outputted.





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


namespace Lab_1
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

        private void pigLatinButton_Click(object sender, RoutedEventArgs e)
        {
            String FirstName = "Samuel", LastName = "Peppetta";
            String pigLatinFirstName, pigLatinLastName;


            FirstName = FirstName.ToLower();
            LastName = LastName.ToLower();

            pigLatinFirstName = FirstName.Substring(1, FirstName.Length - 1) + FirstName.Substring(0, 1) + "ay";

            pigLatinFirstName = pigLatinFirstName.Substring(0, 1).ToUpper() + pigLatinFirstName.Substring(1, pigLatinFirstName.Length - 1);

            pigLatinLastName = LastName.Substring(1, LastName.Length - 1) + LastName.Substring(0, 1) + "ay";

            pigLatinLastName = pigLatinLastName.Substring(0, 1).ToUpper() + pigLatinLastName.Substring(1, pigLatinLastName.Length - 1);


            MessageBox.Show("Your name in pig Latin is " + pigLatinFirstName + "" + pigLatinLastName);

        }
    }
}
