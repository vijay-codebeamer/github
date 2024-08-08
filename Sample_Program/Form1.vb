Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Project As String
        Dim Pressure As Double
        Dim Temp As Double
        Dim Capacity As Double
        Dim TubeOD As Double
        Dim TubeThk As Double
        Dim TubeID As Double

        Project = Text1.Text
        Pressure = Text2.Text
        Temp = Text3.Text
        Capacity = Text4.Text
        TubeOD = Text5.Text
        TubeThk = Text6.Text

        TubeID = TubeOD - (2 * TubeThk)

        End

    End Sub
End Class
