using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("После школы");
        }

        public override void GetDiploma()
        {
            Console.WriteLine("Диплом бакалавра");
        }

        public override void PassExam()
        {
            Console.WriteLine("Гос экзамены");
        }
    }
}
