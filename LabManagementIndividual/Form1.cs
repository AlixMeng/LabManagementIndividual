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
    public partial class Form1 : Form
    {
        public TestModeForm tMode;

        public Form1()
        {
            InitializeComponent();
            displayButtons();
            tMode = new TestModeForm();
            tMode.Show();
        }

        public  void displayButtons()
        {
            capacityBox.Text = "Computers: 21";
            printerBox.Text = "Printer: 1";
            projectorBox.Text = "Projector: 1";
            List<Button> buttonList = new List<Button>();
            foreach (Control c in panel1.Controls)
            {

                if (c is Button)
                {
                    
                    buttonList.Add((Button)c);
                }
            }
            
            int incre = 0;
       
            foreach (Button b in buttonList)
            {
                if (b.BackColor == Color.Lime)
                {
                    incre++;
                }
               
            }
            availableC.Text = "Available Computer: " + incre.ToString();

        }


        private void refreshB_Click(object sender, EventArgs e)
        {
            List<Button> nB = panel1.Controls.OfType<Button>().ToList();
            for (int i = 0; i < nB.Count; i++)
            {
                foreach(Computer c in tMode.aLab.computers)
                {
                    if (c.getComputerID().ToString().Equals(nB.ElementAt(i).Text))
                    {
                        if (c.getCompStatus())
                        {
                            nB.ElementAt(i).BackColor = Color.Lime;
                        }
                        else
                            nB.ElementAt(i).BackColor = Color.Red;
                    }
                }
            }
        }
    }
}
