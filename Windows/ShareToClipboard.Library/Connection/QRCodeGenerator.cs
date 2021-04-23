using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareToClipboard.Library.Connection
{
	public class QRCodeGenerator
	{
		private readonly string text;
		public QRCodeGenerator(string text)
		{
			this.text = text;			
		}

		public Bitmap CreateBitmapQR(Color color1, Color color2)
		{
			QRCoder.QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
			QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCoder.QRCodeGenerator.ECCLevel.Q);
			QRCode qrCode = new QRCode(qrCodeData);
			return qrCode.GetGraphic(20, color1, color2, true);
		}

		public Bitmap CreateBitmapQR()
		{
			return CreateBitmapQR(Color.Black, Color.White);
		}
	}
}
