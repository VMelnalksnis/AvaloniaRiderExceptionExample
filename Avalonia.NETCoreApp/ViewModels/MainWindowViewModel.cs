using System.Collections.ObjectModel;

using Avalonia.NETCoreApp.Web.Data;

namespace Avalonia.NETCoreApp.ViewModels
{
	public sealed class MainWindowViewModel : ViewModelBase
	{
		private ObservableCollection<Model> _values = null!;

		public MainWindowViewModel()
			: this(new Repository())
		{
		}

		private MainWindowViewModel(IRepository repository)
		{
			Values = new(repository.GetDataAsync().Result);
		}

		public ObservableCollection<Model> Values
		{
			get => _values;
			set
			{
				if (Equals(value, _values)) return;
				_values = value;
				OnPropertyChanged();
			}
		}
	}
}
