Public Class Circle
    Inherits BaseShape

    Protected shapeRadius As Double
    Protected PI As Double = Math.Round(Math.PI, 3)

    Public Sub New(radius As Double)
        Me.shapeRadius = radius
    End Sub

    Public Overrides Function calcCircumference() As Double
        Return 2 * Me.PI * Me.shapeRadius
    End Function

    Public Overrides Function calcShapeArea() As Double
        Return Me.PI * (Math.Pow(Me.shapeRadius, 2))
    End Function

    Protected Overrides Sub printShapeDetail()
        Console.WriteLine("- The area for this circle is: {0} cm2", Me.calcShapeArea())
        Console.WriteLine("- The circumference for this circle is: {0} cm", Me.calcCircumference())
        Console.WriteLine("- The total price for this area circle is: Rp. {0} (Rp. {1}/cm2)", FormatNumber(Me.calcShapeArea() * Me.shapePrice), Me.shapePrice)
    End Sub

    Public Overrides Sub setAreaPrice(price As Integer)
        Me.shapePrice = price
    End Sub
End Class
