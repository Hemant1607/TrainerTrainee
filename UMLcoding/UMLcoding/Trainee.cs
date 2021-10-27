using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLcoding
{
    class Trainee
    {
        public Trainer Trainer { get; set; }
        public List<Training> Trainings { get; set; } = new List<Training>();

        /*private string Name { get; set; }
        private string ID { get; set; }

        public void DisplayTrainee()
        {
            Console.WriteLine("Trainee Name:" + Name);
            Console.WriteLine("Trainee ID:" + ID);
        }*/
    }
}
