using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_AT.Data;
using Web_AT.Models;

namespace Web_AT.Pages
{
    public class PostbyIdModel : PageModel
    {
        public int idPost { get; set; }
        public List<Posts> postsList;

        public IActionResult OnGet(int id)
        {
            idPost = id;

            PostData postData = new PostData();
            postsList = postData.GetPostData();

            var query = postsList.Where(a => a.Id == id);

            postsList = query.ToList();


            return Page();
        }
    }
}
