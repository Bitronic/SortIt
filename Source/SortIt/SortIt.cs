using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace SortIt
{
    public partial class SortIt : Form
    {
        string origin_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GitHub\SortIt\origin\";
        string destination_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GitHub\SortIt\Destination\";
        List<string> filePaths = new List<string>();
        List<string> sortFolders_Paths = new List<string>(); //paths 
        List<string> sortFolders_Names = new List<string>();  //Names
        List<Button> sortButtons = new List<Button>();
        //Public properties for controls
        public Label lbl_NumberOfFoundFiles
        {
            get { return lbl_numberOfFoundFiles; }
            set { lbl_numberOfFoundFiles = value; }
        }
        public PictureBox picBox_ShowFile 
        {
            get {return picBox_showFile;}
            set {picBox_showFile = value;}
        }
        public SortIt()
        {
            InitializeComponent();
        }

        private void btn_LoadFiles_Click(object sender, EventArgs e)
        {
            filePaths = System.IO.Directory.GetFiles(origin_path).ToList();
            lbl_NumberOfFoundFiles.Text = filePaths.Count.ToString() + " Dateien gefunden";
            //shows files of folder
            if (filePaths.Count > 0)    //If there are files in the origin folder
            {
                Image currentImage = null;
                //foreach (string path in filePaths)
                //{
                //    try
                //    {
                //        currentImage = Image.FromFile(path);
                //    }
                //    catch
                //    {
                //        MessageBox.Show("Ungültige Datei gefunden: " + path);
                //    }
                //    picBox_ShowFile.BackgroundImage = currentImage;
                //}
                currentImage = Image.FromFile(filePaths[1]);
                picBox_ShowFile.Image = currentImage;
            }
            else    //If no files detected
            {
                MessageBox.Show("Bitte zuerst Datein laden!");
            }
        }

        private void btn_SelectSortFolders_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderBrowser = new CommonOpenFileDialog();
            folderBrowser.IsFolderPicker = true;
            folderBrowser.Multiselect = true;
            CommonFileDialogResult result = folderBrowser.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                sortFolders_Paths = folderBrowser.FileNames.ToList();
                foreach (string folder in sortFolders_Paths)
                {
                    sortFolders_Names.Add(folder.Remove(0, folder.LastIndexOf(@"\") + 1));    // +1 because of 0-based
                }
            }

            //Generates buttons for all sort folders
            foreach (string folderName in sortFolders_Names)
            {
                Button newButton = new Button();
                newButton.Text = folderName;
                newButton.Click += new System.EventHandler(MoveFile);
                newButton.AutoSize = true;
                sortButtons.Add(newButton);
                panel_ShowSortFolders.Controls.Add(newButton);
            }
        }
        private void MoveFile(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Text);
            string Path = sortFolders_Paths.Find(folder => folder.Contains(@"\" + (sender as Button).Text));
            MessageBox.Show(Path);
        }
    }
}
