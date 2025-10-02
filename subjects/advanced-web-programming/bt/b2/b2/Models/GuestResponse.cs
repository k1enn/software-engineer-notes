using System.ComponentModel.DataAnnotations;

namespace b2.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        [Display(Name = "Họ tên")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng nhập email")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [Display(Name = "Số điện thoại")]
        [RegularExpression(@"^0\d{9,10}$", ErrorMessage = "Số điện thoại không hợp lệ (phải bắt đầu bằng 0 và có 10-11 chữ số)")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng chọn khóa học")]
        [Display(Name = "Khóa học")]
        public string Course { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng chọn có tham dự hay không")]
        [Display(Name = "Xác nhận tham dự")]
        public bool? WillAttend { get; set; }
    }
}