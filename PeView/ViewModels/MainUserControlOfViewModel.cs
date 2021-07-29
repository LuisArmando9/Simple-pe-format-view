using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeExplorer.ViewModels
{
    internal abstract class MainUserControlOfViewModel<T>
    {

        protected readonly MainViewModel _mainWindow;
        protected IEnumerable<T> _properties;

        public MainUserControlOfViewModel( MainViewModel mainWindow)
        {
            _mainWindow = mainWindow;
        }

        public virtual string ToDecHex ( ulong n ) => $"0x{n:X}";
    
    }
}
