﻿using FitBody.Views;
using FitBody.Views.Employee;

namespace FitBody
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(CreateCustomer), typeof(CreateCustomer));
            Routing.RegisterRoute(nameof(CreateCustomerDetails), typeof(CreateCustomerDetails));
            Routing.RegisterRoute(nameof(LoginEmployee), typeof(LoginEmployee));
            Routing.RegisterRoute(nameof(EmployeePage), typeof(EmployeePage));
            Routing.RegisterRoute(nameof(EmployeManager),typeof(EmployeManager));
            Routing.RegisterRoute(nameof(EMadduser), typeof(EMadduser));

        }
    }
}
