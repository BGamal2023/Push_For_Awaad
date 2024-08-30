using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Car_GameBoy._1_Deps.Levels
{
    internal class Level_3 : I_Level_Runnable
    {
        public int _level_No = 3;
        public int level_No { get { return _level_No; } set { level_No = _level_No; } }

        public bool levelStarted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int req_Score { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void onDestroyed()
        {
            throw new NotImplementedException();
        }

        public void onRunning()
        {
            throw new NotImplementedException();
        }

        public void onRunning(TextBox tb, I_Level_Runnable current_Level, MainWindow mW)
        {
            throw new NotImplementedException();
        }

        public void onStart(MainWindow mW)
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
        }

        public void Run(TextBox tb, I_Level_Runnable current_Level, MainWindow mW)
        {
            throw new NotImplementedException();
        }

        public void set_Level_Values()
        {
            throw new NotImplementedException();
        }
    }
}
