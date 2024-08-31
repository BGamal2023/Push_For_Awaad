using Car_GameBoy.__Globals;
using Car_GameBoy._1_Deps._5_Buttons.Btn_Stop;
using Car_GameBoy._1_Deps._5_Buttons.Interfaces_And_Thier_Implem_Classes;
using Car_GameBoy._1_Deps._7_Controlling.Controlling_Info_Tickets_Bet_Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace Car_GameBoy._1_Deps._5_Buttons
{
    internal class Btn_Restart
    {
        private C_Btn obj_Btn = new C_Btn();
        private Button btn_Restart = new Button();
        private GameOver_Ticket_Controller obj_GameOver_Ticket_Controller=new GameOver_Ticket_Controller();
        //----------------------------------------------------------------------------------
        public void add_And_Handle_Restart_Btn(Canvas gameArea)
          
        {

           add_The_Btn_To_The_GameArea_GC
                (
                gameArea,
                btn_Restart,
                Globals.btn_Restart_Widht,
                Globals.btn_Restart_Height,
                Globals.btn_Restart_Left_Pos,
                Globals.btn_Restart_Top_Pos,
                Globals.btn_Restart_Text,
                Globals.btn_Restart_Bkground_Color
                );

           // btn_Restart.Click +=(sender,e)=> btn_Restart_OnClick(sender,e,gameArea, obj_GameOver_Ticket_Controller.gameOver_Ticket_Canvas);
        }

    

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void add_The_Btn_To_The_GameArea_GC(
           Canvas gameArea,
           Button btn,
           int btn_Width,
           int btn_Height,
           int btn_Left_Pos,
           int btn_Top_Pos,
           string btn_Text,
           Brush btn_Color)
        {
            gameArea.Children.Add(btn);
            btn.Height = btn_Height;
            btn.Width = btn_Width;
            btn.Background = btn_Color;
            btn.Content = btn_Text;
            Canvas.SetLeft(btn, btn_Left_Pos);
            Canvas.SetTop(btn, btn_Top_Pos);
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btn_Restart_OnClick(object sender, RoutedEventArgs e,Canvas gameArea,Canvas gameOver_Ticket)
        {
            MessageBox.Show("restart btn is pressed");
            gameArea.Children.Remove(gameOver_Ticket);

        }
    }
}
