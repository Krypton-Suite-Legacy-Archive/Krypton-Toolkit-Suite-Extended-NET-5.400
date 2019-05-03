﻿using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;
using ToolkitSettings.Settings.Palette_Explorer.Colours;

namespace ToolkitSettings.Classes.PaletteExplorer.Colours
{
    public class CustomTextColourSettingsManager
    {
        #region Variables
        private bool _alwaysUsePrompt = false, _settingsModified = false;

        private CustomTextColourSettings _customTextColourSettings = new CustomTextColourSettings();
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets a value indicating whether [always use prompt].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [always use prompt]; otherwise, <c>false</c>.
        /// </value>
        public bool AlwaysUsePrompt
        {
            get
            {
                return _alwaysUsePrompt;
            }

            set
            {
                _alwaysUsePrompt = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [settings modified].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [settings modified]; otherwise, <c>false</c>.
        /// </value>
        public bool SettingsModified
        {
            get
            {
                return _settingsModified;
            }

            set
            {
                _settingsModified = value;
            }
        }
        #endregion

        #region Settings Manipulation
        /// <summary>
        /// Sets the value of AlwaysUsePrompt to value.
        /// </summary>
        /// <param name="value">The value of AlwaysUsePrompt.</param>
        public void SetAlwaysUsePrompt(bool value)
        {
            AlwaysUsePrompt = value;
        }

        /// <summary>
        /// Returns the value of AlwaysUsePrompt.
        /// </summary>
        /// <returns>The value of AlwaysUsePrompt.</returns>
        public bool GetAlwaysUsePrompt()
        {
            return AlwaysUsePrompt;
        }

        /// <summary>
        /// Sets the value of SettingsModified to value.
        /// </summary>
        /// <param name="value">The value of SettingsModified.</param>
        public void SetSettingsModified(bool value)
        {
            SettingsModified = value;
        }

        /// <summary>
        /// Returns the value of SettingsModified.
        /// </summary>
        /// <returns>The value of SettingsModified.</returns>
        public bool GetSettingsModified()
        {
            return SettingsModified;
        }
        #endregion

        #region Constructors
        public CustomTextColourSettingsManager()
        {

        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the value of CustomTextColourOne to colour.
        /// </summary>
        /// <param name="colour">The value of CustomTextColourOne.</param>
        public void SetCustomTextColourOne(Color colour)
        {
            _customTextColourSettings.CustomTextColourOne = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomTextColourOne.
        /// </summary>
        /// <returns>The value of CustomTextColourOne.</returns>
        public Color GetCustomTextColourOne()
        {
            return _customTextColourSettings.CustomTextColourOne;
        }

        /// <summary>
        /// Sets the value of CustomTextColourTwo to colour.
        /// </summary>
        /// <param name="colour">The value of CustomTextColourTwo.</param>
        public void SetCustomTextColourTwo(Color colour)
        {
            _customTextColourSettings.CustomTextColourTwo = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomTextColourTwo.
        /// </summary>
        /// <returns>The value of CustomTextColourTwo.</returns>
        public Color GetCustomTextColourTwo()
        {
            return _customTextColourSettings.CustomTextColourTwo;
        }

        /// <summary>
        /// Sets the value of CustomTextColourThree to colour.
        /// </summary>
        /// <param name="colour">The value of CustomTextColourThree.</param>
        public void SetCustomTextColourThree(Color colour)
        {
            _customTextColourSettings.CustomTextColourThree = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomTextColourThree.
        /// </summary>
        /// <returns>The value of CustomTextColourThree.</returns>
        public Color GetCustomTextColourThree()
        {
            return _customTextColourSettings.CustomTextColourThree;
        }

        /// <summary>
        /// Sets the value of CustomTextColourFour to colour.
        /// </summary>
        /// <param name="colour">The value of CustomTextColourFour.</param>
        public void SetCustomTextColourFour(Color colour)
        {
            _customTextColourSettings.CustomTextColourFour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomTextColourFour.
        /// </summary>
        /// <returns>The value of CustomTextColourFour.</returns>
        public Color GetCustomTextColourFour()
        {
            return _customTextColourSettings.CustomTextColourFour;
        }

        /// <summary>
        /// Sets the value of CustomTextColourFive to colour.
        /// </summary>
        /// <param name="colour">The value of CustomTextColourFive.</param>
        public void SetCustomTextColourFive(Color colour)
        {
            _customTextColourSettings.CustomTextColourFive = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomTextColourFive.
        /// </summary>
        /// <returns>The value of CustomTextColourFive.</returns>
        public Color GetCustomTextColourFive()
        {
            return _customTextColourSettings.CustomTextColourFive;
        }

        /// <summary>
        /// Sets the value of CustomTextColourSix to colour.
        /// </summary>
        /// <param name="colour">The value of CustomTextColourSix.</param>
        public void SetCustomTextColourSix(Color colour)
        {
            _customTextColourSettings.CustomTextColourSix = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomTextColourSix.
        /// </summary>
        /// <returns>The value of CustomTextColourSix.</returns>
        public Color GetCustomTextColourSix()
        {
            return _customTextColourSettings.CustomTextColourSix;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Resets to defaults.
        /// </summary>
        public void ResetToDefaults()
        {
            if (KryptonMessageBox.Show("WARNING! You are about to reset these settings back to their original state. This action cannot be undone!\nDo you want to proceed?", "Reset Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                SetCustomTextColourOne(Color.Empty);

                SetCustomTextColourTwo(Color.Empty);

                SetCustomTextColourThree(Color.Empty);

                SetCustomTextColourFour(Color.Empty);

                SetCustomTextColourFive(Color.Empty);

                SetCustomTextColourSix(Color.Empty);

                if (KryptonMessageBox.Show($"Done! Do you want to restart the application now?", "Action Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }

        /// <summary>
        /// Saves the XML file application updater settings.
        /// </summary>
        /// <param name="alwaysUsePrompt">if set to <c>true</c> [always use prompt].</param>
        public void SaveXMLFileApplicationUpdaterSettings(bool alwaysUsePrompt = false)
        {
            if (alwaysUsePrompt)
            {
                if (KryptonMessageBox.Show("You have changed a setting value. Do you want to save these changes?", "Setting Values Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _customTextColourSettings.Save();

                    SetSettingsModified(false);
                }
            }
            else
            {
                _customTextColourSettings.Save();

                SetSettingsModified(false);
            }
        }
        #endregion
    }
}