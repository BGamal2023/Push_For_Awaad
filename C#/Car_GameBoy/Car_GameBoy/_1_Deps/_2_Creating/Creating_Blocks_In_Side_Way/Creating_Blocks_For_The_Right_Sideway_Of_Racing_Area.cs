﻿using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Interfaces_And_Thier_Implemented_Classes;
using Car_GameBoy._1_Deps.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_GameBoy._1_Deps._2_Creating.Creating_Blocks_In_Side_Way
{
    internal class Creating_Blocks_For_The_Right_Sideway_Of_Racing_Area
    {

        C_Creating_Multible_Segement_Items_GC obj_Creat_item = new C_Creating_Multible_Segement_Items_GC();
        //-------------------------------------------------------------------------------

        public void create_Right_Sideway_Blocks()
        {
            obj_Creat_item.creat_Multible_Item(
                Globals.no_Of_The_Right_SideWay_Blocks,
                Globals.right_Sideway_Blocks_Segment_No,
                Globals.right_Sideway_Blocks_Width,
                Globals.right_Sideway_Blocks_Height,
                Globals.racing_Area_Bkground_Line_Segment_Height,
                Globals.right_Sideway_Blocks_BKground_Color,
                Globals.right_Sideway_Blocks_X_Pos,
                Globals.right_Sideway_Blocks_Y_Pos,
                Globals.li_Of_The_Right_Sideway_Blocks_New,
                Globals.right_Sideway_Blocks_Dis_Bet_Blocks
                );
        }

        //-------------------------------------------------------------------------------
        public void create_Right_Sideway_Blocks_V1(I_Level_Runnable obj_I_Level_Runnable)
        {
           /* obj_Creat_item.creat_Multible_Item(
                obj_I_Level_Runnable.no_Of_The_Right_SideWay_Blocks,
                obj_I_Level_Runnable.right_Sideway_Blocks_Segment_No,
                obj_I_Level_Runnable.right_Sideway_Blocks_Width,
                obj_I_Level_Runnable.right_Sideway_Blocks_Height,
                obj_I_Level_Runnable.racing_Area_Bkground_Line_Segment_Height,
                obj_I_Level_Runnable.right_Sideway_Blocks_BKground_Color,
                obj_I_Level_Runnable.right_Sideway_Blocks_X_Pos,
                obj_I_Level_Runnable.right_Sideway_Blocks_Y_Pos,
                I_Level_Runnable.li_Of_The_Right_Sideway_Blocks,
                obj_I_Level_Runnable.right_Sideway_Blocks_Dis_Bet_Blocks
                );*/
        }
    }
}
