using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class Education
    {
        // паттерн исключает дублирующий код у наследников класса, если они будут строиться по похожему принципу
        public abstract void Enter();
        public abstract void PassExam();
        public abstract void GetDiploma();
        public void Learn()
        {
            Enter();
            PassExam();
            GetDiploma();
        }
    }
}
