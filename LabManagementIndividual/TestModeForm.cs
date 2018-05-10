using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManagementIndividual
{
    public partial class TestModeForm : Form

    {
        public List<Button> bs = new List<Button>();
        List<Computer> cList = new List<Computer>();
        public Lab aLab;
        public TestModeForm()
        {
            InitializeComponent();
            //create computers
            foreach(Button b in this.testPanel.Controls.OfType<Button>().ToList())
            {
                bs.Add(b);
                Computer c = new Computer(int.Parse(b.Text), "win", true);
                cList.Add(c);
            }
            aLab = new Lab(cList, true, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Computer c in aLab.computers)
            {
                if((sender as Button).Text.Equals(c.getComputerID().ToString()))
                {
                    if (c.getCompStatus())
                    {
                        (sender as Button).BackColor = Color.Red;
                        c.setCompStatus(false);
                    }
                    else
                    {
                        (sender as Button).BackColor = Color.Lime;
                        c.setCompStatus(true);
                    }
                }
            }
        }
    }
}
