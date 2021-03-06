
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_221

	''' <summary>
	'''     Rounds a double-precision floating-point value to the nearest integral value.
	''' </summary>
	''' <param name="a">A double-precision floating-point number to be rounded.</param>
	''' <returns>
	'''     The integer nearest . If the fractional component of  is halfway between two integers, one of which is even
	'''     and the other odd, then the even number is returned. Note that this method returns a  instead of an integral
	'''     type.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Round(a As [Double]) As [Double]
		Return Math.Round(a)
	End Function

	''' <summary>
	'''     Rounds a double-precision floating-point value to a specified number of fractional digits.
	''' </summary>
	''' <param name="a">A double-precision floating-point number to be rounded.</param>
	''' <param name="digits">The number of fractional digits in the return value.</param>
	''' <returns>The number nearest to  that contains a number of fractional digits equal to .</returns>
	''' ###
	''' <param name="value">A double-precision floating-point number to be rounded.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Round(a As [Double], digits As Int32) As [Double]
		Return Math.Round(a, digits)
	End Function

	''' <summary>
	'''     Rounds a double-precision floating-point value to the nearest integer. A parameter specifies how to round the
	'''     value if it is midway between two numbers.
	''' </summary>
	''' <param name="a">A double-precision floating-point number to be rounded.</param>
	''' <param name="mode">Specification for how to round  if it is midway between two other numbers.</param>
	''' <returns>
	'''     The integer nearest . If  is halfway between two integers, one of which is even and the other odd, then
	'''     determines which of the two is returned.
	''' </returns>
	''' ###
	''' <param name="value">A double-precision floating-point number to be rounded.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Round(a As [Double], mode As MidpointRounding) As [Double]
		Return Math.Round(a, mode)
	End Function

	''' <summary>
	'''     Rounds a double-precision floating-point value to a specified number of fractional digits. A parameter
	'''     specifies how to round the value if it is midway between two numbers.
	''' </summary>
	''' <param name="a">A double-precision floating-point number to be rounded.</param>
	''' <param name="digits">The number of fractional digits in the return value.</param>
	''' <param name="mode">Specification for how to round  if it is midway between two other numbers.</param>
	''' <returns>
	'''     The number nearest to  that has a number of fractional digits equal to . If  has fewer fractional digits than
	'''     ,  is returned unchanged.
	''' </returns>
	''' ###
	''' <param name="value">A double-precision floating-point number to be rounded.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Round(a As [Double], digits As Int32, mode As MidpointRounding) As [Double]
		Return Math.Round(a, digits, mode)
	End Function
End Module


