﻿using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Enumerations;
using KryptonApplicationUpdater.Classes.SettingsManager;
using KryptonApplicationUpdater.Interfaces;
using KryptonExtendedToolkit.Base.Code;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Tooling.Classes.Other;
using Tooling.UX;

namespace Playground
{
    public partial class Form1 : KryptonForm, IUpdatable
    {
        private UtilityMethods utilityMethods = new UtilityMethods();
        private InternalApplicationUpdaterSettingsManager internalApplicationUpdaterSettingsManager = new InternalApplicationUpdaterSettingsManager();
        private MostRecentlyUsedFileManager mostRecentlyUsedFileManager;
        private Version currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
        private ToolStripNonClientRenderer toolStripNonClientRenderer;

        public Form1()
        {
            InitializeComponent();

            tsTest.Renderer = new ToolStripNonClientRenderer();
        }

        #region IUpdatable Implementation
        public Icon ApplicationIcon { get { return this.Icon; } set { } }
        public string ServerXMLFileURL { get { return "https://www.dropbox.com/s/mwyexz1baqt0y4b/Update.xml?dl=0"; } set { } }
        public string ApplicationName { get { return "Playground"; } set { } }
        public string CurrentApplicationVersion { get { return currentVersion.ToString(); } set { } }
        public string ApplicationIdentification { get { return "Playground"; } set { } }
        Form IUpdatable.ParentForm { get { return this; } set { } }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            mostRecentlyUsedFileManager = new MostRecentlyUsedFileManager(recentDocumentsToolStripMenuItem, "Playground", MyOwnRecentFileGotClicked_Handler, MyOwnRecentFilesGotCleared_Handler);

            kuacsbElevate.ProcessName = Process.GetCurrentProcess().ProcessName;

            if (ServerXMLFileURL != null)
            {
                internalApplicationUpdaterSettingsManager.SetXMLFileURL(ServerXMLFileURL);
            }

            if (utilityMethods.GetHasElevateProcessWithAdministrativeRights())
            {
                Text = Text + " (Administrator)";
            }

            klblAdminMode.Text = $"Is running in Administrator mode: { utilityMethods.GetHasElevateProcessWithAdministrativeRights().ToString() }";

            //kctb1.CueText = "Hello";

            //kryptonCommandLinkVersion11.Note = "Hello";

            lblVersion.Text = $"Version: { currentVersion.ToString() }";

            etslBlinkTest.SoftBlink(etslBlinkTest.AlertColourOne, etslBlinkTest.AlertColourTwo, etslBlinkTest.AlertTextColour, 2000, false, 5);
        }

        private void MyOwnRecentFileGotClicked_Handler(object sender, EventArgs e)
        {
            string fileName = (sender as ToolStripItem).Text;

            if (!File.Exists(fileName))
            {
                if (KryptonMessageBox.Show($"{ fileName } doesn't exist. Remove from recent workspaces?", "File not found", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    mostRecentlyUsedFileManager.RemoveRecentFile(fileName);
                }
                else
                {
                    return;
                }
            }

            OpenFile(fileName);
        }

        private void MyOwnRecentFilesGotCleared_Handler(object sender, EventArgs e)
        {

        }

        private void OpenFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                //rtbTextPad.LoadFile(filePath);

                StreamReader reader = new StreamReader(filePath);

                rtbTextPad.Text = reader.ReadToEnd();

                mostRecentlyUsedFileManager.AddRecentFile(filePath);
            }
            else
            {
                KryptonMessageBox.Show($"Error: file '{ filePath }' could not be found!");
            }
        }

        private void SaveFile(string filePath, bool saveAs = false)
        {
            if (saveAs)
            {

            }
            else
            {

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileDialog openFileDlg = new OpenFileDialog();

            openFileDlg.InitialDirectory = Environment.CurrentDirectory;


            if (openFileDlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string openedFile = openFileDlg.FileName;

            OpenFile(openedFile);
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Save file as:";

            saveFileDialog.Filter = "Normal Text Files (*.txt)|*.txt";

            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog.FileName);

                writer.Write(krtbEditor.Text);

                mostRecentlyUsedFileManager.AddRecentFile(Path.GetFullPath(saveFileDialog.FileName));
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            ColourRGBToHexadecimalConverter colourRGBToHexadecimalConverter = new ColourRGBToHexadecimalConverter();

            colourRGBToHexadecimalConverter.Show();
        }

        private void tsAlignLeft_Click(object sender, EventArgs e)
        {
            rxrbTextPad.SelectionAlignment = TextAlignment.LEFT;
        }

        private void tsAlignCentre_Click(object sender, EventArgs e)
        {
            rxrbTextPad.SelectionAlignment = TextAlignment.CENTRE;
        }

        private void tsAlignRight_Click(object sender, EventArgs e)
        {
            rxrbTextPad.SelectionAlignment = TextAlignment.RIGHT;
        }

        private void tsJustify_Click(object sender, EventArgs e)
        {
            rxrbTextPad.SelectionAlignment = TextAlignment.JUSTIFY;
        }

        private void kbtnHexToRGB_Click(object sender, EventArgs e)
        {
            ColourHexadecimalToRGBConverter colourHexadecimalToRGBConverter = new ColourHexadecimalToRGBConverter();

            colourHexadecimalToRGBConverter.Show();
        }

        private void kbtnColourMixer_Click(object sender, EventArgs e)
        {
            ColourMixer colourMixer = new ColourMixer(255, 255, 255, 255);

            colourMixer.Show();
        }
    }
}