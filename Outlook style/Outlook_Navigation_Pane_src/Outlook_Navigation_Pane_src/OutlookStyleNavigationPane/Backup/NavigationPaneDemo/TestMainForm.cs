using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

using MT.WindowsUI;
using MT.WindowsUI.NavigationPane;


namespace NavigationPaneDemo
{
    public partial class TestMainForm : Form
    {

        #region Var
        // NavigateBar

        ContainerControl containerControlProp = null;
        NavigateBarRemoteControl nbRemoteControl;

        NavigateBar outlookNavigatePane;
        NavigateBarButton nvbMail;
        NavigateBarButton nvbCalendar;
        NavigateBarButton nvbContacts;
        NavigateBarButton nvbTasks;
        NavigateBarButton nvbNotes;
        NavigateBarButton nvbFolderList;
        NavigateBarButton nvbShortCuts;
        NavigateBarButton nvbDiary;

        // Form

        MTSplitter splitterNavigateMenu = null;

        // ToolStrip

        ToolStrip toolStrip = null;
        ToolStripButton tbtnMDIChildForm;
        ToolStripButton tbtnAbout;
        ToolStripButton tbtnExit;

        // StatusStrip

        StatusStrip statusStrip = null;

        // MenuStrip

        MenuStrip menuStrip = null;

        ToolStripMenuItem mnExit;
        ToolStripMenuItem mnProgram;

        #endregion

        public static Form MainForm;
        public TestMainForm()
        {
            MainForm = this;

            InitializeComponent();
            //
            InitNavigateBar();
            //
            InitPullMenu();

        }

