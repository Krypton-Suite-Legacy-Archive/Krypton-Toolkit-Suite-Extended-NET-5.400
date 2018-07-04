﻿using System;
using System.Media;

using ExtendedControls.ExtendedToolkit.Messageboxes.Enumerations;

using KryptonExtendedToolkit.Base.Code;

namespace KryptonExtendedToolkit.ExtendedToolkit.Messageboxes.Classes
{
    public class Globals
    {
        ExceptionHandler exceptionHandler = new ExceptionHandler();

        public Globals()
        {

        }

        #region Methods
        /// <summary>
        /// Plays system sound on displaying messagebox.
        /// </summary>
        /// <param name="type">The type of messagebox being displayed.</param>
        public void PlaySound(KryptonMessageBoxExtendedIcon type, string customSoundLocation = null)
        {
            switch (type)
            {
                case KryptonMessageBoxExtendedIcon.HAND:
                    SystemSounds.Hand.Play();
                    break;
                case KryptonMessageBoxExtendedIcon.QUESTION:
                    SystemSounds.Question.Play();
                    break;
                case KryptonMessageBoxExtendedIcon.EXCLAMATION:
                    SystemSounds.Exclamation.Play();
                    break;
                case KryptonMessageBoxExtendedIcon.ASTERISK:
                    SystemSounds.Asterisk.Play();
                    break;
                case KryptonMessageBoxExtendedIcon.STOP:
                    SystemSounds.Asterisk.Play();
                    break;
                case KryptonMessageBoxExtendedIcon.ERROR:
                    SystemSounds.Asterisk.Play();
                    break;
                case KryptonMessageBoxExtendedIcon.INFORMATION:

                    break;
                case KryptonMessageBoxExtendedIcon.CUSTOM:
                    try
                    {
                        SoundPlayer sound = new SoundPlayer();

                        sound.SoundLocation = customSoundLocation;

                        sound.Play();
                    }
                    catch (Exception e)
                    {
                        exceptionHandler.ShowException(e.Message, true);
                    }
                    break;
                case KryptonMessageBoxExtendedIcon.CRITICAL:
                    SystemSounds.Asterisk.Play();
                    break;
                case KryptonMessageBoxExtendedIcon.NONE:
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}