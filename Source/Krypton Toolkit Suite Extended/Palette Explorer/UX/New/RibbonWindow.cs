﻿using ComponentFactory.Krypton.Docking;
using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Toolkit;
using PaletteExplorer.Controls;
using System;
using System.Windows.Forms;

namespace PaletteExplorer.UX.New
{
    public class RibbonWindow : KryptonForm
    {
        #region Designer Code
        private ComponentFactory.Krypton.Ribbon.KryptonRibbon krControls;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton krqatbNew;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton krqatbOpen;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton krqatbSave;
        private KryptonContextMenuItem kcmiNewPalette;
        private KryptonContextMenuSeparator kryptonContextMenuSeparator1;
        private KryptonContextMenuItem kcmiOpenPalette;
        private KryptonContextMenuSeparator kryptonContextMenuSeparator2;
        private KryptonContextMenuItem kcmiSavePalette;
        private KryptonContextMenuItem kcmiSavePaletteAs;
        private KryptonContextMenuSeparator kryptonContextMenuSeparator3;
        private KryptonContextMenuItem kcmiExit;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbNewPalette;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbOpenPalette;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple3;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbSavePalette;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbExportPalette;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup10;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple23;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbCut;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbCopy;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbPaste;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator15;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple24;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbUndo;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbRedo;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup5;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines kryptonRibbonGroupLines2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLabel kryptonRibbonGroupLabel1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupComboBox krgcbBasePaletteMode;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup8;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines kryptonRibbonGroupLines1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCheckBox kryptonRibbonGroupCheckBox1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCheckBox kryptonRibbonGroupCheckBox2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup3;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple6;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbGenerateColours;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator4;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple7;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbGetColours;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator5;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple8;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbExport;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple4;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krbViewPaletteFile;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator6;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple5;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbGenerateContrastColours;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator7;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple9;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbGetColourInformation;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator8;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple10;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbImport;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple11;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbInvert;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator3;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple12;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbUpdateColours;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator9;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple13;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbResetColours;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple14;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbDefineTypefaces;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator10;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple15;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbDefineTypefaceColour;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup4;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple16;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbViewType;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator11;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple17;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbExperimental;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator12;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple19;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbShowHidePropertiesPane;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab3;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup6;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple20;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton3;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator14;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple18;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbOptions;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab4;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup7;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple21;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbAbout;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator13;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple22;
        private KryptonManager kMan;
        private System.ComponentModel.IContainer components;
        private KryptonPanel kpnlStatusStrip;
        private System.Windows.Forms.StatusStrip ss;
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnClose;
        private KryptonLabel lblColourOutput;
        private KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kdm;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbExpertMode;
        private ImageList ilImages;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbShowHideColourPane;
        private KryptonDockableNavigator kryptonDockableNavigator1;
        private KryptonPage kryptonPage1;
        private KryptonPage kryptonPage2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton krgbCheckForUpdates;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues1 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonWindow));
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues2 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues3 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues4 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            this.krControls = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.krqatbNew = new ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton();
            this.krqatbOpen = new ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton();
            this.krqatbSave = new ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton();
            this.kcmiNewPalette = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kcmiOpenPalette = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kcmiSavePalette = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kcmiSavePaletteAs = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kcmiExit = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonRibbonTab1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbNewPalette = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbOpenPalette = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbSavePalette = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbExportPalette = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup10 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple23 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbCut = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbCopy = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbPaste = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator15 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple24 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbUndo = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbRedo = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup5 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupLines2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines();
            this.kryptonRibbonGroupLabel1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLabel();
            this.krgcbBasePaletteMode = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupComboBox();
            this.kryptonRibbonGroup8 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupLines1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines();
            this.kryptonRibbonGroupCheckBox1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCheckBox();
            this.kryptonRibbonGroupCheckBox2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCheckBox();
            this.kryptonRibbonTab2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple6 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbGenerateColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple7 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbGetColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator5 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple8 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbExport = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupTriple4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krbViewPaletteFile = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator6 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple5 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbGenerateContrastColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator7 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple9 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbGetColourInformation = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator8 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple10 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbImport = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupTriple11 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbInvert = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple12 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbUpdateColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator9 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple13 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbResetColours = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple14 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbDefineTypefaces = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator10 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple15 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbDefineTypefaceColour = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple16 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbViewType = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator11 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple17 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbExperimental = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator12 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple19 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbShowHidePropertiesPane = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbShowHideColourPane = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup6 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple20 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButton3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator14 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple18 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbOptions = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krgbExpertMode = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup7 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple21 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbAbout = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator13 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple22 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.krgbCheckForUpdates = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kMan = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kpnlStatusStrip = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblColourOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kdm = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.ilImages = new System.Windows.Forms.ImageList(this.components);
            this.kryptonDockableNavigator1 = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            ((System.ComponentModel.ISupportInitialize)(this.krControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlStatusStrip)).BeginInit();
            this.kpnlStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator1)).BeginInit();
            this.kryptonDockableNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.SuspendLayout();
            // 
            // krControls
            // 
            this.krControls.AllowFormIntegrate = true;
            this.krControls.InDesignHelperMode = true;
            this.krControls.Name = "krControls";
            this.krControls.QATButtons.AddRange(new System.ComponentModel.Component[] {
            this.krqatbNew,
            this.krqatbOpen,
            this.krqatbSave});
            this.krControls.RibbonAppButton.AppButtonImage = global::PaletteExplorer.Properties.Resources.PE_Icon_24_x_24;
            this.krControls.RibbonAppButton.AppButtonMenuItems.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kcmiNewPalette,
            this.kryptonContextMenuSeparator1,
            this.kcmiOpenPalette,
            this.kryptonContextMenuSeparator2,
            this.kcmiSavePalette,
            this.kcmiSavePaletteAs,
            this.kryptonContextMenuSeparator3,
            this.kcmiExit});
            this.krControls.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.kryptonRibbonTab1,
            this.kryptonRibbonTab2,
            this.kryptonRibbonTab3,
            this.kryptonRibbonTab4});
            this.krControls.SelectedContext = null;
            this.krControls.SelectedTab = this.kryptonRibbonTab2;
            this.krControls.Size = new System.Drawing.Size(1649, 115);
            this.krControls.TabIndex = 2;
            popupPositionValues1.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.krControls.ToolTipValues.ToolTipPosition = popupPositionValues1;
            // 
            // krqatbNew
            // 
            this.krqatbNew.Image = ((System.Drawing.Image)(resources.GetObject("krqatbNew.Image")));
            // 
            // krqatbOpen
            // 
            this.krqatbOpen.Image = ((System.Drawing.Image)(resources.GetObject("krqatbOpen.Image")));
            // 
            // krqatbSave
            // 
            this.krqatbSave.Image = ((System.Drawing.Image)(resources.GetObject("krqatbSave.Image")));
            // 
            // kcmiNewPalette
            // 
            this.kcmiNewPalette.Text = "New Palette";
            // 
            // kcmiOpenPalette
            // 
            this.kcmiOpenPalette.Text = "Open Palette";
            // 
            // kcmiSavePalette
            // 
            this.kcmiSavePalette.Text = "Save Palette";
            // 
            // kcmiSavePaletteAs
            // 
            this.kcmiSavePaletteAs.Text = "Save Palette As";
            // 
            // kcmiExit
            // 
            this.kcmiExit.Text = "Exit";
            // 
            // kryptonRibbonTab1
            // 
            this.kryptonRibbonTab1.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1,
            this.kryptonRibbonGroup10,
            this.kryptonRibbonGroup5,
            this.kryptonRibbonGroup8});
            this.kryptonRibbonTab1.Text = "&General";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1,
            this.kryptonRibbonGroupSeparator1,
            this.kryptonRibbonGroupTriple2,
            this.kryptonRibbonGroupSeparator2,
            this.kryptonRibbonGroupTriple3});
            this.kryptonRibbonGroup1.TextLine1 = "File";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbNewPalette});
            // 
            // krgbNewPalette
            // 
            this.krgbNewPalette.ImageLarge = ((System.Drawing.Image)(resources.GetObject("krgbNewPalette.ImageLarge")));
            this.krgbNewPalette.ImageSmall = ((System.Drawing.Image)(resources.GetObject("krgbNewPalette.ImageSmall")));
            this.krgbNewPalette.TextLine1 = "New";
            this.krgbNewPalette.TextLine2 = "Palette";
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbOpenPalette});
            // 
            // krgbOpenPalette
            // 
            this.krgbOpenPalette.ImageLarge = ((System.Drawing.Image)(resources.GetObject("krgbOpenPalette.ImageLarge")));
            this.krgbOpenPalette.ImageSmall = ((System.Drawing.Image)(resources.GetObject("krgbOpenPalette.ImageSmall")));
            this.krgbOpenPalette.TextLine1 = "Open";
            this.krgbOpenPalette.TextLine2 = " Palette";
            // 
            // kryptonRibbonGroupTriple3
            // 
            this.kryptonRibbonGroupTriple3.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbSavePalette,
            this.krgbExportPalette});
            // 
            // krgbSavePalette
            // 
            this.krgbSavePalette.ImageLarge = ((System.Drawing.Image)(resources.GetObject("krgbSavePalette.ImageLarge")));
            this.krgbSavePalette.ImageSmall = ((System.Drawing.Image)(resources.GetObject("krgbSavePalette.ImageSmall")));
            this.krgbSavePalette.TextLine1 = "Save";
            this.krgbSavePalette.TextLine2 = "Palette";
            // 
            // krgbExportPalette
            // 
            this.krgbExportPalette.TextLine1 = "Export";
            // 
            // kryptonRibbonGroup10
            // 
            this.kryptonRibbonGroup10.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple23,
            this.kryptonRibbonGroupSeparator15,
            this.kryptonRibbonGroupTriple24});
            this.kryptonRibbonGroup10.TextLine1 = "General";
            // 
            // kryptonRibbonGroupTriple23
            // 
            this.kryptonRibbonGroupTriple23.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbCut,
            this.krgbCopy,
            this.krgbPaste});
            // 
            // krgbCut
            // 
            this.krgbCut.TextLine1 = "Cut";
            // 
            // krgbCopy
            // 
            this.krgbCopy.TextLine1 = "Copy";
            // 
            // krgbPaste
            // 
            this.krgbPaste.Enabled = false;
            this.krgbPaste.TextLine1 = "Paste";
            // 
            // kryptonRibbonGroupTriple24
            // 
            this.kryptonRibbonGroupTriple24.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbUndo,
            this.krgbRedo});
            // 
            // krgbUndo
            // 
            this.krgbUndo.Enabled = false;
            this.krgbUndo.TextLine1 = "Undo";
            // 
            // krgbRedo
            // 
            this.krgbRedo.Enabled = false;
            this.krgbRedo.TextLine1 = "Redo";
            // 
            // kryptonRibbonGroup5
            // 
            this.kryptonRibbonGroup5.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupLines2});
            this.kryptonRibbonGroup5.TextLine1 = "Palette Mode";
            // 
            // kryptonRibbonGroupLines2
            // 
            this.kryptonRibbonGroupLines2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupLabel1,
            this.krgcbBasePaletteMode});
            // 
            // kryptonRibbonGroupLabel1
            // 
            this.kryptonRibbonGroupLabel1.TextLine1 = "Base Palette Mode:";
            // 
            // krgcbBasePaletteMode
            // 
            this.krgcbBasePaletteMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.krgcbBasePaletteMode.DropDownWidth = 200;
            this.krgcbBasePaletteMode.FormattingEnabled = false;
            this.krgcbBasePaletteMode.ItemHeight = 15;
            this.krgcbBasePaletteMode.Text = "";
            // 
            // kryptonRibbonGroup8
            // 
            this.kryptonRibbonGroup8.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupLines1});
            this.kryptonRibbonGroup8.Visible = false;
            // 
            // kryptonRibbonGroupLines1
            // 
            this.kryptonRibbonGroupLines1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupCheckBox1,
            this.kryptonRibbonGroupCheckBox2});
            // 
            // kryptonRibbonTab2
            // 
            this.kryptonRibbonTab2.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup3,
            this.kryptonRibbonGroup2,
            this.kryptonRibbonGroup4});
            this.kryptonRibbonTab2.Text = "O&ptions";
            // 
            // kryptonRibbonGroup3
            // 
            this.kryptonRibbonGroup3.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple6,
            this.kryptonRibbonGroupSeparator4,
            this.kryptonRibbonGroupTriple7,
            this.kryptonRibbonGroupSeparator5,
            this.kryptonRibbonGroupTriple8,
            this.kryptonRibbonGroupTriple4,
            this.kryptonRibbonGroupSeparator6,
            this.kryptonRibbonGroupTriple5,
            this.kryptonRibbonGroupSeparator7,
            this.kryptonRibbonGroupTriple9,
            this.kryptonRibbonGroupSeparator8,
            this.kryptonRibbonGroupTriple10,
            this.kryptonRibbonGroupTriple11,
            this.kryptonRibbonGroupSeparator3,
            this.kryptonRibbonGroupTriple12,
            this.kryptonRibbonGroupSeparator9,
            this.kryptonRibbonGroupTriple13});
            this.kryptonRibbonGroup3.TextLine1 = "Colour Properties";
            // 
            // kryptonRibbonGroupTriple6
            // 
            this.kryptonRibbonGroupTriple6.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbGenerateColours});
            // 
            // krgbGenerateColours
            // 
            this.krgbGenerateColours.ImageLarge = ((System.Drawing.Image)(resources.GetObject("krgbGenerateColours.ImageLarge")));
            this.krgbGenerateColours.ImageSmall = ((System.Drawing.Image)(resources.GetObject("krgbGenerateColours.ImageSmall")));
            this.krgbGenerateColours.TextLine1 = "Generate";
            this.krgbGenerateColours.TextLine2 = "Colours";
            // 
            // kryptonRibbonGroupTriple7
            // 
            this.kryptonRibbonGroupTriple7.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbGetColours});
            // 
            // krgbGetColours
            // 
            this.krgbGetColours.TextLine1 = "Get";
            this.krgbGetColours.TextLine2 = "Colours";
            // 
            // kryptonRibbonGroupTriple8
            // 
            this.kryptonRibbonGroupTriple8.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbExport});
            this.kryptonRibbonGroupTriple8.Visible = false;
            // 
            // krgbExport
            // 
            this.krgbExport.TextLine1 = "Export Colour";
            this.krgbExport.TextLine2 = "Palette";
            // 
            // kryptonRibbonGroupTriple4
            // 
            this.kryptonRibbonGroupTriple4.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krbViewPaletteFile});
            // 
            // krbViewPaletteFile
            // 
            this.krbViewPaletteFile.TextLine1 = "View";
            this.krbViewPaletteFile.TextLine2 = "Palette File";
            // 
            // kryptonRibbonGroupTriple5
            // 
            this.kryptonRibbonGroupTriple5.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbGenerateContrastColours});
            // 
            // krgbGenerateContrastColours
            // 
            this.krgbGenerateContrastColours.TextLine1 = "Generate";
            this.krgbGenerateContrastColours.TextLine2 = "Contrast Colours";
            // 
            // kryptonRibbonGroupTriple9
            // 
            this.kryptonRibbonGroupTriple9.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbGetColourInformation});
            // 
            // krgbGetColourInformation
            // 
            this.krgbGetColourInformation.TextLine1 = "Get Colour";
            this.krgbGetColourInformation.TextLine2 = "Information";
            // 
            // kryptonRibbonGroupTriple10
            // 
            this.kryptonRibbonGroupTriple10.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbImport});
            // 
            // krgbImport
            // 
            this.krgbImport.TextLine1 = "Import Colour";
            this.krgbImport.TextLine2 = "Scheme";
            this.krgbImport.Visible = false;
            // 
            // kryptonRibbonGroupTriple11
            // 
            this.kryptonRibbonGroupTriple11.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbInvert});
            // 
            // krgbInvert
            // 
            this.krgbInvert.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.krgbInvert.Enabled = false;
            this.krgbInvert.TextLine1 = "Invert";
            this.krgbInvert.TextLine2 = "Colours";
            // 
            // kryptonRibbonGroupTriple12
            // 
            this.kryptonRibbonGroupTriple12.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbUpdateColours});
            // 
            // krgbUpdateColours
            // 
            this.krgbUpdateColours.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Split;
            this.krgbUpdateColours.TextLine1 = "Update";
            this.krgbUpdateColours.TextLine2 = "Colours";
            // 
            // kryptonRibbonGroupTriple13
            // 
            this.kryptonRibbonGroupTriple13.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbResetColours});
            // 
            // krgbResetColours
            // 
            this.krgbResetColours.TextLine1 = "Reset";
            this.krgbResetColours.TextLine2 = "Colours";
            // 
            // kryptonRibbonGroup2
            // 
            this.kryptonRibbonGroup2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple14,
            this.kryptonRibbonGroupSeparator10,
            this.kryptonRibbonGroupTriple15});
            // 
            // kryptonRibbonGroupTriple14
            // 
            this.kryptonRibbonGroupTriple14.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbDefineTypefaces});
            // 
            // krgbDefineTypefaces
            // 
            this.krgbDefineTypefaces.TextLine1 = "Define";
            this.krgbDefineTypefaces.TextLine2 = "Typefaces";
            // 
            // kryptonRibbonGroupTriple15
            // 
            this.kryptonRibbonGroupTriple15.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbDefineTypefaceColour});
            // 
            // krgbDefineTypefaceColour
            // 
            this.krgbDefineTypefaceColour.TextLine1 = "Define Typeface";
            this.krgbDefineTypefaceColour.TextLine2 = "Colour";
            // 
            // kryptonRibbonGroup4
            // 
            this.kryptonRibbonGroup4.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple16,
            this.kryptonRibbonGroupSeparator11,
            this.kryptonRibbonGroupTriple17,
            this.kryptonRibbonGroupSeparator12,
            this.kryptonRibbonGroupTriple19});
            // 
            // kryptonRibbonGroupTriple16
            // 
            this.kryptonRibbonGroupTriple16.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbViewType});
            // 
            // krgbViewType
            // 
            this.krgbViewType.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Split;
            this.krgbViewType.TextLine1 = "View";
            this.krgbViewType.TextLine2 = "Type";
            this.krgbViewType.Visible = false;
            // 
            // kryptonRibbonGroupTriple17
            // 
            this.kryptonRibbonGroupTriple17.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbExperimental});
            // 
            // krgbExperimental
            // 
            this.krgbExperimental.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.DropDown;
            this.krgbExperimental.TextLine1 = "Experimental";
            // 
            // kryptonRibbonGroupTriple19
            // 
            this.kryptonRibbonGroupTriple19.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbShowHidePropertiesPane,
            this.krgbShowHideColourPane});
            // 
            // krgbShowHidePropertiesPane
            // 
            this.krgbShowHidePropertiesPane.TextLine1 = "Show/Hide Palette";
            this.krgbShowHidePropertiesPane.TextLine2 = "Propertes Pane";
            this.krgbShowHidePropertiesPane.Click += new System.EventHandler(this.KrgbShowHidePropertiesPane_Click);
            // 
            // krgbShowHideColourPane
            // 
            this.krgbShowHideColourPane.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check;
            this.krgbShowHideColourPane.TextLine1 = "Show/Hide Colour";
            this.krgbShowHideColourPane.TextLine2 = "Properties Pane";
            // 
            // kryptonRibbonTab3
            // 
            this.kryptonRibbonTab3.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup6});
            this.kryptonRibbonTab3.Text = "Utili&ties";
            // 
            // kryptonRibbonGroup6
            // 
            this.kryptonRibbonGroup6.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple20,
            this.kryptonRibbonGroupSeparator14,
            this.kryptonRibbonGroupTriple18});
            // 
            // kryptonRibbonGroupTriple20
            // 
            this.kryptonRibbonGroupTriple20.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButton3});
            // 
            // kryptonRibbonGroupTriple18
            // 
            this.kryptonRibbonGroupTriple18.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbOptions,
            this.krgbExpertMode});
            // 
            // krgbOptions
            // 
            this.krgbOptions.TextLine1 = "Options /";
            this.krgbOptions.TextLine2 = "Settings";
            // 
            // krgbExpertMode
            // 
            this.krgbExpertMode.TextLine1 = "Expert";
            this.krgbExpertMode.TextLine2 = "Mode";
            this.krgbExpertMode.Click += new System.EventHandler(this.krgbExpertMode_Click);
            // 
            // kryptonRibbonTab4
            // 
            this.kryptonRibbonTab4.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup7});
            this.kryptonRibbonTab4.Text = "&Help";
            // 
            // kryptonRibbonGroup7
            // 
            this.kryptonRibbonGroup7.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple21,
            this.kryptonRibbonGroupSeparator13,
            this.kryptonRibbonGroupTriple22});
            // 
            // kryptonRibbonGroupTriple21
            // 
            this.kryptonRibbonGroupTriple21.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbAbout});
            // 
            // krgbAbout
            // 
            this.krgbAbout.TextLine1 = "About";
            // 
            // kryptonRibbonGroupTriple22
            // 
            this.kryptonRibbonGroupTriple22.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.krgbCheckForUpdates});
            // 
            // krgbCheckForUpdates
            // 
            this.krgbCheckForUpdates.TextLine1 = "Check for";
            this.krgbCheckForUpdates.TextLine2 = "Updates";
            // 
            // kMan
            // 
            this.kMan.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // kpnlStatusStrip
            // 
            this.kpnlStatusStrip.Controls.Add(this.ss);
            this.kpnlStatusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlStatusStrip.Location = new System.Drawing.Point(0, 886);
            this.kpnlStatusStrip.Name = "kpnlStatusStrip";
            this.kpnlStatusStrip.Size = new System.Drawing.Size(1649, 22);
            this.kpnlStatusStrip.TabIndex = 3;
            // 
            // ss
            // 
            this.ss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ss.Location = new System.Drawing.Point(0, 0);
            this.ss.Name = "ss";
            this.ss.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ss.Size = new System.Drawing.Size(1649, 22);
            this.ss.TabIndex = 46;
            this.ss.Text = "statusStrip1";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnClose);
            this.kryptonPanel2.Controls.Add(this.lblColourOutput);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 832);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1649, 54);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // kbtnClose
            // 
            this.kbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnClose.AutoSize = true;
            this.kbtnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnClose.Location = new System.Drawing.Point(1586, 12);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(51, 30);
            this.kbtnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnClose.TabIndex = 64;
            popupPositionValues2.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kbtnClose.ToolTipValues.ToolTipPosition = popupPositionValues2;
            this.kbtnClose.Values.Text = "&Close";
            // 
            // lblColourOutput
            // 
            this.lblColourOutput.Location = new System.Drawing.Point(12, 13);
            this.lblColourOutput.Name = "lblColourOutput";
            this.lblColourOutput.Size = new System.Drawing.Size(6, 2);
            this.lblColourOutput.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColourOutput.TabIndex = 63;
            popupPositionValues3.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.lblColourOutput.ToolTipValues.ToolTipPosition = popupPositionValues3;
            this.lblColourOutput.Values.Text = "";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonDockableNavigator1);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 115);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1649, 717);
            this.kryptonPanel3.TabIndex = 5;
            // 
            // ilImages
            // 
            this.ilImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilImages.ImageSize = new System.Drawing.Size(16, 16);
            this.ilImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // kryptonDockableNavigator1
            // 
            this.kryptonDockableNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDockableNavigator1.Name = "kryptonDockableNavigator1";
            this.kryptonDockableNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2});
            this.kryptonDockableNavigator1.SelectedIndex = 0;
            this.kryptonDockableNavigator1.Size = new System.Drawing.Size(1649, 717);
            this.kryptonDockableNavigator1.TabIndex = 0;
            this.kryptonDockableNavigator1.Text = "kryptonDockableNavigator1";
            popupPositionValues4.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kryptonDockableNavigator1.ToolTipValues.ToolTipPosition = popupPositionValues4;
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(1647, 690);
            this.kryptonPage1.Text = "kryptonPage1";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "49be86230e1f4924a833e71209f61a78";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(100, 100);
            this.kryptonPage2.Text = "kryptonPage2";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "c93c9b60d5274878be88f907b4809e18";
            // 
            // RibbonWindow
            // 
            this.ClientSize = new System.Drawing.Size(1649, 908);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kpnlStatusStrip);
            this.Controls.Add(this.krControls);
            this.Name = "RibbonWindow";
            this.Load += new System.EventHandler(this.RibbonWindow_Load);
            this.Shown += new System.EventHandler(this.RibbonWindow_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.krControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlStatusStrip)).EndInit();
            this.kpnlStatusStrip.ResumeLayout(false);
            this.kpnlStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator1)).EndInit();
            this.kryptonDockableNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Variables
        KryptonPage _page;
        PalettePropertyGrid _palettePropertyGrid;
        KryptonPalette _palette = new KryptonPalette();
        #endregion

        #region Properties        
        /// <summary>
        /// Gets and sets the custom palette implementation.
        /// </summary>
        public KryptonPalette Palette { get => _palette; set => _palette = value; }
        #endregion

        #region Constructor
        public RibbonWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void RibbonWindow_Load(object sender, EventArgs e)
        {

        }

        private void krgbExpertMode_Click(object sender, EventArgs e)
        {
            PaletteExplorerWindow pew = new PaletteExplorerWindow();

            pew.Show();
        }

        private void RibbonWindow_Shown(object sender, EventArgs e)
        {

        }
        #endregion

        #region Methods
        private KryptonPage NewPage()
        {
            return NewPage("Colour Properties", 0, new KryptonPage());
        }

        private KryptonPage NewPage(string text, int image, Control content)
        {
            _page = new KryptonPage();

            _page.Name = text;

            _page.Text = text;

            _page.TextTitle = text;

            _page.TextDescription = text;

            _page.UniqueName = text;

            //_page.ToolTipImage = ilImages.Images

            _page.ToolTipStyle = LabelStyle.GroupBoxCaption;

            _page.ToolTipTitle = text;

            content.Dock = DockStyle.Fill;

            content.Controls.Add(GetPalettePropertyGrid());

            _page.Controls.Add(content);

            _page.ClearFlags(KryptonPageFlags.DockingAllowClose | KryptonPageFlags.DockingAllowDropDown | KryptonPageFlags.DockingAllowFloating);
            _page.AutoHiddenSlideSize = GetPalettePropertyGrid().Size;

            return _page;
        }

        private PalettePropertyGrid GetPalettePropertyGrid()
        {
            _palettePropertyGrid = new PalettePropertyGrid();

            _palettePropertyGrid.Name = "PalettePropertyGrid";

            return _palettePropertyGrid;
        }
        #endregion

        private void KrgbShowHidePropertiesPane_Click(object sender, EventArgs e)
        {
            KryptonPalettePropertiesWindow kryptonPalettePropertiesWindow = new KryptonPalettePropertiesWindow(Palette);

            kryptonPalettePropertiesWindow.Show();
        }
    }
}