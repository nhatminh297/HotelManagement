using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace QLKS
{
    public partial class FormBill : Form
    {
        public FormBill()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private PrintDocument printDocument;

        private void btPrint_Click(object sender, EventArgs e)
        {
            // Ẩn các nút In và Thoát trước khi chụp hình ảnh
            btPrint.Hide();
            iconButton1.Hide();

            // Hiển thị hộp thoại PrintDialog cho người dùng chọn cài đặt in
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Gọi phương thức Print của PrintDocument để in form
                PrintForm(printDialog.PrinterSettings);
            }

            // Hiển thị lại các nút In và Thoát sau khi hoàn thành việc in
            btPrint.Show();
            iconButton1.Show();
        }

        private void PrintForm(PrinterSettings printerSettings)
        {
            // Thiết lập cài đặt in cho PrintDocument
            printDocument.PrinterSettings = printerSettings;

            // Gọi phương thức Print của PrintDocument để in form
            printDocument.Print();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Chụp hình ảnh của form
            Image formImage = CaptureForm();

            // In hình ảnh của form
            e.Graphics.DrawImage(formImage, e.MarginBounds);

            // Giải phóng hình ảnh
            formImage.Dispose();
        }

        private Image CaptureForm()
        {
            // Tạo một bitmap với kích thước của form
            Bitmap bitmap = new Bitmap(this.Width, this.Height);

            // Vẽ form lên bitmap
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

            // Tìm vị trí của các nút In và Thoát
            Point printButtonLocation = btPrint.PointToScreen(Point.Empty);
            Point exitButtonLocation = iconButton1.PointToScreen(Point.Empty);

            // Xóa vùng chứa các nút In và Thoát từ bitmap
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.FillRectangle(Brushes.White, printButtonLocation.X, printButtonLocation.Y, btPrint.Width, btPrint.Height);
                graphics.FillRectangle(Brushes.White, exitButtonLocation.X, exitButtonLocation.Y, iconButton1.Width, iconButton1.Height);
            }

            return bitmap;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
