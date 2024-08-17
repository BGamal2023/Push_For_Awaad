using Car_GameBoy._1_Deps._3_Drawing.Drawing_Enemies;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Player;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Racing_Area;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_The_Bkground_Lines_In_The_Racing_Area;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_The_Blocks_In_The_Sideway_Of_Racing_Area;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Two_Sideways_Of_The_Racing_Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._3_Drawing.Drawing_Manager
{
    internal class Drawing_Manager
    {
        private Drawing_The_Sideway_Blocks obj_D_S_W_B = new Drawing_The_Sideway_Blocks();
        private Drawing_Bkground_Lines_In_The_Racing_Area obj_D_Bkg_Lines = new Drawing_Bkground_Lines_In_The_Racing_Area();
        private Drawing_The_Racing_Area obj_Drawing_Racing_Area = new Drawing_The_Racing_Area();
        private Drawing_The_Two_Sideways_Of_The_Racing_Area obj_Drawing_Sideways_Of_The_Racing_Area = new Drawing_The_Two_Sideways_Of_The_Racing_Area();
        private Drawing_The_Player obj_Drawing_Player = new Drawing_The_Player();
        private Drawing_The_Enemies obj_Drawing_Enemyies = new Drawing_The_Enemies();
        private Drawing_Player_Container obj_Drawing_Player_Container = new Drawing_Player_Container();
        //----------------------------------------------------------------------------------
        public void draw(Canvas gameArea)
        {
            obj_Drawing_Racing_Area.draw_The_Racing_Area(gameArea);
            obj_D_Bkg_Lines.draw_The_Bkground_Lines_In_The_Racing_Area(gameArea);
            obj_Drawing_Sideways_Of_The_Racing_Area.draw_The_Left_Sideway(gameArea);
            obj_Drawing_Sideways_Of_The_Racing_Area.draw_The_Right_Sideway(gameArea);
            obj_D_S_W_B.draw_Left_Sideway_Blocks(gameArea);
            obj_D_S_W_B.draw_Right_Sideway_Blocks(gameArea);
            obj_Drawing_Player_Container.draw_The_Player_Conatiner(gameArea);
            obj_Drawing_Player.draw_The_Player(gameArea);
            //obj_Drawing_Enemey_Containers.draw_The_Enemies(gameArea);
           obj_Drawing_Enemyies.draw_The_Enemies(gameArea);




        }
    }
}
