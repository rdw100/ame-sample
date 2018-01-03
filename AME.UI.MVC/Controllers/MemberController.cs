using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AME.Entities;
using AME.UI.Process;
using AME.Framework;

namespace AME.UI.MVC.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index()
        {
            var upc = new MemberProcessComponent();
            List<Member> member = upc.ListMembers();

            return View(member.ToList());
        }

        // Post: Member
        [HttpPost]
        public ActionResult Index(string filterBy, string filterText)
        {
            var upc = new MemberProcessComponent();
            List<Member> member = upc.ListMembers();

            if (filterBy == "lastName" && !string.IsNullOrEmpty(filterText))
            {
                return View(member.Where(x => x.LastName.Contains(filterText)).ToList());
            }
            else if (filterBy == "firstName" && !string.IsNullOrEmpty(filterText))
            {
                return View(member.Where(x => x.FirstName.Contains(filterText)).ToList());
            }

            return View(member.ToList());
        }

        // GET: Member/Details/5
        public ActionResult Details(int id)
        {
            var upc = new MemberProcessComponent();
            Member member = upc.GetMemberById(id);

            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // GET: Member/Create
        public ActionResult Create()
        {            
            return View();
        }

        // POST: Member/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "FirstName,LastName,Address,City,State,ZIP")] Member member)
        {
            try
            {
                // TODO: Add insert logic here
                var upc = new MemberProcessComponent();
                upc.InsertMember(member);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Member/Edit/5
        public ActionResult Edit(int id)
        {
            var upc = new MemberProcessComponent();
            Member member = upc.GetMemberById(id);

            if (member == null)
            {
                return HttpNotFound();
            }
            
            return View(member);
        }

        // POST: Member/Edit/5 
        [HttpPost]
        public ActionResult Edit([Bind(Include = "MemberId,FirstName,LastName,Address,City,State,ZIP")] Member member)
        {
            // TODO: Add update logic here
            var upc = new MemberProcessComponent();
            upc.UpdateMember(member);

            return RedirectToAction("Index");
        }

        // GET: Member/Delete/5
        public ActionResult Delete(int id)
        {
            var upc = new MemberProcessComponent();
            Member member = upc.GetMemberById(id);

            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // POST: Member/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here 
                var upc = new MemberProcessComponent();
                upc.DeleteMember(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }         
    }
}
