' Abstract class for base shape
Public MustInherit Class BaseShape

    Protected shapePrice As Double = 0

    Public MustOverride Sub setAreaPrice(price As Integer)
    Public MustOverride Function calcShapeArea() As Double
    Public MustOverride Function calcCircumference() As Double
    Protected MustOverride Sub printShapeDetail()

    ' void method for printing the shape details
    Public Sub print()
        Console.WriteLine("The details of the shape: ")
        Console.WriteLine("=======================================")
        Me.printShapeDetail()
        Console.WriteLine("=======================================")
        Console.WriteLine("Generated {0}", Now())
    End Sub

End Class
