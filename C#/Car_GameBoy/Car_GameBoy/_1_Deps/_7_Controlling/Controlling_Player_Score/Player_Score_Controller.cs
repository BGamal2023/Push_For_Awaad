using Car_GameBoy.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._7_Controlling.Controlling_Player_Score
{
    internal class Player_Score_Controller
    {
        //------------------------------------------------------------------------------------------------
        public void update_Player_Score(TextBox tb)
        {
            tb.Text = Globals.player_Score.ToString();
        }
    }
}
