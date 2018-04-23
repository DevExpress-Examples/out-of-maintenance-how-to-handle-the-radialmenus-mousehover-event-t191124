using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace WindowsFormsApplication4 {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void btnShowRadialMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Point pt = GetMenuLocation();
            myRadialMenu1.ShowPopup(pt);
        }
        private Point GetMenuLocation() {
            Point pt = new Point();
            pt.X = Location.X + Size.Width / 2;
            pt.Y = Location.Y + Size.Height / 2;
            return pt;
        }
    }
}
