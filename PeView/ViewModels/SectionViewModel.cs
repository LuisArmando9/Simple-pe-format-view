using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeExplorer.ViewModels
{
    class SectionViewModel:MainUserControlOfViewModel<SectionHeader>
    {

        public IEnumerable<SectionHeader> SectionHeadersProperties 
        {
            get
            {
                if(_mainWindow is not null &&  _mainWindow.PeFile.ImageSectionHeaders is not null )
                {
                    var sectionHeaders = new List<SectionHeader> ();
                    foreach (var section in _mainWindow.PeFile.ImageSectionHeaders)
                    {
                        sectionHeaders.Add (
                            new SectionHeader ()
                            {
                                Name = section.Name ,
                                ImageBaseAddress = ToDecHex (section.ImageBaseAddress) ,
                                VirtualSize = ToDecHex (section.VirtualSize) ,
                                VirtualAddress = ToDecHex (section.VirtualAddress) ,
                                SizeOfRawData = ToDecHex (section.SizeOfRawData) ,
                                PointerToRawData = ToDecHex (section.PointerToRawData) ,
                                PointerToRelocations = ToDecHex (section.PointerToRelocations) ,
                                PointerToLinenumbers = ToDecHex (section.PointerToLinenumbers) ,
                                NumberOfRelocations = ToDecHex (section.NumberOfLinenumbers) ,
                                NumberOfLinenumbers = ToDecHex (section.NumberOfLinenumbers) ,
                                Characteristics = String.Join (',' , section.CharacteristicsResolved)
                            });
                    }
                    _properties = sectionHeaders;
                }
                
                return _properties;
            }
        }
        public SectionViewModel ( MainViewModel mainWindow ) : base (mainWindow) { }        
    }
}
