using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace Car_GameBoy._1_Deps.Levels
{
    internal class Level_1 : I_Level_Runnable


    {
        public int _level_No = 1;
        public bool _levelStarted=false;

        public int level_No { get { return _level_No; } set { level_No = _level_No; } }

        public bool levelStarted { get { return _levelStarted; } set { levelStarted = _levelStarted; } }

        //---------------------------------------------------------------------------------------------------------------
        public void Run()
        {
            set_The_Game_Globals_Variables_As_Level_1();

            onStart();
            onRunning();
            onDestroyed();

        }
        //--------------------------------------------------------------------------------------------------------------
        private void set_The_Game_Globals_Variables_As_Level_1()
        {

            Globals.timerTick = 10;
            /// Racing Area
            Globals.racing_Area_X_Pos = 200;
            Globals.racing_Area_Y_Pos = 0;
            Globals.racing_Area_Width = 300;
            Globals.racing_Area_Height = Globals.gameArea_Height;
            Globals.racing_Area_bGround_Color = Brushes.Black;
            /// Racing Area Bkg Lines
            Globals.racing_Area_Background_Line_Width = 10;
            Globals.racing_Area_Background_Line_Height = 100;
            Globals.racing_Area_Background_Line_Color = Brushes.White;
            Globals.racing_Area_Background_Line_X_Pos = Globals.gameArea_Width / 2;
            Globals.racing_Area_Dist_Bet_Lines = 100;
            Globals.racing_Area_Background_Line_Y_Pos = Globals.racing_Area_Dist_Bet_Lines;
            Globals.no_Of_Lines_In_racing_Area = 3;
            Globals.racing_Area_Bkground_Line_Segment_Height = 1;
            Globals.no_Of_Segement_In_Every_Racing_Area_Lines = Globals.racing_Area_Background_Line_Height / Globals.racing_Area_Bkground_Line_Segment_Height;
            Globals.moving_Increment = 50;
            //------------------------------------
            /// 2 sides of the Racing Area 
            Globals.left_Side_Of_The_Racing_Area_Width = 30;
            Globals.left_Side_Of_The_Racing_Area_X_Pos = Globals.racing_Area_X_Pos - Globals.left_Side_Of_The_Racing_Area_Width;
            Globals.left_Side_Of_The_Racing_Area_Y_Pos = 0;
            Globals.left_Side_Of_The_Racing_Area_Height = Globals.gameArea_Height;
            Globals.left_Side_Of_The_Racing_Area_BKground_Color = Brushes.Orange;
            Globals.right_Side_Of_The_Racing_Area_X_Pos = Globals.racing_Area_X_Pos + Globals.racing_Area_Width;
            Globals.right_Side_Of_The_Racing_Area_Y_Pos = 0;
            Globals.right_Side_Of_The_Racing_Area_Width = 30;
            Globals.right_Side_Of_The_Racing_Area_Height = Globals.gameArea_Height;
            Globals.right_Side_Of_The_Racing_Area_BKground_Color = Brushes.Orange;
            //------------------------------------

            /// Blocks  in sideway of racing area
            // put height that can accept division by 800
            Globals.right_Sideway_Blocks_Height = 30;
            Globals.right_Sideway_Blocks_Width = Globals.right_Side_Of_The_Racing_Area_Width;
            Globals.no_Of_The_Right_SideWay_Blocks = 10;
            Globals.right_Sideway_Blocks_Y_Pos = 40;
            Globals.right_Sideway_Blocks_X_Pos = Globals.right_Side_Of_The_Racing_Area_X_Pos;
            Globals.right_Sideway_Blocks_Dis_Bet_Blocks = 40;
            Globals.right_Sideway_Blocks_BKground_Color = Brushes.Black;
            Globals.right_Sideway_Blocks_Segment_No = Globals.right_Sideway_Blocks_Height;


            Globals.left_Sideway_Blocks_Height = 30;
            Globals.left_Sideway_Blocks_Width = Globals.left_Side_Of_The_Racing_Area_Width;
            Globals.no_Of_Left_SideWay_Blocks = 10;
            Globals.left_Sideway_Blocks_Y_Pos = 40;
            Globals.left_Sideway_Blocks_X_Pos = Globals.left_Side_Of_The_Racing_Area_X_Pos;
            Globals.left_Sideway_Blocks_Dis_Bet_Blocks = 40;
            Globals.left_Sideway_Blocks_BKground_Color = Brushes.Black;
            Globals.left_Sideway_Blocks_Segment_No = Globals.left_Sideway_Blocks_Height;
            //------------------------------------


            /// Start Button 
            Globals.btn_Start_Widht = 80;
            Globals.btn_Start_Height = 25;
            Globals.btn_Start_Left_Pos = 575;
            Globals.btn_Start_Top_Pos = 500;
            Globals.btn_Start_Text = "Start Game";
            Globals.btn_Start_Bkground_Color = Brushes.Green;

            /// Stop Button 
            Globals.btn_Stop_Widht = 80;
            Globals.btn_Stop_Height = 25;
            Globals.btn_Stop_Left_Pos = 575;
            Globals.btn_Stop_Top_Pos = 575;
            Globals.btn_Stop_Text = "Stop Game";
            Globals.btn_Stop_Bkground_Color = Brushes.Red;
            //-------------------------------------------------
            /// Player Container
            Globals.player_One_Block_Width = 15;
            Globals.player_One_Block_Height = 10;
            Globals.no_Of_Blocks_in_Player_Body = 9;

            Globals.player_Container_Width = 3 * Globals.player_One_Block_Width;
            Globals.player_Container_Height = 5 * Globals.player_One_Block_Height;
            Globals.player_Container_X_Pos = 328;
            Globals.player_Container_Y_Pos = 550;
            Globals.player_Continer_Color = Brushes.Black;
            Globals.player_Container_Moving_Speed = Globals.player_Move_Speed;
            //-------------------------------------------

            /// Player 

            Globals.player_All_Width = 45;
            Globals.player_Width = 35;
            Globals.player_Height = 50;
            Globals.player_Color = Brushes.Green;
            Globals.player_Move_Speed = Globals.player_All_Width;

            //-------------------------------------------------
            ///Enemies Contaniners
            Globals.enemy_One_Block_Width = 15;
            Globals.enemy_One_Block_Height = 10;
            Globals.no_Of_Blocks_in_enemy_Body = 9;
            //-------------------------------------------------
            ///Enemyies
            Globals.number_Of_Enemies = 2;
            Globals.vertical_Dis_Bet_Enemies = 300;
            Globals.random_Enemy_X_Pos = 350;
            Globals.time_To_Add_Another_Enemy = 600;
            Globals.enemy_X_Pos = 328;
            Globals.enemy_Y_Pos = 0;
            Globals.enemy_Color = Brushes.Yellow;
            Globals.enemy_Move_Speed = Globals.moving_Increment;
            //------------------------------------------------------
            /// Collision
            Globals.collision_Num = 0;
            Globals.doesPlayCollision = false;
            Globals.doesLeftMovingEnabled = false;
            Globals.doesRightMovingEnabled = false;
            //------------------------------------------------------

            /// Player Score
            Globals.player_Hi_Score = 0;
            Globals.player_Score = 0;
            Globals.player_Fuel = 0;
            //-----------------------------------------------------

            /// Hi Score Text
            Globals.hi_Score_TBlock_W = 80;
            Globals.hi_Score_TBlock_H = 35;
            Globals.hi_Score_TBlock_Left_Pos = 575;
            Globals.hi_Score_TBlock_Top_Pos = 50;
            Globals.hi_Score_TBlock_Text = "Hi Score";
            Globals.hi_Score_TBlock_Bkground_Color = Globals.gameArea_Bkground_Color;
            /// Hi Score box
            Globals.hi_Score_TBox_W = 80;
            Globals.hi_Score_TBox_H = 25;
            Globals.hi_Score_TBox_Left_Pos = 575;
            Globals.hi_Score_TBox_Top_Pos = 80;
            Globals.hi_Score_TBox_Bkground_Color = Globals.gameArea_Bkground_Color;
            //-----------------------------------------------------
            /// Score Text
            Globals.progress_TextBlock_Width = 80;
            Globals.progress_TextBlock_Height = 35;
            Globals.progress_TextBlock_Left_Pos = 575;
            Globals.progress_TextBlock_Top_Pos = 130;
            Globals.progress_TextBlock_Text = "Score";
            Globals.progress_TextBlock_Bkground_Color = Globals.gameArea_Bkground_Color;
            /// Score box
            Globals.progress_TextBox_Width = 80;
            Globals.progress_TextBox_Height = 25;
            Globals.progress_TextBox_Left_Pos = 575;
            Globals.progress_TextBox_Top_Pos = 160;
            Globals.progress_TextBox_Bkground_Color = Globals.gameArea_Bkground_Color;
            //-----------------------------------------------------
            /// Fuel indicator

            Globals.fuel_Indic_TBlock_W = 80;
            Globals.fuel_Indic_TBlock_H = 35;
            Globals.fuel_Indic_TBlock_Left_Pos = 575;
            Globals.fuel_Indic_TBlock_Top_Pos = 220;
            Globals.fuel_Indic_TBlock_Text = "Fuel";
            Globals.fuel_Indic_TBlock_Bkground_Color = Globals.gameArea_Bkground_Color;

            Globals.fuel_Indic_TBox_W = 80;
            Globals.fuel_Indic_TBox_H = 25;
            Globals.fuel_Indic_TBox_Left_Pos = 575;
            Globals.fuel_Indic_TBox_Top_Pos = 250;
            Globals.fuel_Indic_TBox_Bkground_Color = Globals.gameArea_Bkground_Color;

            //--------------------------------------------------------------
            ///Player Food
            Globals.player_Food_X_pos = 300;
            Globals.player_Food_Y_Pos = 50;
            Globals.doesFoodEnabled = false;
            Globals.draw_Food = false;
            Globals.food_Collision = false;
        }
        //--------------------------------------------------------------------------------------------------------------
        private void onStart()
        {
            if(! levelStarted)
            {




                levelStarted = true;
            }

        }

        //--------------------------------------------------------------------------------------------------------------
        private void onRunning()
        {
            /// moving and monitoring actions
        }
        //--------------------------------------------------------------------------------------------------------------
        private void onDestroyed()
        {

        }
        //--------------------------------------------------------------------------------------------------------------


    }
}
