using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Car_GameBoy._1_Deps._5_Buttons.Interfaces_And_Thier_Implem_Classes
{
    internal interface I_Restart_Btn_Interface
    {

        public void Run(DispatcherTimer timer, Canvas gameArea, Canvas gameOver_Ticket);
      
    }
}
