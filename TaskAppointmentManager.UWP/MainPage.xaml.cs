﻿using TaskAppointmentManager.UWP.Dialogs;
using TaskAppointmentManager.UWP.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TaskAppointmentManager.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            DataContext = new MainViewModel();
        }

        private async void AddNew_Click(object sender, RoutedEventArgs e)
        {
            await (DataContext as MainViewModel).AddItem();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainViewModel).DeleteItem();
        }

        private async void Edit_Click(object sender, RoutedEventArgs e)
        {
            await (DataContext as MainViewModel).EditItem();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainViewModel).RefreshList();
        }

        private async void Save_Load_Click(object sender, RoutedEventArgs e)
        {
            await (DataContext as MainViewModel).SaveOrLoadItem();
        }

        private void Show_Incomplete_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainViewModel).ShowIncompleteTasks();
        }

        private void Priority_Sort_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainViewModel).SortByPriority();
        }
    }
}
