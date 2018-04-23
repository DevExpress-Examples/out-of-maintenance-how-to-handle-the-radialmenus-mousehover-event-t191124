Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq

Namespace WindowsFormsApplication4
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnShowRadialMenu_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnShowRadialMenu.ItemClick
            Dim pt As Point = GetMenuLocation()
            myRadialMenu1.ShowPopup(pt)
        End Sub
        Private Function GetMenuLocation() As Point
            Dim pt As New Point()
            pt.X = Location.X + Size.Width \ 2
            pt.Y = Location.Y + Size.Height \ 2
            Return pt
        End Function
    End Class
End Namespace
