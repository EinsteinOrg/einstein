using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using System.Globalization;
using Einstein.Data;
using Einstein.Data.DAL;

namespace Einstein.Platform
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : DevComponents.DotNetBar.RibbonForm
    {
        #region Private Vars
        private System.Windows.Forms.MdiClient mdiClient1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevComponents.DotNetBar.TabStrip tabStrip1;
        private System.ComponentModel.IContainer components;
        private BalloonSearch m_Search = null;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.LabelItem labelStatus;
        internal DevComponents.DotNetBar.LabelItem labelPosition;
        private DevComponents.DotNetBar.RibbonControl mainRibbonControl;
        private DevComponents.DotNetBar.ButtonItem buttonSave;
        private DevComponents.DotNetBar.ButtonItem buttonUndo;
        private DevComponents.DotNetBar.ButtonItem buttonNew;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.Editors.ComboItem comboItem8;
        private DevComponents.Editors.ComboItem comboItem9;
        private DevComponents.DotNetBar.RibbonTabItemGroup ribbonTabItemGroup1;
        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        private DevComponents.DotNetBar.ButtonItem buttonItem20;
        private DevComponents.DotNetBar.ButtonItem buttonItem21;
        private DevComponents.DotNetBar.ButtonItem buttonItem23;
        private DevComponents.DotNetBar.ButtonItem buttonItem24;
        private DevComponents.DotNetBar.ButtonItem buttonItem25;
        private DevComponents.DotNetBar.LabelItem labelItem8;
        private DevComponents.DotNetBar.ButtonItem buttonItem26;
        private DevComponents.DotNetBar.ButtonItem buttonItem27;
        private DevComponents.DotNetBar.ButtonItem buttonItem28;
        private DevComponents.DotNetBar.ButtonItem buttonItem29;
        private DevComponents.DotNetBar.ButtonItem buttonFileSaveAs;
        private DevComponents.DotNetBar.ItemContainer menuFileContainer;
        private DevComponents.DotNetBar.ItemContainer menuFileTwoColumnContainer;
        private DevComponents.DotNetBar.ItemContainer menuFileItems;
        private DevComponents.DotNetBar.ItemContainer menuFileMRU;
        private DevComponents.DotNetBar.ItemContainer menuFileBottomContainer;
        private DevComponents.DotNetBar.ButtonItem buttonOptions;
        private DevComponents.DotNetBar.ButtonItem buttonExit;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar;
        private DevComponents.DotNetBar.ButtonItem bEditPopup;
        private DevComponents.DotNetBar.ButtonItem bCut;
        private DevComponents.DotNetBar.ButtonItem bCopy;
        private DevComponents.DotNetBar.ButtonItem bPaste;
        private DevComponents.DotNetBar.ButtonItem bSelectAll;
        private DevComponents.DotNetBar.ButtonItem buttonItem47;
        private DevComponents.DotNetBar.ButtonItem buttonItem48;
        private DevComponents.DotNetBar.ButtonItem buttonItem49;
        private System.Windows.Forms.Timer progressBarTimer;
        private DevComponents.DotNetBar.ProgressBarItem progressBarItem1;
        private DevComponents.DotNetBar.ItemContainer itemContainer12;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem56;
        private DevComponents.DotNetBar.ButtonItem buttonItem57;
        private DevComponents.DotNetBar.ButtonItem buttonItem58;
        private DevComponents.DotNetBar.ButtonItem buttonItem59;
        private DevComponents.DotNetBar.ItemContainer itemContainer13;
        private Command AppCommandNew;
        private Command AppCommandOpen;
        private Command AppCommandSave;
        private Command AppCommandSaveAs;
        private Command AppCommandTheme;
        private Command AppCommandExit;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private SuperTabControl superTabControl1;
        private SuperTabControlPanel superTabControlPanel1;
        private SuperTabItem superTabItem1;
        private SuperTabControlPanel superTabControlPanel4;
        private SuperTabItem superTabItem4;
        private SuperTabControlPanel superTabControlPanel3;
        private SuperTabItem superTabItem3;
        private SuperTabControlPanel superTabControlPanel2;
        private SuperTabItem superTabItem2;
        private ButtonItem buttonItem61;
        private ButtonItem buttonItem63;
        private ButtonItem buttonItem64;
        private ButtonItem buttonItem65;
        private ButtonItem buttonItem66;
        private PanelEx panelEx1;
        private LabelX labelX1;
        private PanelEx panelEx2;
        private LabelX labelX2;
        private ItemPanel recentDocsItemPane;
        private ItemPanel recentPlacesItemsPanel;
        private LabelX labelX3;
        private ItemPanel itemPanel1;
        private ButtonItem buttonItem67;
        private ButtonItem buttonItem68;
        private ButtonItem buttonItem69;
        private ButtonItem buttonItem70;
        private ButtonItem buttonItem71;
        private ButtonItem buttonItem72;
        private LabelX labelX4;
        private ButtonX buttonX1;
        private PanelEx panelEx3;
        private LabelX labelX5;
        private DevComponents.Editors.IntegerInput integerInput1;
        private ItemPanel itemPanel2;
        private LabelX labelX6;
        private ButtonItem buttonItem73;
        private ButtonItem buttonItem74;
        private ButtonItem buttonItem75;
        private Command AppCommandGoToUrl;
        private ButtonItem buttonItem76;
        private ButtonItem buttonItem77;
        private SwitchButtonItem switchMenuButtonItem;
        private Command RibbonStateCommand;
        private ButtonItem buttonStyleMetro;
        private QatCustomizeItem qatCustomizeItem1;
        private SwitchButtonItem switchButtonItem1;
        private ImageList imageList1;
        private DevComponents.DotNetBar.Office2007StartButton buttonFile;
        #endregion

        #region Constructor/Dispose
        public frmMain()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //CreateMenus();
            Navigations nav = new Navigations(this.mainRibbonControl, new System.ComponentModel.ComponentResourceManager(typeof(Einstein.Platform.frmMain)),this.imageList1);
            nav.Creat();
           
            SetupBackstageContent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mdiClient1 = new System.Windows.Forms.MdiClient();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabStrip1 = new DevComponents.DotNetBar.TabStrip();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.labelStatus = new DevComponents.DotNetBar.LabelItem();
            this.progressBarItem1 = new DevComponents.DotNetBar.ProgressBarItem();
            this.itemContainer13 = new DevComponents.DotNetBar.ItemContainer();
            this.labelPosition = new DevComponents.DotNetBar.LabelItem();
            this.mainRibbonControl = new DevComponents.DotNetBar.RibbonControl();
            this.contextMenuBar = new DevComponents.DotNetBar.ContextMenuBar();
            this.bEditPopup = new DevComponents.DotNetBar.ButtonItem();
            this.bCut = new DevComponents.DotNetBar.ButtonItem();
            this.bCopy = new DevComponents.DotNetBar.ButtonItem();
            this.bPaste = new DevComponents.DotNetBar.ButtonItem();
            this.bSelectAll = new DevComponents.DotNetBar.ButtonItem();
            this.switchButtonItem1 = new DevComponents.DotNetBar.SwitchButtonItem();
            this.RibbonStateCommand = new DevComponents.DotNetBar.Command(this.components);
            this.buttonFile = new DevComponents.DotNetBar.Office2007StartButton();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.recentPlacesItemsPanel = new DevComponents.DotNetBar.ItemPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.recentDocsItemPane = new DevComponents.DotNetBar.ItemPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItem67 = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandNew = new DevComponents.DotNetBar.Command(this.components);
            this.buttonItem68 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem69 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem70 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem71 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem72 = new DevComponents.DotNetBar.ButtonItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.itemPanel2 = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItem77 = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandGoToUrl = new DevComponents.DotNetBar.Command(this.components);
            this.buttonItem73 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem74 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem75 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem76 = new DevComponents.DotNetBar.ButtonItem();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.superTabItem4 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.integerInput1 = new DevComponents.Editors.IntegerInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.superTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.buttonItem61 = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandSave = new DevComponents.DotNetBar.Command(this.components);
            this.buttonItem63 = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandOpen = new DevComponents.DotNetBar.Command(this.components);
            this.buttonItem64 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem65 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem66 = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandExit = new DevComponents.DotNetBar.Command(this.components);
            this.menuFileContainer = new DevComponents.DotNetBar.ItemContainer();
            this.menuFileTwoColumnContainer = new DevComponents.DotNetBar.ItemContainer();
            this.menuFileItems = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem20 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem21 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonFileSaveAs = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandSaveAs = new DevComponents.DotNetBar.Command(this.components);
            this.itemContainer12 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem56 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem57 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem58 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem59 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem23 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem24 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem25 = new DevComponents.DotNetBar.ButtonItem();
            this.menuFileMRU = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem8 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem26 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem27 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem28 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem29 = new DevComponents.DotNetBar.ButtonItem();
            this.menuFileBottomContainer = new DevComponents.DotNetBar.ItemContainer();
            this.buttonOptions = new DevComponents.DotNetBar.ButtonItem();
            this.buttonExit = new DevComponents.DotNetBar.ButtonItem();
            this.buttonNew = new DevComponents.DotNetBar.ButtonItem();
            this.buttonSave = new DevComponents.DotNetBar.ButtonItem();
            this.buttonUndo = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.ribbonTabItemGroup1 = new DevComponents.DotNetBar.RibbonTabItemGroup();
            this.buttonStyleMetro = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandTheme = new DevComponents.DotNetBar.Command(this.components);
            this.buttonItem47 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem48 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem49 = new DevComponents.DotNetBar.ButtonItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.progressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.superTabControlPanel4.SuspendLayout();
            this.superTabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.rtf";
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|All Files(*.*)|*.*";
            this.openFileDialog1.FilterIndex = 2;
            this.openFileDialog1.Title = "Open File";
            // 
            // mdiClient1
            // 
            this.mdiClient1.BackColor = System.Drawing.Color.White;
            this.mdiClient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdiClient1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdiClient1.Location = new System.Drawing.Point(5, 178);
            this.mdiClient1.Name = "mdiClient1";
            this.mdiClient1.Size = new System.Drawing.Size(766, 301);
            this.mdiClient1.TabIndex = 5;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.rtf";
            this.saveFileDialog1.FileName = "doc1";
            this.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|All Files(*.*)|*.*";
            this.saveFileDialog1.FilterIndex = 2;
            this.saveFileDialog1.Title = "Save File";
            // 
            // tabStrip1
            // 
            this.tabStrip1.AutoSelectAttachedControl = true;
            this.tabStrip1.CanReorderTabs = true;
            this.tabStrip1.CloseButtonOnTabsVisible = true;
            this.tabStrip1.CloseButtonVisible = false;
            this.tabStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStrip1.ForeColor = System.Drawing.Color.Black;
            this.tabStrip1.Location = new System.Drawing.Point(5, 152);
            this.tabStrip1.MdiForm = this;
            this.tabStrip1.MdiTabbedDocuments = true;
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.SelectedTab = null;
            this.tabStrip1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStrip1.Size = new System.Drawing.Size(766, 26);
            this.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.tabStrip1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.tabStrip1.TabIndex = 6;
            this.tabStrip1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabStrip1.Text = "tabStrip1";
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.bar1.AntiAlias = true;
            this.bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelStatus,
            this.progressBarItem1,
            this.itemContainer13});
            this.bar1.ItemSpacing = 2;
            this.bar1.Location = new System.Drawing.Point(5, 479);
            this.bar1.Name = "bar1";
            this.bar1.PaddingBottom = 0;
            this.bar1.PaddingTop = 0;
            this.bar1.Size = new System.Drawing.Size(766, 19);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 7;
            this.bar1.TabStop = false;
            this.bar1.Text = "barStatus";
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.PaddingLeft = 2;
            this.labelStatus.PaddingRight = 2;
            this.labelStatus.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.labelStatus.Stretch = true;
            // 
            // progressBarItem1
            // 
            // 
            // 
            // 
            this.progressBarItem1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarItem1.ChunkGradientAngle = 0F;
            this.progressBarItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.progressBarItem1.Name = "progressBarItem1";
            this.progressBarItem1.RecentlyUsed = false;
            // 
            // itemContainer13
            // 
            // 
            // 
            // 
            this.itemContainer13.BackgroundStyle.Class = "Office2007StatusBarBackground2";
            this.itemContainer13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer13.Name = "itemContainer13";
            this.itemContainer13.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelPosition});
            // 
            // 
            // 
            this.itemContainer13.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // labelPosition
            // 
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.PaddingLeft = 2;
            this.labelPosition.PaddingRight = 2;
            this.labelPosition.SingleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.labelPosition.Stretch = true;
            this.labelPosition.Text = "爱因斯坦科技有限公司 版权所有";
            this.labelPosition.Width = 180;
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.mainRibbonControl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mainRibbonControl.CaptionVisible = true;
            this.mainRibbonControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainRibbonControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainRibbonControl.ForeColor = System.Drawing.Color.Black;
            this.mainRibbonControl.GlobalContextMenuBar = this.contextMenuBar;
            this.mainRibbonControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.switchButtonItem1});
            this.mainRibbonControl.KeyTipsFont = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainRibbonControl.Location = new System.Drawing.Point(5, 1);
            this.mainRibbonControl.MdiSystemItemVisible = false;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.mainRibbonControl.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonFile,
            this.buttonNew,
            this.buttonSave,
            this.buttonUndo,
            this.qatCustomizeItem1});
            this.mainRibbonControl.RibbonStripFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainRibbonControl.Size = new System.Drawing.Size(766, 151);
            this.mainRibbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mainRibbonControl.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.mainRibbonControl.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.mainRibbonControl.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.mainRibbonControl.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.mainRibbonControl.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.mainRibbonControl.SystemText.QatDialogAddButton = "&Add >>";
            this.mainRibbonControl.SystemText.QatDialogCancelButton = "Cancel";
            this.mainRibbonControl.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.mainRibbonControl.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.mainRibbonControl.SystemText.QatDialogOkButton = "OK";
            this.mainRibbonControl.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.mainRibbonControl.SystemText.QatDialogRemoveButton = "&Remove";
            this.mainRibbonControl.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.mainRibbonControl.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.mainRibbonControl.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.mainRibbonControl.TabGroupHeight = 14;
            this.mainRibbonControl.TabGroups.AddRange(new DevComponents.DotNetBar.RibbonTabItemGroup[] {
            this.ribbonTabItemGroup1});
            this.mainRibbonControl.TabGroupsVisible = true;
            this.mainRibbonControl.TabIndex = 8;
            this.mainRibbonControl.BeforeRibbonPanelPopupClose += new DevComponents.DotNetBar.RibbonPopupCloseEventHandler(this.ribbonControl1_BeforeRibbonPanelPopupClose);
            // 
            // contextMenuBar
            // 
            this.contextMenuBar.AntiAlias = true;
            this.contextMenuBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bEditPopup});
            this.contextMenuBar.Location = new System.Drawing.Point(352, 309);
            this.contextMenuBar.Name = "contextMenuBar";
            this.contextMenuBar.Size = new System.Drawing.Size(150, 25);
            this.contextMenuBar.Stretch = true;
            this.contextMenuBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar.TabIndex = 13;
            this.contextMenuBar.TabStop = false;
            // 
            // bEditPopup
            // 
            this.bEditPopup.AutoExpandOnClick = true;
            this.bEditPopup.GlobalName = "bEditPopup";
            this.bEditPopup.Name = "bEditPopup";
            this.bEditPopup.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
            this.bEditPopup.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bCut,
            this.bCopy,
            this.bPaste,
            this.bSelectAll});
            this.bEditPopup.Text = "bEditPopup";
            // 
            // bCut
            // 
            this.bCut.BeginGroup = true;
            this.bCut.GlobalName = "bCut";
            this.bCut.ImageIndex = 5;
            this.bCut.Name = "bCut";
            this.bCut.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
            this.bCut.Text = "Cu&t";
            // 
            // bCopy
            // 
            this.bCopy.GlobalName = "bCopy";
            this.bCopy.ImageIndex = 4;
            this.bCopy.Name = "bCopy";
            this.bCopy.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
            this.bCopy.Text = "&Copy";
            // 
            // bPaste
            // 
            this.bPaste.GlobalName = "bPaste";
            this.bPaste.ImageIndex = 12;
            this.bPaste.Name = "bPaste";
            this.bPaste.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
            this.bPaste.Text = "&Paste";
            // 
            // bSelectAll
            // 
            this.bSelectAll.BeginGroup = true;
            this.bSelectAll.GlobalName = "bSelectAll";
            this.bSelectAll.Name = "bSelectAll";
            this.bSelectAll.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
            this.bSelectAll.Text = "Select &All";
            // 
            // switchButtonItem1
            // 
            this.switchButtonItem1.ButtonHeight = 20;
            this.switchButtonItem1.ButtonWidth = 62;
            this.switchButtonItem1.Command = this.RibbonStateCommand;
            this.switchButtonItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.switchButtonItem1.Margin.Bottom = 2;
            this.switchButtonItem1.Margin.Left = 4;
            this.switchButtonItem1.Name = "switchButtonItem1";
            this.switchButtonItem1.OffText = "MAX";
            this.switchButtonItem1.OnText = "MIN";
            this.switchButtonItem1.Tooltip = "Minimizes/Maximizes the Ribbon";
            // 
            // RibbonStateCommand
            // 
            this.RibbonStateCommand.Name = "RibbonStateCommand";
            this.RibbonStateCommand.Executed += new System.EventHandler(this.RibbonStateCommand_Executed);
            // 
            // buttonFile
            // 
            this.buttonFile.AutoExpandOnClick = true;
            this.buttonFile.BackstageTab = this.superTabControl1;
            this.buttonFile.CanCustomize = false;
            this.buttonFile.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.buttonFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonFile.Image")));
            this.buttonFile.ImagePaddingHorizontal = 2;
            this.buttonFile.ImagePaddingVertical = 2;
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.ShowSubItems = false;
            this.buttonFile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menuFileContainer});
            this.buttonFile.Text = "&File";
            // 
            // superTabControl1
            // 
            this.superTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.superTabControl1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.ControlBox.Visible = false;
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel4);
            this.superTabControl1.Controls.Add(this.superTabControlPanel3);
            this.superTabControl1.ForeColor = System.Drawing.Color.Black;
            this.superTabControl1.ItemPadding.Left = 6;
            this.superTabControl1.ItemPadding.Right = 4;
            this.superTabControl1.ItemPadding.Top = 4;
            this.superTabControl1.Location = new System.Drawing.Point(6, 47);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = false;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(766, 448);
            this.superTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left;
            this.superTabControl1.TabFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabHorizontalSpacing = 16;
            this.superTabControl1.TabIndex = 14;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem61,
            this.buttonItem63,
            this.buttonItem64,
            this.superTabItem1,
            this.superTabItem2,
            this.superTabItem3,
            this.superTabItem4,
            this.buttonItem65,
            this.buttonItem66});
            this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.superTabControl1.TabVerticalSpacing = 8;
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.superTabControlPanel1.Controls.Add(this.panelEx2);
            this.superTabControlPanel1.Controls.Add(this.panelEx1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(100, 0);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(666, 448);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.recentPlacesItemsPanel);
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(314, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Padding = new System.Windows.Forms.Padding(12);
            this.panelEx2.Size = new System.Drawing.Size(352, 448);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.Transparent;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Right;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            this.panelEx2.Text = "panelEx2";
            // 
            // recentPlacesItemsPanel
            // 
            this.recentPlacesItemsPanel.AutoScroll = true;
            // 
            // 
            // 
            this.recentPlacesItemsPanel.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recentPlacesItemsPanel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recentPlacesItemsPanel.ContainerControlProcessDialogKey = true;
            this.recentPlacesItemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentPlacesItemsPanel.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.recentPlacesItemsPanel.Location = new System.Drawing.Point(12, 35);
            this.recentPlacesItemsPanel.Name = "recentPlacesItemsPanel";
            this.recentPlacesItemsPanel.Size = new System.Drawing.Size(328, 401);
            this.recentPlacesItemsPanel.TabIndex = 2;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.labelX2.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Gray;
            this.labelX2.BackgroundStyle.BorderBottomWidth = 1;
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.DimGray;
            this.labelX2.Location = new System.Drawing.Point(12, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(328, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Recent Places";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.recentDocsItemPane);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Padding = new System.Windows.Forms.Padding(12);
            this.panelEx1.Size = new System.Drawing.Size(314, 448);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.Transparent;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Right;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Text = "panelEx1";
            // 
            // recentDocsItemPane
            // 
            this.recentDocsItemPane.AutoScroll = true;
            // 
            // 
            // 
            this.recentDocsItemPane.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recentDocsItemPane.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.recentDocsItemPane.ContainerControlProcessDialogKey = true;
            this.recentDocsItemPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentDocsItemPane.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.recentDocsItemPane.Location = new System.Drawing.Point(12, 35);
            this.recentDocsItemPane.Name = "recentDocsItemPane";
            this.recentDocsItemPane.Size = new System.Drawing.Size(290, 401);
            this.recentDocsItemPane.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.labelX1.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Gray;
            this.labelX1.BackgroundStyle.BorderBottomWidth = 1;
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.DimGray;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(290, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Recent Documents";
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.KeyTips = "R";
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "Recent";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.superTabControlPanel2.Controls.Add(this.itemPanel1);
            this.superTabControlPanel2.Controls.Add(this.labelX3);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(100, 0);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Padding = new System.Windows.Forms.Padding(12);
            this.superTabControlPanel2.Size = new System.Drawing.Size(666, 448);
            this.superTabControlPanel2.TabIndex = 2;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // itemPanel1
            // 
            this.itemPanel1.AutoScroll = true;
            this.itemPanel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem67,
            this.buttonItem68,
            this.buttonItem69,
            this.buttonItem70,
            this.buttonItem71,
            this.buttonItem72});
            this.itemPanel1.Location = new System.Drawing.Point(12, 35);
            this.itemPanel1.MultiLine = true;
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(642, 401);
            this.itemPanel1.TabIndex = 3;
            // 
            // buttonItem67
            // 
            this.buttonItem67.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem67.Command = this.AppCommandNew;
            this.buttonItem67.ForeColor = System.Drawing.Color.Black;
            this.buttonItem67.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem67.Image")));
            this.buttonItem67.ImagePaddingVertical = 12;
            this.buttonItem67.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem67.Name = "buttonItem67";
            this.buttonItem67.Text = "<span align=\"center\">Blank<br/>document</span>";
            // 
            // AppCommandNew
            // 
            this.AppCommandNew.Name = "AppCommandNew";
            this.AppCommandNew.Executed += new System.EventHandler(this.AppCommandNew_Executed);
            // 
            // buttonItem68
            // 
            this.buttonItem68.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem68.ForeColor = System.Drawing.Color.Black;
            this.buttonItem68.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem68.Image")));
            this.buttonItem68.ImagePaddingVertical = 12;
            this.buttonItem68.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem68.Name = "buttonItem68";
            this.buttonItem68.Text = "Blog post";
            // 
            // buttonItem69
            // 
            this.buttonItem69.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem69.ForeColor = System.Drawing.Color.Black;
            this.buttonItem69.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem69.Image")));
            this.buttonItem69.ImagePaddingHorizontal = 12;
            this.buttonItem69.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem69.Name = "buttonItem69";
            this.buttonItem69.Text = "<span align=\"center\">Recent<br/>templates</span>";
            // 
            // buttonItem70
            // 
            this.buttonItem70.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem70.ForeColor = System.Drawing.Color.Black;
            this.buttonItem70.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem70.Image")));
            this.buttonItem70.ImagePaddingHorizontal = 12;
            this.buttonItem70.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem70.Name = "buttonItem70";
            this.buttonItem70.Text = "<span align=\"center\">Sample<br/>templates</span>";
            // 
            // buttonItem71
            // 
            this.buttonItem71.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem71.ForeColor = System.Drawing.Color.Black;
            this.buttonItem71.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem71.Image")));
            this.buttonItem71.ImagePaddingHorizontal = 12;
            this.buttonItem71.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem71.Name = "buttonItem71";
            this.buttonItem71.Text = "My templates";
            // 
            // buttonItem72
            // 
            this.buttonItem72.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem72.ForeColor = System.Drawing.Color.Black;
            this.buttonItem72.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem72.Image")));
            this.buttonItem72.ImagePaddingHorizontal = 12;
            this.buttonItem72.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem72.Name = "buttonItem72";
            this.buttonItem72.Text = "<span align=\"center\">New from<br/>existing</span>";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.labelX3.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Gray;
            this.labelX3.BackgroundStyle.BorderBottomWidth = 1;
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.DimGray;
            this.labelX3.Location = new System.Drawing.Point(12, 12);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(642, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Available Templates";
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.KeyTips = "N";
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "New";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.superTabControlPanel4.Controls.Add(this.itemPanel2);
            this.superTabControlPanel4.Controls.Add(this.labelX6);
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(100, 0);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Padding = new System.Windows.Forms.Padding(12);
            this.superTabControlPanel4.Size = new System.Drawing.Size(666, 448);
            this.superTabControlPanel4.TabIndex = 4;
            this.superTabControlPanel4.TabItem = this.superTabItem4;
            // 
            // itemPanel2
            // 
            this.itemPanel2.AutoScroll = true;
            this.itemPanel2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.itemPanel2.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemPanel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel2.ContainerControlProcessDialogKey = true;
            this.itemPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem77,
            this.buttonItem73,
            this.buttonItem74,
            this.buttonItem75,
            this.buttonItem76});
            this.itemPanel2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel2.Location = new System.Drawing.Point(12, 35);
            this.itemPanel2.Name = "itemPanel2";
            this.itemPanel2.Size = new System.Drawing.Size(642, 401);
            this.itemPanel2.TabIndex = 3;
            // 
            // buttonItem77
            // 
            this.buttonItem77.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem77.Command = this.AppCommandGoToUrl;
            this.buttonItem77.CommandParameter = "http://www.devcomponents.com/kb/questions.php?questionid=127";
            this.buttonItem77.ForeColor = System.Drawing.Color.Black;
            this.buttonItem77.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem77.Image")));
            this.buttonItem77.Name = "buttonItem77";
            this.buttonItem77.Text = "Backstage<br/>\r\n<font color=\"Gray\">How to build Office 2010 style Backstage with " +
                "DotNetBar</font>";
            // 
            // AppCommandGoToUrl
            // 
            this.AppCommandGoToUrl.Name = "AppCommandGoToUrl";
            this.AppCommandGoToUrl.Executed += new System.EventHandler(this.AppCommandGoToUrl_Executed);
            // 
            // buttonItem73
            // 
            this.buttonItem73.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem73.Command = this.AppCommandGoToUrl;
            this.buttonItem73.CommandParameter = "http://www.devcomponents.com/kb/";
            this.buttonItem73.ForeColor = System.Drawing.Color.Black;
            this.buttonItem73.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem73.Image")));
            this.buttonItem73.Name = "buttonItem73";
            this.buttonItem73.Text = "DotNetBar Knowledge Base<br/>\r\n<font color=\"Gray\">Browse our online Knowledge Bas" +
                "e.</font>";
            // 
            // buttonItem74
            // 
            this.buttonItem74.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem74.Command = this.AppCommandGoToUrl;
            this.buttonItem74.CommandParameter = "http://www.devcomponents.com/dotnetbar/movies.aspx";
            this.buttonItem74.ForeColor = System.Drawing.Color.Black;
            this.buttonItem74.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem74.Image")));
            this.buttonItem74.Name = "buttonItem74";
            this.buttonItem74.Text = "Movie Tutorials<br/>\r\n<font color=\"Gray\">Watch getting started online movie tutor" +
                "ials</font>";
            // 
            // buttonItem75
            // 
            this.buttonItem75.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem75.Command = this.AppCommandGoToUrl;
            this.buttonItem75.CommandParameter = "http://www.devcomponents.com/support.aspx";
            this.buttonItem75.ForeColor = System.Drawing.Color.Black;
            this.buttonItem75.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem75.Image")));
            this.buttonItem75.Name = "buttonItem75";
            this.buttonItem75.Text = "Contact Us<br/>\r\n<font color=\"Gray\">Let us know if you need help or how we can ma" +
                "ke DotNetBar even better.</font>";
            // 
            // buttonItem76
            // 
            this.buttonItem76.BeginGroup = true;
            this.buttonItem76.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem76.Command = this.AppCommandGoToUrl;
            this.buttonItem76.CommandParameter = "http://www.devcomponents.com/dotnetbar/applicationgallery/";
            this.buttonItem76.ForeColor = System.Drawing.Color.Black;
            this.buttonItem76.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem76.Image")));
            this.buttonItem76.Name = "buttonItem76";
            this.buttonItem76.Text = "Application Gallery<br/>\r\n<font color=\"Gray\">See how other developers are using D" +
                "otNetBar in our application gallery</font>";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.labelX6.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Gray;
            this.labelX6.BackgroundStyle.BorderBottomWidth = 1;
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.Color.DimGray;
            this.labelX6.Location = new System.Drawing.Point(12, 12);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(642, 23);
            this.labelX6.TabIndex = 2;
            this.labelX6.Text = "Support";
            // 
            // superTabItem4
            // 
            this.superTabItem4.AttachedControl = this.superTabControlPanel4;
            this.superTabItem4.GlobalItem = false;
            this.superTabItem4.KeyTips = "H";
            this.superTabItem4.Name = "superTabItem4";
            this.superTabItem4.Text = "Help";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.superTabControlPanel3.Controls.Add(this.panelEx3);
            this.superTabControlPanel3.Controls.Add(this.labelX5);
            this.superTabControlPanel3.Controls.Add(this.integerInput1);
            this.superTabControlPanel3.Controls.Add(this.labelX4);
            this.superTabControlPanel3.Controls.Add(this.buttonX1);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(100, 0);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(666, 448);
            this.superTabControlPanel3.TabIndex = 3;
            this.superTabControlPanel3.TabItem = this.superTabItem3;
            // 
            // panelEx3
            // 
            this.panelEx3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEx3.Location = new System.Drawing.Point(292, 4);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(371, 441);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.Color = System.Drawing.Color.White;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.Color = System.Drawing.Color.Silver;
            this.panelEx3.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left;
            this.panelEx3.Style.ForeColor.Color = System.Drawing.Color.Gray;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 5;
            this.panelEx3.Text = "Print Preview Goes Here...";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(143, 54);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(48, 19);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Copies:";
            // 
            // integerInput1
            // 
            // 
            // 
            // 
            this.integerInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput1.Location = new System.Drawing.Point(198, 53);
            this.integerInput1.Name = "integerInput1";
            this.integerInput1.ShowUpDown = true;
            this.integerInput1.Size = new System.Drawing.Size(66, 22);
            this.integerInput1.TabIndex = 3;
            this.integerInput1.Value = 1;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.labelX4.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Gray;
            this.labelX4.BackgroundStyle.BorderBottomWidth = 1;
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.DimGray;
            this.labelX4.Location = new System.Drawing.Point(144, 16);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(120, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Print";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX1.Location = new System.Drawing.Point(21, 21);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(109, 101);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "Print";
            // 
            // superTabItem3
            // 
            this.superTabItem3.AttachedControl = this.superTabControlPanel3;
            this.superTabItem3.GlobalItem = false;
            this.superTabItem3.KeyTips = "P";
            this.superTabItem3.Name = "superTabItem3";
            this.superTabItem3.Text = "Print";
            // 
            // buttonItem61
            // 
            this.buttonItem61.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem61.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem61.Command = this.AppCommandSave;
            this.buttonItem61.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem61.Image")));
            this.buttonItem61.ImagePaddingHorizontal = 18;
            this.buttonItem61.ImagePaddingVertical = 10;
            this.buttonItem61.KeyTips = "S";
            this.buttonItem61.Name = "buttonItem61";
            this.buttonItem61.Stretch = true;
            this.buttonItem61.Text = "Save";
            // 
            // AppCommandSave
            // 
            this.AppCommandSave.Name = "AppCommandSave";
            this.AppCommandSave.Executed += new System.EventHandler(this.AppCommandSave_Executed);
            // 
            // buttonItem63
            // 
            this.buttonItem63.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem63.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem63.Command = this.AppCommandOpen;
            this.buttonItem63.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem63.Image")));
            this.buttonItem63.ImagePaddingHorizontal = 18;
            this.buttonItem63.ImagePaddingVertical = 10;
            this.buttonItem63.KeyTips = "O";
            this.buttonItem63.Name = "buttonItem63";
            this.buttonItem63.Stretch = true;
            this.buttonItem63.Text = "Open";
            // 
            // AppCommandOpen
            // 
            this.AppCommandOpen.Name = "AppCommandOpen";
            this.AppCommandOpen.Executed += new System.EventHandler(this.AppCommandOpen_Executed);
            // 
            // buttonItem64
            // 
            this.buttonItem64.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem64.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem64.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem64.Image")));
            this.buttonItem64.ImagePaddingHorizontal = 18;
            this.buttonItem64.ImagePaddingVertical = 10;
            this.buttonItem64.KeyTips = "C";
            this.buttonItem64.Name = "buttonItem64";
            this.buttonItem64.Stretch = true;
            this.buttonItem64.Text = "Close";
            // 
            // buttonItem65
            // 
            this.buttonItem65.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem65.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem65.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem65.Image")));
            this.buttonItem65.ImagePaddingHorizontal = 18;
            this.buttonItem65.ImagePaddingVertical = 10;
            this.buttonItem65.KeyTips = "T";
            this.buttonItem65.Name = "buttonItem65";
            this.buttonItem65.Stretch = true;
            this.buttonItem65.Text = "Options";
            // 
            // buttonItem66
            // 
            this.buttonItem66.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem66.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem66.Command = this.AppCommandExit;
            this.buttonItem66.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem66.Image")));
            this.buttonItem66.ImagePaddingHorizontal = 18;
            this.buttonItem66.ImagePaddingVertical = 10;
            this.buttonItem66.KeyTips = "X";
            this.buttonItem66.Name = "buttonItem66";
            this.buttonItem66.Stretch = true;
            this.buttonItem66.Text = "Exit";
            // 
            // AppCommandExit
            // 
            this.AppCommandExit.Name = "AppCommandExit";
            this.AppCommandExit.Executed += new System.EventHandler(this.AppCommandExit_Executed);
            // 
            // menuFileContainer
            // 
            // 
            // 
            // 
            this.menuFileContainer.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.menuFileContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.menuFileContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.menuFileContainer.Name = "menuFileContainer";
            this.menuFileContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menuFileTwoColumnContainer,
            this.menuFileBottomContainer});
            // 
            // 
            // 
            this.menuFileContainer.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // menuFileTwoColumnContainer
            // 
            // 
            // 
            // 
            this.menuFileTwoColumnContainer.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.menuFileTwoColumnContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.menuFileTwoColumnContainer.BackgroundStyle.PaddingBottom = 2;
            this.menuFileTwoColumnContainer.BackgroundStyle.PaddingLeft = 2;
            this.menuFileTwoColumnContainer.BackgroundStyle.PaddingRight = 2;
            this.menuFileTwoColumnContainer.BackgroundStyle.PaddingTop = 2;
            this.menuFileTwoColumnContainer.ItemSpacing = 0;
            this.menuFileTwoColumnContainer.Name = "menuFileTwoColumnContainer";
            this.menuFileTwoColumnContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menuFileItems,
            this.menuFileMRU});
            // 
            // 
            // 
            this.menuFileTwoColumnContainer.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // menuFileItems
            // 
            // 
            // 
            // 
            this.menuFileItems.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.menuFileItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.menuFileItems.ItemSpacing = 5;
            this.menuFileItems.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.menuFileItems.MinimumSize = new System.Drawing.Size(120, 0);
            this.menuFileItems.Name = "menuFileItems";
            this.menuFileItems.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem20,
            this.buttonItem21,
            this.buttonFileSaveAs,
            this.buttonItem23,
            this.buttonItem24,
            this.buttonItem25});
            // 
            // 
            // 
            this.menuFileItems.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem20
            // 
            this.buttonItem20.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem20.Command = this.AppCommandNew;
            this.buttonItem20.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem20.Image")));
            this.buttonItem20.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonItem20.ImageSmall")));
            this.buttonItem20.Name = "buttonItem20";
            this.buttonItem20.SubItemsExpandWidth = 24;
            this.buttonItem20.Text = "&New";
            // 
            // buttonItem21
            // 
            this.buttonItem21.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem21.Command = this.AppCommandOpen;
            this.buttonItem21.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem21.Image")));
            this.buttonItem21.Name = "buttonItem21";
            this.buttonItem21.SubItemsExpandWidth = 24;
            this.buttonItem21.Text = "&Open...";
            // 
            // buttonFileSaveAs
            // 
            this.buttonFileSaveAs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonFileSaveAs.Command = this.AppCommandSaveAs;
            this.buttonFileSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("buttonFileSaveAs.Image")));
            this.buttonFileSaveAs.ImageSmall = ((System.Drawing.Image)(resources.GetObject("buttonFileSaveAs.ImageSmall")));
            this.buttonFileSaveAs.Name = "buttonFileSaveAs";
            this.buttonFileSaveAs.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer12});
            this.buttonFileSaveAs.SubItemsExpandWidth = 24;
            this.buttonFileSaveAs.Text = "&Save As...";
            this.buttonFileSaveAs.ExpandChange += new System.EventHandler(this.buttonFileSaveAs_ExpandChange);
            // 
            // AppCommandSaveAs
            // 
            this.AppCommandSaveAs.Name = "AppCommandSaveAs";
            this.AppCommandSaveAs.Executed += new System.EventHandler(this.AppCommandSaveAs_Executed);
            // 
            // itemContainer12
            // 
            // 
            // 
            // 
            this.itemContainer12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer12.ItemSpacing = 4;
            this.itemContainer12.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer12.MinimumSize = new System.Drawing.Size(210, 256);
            this.itemContainer12.Name = "itemContainer12";
            this.itemContainer12.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.buttonItem56,
            this.buttonItem57,
            this.buttonItem58,
            this.buttonItem59});
            // 
            // 
            // 
            this.itemContainer12.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // labelItem1
            // 
            this.labelItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.labelItem1.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem1.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.PaddingBottom = 5;
            this.labelItem1.PaddingLeft = 5;
            this.labelItem1.PaddingRight = 5;
            this.labelItem1.PaddingTop = 5;
            this.labelItem1.Text = "<b>Save a copy of the document</b>";
            // 
            // buttonItem56
            // 
            this.buttonItem56.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem56.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem56.Image")));
            this.buttonItem56.Name = "buttonItem56";
            this.buttonItem56.Text = "<b>&Rich Text Document</b>\r\n<div padding=\"0,0,4,0\" width=\"170\">Save the document " +
                "in the default file format.</div>";
            // 
            // buttonItem57
            // 
            this.buttonItem57.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem57.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem57.Image")));
            this.buttonItem57.Name = "buttonItem57";
            this.buttonItem57.Text = "<b>Document &Template</b>\r\n<div padding=\"0,0,4,0\" width=\"170\">Save as a template " +
                "that can be used to format future documents.</div>";
            // 
            // buttonItem58
            // 
            this.buttonItem58.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem58.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem58.Image")));
            this.buttonItem58.Name = "buttonItem58";
            this.buttonItem58.Text = "<b>&Find add-ins for other formats</b>\r\n<div padding=\"0,0,4,0\" width=\"180\">Learn " +
                "about add-ins to save to other formats such as PDF or XPS.</div>";
            // 
            // buttonItem59
            // 
            this.buttonItem59.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem59.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem59.Image")));
            this.buttonItem59.Name = "buttonItem59";
            this.buttonItem59.Text = "<b>&Other Formats</b>\r\n<div padding=\"0,0,4,0\" width=\"170\">Open the Save As dialog" +
                " box to select from all possible file types.</div>";
            // 
            // buttonItem23
            // 
            this.buttonItem23.BeginGroup = true;
            this.buttonItem23.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem23.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem23.Image")));
            this.buttonItem23.Name = "buttonItem23";
            this.buttonItem23.SubItemsExpandWidth = 24;
            this.buttonItem23.Text = "S&hare...";
            // 
            // buttonItem24
            // 
            this.buttonItem24.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem24.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem24.Image")));
            this.buttonItem24.Name = "buttonItem24";
            this.buttonItem24.SubItemsExpandWidth = 24;
            this.buttonItem24.Text = "&Print...";
            // 
            // buttonItem25
            // 
            this.buttonItem25.BeginGroup = true;
            this.buttonItem25.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem25.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem25.Image")));
            this.buttonItem25.Name = "buttonItem25";
            this.buttonItem25.SubItemsExpandWidth = 24;
            this.buttonItem25.Text = "&Close";
            // 
            // menuFileMRU
            // 
            // 
            // 
            // 
            this.menuFileMRU.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.menuFileMRU.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.menuFileMRU.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.menuFileMRU.MinimumSize = new System.Drawing.Size(225, 0);
            this.menuFileMRU.Name = "menuFileMRU";
            this.menuFileMRU.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem8,
            this.buttonItem26,
            this.buttonItem27,
            this.buttonItem28,
            this.buttonItem29});
            // 
            // 
            // 
            this.menuFileMRU.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // labelItem8
            // 
            this.labelItem8.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem8.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem8.Name = "labelItem8";
            this.labelItem8.PaddingBottom = 2;
            this.labelItem8.PaddingTop = 2;
            this.labelItem8.Stretch = true;
            this.labelItem8.Text = "Recent Documents";
            // 
            // buttonItem26
            // 
            this.buttonItem26.Name = "buttonItem26";
            this.buttonItem26.Text = "&1. Short News 5-7.rtf";
            // 
            // buttonItem27
            // 
            this.buttonItem27.Name = "buttonItem27";
            this.buttonItem27.Text = "&2. Prospect Email.rtf";
            // 
            // buttonItem28
            // 
            this.buttonItem28.Name = "buttonItem28";
            this.buttonItem28.Text = "&3. Customer Email.rtf";
            // 
            // buttonItem29
            // 
            this.buttonItem29.Name = "buttonItem29";
            this.buttonItem29.Text = "&4. example.rtf";
            // 
            // menuFileBottomContainer
            // 
            // 
            // 
            // 
            this.menuFileBottomContainer.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
            this.menuFileBottomContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.menuFileBottomContainer.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.menuFileBottomContainer.Name = "menuFileBottomContainer";
            this.menuFileBottomContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonOptions,
            this.buttonExit});
            // 
            // 
            // 
            this.menuFileBottomContainer.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonOptions
            // 
            this.buttonOptions.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonOptions.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonOptions.Image")));
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.SubItemsExpandWidth = 24;
            this.buttonOptions.Text = "RibbonPad Opt&ions";
            // 
            // buttonExit
            // 
            this.buttonExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonExit.Command = this.AppCommandExit;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.SubItemsExpandWidth = 24;
            this.buttonExit.Text = "E&xit RibbonPad";
            // 
            // buttonNew
            // 
            this.buttonNew.Command = this.AppCommandNew;
            this.buttonNew.Image = ((System.Drawing.Image)(resources.GetObject("buttonNew.Image")));
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.buttonNew.Text = "New Document";
            // 
            // buttonSave
            // 
            this.buttonSave.Command = this.AppCommandSave;
            this.buttonSave.Enabled = false;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Text = "buttonItem2";
            // 
            // buttonUndo
            // 
            this.buttonUndo.Enabled = false;
            this.buttonUndo.Image = ((System.Drawing.Image)(resources.GetObject("buttonUndo.Image")));
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Text = "Undo";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // ribbonTabItemGroup1
            // 
            this.ribbonTabItemGroup1.Color = DevComponents.DotNetBar.eRibbonTabGroupColor.Orange;
            this.ribbonTabItemGroup1.GroupTitle = "Tab Group";
            this.ribbonTabItemGroup1.Name = "ribbonTabItemGroup1";
            // 
            // 
            // 
            this.ribbonTabItemGroup1.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.ribbonTabItemGroup1.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.ribbonTabItemGroup1.Style.BackColorGradientAngle = 90;
            this.ribbonTabItemGroup1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup1.Style.BorderBottomWidth = 1;
            this.ribbonTabItemGroup1.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            this.ribbonTabItemGroup1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup1.Style.BorderLeftWidth = 1;
            this.ribbonTabItemGroup1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup1.Style.BorderRightWidth = 1;
            this.ribbonTabItemGroup1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup1.Style.BorderTopWidth = 1;
            this.ribbonTabItemGroup1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonTabItemGroup1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribbonTabItemGroup1.Style.TextColor = System.Drawing.Color.Black;
            this.ribbonTabItemGroup1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // buttonStyleMetro
            // 
            this.buttonStyleMetro.Checked = true;
            this.buttonStyleMetro.Command = this.AppCommandTheme;
            this.buttonStyleMetro.CommandParameter = "Metro";
            this.buttonStyleMetro.Name = "buttonStyleMetro";
            this.buttonStyleMetro.OptionGroup = "style";
            this.buttonStyleMetro.Text = "Metro/Office 2013";
            // 
            // AppCommandTheme
            // 
            this.AppCommandTheme.Name = "AppCommandTheme";
            this.AppCommandTheme.Executed += new System.EventHandler(this.AppCommandTheme_Executed);
            // 
            // buttonItem47
            // 
            this.buttonItem47.BeginGroup = true;
            this.buttonItem47.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem47.Image")));
            this.buttonItem47.Name = "buttonItem47";
            this.buttonItem47.Text = "Search for Templates Online...";
            // 
            // buttonItem48
            // 
            this.buttonItem48.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem48.Image")));
            this.buttonItem48.Name = "buttonItem48";
            this.buttonItem48.Text = "Browse for Templates...";
            // 
            // buttonItem49
            // 
            this.buttonItem49.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem49.Image")));
            this.buttonItem49.Name = "buttonItem49";
            this.buttonItem49.Text = "Save Current Template...";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "6";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "7";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "8";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "9";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "10";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "11";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "12";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "13";
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "14";
            // 
            // superTooltip1
            // 
            this.superTooltip1.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTooltip1.MinimumTooltipSize = new System.Drawing.Size(150, 50);
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Enabled = true;
            this.progressBarTimer.Interval = 800;
            this.progressBarTimer.Tick += new System.EventHandler(this.progressBarTimer_Tick);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "OpenExistingPlace.png");
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(776, 500);
            this.Controls.Add(this.superTabControl1);
            this.Controls.Add(this.contextMenuBar);
            this.Controls.Add(this.tabStrip1);
            this.Controls.Add(this.mainRibbonControl);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.mdiClient1);
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "爱因斯坦平台";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MdiChildActivate += new System.EventHandler(this.MdiChildActivated);
            this.Move += new System.EventHandler(this.frmMain_Move);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.superTabControlPanel4.ResumeLayout(false);
            this.superTabControlPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region AppCreation
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            MessageBoxEx.EnableGlass = false; // Disalbe glass effect if available
			Application.Run(new frmMain());
		}
		#endregion

		public void EditContextMenu()
		{
			bEditPopup.Displayed=false;
			bEditPopup.PopupMenu(Control.MousePosition);
		}

		/// <summary>
		/// Verifies current context and enables/disables menu items...
		/// </summary>
		private void EnableFileItems()
		{
			// Accessing items through the Items collection and setting the properties on them
			// will propagate certain properties to all items with the same name...
			if(this.ActiveMdiChild==null)
			{
				AppCommandSave.Enabled=false;
				AppCommandSaveAs.Enabled = false;
			}
			else
			{
				AppCommandSave.Enabled = true;
				AppCommandSaveAs.Enabled = true;
				if(this.ActiveMdiChild is frmDocument)
					((frmDocument)this.ActiveMdiChild).FormActivated();
			}
		}

		private void MdiChildActivated(object sender, System.EventArgs e)
		{
			EnableFileItems();
			BindDocumentCommands();
		}

		internal void SaveDocument(frmDocument doc)
		{
			if(doc.FileName=="")
			{
				if(saveFileDialog1.ShowDialog()!=DialogResult.OK)
					return;
				if(saveFileDialog1.FileName=="")
					return;
				doc.FileName=saveFileDialog1.FileName;
			}
			if(doc.FileName!="")
				doc.SaveFile();
		}

		private void UnloadPopup(object sender, System.EventArgs e)
		{
			ButtonItem item=sender as ButtonItem;
			if(item.Name=="bTabColor")
			{
				DevComponents.DotNetBar.PopupContainerControl container=item.PopupContainerControl as PopupContainerControl;
				ColorPicker clr=container.Controls[0] as ColorPicker;
				if(clr.SelectedColor!=Color.Empty)
				{
					tabStrip1.ColorScheme.TabBackground=ControlPaint.LightLight(clr.SelectedColor);
					tabStrip1.ColorScheme.TabBackground2=clr.SelectedColor;
					tabStrip1.Refresh();
				}
				// Close popup menu, since it is not closed when Popup Container is closed...
				item.Parent.Expanded=false;
			}
        }

		private void frmMain_Load(object sender, System.EventArgs e)
		{
            mainRibbonControl.PerformLayout();
			// Create the list of frequently used commands for the QAT Customize menu
			mainRibbonControl.QatFrequentCommands.Add(buttonItem20);
			mainRibbonControl.QatFrequentCommands.Add(buttonItem21);
			mainRibbonControl.QatFrequentCommands.Add(buttonItem24);
			mainRibbonControl.QatFrequentCommands.Add(buttonItem25);

			EnableFileItems();

			AppCommandNew.Execute();

			// Load Quick Access Toolbar layout if one is saved from last session...
			Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\DevComponents\Ribbon");
			if(key!=null)
			{
				try
				{
					string layout = key.GetValue("RibbonPadCSLayout","").ToString();
					if(layout!="" && layout!=null)
						mainRibbonControl.QatLayout = layout;
				}
				finally
				{
					key.Close();
				}
			}

			// Pulse the Application Button
			buttonFile.Pulse(11);
		}

		private void frmMain_Move(object sender, System.EventArgs e)
		{
			this.CloseSearch();
		}

		private void CloseSearch()
		{
			if(m_Search!=null)
			{
				m_Search.Close();
				m_Search.Dispose();
				m_Search=null;
			}
		}

		

		private void LaunchRibbonDialog(object sender, System.EventArgs e)
		{
			MessageBoxEx.Show("Start <i>Ribbon Dialog</i> with more options here...","Ribbon Demo",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void buttonFind_Click(object sender, System.EventArgs e)
		{
			if(m_Search==null || m_Search.IsDisposed)
			{
				m_Search=new BalloonSearch();
				m_Search.Owner=this;
				m_Search.Show(sender as BaseItem,true);
			}
		}

		private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// Save Quick Access Toolbar layout if it has changed...
			if(mainRibbonControl.QatLayoutChanged)
			{
				Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\DevComponents\Ribbon");
				try
				{
					key.SetValue("RibbonPadCSLayout", mainRibbonControl.QatLayout);
				}
				finally
				{
					key.Close();
				}
			}
		}

		private void progressBarTimer_Tick(object sender, System.EventArgs e)
		{
			if(progressBarItem1.Value>=progressBarItem1.Maximum)
			{
				progressBarTimer.Stop();
				progressBarItem1.Value = 50;
			}
			else
				progressBarItem1.Value+=4;
		}

		private void ribbonControl1_BeforeRibbonPanelPopupClose(object sender, DevComponents.DotNetBar.RibbonPopupCloseEventArgs e)
		{
			// Don't close ribbon tab menu if Find button is clicked since it display the balloon popup
            //if(e.Source == buttonFind)
            //    e.Cancel = true;
		}

		#region Automatic Color Scheme creation based on the selected color table
		private bool m_ColorSelected = false;
		private eStyle m_BaseStyle = eStyle.Office2010Silver;
		

		private void buttonStyleCustom_ColorPreview(object sender, DevComponents.DotNetBar.ColorPreviewEventArgs e)
		{
            if (StyleManager.Style == eStyle.Metro)
            {
                Color baseColor = e.Color;
                StyleManager.MetroColorGeneratorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.White, baseColor);
            }
            else
    			StyleManager.ColorTint = e.Color;
		}

		#endregion

		private void buttonFileSaveAs_ExpandChange(object sender, System.EventArgs e)
		{
			// Position the Save As sub menu on top of the recent files box
			if(buttonFileSaveAs.Expanded)
			{
				buttonFileSaveAs.PopupLocation = menuFileMRU.DisplayRectangle.Location;
			}
		}

        #region Commands Implementation
		private void BindDocumentCommands()
		{
			frmDocument document = this.ActiveMdiChild as frmDocument;
			if (document == null)
			{
				// Note that when Command is set to null the button will be automatically 
				// disabled if it had command associated previously
				buttonUndo.Command = null;
                //zoomSlider.Command = null;
				labelStatus.Command = null;
				bCopy.Command = null;
				bCut.Command = null;
				bPaste.Command = null;
			}
			else
			{
				bCopy.Command = document.CommandCopy;
				bCut.Command = document.CommandCut;
				bPaste.Command = document.CommandPaste;
				buttonUndo.Command = document.CommandUndo;
                //zoomSlider.Command = document.CommandZoom;
				labelStatus.Command = document.CommandStatus;
			}
		}

		private void AppCommandNew_Executed(object sender, EventArgs e)
		{
            // Close Application Menu
            buttonFile.Expanded = false;

			frmDocument doc = new frmDocument();
			doc.Text = "New Document " + (this.MdiChildren.Length + 1);
			doc.MdiParent = this;
			doc.WindowState = FormWindowState.Maximized;
			doc.Show();
			doc.Update();
		}

		private void AppCommandOpen_Executed(object sender, EventArgs e)
		{
            // Close Application Menu
            buttonFile.Expanded = false;

			openFileDialog1.FileName = "";
			openFileDialog1.ShowDialog();
			if (openFileDialog1.FileName == "")
				return;
			frmDocument doc = new frmDocument();
			doc.Text = openFileDialog1.FileName;
			doc.MdiParent = this;
			doc.Show();
			doc.OpenFile(openFileDialog1.FileName);
		}

		private void AppCommandSave_Executed(object sender, EventArgs e)
		{
            // Close Application Menu
            buttonFile.Expanded = false;

			frmDocument doc = this.ActiveMdiChild as frmDocument;
			if (doc == null || !doc.DocumentChanged)
				return;
			SaveDocument(doc);
		}

		private void AppCommandSaveAs_Executed(object sender, EventArgs e)
		{
            // Close Application Menu
            buttonFile.Expanded = false;

			if (this.ActiveMdiChild == null)
				return;

			// Close menu popup if needed since File Dialogs can interfer with it
			if(sender is BaseItem)
				BaseItem.CollapseAll(sender as BaseItem);

			frmDocument doc = this.ActiveMdiChild as frmDocument;
			if (doc == null || !doc.DocumentChanged)
				return;
			if (doc.FileName == "")
			{
				SaveDocument(doc);
				return;
			}

			saveFileDialog1.ShowDialog();
			if (saveFileDialog1.ShowDialog() != DialogResult.OK)
				return;
			if (saveFileDialog1.FileName == "")
				return;
			doc.FileName = saveFileDialog1.FileName;
			doc.SaveFile();
		}

		private void AppCommandTheme_Executed(object sender, EventArgs e)
		{
			ICommandSource source = sender as ICommandSource;
			if (source.CommandParameter is string)
			{
				eStyle style = (eStyle)Enum.Parse(typeof(eStyle), source.CommandParameter.ToString());
				// Using StyleManager change the style and color tinting
                if (style == eStyle.Metro)
                {
                    // More customization is needed for Metro
                    // Capitalize App Button and tab
                    buttonFile.Text = buttonFile.Text.ToUpper();
                    foreach (BaseItem item in RibbonControl.Items)
                    {
                        // Ribbon Control may contain items other than tabs so that needs to be taken in account
                        RibbonTabItem tab = item as RibbonTabItem;
                        if (tab != null)
                            tab.Text = tab.Text.ToUpper();
                    }

                    buttonFile.BackstageTabEnabled = true; // Use Backstage for Metro

                    mainRibbonControl.RibbonStripFont = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    StyleManager.MetroColorGeneratorParameters = DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters.DarkBlue;

                    // Adjust size of switch button to match Metro styling
                    switchMenuButtonItem.SwitchWidth = 12;
                    switchMenuButtonItem.ButtonWidth = 42;
                    switchMenuButtonItem.ButtonHeight = 19;

                    StyleManager.Style = eStyle.Metro; // BOOM
                }
                else
                {
                    // If previous style was Metro we need to update other properties as well
                    if (StyleManager.Style == eStyle.Metro)
                    {
                        mainRibbonControl.RibbonStripFont = null;
                        // Fix capitalization App Button and tab
                        buttonFile.Text = ToTitleCase(buttonFile.Text);
                        foreach (BaseItem item in RibbonControl.Items)
                        {
                            // Ribbon Control may contain items other than tabs so that needs to be taken in account
                            RibbonTabItem tab = item as RibbonTabItem;
                            if (tab != null)
                                tab.Text = ToTitleCase(tab.Text);
                        }
                        // Adjust size of switch button to match Office styling
                        switchMenuButtonItem.SwitchWidth = 28;
                        switchMenuButtonItem.ButtonWidth = 62;
                        switchMenuButtonItem.ButtonHeight = 20;
                    }

                    StyleManager.ChangeStyle(style, Color.Empty);
                    if (style == eStyle.Office2007Black || style == eStyle.Office2007Blue || style == eStyle.Office2007Silver || style == eStyle.Office2007VistaGlass)
                        buttonFile.BackstageTabEnabled = false;
                    else
                        buttonFile.BackstageTabEnabled = true;
                }
			}
			else if (source.CommandParameter is Color)
			{
                if (StyleManager.Style == eStyle.Metro)
                    StyleManager.MetroColorGeneratorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(Color.White, (Color)source.CommandParameter);
                else
                    StyleManager.ColorTint = (Color)source.CommandParameter;
			}
		}

        private string ToTitleCase(string text) 
        {
            if (text.Contains("&"))
            {
                int ampPosition = text.IndexOf('&');
                text = text.Replace("&", "");
                text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
                if (ampPosition > 0)
                    text = text.Substring(0, ampPosition) + "&" + text.Substring(ampPosition);
                else
                    text = "&" + text;
                return text;
            }
            else
                return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
        }

		private void AppCommandExit_Executed(object sender, EventArgs e)
		{
			this.Close();
		}

        private void AppCommandGoToUrl_Executed(object sender, EventArgs e)
        {
            // Close Application Menu
            buttonFile.Expanded = false;
            ICommandSource source = sender as ICommandSource;
            if (source.CommandParameter is string)
            {
                string url = (string)source.CommandParameter;
                System.Diagnostics.Process.Start(url);
            }
            else
                MessageBoxEx.Show("This command must have CommandParameter set to the URL you want to navigate to.");
        }

        private void RibbonStateCommand_Executed(object sender, EventArgs e)
        {
            mainRibbonControl.Expanded = RibbonStateCommand.Checked;
            RibbonStateCommand.Checked = !RibbonStateCommand.Checked;
            
        }
        #endregion

        #region Backstage Application Menu Content Setup
        private void SetupBackstageContent()
        {
            SetupRecentTab();
        }
        private void SetupRecentTab()
        {
            recentDocsItemPane.Items.Clear();
            MruItem[] mruFiles = GetMruFiles();
            foreach (MruItem item in mruFiles)
            {
                recentDocsItemPane.Items.Add(CreateMruFileView(item));
            }

            recentPlacesItemsPanel.Items.Clear();
            MruItem[] mruPlaces = GetMruPlaces();
            foreach (MruItem item in mruPlaces)
            {
                recentPlacesItemsPanel.Items.Add(CreateMruPlaceView(item));
            }
        }

        private BaseItem CreateMruPlaceView(MruItem item)
        {
            ItemDockContainer container = new ItemDockContainer();
            container.LastChildFill = true;
            // Create Pin Button
            ButtonItem pinButton = new ButtonItem();
            pinButton.ImagePaddingHorizontal = 6;
            pinButton.Image = global::Einstein.Platform.Properties.Resources.Unpinned;
            container.SetDock(pinButton, eItemDock.Right); // Position pin button on right side
            container.SubItems.Add(pinButton);
            // Create button with file name and folder
            ButtonItem fileButton = new ButtonItem();
            fileButton.ForeColor = Color.Black;
            fileButton.ButtonStyle = eButtonStyle.ImageAndText;
            fileButton.ImagePosition = eImagePosition.Left;
            fileButton.Text = item.FileName + "<br/><font color=\"Gray\">" + item.Folder + "</font>";
            fileButton.Image = global::Einstein.Platform.Properties.Resources.OpenExistingPlace;
            container.SubItems.Add(fileButton);

            return container;
        }

        private BaseItem CreateMruFileView(MruItem item)
        {
            ItemDockContainer container = new ItemDockContainer();
            container.LastChildFill = true;
            // Create Pin Button
            ButtonItem pinButton = new ButtonItem();
            pinButton.ImagePaddingHorizontal = 6;
            pinButton.Image = global::Einstein.Platform.Properties.Resources.Unpinned;
            container.SetDock(pinButton, eItemDock.Right); // Position pin button on right side
            container.SubItems.Add(pinButton);
            // Create button with file name and folder
            ButtonItem fileButton = new ButtonItem();
            fileButton.ForeColor = Color.Black;
            fileButton.ButtonStyle = eButtonStyle.ImageAndText;
            fileButton.ImagePosition = eImagePosition.Left;
            fileButton.Text = item.FileName + "<br/><font color=\"Gray\">" + item.Folder + "</font>";
            fileButton.Image = global::Einstein.Platform.Properties.Resources.Document;
            container.SubItems.Add(fileButton);

            return container;
        }

        private MruItem[] GetMruPlaces()
        {
            return new MruItem[3] {
                new MruItem("Documents",@"\\fileserver\Documents"),
                new MruItem("My Documents",@"c:\My Documents"),
                new MruItem("Transfer",@"\\droboshare\drobo\Transfer")
            };
        }
        private MruItem[] GetMruFiles()
        {
            return new MruItem[10] {
                new MruItem("Services Invoice 108.rtf",@"\\fileserver\Documents"),
                new MruItem("Services Invoice 109.rtf",@"\\fileserver\Documents"),
                new MruItem("Sales Report.rtf",@"\\fileserver\Documents"),
                new MruItem("Marketing Draft.rtf",@"c:\My Documents"),
                new MruItem("Compensation Report.rtf",@"c:\My Documents"),
                new MruItem("Jim Review.rtf",@"c:\My Documents"),
                new MruItem("Kathy Review.rtf",@"c:\My Documents"),
                new MruItem("Invoice10201.rtf",@"c:\My Documents"),
                new MruItem("Invoice10202.rtf",@"c:\My Documents"),
                new MruItem("Invoice10203.rtf",@"c:\My Documents")
            };
        }

        private class MruItem
        {
            public MruItem(string fileName, string folder)
            {
                FileName = fileName;
                Folder = folder;
            }
            public string FileName;
            public string Folder;
        }
        #endregion
        
	}
}

