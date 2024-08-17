using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._0_MainWindow_Handler;
using Car_GameBoy._1_Deps._1_GameArea_Handler;
using Car_GameBoy._1_Deps._2_Creating.Creating_Blocks_In_Side_Way;
using Car_GameBoy._1_Deps._2_Creating.Creating_Collision_Text;
using Car_GameBoy._1_Deps._2_Creating.Creating_Manager;
using Car_GameBoy._1_Deps._2_Creating.Creating_Score_Box;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_Manager;
using Car_GameBoy._1_Deps._4_Moving.Moving_Manager;
using Car_GameBoy._1_Deps._5_Buttons.Buttons_Manager;
using Car_GameBoy._1_Deps._5_Buttons.Interfaces_And_Thier_Implem_Classes;
using Car_GameBoy._1_Deps._6_Collision;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace Car_GameBoy._0_Main
{

    internal class General_Manger
    {
        private MainWindow_Handler obj_MWH = new MainWindow_Handler();
        private GameArea_Handler obj_GAH = new GameArea_Handler();
        private Canvas gameArea = new Canvas();
        private DispatcherTimer timer = new DispatcherTimer();
        private Creating_Manager obj_Creating_Manager = new Creating_Manager();
        private Drawing_Manager obj_Drawing_Manager = new Drawing_Manager();
        private Moving_Manager obj_Moving_Manager = new Moving_Manager();
        private Buttons_Manager obj_Btns_Manager = new Buttons_Manager();
        private Collision_Text obj_Collision_Text= new Collision_Text();
        private Enemey_Collision obj_Enemey_Collision = new Enemey_Collision();
        
        //------------------------------------------------------------------------------------------------

        public Canvas start_And_Handle_The_App(MainWindow mW)
        {
            obj_MWH.customize_mainWindow(mW);
            gameArea = obj_GAH.handle_And_Give_Me_The_GameArea(mW);
            handle_The_Game_Timer(Score_Box_Creator.obj_TextBox);
            obj_Btns_Manager.handle_GameArea_Buttons(gameArea, timer);
            obj_Creating_Manager.creat();
            obj_Drawing_Manager.draw(gameArea);
            return gameArea;
        }

      

        //------------------------------------------------------------------------------------------------
        public void handle_The_Game_Timer(TextBox player_Score)
        {
            timer.Tick += (sender, e) => timer_Tick(sender, e, gameArea,player_Score);

            timer.Interval = System.TimeSpan.FromMilliseconds(Globals.timerTick);
        }
        //------------------------------------------------------------------------------------------------
        private void timer_Tick(object sender, EventArgs e, Canvas gameArea,TextBox player_Score)
        {
            
            obj_Moving_Manager.move_Items_During_Timer_Tick(gameArea);
            obj_Enemey_Collision.detect_Enemy_Collison(Globals.li_Player_Container, Globals.li_Enemy_Cars, timer);
            Globals.player_Score += 1;
            update_Player_Score(player_Score);
        }
        //------------------------------------------------------------------------------------------------
        public void onclick_Keydown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Right) 
            {
              
                obj_Moving_Manager.move_The_Player_Right(gameArea);
            }
            else if(e.Key == Key.Left)
            {
                obj_Moving_Manager.move_The_Player_Left(gameArea);

            }
        }
        //------------------------------------------------------------------------------------------------
        internal void onClick_Keyup(object sender, KeyEventArgs e)
        {
         
        }
        //------------------------------------------------------------------------------------------------
        private void update_No_Of_Collision(TextBox tb)
        {
            tb.Text=Globals.collision_Num.ToString();
        }
        //------------------------------------------------------------------------------------------------
        private void update_Player_Score(TextBox tb)
        {
            tb.Text=Globals.player_Score.ToString();
        }
    }
}