        public void InitNavigateBar()
        {

            // For automatically save (Save %APPDATA%<exe filename> folder )
            //outlookNavigatePane = new NavigateBar();
            //outlookNavigatePane.SaveAndRestoreSettings = true; 

            // For custom save
            outlookNavigatePane = new NavigateBar(Environment.CurrentDirectory + @"\NavigateBarSettings.xml");
            outlookNavigatePane.Dock = DockStyle.Left;
            outlookNavigatePane.IsShowCollapsibleScreen = true;
            outlookNavigatePane.CollapsedScreenWidth = 150; // For all buttons // Optional
            outlookNavigatePane.CollapsibleWidth = 32;
            outlookNavigatePane.OnNavigateBarDisplayedButtonCountChanged += new NavigateBar.OnNavigateBarDisplayedButtonCountChangedEventHandler(NavigationPane_OnNavigateBarDisplayedButtonCountChanged);
            outlookNavigatePane.OnNavigateBarButtonSelected += new NavigateBar.OnNavigateBarButtonEventHandler(outlookNavigatePane_OnNavigateBarButtonSelected);
            outlookNavigatePane.OnNavigateBarButtonSelecting += new NavigateBar.OnNavigateBarButtonSelectingEventHandler(outlookNavigatePane_OnNavigateBarButtonSelecting);

            outlookNavigatePane.OnNavigateBarColorChanged += new EventHandler(outlookNavigatePane_OnNavigateBarColorChanged);
            outlookNavigatePane.HandleCreated += new EventHandler(outlookNavigatePane_HandleCreated);
            outlookNavigatePane.RightToLeftChanged += new EventHandler(outlookNavigatePane_RightToLeftChanged);
            outlookNavigatePane.Width = 150;

            #region Optional features
            //outlookNavigatePane.RelatedControl = new MailTree(); // If Button.RelatedControl is empty then display this control
            //outlookNavigatePane.NavigateBarDisplayedButtonCount = 5; // Max display 5 button in panel
            //outlookNavigatePane.AlwaysUseSystemColors = true;
            #endregion

            #region NavigateBar Buttons

            nvbMail = new NavigateBarButton();
            nvbMail.RelatedControl = new MailTree();
            nvbMail.Caption = "Mail";
            nvbMail.CaptionDescription = "Mail Folders";
            nvbMail.Image = Properties.Resources.Mail24;
            nvbMail.Enabled = true;
            nvbMail.Key = "MAIL";
            nvbMail.IsShowCaptionImage = false;
            nvbMail.OnNavigateBarButtonSelected += new NavigateBarButton.OnNavigateBarButtonSelectedEventHandler(nvbMail_OnNavigateBarButtonSelected);

            Calendar clndr = new Calendar();
            clndr.BackColor = Color.Red;
            nvbCalendar = new NavigateBarButton(clndr);
            nvbCalendar.Caption = "Calendar";
            nvbCalendar.IsShowCaption = true;
            nvbCalendar.IsShowCaptionDescription = false;
            nvbCalendar.Image = Properties.Resources.Calendar24;
            //nvbCalendar.Font = new Font("Tahoma", 12, FontStyle.Italic | FontStyle.Bold);
            nvbCalendar.ForeColor = Color.Red; // move on ColorTable
            nvbCalendar.Key = "CALENDAR";
            nvbCalendar.IsShowCaptionImage = false;
            nvbCalendar.CollapsedScreenWidth = 195;
            nvbCalendar.IsShowCollapseScreenCaption = false; // Hide collapse screen caption band

            DataGridView dgv = new DataGridView();

            nvbContacts = new NavigateBarButton();
            nvbContacts.Caption = "Contacts";
            nvbContacts.CaptionDescription = "My Friends";
            nvbContacts.Image = Properties.Resources.Contacts24;
            nvbContacts.RelatedControl = dgv;
            nvbContacts.IsShowCaption = false;
            nvbContacts.IsShowCaptionDescription = true;
            nvbContacts.Key = "CONTACTS";
            nvbContacts.IsAlwaysDisplayed = true; // Always show in panel
            nvbContacts.CollapsedScreenWidth = 240; // For Contacts button

            nvbTasks = new NavigateBarButton(new RichTextBox());
            nvbTasks.Caption = "Tasks";
            nvbTasks.CaptionDescription = "My Tasks";
            nvbTasks.Image = Properties.Resources.Tasks24;
            nvbTasks.MouseOverImage = Properties.Resources.Contacts24;
            nvbTasks.SelectedImage = Properties.Resources.Mail24;
            nvbTasks.ToolTipText = "ToolTipText for tasks";
            //nvbTasks.Enabled = false;
            nvbTasks.IsShowCaption = false;
            nvbTasks.IsShowCaptionDescription = false;
            nvbTasks.Key = "TASKS";

            nvbNotes = new NavigateBarButton("Notes", Properties.Resources.Notes24);
            nvbNotes.Key = "NOTES";

            nvbFolderList = new NavigateBarButton("Folder List", Properties.Resources.FolderList24);
            nvbFolderList.Key = "FOLDERLIST";

            nvbShortCuts = new NavigateBarButton("Shortcuts", Properties.Resources.Shortcut24);
            nvbShortCuts.Key = "SHORTCUT";

            nvbDiary = new NavigateBarButton("Diary", Properties.Resources.Diary24);
            nvbDiary.Key = "DIARY";

            outlookNavigatePane.NavigateBarButtons.AddRange(new NavigateBarButton[] { nvbMail, nvbCalendar, nvbContacts });
            outlookNavigatePane.NavigateBarButtons.Add(nvbTasks);
            outlookNavigatePane.NavigateBarButtons.Add(nvbNotes);
            outlookNavigatePane.NavigateBarButtons.Add(nvbFolderList);
            outlookNavigatePane.NavigateBarButtons.Add(nvbShortCuts);
            outlookNavigatePane.NavigateBarButtons.Add(nvbDiary);
            #endregion

            #region Strips

            // ToolStrip
            toolStrip = new ToolStrip();
            toolStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;

            tbtnMDIChildForm = new ToolStripButton();
            tbtnMDIChildForm.Text = "MDI Child";
            tbtnMDIChildForm.Click += new EventHandler(tbtnMDIChildForm_Click);

            tbtnAbout = new ToolStripButton();
            tbtnAbout.Text = "About";
            tbtnAbout.Click += delegate(object sender, EventArgs e)
                {

                    Type typ = typeof(TestMainForm);

                    object[] r = typ.Assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                    AssemblyCopyrightAttribute ct = (AssemblyCopyrightAttribute)r[0];

                    object[] d = typ.Assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                    AssemblyDescriptionAttribute dt = (AssemblyDescriptionAttribute)d[0];

                    object[] v = typ.Assembly.GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false);
                    AssemblyFileVersionAttribute vt = (AssemblyFileVersionAttribute)v[0];

                    MessageBox.Show(ct.Copyright + "\n\n" + dt.Description + "\n\n" + "Version : " + vt.Version);

                };


            tbtnExit = new ToolStripButton();
            tbtnExit.Text = "Exit";
            tbtnExit.Click += delegate(object sender, EventArgs e)
            {
                this.Close();
            };

            toolStrip.Items.Add(tbtnMDIChildForm);
            toolStrip.Items.Add(new ToolStripSeparator());
            toolStrip.Items.Add(tbtnAbout);
            toolStrip.Items.Add(tbtnExit);


            // MenuStrip

            menuStrip = new MenuStrip();
            menuStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            menuStrip.Dock = DockStyle.Top;
            MainMenuStrip = menuStrip;

