using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Shapes;
using Car_GameBoy._1_Deps._3_Drawing.Drawing_GC;
using Car_GameBoy.__Globals;
using System.Windows.Threading;
using Car_GameBoy._1_Deps._7_Controlling.Controlling_Info_Tickets_Bet_Levels;
using Car_GameBoy._0_Main;

namespace Car_GameBoy._1_Deps._6_Collision
{
    internal class Enemey_Collision
    {
        private GameOver_Ticket_Controller obj_GO_Ticket_Con=new GameOver_Ticket_Controller();
        //-------------------------------------------------------------------------------------------------------------------------
        public void detect_Enemy_Collison(List<C_Item> player,List<List<C_Item>> enemies,DispatcherTimer timer,Canvas gameArea,MainWindow mW)
        {
            for(int i = 0;i<player.Count;i++)
            {
                foreach(List<C_Item> Cars_Enemies_List in enemies)
                {
                    foreach(C_Item enemy_Car in  Cars_Enemies_List)
                    {
                        bool isColliding = CheckCollision(player[i].rect, enemy_Car.rect);
                        if (isColliding)
                        {
                            timer.Stop();
                            obj_GO_Ticket_Con.issue_GameOver_Tickt(gameArea, 1, 500, 5);
                          //  obj_GM.start_And_Handle_The_App(mW);

                        }
                    }
                }





            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------
        private bool CheckCollision(Rectangle rect1, Rectangle rect2)
        {
            // Get the bounding rectangles of the shapes
            Rect rect1Bounds = new Rect(Canvas.GetLeft(rect1), Canvas.GetTop(rect1), rect1.Width, rect1.Height);
            Rect rect2Bounds = new Rect(Canvas.GetLeft(rect2), Canvas.GetTop(rect2), rect2.Width, rect2.Height);

            // Check if the rectangles intersect
            return rect1Bounds.IntersectsWith(rect2Bounds);
        }
    }
}
