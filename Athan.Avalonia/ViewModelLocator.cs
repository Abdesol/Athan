﻿using Athan.Avalonia.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Athan.Avalonia;

// To feed the design time property of each view that needs it
internal sealed class ViewModelLocator
{
    public ShellViewModel ShellViewModel => App.Current.Services.GetRequiredService<ShellViewModel>();
}