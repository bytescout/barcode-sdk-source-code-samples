//****************************************************************************//
//                                                                            //
// Download evaluation version: https://bytescout.com/download/web-installer  //
//                                                                            //
// Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    //
//                                                                            //
// Copyright © 2017 ByteScout Inc. All rights reserved.                       //
// http://www.bytescout.com                                                   //
//                                                                            //
//****************************************************************************//


using System;
using Bytescout.BarCode;

namespace QRCodeWithImage
{
	class Program
	{
		static void Main(string[] args)
		{
			const string decorationImageFile = @".\logo.png";
			const string outputFile = @".\barcode.png";
			const string barcodeValue = "1234567890 abcdefghijklmnopqrstuvwxyz 1234567890 abcdefghijklmnopqrstuvwxyz";
			
			// Create and activate barcode generator instance
			using (Barcode barcode = new Barcode("demo", "demo"))
			{
				// Set barcode type
				barcode.Symbology = SymbologyType.QRCode;

				// Set high QR Code error correction level
				barcode.Options.QRErrorCorrectionLevel = QRErrorCorrectionLevel.High;

				// Set barcode value
				barcode.Value = barcodeValue;

				// Add decoration image and scale it to 15% of the barcode square
				barcode.AddDecorationImage(decorationImageFile, 15);

				// Save generated barcode
				barcode.SaveImage(outputFile);

				Console.WriteLine("Barcode saved to " + outputFile);

				Console.WriteLine();
				Console.WriteLine("Press any key...");
				Console.ReadKey();
			}
		}
	}
}
