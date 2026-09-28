using Microsoft.AspNetCore.Mvc;
using bt28092026.Models; // Import namespace chứa class Product

namespace bt28092026.Controllers // Đã sửa tên namespace đúng theo tên dự án của bạn
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // BÀI 1: Action kiểm tra ngày cuối tuần
        public IActionResult KiemTraCuoiTuan()
        {
            DateTime today = DateTime.Now;

            // Kiểm tra xem hôm nay có phải Thứ Bảy hoặc Chủ Nhật không
            bool isWeekend = today.DayOfWeek == DayOfWeek.Saturday || today.DayOfWeek == DayOfWeek.Sunday;

            // Truyền dữ liệu sang View thông qua ViewBag
            ViewBag.Today = today;
            ViewBag.IsWeekend = isWeekend;

            return View();
        }

        // BÀI 2: Action hiển thị danh sách sản phẩm
        public IActionResult DanhSachSanPham()
        {
            // Khởi tạo danh sách sản phẩm mẫu
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Điện thoại iPhone 15", Price = 22000000 },
                new Product { Id = 2, Name = "Laptop Dell XPS 13", Price = 35000000 },
                new Product { Id = 3, Name = "Tai nghe Sony WH-1000XM5", Price = 8000000 },
                new Product { Id = 4, Name = "Chuột Logitech MX Master 3S", Price = 2500000 }
            };

            // Truyền danh sách sản phẩm sang View
            return View(products);
        }
    }
}