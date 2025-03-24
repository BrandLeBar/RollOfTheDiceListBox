'Brandon Barrera
'RCET0265
'Spring 2025
'

Option Explicit On
Option Strict On
Option Compare Text

Public Class RollTheDiceForm

    Sub SetDefaults()
        DisplayListBox.Items.Clear()
    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        Main()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub

    Sub Main()
        Dim rolls(12) As Integer
        Dim columnWidth As Integer = 11
        Dim header As String
        Dim data As String

        DisplayListBox.Items.Add("Roll of the Dice ".PadLeft(columnWidth * 9))
        DisplayListBox.Items.Add(StrDup(columnWidth * 11, "_"))

        For i = 1 To 1000
            rolls(RandomNumberGenerator(1, 12)) += 1
        Next

        DisplayListBox.Items.Add("")

        For i = 2 To UBound(rolls)
            header &= (CStr(i).PadLeft(columnWidth + 1) & "   |")
        Next

        For i = 2 To UBound(rolls)
            data &= (CStr(rolls(i)).PadLeft(columnWidth) & "   |")
        Next

        DisplayListBox.Items.Add(header)
        DisplayListBox.Items.Add("")
        DisplayListBox.Items.Add(StrDup(columnWidth * 11, "_"))
        DisplayListBox.Items.Add("")
        DisplayListBox.Items.Add(data)
        DisplayListBox.Items.Add("")

    End Sub

    Function RandomNumberGenerator(min As Integer, max As Integer) As Integer
        Randomize()
        Return CInt(Math.Ceiling((max - min) * Rnd() + min))
    End Function

End Class
