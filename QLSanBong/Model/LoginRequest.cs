using System.ComponentModel.DataAnnotations;

namespace QLSanBong.Model
{
    public class LoginRequest
    {

        [Required(ErrorMessage = "Bạn phải nhập tên tài khoản hoặc Email")]
        [StringLength(100, ErrorMessage = "Tài khoản hoặc Email không quá 100 ký tự")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập mật khẩu")]
        [StringLength(100, ErrorMessage = "Mật khẩu không quá 100 ký tự")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
