using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Win32;
using PeExplorer.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PeExplorer.ViewModels
{
    class MainViewModel : ObservableObject
    {



        private const string FILTERS = "PE Files (*.exe;*.dll;*.ocx;*.sys;*.efi)|*.exe;*.sys;*.dll;*.ocx;*.efi";
        private string _path;
        private string _message;
        private bool _isBusy;

        private ObservableCollection<UserControl> _views = new();
        public string Message { get => _message; set => SetProperty (ref _message , value); }
        public ObservableCollection<UserControl> Views { get => _views; set => SetProperty(ref _views, value); }
        public HeaderViewModel Headers { get; private set; }
        public SectionViewModel Sections { get; private set; }
        public DirectoriesViewModel Directories { get; private set; }
        public ExportFunctionViewModel Exports { get; private set; }
        public ImportFunctionViewModel Imports { get; private set; }

        public MainWindow MainWindow { get; private set; }
        public PeNet.PeFile PeFile { get; private set; }
        public string Path
        {
            get => _path;
            private set
            {
                SetProperty (ref _path , value);
                if (string.IsNullOrEmpty(_path))
                    throw new MemberAccessException("Invalid path");   
            }

        }
        public ICommand OpenFileCommand { get; }
        public ICommand MenuCommand { get; }
        private void InitializeUserControls()
        {
            Headers = new(this);
            Sections = new (this);
            Directories = new (this);
            Exports = new (this);
            Imports = new (this);
        }
        private void ShowInitialControlBeforeLoadingPeFile()
        {
           
            _views.Clear ();
            Views.Add (new HeadersControl ());
        }
        public void OpenFile()
        {
          
            OpenFileDialog dialog = new(){ Filter = FILTERS};
            try
            {
                if(dialog.ShowDialog() == true)
                {
                    Path = dialog.FileName;
                    if(PeNet.PeFile.IsPeFile(dialog.OpenFile()))
                    {
                        PeFile = new PeNet.PeFile(dialog.OpenFile());
                        _isBusy = true;
                        InitializeUserControls();
                        Message = "";
                        ShowInitialControlBeforeLoadingPeFile();
                    }
                    else
                    {
                        Message = "It is not Pe file";
                        _isBusy = false;
                    }
                }
            }
            catch(Exception ex) 
            {
                _isBusy = false;
                Message = ex.Message;
            }
        }
    
        public void ShowMenuItem(object listviewitem)
        {
            try
            {
               ListViewItem item = (ListViewItem)listviewitem;
                string itemName = item.Name;
                if (Enum.TryParse(itemName, out VIEWS_TYPE itemType))
                {
                    if(_isBusy)
                    {
                        _views.Clear();
                        Views.Add(PeMenu.GetitemToShowInDashboard(itemType));
                    }  
                }
            }catch
            {
                _isBusy = false;
                return;
            }
            
        }
        public MainViewModel()
        {
            
            Views = new ObservableCollection<UserControl>() { new HomeControl()};
            OpenFileCommand = new RelayCommand(OpenFile);
            MenuCommand = new RelayCommand<object>((control)=> ShowMenuItem (control));
            _isBusy = false;
            Message = "";
        }

    }
}
