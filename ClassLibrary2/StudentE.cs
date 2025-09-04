using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    public class StudentE
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Examination> Examinations { get; set; }
    }
}
