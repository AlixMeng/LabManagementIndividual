using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagementIndividual
{
    public class Lab
    {
        public List<Computer> computers;
        bool projector;
        bool printer;

        public Lab(List<Computer> cs, bool proj, bool pri)
        {
            computers = cs;
            projector = proj;
            printer = pri;
        }
    }
}
