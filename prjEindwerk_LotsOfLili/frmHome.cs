using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEindwerk_LotsOfLili
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();

            // ---Notes---
            //
            // multiple buttons to same eventhandler --> https://stackoverflow.com/questions/3814234/how-can-i-subscribe-multiple-buttons-to-the-same-event-handler-and-act-according
            //
            // ControlPaint.DrawBorder(e.Graphics, lblBeschrijving1.DisplayRectangle, Color.Black, ButtonBorderStyle.Solid); 
            // 
        }
    }
}
