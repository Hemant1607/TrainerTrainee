using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLcoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Organization org = new Organization();
            org.name = "ABC Organization";

            Trainer trainer = new Trainer();
            trainer.Organization = org;

            Trainee t1 = new Trainee();
            t1.Trainer = trainer;
            Trainee t2 = new Trainee();
            t2.Trainer = trainer;
            Trainee t3 = new Trainee();
            t3.Trainer = trainer;
            Trainee t4 = new Trainee();
            t4.Trainer = trainer;

            trainer.Trainees.Add(t1);
            trainer.Trainees.Add(t2);
            trainer.Trainees.Add(t3);
            trainer.Trainees.Add(t4);

            Course course = new Course();
            Training training = new Training();

            training.Trainer = trainer;
            training.Course = course;

            training.Trainees.Add(t1);
            training.Trainees.Add(t2);
            training.Trainees.Add(t3);
            training.Trainees.Add(t4);

            Module m1 = new Module();
            Module m2 = new Module();
            Module m3 = new Module();
            Module m4 = new Module();

            course.Modules.Add(m1);
            course.Modules.Add(m2);
            course.Modules.Add(m3);
            course.Modules.Add(m4);

            Unit u1 = new Unit();
            u1.durationinHrs = 1;
            Unit u2 = new Unit();
            u2.durationinHrs = 2;
            Unit u3 = new Unit();
            u3.durationinHrs = 1;
            Unit u4 = new Unit();
            u4.durationinHrs = 3;
            Unit u5 = new Unit();
            u5.durationinHrs = 2;
            Unit u6 = new Unit();
            u6.durationinHrs = 4;
            Unit u7 = new Unit();
            u7.durationinHrs = 5;
            Unit u8 = new Unit();
            u8.durationinHrs = 3;

            m1.Units.Add(u1);
            m1.Units.Add(u3);
            m1.Units.Add(u4);

            m2.Units.Add(u5);
            m2.Units.Add(u8);

            m3.Units.Add(u6);
            m3.Units.Add(u2);

            m4.Units.Add(u7);

            Topic topic1 = new Topic();
            topic1.name = "First Topic";
            Topic topic2 = new Topic();
            topic2.name = "Second Topic";
            Topic topic3 = new Topic();
            topic3.name = "Third Topic";
            Topic topic4 = new Topic();
            topic4.name = "Fourth Topic";
            Topic topic5 = new Topic();
            topic5.name = "Fifth Topic";
            Topic topic6 = new Topic();
            topic6.name = "Sixth Topic";
            Topic topic7 = new Topic();
            topic7.name = "Seventh Topic";
            Topic topic8 = new Topic();
            topic8.name = "Eighth Topic";

            u1.Topics.Add(topic1);
            u2.Topics.Add(topic2);
            u3.Topics.Add(topic3);
            u4.Topics.Add(topic4);
            u5.Topics.Add(topic5);
            u6.Topics.Add(topic6);
            u7.Topics.Add(topic7);
            u8.Topics.Add(topic8);

            Console.WriteLine("Number of trainees:" + training.getNumOfTrainees());
            Console.WriteLine("Training Organization Name:" + training.getOrganizationName());
            Console.WriteLine("Total Duration of Training:" + training.GetTrainingDurationInHrs());

            Console.ReadLine();
        }


    }

 
}
