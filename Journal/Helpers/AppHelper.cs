using Journal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Journal.Helpers
{
    public class AppHelper
    {
        public static Журнал_ДанныхEntities2 DbConnect = new Журнал_ДанныхEntities2();
        public static Frame MainFrame;

    }

}
