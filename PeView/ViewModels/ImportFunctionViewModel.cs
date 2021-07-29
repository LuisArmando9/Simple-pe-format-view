using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeExplorer.ViewModels
{
    class ImportFunctionViewModel:MainUserControlOfViewModel<ImportFunction>
    {
        public IEnumerable<ImportFunction> ImportProperties
        {
            get
            {
                var imports = new List<ImportFunction> ();
                if (_mainWindow.PeFile.ImportedFunctions is not null)
                {
                    foreach (var import in _mainWindow.PeFile.ImportedFunctions)
                    {
                        imports.Add (new ImportFunction ()
                        {
                            Name = import.Name ?? "UNKNOWN" ,
                            DLL = import.DLL ,
                            Hint = ToDecHex (import.Hint) ,
                            IATOffset = ToDecHex (import.IATOffset)
                        });
                        _properties = imports;
                    }
                }

                return _properties;
            }
        }
        public ImportFunctionViewModel(MainViewModel mainWindow ) : base (mainWindow) { }

    }
}
