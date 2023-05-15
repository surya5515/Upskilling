Option Strict On
Imports System.IO
Public Class Form1
    Dim write As StreamWriter
    Dim read As StreamReader
    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click

        write = File.AppendText("C:\Users\SAILS-DM110\OneDrive\Desktop\myfile.txt")
        write.WriteLine(txtInfo.Text)
        write.Close()

    End Sub

    Private Sub txtRead_Click(sender As Object, e As EventArgs) Handles txtRead.Click
        read = File.OpenText("C:\Users\SAILS-DM110\OneDrive\Desktop\myfile.txt")
        txtInfo.Text = read.ReadToEnd
        read.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        box_Save.Filter = "Text Files (*txt) | *txt | All Files (*.*)|*.*"
        box_Save.ShowDialog()
        write = File.AppendText(box_Save.FileName)
        write.WriteLine(txtInfo.Text)
        write.Close()

    End Sub

    'Private Sub btnOpen_Click(sender As Object, e As EventArgs)
    '    box_open.Filter = "Text Files (*txt) | *txt | All Files (*.*)|*.*"
    '    box_open.ShowDialog()
    '    read = File.OpenText(box_open.FileName)
    '    txtInfo.Text = read.ReadToEnd
    '    read.Close()
    'End Sub

    Private Sub btnOpen_Click_1(sender As Object, e As EventArgs) Handles btnOpen.Click
        box_open.Filter = "Text Files (*txt) | *txt | All Files (*.*)|*.*"
        box_open.ShowDialog()
        read = File.OpenText(box_open.FileName)
        txtInfo.Text = read.ReadToEnd
        read.Close()
    End Sub
End Class
