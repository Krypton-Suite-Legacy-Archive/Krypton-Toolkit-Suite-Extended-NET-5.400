# <img src="https://raw.githubusercontent.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.400/master/Assets/PNG/64%20x%2064/KR%2064%20%20x%2064%20Orange.png" /> Toolkit Suite Extended .NET 5.400

=======

| NuGet | Current NuGet Version | Github License |
|---|---|---|
| [![NuGet](https://img.shields.io/badge/NuGet-Krypton%20Extended%20.NET%205.400-brightgreen.svg)](https://www.nuget.org/packages/KryptonExtendedToolkit5400/) | ![Nuget](https://img.shields.io/nuget/v/KryptonExtendedToolkit5400.svg) | ![GitHub](https://img.shields.io/github/license/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.400.svg)

=======

# Note on NuGet package servicing
**Due to API changes in later .NET 4.x revisions, the 5.400 version will not be updated as regualary as 5.450 versions and above, as some code is written with some APIs that are only supported in later versions. Sorry for the inconvinence that this may cause.**

=======

## An extension to the Krypton Toolkit suite of controls for .NET framework 4.0.

======

# Building this repository from code

## In order to compile the code, you MUST restore/update the NuGet packages in order to build successfully!

======

## Control Examples

Please refer to [examples](https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/Examples.md) to see what each control looks like.

======
## 2019-06-01 Build 1030 - June Update
* New `issue` templates
* Implemented repository tags for better GitHub SEO
* Implement `WindowsAPICodePackModel.cs` class for dealing with **WindowsAPICodePack** features 
* New `Palette Explorer` controls
* Merged all settings into `Toolkit Settings.dll`
* Begun work on [#70](https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/issues/70)
* Implemented [NaviSuite](https://github.com/jacobmesu/Guifreaks-Navisuite) by [Jacobmesu](https://github.com/jacobmesu)
* New file varifier app to work with May's file checksum calculator
* New `KryptonFileInformationDialog` to replace the Windows default one with some extra features
* Upgraded to Krypton Toolkit Suite - version: **5.400.1204**
* Build 1030 (build date Saturday 1st, June 2019) is now available on NuGet

======

## 2019-05-10 Build 945 - May Update
* Outlook 2003 style toast notification
* File checksum calculator (MD5, SHA-1, SHA-256, SHA-384, SHA-512 and RIPEMD-160)
* New `KryptonPaletteManager` class for dealing with creating custom `KryptonPalette`'s
* Ribbon enhancements, merge two ribbons together [#150](https://github.com/Wagnerp/Krypton-NET-5.470/issues/150)
* Capture version information from another file
* Playground application reorganisation
* Images of controls to show developers what they look like
* Image resizing utility - resize & save images on the fly
* New palette explorer user controls - will make it quicker to design the application
* Fix palette theme selector, issue [#71](https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/issues/71)
* General tidyup of code & API updates
* XML documentation files for DLLs
* New palette theme selector
* New `KryptonToastNotification` window
* New circular progressbar control
* Random password generator (for use on future user creation dialog)
* New developer API tools for internal development of the toolkit
* Begun re-working the `Palette Explorer` application
* New `Palette Upgrade Tool` application for upgrading any older palette `xml` files
* Theme `*.xml` files are now available to view and edit in the Visual Studio solution under the **themes** folder
* All theme files are now bundled with the NuGet package
* New colour wheel colour dialog
* New toggle switch control
* New rounded textbox control
* Integrated `ookii.dialogs` code
* Working on new folder browser dialog and file browser
* New theme chooser component (proof of concept for a more sophisticated UI for next update)
* Removed **LinqBridge** requirement, [#48](https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/issues/48)
* Reorganised `Playground` test application
* Fully merged the `ExtendedRenderer` project codebase
* Tidy up control placement in code
* New control, `KryptonCommandLinkButton`
* Add Designer to allow drag and drop in IDE
* Add defaults to demonstrate layout and then allow user to change the values
* Add Code to the Playground to show defaults
* Complete the optional font usage for the `ExtendedKryptonMessageBox` 
* Add code behind the PlayGrounds `MessageBox Test` button.
* New controls, including a new, theme-able scrollbar - need help implementing it into controls i.e ComboBox, rich textbox etc.
* Partially implemented the `ExtendedRenderer` project - due to be completed in early 2019.
* **Tooling.dll** has now been renamed to **Core.dll**
* Consolidate settings
* Begun work on a new colour dialog
* Refinements to code
* Set your own colour intensity
* Automatic updating of colours has been centralised
* Work on a new ribbonised `Palette Explorer` is in progress
* New floating toolbar/window feature
* Re-work of `Palette Editor` UI to tidy up (ribbon UI is a possibility)
* Started feasibility work on a "Kryptonised" common file dialog (any help is appreciated)
* New splash screen for `Palette Editor` application
* Removed requirement for DLLs in favor of NuGet management
* General bug fixes
* Allow users to define **any** colour in the `Palette Editor` using a context menu
* Begun work on a new typeface/font dialog box
* Begun work on a new `Define Basic Palette Colours` UI to allow users to define custom basic palette colours (currently in pre-alpha stages)
* Updated the required Krypton DLLs to build 643 (build date Tuesday 25th September, 2018)
* General code updates

======

## 2018-09-05 Removal of Unsupported Code
* Removed `KryptonRichTextBoxExtended` due to unsupported APIs in .NET framework 4.0.

======

## 2018-06-21 Build paths
* Reset build paths, so no errors should be incurred.

======

## 2018-06-2018 Slate silver theme
* One **new** theme called `Slate Silver`, stylised for the 2007/2010 and 2013 theme sets.

======

## 2018-06-11 New palettes & gradeint toolstrip label
* There are now 50+ **new** palettes to choose from.
* A new toolstrip label capable of background gradeints is now available to use, as per [#28](https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-4.70/issues/28).

======

## 2018-05-22 Colour Mania!
* Colours... colours... colours... We now have 26 **new** colours to choose from! Find the `xml` files in the `Palettes` folder, this will be updated regulary, so be sure to come back often! Alternatively, if you would like to request/submit a colour palette, then please submit a base colour in a hexadecimal format plus a suitable name for it on the `New Palette Ideas` issues thread.

======

## 2018-04-29 Tinkering with the References
* Tinkering with the References.
* Start to fill out the WIX installer project.

======

## 2018-04-17 Application Update XML Configuration
* Nearly completed first design stage of the `Update File Creator`.
* New installer project (Advanced Installer & WIX).

======

## 2018-04-16 Krypton Extended Messagebox
* Laid basic foundation for a designable `Krypton MessageBox`.

======

## 2018-04-11 Nuget package migration/consolodation
* Migrated `packages.config` over  to `PackageReference` (must have the latest Visual Studio 2017 Preview build to utilise this feature).

======

## 2018-04-10 New Menu control
* `KryptonNumericUpDown` control can now be used on menu & toolbar controls.

======

## 2018-03-28 Toolkit changes
* The `ExtendedControls.dll` has now been renamed to `KryptonExtendedToolkit.dll`
* Build output paths changed for neatness
* The **releases** tab is now activated

======

## 2018-03-13 Krypton Application Updater (XML based version) update
* Base groundwork for XML updater & parsing XML files has been completed
* New XML files labelled `Update.xml` and `CheckSum.xml` have been created to explain to developers how to use the updater back-end.
* TODO: Connect the framework up to UI elements.

======

## 2018-03-10 Krypton Application Updater (XML based version)
* Begun fundamental groundwork on an XML based application updater (classes/settings/UI).
* Improved documentation with the aid of [GhostDoc](https://marketplace.visualstudio.com/items?itemName=sergeb.GhostDoc).

======

## 2018-03-08 New controls
* New wizard control based off of [Aero Wizard](https://github.com/dahall/AeroWizard) base implemented, ready for conversion to Krypton controls
* New "Most Recently Used" files option for `File` menu, see `Playground` for proper implementation

======

## 2018-02-27 Toolkit update
* A new Windows Forms application `Playground` has been added to test controls and features added to the toolkit.

======

## 2018-02-25 New Control, methods and documentation
* Added a new toolstrip menu item UAC shield control
* Added/cleaned up documentation for methods
* New setter/getter methods for certain properties in `Global Utilities`
* New method `ElevateProcessWithAdministrativeRights(string processName)` for elevating your application with administrative rights (to be used in conjunction with the recently added UAC shield controls)
* New `CODE_OF_CONDUCT.md` file for project

======

## 2018-02-24 New Control
* Krypton UAC shield button
* New options for developers to check if the user is running Windows 7 or higher. 64-bit checks will follow soon.

======

## 2018-02-08 New controls 
* Extended 'KryptonTextBox' to have watermark functionality.
* Wrapped 'KryptonTextBox' into a `toolstrip container` object to make it easier to add new functionality i.e watermarks.

======

## 2018-02-06 New resources
* New icons for `MessageBoxes`

======

## 2018-02-05pm New `Globals.cs` class for enumerations
* New `Globals.cs` class for custom enumerations. (Needs documentation finishing off)
* NOTE FOR FUTURE REFRENCE: Find suitable icons for `MessageBoxes` (CC license maybe?)

======

## 2018-02-05am Krypton outlook grid & Krypton messagebox base
* Fixed bug with Krypton outlook grid
* Incorporated a `base Krypton MessageBox` as a reference for extending

=======

## 2018-02-04 Krypton outlook grid
* Fully incorporated `Krypton Outlook Grid` code

=======

## 2018-02-03 Krypton outlook grid
* `Krypton Outlook Grid` 45% complete
* Altered assembly info
* Variables and comments with `color` renamed to `colour`

=======

## 2018-02-02 Initial commit
* Added generic C# `.gitignore` file
* Created solution with two class projects inside labelled `Extended Controls` and `Krypton Outlook Grid`
* Automatic versioning
* High DPI support configuration 
