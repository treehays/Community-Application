using System;
using System.Collections.Generic;
using System.Linq;
using Community_Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Community_Application.Controllers
{
    public class DiscussionController : Controller
    {
        List<Discussion> Discussions = new List<Discussion>(){
            new Discussion{Id = 1, Subject = "I love programming", Creator = "Masturah", TimeCreated = DateTime.Now},
            new Discussion{Id = 2, Subject = "She is lovely", Creator = "Bola", TimeCreated = DateTime.Now}
        };

        public IActionResult GetAllDiscussions()
        {
            var discussions = Discussions.ToList();
            return View(discussions);
        }


        [HttpGet("{id}")]
         public IActionResult Details(int id)
        {
            var discussion = Discussions.Where(x => x.Id == id).SingleOrDefault();
            return View(discussion);
        }
    }
}