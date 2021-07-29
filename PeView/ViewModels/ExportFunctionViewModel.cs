using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeExplorer.ViewModels
{
    class ExportFunctionViewModel: MainUserControlOfViewModel<ExportFunction>
    {
        public IEnumerable<ExportFunction> ExportProperties
        {
            
            get
            {
                var exports = new List<ExportFunction> ();
                if(_mainWindow.PeFile.ExportedFunctions is not null)
                {
                    foreach (var export in _mainWindow.PeFile.ExportedFunctions)
                    {
                        exports.Add (new ExportFunction ()
                        {
                            Name = export.Name ?? "UNKNOWN" ,
                            Address = ToDecHex (export.Address) ,
                            ForwardName = export.ForwardName ?? "UNKNOWN" ,
                            Ordinal = ToDecHex (export.Ordinal)
                        });
                        _properties = exports;
                    }

                }
                return _properties;
            }
        }
        public ExportFunctionViewModel(MainViewModel mainWindow ) : base (mainWindow) { }
    }
}
