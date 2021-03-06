﻿using Microsoft.Win32;
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

namespace DiskCleanup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ViewModels.AppViewModel();
        }

        private void bt_PickRRoot_Click(object sender, RoutedEventArgs e)
        {
            PickRoot(tb_rootL.Text);
        }

        private void bt_PickLRoot_Click(object sender, RoutedEventArgs e)
        {
            PickRoot(tb_rootR.Text);
        }

        private void PickRoot(String str)
        {
            var dlg = new OpenFileDialog();
            dlg.InitialDirectory = str;
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true ) {
                string newRootDirSubTreeName = dlg.FileName;
            }
        }

        // Use FileSystemWatcher to handle the situation where stuff is changed in real time outside the application

    }
}
