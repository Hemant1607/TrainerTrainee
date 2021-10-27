using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLcoding
{
    class Training
    {
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();

        public Trainer Trainer { get; set; }
        public Course Course { get; set; }

        public int getNumOfTrainees()
        {
            return Trainees.Count;
        }

        public string getOrganizationName()
        {
            return Trainer.Organization.name;
        }

        public int GetTrainingDurationInHrs()
        {
            int TotalDuration = 0;
            foreach (var Module in Course.Modules)
            {
                foreach (var Unit in Module.Units)
                {
                    TotalDuration += Unit.durationinHrs;
                }
            }

            return TotalDuration;
        }
    }
}
