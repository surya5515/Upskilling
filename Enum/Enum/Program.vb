Imports System

Module constantsNenum
    Enum Colors
        red = 1
        orange = 2
        blue = 3
        green = 4
        black = 5
        yellow = 6
    End Enum
    Sub Main(args As String())
        Console.WriteLine("The Color Red is: " & Colors.red)
        Console.WriteLine("The Color Green is :" & Colors.yellow)
        Console.WriteLine("The Color Black is :" & Colors.blue)
        Main1()
    End Sub
End Module

Module cons
    Sub Main1()
        Const PI = 3.14
        Dim Radius, area As Single
        Radius = 7
        area = PI * Radius * Radius
        Console.WriteLine("Area = " & Str(area))

    End Sub
End Module
