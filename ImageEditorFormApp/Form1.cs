using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditorFormApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void loadImageButton_Click(object sender, EventArgs e) {

            //Bitmap bmp = new Bitmap(@"C:\Users\Aleksa\Desktop\face0.jpg");
            //pictureBox1.ImageLocation = @"C:\Users\Aleksa\Desktop\07-1.jpg";

            using(OpenFileDialog open_dialog = new OpenFileDialog()) {
                open_dialog.InitialDirectory = @"C:\Users\Aleksa\Desktop";
                open_dialog.Filter = "Image files (*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png";
                open_dialog.RestoreDirectory = true;

                if (open_dialog.ShowDialog() == DialogResult.OK) {
                    string file_path = open_dialog.FileName;

                    Bitmap original = new Bitmap(file_path);

                    double ratio = (double)original.Width / (double)original.Height;

                    Bitmap resizedImage;

                    if ((int)(double)boxOpen.Height * ratio <= boxOpen.Width) {
                        resizedImage = new Bitmap(original, (int)((double)boxOpen.Height * ratio), boxOpen.Height);
                    } else {
                        resizedImage = new Bitmap(original, boxOpen.Width, (int)((double)boxOpen.Width / ratio));
                    }

                    this.boxOpen.Image = resizedImage;

                    float maxLightness = 0;

                    for (int i = 0; i < resizedImage.Width; i++) {
                        for (int j = 0; j < resizedImage.Height; j++) {
                            if(resizedImage.GetPixel(i, j).GetBrightness() > maxLightness) {
                                maxLightness = resizedImage.GetPixel(i, j).GetBrightness();
                            }
                        }
                    }

                    // var minLightness = maxLightness - (maxLightness * 0.2);
                    var minLightness = maxLightness - 0.2;

                    Console.WriteLine("maxB: {0}, minB: {1}", maxLightness, minLightness);



                    //var result = AdjustBrightness.Adjust(resizedImage, 1, 1, 1, 1, 1, 0);
                    //this.boxPreview.Image = result;

                    var preview = new Bitmap(resizedImage);

                    for (int i = 0; i < preview.Width; i++) {
                        for (int j = 0; j < preview.Height; j++) {
                            if (preview.GetPixel(i, j).GetBrightness() <= maxLightness
                                    && preview.GetPixel(i, j).GetBrightness() >= minLightness) {
                                preview.SetPixel(i, j, Color.White);
                            }
                        }
                    }

                    boxPreview.Image = preview;

                    //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    //pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                }
            }


            // bmp.SetResolution(pictureBox1.Image.HorizontalResolution, pictureBox1.Image.VerticalResolution);
            //this.pictureBox1.Size = bmp.Size;
            

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) {
            var vertical = e.Y;
            var horizontal = e.X;

            Console.WriteLine("x, y: {0}, {1}", horizontal, vertical);

            if (boxOpen.Image != null) {
                Bitmap bmp = new Bitmap(boxOpen.Image);

                var pixel = bmp.GetPixel(horizontal, vertical);

                //hueText.Text = pixel.GetHue().ToString();
                //saturationText.Text = pixel.GetSaturation().ToString();
                //lightnessText.Text = pixel.GetBrightness().ToString();

                //redText.Text = pixel.R.ToString();
                //greenText.Text = pixel.G.ToString();
                //blueText.Text = pixel.B.ToString();

                //argbText.Text = pixel.ToArgb().ToString();
                //rgbText.Text = (pixel.R + pixel.G + pixel.B).ToString();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            var vertical = Cursor.Position.Y;
            var horizontal = Cursor.Position.X;

            if (boxOpen.Image != null) {
                Bitmap bmp = new Bitmap(boxOpen.Image);

                var pixel = bmp.GetPixel(horizontal, vertical);

                for (int i = 0; i < bmp.Width; i++) {
                    for (int j = 0; j < bmp.Height; j++) {

                        var tmp = bmp.GetPixel(i, j);

                        var color = tmp.R + tmp.G + tmp.B;

                        if (color >= 400 && color <= 550) {
                            bmp.SetPixel(i, j, Color.Red);
                        }

                    }
                }

                bmp.Save(@"C:\Users\Aleksa\Desktop\images\face_output.bmp");
            }

        }

        private void saveImageButton_Click(object sender, EventArgs e) {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Images|*.bmp;*.png;*.jpg";
            ImageFormat format = ImageFormat.Png; 

            if(save.ShowDialog() == DialogResult.OK) {
                string ext = System.IO.Path.GetExtension(save.FileName);

                switch (ext) {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                    default:
                        break;
                }

                boxPreview.Image.Save(save.FileName, format);

            }

        }
    }
}
