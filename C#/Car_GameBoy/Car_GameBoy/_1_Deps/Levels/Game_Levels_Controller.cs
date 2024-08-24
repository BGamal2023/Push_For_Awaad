using Car_GameBoy.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_GameBoy._1_Deps.Levels
{
    internal class Game_Levels_Controller
    {

        private Level_1 obj_Level_1 = new Level_1();
        private Level_2 obj_Level_2 = new Level_2();
        private Level_3 obj_Level_3 = new Level_3();
        private Level_4 obj_Level_4 = new Level_4();

        //----------------------------------------------------------------------------------------------------------------------------------------
        public void control_Game_Levels(double current_Score, I_Level_Runnable obj_I_Level_Runnable)
        {
            monitore_The_Score_To_Update_Level(current_Score, obj_I_Level_Runnable);
            update_The_Level_Runnable();
        }







        //----------------------------------------------------------------------------------------------------------------------------------------
        private void monitore_The_Score_To_Update_Level(double current_Score, I_Level_Runnable obj_I_Level_Runnable)
        {
            if (current_Score >= Globals.level_Score && Globals.current_Level_Nu == obj_I_Level_Runnable.level_No)
            {

                Globals.current_Level_Nu += 1;

                obj_I_Level_Runnable.onDestroyed();

                switch (Globals.current_Level_Nu)
                {
                    case 1:
                        Globals.enum_Current_Level = Globals.Enum_Level.Level_1;
                        break;
                    case 2:
                        Globals.enum_Current_Level = Globals.Enum_Level.Level_2;
                        break;
                    case 3:
                        Globals.enum_Current_Level = Globals.Enum_Level.Level_3;
                        break;

                    case 4:
                        Globals.enum_Current_Level = Globals.Enum_Level.Level_4;
                        break;


                }
                /// current level onDestroyed

            }



        }

        //----------------------------------------------------------------------------------------------------------------------------------------

        private void update_The_Level_Runnable()
        {

            switch (Globals.enum_Current_Level)
            {
                case Globals.Enum_Level.Level_1:
                    Globals.current_Level = obj_Level_1;
                    break;

                case Globals.Enum_Level.Level_2:
                    Globals.current_Level = obj_Level_2;
                    break;

                case Globals.Enum_Level.Level_3:
                    Globals.current_Level = obj_Level_3;
                    break;

                case Globals.Enum_Level.Level_4:
                    Globals.current_Level = obj_Level_4;
                    break;



            }
        }
    }
}
