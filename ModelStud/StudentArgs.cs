using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ModelStud
{
    public class StudentArgs: EventArgs
    {
        public Student student { get; set; }
        public StudentArgs(Student student)
        {
            this.student = student;
        }   
    }
}