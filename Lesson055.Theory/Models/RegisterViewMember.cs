using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lesson05.Theory.Models
{
    public class RegisterViewMember
    {
        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage ="Têm đăng nhập không để trống")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="Độ dài từ 3-20 ký tự")]
        public string UserName { get; set; }
        public string Password { get; set; }

        [DisplayName("Hộ vầ tên")]
        [Required(ErrorMessage = "Họ và tên không để trống")]
        public string FullName { get; set; }

        [DisplayName("Hộp thư")]
        [RegularExpression(@"[a-z0-9._-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage ="Email khonog đúng định dạng")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
    }
}
