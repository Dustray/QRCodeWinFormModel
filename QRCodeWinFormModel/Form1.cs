using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Win32二维码程序模型
namespace QRCodeWinFormModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Bitmap generateQRCode(string msg)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(msg, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.DarkRed, Color.PaleGreen, (Bitmap)Bitmap.FromFile(@"C:\Users\yinxi\OneDrive\图标\Win10表情包Emoji_IT之家.zip\006maLokjw1f2nqnpfa6bg308w08wb2a.gif.ifl\IMG00122.bmp"),25,1,true);
            return qrCodeImage;
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (messageText.Text == "")
            {
                return;
            }
            else
            {
                showPic.Image=generateQRCode(messageText.Text);
            }
        }
    }
}
