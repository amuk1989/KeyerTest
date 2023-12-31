﻿using System.Configuration;
using System.Data;
using System.Windows;
using Grace.DependencyInjection;
using KeyerTest.Di;

namespace KeyerTest;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        DiInitializer.DiInitialize();
    }
}