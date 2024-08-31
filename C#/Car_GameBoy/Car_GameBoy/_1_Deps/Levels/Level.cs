using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._0_MainWindow_Handler;
using Car_GameBoy._1_Deps._1_GameArea_Handler;
using Car_GameBoy._1_Deps._2_Creating.Creating_Collision_Text;
using Car_GameBoy._1_Deps._2_Creating.Creating_Level_Info_Ticket;
using Car_GameBoy._1_Deps._2_Creating.Creating_Manager;
using Car_GameBoy._1_Deps._2_Creating.Creating_Score_Box;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Manager;
using Car_GameBoy._1_Deps._4_Moving.Moving_Manager;
using Car_GameBoy._1_Deps._5_Buttons.Buttons_Manager;
using Car_GameBoy._1_Deps._6_Collision;
using Car_GameBoy._1_Deps._7_Controlling.Controlling_Info_Tickets_Bet_Levels;
using Car_GameBoy._1_Deps._7_Controlling.Controlling_Manager;
using Car_GameBoy._1_Deps._7_Controlling.Controlling_Player_Score;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Car_GameBoy._1_Deps.Levels
{
    internal class Level
    {


        bool levelStarted = false;

        private MainWindow_Handler obj_MWH = new MainWindow_Handler();
        private GameArea_Handler obj_GAH = new GameArea_Handler();
        private Canvas gameArea = new Canvas();
        private DispatcherTimer timer = new DispatcherTimer();
        private Creating_Manager obj_Creating_Manager = new Creating_Manager();
        private Drawing_Manager obj_Drawing_Manager = new Drawing_Manager();
        private Moving_Manager obj_Moving_Manager = new Moving_Manager();
        private Buttons_Manager obj_Btns_Manager = new Buttons_Manager();
        private Collision_Text obj_Collision_Text = new Collision_Text();
        private Collision_Manager obj_Collision_Manager = new Collision_Manager();
        private Controlling_Manager obj_Controlling_Manager = new Controlling_Manager();
        private int count = 0;
        private Level_1 obj_Level_1 = new Level_1();
        private Level_Ticket_Info_Controller obj_Level_Info_Ticket = new Level_Ticket_Info_Controller();
        private Player_Score_Controller obj_Player_Score=new Player_Score_Controller(); 
        private Game_Levels_Controller obj_Game_Level_Controller=new Game_Levels_Controller();
        private Level_States_Manager obj_Level_States_Manager=new Level_States_Manager();

        //-----------------------------------------------------------------------------------------------
        public void onStart( MainWindow mW)
        {
            // set game area
            // create
            // draw 
            if (!levelStarted)
            {


                ///bug #20 i moved this to start point
             ///  Globals.current_Level= obj_Game_Level_Controller.detect_Level();
             ///   Globals.current_Level.set_Level_Values();
                obj_MWH.customize_mainWindow(mW);
                gameArea = obj_GAH.handle_And_Give_Me_The_GameArea(mW);
                obj_Btns_Manager.handle_GameArea_Buttons(gameArea, timer);
                obj_Creating_Manager.creat();
                obj_Drawing_Manager.draw(gameArea);
                levelStarted = true;
                obj_Level_Info_Ticket.show_Level_Ticket_Info_In_Starting_The_Level(gameArea, Globals.current_Level.level_No, Globals.current_Level.req_Score, 5);

            }

        }
        //-----------------------------------------------------------------------------------------------
        public void onRunning(TextBox tb, I_Level_Runnable current_Level, MainWindow mW)
        {
            obj_Level_States_Manager.control_Level_States(current_Level, mW, tb );
            obj_Collision_Manager.check_Collision(Globals.li_Player_Container, Globals.li_Enemy_Cars, Globals.li_Player_Food, timer);
            obj_Moving_Manager.move_Items_During_Timer_Tick(gameArea);
            Globals.player_Score += 1;
            obj_Player_Score.update_Player_Score(tb);
            obj_Controlling_Manager.control(Globals.timerTick, gameArea);
            /// monitor the score to detect 
        }
        //-----------------------------------------------------------------------------------------------
        public void onDestroyed()
        {

            if (Globals.does_Scored)
            {
                Globals.current_Level_Nu += 1;
                // update level to new level
                // start the new level 
                // zero the score 

            }
            else if(Globals.does_Game_Over)
            {
                //show the failed message
                //repeate the level from begining
            }
           

        }
        //-----------------------------------------------------------------------------------------------
        public void handle_The_Discussion_Menu()
        {

        }
        //-----------------------------------------------------------------------------------------------
        public void set_Level_Values()
        {

        }

    }
}
