using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.NETCoreApp.ViewModels;
using Avalonia.NETCoreApp.Views;

namespace Avalonia.NETCoreApp
{
	public sealed class App : Application
	{
		public override void Initialize()
		{
			AvaloniaXamlLoader.Load(this);
		}

		public override void OnFrameworkInitializationCompleted()
		{
			if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
			{
				desktop.MainWindow = new MainWindow { DataContext = new MainWindowViewModel() };
			}

			base.OnFrameworkInitializationCompleted();
		}
	}
}
