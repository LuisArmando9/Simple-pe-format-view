using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeExplorer.ViewModels
{
    class DirectoriesViewModel : MainUserControlOfViewModel<Directory>
    {
        public IEnumerable<Directory> DirectoriesProperties
        {
            get
            {
                var directories = new List<Directory> ();
                foreach(var directory in _mainWindow.PeFile.ImageNtHeaders.OptionalHeader.DataDirectory)
                {
                    directories.Add (new Directory { Name="Directory", Size=ToDecHex(directory.Size), VirtualAddress= ToDecHex(directory.VirtualAddress) });
                }

                _properties = directories;
                return _properties;
            }
        }
        public DirectoriesViewModel ( MainViewModel mainWindow ) : base (mainWindow) { }
    }
}
