using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinhGiaoVienTHPT
{
    public partial class FrmHDSD : Form
    {
        public FrmHDSD()
        {
            InitializeComponent();
        }

        private void FrmHDSD_Load(object sender, EventArgs e)
        {

        }

        private void rbQLHS_Click(object sender, EventArgs e)
        {
            line1.Text = "*Thêm học sinh mới:";
            line2.Text = "      -Nhấn nút Nhập Lại";
            line3.Text = "      -Nhập thông tin học sinh";
            line4.Text = "      -Nhấn nút Thêm";
            line5.Text = "*Xóa học sinh:";
            line6.Text = "      -Chọn một học sinh để xóa";
            line7.Text = "      -Nhấn nút xóa";
            line8.Text = "      -Hộp thoại hiện ra, nhấn OK";
            line9.Text = "*Sửa học sinh:";
            line10.Text = "     -Chọn một học sinh để sửa";
            line11.Text = "     -Nhập thông tin học sinh";
            line12.Text = "     -Nhấn nút sửa";
            line13.Text = "     -Hộp thoại hiện ra, nhấn OK";
            line14.Text = "*Tìm kiếm học sinh:";
            line15.Text = "     -Nhập thông tin học sinh cần tìm kiếm vào ô tìm kiếm";
            line16.Text = "     -Thông tin học sinh hiện ra trong bảng Danh Sách Học Sinh";
        }

        private void rbQLGV_Click(object sender, EventArgs e)
        {
            line1.Text = "*Thêm giáo viên mới:";
            line2.Text = "      -Nhấn nút Nhập Lại";
            line3.Text = "      -Nhập thông tin giáo viên";
            line4.Text = "      -Nhấn nút Thêm";
            line5.Text = "*Xóa giáo viên:";
            line6.Text = "      -Chọn một giáo viên để xóa";
            line7.Text = "      -Nhấn nút xóa";
            line8.Text = "      -Hộp thoại hiện ra, nhấn OK";
            line9.Text = "*Sửa giáo viên:";
            line10.Text = "     -Chọn một giáo viên để sửa";
            line11.Text = "     -Nhập thông tin giáo viên";
            line12.Text = "     -Nhấn nút sửa";
            line13.Text = "     -Hộp thoại hiện ra, nhấn OK";
            line14.Text = "*Tìm kiếm giáo viên:";
            line15.Text = "     -Nhập thông tin giáo viên cần tìm kiếm vào ô tìm kiếm";
            line16.Text = "     -Thông tin giáo viên hiện ra trong bảng Danh Sách Giáo Viên";
        }

        private void rbQLLop_Click(object sender, EventArgs e)
        {
            line1.Text = "*Sửa thông tin giáo viên chủ nhiệm và phòng học:";
            line2.Text = "      -Chọn lớp cần sửa";
            line3.Text = "      -Chỉnh sửa thông tin, chọn lại GVCN hoặc nhập lại phòng học";
            line4.Text = "      -Nhấn nút sửa";
            line5.Text = "      -Hộp thoại hiện ra, bấm OK";
            line6.Text = "*Hiển thị danh sách học sinh theo lớp:";
            line7.Text = "      -Chọn lớp cần hiển thị danh sách học sinh trong bảng Danh sách lớp";
            line8.Text = "      -Danh sách học sinh theo lớp được hiển thị trong bảng Danh sách học sinh";
            line9.Text = "*Tìm kiếm lớp:";
            line10.Text = "     -Nhập lớp cần tìm kiếm vào ô Tìm kiếm";
            line11.Text = "     -Lớp cần tìm(nếu có) sẽ hiển thị trong bảng Danh sách lớp.";
            line12.Text = "";
            line13.Text = "";
            line14.Text = "";
            line15.Text = "";
            line16.Text = "";
        }

        private void rbQLMH_Click(object sender, EventArgs e)
        {
            line1.Text = "*Tìm kiếm môn học:";
            line2.Text = "      -Nhập môn học cần tìm kiếm vào ô Tìm kiếm";
            line3.Text = "      -Môn học cần tìm sẽ hiển thị trong bảng Danh sách môn học.";
            line4.Text = "";
            line5.Text = "";
            line6.Text = "";
            line7.Text = "";
            line8.Text = "";
            line9.Text = "";
            line10.Text = "";
            line11.Text = "";
            line12.Text = "";
            line13.Text = "";
            line14.Text = "";
            line15.Text = "";
            line16.Text = "";
        }

        private void rbQLLD_Click(object sender, EventArgs e)
        {
            line1.Text = "*Thêm lịch dạy học:";
            line2.Text = "      -Chọn giáo viên, lớp, thời gian học(thứ, tiết)";
            line3.Text = "      -Nhấn nút thêm";
            line4.Text = "      *Lưu ý:* Nếu đã tồn tại lịch dạy khác trùng Mã giáo viên và Mã lớp, bạn sẽ không thể thêm";
            line5.Text = "                  vui lòng kiểm tra lại!";
            line6.Text = "*Sửa lịch dạy học:";
            line7.Text = "      -Chọn lịch dạy cần sửa";
            line8.Text = "      -Chỉnh sửa thông tin lịch dạy";
            line9.Text = "      -Nhấn nút sửa";
            line10.Text = "      -Hộp thoại hiện ra, nhấn OK";
            line11.Text = "*Xóa lịch dạy học:";
            line12.Text = "     -Chọn lịch học cần xóa";
            line13.Text = "     -Nhấn nút xóa";
            line14.Text = "     -Hộp thoại hiện ra, nhấn OK";
            line15.Text = "";
            line16.Text = "";

        }
    }
}
