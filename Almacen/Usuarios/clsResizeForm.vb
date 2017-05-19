Imports System.Drawing
Imports System.Windows.Forms

Public Class clsResizeForm
    Dim f_HeightRatio As Single = New Single
    Dim f_WidthRatio As Single = New Single
    Public Sub ResizeForm(ObjForm As Form, DesignerWidth As Integer, DesignerHeight As Integer)
        Dim i_StandardHeight As Integer = DesignerHeight
        Dim i_StandardWidth As Integer = DesignerWidth
        Dim i_PresentHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim i_PresentWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        f_HeightRatio = (CSng(i_PresentHeight) / CSng(i_StandardHeight))
        f_WidthRatio = (CSng(i_PresentWidth) / CSng(i_StandardWidth))
        ObjForm.AutoScaleMode = AutoScaleMode.None
        ObjForm.Scale(New SizeF(f_WidthRatio, f_HeightRatio))
        For Each c As Control In ObjForm.Controls
            If c.HasChildren Then
                ResizeControlStore(c)
            Else
                c.Font = New Font(c.Font.FontFamily, c.Font.Size * f_HeightRatio, c.Font.Style, c.Font.Unit, (CByte(0)))
            End If
        Next
        ObjForm.Font = New Font(ObjForm.Font.FontFamily, ObjForm.Font.Size * f_HeightRatio, ObjForm.Font.Style, ObjForm.Font.Unit, (CByte(0)))
    End Sub
    Private Sub ResizeControlStore(objCtl As Control)
        If objCtl.HasChildren Then
            For Each cChildren As Control In objCtl.Controls
                If cChildren.HasChildren Then
                    ResizeControlStore(cChildren)
                Else
                    cChildren.Font = New Font(cChildren.Font.FontFamily, cChildren.Font.Size * f_HeightRatio, cChildren.Font.Style, cChildren.Font.Unit, (CByte(0)))
                End If
            Next
            objCtl.Font = New Font(objCtl.Font.FontFamily, objCtl.Font.Size * f_HeightRatio, objCtl.Font.Style, objCtl.Font.Unit, (CByte(0)))
        Else
            objCtl.Font = New Font(objCtl.Font.FontFamily, objCtl.Font.Size * f_HeightRatio, objCtl.Font.Style, objCtl.Font.Unit, (CByte(0)))
        End If
    End Sub
End Class
