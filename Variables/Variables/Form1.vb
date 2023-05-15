Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        MsgBox("Welcome")
        MsgBox("To")
        MsgBox("VB.Net")
        MsgBox("Programming")

        MessageBox.Show("This is an other message")

    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstName As String
        Dim stLastName As String
        stFirstName = "VB.net"
        stLastName = "Language"

        MsgBox("Hello and Welcome " & stFirstName & " " & stLastName & " Programming")


    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click

        Dim stMake = "Ford"
        Dim stModel = "Mustang"
        Dim Idoors As Integer
        Dim stColour As String
        Dim bTaxed As Boolean
        Dim decPrice As Decimal
        Dim dateRegistered As Date


        Idoors = 4
        stColour = "Red"
        bTaxed = True
        decPrice = 999.99
        dateRegistered = #11/2/2004#
        MsgBox("The car is" & vbNewLine & stMake & vbNewLine &
               stModel & vbNewLine & Idoors & vbNewLine &
               stColour & vbNewLine & bTaxed & vbNewLine &
               decPrice & vbNewLine & dateRegistered)



    End Sub

    Private Sub Input_Click(sender As Object, e As EventArgs) Handles Input.Click

        Dim stFirstName As String
        stFirstName = InputBox("Enter your Name")

        MsgBox("Hello " & stFirstName)




    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged




    End Sub
End Class
