using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraBars.Ribbon;
using System.ComponentModel;

namespace WindowsFormsApplication4 {
    [ToolboxItem(true)]
    public class MyRadialMenu : RadialMenu {
        public MyRadialMenu() {
        }
        protected override RadialMenuWindow CreateLayeredWindow() {
            return new MyRadialMenuWindow(this);
        }
    }
}
