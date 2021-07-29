using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeExplorer.ViewModels
{
    class HeaderViewModel:MainUserControlOfViewModel<GenericProperty>
    {
       
        public IEnumerable<GenericProperty> DosHeaderProperties
        {
            get
            {
                if (_mainWindow is not null && _mainWindow.PeFile.ImageDosHeader is not null)
                {
                    var dosHeader = _mainWindow.PeFile.ImageDosHeader;
                   
                    _properties = new List<GenericProperty>()
                    {
                        new GenericProperty{Name = "E_cblp", Value= ToDecHex(dosHeader.E_cblp) },
                        new GenericProperty{Name = "E_cp", Value= ToDecHex(dosHeader.E_cp) },
                        new GenericProperty{Name = "E_cparhdr", Value= ToDecHex(dosHeader.E_cparhdr) },
                        new GenericProperty{Name = "E_crlc", Value= ToDecHex(dosHeader.E_crlc) },
                        new GenericProperty{Name = "E_cs", Value= ToDecHex(dosHeader.E_cs) },
                        new GenericProperty{Name = "E_csum", Value= ToDecHex(dosHeader.E_csum) },
                        new GenericProperty{Name = "E_ip", Value= ToDecHex(dosHeader.E_ip) },
                        new GenericProperty{Name = "E_lfanew", Value= ToDecHex(dosHeader.E_lfanew) },
                        new GenericProperty{Name = "E_lfarlc", Value= ToDecHex(dosHeader.E_lfarlc) },
                        new GenericProperty{Name = "E_magic", Value= ToDecHex(dosHeader.E_magic), MoreInfo="MZ" },
                        new GenericProperty{Name = "E_maxalloc", Value= ToDecHex(dosHeader.E_maxalloc) },
                        new GenericProperty{Name = "E_minalloc", Value= ToDecHex(dosHeader.E_minalloc) },
                        new GenericProperty{Name = "E_oemid", Value= ToDecHex(dosHeader.E_oemid) },
                        new GenericProperty{Name = "E_oeminfo", Value= ToDecHex(dosHeader.E_oeminfo) },
                        new GenericProperty{Name = "E_ovno", Value= ToDecHex(dosHeader.E_ovno) },
                        new GenericProperty{Name = "E_res", Value= "0x0"},
                        new GenericProperty{Name = "E_res2", Value= "0x0" },
                        new GenericProperty{Name = "E_sp", Value= ToDecHex(dosHeader.E_sp)},
                        new GenericProperty{Name = "E_ss", Value= ToDecHex(dosHeader.E_cblp) }

                    };
                }


                return _properties;
            }
        }

        public IEnumerable<GenericProperty> OptinalHeaderProperties
        {
            get
            {
                _properties = new List<GenericProperty>();
                if (_mainWindow is not null && _mainWindow.PeFile.ImageNtHeaders is not null)
                {
                    var optionalHeader = _mainWindow.PeFile.ImageNtHeaders.OptionalHeader;
                    if (optionalHeader is not null)
                    {
                        _properties = new List<GenericProperty>()
                        {
                            new GenericProperty{ Name="BaseOfCode", Value=ToDecHex(optionalHeader.BaseOfCode)},
                            new GenericProperty{ Name="BaseOfData", Value=ToDecHex(optionalHeader.BaseOfData)},
                            new GenericProperty{ Name="CheckSum", Value=ToDecHex(optionalHeader.CheckSum)},
                            new GenericProperty{ Name="DllCharacteristics", Value=ToDecHex((ulong)optionalHeader.DllCharacteristics), MoreInfo=$"{optionalHeader.DllCharacteristics}"},
                            new GenericProperty{ Name="FileAlignment", Value=ToDecHex(optionalHeader.FileAlignment)},
                            new GenericProperty{ Name="ImageBase", Value=ToDecHex(optionalHeader.ImageBase)},
                            new GenericProperty{ Name="Magic", Value=ToDecHex((ulong)optionalHeader.Magic), MoreInfo=$"{optionalHeader.Magic}"},
                            new GenericProperty{ Name="MajorImageVersion", Value=ToDecHex(optionalHeader.MajorImageVersion)},
                            new GenericProperty{ Name="MajorLinkerVersion", Value=ToDecHex(optionalHeader.MajorLinkerVersion)},
                            new GenericProperty{ Name="MajorOperatingSystemVersion", Value=ToDecHex(optionalHeader.MajorOperatingSystemVersion)},
                            new GenericProperty{ Name="MajorSubsystemVersion", Value=ToDecHex(optionalHeader.AddressOfEntryPoint) } ,
                            new GenericProperty{ Name="MinorImageVersion", Value=ToDecHex(optionalHeader.MajorSubsystemVersion)},
                            new GenericProperty{ Name="MinorLinkerVersion", Value=ToDecHex(optionalHeader.MinorLinkerVersion) } ,
                            new GenericProperty{ Name="MinorOperatingSystemVersion", Value=ToDecHex(optionalHeader.MinorOperatingSystemVersion) } ,
                            new GenericProperty{ Name="MinorSubsystemVersion", Value=ToDecHex(optionalHeader.MinorSubsystemVersion) } ,
                            new GenericProperty{ Name="NumberOfRvaAndSizes", Value=ToDecHex(optionalHeader.NumberOfRvaAndSizes)},
                            new GenericProperty{ Name="SectionAlignment", Value=ToDecHex(optionalHeader.SectionAlignment)},
                            new GenericProperty{ Name="SizeOfCode", Value=ToDecHex(optionalHeader.SizeOfCode)},
                            new GenericProperty{ Name="SizeOfHeaders", Value=ToDecHex(optionalHeader.SizeOfHeaders)},
                            new GenericProperty{ Name="SizeOfHeapCommit", Value=ToDecHex(optionalHeader.SizeOfHeapCommit)},
                            new GenericProperty{ Name="SizeOfHeapReserve", Value=ToDecHex(optionalHeader.SizeOfHeapReserve)},
                            new GenericProperty{ Name="SizeOfImage", Value=ToDecHex(optionalHeader.SizeOfImage)},
                            new GenericProperty{ Name="SizeOfInitializedData", Value=ToDecHex(optionalHeader.SizeOfInitializedData)},
                            new GenericProperty{ Name="SizeOfStackCommit", Value=ToDecHex(optionalHeader.SizeOfStackCommit)},
                            new GenericProperty{ Name="SizeOfStackReserve", Value=ToDecHex(optionalHeader.SizeOfStackReserve)},
                            new GenericProperty{ Name="SizeOfInitializedData", Value=ToDecHex(optionalHeader.SizeOfInitializedData)},
                            new GenericProperty{ Name="SizeOfUninitializedData", Value=ToDecHex(optionalHeader.SizeOfUninitializedData)},
                            new GenericProperty{ Name="Subsystem", Value=ToDecHex((ulong)optionalHeader.Subsystem), MoreInfo=optionalHeader.SubsystemResolved},
                            new GenericProperty{ Name="Win32VersionValue", Value=ToDecHex(optionalHeader.Win32VersionValue)},
                           
                        };
                    }

                }
                return _properties;
            }
        }
        public IEnumerable<GenericProperty> FileHeaderProperties
        { 
            get 
            {
                _properties = new List<GenericProperty> ();
                if(_mainWindow is not null && _mainWindow.PeFile.ImageNtHeaders is not null)
                {
                    var fileHeader = _mainWindow.PeFile.ImageNtHeaders.FileHeader;
                    if(fileHeader is not null)
                    {
                        _properties = new List<GenericProperty> ()
                        {
                            new GenericProperty{Name="Characteristics", MoreInfo=String.Join(',', fileHeader.Characteristics)},
                            new GenericProperty{Name="Machine", Value=ToDecHex((uint)fileHeader.Machine), MoreInfo=fileHeader.MachineResolved},
                            new GenericProperty{Name="NumberOfSections",Value=ToDecHex(fileHeader.NumberOfSections)},
                            new GenericProperty{Name="PointerToSymbolTable",Value=ToDecHex(fileHeader.PointerToSymbolTable)},
                            new GenericProperty{Name="TimeDateStamp",Value=ToDecHex(fileHeader.TimeDateStamp)},
                        };
                    }
                }
                return _properties;

            }
        }
       
        public HeaderViewModel(MainViewModel mainWindow ) : base (mainWindow) { }
       

    }
}
