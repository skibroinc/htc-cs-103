﻿using System;
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

namespace no
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

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void barkbutton_Click(object sender, RoutedEventArgs e)
        {
            //string dogname = namebox.Text;
            //dog dog = new dog();
            //dog.name = dogname;
            //dog.sayname();

            duck duck = new duck();
            //duck.age = 21;
            //duck.name = "hornky";
            //duck.attackdmg = 69;

        }

        private void buttonbark_Click(object sender, RoutedEventArgs e)
        {
            dog dog = new dog();
            dog.bork();
        }

    }
}
