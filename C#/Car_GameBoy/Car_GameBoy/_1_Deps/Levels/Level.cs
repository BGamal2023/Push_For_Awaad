using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._2_Creating.Creating_Score_Box;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
        bool levelStarted = false;

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
            this.level_Dist_Bet_Enemies = level_Vertical_Dist_Bet_Enemies;
            this.level_Road_Pumb = level_Road_Bumb;
            this.level_Score = level_Score;

        }
        //-----------------------------------------------------------------------------------------------

        public void Run()
        {
            onStart();
            onRunning();
            onDestroyed();
        }

        //-----------------------------------------------------------------------------------------------
        public void onStart()
        {
            // set game area
            // create
            // draw 
            if (!levelStarted)
            {
                set_Level_Values();

                obj_MWH.customize_mainWindow(mW);
                gameArea = obj_GAH.handle_And_Give_Me_The_GameArea(mW);
                handle_The_Game_Timer(Score_Box_Creator.obj_TextBox);
                obj_Btns_Manager.handle_GameArea_Buttons(gameArea, timer);
                obj_Creating_Manager.creat();
                obj_Drawing_Manager.draw(gameArea);
                return gameArea;
                levelStarted = true;
            }

        }
        //-----------------------------------------------------------------------------------------------
        public void onRunning()
        {
            // timer tick actions

            obj_Collision_Manager.check_Collision(Globals.li_Player_Container, Globals.li_Enemy_Cars, Globals.li_Player_Food, timer);
            obj_Moving_Manager.move_Items_During_Timer_Tick(gameArea);
            Globals.player_Score += 1;
            update_Player_Score(player_Score);
            obj_Controlling_Manager.control(Globals.timerTick, gameArea);
            /// monitor the score 


        }
        //-----------------------------------------------------------------------------------------------
        public void onDestroyed()
        {
            /// if the score done 
            /// go to level 2
            /// bool level started =false;


        }

        public void handle_The_Discussion_Menu()
        {

        }
        //-----------------------------------------------------------------------------------------------
        public void set_Level_Values()
        {

        }

    }
}
