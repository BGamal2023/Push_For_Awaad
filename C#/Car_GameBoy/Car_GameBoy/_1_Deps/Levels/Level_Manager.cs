using Car_GameBoy.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_GameBoy._1_Deps.Levels
{
    internal class Level_Manager
    {

        //-------------------------------------------------------------------------------------------------------------
        public void transfer_Bet_Level_States()
        {
            if (Globals.does_Level_Started)
            {
                Globals.current_Level_State = Globals.level_States.onRun;
            }

            else if (Globals.does_Game_Over || Globals.does_Scored)
            {
                Globals.current_Level_State = Globals.level_States.onDestroy;
            }


        }
        //-------------------------------------------------------------------------------------------------------------
        public void follow_Level_States(I_Level_Runnable current_Level)
        {
            switch (Globals.current_Level_State)
            {
                case Globals.level_States.onStart:
                    current_Level.onStart();
                    break;

                case Globals.level_States.onRun:
                    current_Level.onRunning();
                    break;

                case Globals.level_States.onDestroy:
                    current_Level.onDestroyed();
                    break;

            }
            {

            }
        }
      
    }
}
