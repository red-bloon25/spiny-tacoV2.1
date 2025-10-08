
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;


namespace spiny_taco;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        counter.Visibility = Visibility.Hidden;
        displayMess();
    }

    public string steamGameLoaction = @"C:\Program Files (x86)\Steam\steamapps\common\Ultrakill";

    private bool CheckIfhaveUK()
    {
       if (Directory.Exists(steamGameLoaction))
       return true;
       else
       return false;
       
    }

    private void displayMess()
    {
       if (CheckIfhaveUK())
       {
          MessageBox.Show("You PLAY \n ULTRAKILL","u hav UK",MessageBoxButton.OK,MessageBoxImage.Warning);
       }
    }
    private void LEAVE_OnClick(object sender, RoutedEventArgs e)
    {
        
        MainWindow mainWindow = this as MainWindow;
        mainWindow.Close();
    }

    private void MakeSMALL_OnClick(object sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = this as MainWindow;
        mainWindow.WindowState = WindowState.Minimized;
    }

    private void MakeLarge_OnClick(object sender, RoutedEventArgs e)
    {
        
    }
    private void MakeLarge_OnChecked(object sender, RoutedEventArgs e)
    {
       if (MakeLarge.IsChecked == true)
       {
          MainWindow mainWindow = this as MainWindow;
          mainWindow.WindowState = WindowState.Maximized;
       }
    }
    private void MakeLarge_OnUnchecked(object sender, RoutedEventArgs e)
    {
       if (MakeLarge.IsChecked == false)
       {
          MainWindow mainWindow = this as MainWindow;
          mainWindow.WindowState = WindowState.Normal;
       }
    }

    public int k = 0;
    private async void SPINTACO(object sender, RoutedEventArgs e)
    {
       Button.IsEnabled = false;
       
       DoubleAnimation rotateion = new DoubleAnimation(0,360,new Duration(TimeSpan.FromSeconds(2)));
       RotateTransform rt = new RotateTransform();
       taco.RenderTransform = rt;
       taco.RenderTransformOrigin = new Point(0.5, 0.5);
       rt.BeginAnimation(RotateTransform.AngleProperty, rotateion);
       int w = k + 1;
       k++;
       counter.Visibility=Visibility.Visible;
       counter.Content="Times spun: "+ w.ToString();
       Console.WriteLine("w"+w.ToString());
       Console.WriteLine("k"+k.ToString());
       await Task.Delay(2000);
       Button.IsEnabled=true;


    }

    private bool? iseven(int n)
    {
        if (n == 1)
            return false;
      else if (n==2)
         return true;
      else if (n==3)
         return false;
      else if (n==4)
         return true;
      else if (n==5)
         return false;
      else if (n==6)
         return true;
      else if (n==7)
         return false;
      else if (n==8)
         return true;
      else if (n==9)
         return false;
      else if (n==10)
         return true;
      else if (n==11)
         return false;
      else if (n==12)
         return true;
      else if (n==13)
         return false;
      else if (n==14)
         return true;
      else if (n==15)
         return false;
      else if (n==16)
         return true;
      else if (n==17)
         return false;
      else if (n==18)
         return true;
      else if (n==19)
         return false;
      else if (n==20)
         return true;
      else if (n==21)
         return false;
      else if (n==22)
         return true;
      else if (n==23)
         return false;
      else if (n==24)
         return true;
      else if (n==25)
         return false;
      else if (n==26)
         return true;
      else if (n==27)
         return false;
      else if (n==28)
         return true;
      else if (n==29)
         return false;
      else if (n==30)
         return true;
      else if (n==31)
         return false;
      else if (n==32)
         return true;
      else if (n==33)
         return false;
      else if (n==34)
         return true;
      else if (n==35)
         return false;
      else if (n==36)
         return true;
      else if (n==37)
         return false;
      else if (n==38)
         return true;
      else if (n==39)
         return false;
      else if (n==40)
         return true;
      else if (n==41)
         return false;
      else if (n==42)
         return true;
      else if (n==43)
         return false;
      else if (n==44)
         return true;
      else if (n==45)
         return false;
      else if (n==46)
         return true;
      else if (n==47)
         return false;
      else if (n==48)
         return true;
      else if (n==49)
         return false;
      else if (n==50)
         return true;
      else if (n==51)
         return false;
      else if (n==52)
         return true;
      else if (n==53)
         return false;
      else if (n==54)
         return true;
      else if (n==55)
         return false;
      else if (n==56)
         return true;
      else if (n==57)
         return false;
      else if (n==58)
         return true;
      else if (n==59)
         return false;
      else if (n==60)
         return true;
      else if (n==61)
         return false;
      else if (n==62)
         return true;
      else if (n==63)
         return false;
      else if (n==64)
         return true;
      else if (n==65)
         return false;
      else if (n==66)
         return true;
      else if (n==67)
         return false;
      else if (n==68)
         return true;
      else if (n==69)
         return false;
      else if (n==70)
         return true;
      else if (n==71)
         return false;
      else if (n==72)
         return true;
      else if (n==73)
         return false;
      else if (n==74)
         return true;
      else if (n==75)
         return false;
      else if (n==76)
         return true;
      else if (n==77)
         return false;
      else if (n==78)
         return true;
      else if (n==79)
         return false;
      else if (n==80)
         return true;
      else if (n==81)
         return false;
      else if (n==82)
         return true;
      else if (n==83)
         return false;
      else if (n==84)
         return true;
      else if (n==85)
         return false;
      else if (n==86)
         return true;
      else if (n==87)
         return false;
      else if (n==88)
         return true;
      else if (n==89)
         return false;
      else if (n==90)
         return true;
      else if (n==91)
         return false;
      else if (n==92)
         return true;
      else if (n==93)
         return false;
      else if (n==94)
         return true;
      else if (n==95)
         return false;
      else if (n==96)
         return true;
      else if (n==97)
         return false;
      else if (n==98)
         return true;
      else if (n==99)
         return false;
      else if (n==100)
         return true;
        else
            return null;
    }
    
    
    
    
    
    
    

    private async void madeFUNC()
    {
        int num = 1;
        while (num < 101)
        {
            char n = 'n';
            string stringa = "else if (" + n +"=="+ num+")";
            string stringb = "   return true;";
            string stringc = "   return false;";
            await Task.Delay(100);
            if (num % 2 == 0)
            {
                Console.WriteLine(stringa);
                Console.WriteLine(stringb);
                num++;
                
            }
            else
            {
                Console.WriteLine(stringa);
                Console.WriteLine(stringc);
                num++;
            }
            
        }
    }


    private void Cartoonify_OnChecked(object sender, RoutedEventArgs e)
    {
       BitmapImage image = new BitmapImage(new Uri("pack://application:,,,/images/fulltaco.png"));
       taco.Source = image;
       taco.Width = 250;
       cartoonify.Content = "✔  Cartoon?";
    }

    private void Cartoonify_OnUnchecked(object sender, RoutedEventArgs e)
    {
       BitmapImage image = new BitmapImage(new Uri("pack://application:,,,/images/taco.jpg"));
       taco.Source = image;
       taco.Width = 190;
       cartoonify.Content = "❌  Cartoon?";
    }

    
}