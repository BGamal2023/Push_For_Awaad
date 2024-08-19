using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Player_Food;
using Car_GameBoy._1_Deps._4_Moving.Interfaces_And_Thier_Implem_Classes;
using Car_GameBoy._1_Deps._4_Moving.Moving_Player_Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._7_Controlling.Controlling_Player_Food
{
    internal class Player_Food_Controller
    {
        private Player_Food_Mover obj_Player_Food_Mover = new Player_Food_Mover();
        private Player_Food_Drawer obj_Drawer_Food_Drawer = new Player_Food_Drawer();
        private bool actionExecuted = false;
        private C_Moving obj_Moving = new C_Moving();
        //-----------------------------------------------------------------------------------------------------
        public void control_Player_Food(double player_Fuel, Canvas gameArea)
        {
            draw_Player_Food_In_GameArea(player_Fuel, gameArea);
            remove_Food_From_GameArea(gameArea);

        }
        //-----------------------------------------------------------------------------------------------------
        private void draw_Player_Food_In_GameArea(double player_Fuel, Canvas gameArea)
        {
            double level = player_Fuel;
            if (level == 80.0 || level == 60.0 || level == 40.0 || level == 20.0 || level == 10.0)
            {
                if (!actionExecuted)
                {
                    obj_Drawer_Food_Drawer.draw_The_Player_Food(gameArea);
                    actionExecuted = true;
                }

                Globals.doesFoodEnabled = true;


            }
        }
        //-----------------------------------------------------------------------------------------------------
        public void remove_Food_From_GameArea(Canvas gameArea)
        {
            if (Globals.li_Player_Food[0].left_Pos >= Globals.gameArea_Height || Globals.food_Collision)
            {
                obj_Moving.clear_Item_From_The_GameArea(Globals.li_Player_Food, gameArea);
            }
        }
    }

}
