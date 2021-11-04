Imports DXFReaderNET
Public Class Form1

    Friend Enum FunctionsEnum
        None
        Line1
        Line2
    End Enum

    Private p1 As Vector2 = Vector2.Zero
    Private p2 As Vector2 = Vector2.Zero
    Private CurrentFunction As FunctionsEnum = FunctionsEnum.None

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DxfReaderNETControl1.NewDrawing()
        DxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        CurrentFunction = FunctionsEnum.Line1
    End Sub

    Private Sub DxfReaderNETControl1_MouseUp(sender As Object, e As MouseEventArgs) Handles DxfReaderNETControl1.MouseUp
        If e.Button = MouseButtons.Left Then

            Select Case CurrentFunction
                Case FunctionsEnum.Line2
                    CurrentFunction = FunctionsEnum.None
                    p2 = DxfReaderNETControl1.CurrentWCSpoint
                    DxfReaderNETControl1.DrawEntity(DxfReaderNETControl1.AddLine(p1.ToVector3(), p2.ToVector3()))
                Case FunctionsEnum.Line1
                    CurrentFunction = FunctionsEnum.Line2
                    p1 = DxfReaderNETControl1.CurrentWCSpoint
            End Select
        End If
    End Sub

    Private Sub DxfReaderNETControl1_MouseMove(sender As Object, e As MouseEventArgs) Handles DxfReaderNETControl1.MouseMove
        Select Case CurrentFunction
            Case FunctionsEnum.Line2
                DxfReaderNETControl1.ShowRubberBandLine(p1, DxfReaderNETControl1.CurrentWCSpoint)
        End Select
    End Sub
End Class
