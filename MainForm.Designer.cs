﻿namespace com.clusterrr.hakchi_gui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                StaticRef = null;
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMoreGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autodetectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asIsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.addPresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePresetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
            this.exportGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synchronizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.resetOriginalGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kernelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashCustomKernelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.flashUbootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sDModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membootOriginalKernelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membootCustomKernelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membootRecoveryKernelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.dumpOriginalKernellegacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripSeparator();
            this.dumpTheWholeNANDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFlashTheWholeNANDStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpNANDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashNANDBPartitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpNANDCPartitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashNANDCPartitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatNANDCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.factoryResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateModulesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modRepoStartSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionAtTheTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionAtTheBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionSortedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionHiddenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGamesWithoutBoxArtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sFROMToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableSFROMToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usePCMPatchWhenAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertSNESROMSToSFROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separateGamesStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressBoxArtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerBoxArtThumbnailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableHakchi2PopupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripSeparator();
            this.developerToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devForceSshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadTotmpforTestingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripSeparator();
            this.forceNetworkMembootsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceClovershellMembootsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separateGamesForMultibootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysCopyOriginalGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useLinkedSyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripSeparator();
            this.cloverconHackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetUsingCombinationOfButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectButtonCombinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableAutofireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useXYOnClassicControllerAsAutofireABToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upABStartOnSecondControllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalCommandLineArgumentsexpertsOnluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kachikachiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canoeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retroarchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epilepsyProtectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.saveSettingsToNESMiniNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStateManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeScreenshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.openFTPInExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTelnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.bootImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBootImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableBootImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDefaultBootImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchRunningFirmwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripSeparator();
            this.prepareArtDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubPageWithActualReleasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageOfTheDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripSeparator();
            this.technicalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddGames = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusConnectionIcon = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelShell = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialogNes = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.explorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripSeparator();
            this.scanForNewBoxArtForSelectedGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadBoxArtForSelectedGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedGamesBoxArtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripSeparator();
            this.archiveSelectedGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressSelectedGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompressSelectedGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripSeparator();
            this.sFROMToolToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editROMHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.resetROMHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripSeparator();
            this.selectEmulationCoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerCalculateGames = new System.Windows.Forms.Timer(this.components);
            this.timerConnectionCheck = new System.Windows.Forms.Timer(this.components);
            this.saveDumpFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDumpFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.listViewGames = new System.Windows.Forms.ListView();
            this.gameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerShowSelected = new System.Windows.Forms.Timer(this.components);
            this.buttonExport = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.radioButtonOne = new System.Windows.Forms.RadioButton();
            this.radioButtonTwo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxArguments = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxArt = new System.Windows.Forms.PictureBox();
            this.buttonBrowseImage = new System.Windows.Forms.Button();
            this.buttonGoogle = new System.Windows.Forms.Button();
            this.radioButtonTwoSim = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGameGenie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxReleaseDate = new System.Windows.Forms.MaskedTextBox();
            this.buttonShowGameGenieDatabase = new System.Windows.Forms.Button();
            this.checkBoxCompressed = new System.Windows.Forms.CheckBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonDefaultCover = new System.Windows.Forms.Button();
            this.pictureBoxThumbnail = new System.Windows.Forms.PictureBox();
            this.labelSortName = new System.Windows.Forms.Label();
            this.textBoxSortName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownSaveCount = new System.Windows.Forms.NumericUpDown();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.structureButton = new System.Windows.Forms.Button();
            this.foldersContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.disablePagefoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.automaticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticOriginalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagesOriginalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foldersOriginalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foldersSplitByFirstLetterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foldersSplitByFirstLetterOriginalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.maximumGamesPerFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backFolderButtonPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftmostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightmostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderImagesSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripSeparator();
            this.syncStructureForAllGamesCollectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesConsoleComboBox = new System.Windows.Forms.ComboBox();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.modRepoEndSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.manageModRepositoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaveCount)).BeginInit();
            this.groupBoxOptions.SuspendLayout();
            this.foldersContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.kernelToolStripMenuItem,
            this.modulesToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMoreGamesToolStripMenuItem,
            this.addCustomAppToolStripMenuItem,
            this.presetsToolStripMenuItem,
            this.toolStripMenuItem13,
            this.exportGamesToolStripMenuItem,
            this.synchronizeToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.reloadGamesToolStripMenuItem,
            this.toolStripMenuItem12,
            this.resetOriginalGamesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // addMoreGamesToolStripMenuItem
            // 
            this.addMoreGamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autodetectToolStripMenuItem,
            this.asIsToolStripMenuItem});
            this.addMoreGamesToolStripMenuItem.Name = "addMoreGamesToolStripMenuItem";
            resources.ApplyResources(this.addMoreGamesToolStripMenuItem, "addMoreGamesToolStripMenuItem");
            // 
            // autodetectToolStripMenuItem
            // 
            this.autodetectToolStripMenuItem.Name = "autodetectToolStripMenuItem";
            resources.ApplyResources(this.autodetectToolStripMenuItem, "autodetectToolStripMenuItem");
            this.autodetectToolStripMenuItem.Click += new System.EventHandler(this.buttonAddGames_Click);
            // 
            // asIsToolStripMenuItem
            // 
            this.asIsToolStripMenuItem.Name = "asIsToolStripMenuItem";
            resources.ApplyResources(this.asIsToolStripMenuItem, "asIsToolStripMenuItem");
            this.asIsToolStripMenuItem.Click += new System.EventHandler(this.asIsToolStripMenuItem_Click);
            // 
            // addCustomAppToolStripMenuItem
            // 
            this.addCustomAppToolStripMenuItem.Name = "addCustomAppToolStripMenuItem";
            resources.ApplyResources(this.addCustomAppToolStripMenuItem, "addCustomAppToolStripMenuItem");
            this.addCustomAppToolStripMenuItem.Click += new System.EventHandler(this.addCustomAppToolStripMenuItem_Click);
            // 
            // presetsToolStripMenuItem
            // 
            this.presetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.addPresetToolStripMenuItem,
            this.deletePresetToolStripMenuItem});
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            resources.ApplyResources(this.presetsToolStripMenuItem, "presetsToolStripMenuItem");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // addPresetToolStripMenuItem
            // 
            this.addPresetToolStripMenuItem.Name = "addPresetToolStripMenuItem";
            resources.ApplyResources(this.addPresetToolStripMenuItem, "addPresetToolStripMenuItem");
            this.addPresetToolStripMenuItem.Click += new System.EventHandler(this.AddPreset);
            // 
            // deletePresetToolStripMenuItem
            // 
            this.deletePresetToolStripMenuItem.Name = "deletePresetToolStripMenuItem";
            resources.ApplyResources(this.deletePresetToolStripMenuItem, "deletePresetToolStripMenuItem");
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            resources.ApplyResources(this.toolStripMenuItem13, "toolStripMenuItem13");
            // 
            // exportGamesToolStripMenuItem
            // 
            this.exportGamesToolStripMenuItem.Name = "exportGamesToolStripMenuItem";
            resources.ApplyResources(this.exportGamesToolStripMenuItem, "exportGamesToolStripMenuItem");
            this.exportGamesToolStripMenuItem.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // synchronizeToolStripMenuItem
            // 
            this.synchronizeToolStripMenuItem.Name = "synchronizeToolStripMenuItem";
            resources.ApplyResources(this.synchronizeToolStripMenuItem, "synchronizeToolStripMenuItem");
            this.synchronizeToolStripMenuItem.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            resources.ApplyResources(this.searchToolStripMenuItem, "searchToolStripMenuItem");
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // reloadGamesToolStripMenuItem
            // 
            this.reloadGamesToolStripMenuItem.Name = "reloadGamesToolStripMenuItem";
            resources.ApplyResources(this.reloadGamesToolStripMenuItem, "reloadGamesToolStripMenuItem");
            this.reloadGamesToolStripMenuItem.Click += new System.EventHandler(this.reloadGamesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            resources.ApplyResources(this.toolStripMenuItem12, "toolStripMenuItem12");
            // 
            // resetOriginalGamesToolStripMenuItem
            // 
            this.resetOriginalGamesToolStripMenuItem.Name = "resetOriginalGamesToolStripMenuItem";
            resources.ApplyResources(this.resetOriginalGamesToolStripMenuItem, "resetOriginalGamesToolStripMenuItem");
            this.resetOriginalGamesToolStripMenuItem.Click += new System.EventHandler(this.resetOriginalGamesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // kernelToolStripMenuItem
            // 
            this.kernelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flashCustomKernelToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.uninstallToolStripMenuItem,
            this.toolStripMenuItem11,
            this.flashUbootToolStripMenuItem,
            this.advancedToolStripMenuItem});
            this.kernelToolStripMenuItem.Name = "kernelToolStripMenuItem";
            resources.ApplyResources(this.kernelToolStripMenuItem, "kernelToolStripMenuItem");
            // 
            // flashCustomKernelToolStripMenuItem
            // 
            this.flashCustomKernelToolStripMenuItem.Name = "flashCustomKernelToolStripMenuItem";
            resources.ApplyResources(this.flashCustomKernelToolStripMenuItem, "flashCustomKernelToolStripMenuItem");
            this.flashCustomKernelToolStripMenuItem.Click += new System.EventHandler(this.flashCustomKernelToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resources.ApplyResources(this.resetToolStripMenuItem, "resetToolStripMenuItem");
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // uninstallToolStripMenuItem
            // 
            this.uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
            resources.ApplyResources(this.uninstallToolStripMenuItem, "uninstallToolStripMenuItem");
            this.uninstallToolStripMenuItem.Click += new System.EventHandler(this.uninstallToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            resources.ApplyResources(this.toolStripMenuItem11, "toolStripMenuItem11");
            // 
            // flashUbootToolStripMenuItem
            // 
            this.flashUbootToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalModeToolStripMenuItem,
            this.sDModeToolStripMenuItem});
            this.flashUbootToolStripMenuItem.Name = "flashUbootToolStripMenuItem";
            resources.ApplyResources(this.flashUbootToolStripMenuItem, "flashUbootToolStripMenuItem");
            // 
            // normalModeToolStripMenuItem
            // 
            this.normalModeToolStripMenuItem.Name = "normalModeToolStripMenuItem";
            resources.ApplyResources(this.normalModeToolStripMenuItem, "normalModeToolStripMenuItem");
            this.normalModeToolStripMenuItem.Click += new System.EventHandler(this.normalModeToolStripMenuItem_Click);
            // 
            // sDModeToolStripMenuItem
            // 
            this.sDModeToolStripMenuItem.Name = "sDModeToolStripMenuItem";
            resources.ApplyResources(this.sDModeToolStripMenuItem, "sDModeToolStripMenuItem");
            this.sDModeToolStripMenuItem.Click += new System.EventHandler(this.sDModeToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membootOriginalKernelToolStripMenuItem,
            this.membootCustomKernelToolStripMenuItem,
            this.membootRecoveryKernelToolStripMenuItem,
            this.toolStripMenuItem10,
            this.dumpOriginalKernellegacyToolStripMenuItem,
            this.toolStripMenuItem24,
            this.dumpTheWholeNANDToolStripMenuItem,
            this.toolFlashTheWholeNANDStripMenuItem,
            this.dumpNANDBToolStripMenuItem,
            this.flashNANDBPartitionToolStripMenuItem,
            this.dumpNANDCPartitionToolStripMenuItem,
            this.flashNANDCPartitionToolStripMenuItem,
            this.formatNANDCToolStripMenuItem,
            this.toolStripSeparator1,
            this.factoryResetToolStripMenuItem});
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            resources.ApplyResources(this.advancedToolStripMenuItem, "advancedToolStripMenuItem");
            // 
            // membootOriginalKernelToolStripMenuItem
            // 
            this.membootOriginalKernelToolStripMenuItem.Name = "membootOriginalKernelToolStripMenuItem";
            resources.ApplyResources(this.membootOriginalKernelToolStripMenuItem, "membootOriginalKernelToolStripMenuItem");
            this.membootOriginalKernelToolStripMenuItem.Click += new System.EventHandler(this.membootOriginalKernelToolStripMenuItem_Click);
            // 
            // membootCustomKernelToolStripMenuItem
            // 
            this.membootCustomKernelToolStripMenuItem.Name = "membootCustomKernelToolStripMenuItem";
            resources.ApplyResources(this.membootCustomKernelToolStripMenuItem, "membootCustomKernelToolStripMenuItem");
            this.membootCustomKernelToolStripMenuItem.Click += new System.EventHandler(this.membootCustomKernelToolStripMenuItem_Click);
            // 
            // membootRecoveryKernelToolStripMenuItem
            // 
            this.membootRecoveryKernelToolStripMenuItem.Name = "membootRecoveryKernelToolStripMenuItem";
            resources.ApplyResources(this.membootRecoveryKernelToolStripMenuItem, "membootRecoveryKernelToolStripMenuItem");
            this.membootRecoveryKernelToolStripMenuItem.Click += new System.EventHandler(this.membootRecoveryKernelToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            resources.ApplyResources(this.toolStripMenuItem10, "toolStripMenuItem10");
            // 
            // dumpOriginalKernellegacyToolStripMenuItem
            // 
            this.dumpOriginalKernellegacyToolStripMenuItem.Name = "dumpOriginalKernellegacyToolStripMenuItem";
            resources.ApplyResources(this.dumpOriginalKernellegacyToolStripMenuItem, "dumpOriginalKernellegacyToolStripMenuItem");
            this.dumpOriginalKernellegacyToolStripMenuItem.Click += new System.EventHandler(this.dumpOriginalKernellegacyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            resources.ApplyResources(this.toolStripMenuItem24, "toolStripMenuItem24");
            // 
            // dumpTheWholeNANDToolStripMenuItem
            // 
            this.dumpTheWholeNANDToolStripMenuItem.Name = "dumpTheWholeNANDToolStripMenuItem";
            resources.ApplyResources(this.dumpTheWholeNANDToolStripMenuItem, "dumpTheWholeNANDToolStripMenuItem");
            this.dumpTheWholeNANDToolStripMenuItem.Click += new System.EventHandler(this.dumpTheWholeNANDToolStripMenuItem_Click);
            // 
            // toolFlashTheWholeNANDStripMenuItem
            // 
            this.toolFlashTheWholeNANDStripMenuItem.Name = "toolFlashTheWholeNANDStripMenuItem";
            resources.ApplyResources(this.toolFlashTheWholeNANDStripMenuItem, "toolFlashTheWholeNANDStripMenuItem");
            this.toolFlashTheWholeNANDStripMenuItem.Click += new System.EventHandler(this.toolFlashTheWholeNANDStripMenuItem_Click);
            // 
            // dumpNANDBToolStripMenuItem
            // 
            this.dumpNANDBToolStripMenuItem.Name = "dumpNANDBToolStripMenuItem";
            resources.ApplyResources(this.dumpNANDBToolStripMenuItem, "dumpNANDBToolStripMenuItem");
            this.dumpNANDBToolStripMenuItem.Click += new System.EventHandler(this.dumpNANDBToolStripMenuItem_Click);
            // 
            // flashNANDBPartitionToolStripMenuItem
            // 
            this.flashNANDBPartitionToolStripMenuItem.Name = "flashNANDBPartitionToolStripMenuItem";
            resources.ApplyResources(this.flashNANDBPartitionToolStripMenuItem, "flashNANDBPartitionToolStripMenuItem");
            this.flashNANDBPartitionToolStripMenuItem.Click += new System.EventHandler(this.flashNANDBPartitionToolStripMenuItem_Click);
            // 
            // dumpNANDCPartitionToolStripMenuItem
            // 
            this.dumpNANDCPartitionToolStripMenuItem.Name = "dumpNANDCPartitionToolStripMenuItem";
            resources.ApplyResources(this.dumpNANDCPartitionToolStripMenuItem, "dumpNANDCPartitionToolStripMenuItem");
            this.dumpNANDCPartitionToolStripMenuItem.Click += new System.EventHandler(this.dumpNANDCPartitionToolStripMenuItem_Click);
            // 
            // flashNANDCPartitionToolStripMenuItem
            // 
            this.flashNANDCPartitionToolStripMenuItem.Name = "flashNANDCPartitionToolStripMenuItem";
            resources.ApplyResources(this.flashNANDCPartitionToolStripMenuItem, "flashNANDCPartitionToolStripMenuItem");
            this.flashNANDCPartitionToolStripMenuItem.Click += new System.EventHandler(this.flashNANDCPartitionToolStripMenuItem_Click);
            // 
            // formatNANDCToolStripMenuItem
            // 
            this.formatNANDCToolStripMenuItem.Name = "formatNANDCToolStripMenuItem";
            resources.ApplyResources(this.formatNANDCToolStripMenuItem, "formatNANDCToolStripMenuItem");
            this.formatNANDCToolStripMenuItem.Click += new System.EventHandler(this.formatNANDCToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // factoryResetToolStripMenuItem
            // 
            resources.ApplyResources(this.factoryResetToolStripMenuItem, "factoryResetToolStripMenuItem");
            this.factoryResetToolStripMenuItem.Name = "factoryResetToolStripMenuItem";
            this.factoryResetToolStripMenuItem.Click += new System.EventHandler(this.factoryResetToolStripMenuItem_Click);
            // 
            // modulesToolStripMenuItem
            // 
            this.modulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installModulesToolStripMenuItem,
            this.uninstallModulesToolStripMenuItem,
            this.generateModulesReportToolStripMenuItem,
            this.modRepoStartSeparator,
            this.modRepoEndSeparator,
            this.manageModRepositoriesToolStripMenuItem});
            this.modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            resources.ApplyResources(this.modulesToolStripMenuItem, "modulesToolStripMenuItem");
            // 
            // installModulesToolStripMenuItem
            // 
            this.installModulesToolStripMenuItem.Name = "installModulesToolStripMenuItem";
            resources.ApplyResources(this.installModulesToolStripMenuItem, "installModulesToolStripMenuItem");
            this.installModulesToolStripMenuItem.Click += new System.EventHandler(this.installModulesToolStripMenuItem_Click);
            // 
            // uninstallModulesToolStripMenuItem
            // 
            this.uninstallModulesToolStripMenuItem.Name = "uninstallModulesToolStripMenuItem";
            resources.ApplyResources(this.uninstallModulesToolStripMenuItem, "uninstallModulesToolStripMenuItem");
            this.uninstallModulesToolStripMenuItem.Click += new System.EventHandler(this.uninstallModulesToolStripMenuItem_Click);
            // 
            // generateModulesReportToolStripMenuItem
            // 
            this.generateModulesReportToolStripMenuItem.Name = "generateModulesReportToolStripMenuItem";
            resources.ApplyResources(this.generateModulesReportToolStripMenuItem, "generateModulesReportToolStripMenuItem");
            this.generateModulesReportToolStripMenuItem.Click += new System.EventHandler(this.generateModulesReportToolStripMenuItem_Click);
            // 
            // modRepoStartSeparator
            // 
            this.modRepoStartSeparator.Name = "modRepoStartSeparator";
            resources.ApplyResources(this.modRepoStartSeparator, "modRepoStartSeparator");
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.originalGamesToolStripMenuItem,
            this.sortByToolStripMenuItem,
            this.showGamesWithoutBoxArtToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // originalGamesToolStripMenuItem
            // 
            this.originalGamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionAtTheTopToolStripMenuItem,
            this.positionAtTheBottomToolStripMenuItem,
            this.positionSortedToolStripMenuItem,
            this.positionHiddenToolStripMenuItem});
            this.originalGamesToolStripMenuItem.Name = "originalGamesToolStripMenuItem";
            resources.ApplyResources(this.originalGamesToolStripMenuItem, "originalGamesToolStripMenuItem");
            // 
            // positionAtTheTopToolStripMenuItem
            // 
            this.positionAtTheTopToolStripMenuItem.Name = "positionAtTheTopToolStripMenuItem";
            resources.ApplyResources(this.positionAtTheTopToolStripMenuItem, "positionAtTheTopToolStripMenuItem");
            this.positionAtTheTopToolStripMenuItem.Tag = "0";
            this.positionAtTheTopToolStripMenuItem.Click += new System.EventHandler(this.originalGamesPositionToolStripMenuItem_Click);
            // 
            // positionAtTheBottomToolStripMenuItem
            // 
            this.positionAtTheBottomToolStripMenuItem.Name = "positionAtTheBottomToolStripMenuItem";
            resources.ApplyResources(this.positionAtTheBottomToolStripMenuItem, "positionAtTheBottomToolStripMenuItem");
            this.positionAtTheBottomToolStripMenuItem.Tag = "1";
            this.positionAtTheBottomToolStripMenuItem.Click += new System.EventHandler(this.originalGamesPositionToolStripMenuItem_Click);
            // 
            // positionSortedToolStripMenuItem
            // 
            this.positionSortedToolStripMenuItem.Name = "positionSortedToolStripMenuItem";
            resources.ApplyResources(this.positionSortedToolStripMenuItem, "positionSortedToolStripMenuItem");
            this.positionSortedToolStripMenuItem.Tag = "2";
            this.positionSortedToolStripMenuItem.Click += new System.EventHandler(this.originalGamesPositionToolStripMenuItem_Click);
            // 
            // positionHiddenToolStripMenuItem
            // 
            this.positionHiddenToolStripMenuItem.Name = "positionHiddenToolStripMenuItem";
            resources.ApplyResources(this.positionHiddenToolStripMenuItem, "positionHiddenToolStripMenuItem");
            this.positionHiddenToolStripMenuItem.Tag = "3";
            this.positionHiddenToolStripMenuItem.Click += new System.EventHandler(this.originalGamesPositionToolStripMenuItem_Click);
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.coreToolStripMenuItem,
            this.systemToolStripMenuItem});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            resources.ApplyResources(this.sortByToolStripMenuItem, "sortByToolStripMenuItem");
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            resources.ApplyResources(this.nameToolStripMenuItem, "nameToolStripMenuItem");
            this.nameToolStripMenuItem.Tag = "0";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.sortByToolStripMenuItem_Click);
            // 
            // coreToolStripMenuItem
            // 
            this.coreToolStripMenuItem.Name = "coreToolStripMenuItem";
            resources.ApplyResources(this.coreToolStripMenuItem, "coreToolStripMenuItem");
            this.coreToolStripMenuItem.Tag = "1";
            this.coreToolStripMenuItem.Click += new System.EventHandler(this.sortByToolStripMenuItem_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            resources.ApplyResources(this.systemToolStripMenuItem, "systemToolStripMenuItem");
            this.systemToolStripMenuItem.Tag = "2";
            this.systemToolStripMenuItem.Click += new System.EventHandler(this.sortByToolStripMenuItem_Click);
            // 
            // showGamesWithoutBoxArtToolStripMenuItem
            // 
            this.showGamesWithoutBoxArtToolStripMenuItem.Checked = true;
            this.showGamesWithoutBoxArtToolStripMenuItem.CheckOnClick = true;
            this.showGamesWithoutBoxArtToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showGamesWithoutBoxArtToolStripMenuItem.Name = "showGamesWithoutBoxArtToolStripMenuItem";
            resources.ApplyResources(this.showGamesWithoutBoxArtToolStripMenuItem, "showGamesWithoutBoxArtToolStripMenuItem");
            this.showGamesWithoutBoxArtToolStripMenuItem.Click += new System.EventHandler(this.showGamesWithoutBoxArtToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.sFROMToolToolStripMenuItem,
            this.convertSNESROMSToSFROMToolStripMenuItem,
            this.separateGamesStorageToolStripMenuItem,
            this.compressGamesToolStripMenuItem,
            this.compressBoxArtToolStripMenuItem,
            this.centerBoxArtThumbnailToolStripMenuItem,
            this.disableHakchi2PopupsToolStripMenuItem,
            this.toolStripMenuItem25,
            this.developerToolsToolStripMenuItem,
            this.separateGamesForMultibootToolStripMenuItem,
            this.alwaysCopyOriginalGamesToolStripMenuItem,
            this.useLinkedSyncToolStripMenuItem,
            this.toolStripMenuItem16,
            this.cloverconHackToolStripMenuItem,
            this.globalCommandLineArgumentsexpertsOnluToolStripMenuItem,
            this.epilepsyProtectionToolStripMenuItem,
            this.toolStripMenuItem5,
            this.saveSettingsToNESMiniNowToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // sFROMToolToolStripMenuItem
            // 
            this.sFROMToolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableSFROMToolToolStripMenuItem,
            this.usePCMPatchWhenAvailableToolStripMenuItem});
            this.sFROMToolToolStripMenuItem.Name = "sFROMToolToolStripMenuItem";
            resources.ApplyResources(this.sFROMToolToolStripMenuItem, "sFROMToolToolStripMenuItem");
            // 
            // enableSFROMToolToolStripMenuItem
            // 
            this.enableSFROMToolToolStripMenuItem.CheckOnClick = true;
            this.enableSFROMToolToolStripMenuItem.Name = "enableSFROMToolToolStripMenuItem";
            resources.ApplyResources(this.enableSFROMToolToolStripMenuItem, "enableSFROMToolToolStripMenuItem");
            this.enableSFROMToolToolStripMenuItem.Click += new System.EventHandler(this.enableSFROMToolToolStripMenuItem_Click);
            // 
            // usePCMPatchWhenAvailableToolStripMenuItem
            // 
            this.usePCMPatchWhenAvailableToolStripMenuItem.CheckOnClick = true;
            this.usePCMPatchWhenAvailableToolStripMenuItem.Name = "usePCMPatchWhenAvailableToolStripMenuItem";
            resources.ApplyResources(this.usePCMPatchWhenAvailableToolStripMenuItem, "usePCMPatchWhenAvailableToolStripMenuItem");
            this.usePCMPatchWhenAvailableToolStripMenuItem.Click += new System.EventHandler(this.usePCMPatchWhenAvailableToolStripMenuItem_Click);
            // 
            // convertSNESROMSToSFROMToolStripMenuItem
            // 
            this.convertSNESROMSToSFROMToolStripMenuItem.Checked = true;
            this.convertSNESROMSToSFROMToolStripMenuItem.CheckOnClick = true;
            this.convertSNESROMSToSFROMToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.convertSNESROMSToSFROMToolStripMenuItem.Name = "convertSNESROMSToSFROMToolStripMenuItem";
            resources.ApplyResources(this.convertSNESROMSToSFROMToolStripMenuItem, "convertSNESROMSToSFROMToolStripMenuItem");
            this.convertSNESROMSToSFROMToolStripMenuItem.Click += new System.EventHandler(this.convertSNESROMSToSFROMToolStripMenuItem_Click);
            // 
            // separateGamesStorageToolStripMenuItem
            // 
            this.separateGamesStorageToolStripMenuItem.Checked = true;
            this.separateGamesStorageToolStripMenuItem.CheckOnClick = true;
            this.separateGamesStorageToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.separateGamesStorageToolStripMenuItem.Name = "separateGamesStorageToolStripMenuItem";
            resources.ApplyResources(this.separateGamesStorageToolStripMenuItem, "separateGamesStorageToolStripMenuItem");
            this.separateGamesStorageToolStripMenuItem.Click += new System.EventHandler(this.separateGamesStorageToolStripMenuItem_Click);
            // 
            // compressGamesToolStripMenuItem
            // 
            this.compressGamesToolStripMenuItem.Checked = true;
            this.compressGamesToolStripMenuItem.CheckOnClick = true;
            this.compressGamesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.compressGamesToolStripMenuItem.Name = "compressGamesToolStripMenuItem";
            resources.ApplyResources(this.compressGamesToolStripMenuItem, "compressGamesToolStripMenuItem");
            this.compressGamesToolStripMenuItem.Click += new System.EventHandler(this.compressGamesToolStripMenuItem_Click);
            // 
            // compressBoxArtToolStripMenuItem
            // 
            this.compressBoxArtToolStripMenuItem.Checked = true;
            this.compressBoxArtToolStripMenuItem.CheckOnClick = true;
            this.compressBoxArtToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.compressBoxArtToolStripMenuItem.Name = "compressBoxArtToolStripMenuItem";
            resources.ApplyResources(this.compressBoxArtToolStripMenuItem, "compressBoxArtToolStripMenuItem");
            this.compressBoxArtToolStripMenuItem.Click += new System.EventHandler(this.compressBoxArtToolStripMenuItem_Click);
            // 
            // centerBoxArtThumbnailToolStripMenuItem
            // 
            this.centerBoxArtThumbnailToolStripMenuItem.Checked = true;
            this.centerBoxArtThumbnailToolStripMenuItem.CheckOnClick = true;
            this.centerBoxArtThumbnailToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.centerBoxArtThumbnailToolStripMenuItem.Name = "centerBoxArtThumbnailToolStripMenuItem";
            resources.ApplyResources(this.centerBoxArtThumbnailToolStripMenuItem, "centerBoxArtThumbnailToolStripMenuItem");
            this.centerBoxArtThumbnailToolStripMenuItem.Click += new System.EventHandler(this.centerBoxArtThumbnailToolStripMenuItem_Click);
            // 
            // disableHakchi2PopupsToolStripMenuItem
            // 
            this.disableHakchi2PopupsToolStripMenuItem.Checked = true;
            this.disableHakchi2PopupsToolStripMenuItem.CheckOnClick = true;
            this.disableHakchi2PopupsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.disableHakchi2PopupsToolStripMenuItem.Name = "disableHakchi2PopupsToolStripMenuItem";
            resources.ApplyResources(this.disableHakchi2PopupsToolStripMenuItem, "disableHakchi2PopupsToolStripMenuItem");
            this.disableHakchi2PopupsToolStripMenuItem.Click += new System.EventHandler(this.disableHakchi2PopupsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            resources.ApplyResources(this.toolStripMenuItem25, "toolStripMenuItem25");
            // 
            // developerToolsToolStripMenuItem
            // 
            this.developerToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devForceSshToolStripMenuItem,
            this.uploadTotmpforTestingToolStripMenuItem,
            this.toolStripMenuItem23,
            this.forceNetworkMembootsToolStripMenuItem,
            this.forceClovershellMembootsToolStripMenuItem});
            this.developerToolsToolStripMenuItem.Name = "developerToolsToolStripMenuItem";
            resources.ApplyResources(this.developerToolsToolStripMenuItem, "developerToolsToolStripMenuItem");
            // 
            // devForceSshToolStripMenuItem
            // 
            this.devForceSshToolStripMenuItem.CheckOnClick = true;
            this.devForceSshToolStripMenuItem.Name = "devForceSshToolStripMenuItem";
            resources.ApplyResources(this.devForceSshToolStripMenuItem, "devForceSshToolStripMenuItem");
            this.devForceSshToolStripMenuItem.Click += new System.EventHandler(this.devForceSshToolStripMenuItem_Click);
            // 
            // uploadTotmpforTestingToolStripMenuItem
            // 
            this.uploadTotmpforTestingToolStripMenuItem.CheckOnClick = true;
            this.uploadTotmpforTestingToolStripMenuItem.Name = "uploadTotmpforTestingToolStripMenuItem";
            resources.ApplyResources(this.uploadTotmpforTestingToolStripMenuItem, "uploadTotmpforTestingToolStripMenuItem");
            this.uploadTotmpforTestingToolStripMenuItem.Click += new System.EventHandler(this.uploadTotmpforTestingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            resources.ApplyResources(this.toolStripMenuItem23, "toolStripMenuItem23");
            // 
            // forceNetworkMembootsToolStripMenuItem
            // 
            this.forceNetworkMembootsToolStripMenuItem.CheckOnClick = true;
            this.forceNetworkMembootsToolStripMenuItem.Name = "forceNetworkMembootsToolStripMenuItem";
            resources.ApplyResources(this.forceNetworkMembootsToolStripMenuItem, "forceNetworkMembootsToolStripMenuItem");
            this.forceNetworkMembootsToolStripMenuItem.Click += new System.EventHandler(this.forceNetworkMembootsToolStripMenuItem_Click);
            // 
            // forceClovershellMembootsToolStripMenuItem
            // 
            this.forceClovershellMembootsToolStripMenuItem.CheckOnClick = true;
            this.forceClovershellMembootsToolStripMenuItem.Name = "forceClovershellMembootsToolStripMenuItem";
            resources.ApplyResources(this.forceClovershellMembootsToolStripMenuItem, "forceClovershellMembootsToolStripMenuItem");
            this.forceClovershellMembootsToolStripMenuItem.Click += new System.EventHandler(this.forceClovershellMembootsToolStripMenuItem_Click);
            // 
            // separateGamesForMultibootToolStripMenuItem
            // 
            this.separateGamesForMultibootToolStripMenuItem.Checked = true;
            this.separateGamesForMultibootToolStripMenuItem.CheckOnClick = true;
            this.separateGamesForMultibootToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.separateGamesForMultibootToolStripMenuItem.Name = "separateGamesForMultibootToolStripMenuItem";
            resources.ApplyResources(this.separateGamesForMultibootToolStripMenuItem, "separateGamesForMultibootToolStripMenuItem");
            this.separateGamesForMultibootToolStripMenuItem.Click += new System.EventHandler(this.separateGamesForMultibootToolStripMenuItem_Click);
            // 
            // alwaysCopyOriginalGamesToolStripMenuItem
            // 
            this.alwaysCopyOriginalGamesToolStripMenuItem.Checked = true;
            this.alwaysCopyOriginalGamesToolStripMenuItem.CheckOnClick = true;
            this.alwaysCopyOriginalGamesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alwaysCopyOriginalGamesToolStripMenuItem.Name = "alwaysCopyOriginalGamesToolStripMenuItem";
            resources.ApplyResources(this.alwaysCopyOriginalGamesToolStripMenuItem, "alwaysCopyOriginalGamesToolStripMenuItem");
            this.alwaysCopyOriginalGamesToolStripMenuItem.Click += new System.EventHandler(this.alwaysCopyOriginalGamesToolStripMenuItem_Click);
            // 
            // useLinkedSyncToolStripMenuItem
            // 
            this.useLinkedSyncToolStripMenuItem.Checked = true;
            this.useLinkedSyncToolStripMenuItem.CheckOnClick = true;
            this.useLinkedSyncToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useLinkedSyncToolStripMenuItem.Name = "useLinkedSyncToolStripMenuItem";
            resources.ApplyResources(this.useLinkedSyncToolStripMenuItem, "useLinkedSyncToolStripMenuItem");
            this.useLinkedSyncToolStripMenuItem.Click += new System.EventHandler(this.useLinkedSyncToolStripMenuItem_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            resources.ApplyResources(this.toolStripMenuItem16, "toolStripMenuItem16");
            // 
            // cloverconHackToolStripMenuItem
            // 
            this.cloverconHackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetUsingCombinationOfButtonsToolStripMenuItem,
            this.selectButtonCombinationToolStripMenuItem,
            this.enableAutofireToolStripMenuItem,
            this.useXYOnClassicControllerAsAutofireABToolStripMenuItem,
            this.upABStartOnSecondControllerToolStripMenuItem});
            this.cloverconHackToolStripMenuItem.Name = "cloverconHackToolStripMenuItem";
            resources.ApplyResources(this.cloverconHackToolStripMenuItem, "cloverconHackToolStripMenuItem");
            // 
            // resetUsingCombinationOfButtonsToolStripMenuItem
            // 
            this.resetUsingCombinationOfButtonsToolStripMenuItem.Checked = true;
            this.resetUsingCombinationOfButtonsToolStripMenuItem.CheckOnClick = true;
            this.resetUsingCombinationOfButtonsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.resetUsingCombinationOfButtonsToolStripMenuItem.Name = "resetUsingCombinationOfButtonsToolStripMenuItem";
            resources.ApplyResources(this.resetUsingCombinationOfButtonsToolStripMenuItem, "resetUsingCombinationOfButtonsToolStripMenuItem");
            this.resetUsingCombinationOfButtonsToolStripMenuItem.Click += new System.EventHandler(this.cloverconHackToolStripMenuItem_Click);
            // 
            // selectButtonCombinationToolStripMenuItem
            // 
            this.selectButtonCombinationToolStripMenuItem.Name = "selectButtonCombinationToolStripMenuItem";
            resources.ApplyResources(this.selectButtonCombinationToolStripMenuItem, "selectButtonCombinationToolStripMenuItem");
            this.selectButtonCombinationToolStripMenuItem.Click += new System.EventHandler(this.selectButtonCombinationToolStripMenuItem_Click);
            // 
            // enableAutofireToolStripMenuItem
            // 
            this.enableAutofireToolStripMenuItem.CheckOnClick = true;
            this.enableAutofireToolStripMenuItem.Name = "enableAutofireToolStripMenuItem";
            resources.ApplyResources(this.enableAutofireToolStripMenuItem, "enableAutofireToolStripMenuItem");
            this.enableAutofireToolStripMenuItem.Click += new System.EventHandler(this.enableAutofireToolStripMenuItem_Click);
            // 
            // useXYOnClassicControllerAsAutofireABToolStripMenuItem
            // 
            this.useXYOnClassicControllerAsAutofireABToolStripMenuItem.CheckOnClick = true;
            this.useXYOnClassicControllerAsAutofireABToolStripMenuItem.Name = "useXYOnClassicControllerAsAutofireABToolStripMenuItem";
            resources.ApplyResources(this.useXYOnClassicControllerAsAutofireABToolStripMenuItem, "useXYOnClassicControllerAsAutofireABToolStripMenuItem");
            this.useXYOnClassicControllerAsAutofireABToolStripMenuItem.Click += new System.EventHandler(this.useXYOnClassicControllerAsAutofireABToolStripMenuItem_Click);
            // 
            // upABStartOnSecondControllerToolStripMenuItem
            // 
            this.upABStartOnSecondControllerToolStripMenuItem.CheckOnClick = true;
            this.upABStartOnSecondControllerToolStripMenuItem.Name = "upABStartOnSecondControllerToolStripMenuItem";
            resources.ApplyResources(this.upABStartOnSecondControllerToolStripMenuItem, "upABStartOnSecondControllerToolStripMenuItem");
            this.upABStartOnSecondControllerToolStripMenuItem.Click += new System.EventHandler(this.upABStartOnSecondControllerToolStripMenuItem_Click);
            // 
            // globalCommandLineArgumentsexpertsOnluToolStripMenuItem
            // 
            this.globalCommandLineArgumentsexpertsOnluToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kachikachiToolStripMenuItem,
            this.canoeToolStripMenuItem,
            this.retroarchToolStripMenuItem});
            this.globalCommandLineArgumentsexpertsOnluToolStripMenuItem.Name = "globalCommandLineArgumentsexpertsOnluToolStripMenuItem";
            resources.ApplyResources(this.globalCommandLineArgumentsexpertsOnluToolStripMenuItem, "globalCommandLineArgumentsexpertsOnluToolStripMenuItem");
            // 
            // kachikachiToolStripMenuItem
            // 
            this.kachikachiToolStripMenuItem.Name = "kachikachiToolStripMenuItem";
            resources.ApplyResources(this.kachikachiToolStripMenuItem, "kachikachiToolStripMenuItem");
            this.kachikachiToolStripMenuItem.Tag = "0";
            this.kachikachiToolStripMenuItem.Click += new System.EventHandler(this.globalCommandLineArgumentsexpertsOnluToolStripMenuItem_Click);
            // 
            // canoeToolStripMenuItem
            // 
            this.canoeToolStripMenuItem.Name = "canoeToolStripMenuItem";
            resources.ApplyResources(this.canoeToolStripMenuItem, "canoeToolStripMenuItem");
            this.canoeToolStripMenuItem.Tag = "1";
            this.canoeToolStripMenuItem.Click += new System.EventHandler(this.globalCommandLineArgumentsexpertsOnluToolStripMenuItem_Click);
            // 
            // retroarchToolStripMenuItem
            // 
            this.retroarchToolStripMenuItem.Name = "retroarchToolStripMenuItem";
            resources.ApplyResources(this.retroarchToolStripMenuItem, "retroarchToolStripMenuItem");
            this.retroarchToolStripMenuItem.Tag = "2";
            this.retroarchToolStripMenuItem.Click += new System.EventHandler(this.globalCommandLineArgumentsexpertsOnluToolStripMenuItem_Click);
            // 
            // epilepsyProtectionToolStripMenuItem
            // 
            this.epilepsyProtectionToolStripMenuItem.Checked = true;
            this.epilepsyProtectionToolStripMenuItem.CheckOnClick = true;
            this.epilepsyProtectionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.epilepsyProtectionToolStripMenuItem.Name = "epilepsyProtectionToolStripMenuItem";
            resources.ApplyResources(this.epilepsyProtectionToolStripMenuItem, "epilepsyProtectionToolStripMenuItem");
            this.epilepsyProtectionToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemArmet_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            // 
            // saveSettingsToNESMiniNowToolStripMenuItem
            // 
            resources.ApplyResources(this.saveSettingsToNESMiniNowToolStripMenuItem, "saveSettingsToNESMiniNowToolStripMenuItem");
            this.saveSettingsToNESMiniNowToolStripMenuItem.Name = "saveSettingsToNESMiniNowToolStripMenuItem";
            this.saveSettingsToNESMiniNowToolStripMenuItem.Click += new System.EventHandler(this.saveSettingsToNESMiniNowToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveStateManagerToolStripMenuItem,
            this.takeScreenshotToolStripMenuItem,
            this.toolStripMenuItem6,
            this.openFTPInExplorerToolStripMenuItem,
            this.openTelnetToolStripMenuItem,
            this.toolStripMenuItem8,
            this.bootImageToolStripMenuItem,
            this.rebootToolStripMenuItem,
            this.switchRunningFirmwareToolStripMenuItem,
            this.toolStripMenuItem18,
            this.prepareArtDirectoryToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // saveStateManagerToolStripMenuItem
            // 
            this.saveStateManagerToolStripMenuItem.Name = "saveStateManagerToolStripMenuItem";
            resources.ApplyResources(this.saveStateManagerToolStripMenuItem, "saveStateManagerToolStripMenuItem");
            this.saveStateManagerToolStripMenuItem.Click += new System.EventHandler(this.saveStateManagerToolStripMenuItem_Click);
            // 
            // takeScreenshotToolStripMenuItem
            // 
            this.takeScreenshotToolStripMenuItem.Name = "takeScreenshotToolStripMenuItem";
            resources.ApplyResources(this.takeScreenshotToolStripMenuItem, "takeScreenshotToolStripMenuItem");
            this.takeScreenshotToolStripMenuItem.Click += new System.EventHandler(this.takeScreenshotToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            // 
            // openFTPInExplorerToolStripMenuItem
            // 
            resources.ApplyResources(this.openFTPInExplorerToolStripMenuItem, "openFTPInExplorerToolStripMenuItem");
            this.openFTPInExplorerToolStripMenuItem.Name = "openFTPInExplorerToolStripMenuItem";
            this.openFTPInExplorerToolStripMenuItem.Click += new System.EventHandler(this.openFTPInExplorerToolStripMenuItem_Click);
            // 
            // openTelnetToolStripMenuItem
            // 
            resources.ApplyResources(this.openTelnetToolStripMenuItem, "openTelnetToolStripMenuItem");
            this.openTelnetToolStripMenuItem.Name = "openTelnetToolStripMenuItem";
            this.openTelnetToolStripMenuItem.Click += new System.EventHandler(this.openTelnetToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            resources.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
            // 
            // bootImageToolStripMenuItem
            // 
            this.bootImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBootImageToolStripMenuItem,
            this.disableBootImageToolStripMenuItem,
            this.resetDefaultBootImageToolStripMenuItem});
            this.bootImageToolStripMenuItem.Name = "bootImageToolStripMenuItem";
            resources.ApplyResources(this.bootImageToolStripMenuItem, "bootImageToolStripMenuItem");
            // 
            // changeBootImageToolStripMenuItem
            // 
            this.changeBootImageToolStripMenuItem.Name = "changeBootImageToolStripMenuItem";
            resources.ApplyResources(this.changeBootImageToolStripMenuItem, "changeBootImageToolStripMenuItem");
            this.changeBootImageToolStripMenuItem.Click += new System.EventHandler(this.changeBootImageToolStripMenuItem_Click);
            // 
            // disableBootImageToolStripMenuItem
            // 
            this.disableBootImageToolStripMenuItem.Name = "disableBootImageToolStripMenuItem";
            resources.ApplyResources(this.disableBootImageToolStripMenuItem, "disableBootImageToolStripMenuItem");
            this.disableBootImageToolStripMenuItem.Click += new System.EventHandler(this.disableBootImageToolStripMenuItem_Click);
            // 
            // resetDefaultBootImageToolStripMenuItem
            // 
            this.resetDefaultBootImageToolStripMenuItem.Name = "resetDefaultBootImageToolStripMenuItem";
            resources.ApplyResources(this.resetDefaultBootImageToolStripMenuItem, "resetDefaultBootImageToolStripMenuItem");
            this.resetDefaultBootImageToolStripMenuItem.Click += new System.EventHandler(this.resetDefaultBootImageToolStripMenuItem_Click);
            // 
            // rebootToolStripMenuItem
            // 
            this.rebootToolStripMenuItem.Name = "rebootToolStripMenuItem";
            resources.ApplyResources(this.rebootToolStripMenuItem, "rebootToolStripMenuItem");
            this.rebootToolStripMenuItem.Click += new System.EventHandler(this.rebootToolStripMenuItem_Click);
            // 
            // switchRunningFirmwareToolStripMenuItem
            // 
            this.switchRunningFirmwareToolStripMenuItem.Name = "switchRunningFirmwareToolStripMenuItem";
            resources.ApplyResources(this.switchRunningFirmwareToolStripMenuItem, "switchRunningFirmwareToolStripMenuItem");
            this.switchRunningFirmwareToolStripMenuItem.Click += new System.EventHandler(this.switchRunningFirmwareToolStripMenuItem_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            resources.ApplyResources(this.toolStripMenuItem18, "toolStripMenuItem18");
            // 
            // prepareArtDirectoryToolStripMenuItem
            // 
            this.prepareArtDirectoryToolStripMenuItem.Image = global::com.clusterrr.hakchi_gui.Properties.Resources.folder_sm;
            this.prepareArtDirectoryToolStripMenuItem.Name = "prepareArtDirectoryToolStripMenuItem";
            resources.ApplyResources(this.prepareArtDirectoryToolStripMenuItem, "prepareArtDirectoryToolStripMenuItem");
            this.prepareArtDirectoryToolStripMenuItem.Click += new System.EventHandler(this.prepareArtDirectoryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubPageWithActualReleasesToolStripMenuItem,
            this.fAQToolStripMenuItem,
            this.messageOfTheDayToolStripMenuItem,
            this.donateToolStripMenuItem,
            this.toolStripMenuItem22,
            this.technicalInformationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // gitHubPageWithActualReleasesToolStripMenuItem
            // 
            this.gitHubPageWithActualReleasesToolStripMenuItem.Name = "gitHubPageWithActualReleasesToolStripMenuItem";
            resources.ApplyResources(this.gitHubPageWithActualReleasesToolStripMenuItem, "gitHubPageWithActualReleasesToolStripMenuItem");
            this.gitHubPageWithActualReleasesToolStripMenuItem.Click += new System.EventHandler(this.gitHubPageWithActualReleasesToolStripMenuItem_Click);
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            resources.ApplyResources(this.fAQToolStripMenuItem, "fAQToolStripMenuItem");
            this.fAQToolStripMenuItem.Click += new System.EventHandler(this.fAQToolStripMenuItem_Click);
            // 
            // messageOfTheDayToolStripMenuItem
            // 
            this.messageOfTheDayToolStripMenuItem.Name = "messageOfTheDayToolStripMenuItem";
            resources.ApplyResources(this.messageOfTheDayToolStripMenuItem, "messageOfTheDayToolStripMenuItem");
            this.messageOfTheDayToolStripMenuItem.Click += new System.EventHandler(this.messageOfTheDayToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            resources.ApplyResources(this.donateToolStripMenuItem, "donateToolStripMenuItem");
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            resources.ApplyResources(this.toolStripMenuItem22, "toolStripMenuItem22");
            // 
            // technicalInformationToolStripMenuItem
            // 
            this.technicalInformationToolStripMenuItem.Name = "technicalInformationToolStripMenuItem";
            resources.ApplyResources(this.technicalInformationToolStripMenuItem, "technicalInformationToolStripMenuItem");
            this.technicalInformationToolStripMenuItem.Click += new System.EventHandler(this.technicalInformationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // buttonAddGames
            // 
            resources.ApplyResources(this.buttonAddGames, "buttonAddGames");
            this.buttonAddGames.Name = "buttonAddGames";
            this.buttonAddGames.UseVisualStyleBackColor = true;
            this.buttonAddGames.Click += new System.EventHandler(this.buttonAddGames_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusConnectionIcon,
            this.toolStripStatusLabelShell,
            this.toolStripStatusLabelSelected,
            this.toolStripStatusLabelSize,
            this.toolStripProgressBar});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.SizingGrip = false;
            // 
            // toolStripStatusConnectionIcon
            // 
            resources.ApplyResources(this.toolStripStatusConnectionIcon, "toolStripStatusConnectionIcon");
            this.toolStripStatusConnectionIcon.Image = global::com.clusterrr.hakchi_gui.Properties.Resources.red;
            this.toolStripStatusConnectionIcon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.toolStripStatusConnectionIcon.Name = "toolStripStatusConnectionIcon";
            // 
            // toolStripStatusLabelShell
            // 
            resources.ApplyResources(this.toolStripStatusLabelShell, "toolStripStatusLabelShell");
            this.toolStripStatusLabelShell.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelShell.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolStripStatusLabelShell.Name = "toolStripStatusLabelShell";
            // 
            // toolStripStatusLabelSelected
            // 
            resources.ApplyResources(this.toolStripStatusLabelSelected, "toolStripStatusLabelSelected");
            this.toolStripStatusLabelSelected.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelSelected.Name = "toolStripStatusLabelSelected";
            // 
            // toolStripStatusLabelSize
            // 
            resources.ApplyResources(this.toolStripStatusLabelSize, "toolStripStatusLabelSize");
            this.toolStripStatusLabelSize.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelSize.Name = "toolStripStatusLabelSize";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            resources.ApplyResources(this.toolStripProgressBar, "toolStripProgressBar");
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.toolStripProgressBar.Value = 50;
            // 
            // openFileDialogNes
            // 
            this.openFileDialogNes.DefaultExt = "nes";
            this.openFileDialogNes.Multiselect = true;
            resources.ApplyResources(this.openFileDialogNes, "openFileDialogNes");
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.explorerToolStripMenuItem,
            this.toolStripMenuItem14,
            this.scanForNewBoxArtForSelectedGamesToolStripMenuItem,
            this.downloadBoxArtForSelectedGamesToolStripMenuItem,
            this.deleteSelectedGamesBoxArtToolStripMenuItem,
            this.toolStripMenuItem15,
            this.archiveSelectedGamesToolStripMenuItem,
            this.compressSelectedGamesToolStripMenuItem,
            this.decompressSelectedGamesToolStripMenuItem,
            this.deleteSelectedGamesToolStripMenuItem,
            this.toolStripMenuItem17,
            this.sFROMToolToolStripMenuItem1,
            this.repairGamesToolStripMenuItem,
            this.toolStripMenuItem19,
            this.selectEmulationCoreToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            // 
            // explorerToolStripMenuItem
            // 
            resources.ApplyResources(this.explorerToolStripMenuItem, "explorerToolStripMenuItem");
            this.explorerToolStripMenuItem.Name = "explorerToolStripMenuItem";
            this.explorerToolStripMenuItem.Click += new System.EventHandler(this.explorerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            resources.ApplyResources(this.toolStripMenuItem14, "toolStripMenuItem14");
            // 
            // scanForNewBoxArtForSelectedGamesToolStripMenuItem
            // 
            resources.ApplyResources(this.scanForNewBoxArtForSelectedGamesToolStripMenuItem, "scanForNewBoxArtForSelectedGamesToolStripMenuItem");
            this.scanForNewBoxArtForSelectedGamesToolStripMenuItem.Name = "scanForNewBoxArtForSelectedGamesToolStripMenuItem";
            this.scanForNewBoxArtForSelectedGamesToolStripMenuItem.Click += new System.EventHandler(this.scanForNewBoxArtForSelectedGamesToolStripMenuItem_Click);
            // 
            // downloadBoxArtForSelectedGamesToolStripMenuItem
            // 
            resources.ApplyResources(this.downloadBoxArtForSelectedGamesToolStripMenuItem, "downloadBoxArtForSelectedGamesToolStripMenuItem");
            this.downloadBoxArtForSelectedGamesToolStripMenuItem.Name = "downloadBoxArtForSelectedGamesToolStripMenuItem";
            this.downloadBoxArtForSelectedGamesToolStripMenuItem.Click += new System.EventHandler(this.downloadBoxArtForSelectedGamesToolStripMenuItem_Click);
            // 
            // deleteSelectedGamesBoxArtToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteSelectedGamesBoxArtToolStripMenuItem, "deleteSelectedGamesBoxArtToolStripMenuItem");
            this.deleteSelectedGamesBoxArtToolStripMenuItem.Name = "deleteSelectedGamesBoxArtToolStripMenuItem";
            this.deleteSelectedGamesBoxArtToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedGamesBoxArtToolStripMenuItem_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            resources.ApplyResources(this.toolStripMenuItem15, "toolStripMenuItem15");
            // 
            // archiveSelectedGamesToolStripMenuItem
            // 
            resources.ApplyResources(this.archiveSelectedGamesToolStripMenuItem, "archiveSelectedGamesToolStripMenuItem");
            this.archiveSelectedGamesToolStripMenuItem.Name = "archiveSelectedGamesToolStripMenuItem";
            this.archiveSelectedGamesToolStripMenuItem.Click += new System.EventHandler(this.archiveSelectedGamesToolStripMenuItem_Click);
            // 
            // compressSelectedGamesToolStripMenuItem
            // 
            resources.ApplyResources(this.compressSelectedGamesToolStripMenuItem, "compressSelectedGamesToolStripMenuItem");
            this.compressSelectedGamesToolStripMenuItem.Name = "compressSelectedGamesToolStripMenuItem";
            this.compressSelectedGamesToolStripMenuItem.Click += new System.EventHandler(this.compressSelectedGamesToolStripMenuItem_Click);
            // 
            // decompressSelectedGamesToolStripMenuItem
            // 
            resources.ApplyResources(this.decompressSelectedGamesToolStripMenuItem, "decompressSelectedGamesToolStripMenuItem");
            this.decompressSelectedGamesToolStripMenuItem.Name = "decompressSelectedGamesToolStripMenuItem";
            this.decompressSelectedGamesToolStripMenuItem.Click += new System.EventHandler(this.decompressSelectedGamesToolStripMenuItem_Click);
            // 
            // deleteSelectedGamesToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteSelectedGamesToolStripMenuItem, "deleteSelectedGamesToolStripMenuItem");
            this.deleteSelectedGamesToolStripMenuItem.Name = "deleteSelectedGamesToolStripMenuItem";
            this.deleteSelectedGamesToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedGamesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            resources.ApplyResources(this.toolStripMenuItem17, "toolStripMenuItem17");
            // 
            // sFROMToolToolStripMenuItem1
            // 
            this.sFROMToolToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editROMHeaderToolStripMenuItem,
            this.toolStripMenuItem9,
            this.resetROMHeaderToolStripMenuItem});
            this.sFROMToolToolStripMenuItem1.Name = "sFROMToolToolStripMenuItem1";
            resources.ApplyResources(this.sFROMToolToolStripMenuItem1, "sFROMToolToolStripMenuItem1");
            // 
            // editROMHeaderToolStripMenuItem
            // 
            this.editROMHeaderToolStripMenuItem.Name = "editROMHeaderToolStripMenuItem";
            resources.ApplyResources(this.editROMHeaderToolStripMenuItem, "editROMHeaderToolStripMenuItem");
            this.editROMHeaderToolStripMenuItem.Click += new System.EventHandler(this.editROMHeaderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            resources.ApplyResources(this.toolStripMenuItem9, "toolStripMenuItem9");
            // 
            // resetROMHeaderToolStripMenuItem
            // 
            this.resetROMHeaderToolStripMenuItem.Name = "resetROMHeaderToolStripMenuItem";
            resources.ApplyResources(this.resetROMHeaderToolStripMenuItem, "resetROMHeaderToolStripMenuItem");
            this.resetROMHeaderToolStripMenuItem.Click += new System.EventHandler(this.resetROMHeaderToolStripMenuItem_Click);
            // 
            // repairGamesToolStripMenuItem
            // 
            this.repairGamesToolStripMenuItem.Name = "repairGamesToolStripMenuItem";
            resources.ApplyResources(this.repairGamesToolStripMenuItem, "repairGamesToolStripMenuItem");
            this.repairGamesToolStripMenuItem.Click += new System.EventHandler(this.repairGamesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            resources.ApplyResources(this.toolStripMenuItem19, "toolStripMenuItem19");
            // 
            // selectEmulationCoreToolStripMenuItem
            // 
            this.selectEmulationCoreToolStripMenuItem.Name = "selectEmulationCoreToolStripMenuItem";
            resources.ApplyResources(this.selectEmulationCoreToolStripMenuItem, "selectEmulationCoreToolStripMenuItem");
            this.selectEmulationCoreToolStripMenuItem.Click += new System.EventHandler(this.selectEmulationCoreToolStripMenuItem_Click);
            // 
            // openFileDialogImage
            // 
            resources.ApplyResources(this.openFileDialogImage, "openFileDialogImage");
            // 
            // buttonStart
            // 
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerCalculateGames
            // 
            this.timerCalculateGames.Interval = 500;
            this.timerCalculateGames.Tick += new System.EventHandler(this.timerCalculateGames_Tick);
            // 
            // timerConnectionCheck
            // 
            this.timerConnectionCheck.Interval = 500;
            this.timerConnectionCheck.Tick += new System.EventHandler(this.timerConnectionCheck_Tick);
            // 
            // saveDumpFileDialog
            // 
            this.saveDumpFileDialog.DefaultExt = "bin";
            this.saveDumpFileDialog.FileName = "nand.bin";
            resources.ApplyResources(this.saveDumpFileDialog, "saveDumpFileDialog");
            // 
            // openDumpFileDialog
            // 
            this.openDumpFileDialog.FileName = "...";
            resources.ApplyResources(this.openDumpFileDialog, "openDumpFileDialog");
            // 
            // listViewGames
            // 
            this.listViewGames.CheckBoxes = true;
            this.listViewGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gameName});
            this.listViewGames.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewGames.HideSelection = false;
            resources.ApplyResources(this.listViewGames, "listViewGames");
            this.listViewGames.Name = "listViewGames";
            this.listViewGames.UseCompatibleStateImageBehavior = false;
            this.listViewGames.View = System.Windows.Forms.View.Details;
            this.listViewGames.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listViewGames_ItemCheck);
            this.listViewGames.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewGames_ItemSelectionChanged);
            this.listViewGames.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewGames_KeyDown);
            this.listViewGames.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewGames_MouseDown);
            // 
            // gameName
            // 
            resources.ApplyResources(this.gameName, "gameName");
            // 
            // timerShowSelected
            // 
            this.timerShowSelected.Interval = 50;
            this.timerShowSelected.Tick += new System.EventHandler(this.timerShowSelected_Tick);
            // 
            // buttonExport
            // 
            resources.ApplyResources(this.buttonExport, "buttonExport");
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // labelID
            // 
            resources.ApplyResources(this.labelID, "labelID");
            this.labelID.Name = "labelID";
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.Name = "labelName";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.textBoxName, "textBoxName");
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // radioButtonOne
            // 
            resources.ApplyResources(this.radioButtonOne, "radioButtonOne");
            this.radioButtonOne.Checked = true;
            this.radioButtonOne.Name = "radioButtonOne";
            this.radioButtonOne.TabStop = true;
            this.radioButtonOne.UseVisualStyleBackColor = true;
            this.radioButtonOne.CheckedChanged += new System.EventHandler(this.radioButtonOne_CheckedChanged);
            // 
            // radioButtonTwo
            // 
            resources.ApplyResources(this.radioButtonTwo, "radioButtonTwo");
            this.radioButtonTwo.Name = "radioButtonTwo";
            this.radioButtonTwo.TabStop = true;
            this.radioButtonTwo.UseVisualStyleBackColor = true;
            this.radioButtonTwo.CheckedChanged += new System.EventHandler(this.radioButtonOne_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.textBoxPublisher, "textBoxPublisher");
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.TextChanged += new System.EventHandler(this.textBoxPublisher_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxArguments
            // 
            this.textBoxArguments.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.textBoxArguments, "textBoxArguments");
            this.textBoxArguments.Name = "textBoxArguments";
            this.textBoxArguments.TextChanged += new System.EventHandler(this.textBoxArguments_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // pictureBoxArt
            // 
            this.pictureBoxArt.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.pictureBoxArt, "pictureBoxArt");
            this.pictureBoxArt.Name = "pictureBoxArt";
            this.pictureBoxArt.TabStop = false;
            this.pictureBoxArt.Click += new System.EventHandler(this.buttonBrowseImage_Click);
            // 
            // buttonBrowseImage
            // 
            resources.ApplyResources(this.buttonBrowseImage, "buttonBrowseImage");
            this.buttonBrowseImage.Name = "buttonBrowseImage";
            this.buttonBrowseImage.UseVisualStyleBackColor = true;
            this.buttonBrowseImage.Click += new System.EventHandler(this.buttonBrowseImage_Click);
            // 
            // buttonGoogle
            // 
            resources.ApplyResources(this.buttonGoogle, "buttonGoogle");
            this.buttonGoogle.Name = "buttonGoogle";
            this.buttonGoogle.UseVisualStyleBackColor = true;
            this.buttonGoogle.Click += new System.EventHandler(this.buttonGoogle_Click);
            // 
            // radioButtonTwoSim
            // 
            resources.ApplyResources(this.radioButtonTwoSim, "radioButtonTwoSim");
            this.radioButtonTwoSim.Name = "radioButtonTwoSim";
            this.radioButtonTwoSim.TabStop = true;
            this.radioButtonTwoSim.UseVisualStyleBackColor = true;
            this.radioButtonTwoSim.CheckedChanged += new System.EventHandler(this.radioButtonOne_CheckedChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // textBoxGameGenie
            // 
            this.textBoxGameGenie.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.textBoxGameGenie, "textBoxGameGenie");
            this.textBoxGameGenie.Name = "textBoxGameGenie";
            this.textBoxGameGenie.TextChanged += new System.EventHandler(this.textBoxGameGenie_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // maskedTextBoxReleaseDate
            // 
            this.maskedTextBoxReleaseDate.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.maskedTextBoxReleaseDate, "maskedTextBoxReleaseDate");
            this.maskedTextBoxReleaseDate.Name = "maskedTextBoxReleaseDate";
            this.maskedTextBoxReleaseDate.TextChanged += new System.EventHandler(this.maskedTextBoxReleaseDate_TextChanged);
            // 
            // buttonShowGameGenieDatabase
            // 
            resources.ApplyResources(this.buttonShowGameGenieDatabase, "buttonShowGameGenieDatabase");
            this.buttonShowGameGenieDatabase.Name = "buttonShowGameGenieDatabase";
            this.buttonShowGameGenieDatabase.UseVisualStyleBackColor = true;
            this.buttonShowGameGenieDatabase.Click += new System.EventHandler(this.buttonShowGameGenieDatabase_Click);
            // 
            // checkBoxCompressed
            // 
            resources.ApplyResources(this.checkBoxCompressed, "checkBoxCompressed");
            this.checkBoxCompressed.Name = "checkBoxCompressed";
            this.checkBoxCompressed.UseVisualStyleBackColor = true;
            this.checkBoxCompressed.Click += new System.EventHandler(this.checkBoxCompressed_CheckedChanged);
            // 
            // labelSize
            // 
            resources.ApplyResources(this.labelSize, "labelSize");
            this.labelSize.Name = "labelSize";
            // 
            // buttonDefaultCover
            // 
            resources.ApplyResources(this.buttonDefaultCover, "buttonDefaultCover");
            this.buttonDefaultCover.Name = "buttonDefaultCover";
            this.buttonDefaultCover.UseVisualStyleBackColor = true;
            this.buttonDefaultCover.Click += new System.EventHandler(this.buttonDefaultCover_Click);
            // 
            // pictureBoxThumbnail
            // 
            this.pictureBoxThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBoxThumbnail, "pictureBoxThumbnail");
            this.pictureBoxThumbnail.Name = "pictureBoxThumbnail";
            this.pictureBoxThumbnail.TabStop = false;
            this.pictureBoxThumbnail.Click += new System.EventHandler(this.pictureBoxThumbnail_Click);
            // 
            // labelSortName
            // 
            resources.ApplyResources(this.labelSortName, "labelSortName");
            this.labelSortName.Name = "labelSortName";
            // 
            // textBoxSortName
            // 
            this.textBoxSortName.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.textBoxSortName, "textBoxSortName");
            this.textBoxSortName.Name = "textBoxSortName";
            this.textBoxSortName.TextChanged += new System.EventHandler(this.textBoxSortName_TextChanged);
            this.textBoxSortName.Leave += new System.EventHandler(this.textBoxSortName_Leave);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // numericUpDownSaveCount
            // 
            this.numericUpDownSaveCount.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.numericUpDownSaveCount, "numericUpDownSaveCount");
            this.numericUpDownSaveCount.Name = "numericUpDownSaveCount";
            this.numericUpDownSaveCount.ValueChanged += new System.EventHandler(this.numericUpDownSaveCount_ValueChanged);
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.numericUpDownSaveCount);
            this.groupBoxOptions.Controls.Add(this.label8);
            this.groupBoxOptions.Controls.Add(this.textBoxSortName);
            this.groupBoxOptions.Controls.Add(this.labelSortName);
            this.groupBoxOptions.Controls.Add(this.pictureBoxThumbnail);
            this.groupBoxOptions.Controls.Add(this.buttonDefaultCover);
            this.groupBoxOptions.Controls.Add(this.labelSize);
            this.groupBoxOptions.Controls.Add(this.checkBoxCompressed);
            this.groupBoxOptions.Controls.Add(this.buttonShowGameGenieDatabase);
            this.groupBoxOptions.Controls.Add(this.maskedTextBoxReleaseDate);
            this.groupBoxOptions.Controls.Add(this.label1);
            this.groupBoxOptions.Controls.Add(this.textBoxGameGenie);
            this.groupBoxOptions.Controls.Add(this.label7);
            this.groupBoxOptions.Controls.Add(this.label6);
            this.groupBoxOptions.Controls.Add(this.radioButtonTwoSim);
            this.groupBoxOptions.Controls.Add(this.buttonGoogle);
            this.groupBoxOptions.Controls.Add(this.buttonBrowseImage);
            this.groupBoxOptions.Controls.Add(this.pictureBoxArt);
            this.groupBoxOptions.Controls.Add(this.label4);
            this.groupBoxOptions.Controls.Add(this.textBoxArguments);
            this.groupBoxOptions.Controls.Add(this.label3);
            this.groupBoxOptions.Controls.Add(this.textBoxPublisher);
            this.groupBoxOptions.Controls.Add(this.label2);
            this.groupBoxOptions.Controls.Add(this.radioButtonTwo);
            this.groupBoxOptions.Controls.Add(this.radioButtonOne);
            this.groupBoxOptions.Controls.Add(this.textBoxName);
            this.groupBoxOptions.Controls.Add(this.labelName);
            this.groupBoxOptions.Controls.Add(this.labelID);
            resources.ApplyResources(this.groupBoxOptions, "groupBoxOptions");
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.TabStop = false;
            // 
            // structureButton
            // 
            resources.ApplyResources(this.structureButton, "structureButton");
            this.structureButton.Name = "structureButton";
            this.structureButton.UseVisualStyleBackColor = true;
            this.structureButton.Click += new System.EventHandler(this.structureButton_Click);
            // 
            // foldersContextMenuStrip
            // 
            this.foldersContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disablePagefoldersToolStripMenuItem,
            this.customToolStripMenuItem,
            this.toolStripMenuItem3,
            this.automaticToolStripMenuItem,
            this.automaticOriginalToolStripMenuItem,
            this.pagesToolStripMenuItem,
            this.pagesOriginalToolStripMenuItem,
            this.foldersToolStripMenuItem,
            this.foldersOriginalToolStripMenuItem,
            this.foldersSplitByFirstLetterToolStripMenuItem,
            this.foldersSplitByFirstLetterOriginalToolStripMenuItem,
            this.toolStripMenuItem4,
            this.maximumGamesPerFolderToolStripMenuItem,
            this.backFolderButtonPositionToolStripMenuItem,
            this.folderImagesSetToolStripMenuItem,
            this.toolStripMenuItem20,
            this.syncStructureForAllGamesCollectionsToolStripMenuItem});
            this.foldersContextMenuStrip.Name = "foldersContextMenuStrip";
            resources.ApplyResources(this.foldersContextMenuStrip, "foldersContextMenuStrip");
            // 
            // disablePagefoldersToolStripMenuItem
            // 
            this.disablePagefoldersToolStripMenuItem.Name = "disablePagefoldersToolStripMenuItem";
            resources.ApplyResources(this.disablePagefoldersToolStripMenuItem, "disablePagefoldersToolStripMenuItem");
            this.disablePagefoldersToolStripMenuItem.Tag = "0";
            this.disablePagefoldersToolStripMenuItem.Click += new System.EventHandler(this.pagesModefoldersToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            resources.ApplyResources(this.customToolStripMenuItem, "customToolStripMenuItem");
            this.customToolStripMenuItem.Tag = "99";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.pagesModefoldersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // automaticToolStripMenuItem
            // 
            this.automaticToolStripMenuItem.Checked = true;
            this.automaticToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.automaticToolStripMenuItem.Name = "automaticToolStripMenuItem";
            resources.ApplyResources(this.automaticToolStripMenuItem, "automaticToolStripMenuItem");
            this.automaticToolStripMenuItem.Tag = "2";
            this.automaticToolStripMenuItem.Click += new System.EventHandler(this.pagesModefoldersToolStripMenuItem_Click);
            // 
            // automaticOriginalToolStripMenuItem
            // 
            this.automaticOriginalToolStripMenuItem.Name = "automaticOriginalToolStripMenuItem";
            resources.ApplyResources(this.automaticOriginalToolStripMenuItem, "automaticOriginalToolStripMenuItem");
            this.automaticOriginalToolStripMenuItem.Tag = "3";
            this.automaticOriginalToolStripMenuItem.Click += new System.EventHandler(this.pagesModefoldersToolStripMenuItem_Click);
            // 
            // pagesToolStripMenuItem
            // 
            resources.ApplyResources(this.pagesToolStripMenuItem, "pagesToolStripMenuItem");
            this.pagesToolStripMenuItem.Name = "pagesToolStripMenuItem";
            this.pagesToolStripMenuItem.Tag = "4";
            this.pagesToolStripMenuItem.Click += new System.EventHandler(this.pagesModefoldersToolStripMenuItem_Click);
            // 
            // pagesOriginalToolStripMenuItem
            // 
            resources.ApplyResources(this.pagesOriginalToolStripMenuItem, "pagesOriginalToolStripMenuItem");
            this.pagesOriginalToolStripMenuItem.Name = "pagesOriginalToolStripMenuItem";
            this.pagesOriginalToolStripMenuItem.Tag = "5";
            this.pagesOriginalToolStripMenuItem.Click += new System.EventHandler(this.pagesModefoldersToolStripMenuItem_Click);
            // 
            // foldersToolStripMenuItem
            // 
            this.foldersToolStripMenuItem.Name = "foldersToolStripMenuItem";
            resources.ApplyResources(this.foldersToolStripMenuItem, "foldersToolStripMenuItem");
            this.foldersToolStripMenuItem.Tag = "6";
            this.foldersToolStripMenuItem.Click += new System.EventHandler(this.pagesModefoldersToolStripMenuItem_Click);
            // 
            // foldersOriginalToolStripMenuItem
            // 
            this.foldersOriginalToolStripMenuItem.Name = "foldersOriginalToolStripMenuItem";
            resources.ApplyResources(this.foldersOriginalToolStripMenuItem, "foldersOriginalToolStripMenuItem");
            this.foldersOriginalToolStripMenuItem.Tag = "7";
            this.foldersOriginalToolStripMenuItem.Click += new System.EventHandler(this.pagesModefoldersToolStripMenuItem_Click);
            // 
            // foldersSplitByFirstLetterToolStripMenuItem
            // 
            this.foldersSplitByFirstLetterToolStripMenuItem.Name = "foldersSplitByFirstLetterToolStripMenuItem";
            resources.ApplyResources(this.foldersSplitByFirstLetterToolStripMenuItem, "foldersSplitByFirstLetterToolStripMenuItem");
            this.foldersSplitByFirstLetterToolStripMenuItem.Tag = "8";
            this.foldersSplitByFirstLetterToolStripMenuItem.Click += new System.EventHandler(this.pagesModefoldersToolStripMenuItem_Click);
            // 
            // foldersSplitByFirstLetterOriginalToolStripMenuItem
            // 
            this.foldersSplitByFirstLetterOriginalToolStripMenuItem.Name = "foldersSplitByFirstLetterOriginalToolStripMenuItem";
            resources.ApplyResources(this.foldersSplitByFirstLetterOriginalToolStripMenuItem, "foldersSplitByFirstLetterOriginalToolStripMenuItem");
            this.foldersSplitByFirstLetterOriginalToolStripMenuItem.Tag = "9";
            this.foldersSplitByFirstLetterOriginalToolStripMenuItem.Click += new System.EventHandler(this.pagesModefoldersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // maximumGamesPerFolderToolStripMenuItem
            // 
            this.maximumGamesPerFolderToolStripMenuItem.Name = "maximumGamesPerFolderToolStripMenuItem";
            resources.ApplyResources(this.maximumGamesPerFolderToolStripMenuItem, "maximumGamesPerFolderToolStripMenuItem");
            // 
            // backFolderButtonPositionToolStripMenuItem
            // 
            this.backFolderButtonPositionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftmostToolStripMenuItem,
            this.rightmostToolStripMenuItem});
            this.backFolderButtonPositionToolStripMenuItem.Name = "backFolderButtonPositionToolStripMenuItem";
            resources.ApplyResources(this.backFolderButtonPositionToolStripMenuItem, "backFolderButtonPositionToolStripMenuItem");
            // 
            // leftmostToolStripMenuItem
            // 
            this.leftmostToolStripMenuItem.Name = "leftmostToolStripMenuItem";
            resources.ApplyResources(this.leftmostToolStripMenuItem, "leftmostToolStripMenuItem");
            this.leftmostToolStripMenuItem.Click += new System.EventHandler(this.leftmostToolStripMenuItem_Click);
            // 
            // rightmostToolStripMenuItem
            // 
            this.rightmostToolStripMenuItem.Name = "rightmostToolStripMenuItem";
            resources.ApplyResources(this.rightmostToolStripMenuItem, "rightmostToolStripMenuItem");
            this.rightmostToolStripMenuItem.Click += new System.EventHandler(this.rightmostToolStripMenuItem_Click);
            // 
            // folderImagesSetToolStripMenuItem
            // 
            this.folderImagesSetToolStripMenuItem.Image = global::com.clusterrr.hakchi_gui.Properties.Resources.folder_sm;
            this.folderImagesSetToolStripMenuItem.Name = "folderImagesSetToolStripMenuItem";
            resources.ApplyResources(this.folderImagesSetToolStripMenuItem, "folderImagesSetToolStripMenuItem");
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            resources.ApplyResources(this.toolStripMenuItem20, "toolStripMenuItem20");
            // 
            // syncStructureForAllGamesCollectionsToolStripMenuItem
            // 
            resources.ApplyResources(this.syncStructureForAllGamesCollectionsToolStripMenuItem, "syncStructureForAllGamesCollectionsToolStripMenuItem");
            this.syncStructureForAllGamesCollectionsToolStripMenuItem.Name = "syncStructureForAllGamesCollectionsToolStripMenuItem";
            this.syncStructureForAllGamesCollectionsToolStripMenuItem.Click += new System.EventHandler(this.syncStructureForAllGamesCollectionsToolStripMenuItem_Click);
            // 
            // gamesConsoleComboBox
            // 
            this.gamesConsoleComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.gamesConsoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gamesConsoleComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.gamesConsoleComboBox, "gamesConsoleComboBox");
            this.gamesConsoleComboBox.Name = "gamesConsoleComboBox";
            this.gamesConsoleComboBox.SelectedIndexChanged += new System.EventHandler(this.gamesConsoleComboBox_SelectedIndexChanged);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // modRepoEndSeparator
            // 
            this.modRepoEndSeparator.Name = "modRepoEndSeparator";
            resources.ApplyResources(this.modRepoEndSeparator, "modRepoEndSeparator");
            // 
            // manageModRepositoriesToolStripMenuItem
            // 
            this.manageModRepositoriesToolStripMenuItem.Name = "manageModRepositoriesToolStripMenuItem";
            resources.ApplyResources(this.manageModRepositoriesToolStripMenuItem, "manageModRepositoriesToolStripMenuItem");
            this.manageModRepositoriesToolStripMenuItem.Click += new System.EventHandler(this.manageModRepositoriesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gamesConsoleComboBox);
            this.Controls.Add(this.structureButton);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonAddGames);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.listViewGames);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::com.clusterrr.hakchi_gui.Properties.Resources.icon;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaveCount)).EndInit();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.foldersContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMoreGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddGames;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSelected;
        private System.Windows.Forms.OpenFileDialog openFileDialogNes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ToolStripMenuItem kernelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flashCustomKernelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Timer timerCalculateGames;
        private System.Windows.Forms.ToolStripMenuItem uninstallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubPageWithActualReleasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem presetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPresetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePresetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem epilepsyProtectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloverconHackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetUsingCombinationOfButtonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectButtonCombinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableAutofireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalCommandLineArgumentsexpertsOnluToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upABStartOnSecondControllerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uninstallModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem synchronizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useXYOnClassicControllerAsAutofireABToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSize;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusConnectionIcon;
        private System.Windows.Forms.Timer timerConnectionCheck;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToNESMiniNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStateManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFTPInExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTelnetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem takeScreenshotToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveDumpFileDialog;
        private System.Windows.Forms.OpenFileDialog openDumpFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem compressGamesToolStripMenuItem;
        internal System.Windows.Forms.ListView listViewGames;
        private System.Windows.Forms.ColumnHeader gameName;
        private System.Windows.Forms.ToolStripMenuItem compressSelectedGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decompressSelectedGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadBoxArtForSelectedGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compressBoxArtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedGamesBoxArtToolStripMenuItem;
        private System.Windows.Forms.Timer timerShowSelected;
        private System.Windows.Forms.ToolStripMenuItem reloadGamesToolStripMenuItem;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem exportGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem scanForNewBoxArtForSelectedGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem disableHakchi2PopupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem resetOriginalGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionAtTheTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionAtTheBottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionSortedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem separateGamesForMultibootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sFROMToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableSFROMToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flashUbootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sDModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membootOriginalKernelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membootRecoveryKernelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem dumpTheWholeNANDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolFlashTheWholeNANDStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumpNANDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumpNANDCPartitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flashNANDCPartitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usePCMPatchWhenAvailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sFROMToolToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editROMHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem resetROMHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem17;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RadioButton radioButtonOne;
        private System.Windows.Forms.RadioButton radioButtonTwo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxArguments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxArt;
        private System.Windows.Forms.Button buttonBrowseImage;
        private System.Windows.Forms.Button buttonGoogle;
        private System.Windows.Forms.RadioButton radioButtonTwoSim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGameGenie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxReleaseDate;
        private System.Windows.Forms.Button buttonShowGameGenieDatabase;
        private System.Windows.Forms.CheckBox checkBoxCompressed;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonDefaultCover;
        private System.Windows.Forms.PictureBox pictureBoxThumbnail;
        private System.Windows.Forms.Label labelSortName;
        private System.Windows.Forms.TextBox textBoxSortName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownSaveCount;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.ToolStripMenuItem centerBoxArtThumbnailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionHiddenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectEmulationCoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useLinkedSyncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bootImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBootImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableBootImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetDefaultBootImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem prepareArtDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatNANDCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.Button structureButton;
        private System.Windows.Forms.ContextMenuStrip foldersContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem disablePagefoldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem automaticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automaticOriginalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagesOriginalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foldersOriginalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foldersSplitByFirstLetterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foldersSplitByFirstLetterOriginalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem maximumGamesPerFolderToolStripMenuItem;
        private System.Windows.Forms.ComboBox gamesConsoleComboBox;
        private System.Windows.Forms.ToolStripMenuItem kachikachiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canoeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retroarchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flashNANDBPartitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGamesWithoutBoxArtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devForceSshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem repairGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membootCustomKernelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadTotmpforTestingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderImagesSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem factoryResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backFolderButtonPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftmostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightmostToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem syncStructureForAllGamesCollectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator modRepoStartSeparator;
        private System.Windows.Forms.ToolStripMenuItem messageOfTheDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem22;
        private System.Windows.Forms.ToolStripMenuItem forceClovershellMembootsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem23;
        private System.Windows.Forms.ToolStripMenuItem technicalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumpOriginalKernellegacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem24;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelShell;
        private System.Windows.Forms.ToolStripMenuItem forceNetworkMembootsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysCopyOriginalGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem25;
        private System.Windows.Forms.ToolStripMenuItem convertSNESROMSToSFROMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem separateGamesStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autodetectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asIsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchRunningFirmwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem generateModulesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveSelectedGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator modRepoEndSeparator;
        private System.Windows.Forms.ToolStripMenuItem manageModRepositoriesToolStripMenuItem;
    }
}

