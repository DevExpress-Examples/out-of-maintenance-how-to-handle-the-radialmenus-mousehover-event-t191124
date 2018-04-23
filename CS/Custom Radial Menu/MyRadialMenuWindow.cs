using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraBars.Ribbon;
using System.Windows.Forms;
using DevExpress.Utils;

namespace WindowsFormsApplication4 {
    public class MyRadialMenuWindow : RadialMenuWindow {
        public MyRadialMenuWindow(RadialMenu menu)
            : base(menu) {
        }
        protected override void OnMouseMove(MouseEventArgs e) {
            base.OnMouseMove(e);
            RadialMenuHitInfo hitInfo = ViewInfo.CalcHitInfo(e.Location);
            Console.WriteLine(hitInfo.HitTest.ToString());
            switch (hitInfo.HitTest) {
                case RadialMenuHitTest.None:
                    ToolTipController.DefaultController.HideHint();
                    break;
                case RadialMenuHitTest.Glyph:
                    ShowHint("Glyph");
                    break;
                case RadialMenuHitTest.Link:
                    ShowHint(hitInfo.LinkInfo.Link.Caption);
                    break;
                case RadialMenuHitTest.LinkArrow:
                    ShowHint("LinkArrow");
                    break;
            }
        }
        private static void ShowHint(string text) {
            ToolTipController.DefaultController.ShowHint(text, "Hovered element", Control.MousePosition);
        }
    }
}