            // StatusStrip

            statusStrip = new StatusStrip();
            statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;

            #endregion

            // Splitter

            splitterNavigateMenu = new MTSplitter();
            splitterNavigateMenu.Size = new Size(7, 100);
            splitterNavigateMenu.SplitterPointCount = 10;
            splitterNavigateMenu.SplitterPaintAngle = 360F;

            splitterNavigateMenu.Dock = DockStyle.Left;

            // Navigatebar Remote Control

            nbRemoteControl = new NavigateBarRemoteControl(outlookNavigatePane);
            nbRemoteControl.Dock = DockStyle.Fill;

            containerControlProp = new ContainerControl();
            containerControlProp.Width = nbRemoteControl.Width;

            containerControlProp.Controls.Add(nbRemoteControl);
            containerControlProp.Dock = DockStyle.Right;


            Controls.AddRange(new Control[] { splitterNavigateMenu, outlookNavigatePane, containerControlProp, toolStrip, statusStrip, menuStrip });

        }

        /// <summary>
        /// Changed rtl state, redock controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void outlookNavigatePane_RightToLeftChanged(object sender, EventArgs e)
        {
            if (outlookNavigatePane.RightToLeft == RightToLeft.Yes)
            {
                containerControlProp.Dock = DockStyle.Left;
                outlookNavigatePane.Dock = DockStyle.Right;
                splitterNavigateMenu.Dock = DockStyle.Right;
            }
            else
            {
                containerControlProp.Dock = DockStyle.Right;
                outlookNavigatePane.Dock = DockStyle.Left;
                splitterNavigateMenu.Dock = DockStyle.Left;
            }
        }

        /// <summary>
        /// Pane colortable changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void outlookNavigatePane_OnNavigateBarColorChanged(object sender, EventArgs e)
        {
            splitterNavigateMenu.SplitterLightColor = outlookNavigatePane.NavigateBarColorTable.ButtonNormalBegin;
            splitterNavigateMenu.SplitterDarkColor = outlookNavigatePane.NavigateBarColorTable.ButtonNormalEnd;
            splitterNavigateMenu.SplitterBorderColor = Color.Transparent;
        }

        /// <summary>
        /// Set new color (passing saved color table in settings file )
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void outlookNavigatePane_HandleCreated(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Do you want use system colors", "Theme Color", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    outlookNavigatePane.NavigateBarColorTable = NavigateBarColorTable.SystemColor;
        }


        /// <summary>
        /// Any button selected
        /// </summary>
        /// <param name="tNavigateBarButton"></param>
        void outlookNavigatePane_OnNavigateBarButtonSelected(NavigateBarButton tNavigateBarButton)
        {
            if (outlookNavigatePane == null || nbRemoteControl == null)
                return;
            nbRemoteControl.nudPosition.Value = outlookNavigatePane.NavigateBarButtons.IndexOf(tNavigateBarButton);

            if (outlookNavigatePane.SelectedButton != null)
                this.Text = outlookNavigatePane.SelectedButton.Caption;
        }

        /// <summary>
        /// Check selecting for any button
        /// </summary>
        /// <param name="e"></param>
        void outlookNavigatePane_OnNavigateBarButtonSelecting(NavigateBarButtonCancelEventArgs e)
        {
            // Calendar control
            if (e.Selected.Equals(nvbCalendar) && !this.DesignMode)
            {
                if (MessageBox.Show("Select " + e.Selected.Caption + " button ", "Select", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }

        /// <summary>
        /// Mail button selected
        /// </summary>
        /// <param name="e"></param>
        void nvbMail_OnNavigateBarButtonSelected(NavigateBarButtonEventArgs e)
        {
            this.Text = "Mail button pressed";
        }

        /// <summary>
        /// Displayed button count changed in pane
        /// </summary>
        void NavigationPane_OnNavigateBarDisplayedButtonCountChanged()
        {
            nbRemoteControl.nudButtonCount.Value = outlookNavigatePane.DisplayedButtonCount;
        }


        #region Strips Events & Methods
        void tbtnMDIChildForm_Click(object sender, EventArgs e)
        {
            TestMDIChildForm frm = new TestMDIChildForm();
            frm.MdiParent = this;
            frm.Show();
        }

        void InitPullMenu()
        {

            mnProgram = new ToolStripMenuItem("Program");

            mnExit = new ToolStripMenuItem("Exit");
            mnExit.Click += new EventHandler(mnExit_Click);

            mnProgram.DropDownItems.Add(mnExit);

            menuStrip.Items.Add(mnProgram);

        }

        void mnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}