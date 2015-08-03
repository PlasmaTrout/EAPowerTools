using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAPowerTools
{
    class NotesCleaner
    {
        private EA.Repository currentRepo;

        public NotesCleaner(EA.Repository repository)
        {
            this.currentRepo = repository;
        }

        public void CleanUpNotesAndSave()
        {
            if(currentRepo != null)
            {
                EA.Collection items =  currentRepo.GetTreeSelectedElements();
                for(short i=0; i < items.Count; i++)
                {
                    EA.Element element = items.GetAt(i);
                    element.Notes = element.Notes.Replace(Environment.NewLine, " ");
                    element.Update();
                }
            }
        }
    }
}
