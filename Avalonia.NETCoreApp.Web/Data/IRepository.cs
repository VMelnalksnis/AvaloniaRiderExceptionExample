using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avalonia.NETCoreApp.Web.Data
{
	public interface IRepository
	{
		Task<List<Model>> GetDataAsync();
	}
}
