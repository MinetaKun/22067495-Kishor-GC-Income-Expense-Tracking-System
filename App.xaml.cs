﻿namespace _22067495_Kishor_GC_Income_Expense_Tracking_App;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new MainPage()) { Title = "22067495-Kishor-GC-Income-Expense-Tracking-App" };
    }
}