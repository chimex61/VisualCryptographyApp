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

namespace VisualCryptographyApp
{
    /// <summary>
    /// Interaction logic for StartUserControl.xaml
    /// </summary>
    public partial class StartUserControl : UserControl
    {

        public enum ModeEnum { Create, Recreate };
        private ModeEnum mode;

        public StartUserControl()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            mode = ModeEnum.Create;
            MainGrid.Children.Add(new ModelSelectUserControl(mode));
        }

        private void RecreateButton_Click(object sender, RoutedEventArgs e)
        {
            mode = ModeEnum.Recreate;
            MainGrid.Children.Add(new ModelSelectUserControl(mode));
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            MainGrid.Children.Add(new HelpUserControl());
        }

    }
}