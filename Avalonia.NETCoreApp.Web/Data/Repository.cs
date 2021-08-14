using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avalonia.NETCoreApp.Web.Data
{
	public class Repository : IRepository
	{
		public Task<List<Model>> GetDataAsync()
		{
			var values = new List<Model> { new() { Name = "Foo" }, new() { Name = "Bar" } };
			return Task.FromResult(values);
		}
	}
}
