using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("после садика");
        }

        public override void GetDiploma()
        {
            Console.WriteLine("Аттестат");
        }

        public override void PassExam()
        {
            Console.WriteLine("ЕГЭЭЭЭ");
        }
    }
}
