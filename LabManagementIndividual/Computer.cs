using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagementIndividual
{
    public class Computer
    {
        private int computerID;
        private string type;
        private bool compStatus;

        public Computer(int cid, string t, bool cs)
        {
            computerID = cid;
            type = t;
            compStatus = cs;
        }

        public int getComputerID()
        {
            return computerID;
        }

        public string getComputerType()
        {
            return type;
        }

        public bool getCompStatus()
        {
            return compStatus;  
        }

        public void setCompStatus(bool s)
        {
            compStatus = s;
        }
    }
}
