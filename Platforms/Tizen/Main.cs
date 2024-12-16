using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace _22067495_Kishor_GC_Income_Expense_Tracking_App;

class Program : MauiApplication
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    static void Main(string[] args)
    {
        var app = new Program();
        app.Run(args);
    }
}