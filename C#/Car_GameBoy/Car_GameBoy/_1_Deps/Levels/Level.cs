using Car_GameBoy.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace Car_GameBoy._1_Deps.Levels
{
    internal class Level
    {
        int level_number;
        int level_Speed;
        int level_Fuel;
        int level_Enemy_Num;
        int level_Dist_Bet_Enemies;
        int level_Road_Pumb;
        int level_Score;

        //-----------------------------------------------------------------------------------------------

        public Level
             (
         int level_Speed,
         int level_Fuel,
         int level_Enemy_Num,
         int level_Vertical_Dist_Bet_Enemies,
         int level_Road_Bumb,
         int level_Score
            )
        {
            this.level_Speed = level_Speed;
            this.level_Fuel = level_Fuel;
            this.level_Enemy_Num = level_Enemy_Num;
            this.level_Dist_Bet_Enemies=level_Vertical_Dist_Bet_Enemies ;
            this.level_Road_Pumb = level_Road_Bumb ;
            this.level_Score = level_Score;

        }


        //-----------------------------------------------------------------------------------------------
        public void actions_To_Be_Done_In_The_Enter_Of_The_Level()
        {

        }
        //-----------------------------------------------------------------------------------------------
        public void actions_To_Be_Done_During_Level()
        {

        }
        //-----------------------------------------------------------------------------------------------
        public void actions_To_Be_Done_In_The_End_Of_The_Level()
        {

        }

    }
}
