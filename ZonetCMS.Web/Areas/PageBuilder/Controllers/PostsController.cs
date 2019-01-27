using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ZonetCMS.Entities;
using ZonetCMS.Entities.Entities;

namespace ZonetCMS.Web.Areas.PageBuilder.Controllers
{
    public class PostsController : Controller
    {
        private PortalEntityModel db = new PortalEntityModel();

        // GET: PageBuilder/Posts
        public ActionResult Index()
        {
            var posts = db.Posts.Include(p => p.PostCategory);
            return View(posts.ToList());
        }

        // GET: PageBuilder/Posts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // GET: PageBuilder/Posts/Create
        public ActionResult Create()
        {
            ViewBag.PostCategoryId = new SelectList(db.PostCategories, "PostCategoryId", "PostCategoryName");
            return View();
        }

        // POST: PageBuilder/Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PostId,PostTitle,PostDescription,PostBody,PostAuthorUserId,DateAdded,DateUpdated,PostCategoryId,IsPublished")] Post post)
        {
            if (ModelState.IsValid)
            {
                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PostCategoryId = new SelectList(db.PostCategories, "PostCategoryId", "PostCategoryName", post.PostCategoryId);
            return View(post);
        }

        // GET: PageBuilder/Posts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            ViewBag.PostCategoryId = new SelectList(db.PostCategories, "PostCategoryId", "PostCategoryName", post.PostCategoryId);
            return View(post);
        }

        // POST: PageBuilder/Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PostId,PostTitle,PostDescription,PostBody,PostAuthorUserId,DateAdded,DateUpdated,PostCategoryId,IsPublished")] Post post)
        {
            if (ModelState.IsValid)
            {
                db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PostCategoryId = new SelectList(db.PostCategories, "PostCategoryId", "PostCategoryName", post.PostCategoryId);
            return View(post);
        }

        // GET: PageBuilder/Posts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: PageBuilder/Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Post post = db.Posts.Find(id);
            db.Posts.Remove(post);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
