namespace Lesson04.Lab.Models
{
    public class Data
    {
        public static List<People> _peoples = new List<People>()
        {
            new People(){Id=1,Name="Devmaster",Email="devmaster.edu.vn@gmail.com",Phone="0978611889",Address="25 Vũ Ngọc Phan",Avatar="images/avatar/dev.png",Birthday=Convert.ToDateTime("2012/09/22"),Bio="Viện Công Nghệ Devmaster",Gender=0},
            new People(){Id=2,Name="Trịnh Văn Chung",Email="chungtrinhj@gmail.com",Phone="0978611889",Address="25 Vũ Ngọc Phan", Avatar="images/avatar/2.png",Birthday=Convert.ToDateTime("1979/05/25"),Bio="Devmaster Academy",Gender=1},
            new People(){Id=2,Name="Nguyễn Huy",Email="huynguyen@gmail.com",Phone="0912113113",Address="Gia lâm, hà nội", Avatar="images/avatar/3.png",Birthday=Convert.ToDateTime("1999/02/12"),Bio="Viện Devmaster",Gender=1},
            new People(){Id=3,Name="Tiểu Long Nữ",Email="longnutieu@gmail.com",Phone="0904001002",Address="Ba đình, hà nội", Avatar="images/avatar/4.png",Birthday=Convert.ToDateTime("2000/02/02"),Bio="Nhân vật trong phim kiếm hiệp",Gender=2},
            new People(){Id=4,Name="Pikachu",Email="chupika@gmail.com",Phone="0902114115",Address="Quang trung, hà đông", Avatar="images/avatar/5.png",Birthday=Convert.ToDateTime("1997/12/12"),Bio="Nhân vật trong phim hoạt hình",Gender=2},
        };
        public static List<People> GetPeoples()
        {
            return _peoples;
        }

        /// <summary>
        /// Get All
        /// </summary>
        /// <returns></returns>
        public static People GetPeopleById(int Id)
        {
            var people = _peoples.FirstOrDefault(x=>x.Id==Id);
            return people;
        }
    }
}
