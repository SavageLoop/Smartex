﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartex2.ViewModel;
using Xamarin.Forms;

namespace Smartex2
{
    public partial class MainPage : ContentPage
    {
        private MainVM viewModel;
        public MainPage()
        {
            InitializeComponent();
            viewModel = new MainVM();
            BindingContext = viewModel;
        }
    }
}