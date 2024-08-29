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
        public I_Level_Runnable detect_Level( )
        {
            switch (Globals.current_Level_Nu)
            {
                case 1:
                   return obj_Level_1;
                   
                case 2:
                    return obj_Level_2;

                   
                case 3:
                   return obj_Level_3;

                    

                case 4:
                   return obj_Level_4;

                default:
                    return obj_Level_1;


            }
           

        }
       



    }
}
