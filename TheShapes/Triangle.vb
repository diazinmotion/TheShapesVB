Public Class Triangle
    Inherits BaseShape

    Protected shapeBaseLine As Double
    Protected shapeHeight As Double

    Public Sub New(baseline As Double, height As Double)
        Me.shapeBaseLine = baseline
        Me.shapeHeight = height
    End Sub

    Public Overrides Function calcCircumference() As Double
        Return Me.shapeHeight + Me.shapeBaseLine + Me.calcDiagonalLegth()
    End Function

    Public Overrides Function calcShapeArea() As Double
        Return 0.5 * Me.shapeHeight * Me.shapeBaseLine
    End Function

    Protected Overrides Sub printShapeDetail()
        Console.WriteLine("- The area for this triangle is: {0} cm2", Me.calcShapeArea())
        Console.WriteLine("- The circumference for this triangle is: {0} cm", Me.calcCircumference())
        Console.WriteLine("- The total price for this area triangle is: Rp. {0} (Rp. {1}/cm2)", FormatNumber(Me.calcShapeArea() * Me.shapePrice), Me.shapePrice)
    End Sub

    Public Overrides Sub setAreaPrice(price As Integer)
        Me.shapePrice = price
    End Sub

    Private Function calcDiagonalLegth() As Double
        ' Pythagoras formula
        ' c = sqrt(a^2 + b^2)
        Return Math.Round(Math.Sqrt((Me.shapeBaseLine ^ 2 + Me.shapeHeight ^ 2)), 2)
    End Function
End Class
