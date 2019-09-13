﻿using Microsoft.Win32;
using System;
using System.Globalization;

namespace KryptonSparkle.Classes
{
    /// <summary>
    /// This class handles all registry values which are used from sparkle to handle 
    /// update intervalls. All values are stored in HKCU\Software\Vendor\AppName which 
    /// will be read ot from the assembly information. All values are of the REG_SZ 
    /// type, no matter what their "logical" type is. The following options are
    /// available:
    /// 
    /// CheckForUpdate  - Boolean    - Whether NetSparkle should check for updates
    /// LastCheckTime   - time_t     - Time of last check
    /// SkipThisVersion - String     - If the user skipped an update, then the version to ignore is stored here (e.g. "1.4.3")
    /// DidRunOnce      - Boolean    - Check only one time when the app launched
    /// </summary>    
    public class KryptonSparkleRegistryConfiguration : KryptonSparkleConfiguration
    {
        /// <summary>
        /// The constructor reads out all configured values
        /// </summary>        
        /// <param name="referenceAssembly">the reference assembly name</param>
        public KryptonSparkleRegistryConfiguration(string referenceAssembly)
            : this(referenceAssembly, true)
        { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="referenceAssembly">the name of hte reference assembly</param>
        /// <param name="isReflectionBasedAssemblyAccessorUsed"><c>true</c> if reflection is used to access the assembly.</param>
        public KryptonSparkleRegistryConfiguration(string referenceAssembly, bool isReflectionBasedAssemblyAccessorUsed) : base(referenceAssembly, isReflectionBasedAssemblyAccessorUsed)
        {
            try
            {
                // build the reg path
                String regPath = BuildRegistryPath();

                // load the values
                LoadValuesFromPath(regPath);
            }
            catch (KryptonSparkleException)
            {
                // disable update checks when exception was called 
                this.CheckForUpdate = false;
                throw;
            }
        }

        /// <summary>
        /// Touches to profile time
        /// </summary>
        public override void TouchProfileTime()
        {
            base.TouchProfileTime();
            // save the values
            SaveValuesToPath(BuildRegistryPath());
        }

        /// <summary>
        /// Touches the check time to now, should be used after a check directly
        /// </summary>
        public override void TouchCheckTime()
        {
            base.TouchCheckTime();
            // save the values
            SaveValuesToPath(BuildRegistryPath());
        }

        /// <summary>
        /// This method allows to skip a specific version
        /// </summary>
        /// <param name="version">the version to skeip</param>
        public override void SetVersionToSkip(string version)
        {
            base.SetVersionToSkip(version);
            SaveValuesToPath(BuildRegistryPath());
        }

        /// <summary>
        /// Reloads the configuration object
        /// </summary>
        public override void Reload()
        {
            LoadValuesFromPath(BuildRegistryPath());
        }

        /// <summary>
        /// This function build a valid registry path in dependecy to the 
        /// assembly information
        /// </summary>
        /// <returns></returns>
        private String BuildRegistryPath()
        {
            KryptonSparkleAssemblyAccessor accessor = new KryptonSparkleAssemblyAccessor(this.ReferenceAssembly, this.UseReflectionBasedAssemblyAccessor);

            if (string.IsNullOrEmpty(accessor.AssemblyCompany) || string.IsNullOrEmpty(accessor.AssemblyProduct))
                throw new KryptonSparkleException("STOP: Sparkle is missing the company or productname tag in " + ReferenceAssembly);

            return "Software\\" + accessor.AssemblyCompany + "\\" + accessor.AssemblyProduct + "\\AutoUpdate";
        }

        /// <summary>
        /// This method loads the values from registry
        /// </summary>
        /// <param name="regPath">the registry path</param>
        /// <returns><c>true</c> if the items were loaded</returns>
        private void LoadValuesFromPath(String regPath)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(regPath);
            if (key == null)
                return;
            // read out                
            String strCheckForUpdate = key.GetValue("CheckForUpdate", "True") as String;
            String strLastCheckTime = key.GetValue("LastCheckTime", new DateTime(0).ToString(CultureInfo.InvariantCulture)) as String;
            String strSkipThisVersion = key.GetValue("SkipThisVersion", "") as String;
            String strDidRunOnc = key.GetValue("DidRunOnce", "False") as String;
            String strShowDiagnosticWindow = key.GetValue("ShowDiagnosticWindow", "False") as String;
            String strProfileTime = key.GetValue("LastProfileUpdate", new DateTime(0).ToString(CultureInfo.InvariantCulture)) as String;

            // convert th right datatypes
            CheckForUpdate = Convert.ToBoolean(strCheckForUpdate);
            LastCheckTime = Convert.ToDateTime(strLastCheckTime);
            SkipThisVersion = strSkipThisVersion;
            DidRunOnce = Convert.ToBoolean(strDidRunOnc);
            ShowDiagnosticWindow = Convert.ToBoolean(strShowDiagnosticWindow);
            LastProfileUpdate = Convert.ToDateTime(strProfileTime);
        }

        /// <summary>
        /// This method store the information into registry
        /// </summary>
        /// <param name="regPath">the registry path</param>
        /// <returns><c>true</c> if the values were saved to the registry</returns>
        private void SaveValuesToPath(string regPath)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(regPath);
            if (key == null)
                return;
            // convert to regsz
            String strCheckForUpdate = CheckForUpdate.ToString();
            String strLastCheckTime = LastCheckTime.ToString(CultureInfo.InvariantCulture);
            String strSkipThisVersion = SkipThisVersion;
            String strDidRunOnc = DidRunOnce.ToString();
            String strProfileTime = LastProfileUpdate.ToString(CultureInfo.InvariantCulture);

            // set the values
            key.SetValue("CheckForUpdate", strCheckForUpdate, RegistryValueKind.String);
            key.SetValue("LastCheckTime", strLastCheckTime, RegistryValueKind.String);
            key.SetValue("SkipThisVersion", strSkipThisVersion, RegistryValueKind.String);
            key.SetValue("DidRunOnce", strDidRunOnc, RegistryValueKind.String);
            key.SetValue("LastProfileUpdate", strProfileTime, RegistryValueKind.String);
        }
    }
}