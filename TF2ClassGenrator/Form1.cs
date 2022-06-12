using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.IO.Compression;

namespace TF2ClassGenrator
{

    public partial class Form1 : Form
    {
        int Class = 0;

        public Form1()
        {
            string ImagesFolder = "Images";
            if(!Directory.Exists(ImagesFolder))
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://drive.google.com/u/0/uc?id=1x1ZOl7w4eGKVRsZ41KFwV4MSNm7FMCED&export=download", "tf2Weapons.txt");
                webClient.DownloadFile("https://drive.google.com/u/0/uc?id=1wd14YrQ5opyXMI_RBolb1JjKqMUg17TV&export=download", "Images.zip");
                ZipFile.ExtractToDirectory("Images.zip", ImagesFolder + "/..");
                File.Delete("Images.zip");
            }
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // Generate Button
        {
            Random random = new Random();
            Class = random.Next(1, 10);
            var weaponPath = "tf2Weapons.txt";
            string[] lines = System.IO.File.ReadAllLines(weaponPath);
            string imageLocation = "Images/";
            switch (Class)
            {
                case 1:
                    label1.Text = "Scout";
                    label2.Text = lines[random.Next(1, 6)];
                    label3.Text = lines[random.Next(7, 16)];
                    label4.Text = lines[random.Next(18, 29)];
                    PrimaryImage.ImageLocation = imageLocation + label2.Text + ".png";
                    SecondaryImage.ImageLocation = imageLocation + label3.Text + ".png";
                    MeleeImage.ImageLocation = imageLocation + label4.Text + ".png";
                    ExtraPicture.Visible = false;
                    label5.Visible = false;
                    break;
                case 2:
                    label1.Text = "Soldier";
                    label2.Text = lines[random.Next(30, 38)];
                    label3.Text = lines[random.Next(39, 48)];
                    label4.Text = lines[random.Next(49, 55)];
                    PrimaryImage.ImageLocation = imageLocation + label2.Text + ".png";
                    SecondaryImage.ImageLocation = imageLocation + label3.Text + ".png";
                    MeleeImage.ImageLocation = imageLocation + label4.Text + ".png";
                    ExtraPicture.Visible = false;
                    label5.Visible = false;
                    break;
                case 3:
                    label1.Text = "Pyro";
                    label2.Text = lines[random.Next(56, 62)];
                    label3.Text = lines[random.Next(63, 71)];
                    label4.Text = lines[random.Next(72, 83)];
                    PrimaryImage.ImageLocation = imageLocation + label2.Text + ".png";
                    SecondaryImage.ImageLocation = imageLocation + label3.Text + ".png";
                    MeleeImage.ImageLocation = imageLocation + label4.Text + ".png";
                    ExtraPicture.Visible = false;
                    label5.Visible = false;
                    break;
                case 4:
                    label1.Text = "Demoman";
                    label2.Text = lines[random.Next(84, 90)];
                    label3.Text = lines[random.Next(91, 97)];
                    label4.Text = lines[random.Next(98, 108)];
                    PrimaryImage.ImageLocation = imageLocation + label2.Text + ".png";
                    SecondaryImage.ImageLocation = imageLocation + label3.Text + ".png";
                    MeleeImage.ImageLocation = imageLocation + label4.Text + ".png";
                    ExtraPicture.Visible = false;
                    label5.Visible = false;
                    break;
                case 5:
                    label1.Text = "Heavy";
                    label2.Text = lines[random.Next(109, 114)];
                    label3.Text = lines[random.Next(115, 123)];
                    label4.Text = lines[random.Next(124, 132)];
                    PrimaryImage.ImageLocation = imageLocation + label2.Text + ".png";
                    SecondaryImage.ImageLocation = imageLocation + label3.Text + ".png";
                    MeleeImage.ImageLocation = imageLocation + label4.Text + ".png";
                    ExtraPicture.Visible = false;
                    label5.Visible = false;
                    break;
                case 6:
                    label1.Text = "Engineer";
                    label2.Text = lines[random.Next(133, 138)];
                    label3.Text = lines[random.Next(139, 144)];
                    label4.Text = lines[random.Next(145, 152)];
                    PrimaryImage.ImageLocation = imageLocation + label2.Text + ".png";
                    SecondaryImage.ImageLocation = imageLocation + label3.Text + ".png";
                    MeleeImage.ImageLocation = imageLocation + label4.Text + ".png";
                    ExtraPicture.Visible = false;
                    label5.Visible = false;
                    break;
                case 7:
                    label1.Text = "Medic";
                    label2.Text = lines[random.Next(154, 156)];
                    label3.Text = lines[random.Next(157, 160)];
                    label4.Text = lines[random.Next(161, 165)];
                    PrimaryImage.ImageLocation = imageLocation + label2.Text + ".png";
                    SecondaryImage.ImageLocation = imageLocation + label3.Text + ".png";
                    MeleeImage.ImageLocation = imageLocation + label4.Text + ".png";
                    ExtraPicture.Visible = false;
                    label5.Visible = false;
                    break;
                case 8:
                    label1.Text = "Sniper";
                    label2.Text = lines[random.Next(164, 173)];
                    label3.Text = lines[random.Next(174, 180)];
                    label4.Text = lines[random.Next(181, 184)];
                    PrimaryImage.ImageLocation = imageLocation + label2.Text + ".png";
                    SecondaryImage.ImageLocation = imageLocation + label3.Text + ".png";
                    MeleeImage.ImageLocation = imageLocation + label4.Text + ".png";
                    ExtraPicture.Visible = false;
                    label5.Visible = false;
                    break;
                case 9:
                    label5.Visible = true;
                    ExtraPicture.Visible = true;
                    label1.Text = "Spy";
                    label2.Text = lines[random.Next(187, 192)];
                    label3.Text = lines[random.Next(193, 199)];
                    label4.Text = lines[random.Next(205, 208)];
                    label5.Text = lines[random.Next(200, 204)];
                    PrimaryImage.ImageLocation = imageLocation + label2.Text + ".png";
                    SecondaryImage.ImageLocation = imageLocation + label3.Text + ".png";
                    MeleeImage.ImageLocation = imageLocation + label4.Text + ".png";
                    ExtraPicture.ImageLocation = imageLocation + label5.Text + ".png";
                    break;
            }

        }

    }
}
