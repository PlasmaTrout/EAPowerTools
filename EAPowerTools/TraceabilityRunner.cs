using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EAPowerTools
{
    class TraceabilityRunner
    {
        private EA.Repository currentRepo;
        Dictionary<string, int> completionDictionary = new Dictionary<string, int>();
        XDocument results;

        public TraceabilityRunner(EA.Repository repository)
        {
            this.currentRepo = repository;
        }

        public void RunReportOnSelectedPBItem()
        {
            if(currentRepo != null)
            {
                currentRepo.EnsureOutputVisible("EAPowerTools");
                currentRepo.ClearOutput("EAPowerTools");

                results = this.GetTemplate();

                EA.Collection elements = currentRepo.GetTreeSelectedElements();
               
                if (elements.Count > 0)
                {
                    EA.Element selectedElement = elements.GetAt(0);

                    getConnections(selectedElement, "initial");

                    currentRepo.RunModelSearch("", "", "", results.ToString());
                }
                else
                {
                    EA.Diagram diagram = currentRepo.GetCurrentDiagram();
                    if(diagram != null)
                    {
                        EA.DiagramObject s = diagram.SelectedObjects.GetAt(0);
                        EA.Element selectedElement = currentRepo.GetElementByID(s.ElementID);
                        
                        if(selectedElement != null)
                        {
                            getConnections(selectedElement, "initial");

                            currentRepo.RunModelSearch("", "", "", results.ToString());
                        }
                    }
                }

               
            }
        }

        private void getConnections(EA.Element element, string traversal)
        {

            EA.Collection connectors = element.Connectors;

            for(short i=0; i < connectors.Count; i++)
            {
                EA.Connector connector = connectors.GetAt(i);
                EA.Element target = currentRepo.GetElementByID(connector.SupplierID);
                EA.Element source = currentRepo.GetElementByID(connector.ClientID);
                String key = target.Name + ":" + source.Name;

                if (completionDictionary.ContainsKey(key))
                {
                    completionDictionary[key] = completionDictionary[key] + 1;
                }
                else
                {
                    completionDictionary.Add(key, 1);
                    AddRow(source, target, traversal, connector);
                    getConnections(target, "forwards");
                    getConnections(source, "backwards");
                }
            }
        }

        private void AddRow(EA.Element source, EA.Element destination, string traversal, EA.Connector connector)
        {
            XElement element = results.Root.Element("Rows");
            XElement newRow = new XElement("Row");

            AddField(newRow, "CLASSGUID", source.ElementGUID);
            AddField(newRow, "CLASSTYPE", source.Type);
            AddField(newRow, "From", source.Name);
            AddField(newRow, "Object_Type", source.Type);
            AddField(newRow,"To", destination.Name);
            AddField(newRow,"To_Object_Type", destination.Type);
            AddField(newRow,"Type", connector.Type);
            AddField(newRow,"Stereotype", connector.Stereotype);
            AddField(newRow,"Direction", connector.Direction);
            AddField(newRow,"Traversal", traversal);
            AddField(newRow, "Object_ID", source.ElementID);

            element.Add(newRow);
        }

        private void AddField(XElement row, String key, Object value)
        {
            XElement field = new XElement("Field");
            field.Add(new XAttribute("name",key));
            field.Add(new XAttribute("value", value));
            row.Add(field);
        }

        private XDocument GetTemplate()
        {
            XDocument doc = new XDocument(
                new XElement("ReportViewData",
                    new XAttribute("UID","TraceabilityReport"),
                    new XElement("Fields",
                        new XElement("Field", new XAttribute("name", "CLASSGUID")),
                        new XElement("Field", new XAttribute("name", "CLASSTYPE")),
                        new XElement("Field", new XAttribute("name", "From")),
                        new XElement("Field", new XAttribute("name", "Object_Type")),
                        new XElement("Field", new XAttribute("name", "To")),
                        new XElement("Field", new XAttribute("name", "To_Object_Type")),
                        new XElement("Field", new XAttribute("name", "Type")),
                        new XElement("Field", new XAttribute("name", "Stereotype")),
                        new XElement("Field", new XAttribute("name", "Direction")),
                        new XElement("Field", new XAttribute("name", "Traversal")),
                       new XElement("Field", new XAttribute("name", "Object_ID"))
                    ),
                    new XElement("Rows")
                )
            );

            return doc;
        }
    }
}
