using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Testing.Data;
using Asp_Core_Testing.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Asp_Core_Testing.Controllers
{
    public class CodeProjectsController : Controller
    {
        private readonly ApplicationDbContext db;

        public CodeProjectsController(ApplicationDbContext _db)
        {
            db = _db;
        }

        // GET: CodeProjects
        public ActionResult Folders()
        {
            var currentUserId = db.User.ToList()
                .Find(x => x.Email == User.Identity.Name).Id;

            var codeProjects = db.CodeProjects.ToList()
                .FindAll(x => x.ModelId == currentUserId);

            return View(codeProjects);
        }

        [HttpPost]
        public ActionResult FolderCreate( string FileName)
        {
            Random rnd = new Random();
            // Gets the current user
            var CurrentUser = db.User.ToList()
                .Find(x => x.Email == User.Identity.Name);

            // creates a username string used for the root folder directory
            string UserName = ((rnd.Next(100)).ToString() + CurrentUser.Name);

            // Gets rid of spaces to keep things clean for later
            string FileName_NoSpace = FileName.Replace(" ", string.Empty);

            // Creates the directory
            Directory.CreateDirectory("wwwroot/UserFolders/" + FileName_NoSpace);

            CodeProjects CP = new CodeProjects()
            {
                CodeSnippets = new List<Code_Snippets>(),
                Name = FileName,
                FileUrl = FileName_NoSpace,
                DateAdded = DateTime.Today,
                ModelId = CurrentUser.Id,
            };

            db.CodeProjects.Add(CP);
            db.SaveChanges();
            return RedirectToAction("Folders");
        }

        // GET: CodeProjects/Details/5
        public ActionResult CodeSnippets(int id)
        {
            var files = db.Code_Snippets.ToList()
                .FindAll(x=>x.ModelId == id);
            return View(files);
        }

        // GET: CodeProjects/Create
        public ActionResult FileUpload()
        {
            
            return RedirectToAction("CodeSnippets");
        }

        //// POST: CodeProjects/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return View();
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: CodeProjects/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        // POST: CodeProjects/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: CodeProjects/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: CodeProjects/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        //return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}