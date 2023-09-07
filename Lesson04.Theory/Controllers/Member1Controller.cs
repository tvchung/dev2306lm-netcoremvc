using Lesson04.Theory.Models.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson04.Theory.Controllers
{
    public class Member1Controller : Controller
    {
        private static readonly List<Member> _members = new List<Member>()
        {
            new Member{MemberId=Guid.NewGuid().ToString(),UserName="member1",Password="123456",FullName="Thành viên 1",Email="member1@gmail.com"},
            new Member{MemberId=Guid.NewGuid().ToString(),UserName="member2",Password="123456",FullName="Thành viên 2",Email="member2@gmail.com"},
            new Member{MemberId=Guid.NewGuid().ToString(),UserName="member3",Password="123456",FullName="Thành viên 3",Email="member3@gmail.com"},
            new Member{MemberId=Guid.NewGuid().ToString(),UserName="member4",Password="123456",FullName="Thành viên 4",Email="member4@gmail.com"},
            new Member{MemberId=Guid.NewGuid().ToString(),UserName="member5",Password="123456",FullName="Thành viên 5",Email="member5@gmail.com"},
        };
        // GET: Member1Controller
        public ActionResult Index()
        {
            return View(_members);
        }

        // GET: Member1Controller/Details/5
        public ActionResult Details(string id)
        {
            var model = _members.Where(x => x.MemberId == id).FirstOrDefault();
            return View(model);
        }

        // GET: Member1Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Member1Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            try
            {
                member.MemberId = Guid.NewGuid().ToString();
                _members.Add(member);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Member1Controller/Edit/5
        public ActionResult Edit(string id)
        {
            var model = _members.Where(x => x.MemberId == id).FirstOrDefault();
            return View(model);
        }

        // POST: Member1Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Member member)
        {
            try
            {
                var model = _members.Where(x => x.MemberId == id).FirstOrDefault() ;
                model.UserName = member.UserName;
                model.Password = member.Password;
                model.FullName = member.FullName;
                model.Email = member.Email;

                for (int i = 0; i < _members.Count; i++)
                {
                    if (_members[i].MemberId == id)
                    {
                        _members[i] = model;
                    }
                }
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Member1Controller/Delete/5
        public ActionResult Delete(string id)
        {
            var model = _members.Where(x => x.MemberId == id).FirstOrDefault();
            return View(model);
        }

        // POST: Member1Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, Member member)
        {
            try
            {
                string memnerid = member.MemberId;
                var model = _members.Where(x => x.MemberId == memnerid).FirstOrDefault();
                _members.Remove(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
