Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraBars.Ribbon
Imports System.Windows.Forms
Imports DevExpress.Utils

Namespace WindowsFormsApplication4
    Public Class MyRadialMenuWindow
        Inherits RadialMenuWindow

        Public Sub New(ByVal menu As RadialMenu)
            MyBase.New(menu)
        End Sub
        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
            MyBase.OnMouseMove(e)
            Dim hitInfo As RadialMenuHitInfo = ViewInfo.CalcHitInfo(e.Location)
            Console.WriteLine(hitInfo.HitTest.ToString())
            Select Case hitInfo.HitTest
                Case RadialMenuHitTest.None
                    ToolTipController.DefaultController.HideHint()
                Case RadialMenuHitTest.Glyph
                    ShowHint("Glyph")
                Case RadialMenuHitTest.Link
                    ShowHint(hitInfo.LinkInfo.Link.Caption)
                Case RadialMenuHitTest.LinkArrow
                    ShowHint("LinkArrow")
            End Select
        End Sub
        Private Shared Sub ShowHint(ByVal text As String)
            ToolTipController.DefaultController.ShowHint(text, "Hovered element", Control.MousePosition)
        End Sub
    End Class
End Namespace
