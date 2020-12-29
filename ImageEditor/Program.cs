using System;
using System.Drawing;

namespace ImageEditor {
    class Program {

        private void Triangle() {
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < i; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args) {

            Bitmap rainbow = new Bitmap(@"C:\Users\Aleksa\Desktop\07-1.jpg");
            //Bitmap sample = new Bitmap(@"C:\Users\Aleksa\Desktop\outup.bmp");

            var height = rainbow.Height;
            var width = rainbow.Width;
            //Console.WriteLine("image height: {0}, image width: {1}", height, width);



            var pixel = rainbow.GetPixel(0, 0);
            var hue = Math.Ceiling(pixel.GetHue());
            var brightness = pixel.GetBrightness();
            Console.WriteLine("brightness: {0}", brightness);

            Console.WriteLine(hue);

            //Console.WriteLine(pixel.ToArgb());
            //Console.WriteLine(pixel.ToString());

            //Console.WriteLine(sample.GetPixel(0, 0).ToArgb());
            //Console.WriteLine(sample.GetPixel(0, 0).ToString());
            for (int j = 0; j < height; j++) {

                for (int i = 0; i < width; i++) {

                    var tmp = rainbow.GetPixel(i, j);

                    var x = Math.Ceiling(tmp.GetHue());

                    //if (colors.GetPixel(i, j).ToArgb() >= pixel.ToArgb() && sample.GetPixel(i, j).ToArgb() <= pixel.ToArgb()) {
                    if (x >= hue-1 && x <= hue+1 && tmp.GetBrightness() <= 1 && tmp.GetBrightness() >= 0) {
                        rainbow.SetPixel(i, j, Color.Red);
                        //Console.WriteLine("pixel at {0}, {1}: {2}", i, j, colors.GetPixel(i, j).ToArgb());
                    }
                }
            }
            rainbow.Save(@"C:\Users\Aleksa\Desktop\images\output11.bmp");
            for (int i = 1; i <= 5; i++) {
                Console.WriteLine("Changed: {0}%", i * 20);
                System.Threading.Thread.Sleep(1000);
            }

            Console.WriteLine("Color changed.");

        }
    }
}
