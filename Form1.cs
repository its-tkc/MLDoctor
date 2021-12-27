using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MLDoctorML.Model;

namespace MLDoctor
{
    public partial class Form1 : Form
    {
        string imagePath, cancerName;

        
        public Form1()
        {
            InitializeComponent();

            homePanel.Visible = true;
            dropPanel.Visible = false;
            ResourcesPanel.Visible = false;
            ContactPanel.Visible = false;
            ReadMore.Visible = false;
            


            homePanel.Location = new Point(180, 0);
            dropPanel.Location = new Point(180, 0);
            ResourcesPanel.Location = new Point(180, 0);
            ContactPanel.Location = new Point(180, 0);

            introBox.Text = "A Machine Learnig Based Artificial Doctor.\nLet's Start checkup :)";
            info.Text = "I am Skin Cancer Specialist.\nI can Diagnose you to predict,\npossible risk of cancerian cell developement\nin the body\nDrop an image and i'll give you a report.";
            copyright.Text = "This Software is Developed by Tushar K. Chand.\nAll Rights Reserved (c)2021.\n" +
                             "Resources: Mritunjaya Sharma";
            contact.Text = "Email: tusharkumar2806@gmail.com\nwww.github.com/its-tkc\nwww.linkedin.com/in/its-tkc";

            resInfo.Text = "Skin cancers, the abnormal growth of skin cells.\nmost often develops on skin exposed to the sun.But this common form of \ncancer can also occur on areas of your skin\nnot ordinarily exposed to sunlight.\nThere are three major types of skin cancer\n1. Basal cell carcinoma\n2. Squamous cell carcinoma\n3. Melanoma.\n" +
                           "You can reduce your risk of skin cancer\nby limiting or avoiding exposure to ultraviolet (UV) radiation.\n\nChecking your skin for suspicious changes can help detect skin cancer at its earliest stages.\nEarly detection of skin cancer gives you the greatest chance\nfor successful skin cancer treatment.\n\n" +
                           "Skin cancer affects people of all skin tones, including those with darker complexions.";
           
        }

       

        public void SubmitButton_Click(object sender, EventArgs e)
        {
            
            // Add input data
            var input = new ModelInput();
            input.ImageSource = imagePath;
           

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            

            DebugBox.Text = "Please wait analysing...";

            if(result.Prediction == "Basal Cell Carcinoma")
            {
                ReadMore.Visible = true;
                cancerName = "Basal Cell Carcinoma";
                DebugBox.Text = result.Prediction;
                PrintBox.Text = "basal cell cancer, is the most common type of skin cancer.\nIt often appears as a painless raised area of skin, which may be shiny\nwith small blood vessels running over it.\n" +
                                "Basal cell cancer grows slowly and can damage\nthe tissue around it.\nBut it is unlikely to spread to distant areas or result in death";
               
            }

            else if (result.Prediction == "Melanoma")
            {
                ReadMore.Visible = true;
                cancerName = "Melanoma";
                DebugBox.Text = result.Prediction;
                PrintBox.Text = "Melanoma is a disease in which malignant (cancer) cells form in melanocytes,\ncells that color the skin)\nThere are different types of cancer. Melanoma can occur anywhere on the skin.\n\n" +
                                "Unusual moles, exposure to sunlight, and health history can affect the risk of melanoma.\nSigns of melanoma include a change in the way a mole or pigmented area looks.";

            }

            else if (result.Prediction == "Merkel Cell Cancer")
            {
                ReadMore.Visible = true;
                cancerName = "Merkel Cell Cancer";
                DebugBox.Text = result.Prediction;
                PrintBox.Text = "Merkel cell carcinoma is a very rare disease in which malignant (cancer) cells form in the skin.\nSun exposure and having a weak immune system can affect the risk of Merkel cell carcinoma.\n" +
                                "Merkel cell carcinoma usually appears as a single painless lump on sun-exposed skin.\nCertain factors affect prognosis (chance of recovery) and treatment options.\nTests and procedures that examine the skin are used to diagnose Merkel cell carcinoma.";

            }

            else if (result.Prediction == "Squamous Cell Carcinoma")
            {
                ReadMore.Visible = true;
                cancerName = "Squamous Cell Carcinoma";
                DebugBox.Text = result.Prediction;
                PrintBox.Text = "Cancer that begins in squamous cells.\nSquamous cells are thin, flat cells that look like fish scales,\nand are found in the tissue that forms the surface of the skin.\n\n" +
                                "the lining of the hollow organs of the body,\nand the lining of the respiratory and digestive tracts.\nMost cancers of the anus, cervix, head and neck, and vagina are squamous cell carcinomas.";

            }

            else
            {
                PrintBox.Text = "Sorry Couldn't Identify the disease.";
            }
        }

        public void SelectImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";

            if(open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                imagePath = open.FileName;
                
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DropBtn_Click(object sender, EventArgs e)
        {
            dropPanel.Visible = true;
            homePanel.Visible = false;
            ContactPanel.Visible = false;
            ResourcesPanel.Visible = false;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            dropPanel.Visible = false;
            ContactPanel.Visible = false;
            ResourcesPanel.Visible = false;
        }

        private void ResourcesBtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            dropPanel.Visible = false;
            ContactPanel.Visible = false;
            ResourcesPanel.Visible = true;
        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            dropPanel.Visible = false;
            ContactPanel.Visible = true;
            ResourcesPanel.Visible = false;
        }

        private void resbtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo
            {
                FileName = "https://www.cancer.gov/types/skin",
                UseShellExecute = true
            };
            Process.Start(sInfo);
        }

        private void ReadMore_Click(object sender, EventArgs e)
        {
            if (cancerName == "Squamous Cell Carcinoma")
            {
                ProcessStartInfo sInfo = new ProcessStartInfo
                {
                    FileName = "https://en.wikipedia.org/wiki/Squamous_cell_carcinoma",
                    UseShellExecute = true
                };
                Process.Start(sInfo);
            }

            if (cancerName == "Merkel Cell Cancer")
            {
                ProcessStartInfo sInfo = new ProcessStartInfo
                {
                    FileName = "https://en.wikipedia.org/wiki/Merkel-cell_carcinoma",
                    UseShellExecute = true
                };
                Process.Start(sInfo);
            }

            if (cancerName == "Basal Cell Carcinoma")
            {
                ProcessStartInfo sInfo = new ProcessStartInfo
                {
                    FileName = "https://en.wikipedia.org/wiki/Basal-cell_carcinoma",
                    UseShellExecute = true
                };
                Process.Start(sInfo);
            }

            if (cancerName == "Melanoma")
            {
                ProcessStartInfo sInfo = new ProcessStartInfo
                {
                    FileName = "https://en.wikipedia.org/wiki/Melanoma",
                    UseShellExecute = true
                };
                Process.Start(sInfo);
            }
        }
    }
}
