using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps._2_Creating.Creating_Progress_Bar
{
    internal class Progress_Bar_Creator
    {
        private ProgressBar progress_Bar=new ProgressBar();
        //--------------------------------------------------------------------------------------
        public void add_Progress_Bar_To_GameArea(Canvas gameArea)
        {
            gameArea.Children.Add(progress_Bar);
            Canvas.SetLeft(progress_Bar, 0);

        }
    }
}
