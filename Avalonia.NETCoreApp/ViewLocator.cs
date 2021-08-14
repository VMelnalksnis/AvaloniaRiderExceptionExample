using System;

using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.NETCoreApp.ViewModels;

namespace Avalonia.NETCoreApp
{
	public sealed class ViewLocator : IDataTemplate
	{
		public bool SupportsRecycling => false;

		/// <inheritdoc />
		public IControl Build(object data)
		{
			var name = data.GetType().FullName!.Replace("ViewModel", "View");
			var type = Type.GetType(name);

			if (type != null)
			{
				return (Control)Activator.CreateInstance(type)!;
			}

			return new TextBlock { Text = $"Not Found: {name}" };
		}

		/// <inheritdoc />
		public bool Match(object data) => data is ViewModelBase;
	}
}
