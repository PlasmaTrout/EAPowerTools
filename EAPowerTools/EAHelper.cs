using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAPowerTools
{
    class EAHelper
    {
        /// <summary>
        /// Selected items in the project browser are processed differently than selected elements
        /// in the visible diagram. This helper will grab the currently selected project browser item first.
        /// If it doesn't find it, it will return the currently selected diagram item.
        /// </summary>
        /// <param name="repository">The currently open EA repository</param>
        /// <returns>The element currently selected in either the project browser or diagram</returns>
        public static EA.Element GetCurrentElement(EA.Repository repository)
        {
            EA.Element result = null;

            EA.Collection elements = repository.GetTreeSelectedElements();

            if (elements.Count > 0)
            {
                result = elements.GetAt(0); 
            }
            else
            {
                EA.Diagram diagram = repository.GetCurrentDiagram();
                if (diagram != null)
                {
                    EA.DiagramObject s = diagram.SelectedObjects.GetAt(0);
                    result = repository.GetElementByID(s.ElementID);
                }
            }

            return result;
        }

        
    }
}
