﻿using KryptonToolkitHub.Enumerations;
using System.IO;
using System.Windows.Forms;

namespace KryptonToolkitHub.Classes
{
    public class LaunchManager
    {
        #region Variables
        private IOOperations _io = new IOOperations();
        #endregion

        #region Constructor
        public LaunchManager()
        {

        }
        #endregion

        #region Methods

        #region Component Examples
        /// <summary>
        /// Launches the specified component example.
        /// </summary>
        /// <param name="componentExample">The component example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchComponentExample(ComponentToolkitExamples componentExample, ToolStripLabel statusLabel = null, bool useFullPath = false)
        {
            string statusText = null;

            switch (componentExample)
            {
                case ComponentToolkitExamples.KRYPTONBUTTON:
                    ProcessManager.LaunchProcess(@".\Krypton Button Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONCHECKBUTTON:
                    ProcessManager.LaunchProcess(@".\Krypton CheckButton Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONDROPBUTTON:
                    ProcessManager.LaunchProcess(@".\Krypton DropButton Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONCOLOURBUTTON:
                    ProcessManager.LaunchProcess(@".\Krypton ColorButton Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONCHECKSET:
                    ProcessManager.LaunchProcess(@".\Krypton CheckSet Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONCHECKBOX:
                    ProcessManager.LaunchProcess(@".\Krypton CheckBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONRADIOBUTTON:
                    ProcessManager.LaunchProcess(@".\Krypton RadioButton Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONLABEL:
                    ProcessManager.LaunchProcess(@".\Krypton Label Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONLINKLABEL:
                    ProcessManager.LaunchProcess(@".\Krypton Link Label Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONWRAPLABEL:
                    ProcessManager.LaunchProcess(@".\Krypton Wrap Label Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONSPLITCONTAINER:
                    ProcessManager.LaunchProcess(@".\Krypton Split Container Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONCONTEXTMENU:
                    ProcessManager.LaunchProcess(@".\Krypton Context Menu Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONTRACKBAR:
                    ProcessManager.LaunchProcess(@".\Krypton TrackBar Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONLISTBOX:
                    ProcessManager.LaunchProcess(@".\Krypton ListBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONCHECKEDLISTBOX:
                    ProcessManager.LaunchProcess(@".\Krypton Checked ListBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONTEXTBOX:
                    ProcessManager.LaunchProcess(@".\Krypton TextBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONMASKEDTEXTBOX:
                    ProcessManager.LaunchProcess(@".\Krypton Masked TextBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONRICHTEXTBOX:
                    ProcessManager.LaunchProcess(@".\Krypton Rich TextBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONCOMBOBOX:
                    ProcessManager.LaunchProcess(@".\Krypton ComboBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONNUMERICUPDOWN:
                    ProcessManager.LaunchProcess(@".\Krypton Numeric UpDown Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONDOMAINUPDOWN:
                    ProcessManager.LaunchProcess(@".\Krypton Domain UpDown Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONBREADCRUMB:
                    ProcessManager.LaunchProcess(@".\Krypton Bread Crumb Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONDATETIMEPICKER:
                    ProcessManager.LaunchProcess(@".\Krypton DateTimePicker Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONMONTHCALENDAR:
                    ProcessManager.LaunchProcess(@".\Krypton Month Calendar Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONDATAGRIDVIEW:
                    ProcessManager.LaunchProcess(@".\Krypton Data GridView Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONTREEVIEW:
                    ProcessManager.LaunchProcess(@".\Krypton TreeView Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONBORDEREDGE:
                    ProcessManager.LaunchProcess(@".\Krypton Border Edge Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONSEPARATOR:
                    ProcessManager.LaunchProcess(@".\Krypton Separator Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONPANEL:
                    ProcessManager.LaunchProcess(@".\Krypton Panel Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONGROUP:
                    ProcessManager.LaunchProcess(@".\Krypton Group Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONGROUPBOX:
                    ProcessManager.LaunchProcess(@".\Krypton GroupBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONHEADERGROUP:
                    ProcessManager.LaunchProcess(@".\Krypton Header Group Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONHEADER:
                    ProcessManager.LaunchProcess(@".\Krypton Header Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONPALETTE:
                    ProcessManager.LaunchProcess(@".\Krypton Palette Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONCOMMAND:
                    ProcessManager.LaunchProcess(@".\Krypton Command Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONINPUTBOX:
                    ProcessManager.LaunchProcess(@".\Krypton InputBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONMESSAGEBOX:
                    ProcessManager.LaunchProcess(@".\Krypton MessageBox Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONTASKDIALOG:
                    ProcessManager.LaunchProcess(@".\Krypton TaskDialog Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.KRYPTONFORM:
                    ProcessManager.LaunchProcess(@".\Krypton Form Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ComponentToolkitExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Application Toolkit Examples
        /// <summary>
        /// Launches the application toolkit example.
        /// </summary>
        /// <param name="applicationExample">The application example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchApplicationToolkitExample(ApplicationToolkitExamples applicationExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (applicationExample)
            {
                case ApplicationToolkitExamples.INPUTFORM:
                    ProcessManager.LaunchProcess(@".\Input Form Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.THREEPANEAPPLICATIONBASIC:
                    ProcessManager.LaunchProcess(@".\Three Pane Application Basic.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.THREEPANEAPPLICATIONEXTENDED:
                    ProcessManager.LaunchProcess(@".\Three Pane Application Extended.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.EXPANDINGHEADERGROUPSSPLITTERS:
                    ProcessManager.LaunchProcess(@".\Expanding Header Groups Splitters Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.EXPANDINGHEADERGROUPSDOCKSTYLE:
                    ProcessManager.LaunchProcess(@".\Expanding Header Groups DockStyle Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.EXPANDINGHEADERGROUPSSTACK:
                    ProcessManager.LaunchProcess(@".\Expanding Header Groups Stack Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.MDIAPPLICATION:
                    ProcessManager.LaunchProcess(@".\MDI Application.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.CHILDCONTROLSTACK:
                    ProcessManager.LaunchProcess(@".\Child Control Stack.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.BUTTONSPECPLAYGROUND:
                    ProcessManager.LaunchProcess(@".\Button Spec Playground.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.CUSTOMCONTROLUSINGPALETTES:
                    ProcessManager.LaunchProcess(@".\Custom Control Using Palettes.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.CUSTOMCONTROLUSINGRENDERERS:
                    ProcessManager.LaunchProcess(@".\Custom Control Using Renderers.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case ApplicationToolkitExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Test Application Toolkit Examples
        /// <summary>
        /// Launches the test application toolkit example.
        /// </summary>
        /// <param name="applicationToolkitExample">The application toolkit example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchTestApplicationToolkitExample(TestApplicationToolkitExamples applicationToolkitExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (applicationToolkitExample)
            {
                case TestApplicationToolkitExamples.KRYPTONTREEVIEW:
                    ProcessManager.LaunchProcess(@".\Krypton TreeView Examples.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case TestApplicationToolkitExamples.SYSTEMTHEMEDFORMS:
                    ProcessManager.LaunchProcess(@".\System Themed Forms.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case TestApplicationToolkitExamples.TESTCLIPBASE:
                    ProcessManager.LaunchProcess(@".\Test Clip Base.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case TestApplicationToolkitExamples.TESTMESSAGEBOXCLIPPING:
                    ProcessManager.LaunchProcess(@".\Test MessageBox Clipping.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case TestApplicationToolkitExamples.TESTTEXTCLIPPING:
                    ProcessManager.LaunchProcess(@".\Test Text Clipping.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case TestApplicationToolkitExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Docking Feature Examples
        /// <summary>
        /// Launches the docking feature examples.
        /// </summary>
        /// <param name="dockingFeatureExample">The docking feature example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchDockingFeatureExample(DockingFeatureExamples dockingFeatureExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (dockingFeatureExample)
            {
                case DockingFeatureExamples.DOCKINGCUSTOMISED:
                    ProcessManager.LaunchProcess(@".\Docking Customized.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case DockingFeatureExamples.DOCKINGPERSISTENCE:
                    ProcessManager.LaunchProcess(@".\Docking Persistence.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case DockingFeatureExamples.DOCKINGFLAGS:
                    ProcessManager.LaunchProcess(@".\Docking Flags.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case DockingFeatureExamples.MULTICONTROLDOCKING:
                    ProcessManager.LaunchProcess(@".\Multi Control Docking.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case DockingFeatureExamples.EXTERNALDRAGTODOCKING:
                    ProcessManager.LaunchProcess(@".\External Drag To Docking.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case DockingFeatureExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Docking Usage Examples
        /// <summary>
        /// Launches the docking usage examples.
        /// </summary>
        /// <param name="dockingUsageExample">The docking usage example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchDockingUsageExample(DockingUsageExamples dockingUsageExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (dockingUsageExample)
            {
                case DockingUsageExamples.STANDARDDOCKING:
                    ProcessManager.LaunchProcess(@".\Standard Docking.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case DockingUsageExamples.NAVICATORPLUSFLOATINGWINDOWS:
                    ProcessManager.LaunchProcess(@".\Navigator And Floating Windows.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case DockingUsageExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Workspace Feature Examples
        /// <summary>
        /// Launches the workspace feature examples.
        /// </summary>
        /// <param name="workspaceFeatureExample">The workspace feature example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchWorkspaceFeatureExample(WorkspaceFeatureExamples workspaceFeatureExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (workspaceFeatureExample)
            {
                case WorkspaceFeatureExamples.WORKSPACECELLMODES:
                    ProcessManager.LaunchProcess(@".\Workspace Cell Modes.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case WorkspaceFeatureExamples.WORKSPACECELLLAYOUT:
                    ProcessManager.LaunchProcess(@".\Workspace Cell Layout.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case WorkspaceFeatureExamples.WORKSPACEPERSISTENCE:
                    ProcessManager.LaunchProcess(@".\Workspace Persistence.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case WorkspaceFeatureExamples.CELLMAXIMISEPLUSRESTORE:
                    ProcessManager.LaunchProcess(@".\Cell Maximize And Restore.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case WorkspaceFeatureExamples.BASICPAGEDRAGANDDROP:
                    ProcessManager.LaunchProcess(@".\Basic Page Drag And Drop.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case WorkspaceFeatureExamples.ADVANCEDPAGEDRAGANDDROP:
                    ProcessManager.LaunchProcess(@".\Advanced Page Drag And Drop.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case WorkspaceFeatureExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Workspace Usage Examples
        /// <summary>
        /// Launches the workspace usage example.
        /// </summary>
        /// <param name="workspaceUsageExample">The workspace usage example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchWorkspaceUsageExample(WorkspaceUsageExamples workspaceUsageExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (workspaceUsageExample)
            {
                case WorkspaceUsageExamples.RIBBONPLUSNAVIGATORPLUSWORKSPACE:
                    ProcessManager.LaunchProcess(@".\Ribbon And Navigator And Workspace.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case WorkspaceUsageExamples.MEMOEDITOR:
                    ProcessManager.LaunchProcess(@".\Memo Editor.exe", useFullPath);

                    statusText = ProcessManager.GetProcessFilePath();

                    UpdateStatus(statusLabel, statusText);
                    break;
                case WorkspaceUsageExamples.READY:
                    UpdateStatus(statusLabel, "Ready", useFullPath);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Navigator Feature Examples
        /// <summary>
        /// Launches the navigator feature example.
        /// </summary>
        /// <param name="navigatorFeatureExample">The navigator feature example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchNavigatorFeatureExample(NavigatorFeatureExamples navigatorFeatureExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (navigatorFeatureExample)
            {
                case NavigatorFeatureExamples.NAVIGATORMODES:
                    break;
                case NavigatorFeatureExamples.NAVIGATORPALETTES:
                    break;
                case NavigatorFeatureExamples.OREINTATIONPLUSALIGNMENT:
                    break;
                case NavigatorFeatureExamples.SINGLELINEPLUSMULTILINE:
                    break;
                case NavigatorFeatureExamples.TABBORDERSTYLES:
                    break;
                case NavigatorFeatureExamples.POPUPPAGES:
                    break;
                case NavigatorFeatureExamples.PERTABBUTTONS:
                    break;
                case NavigatorFeatureExamples.NAVIGATORTOOLTIPS:
                    break;
                case NavigatorFeatureExamples.NAVIGATORCONTEXTMENUS:
                    break;
                case NavigatorFeatureExamples.NAVIGATORPLAYGROROUND:
                    break;
                case NavigatorFeatureExamples.BASICPAGEDRAGANDDROP:
                    break;
                case NavigatorFeatureExamples.ADVANCEDPAGEDRAGANDDROP:
                    break;
                case NavigatorFeatureExamples.BASICEVENTS:
                    break;
                case NavigatorFeatureExamples.READY:
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Navigator Usage Examples
        /// <summary>
        /// Launches the navigator usage example.
        /// </summary>
        /// <param name="navigatorUsageExample">The navigator usage example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchNavigatorUsageExample(NavigatorUsageExamples navigatorUsageExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (navigatorUsageExample)
            {
                case NavigatorUsageExamples.USERPAGECREATION:
                    break;
                case NavigatorUsageExamples.ONENOTETABS:
                    break;
                case NavigatorUsageExamples.OUTLOOKMOCKUP:
                    break;
                case NavigatorUsageExamples.RIBBONPLUSNAVIGATORPLUSWORKSPACE:
                    break;
                case NavigatorUsageExamples.EXPANDINGPAGES:
                    break;
                case NavigatorUsageExamples.NAVIGATORPLUSFLOATINGWINDOWS:
                    break;
                case NavigatorUsageExamples.READY:
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Ribbon Feature Examples
        /// <summary>
        /// Launches the ribbon feature example.
        /// </summary>
        /// <param name="ribbonFeatureExample">The ribbon feature example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchRibbonFeatureExample(RibbonFeatureExamples ribbonFeatureExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (ribbonFeatureExample)
            {
                case RibbonFeatureExamples.CONTEXTUALTABS:
                    break;
                case RibbonFeatureExamples.KEYTIPSPLUSKEYBOARDACCESS:
                    break;
                case RibbonFeatureExamples.AUTOSHRINKINGGROUPS:
                    break;
                case RibbonFeatureExamples.QUICKACCESSTOOLBAR:
                    break;
                case RibbonFeatureExamples.RIBBONTOOLTIPS:
                    break;
                case RibbonFeatureExamples.RIBBONCONTROLS:
                    break;
                case RibbonFeatureExamples.APPLICATIONMENU:
                    break;
                case RibbonFeatureExamples.KRYPTONGALLERYEXAMPLES:
                    break;
                case RibbonFeatureExamples.READY:
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Ribbon Usage Examples
        /// <summary>
        /// Launches the ribbon usage example.
        /// </summary>
        /// <param name="ribbonUsageExample">The ribbon usage example.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchRibbonUsageExample(RibbonUsageExamples ribbonUsageExample, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (ribbonUsageExample)
            {
                case RibbonUsageExamples.OUTLOOKMAILCLONE:
                    break;
                case RibbonUsageExamples.RIBBONPLUSNAVIGATORPLUSWORKSPACE:
                    break;
                case RibbonUsageExamples.MDIRIBBON:
                    break;
                case RibbonUsageExamples.MEMOEDITOR:
                    break;
                case RibbonUsageExamples.READY:
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Krypton Applications
        /// <summary>
        /// Launches the krypton application.
        /// </summary>
        /// <param name="kryptonApplication">The krypton application.</param>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="statusText">The status text.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchKryptonApplication(KryptonApplications kryptonApplication, ToolStripLabel statusLabel = null, string statusText = null, bool useFullPath = false)
        {
            switch (kryptonApplication)
            {
                case KryptonApplications.PALETTEDESIGNER:
                    break;
                case KryptonApplications.PALETTEUPGRADETOOL:
                    break;
                case KryptonApplications.READY:
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Status Update
        /// <summary>
        /// Updates the status.
        /// </summary>
        /// <param name="statusLabel">The status label.</param>
        /// <param name="processName">Name of the process.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        private static void UpdateStatus(ToolStripLabel statusLabel, string processName, bool useFullPath = false)
        {
            if (useFullPath)
            {
                statusLabel.Text = $"Attempting to launch: '{ Path.GetFullPath(processName) }'";
            }
            else if (processName == "Ready" || processName == "ready" || processName == "READY")
            {
                statusLabel.Text = "Ready";
            }
            else
            {
                statusLabel.Text = $"Attempting to launch: '{ processName }'";
            }
        }
        #endregion

        #endregion
    }
}