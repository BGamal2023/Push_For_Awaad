using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Car_GameBoy._1_Deps._5_Buttons.Interfaces_And_Thier_Implem_Classes
{

    // GA == GameArea
    internal interface I_GameArea_Btns_Runnable
    {
        public void Run(DispatcherTimer timer);
       
    }
}
