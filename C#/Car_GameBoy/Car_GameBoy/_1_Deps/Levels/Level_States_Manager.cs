using Car_GameBoy.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps.Levels
{
    internal class Level_States_Manager
    {

        public void control_Level_States(I_Level_Runnable current_Level, MainWindow mW, TextBox tb)
        {
            monitor_Level_States();
            Switch_Bet_Level_States_According_To_Monitoring_Result(current_Level,mW,tb);
        }
        //-------------------------------------------------------------------------------------------------------------
        private void monitor_Level_States()
        {
            if (Globals.does_Level_Started)
            {
                Globals.current_Level_State = Globals.level_States.onRun_State;
            }
            else if (Globals.does_Game_Over || Globals.does_Scored)
            {
                Globals.current_Level_State = Globals.level_States.onDestroy_State;
            }
        }
        //-------------------------------------------------------------------------------------------------------------
        private void Switch_Bet_Level_States_According_To_Monitoring_Result(I_Level_Runnable current_Level,MainWindow mW,TextBox tb)
        {
            switch (Globals.current_Level_State)
            {
                case Globals.level_States.onStart_State:
                    current_Level.onStart(mW);
                    break;

                case Globals.level_States.onRun_State:
                    current_Level.onRunning(tb,current_Level,mW);
                    break;

                case Globals.level_States.onDestroy_State:
                    current_Level.onDestroyed();
                    break;
            }
            {

            }
        }
    }
}
