using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PeExplorer.Views
{
    public static  class PeMenu
    {
        public static UserControl GetitemToShowInDashboard ( VIEWS_TYPE view )
            => view switch
            {
                VIEWS_TYPE.HOME => new HomeControl (),
                VIEWS_TYPE.HEADERS => new HeadersControl (),
                VIEWS_TYPE.SECTIONS => new SectionsControl (),
                VIEWS_TYPE.DIRECTORIES => new DirectoriesControl (),
                VIEWS_TYPE.IMPORTS => new ImportsControl (),
                VIEWS_TYPE.EXPORTS => new ExportsControl (),
                _ => new HomeControl (),
            };
    }
}
