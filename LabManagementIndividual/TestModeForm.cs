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
        public TestModeForm()
        {
            InitializeComponent();
            foreach(Control c in testPanel.Controls)
            {
                if(c is Button)
                {
                    bs.Add((Button)c);
                }
            }
        }
    }
}
