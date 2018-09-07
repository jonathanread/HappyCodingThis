using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.Sitefinity;
using Telerik.Sitefinity.Modules.Libraries;

namespace SitefinityWebApp.Helpers
{
	public static class LibrariesHelpers
	{
		public static IFolder FindFolderById(Guid id)
		{
			//gets an isntance of the LibrariesManager
			IFolder folder = manager.FindFolderById(id);
			return folder;
		}

		private static LibrariesManager manager = LibrariesManager.GetManager();
	}
}