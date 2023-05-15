Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports Newtonsoft.Json



Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emp As Employee
        emp = New Employee
        emp.FirstName = "Kevin"
        emp.LastName = "Drumm"
        emp.Gender = "Male"
        emp.JobRole = "Teacher"
        emp.Salary = 55000

        Dim myString As String
        myString = JsonConvert.SerializeObject(emp, Formatting.Indented)
        MsgBox(myString)


        Dim swPerson As StreamWriter
        swPerson = New StreamWriter("C:\Sample\person.json", True)
        Dim myPersonserializer As New JsonSerializer()
        myPersonserializer.Serialize(swPerson, emp)
        swPerson.Close()

        'File.WriteAllText("C:\Sample\person.json", JsonConvert.SerializeObject(emp, Formatting.Indented))

        'Dim emp2 As New Employee
        'Dim srPerson As StreamReader
        'srPerson = New StreamReader("C:\Sample\person.json", True)
        'Dim myPersonserializer As New JsonSerializer()
        'emp2 = myPersonserializer.Deserialize(srPerson, emp2.GetType)
        'srPerson.Close()
        'MsgBox(emp2.FirstName & " " & emp2.LastName & " " & emp2.Gender & " " & emp2.JobRole & " " & emp2.Salary)


        'Dim emp2 As New Employee
        'emp2 = JsonConvert.DeserializeObject(myString, emp2.GetType)
        'MsgBox(emp.FirstName & " " & emp.LastName & " " & emp.Gender & " " & emp.JobRole & " " & emp.Salary)

        'Dim s1 As New FileStream("C:\Test File\binarydata.txt", FileMode.Create)
        'Dim fm1 As New BinaryFormatter
        'fm1.Serialize(s1, emp)
        's1.Close()

        'Dim emp2 As New Employee

        'Dim s2 As New FileStream("C:\Test File\binarydata.txt", FileMode.Open)
        'Dim fm2 As New BinaryFormatter
        'emp2 = fm2.Deserialize(s2)
        's2.Close()


    End Sub
End Class

Public Class Person
    Public FirstName As String
    Public LastName As String
    Public Gender As String

    Public Function SayHi() As String
        Return "Hi"
    End Function
End Class

Public Class Employee
    Inherits Person
    Public JobRole As String
    Public Salary As Decimal

    Public Function ShouldSerializeSalary() As Boolean
        If Salary < 50000 Then
            Return False
        Else
            Return True
        End If
    End Function

End Class