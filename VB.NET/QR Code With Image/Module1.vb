'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports Bytescout.BarCode

Module Module1

	Sub Main()

		Dim decorationImageFile As String = ".\logo.png"
		Dim outputFile As String = ".\barcode.png"
		Dim barcodeValue As String = "1234567890 abcdefghijklmnopqrstuvwxyz 1234567890 abcdefghijklmnopqrstuvwxyz"

		' Create and activate barcode generator instance
		Using barcode As New Barcode("demo", "demo")

			' Set barcode type
			barcode.Symbology = SymbologyType.QRCode

			' Set high QR Code error correction level
			barcode.Options.QRErrorCorrectionLevel = QRErrorCorrectionLevel.High

			' Set barcode value
			barcode.Value = barcodeValue

			' Add decoration image and scale it to 15% of the barcode square
			barcode.AddDecorationImage(decorationImageFile, 15)

			' Save generated barcode
			barcode.SaveImage(outputFile)

			Console.WriteLine("Barcode saved to " + outputFile)

			Console.WriteLine()
			Console.WriteLine("Press any key...")
			Console.ReadKey()

		End Using

	End Sub

End Module
