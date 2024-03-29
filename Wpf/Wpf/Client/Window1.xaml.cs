﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using StockProvider;
using System.Collections.ObjectModel;

namespace Client
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        RandomQuoteSource quoteSource = new RandomQuoteSource();
        private WatchListViewModel vm;
        
        public Window1()
        {
            InitializeComponent();
            this.vm = new WatchListViewModel(this.quoteSource);
            this.DataContext = this.vm;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            vm.Subscribe();
        }
    }
}
