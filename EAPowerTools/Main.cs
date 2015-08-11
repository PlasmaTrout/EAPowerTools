using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EA;

namespace EAPowerTools
{
    public class Main : EAAddinFramework.EAAddinBase
    {
        private const string BASE_MENU = "-&EA Power Tools";
        private const string NEWLINE_MENU_ITEM = "Remove Newlines From Notes";
        private const string TRACE_MENU_ITEM = "Traceability Report";
        private const string POWER_EDITOR = "Power Editor";
        private const string MARKDOWN_EDITOR = "Markdown Notes";
        private const string MARKDOWN_DOCKED = "Show Markdown Addin Window";

        PowerEditorControl control;
        MarkdownNotesControl mdownControl;
        MarkdownDockedViewer mdownDocked;

        public override String EA_Connect(EA.Repository repository)
        {
            return "Connection To PowerTools Complete!";
        }

        /// <summary>
        /// This is what sets up the main menu items that show up under extensions. Basically each
        /// addin executes this method a few times the first being an empty string. This allows you
        /// to add the base menu name to the list. Then catch it on subsequent times around.
        /// </summary>
        /// <param name="repository">The EA Repository currently open</param>
        /// <param name="location"></param>
        /// <param name="menuName">The menu item that is currently being loaded</param>
        /// <returns></returns>
        public override object EA_GetMenuItems(EA.Repository repository,string location, string menuName)
        {
            switch (menuName)
            {
                case "":
                    return BASE_MENU;
                case BASE_MENU:
                    string[] items = { TRACE_MENU_ITEM, POWER_EDITOR, MARKDOWN_EDITOR, MARKDOWN_DOCKED };
                    return items;
            }

            return "";
        }


        public override void EA_GetMenuState(EA.Repository Repository, string Location, string MenuName, string ItemName, ref bool IsEnabled, ref bool IsChecked)
        {
            if (IsProjectOpen(Repository))
            {
                IsEnabled = true;
            }
            else
                // If no open project, disable all menu options
                IsEnabled = false;
        }

        public override void EA_MenuClick(EA.Repository Repository, string Location, string MenuName, string ItemName)
        {
            switch (ItemName)
            {
                case NEWLINE_MENU_ITEM:
                    NotesCleaner cleaner = new NotesCleaner(Repository);
                    cleaner.CleanUpNotesAndSave();
                    break;
                case TRACE_MENU_ITEM:
                    TraceabilityRunner runner = new TraceabilityRunner(Repository);
                    runner.RunReportOnSelectedPBItem();
                    break;
                case MARKDOWN_EDITOR:
                    mdownControl = (MarkdownNotesControl)Repository.AddTab("Markdown Editor", "EAPowerTools.MarkdownNotesControl");
                    mdownControl.LoadFromRepository(Repository);
                    break;
                case MARKDOWN_DOCKED:
                    mdownDocked = (MarkdownDockedViewer)Repository.AddWindow("Markdown Notes", "EAPowerTools.MarkdownDockedViewer");
                    mdownDocked.SetRepo(Repository);
                    break;
                case POWER_EDITOR:
                    control = (PowerEditorControl) Repository.AddTab("Power Editor", "EAPowerTools.PowerEditorControl");
                    control.LoadNotes(Repository);
                    break;
            }
        }

        protected override bool IsProjectOpen(EA.Repository repository)
        {
            try
            {
                EA.Collection c = repository.Models;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override void EA_OnContextItemChanged(Repository Repository, string GUID, ObjectType ot)
        {
            Repository.EnsureOutputVisible("System");

            if (ot == ObjectType.otElement)
            {
                Repository.WriteOutput("System", "Element Changed!", 1);
                if(mdownDocked != null)
                {
                    mdownDocked.RefreshWebBrowser();
                }

                if(mdownControl != null)
                {
                    mdownControl.LoadFromRepository(Repository);
                    mdownControl.UpdateWebBrowser();
                }

                if(control != null)
                {
                    control.LoadNotes(Repository);
                }
            }

            base.EA_OnContextItemChanged(Repository, GUID, ot);
        }
    }
}
