using Lesson05.Theory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Lesson05.Theory.Controllers
{
    public class MemberController : Controller
    {
        // GET: MemberController
        public ActionResult Index()
        {
            var model = DataLocal._members.ToList();
            return View(model);
        }

        // GET: MemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            //var member = new Member();
            var member = new RegisterViewMember();
            return View(member);
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create(Member model)
        //{

        //    string msg = "";
        //    bool validate = true;

        //    if (model.UserName.Length < 3 || model.UserName.Length > 20)
        //    {
        //        msg += "<li> Tên đăng nhập có độ dài 3-20 ký tự </li>";
        //        validate = false;
        //    }

        //    string patternEmail = @"[a-z0-9._-]+@[a-z0-9.-]+\.[a-z]{2,4}";
        //    if (!Regex.IsMatch(model.Email, patternEmail))
        //    {
        //        msg += "<li> Email không đúng định dạng </li>";
        //        validate = false;
        //    }

        //    if (validate == true)
        //    {
        //        model.MemberId = Guid.NewGuid().ToString();
        //        DataLocal._members.Add(model);
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.error = msg;
        //    return View(model);
        //}
        public ActionResult Create(RegisterViewMember model)
        {
            if (ModelState.IsValid)
            {
                Member member = new Member()
                {
                    MemberId = Guid.NewGuid().ToString(),
                    UserName=model.UserName,
                    Password=model.Password,
                    FullName=model.FullName,
                    Email=model.Email,
                    Phone=model.Phone,
                    Birthday=model.Birthday,

                };
                DataLocal._members.Add(member);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
           
        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
