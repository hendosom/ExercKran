using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercKran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Kran-Arm und Haken ein- und ausfahren

        private void CmdHookHoch_Click(object sender, EventArgs e)
        {
            PnlHook.Size = new Size(PnlHook.Size.Width, PnlHook.Size.Height - geschwindigkeit);
        }

        private void CmdHookRunter_Click(object sender, EventArgs e)
        {
            PnlHook.Size = new Size(PnlHook.Size.Width, PnlHook.Size.Height + geschwindigkeit);
        }

        private void CmdArmRaus_Click(object sender, EventArgs e)
        {
            PnlArm.Location = new Point(PnlArm.Location.X - geschwindigkeit, PnlArm.Location.Y);
            PnlHook.Location = PnlArm.Location;
            PnlArm.Size = new Size(PnlArm.Size.Width + geschwindigkeit, PnlArm.Size.Height);
        }

        private void CmdArmEinfahren_Click(object sender, EventArgs e)
        {
            PnlArm.Location = new Point(PnlArm.Location.X + geschwindigkeit, PnlArm.Location.Y);
            PnlHook.Location = PnlArm.Location;
            PnlArm.Size = new Size(PnlArm.Size.Width - geschwindigkeit, PnlArm.Size.Height);
            
        }


        // Geschwindigkeit, mit der sich die Komponenten bewegen, per Textfeld-Eingabe festlegen

        int geschwindigkeit = 10;
        

        private void TxtBoxEingabeGeschw_TextChanged(object sender, EventArgs e)
        {
            
            geschwindigkeit = Convert.ToInt32(TxtBoxEingabeGeschw.Text);
            
        }
    }
}
