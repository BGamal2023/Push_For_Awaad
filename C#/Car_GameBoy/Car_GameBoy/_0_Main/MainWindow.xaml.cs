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
        private TextBox obj_Text_Box = new TextBox();


        //---------------------------------------------------------------------------------------------------------------------
        public MainWindow()
        {
            InitializeComponent();
            Canvas gameArea = obj_GM.start_And_Handle_The_App(this,obj_Text_Box);
            gameArea.Children.Add(obj_Text_Box);
            obj_Text_Box.Width = 50;
            obj_Text_Box.Height = 25;
            obj_Text_Box.Text = Globals.collision_Num.ToString();
            obj_Text_Box.TextAlignment = TextAlignment.Center;
            Canvas.SetTop(obj_Text_Box, 300);
            Canvas.SetLeft(obj_Text_Box, 550);

            KeyDown += (sender, e) => obj_GM.onclick_Keydown(sender, e);

            KeyUp += obj_GM.onClick_Keyup;

        }

    }
}