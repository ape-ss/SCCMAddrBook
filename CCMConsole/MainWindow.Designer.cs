﻿namespace CCMList
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusIpAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainList = new System.Windows.Forms.TreeView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolImages = new System.Windows.Forms.ImageList(this.components);
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.buttonNewFolder = new System.Windows.Forms.ToolStripButton();
            this.buttonNewNode = new System.Windows.Forms.ToolStripButton();
            this.buttonConnect = new System.Windows.Forms.ToolStripButton();
            this.buttonSaveList = new System.Windows.Forms.ToolStripButton();
            this.buttonOpenList = new System.Windows.Forms.ToolStripButton();
            this.buttonOptions = new System.Windows.Forms.ToolStripButton();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContainer.BottomToolStripPanel.SuspendLayout();
            this.mainContainer.ContentPanel.SuspendLayout();
            this.mainContainer.TopToolStripPanel.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            // 
            // mainContainer.BottomToolStripPanel
            // 
            this.mainContainer.BottomToolStripPanel.Controls.Add(this.statusBar);
            // 
            // mainContainer.ContentPanel
            // 
            this.mainContainer.ContentPanel.Controls.Add(this.mainList);
            resources.ApplyResources(this.mainContainer.ContentPanel, "mainContainer.ContentPanel");
            resources.ApplyResources(this.mainContainer, "mainContainer");
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.TopToolStripPanel
            // 
            this.mainContainer.TopToolStripPanel.Controls.Add(this.toolBar);
            // 
            // statusBar
            // 
            resources.ApplyResources(this.statusBar, "statusBar");
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusIpAddress});
            this.statusBar.Name = "statusBar";
            // 
            // statusIpAddress
            // 
            resources.ApplyResources(this.statusIpAddress, "statusIpAddress");
            this.statusIpAddress.Name = "statusIpAddress";
            // 
            // mainList
            // 
            this.mainList.ContextMenuStrip = this.contextMenu;
            resources.ApplyResources(this.mainList, "mainList");
            this.mainList.ImageList = this.toolImages;
            this.mainList.ItemHeight = 22;
            this.mainList.Name = "mainList";
            this.mainList.StateImageList = this.toolImages;
            this.mainList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.mainList_NodeMouseClick);
            this.mainList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.mainList_NodeMouseDoubleClick);
            this.mainList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainList_KeyPress);
            this.mainList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mainList_KeyUp);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editNodeToolStripMenuItem,
            this.deleteNodeToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            resources.ApplyResources(this.contextMenu, "contextMenu");
            // 
            // editNodeToolStripMenuItem
            // 
            this.editNodeToolStripMenuItem.Image = global::CCMList.Properties.Resources.computer__pencil;
            this.editNodeToolStripMenuItem.Name = "editNodeToolStripMenuItem";
            resources.ApplyResources(this.editNodeToolStripMenuItem, "editNodeToolStripMenuItem");
            this.editNodeToolStripMenuItem.Click += new System.EventHandler(this.editNodeToolStripMenuItem_Click);
            // 
            // deleteNodeToolStripMenuItem
            // 
            this.deleteNodeToolStripMenuItem.Image = global::CCMList.Properties.Resources.computer__minus;
            this.deleteNodeToolStripMenuItem.Name = "deleteNodeToolStripMenuItem";
            resources.ApplyResources(this.deleteNodeToolStripMenuItem, "deleteNodeToolStripMenuItem");
            this.deleteNodeToolStripMenuItem.Click += new System.EventHandler(this.deleteNodeToolStripMenuItem_Click);
            // 
            // toolImages
            // 
            this.toolImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toolImages.ImageStream")));
            this.toolImages.TransparentColor = System.Drawing.Color.Transparent;
            this.toolImages.Images.SetKeyName(0, "computer-network.png");
            this.toolImages.Images.SetKeyName(1, "document--plus.png");
            this.toolImages.Images.SetKeyName(2, "folder--plus.png");
            this.toolImages.Images.SetKeyName(3, "computer.png");
            this.toolImages.Images.SetKeyName(4, "folder.png");
            this.toolImages.Images.SetKeyName(5, "folder-open.png");
            this.toolImages.Images.SetKeyName(6, "folder-horizontal.png");
            this.toolImages.Images.SetKeyName(7, "folder-horizontal-open.png");
            // 
            // toolBar
            // 
            resources.ApplyResources(this.toolBar, "toolBar");
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonNewFolder,
            this.buttonNewNode,
            this.buttonConnect,
            this.buttonSaveList,
            this.buttonOpenList,
            this.buttonOptions});
            this.toolBar.Name = "toolBar";
            // 
            // buttonNewFolder
            // 
            this.buttonNewFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonNewFolder.Image = global::CCMList.Properties.Resources.folder__plus;
            resources.ApplyResources(this.buttonNewFolder, "buttonNewFolder");
            this.buttonNewFolder.Name = "buttonNewFolder";
            this.buttonNewFolder.Padding = new System.Windows.Forms.Padding(5);
            this.buttonNewFolder.Click += new System.EventHandler(this.buttonNewFolder_Click);
            // 
            // buttonNewNode
            // 
            this.buttonNewNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonNewNode.Image = global::CCMList.Properties.Resources.computer__plus;
            resources.ApplyResources(this.buttonNewNode, "buttonNewNode");
            this.buttonNewNode.Name = "buttonNewNode";
            this.buttonNewNode.Padding = new System.Windows.Forms.Padding(5);
            this.buttonNewNode.Click += new System.EventHandler(this.buttonNewNode_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonConnect.Image = global::CCMList.Properties.Resources.computer_network;
            resources.ApplyResources(this.buttonConnect, "buttonConnect");
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Padding = new System.Windows.Forms.Padding(5);
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonSaveList
            // 
            this.buttonSaveList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSaveList.Image = global::CCMList.Properties.Resources.folder_export;
            resources.ApplyResources(this.buttonSaveList, "buttonSaveList");
            this.buttonSaveList.Name = "buttonSaveList";
            this.buttonSaveList.Padding = new System.Windows.Forms.Padding(5);
            this.buttonSaveList.Click += new System.EventHandler(this.buttonSaveList_Click);
            // 
            // buttonOpenList
            // 
            this.buttonOpenList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonOpenList.Image = global::CCMList.Properties.Resources.folder_import;
            resources.ApplyResources(this.buttonOpenList, "buttonOpenList");
            this.buttonOpenList.Name = "buttonOpenList";
            this.buttonOpenList.Padding = new System.Windows.Forms.Padding(5);
            this.buttonOpenList.Click += new System.EventHandler(this.buttonOpenList_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonOptions.Image = global::CCMList.Properties.Resources.wrench_screwdriver;
            resources.ApplyResources(this.buttonOptions, "buttonOptions");
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Padding = new System.Windows.Forms.Padding(5);
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
            resources.ApplyResources(this.openDialog, "openDialog");
            // 
            // saveDialog
            // 
            resources.ApplyResources(this.saveDialog, "saveDialog");
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            resources.ApplyResources(this.trayIcon, "trayIcon");
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.trayMenu.Name = "trayMenu";
            resources.ApplyResources(this.trayMenu, "trayMenu");
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            resources.ApplyResources(this.restoreToolStripMenuItem, "restoreToolStripMenuItem");
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
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
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.mainContainer.BottomToolStripPanel.ResumeLayout(false);
            this.mainContainer.BottomToolStripPanel.PerformLayout();
            this.mainContainer.ContentPanel.ResumeLayout(false);
            this.mainContainer.TopToolStripPanel.ResumeLayout(false);
            this.mainContainer.TopToolStripPanel.PerformLayout();
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer mainContainer;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.TreeView mainList;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ImageList toolImages;
        private System.Windows.Forms.ToolStripButton buttonNewNode;
        private System.Windows.Forms.ToolStripButton buttonNewFolder;
        private System.Windows.Forms.ToolStripButton buttonConnect;
        private System.Windows.Forms.ToolStripStatusLabel statusIpAddress;
        private System.Windows.Forms.ToolStripButton buttonSaveList;
        private System.Windows.Forms.ToolStripButton buttonOpenList;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.ToolStripButton buttonOptions;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem editNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteNodeToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}
