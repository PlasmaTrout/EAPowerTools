using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAPowerTools
{
    public class Main
    {
        private const String BASE_MENU = "-&EA Power Tools";
        private const String NEWLINE_MENU_ITEM = "Remove Newlines From Notes";
        private const String TRACE_MENU_ITEM = "Traceability Report";

        public String EA_Connect(EA.Repository repository)
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
        public object EA_GetMenuItems(EA.Repository repository,string location, string menuName)
        {
            switch (menuName)
            {
                case "":
                    return BASE_MENU;
                case BASE_MENU:
                    string[] items = { NEWLINE_MENU_ITEM, TRACE_MENU_ITEM };
                    return items;
            }

            return "";
        }


        public void EA_GetMenuState(EA.Repository Repository, string Location, string MenuName, string ItemName, ref bool IsEnabled, ref bool IsChecked)
        {
            if (IsProjectOpen(Repository))
            {
                IsEnabled = true;
            }
            else
                // If no open project, disable all menu options
                IsEnabled = false;
        }

        public void EA_MenuClick(EA.Repository Repository, string Location, string MenuName, string ItemName)
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
            }
        }

        bool IsProjectOpen(EA.Repository repository)
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
    }
}
