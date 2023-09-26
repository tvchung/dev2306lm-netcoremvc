using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lesson05.Theory.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        [DisplayName("Địa chỉ mail")]
        //[DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Sai định dạng")]
        [Required(ErrorMessage = "Yêu cầu nhập")]
        public string Email { get; set; }


    }
}
