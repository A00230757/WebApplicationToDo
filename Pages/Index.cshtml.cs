using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationToDo.Data;
using WebApplicationToDo.Data.Context;

namespace WebApplicationToDo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        StoreContext _context;

        [FromQuery]
        public ToDo updatetodo { get; set; }

        [FromForm]
        public ToDo inserttodo { get; set; }

        public IList<ToDo> todoList { get; set; } = new List<ToDo>();

        public IndexModel(StoreContext context)
        {
            
            _context = context;
        }

        public void OnGet()
        {
            Debug.WriteLine("Send to debug output." );
            if (updatetodo.Name != null & updatetodo.Done != null & updatetodo.EntryDate != null)
            {
                try
                {
                   
                
                    _context.ToDo.Update(updatetodo);
                    _context.SaveChanges();
                }
                catch
                {
                    
                    
                    _context.ToDo.Update(updatetodo);
                    _context.SaveChanges();
                }


            }
            todoList = _context.ToDo.ToList();
        }
        public void OnPost()
        {
            if (inserttodo.Name != null & inserttodo.Done != null & inserttodo.EntryDate != null)
            {
                
                try
                {
                    _context.ToDo.Add(inserttodo);
                    _context.SaveChanges();
                }
                catch
                {
                    _context.ToDo.Update(inserttodo);
                    _context.SaveChanges();
                }
               
            }

            todoList = _context.ToDo.ToList();
        }
    }
}
