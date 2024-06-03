using System.ComponentModel.DataAnnotations;
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

namespace Space_Invaders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Properties

        int displayHeight = 400;
        int displayWidth = 500;
        
        RGBBitmap frame;


        #endregion
        public MainWindow()
        {
            InitializeComponent();

            display.Height = displayHeight;
            display.Width = displayWidth;
            frame = new RGBBitmap(displayWidth,displayHeight);

            display.Source = BitmapDecoder frame;
             
            

        }

        public class RGB
        {
            public int Red;
            public int Green;
            public int Blue;

            public RGB(int red, int green, int blue)
            {
                Red = red;
                Green = green;
                Blue = blue;

            }

        }

        public class RGBBitmap
        {
            public RGB[,] bitmap;

            public RGBBitmap(int hight, int width)
            {
                bitmap = new RGB[hight, width];
                bitmap = InializeRGBBitmap(bitmap);
            }

            public RGB[,] InializeRGBBitmap(RGB[,]rgbBitmap)
            {
                for (int y = 0; y < rgbBitmap.GetLength(1); y++)
                {
                    for (int x = 0; x < rgbBitmap.GetLength(0); x++)
                    {
                        rgbBitmap[x, y].Red = 100;
                        rgbBitmap[x, y].Green = 100;
                        rgbBitmap[x, y].Blue = 100;
                    }
                }
                return rgbBitmap;
            }
        }


        
    }


}