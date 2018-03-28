using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Testing.Data;
using Asp_Core_Testing.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp_Core_Testing.Controllers
{
    public class UserViewsController : Controller
    {

        private readonly ApplicationDbContext db;

        public UserViewsController(ApplicationDbContext context)
        {
            db = context;
        }

        [Authorize]
        public IActionResult Home()
        {
            var UItem = db.User.ToList().Find(e => e.Email == User.Identity.Name);
            var Following = db.User.ToList().Find(x => x.Email == User.Identity.Name).Following;

            var Posts = db.Posts.ToList().FindAll(x => LookForFollowing(x.ModelId, Following) == true 
                || x.ModelId == UItem.Id).ToList();

            UItem.Posts = Posts;
            return View(UItem);
        }

        public IActionResult PostsView(string UserEmail)
        {
            try
            {
                

                return View();
            }
            catch { return View(); }
        }

        private bool LookForFollowing(int Id, IList<Following> Fol)
        {
            if(Fol == null)
            {
                return false;
            }
            foreach( var item in Fol)
            {
                if (Id == item.UserId)
                {
                    return true;
                }
            }

            return false;
        }

        [HttpGet]
        public IActionResult PostsCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PostsCreate(UserModel model, IFormFile File)
        {
            Random rnd = new Random();
            if (ModelState.IsValid)
            {
                string FilePathNew;
                if (File != null)
                {
                    File.FileName.Replace(" ", "%");
                    File.FileName.Replace(@"\", "/");
                    string rn = Convert.ToString(rnd.Next(50));
                    var filePath = Path.Combine("wwwroot/PostImages/StoredImages", rn + File.FileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await File.CopyToAsync(stream);
                    }

                    FilePathNew = "/PostImages/StoredImages/" + rn + File.FileName;
                }
                else
                {
                    FilePathNew = "DNE";
                }
                var UserItem = db.User.ToList().Find(x => x.Email == User.Identity.Name);

                UserItem.Posts = new List<Posts>
                    {
                        new Posts {Content = model.Posts.LastOrDefault().Content,
                        ImageUrl = FilePathNew,
                        PostType = model.Posts.LastOrDefault().PostType,
                        ModelId = UserItem.Id,
                        DateAdded = DateTime.Today
                        }
                    };


                var result = db.Entry(UserItem).State = EntityState.Modified;
                await db.SaveChangesAsync();

            }

            return View();
        }

    }
}