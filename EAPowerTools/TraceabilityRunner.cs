﻿using System;
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

                EA.Collection elements = currentRepo.GetTreeSelectedElements();

                if (elements.Count > 0)
                {
                    EA.Element selectedElement = elements.GetAt(0);

                    results = this.GetTemplate();

                    getConnections(selectedElement, "initial");

                    currentRepo.RunModelSearch("", "", "", results.ToString());
                }
                else
                {
                    // Error Code Goes Here
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

            AddField(newRow, "From", source.Name);
            AddField(newRow,"FromType", source.Type);
            AddField(newRow,"To", destination.Name);
            AddField(newRow,"ToType", destination.Type);
            AddField(newRow,"Type", connector.Type);
            AddField(newRow,"Stereotype", connector.Stereotype);
            AddField(newRow,"Direction", connector.Direction);
            AddField(newRow,"Traversal", traversal);

            element.Add(newRow);
        }

        private void AddField(XElement row, String key, String value)
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
                        new XElement("Field", new XAttribute("name", "From")),
                        new XElement("Field", new XAttribute("name", "FromType")),
                        new XElement("Field", new XAttribute("name", "To")),
                        new XElement("Field", new XAttribute("name", "ToType")),
                        new XElement("Field", new XAttribute("name", "Type")),
                        new XElement("Field", new XAttribute("name", "Stereotype")),
                        new XElement("Field", new XAttribute("name", "Direction")),
                        new XElement("Field", new XAttribute("name", "Traversal"))
                    ),
                    new XElement("Rows")
                )
            );

            return doc;
        }
    }
}