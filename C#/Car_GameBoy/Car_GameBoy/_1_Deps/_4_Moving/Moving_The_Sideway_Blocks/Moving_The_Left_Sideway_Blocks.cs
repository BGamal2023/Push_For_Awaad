using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._4_Moving.Interfaces_And_Thier_Implem_Classes;
using Car_GameBoy._1_Deps.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._4_Moving.Moving_The_Sideway_Blocks
{
    internal class Moving_The_Left_Sideway_Blocks
    {

        private C_Moving obj_Moving = new C_Moving();
        //---------------------------------------------------------------------------
        public void move_The_Left_Blocks_In_Sideway(Canvas gameArea)
        {
            obj_Moving.move_Item_Vertical_Down_At_Fixed_Left_Pos(Globals.li_Of_The_Left_Sideway_Blocks_New, gameArea, Globals.moving_Increment, Globals.gameArea_Height);
        }
        //---------------------------------------------------------------------------
        public void move_The_Left_Blocks_In_Sideway_V1(Canvas gameArea,I_Level_Runnable obj_I_Level_Runnable)
        {
            //obj_Moving.move_Item_Vertical_Down_At_Fixed_Left_Pos
             //   (I_Level_Runnable.li_Of_The_Left_Sideway_Blocks, gameArea, obj_I_Level_Runnable.moving_Increment, Globals.gameArea_Height);
        }
    }
}
