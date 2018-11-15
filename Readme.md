<!-- default file list -->
*Files to look at*:

* [MyRadialMenuWindow.cs](./CS/Custom Radial Menu/MyRadialMenuWindow.cs) (VB: [MyRadialMenuWindow.vb](./VB/Custom Radial Menu/MyRadialMenuWindow.vb))
* [RadialMenuDescendant.cs](./CS/Custom Radial Menu/RadialMenuDescendant.cs) (VB: [RadialMenuDescendant.vb](./VB/Custom Radial Menu/RadialMenuDescendant.vb))
* **[Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))**
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to handle the RadialMenu's MouseHover event 


This example demonstrates how to handle the RadialMenu MouseHover event and display information about a hovered Radial Menu element in a tool tip.<br />To achieve this:<br />1) Create a RadialMenu descendant.<br />2) Override its CreateLayeredWindow method and return a RadialMenuWindow descendant.<br />3) Override the RadialMenuWindow.OnMouseMove method.

<br/>


