﻿using AlpatovPr15.ViewModels;
using AlpatovPr15.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AlpatovPr15
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
