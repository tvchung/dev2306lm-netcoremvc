using Lesson04.Theory.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace Lesson04.Theory.Controllers
{
    public class MemberController : Controller
    {

        private static readonly List<Member> _members = new List<Member>()
        {
            new Member{MemberId=Guid.NewGuid().ToString(),UserName="member1",Password="123456",FullName="Thành viên 1",Email="member1@gmail.com"},
            new Member{MemberId=Guid.NewGuid().ToString(),UserName="member2",Password="123456",FullName="Thành viên 2",Email="member2@gmail.com"},
            new Member{MemberId=Guid.NewGuid().ToString(),UserName="member3",Password="123456",FullName="Thành viên 3",Email="member3@gmail.com"},
            new Member{MemberId=Guid.NewGuid().ToString(),UserName="member4",Password="123456",FullName="Thành viên 4",Email="member4@gmail.com"},
            new Member{MemberId=Guid.NewGuid().ToString(),UserName="member5",Password="123456",FullName="Thành viên 5",Email="member5@gmail.com"},
        };

        /// <summary>
        /// ViewBag, ViewData, TempData
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            // Tạo đối tượng dữ liệu
            var member = new Member();
            // Gán các giá trị
            member.MemberId = Guid.NewGuid().ToString();
            member.UserName = "ChungChung";
            member.Password = "123456";
            member.FullName = "Chung Trịnh";
            member.Email = "devmaster.edu.vn@gmail.com";

            // Truyền dữ liệu object ra view
            ViewBag.member = member;

            return View();
        }

        /// <summary>
        /// ViewBag, ViewData, TempData
        /// </summary>
        /// <returns></returns>
        public IActionResult ListMember()
        {
            // Truyền dữ liệu list object ra view
            ViewBag.listMember = _members;
            return View();
        }

        /// <summary>
        /// Model
        /// </summary>
        /// <returns></returns>
        public IActionResult ModelMember()
        {
            // Tạo đối tượng dữ liệu
            var member = new Member();
            // Gán các giá trị
            member.MemberId = Guid.NewGuid().ToString();
            member.UserName = "ChungChung";
            member.Password = "123456";
            member.FullName = "Chung Trịnh";
            member.Email = "devmaster.edu.vn@gmail.com";
            // Truyền biến Model
            return View(member);
        }

        public IActionResult ListMemberModel()
        {
            // Truyền dữ liệu list object ra view
            //ViewBag.listMember = _members;
            return View(_members);
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Member member)
        {
            member.MemberId = Guid.NewGuid().ToString();
            _members.Add(member);
            //return View();
            return RedirectToAction("ListMemberModel");
        }
    }
}
