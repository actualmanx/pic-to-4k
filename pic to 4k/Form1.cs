using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;
using System.IO;
using System.Configuration;
using System.Diagnostics;
using System.Collections.Specialized;
using Utility.ModifyRegistry;
using Microsoft.Win32;

namespace pic_to_4k
{
    public partial class PicResize : Form


    {
        


        

        public PicResize()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Image Files |*.JPEG;*.PNG;*.GIF;*.BMP;*.JPG";

            fileStripStatusLabel1.Text = myRegistry.Read("File Location");
            this.DragEnter += new DragEventHandler(Form_DragEnter);
            this.DragDrop += new DragEventHandler(Form_DragDrop);
        }


        void Form_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the Data format of the data can be accepted
            // (we only accept file drops from Explorer, etc.)
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; // Okay
            else
                e.Effect = DragDropEffects.None; // Unknown data, ignore it

        }

        void Form_DragDrop(object sender, DragEventArgs e)
        {
            // clear the label
            fileStripStatusLabel1.Text = String.Empty;
            // Extract the data from the DataObject-Container into a string list
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            // Do something with the data...

            // For example add all files into a simple label control:
            foreach (string File in FileList)
                this.fileStripStatusLabel1.Text += File;
            myRegistry.Write("File Location", this.fileStripStatusLabel1.Text);
        }
        ModifyRegistry myRegistry = new ModifyRegistry();

        private void inputbutton_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                myRegistry.Write("File Location", openFileDialog1.FileName);
                fileStripStatusLabel1.Text = myRegistry.Read("File Location");
            }
        }

        private void outputandsave_Click(object sender, EventArgs e)
        {
            string inputPath = fileStripStatusLabel1.Text;
            string outputPath = fileStripStatusLabel1.Text + ("." + formatComboBox.Text).ToLower();
            int outputWidth = int.Parse(widthtextBox1.Text);  // Convert string to int
            int outputHeight = int.Parse(heighttextBox1.Text);  // Convert string to int

            using (Image inputImage = Image.FromFile(inputPath))
            using (Bitmap outputImage = new Bitmap(outputWidth, outputHeight))
            using (Graphics graphics = Graphics.FromImage(outputImage))
            {
                for (int x = 0; x < outputWidth; x += inputImage.Width)
                {
                    for (int y = 0; y < outputHeight; y += inputImage.Height)
                    {
                        graphics.DrawImage(inputImage, new Point(x, y));
                    }
                }

                // Determine the ImageFormat based on the selected item in the ComboBox
                System.Drawing.Imaging.ImageFormat format;
                switch (formatComboBox.SelectedItem.ToString())
                {
                    case "PNG":
                        format = System.Drawing.Imaging.ImageFormat.Png;
                        break;
                    case "JPEG":
                        format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                    case "BMP":
                        format = System.Drawing.Imaging.ImageFormat.Bmp;
                        break;
                    case "GIF":
                        format = System.Drawing.Imaging.ImageFormat.Gif;
                        break;
                    default:
                        throw new Exception("Unsupported image format.");
                }

                outputImage.Save(outputPath, format);
            }
        }
        }
    }

    

