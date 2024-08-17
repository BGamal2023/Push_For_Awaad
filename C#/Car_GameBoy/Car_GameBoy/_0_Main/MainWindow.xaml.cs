using Car_GameBoy.__Globals;
using Car_GameBoy._0_Main;
using Car_GameBoy._1_Deps._5_Buttons.Interfaces_And_Thier_Implem_Classes;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Car_GameBoy
{
    public partial class MainWindow : Window
    {
        private General_Manger obj_GM = new General_Manger();


        //---------------------------------------------------------------------------------------------------------------------
        public MainWindow()
        {
            InitializeComponent();
            Canvas gameArea = obj_GM.start_And_Handle_The_App(this);

            KeyDown += (sender, e) => obj_GM.onclick_Keydown(sender, e);

            KeyUp += obj_GM.onClick_Keyup;

        }

    }
}