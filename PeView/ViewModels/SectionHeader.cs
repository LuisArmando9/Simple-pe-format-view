using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeExplorer.ViewModels
{
    class SectionHeader
    {
        public string ImageBaseAddress { get; set; }
        public string Name { get; set; }
        public string VirtualSize { get; set; }
        public string VirtualAddress { get; set; }
        public string SizeOfRawData { get; set; }
        public string PointerToRawData { get; set; }
        public string PointerToRelocations { get; set; }
        public string PointerToLinenumbers { get; set; }
        public string NumberOfRelocations { get; set; }
        public string NumberOfLinenumbers { get; set; }
        public string Characteristics { get; set; }
       
    }
}
