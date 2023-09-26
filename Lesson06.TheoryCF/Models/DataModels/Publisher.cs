using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson06.TheoryCF.Models.DataModels
{
    [Table("Publishers")]
    public class Publisher
    {
        [DisplayName("Mã nhà xuất bản")]
        public int PublisherId { get; set; }
        [DisplayName("Tên nhà xuất bản")]
        [StringLength(100)]
        public string PublisherName { get; set; }
        [DisplayName("Điện thoại")]
        [StringLength(10)]
        public string Phone { get; set; }
        [DisplayName("Địa chỉ")]
        [StringLength(200)]
        public string Address { get; set; }
        // Thuộc tính quan hệ
        public ICollection<Book> Books { get; set; }

    }
}
