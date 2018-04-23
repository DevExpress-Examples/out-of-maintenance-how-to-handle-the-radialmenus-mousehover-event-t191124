Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraBars.Ribbon
Imports System.ComponentModel

Namespace WindowsFormsApplication4
    <ToolboxItem(True)> _
    Public Class MyRadialMenu
        Inherits RadialMenu

        Public Sub New()
        End Sub
        Protected Overrides Function CreateLayeredWindow() As RadialMenuWindow
            Return New MyRadialMenuWindow(Me)
        End Function
    End Class
End Namespace
