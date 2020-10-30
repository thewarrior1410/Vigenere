using System;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Vigenere
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// 
    /// Variablen Clear (Binding zu clear_inp); Code (Binding zu code_inp); Password (Binding zu password)
    /// Variable Mode -> Switch_Mode durch button_mode
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        /*
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string name = txtBox_name.Text;
            
            if (RadioButton1.IsChecked == false && RadioButton2.IsChecked == false)
            {
                MessageBox.Show("No greeting selected :(");
                return;
            }

            if (name == "")
            {
                MessageBox.Show("Enter a name first");
                return;
            }


            if (RadioButton1.IsChecked == true)
            {
                MessageBox.Show("Hello " + name + "!");
            }
            else if (RadioButton2.IsChecked == true)
            {
                MessageBox.Show("Goodbye " + name + "!");
            }

        }
        */


        private int _mode;
        public int Mode
        {
            get { return _mode; }
            set
            {
                if (_mode != value)
                {
                    _mode = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _clear;
        public string Clear
        {
            get { return _clear; }
            set
            {
                if (_clear != value)
                {
                    _clear = value;
                    OnPropertyChanged();

                    Info_Label.Content = "Info: Changed clear!";
                    System.Console.Out.WriteLine("Clear: " + _clear);
                }
            }
        }

        private string _code;
        public string Code
        {
            get { return _code; }
            set
            {
                if (_code != value)
                {
                    _code = value;
                    OnPropertyChanged();

                    Info_Label.Content = "Info: Changed code";
                    System.Console.Out.WriteLine("Code: "+_code);
                }
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                    Info_Label.Content = "Info: Changed password";
                }
            }
        }

        private void Switch_Mode(object sender, RoutedEventArgs e)
        {

            if(Mode == 0)
            {
                Code = code_out.Content.ToString();
                clear_inp.Visibility = Visibility.Collapsed;
                clear_out.Visibility = Visibility.Visible;

                code_inp.Visibility = Visibility.Visible;
                code_out.Visibility = Visibility.Collapsed;

                headline.Content = "Vigenere Decode";
            }
            else if(Mode == 1)
            {
                Clear = clear_out.Content.ToString();
                clear_inp.Visibility = Visibility.Visible;
                clear_out.Visibility = Visibility.Collapsed;

                code_inp.Visibility = Visibility.Collapsed;
                code_out.Visibility = Visibility.Visible;

                headline.Content = "Vigenere Encode";
            }

            int new_mode = 1 - Mode;
            Mode = new_mode;
            Info_Label.Content = "Info: Mode " + new_mode;

        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

    }
}
