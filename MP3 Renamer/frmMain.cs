using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MP3_Renamer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void cmdChooseFiles_Click(object sender, EventArgs e)
        {
            lstFilesToRename.Items.Clear();

            OpenFileDialog dlgOpenFile = new OpenFileDialog
                                             {
                                                 Filter = "MP3 Files (*.mp3)|*.mp3|All Files (*.*)|*.*",
                                                 Multiselect = true
                                             };
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string FileName in dlgOpenFile.FileNames)
                {
                    lstFilesToRename.Items.Add(FileName);
                }
            }
        }

        private void cmdRenameFiles_Click(object sender, EventArgs e)
        {
            foreach(string FileName in lstFilesToRename.Items)
            {
                try
                {
                    string FilePath = System.IO.Path.GetDirectoryName(FileName);

                    TagLib.File AudioFile = TagLib.File.Create(FileName);

                    string TrackNumber = AudioFile.Tag.Track.ToString("00");
                    string TrackName = AudioFile.Tag.Title;
                    string Artists = "";
                    foreach (string Performer in AudioFile.Tag.Performers)
                    {
                        Artists += Performer + ", ";
                    }
                    if (Artists != "")
                    {
                        // remove last ", "
                        Artists = Artists.Substring(0, Artists.Length - 2);
                    }

                    string NewFileName = String.Format("{0} - {1} - {2}.mp3", TrackNumber, TrackName, Artists);
                    string NewFullFileName = FilePath + "\\" + NewFileName;

                    Console.WriteLine(String.Format("Renaming \"{0}\" to \"{1}\"", FileName, NewFullFileName));
                    File.Move(FileName, NewFullFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception reading MP3: " + ex);
                }
            }
        }
    }
}
