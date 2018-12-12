Public Class Rectangle
    Inherits BaseShape

    Protected length As Double

    Public Sub New(length As Double)
        Me.length = length
    End Sub

    Public Overrides Function calcCircumference() As Double
        Return 4 * Me.length
    End Function

    Public Overrides Function calcShapeArea() As Double
        Return Math.Pow(Me.length, 2)
    End Function

    Protected Overrides Sub printShapeDetail()
        Console.WriteLine("- The area for this rectangular is: {0} cm2", Me.calcShapeArea())
        Console.WriteLine("- The circumference for this rectangular is: {0} cm", Me.calcCircumference())
        Console.WriteLine("- The total price for this area rectangular is: Rp. {0} (Rp. {1}/cm2)", FormatNumber(Me.calcShapeArea() * Me.shapePrice), Me.shapePrice)
    End Sub

    Public Overrides Sub setAreaPrice(price As Integer)
        Me.shapePrice = price
    End Sub
End Class
