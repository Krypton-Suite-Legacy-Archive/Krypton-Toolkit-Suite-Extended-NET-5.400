﻿using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;
using ToolkitSettings.Settings.Palette_Explorer.Colours;

namespace ToolkitSettings.Classes.PaletteExplorer.Colours
{
    public class AllMergedColourSettingsManager
    {
        #region Variables
        private bool _alwaysUsePrompt = false, _settingsModified = false;

        private AllMergedColourSettings _allMergedColourSettings = new AllMergedColourSettings();
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
        public AllMergedColourSettingsManager()
        {

        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the value of BaseColour to colour.
        /// </summary>
        /// <param name="colour">The value of BaseColour.</param>
        public void SetBaseColour(Color colour)
        {
            _allMergedColourSettings.BaseColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of BaseColour.
        /// </summary>
        /// <returns>The value of BaseColour.</returns>
        public Color GetBaseColour()
        {
            return _allMergedColourSettings.BaseColour;
        }

        /// <summary>
        /// Sets the value of DarkColour to colour.
        /// </summary>
        /// <param name="colour">The value of DarkColour.</param>
        public void SetDarkColour(Color colour)
        {
            _allMergedColourSettings.DarkColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of DarkColour.
        /// </summary>
        /// <returns>The value of DarkColour.</returns>
        public Color GetDarkColour()
        {
            return _allMergedColourSettings.DarkColour;
        }

        /// <summary>
        /// Sets the value of MediumColour to colour.
        /// </summary>
        /// <param name="colour">The value of MediumColour.</param>
        public void SetMediumColour(Color colour)
        {
            _allMergedColourSettings.MediumColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of MediumColour.
        /// </summary>
        /// <returns>The value of MediumColour.</returns>
        public Color GetMediumColour()
        {
            return _allMergedColourSettings.MediumColour;
        }

        /// <summary>
        /// Sets the value of LightColour to colour.
        /// </summary>
        /// <param name="colour">The value of LightColour.</param>
        public void SetLightColour(Color colour)
        {
            _allMergedColourSettings.LightColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of LightColour.
        /// </summary>
        /// <returns>The value of LightColour.</returns>
        public Color GetLightColour()
        {
            return _allMergedColourSettings.LightColour;
        }

        /// <summary>
        /// Sets the value of LightestColour to colour.
        /// </summary>
        /// <param name="colour">The value of LightestColour.</param>
        public void SetLightestColour(Color colour)
        {
            _allMergedColourSettings.LightestColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of LightestColour.
        /// </summary>
        /// <returns>The value of LightestColour.</returns>
        public Color GetLightestColour()
        {
            return _allMergedColourSettings.LightestColour;
        }

        /// <summary>
        /// Sets the value of CustomColourOne to colour.
        /// </summary>
        /// <param name="colour">The value of CustomColourOne.</param>
        public void SetCustomColourOne(Color colour)
        {
            _allMergedColourSettings.CustomColourOne = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomColourOne.
        /// </summary>
        /// <returns>The value of CustomColourOne.</returns>
        public Color GetCustomColourOne()
        {
            return _allMergedColourSettings.CustomColourOne;
        }

        /// <summary>
        /// Sets the value of CustomColourTwo to colour.
        /// </summary>
        /// <param name="colour">The value of CustomColourTwo.</param>
        public void SetCustomColourTwo(Color colour)
        {
            _allMergedColourSettings.CustomColourTwo = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomColourTwo.
        /// </summary>
        /// <returns>The value of CustomColourTwo.</returns>
        public Color GetCustomColourTwo()
        {
            return _allMergedColourSettings.CustomColourTwo;
        }

        /// <summary>
        /// Sets the value of CustomColourThree to colour.
        /// </summary>
        /// <param name="colour">The value of CustomColourThree.</param>
        public void SetCustomColourThree(Color colour)
        {
            _allMergedColourSettings.CustomColourThree = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomColourThree.
        /// </summary>
        /// <returns>The value of CustomColourThree.</returns>
        public Color GetCustomColourThree()
        {
            return _allMergedColourSettings.CustomColourThree;
        }

        /// <summary>
        /// Sets the value of CustomColourFour to colour.
        /// </summary>
        /// <param name="colour">The value of CustomColourFour.</param>
        public void SetCustomColourFour(Color colour)
        {
            _allMergedColourSettings.CustomColourFour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomColourFour.
        /// </summary>
        /// <returns>The value of CustomColourFour.</returns>
        public Color GetCustomColourFour()
        {
            return _allMergedColourSettings.CustomColourFour;
        }

        /// <summary>
        /// Sets the value of CustomColourFive to colour.
        /// </summary>
        /// <param name="colour">The value of CustomColourFive.</param>
        public void SetCustomColourFive(Color colour)
        {
            _allMergedColourSettings.CustomColourFive = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomColourFive.
        /// </summary>
        /// <returns>The value of CustomColourFive.</returns>
        public Color GetCustomColourFive()
        {
            return _allMergedColourSettings.CustomColourFive;
        }

        /// <summary>
        /// Sets the value of CustomColourSix to colour.
        /// </summary>
        /// <param name="colour">The value of CustomColourSix.</param>
        public void SetCustomColourSix(Color colour)
        {
            _allMergedColourSettings.CustomColourSix = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomColourSix.
        /// </summary>
        /// <returns>The value of CustomColourSix.</returns>
        public Color GetCustomColourSix()
        {
            return _allMergedColourSettings.CustomColourSix;
        }

        /// <summary>
        /// Sets the value of CustomTextColourOne to colour.
        /// </summary>
        /// <param name="colour">The value of CustomTextColourOne.</param>
        public void SetCustomTextColourOne(Color colour)
        {
            _allMergedColourSettings.CustomTextColourOne = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomTextColourOne.
        /// </summary>
        /// <returns>The value of CustomTextColourOne.</returns>
        public Color GetCustomTextColourOne()
        {
            return _allMergedColourSettings.CustomTextColourOne;
        }

        /// <summary>
        /// Sets the value of CustomTextColourTwo to colour.
        /// </summary>
        /// <param name="colour">The value of CustomTextColourTwo.</param>
        public void SetCustomTextColourTwo(Color colour)
        {
            _allMergedColourSettings.CustomTextColourTwo = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomTextColourTwo.
        /// </summary>
        /// <returns>The value of CustomTextColourTwo.</returns>
        public Color GetCustomTextColourTwo()
        {
            return _allMergedColourSettings.CustomTextColourTwo;
        }

        /// <summary>
        /// Sets the value of CustomTextColourThree to colour.
        /// </summary>
        /// <param name="colour">The value of CustomTextColourThree.</param>
        public void SetCustomTextColourThree(Color colour)
        {
            _allMergedColourSettings.CustomTextColourThree = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomTextColourThree.
        /// </summary>
        /// <returns>The value of CustomTextColourThree.</returns>
        public Color GetCustomTextColourThree()
        {
            return _allMergedColourSettings.CustomTextColourThree;
        }

        /// <summary>
        /// Sets the value of CustomTextColourFour to colour.
        /// </summary>
        /// <param name="colour">The value of CustomTextColourFour.</param>
        public void SetCustomTextColourFour(Color colour)
        {
            _allMergedColourSettings.CustomTextColourFour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomTextColourFour.
        /// </summary>
        /// <returns>The value of CustomTextColourFour.</returns>
        public Color GetCustomTextColourFour()
        {
            return _allMergedColourSettings.CustomTextColourFour;
        }

        /// <summary>
        /// Sets the value of CustomTextColourFive to colour.
        /// </summary>
        /// <param name="colour">The value of CustomTextColourFive.</param>
        public void SetCustomTextColourFive(Color colour)
        {
            _allMergedColourSettings.CustomTextColourFive = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomTextColourFive.
        /// </summary>
        /// <returns>The value of CustomTextColourFive.</returns>
        public Color GetCustomTextColourFive()
        {
            return _allMergedColourSettings.CustomTextColourFive;
        }

        /// <summary>
        /// Sets the value of CustomTextColourSix to colour.
        /// </summary>
        /// <param name="colour">The value of CustomTextColourSix.</param>
        public void SetCustomTextColourSix(Color colour)
        {
            _allMergedColourSettings.CustomTextColourSix = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of CustomTextColourSix.
        /// </summary>
        /// <returns>The value of CustomTextColourSix.</returns>
        public Color GetCustomTextColourSix()
        {
            return _allMergedColourSettings.CustomTextColourSix;
        }

        /// <summary>
        /// Sets the value of LinkFocusedColour to colour.
        /// </summary>
        /// <param name="colour">The value of LinkFocusedColour.</param>
        public void SetLinkFocusedColour(Color colour)
        {
            _allMergedColourSettings.LinkFocusedColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of LinkFocusedColour.
        /// </summary>
        /// <returns>The value of LinkFocusedColour.</returns>
        public Color GetLinkFocusedColour()
        {
            return _allMergedColourSettings.LinkFocusedColour;
        }

        /// <summary>
        /// Sets the value of LinkHoverColour to colour.
        /// </summary>
        /// <param name="colour">The value of LinkHoverColour.</param>
        public void SetLinkHoverColour(Color colour)
        {
            _allMergedColourSettings.LinkHoverColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of LinkHoverColour.
        /// </summary>
        /// <returns>The value of LinkHoverColour.</returns>
        public Color GetLinkHoverColour()
        {
            return _allMergedColourSettings.LinkHoverColour;
        }

        /// <summary>
        /// Sets the value of LinkNormalColour to colour.
        /// </summary>
        /// <param name="colour">The value of LinkNormalColour.</param>
        public void SetLinkNormalColour(Color colour)
        {
            _allMergedColourSettings.LinkNormalColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of LinkNormalColour.
        /// </summary>
        /// <returns>The value of LinkNormalColour.</returns>
        public Color GetLinkNormalColour()
        {
            return _allMergedColourSettings.LinkNormalColour;
        }

        /// <summary>
        /// Sets the value of LinkVisitedColour to colour.
        /// </summary>
        /// <param name="colour">The value of LinkVisitedColour.</param>
        public void SetLinkVisitedColour(Color colour)
        {
            _allMergedColourSettings.LinkVisitedColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of LinkVisitedColour.
        /// </summary>
        /// <returns>The value of LinkVisitedColour.</returns>
        public Color GetLinkVisitedColour()
        {
            return _allMergedColourSettings.LinkVisitedColour;
        }

        /// <summary>
        /// Sets the value of BorderColour to colour.
        /// </summary>
        /// <param name="colour">The value of BorderColour.</param>
        public void SetBorderColour(Color colour)
        {
            _allMergedColourSettings.BorderColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of BorderColour.
        /// </summary>
        /// <returns>The value of BorderColour.</returns>
        public Color GetBorderColour()
        {
            return _allMergedColourSettings.BorderColour;
        }

        /// <summary>
        /// Sets the value of DisabledControlColour to colour.
        /// </summary>
        /// <param name="colour">The value of DisabledControlColour.</param>
        public void SetDisabledControlColour(Color colour)
        {
            _allMergedColourSettings.DisabledControlColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of DisabledControlColour.
        /// </summary>
        /// <returns>The value of DisabledControlColour.</returns>
        public Color GetDisabledControlColour()
        {
            return _allMergedColourSettings.DisabledControlColour;
        }

        /// <summary>
        /// Sets the value of MenuTextColour to colour.
        /// </summary>
        /// <param name="colour">The value of MenuTextColour.</param>
        public void SetMenuTextColour(Color colour)
        {
            _allMergedColourSettings.MenuTextColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of MenuTextColour.
        /// </summary>
        /// <returns>The value of MenuTextColour.</returns>
        public Color GetMenuTextColour()
        {
            return _allMergedColourSettings.MenuTextColour;
        }

        /// <summary>
        /// Sets the value of StatusStripTextColour to colour.
        /// </summary>
        /// <param name="colour">The value of StatusStripTextColour.</param>
        public void SetStatusStripTextColour(Color colour)
        {
            _allMergedColourSettings.StatusStripTextColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of StatusStripTextColour.
        /// </summary>
        /// <returns>The value of StatusStripTextColour.</returns>
        public Color GetStatusStripTextColour()
        {
            return _allMergedColourSettings.StatusStripTextColour;
        }

        /// <summary>
        /// Sets the value of RibbonTabTextColour to colour.
        /// </summary>
        /// <param name="colour">The value of RibbonTabTextColour.</param>
        public void SetRibbonTabTextColour(Color colour)
        {
            _allMergedColourSettings.RibbonTabTextColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of RibbonTabTextColour.
        /// </summary>
        /// <returns>The value of RibbonTabTextColour.</returns>
        public Color GetRibbonTabTextColour()
        {
            return _allMergedColourSettings.RibbonTabTextColour;
        }

        /// <summary>
        /// Sets the value of AlternativeNormalTextColour to colour.
        /// </summary>
        /// <param name="colour">The value of AlternativeNormalTextColour.</param>
        public void SetAlternativeNormalTextColour(Color colour)
        {
            _allMergedColourSettings.AlternativeNormalTextColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of AlternativeNormalTextColour.
        /// </summary>
        /// <returns>The value of AlternativeNormalTextColour.</returns>
        public Color GetAlternativeNormalTextColour()
        {
            return _allMergedColourSettings.AlternativeNormalTextColour;
        }

        /// <summary>
        /// Sets the value of DisabledTextColour to colour.
        /// </summary>
        /// <param name="colour">The value of DisabledTextColour.</param>
        public void SetDisabledTextColour(Color colour)
        {
            _allMergedColourSettings.DisabledTextColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of DisabledTextColour.
        /// </summary>
        /// <returns>The value of DisabledTextColour.</returns>
        public Color GetDisabledTextColour()
        {
            return _allMergedColourSettings.DisabledTextColour;
        }

        /// <summary>
        /// Sets the value of FocusedTextColour to colour.
        /// </summary>
        /// <param name="colour">The value of FocusedTextColour.</param>
        public void SetFocusedTextColour(Color colour)
        {
            _allMergedColourSettings.FocusedTextColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of FocusedTextColour.
        /// </summary>
        /// <returns>The value of FocusedTextColour.</returns>
        public Color GetFocusedTextColour()
        {
            return _allMergedColourSettings.FocusedTextColour;
        }

        /// <summary>
        /// Sets the value of NormalTextColour to colour.
        /// </summary>
        /// <param name="colour">The value of NormalTextColour.</param>
        public void SetNormalTextColour(Color colour)
        {
            _allMergedColourSettings.NormalTextColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of NormalTextColour.
        /// </summary>
        /// <returns>The value of NormalTextColour.</returns>
        public Color GetNormalTextColour()
        {
            return _allMergedColourSettings.NormalTextColour;
        }

        /// <summary>
        /// Sets the value of PressedTextColour to colour.
        /// </summary>
        /// <param name="colour">The value of PressedTextColour.</param>
        public void SetPressedTextColour(Color colour)
        {
            _allMergedColourSettings.PressedTextColour = colour;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of PressedTextColour.
        /// </summary>
        /// <returns>The value of PressedTextColour.</returns>
        public Color GetPressedTextColour()
        {
            return _allMergedColourSettings.PressedTextColour;
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
                SetBaseColour(Color.Empty);

                SetDarkColour(Color.Empty);

                SetMediumColour(Color.Empty);

                SetLightColour(Color.Empty);

                SetLightestColour(Color.Empty);

                SetCustomColourOne(Color.Empty);

                SetCustomColourTwo(Color.Empty);

                SetCustomColourThree(Color.Empty);

                SetCustomColourFour(Color.Empty);

                SetCustomColourFive(Color.Empty);

                SetCustomColourSix(Color.Empty);

                SetCustomTextColourOne(Color.Empty);

                SetCustomTextColourTwo(Color.Empty);

                SetCustomTextColourThree(Color.Empty);

                SetCustomTextColourFour(Color.Empty);

                SetCustomTextColourFive(Color.Empty);

                SetCustomTextColourSix(Color.Empty);

                SetLinkFocusedColour(Color.Empty);

                SetLinkHoverColour(Color.Empty);

                SetLinkNormalColour(Color.Empty);

                SetLinkVisitedColour(Color.Empty);

                SetBorderColour(Color.Empty);

                SetDisabledControlColour(Color.Empty);

                SetMenuTextColour(Color.Empty);

                SetStatusStripTextColour(Color.Empty);

                SetRibbonTabTextColour(Color.Empty);

                SetDisabledTextColour(Color.Empty);

                SetFocusedTextColour(Color.Empty);

                SetNormalTextColour(Color.Empty);

                SetPressedTextColour(Color.Empty);

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
                    _allMergedColourSettings.Save();

                    SetSettingsModified(false);
                }
            }
            else
            {
                _allMergedColourSettings.Save();

                SetSettingsModified(false);
            }
        }
        #endregion
    }
}