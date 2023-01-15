using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace LogicStoreAPI.Pages
{
    public class Index2Model : PageModel
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<Index2Model> _logger;

        public string AngularOutput { get; set; } 

        public Index2Model(IWebHostEnvironment webHostEnvironment, ILogger<Index2Model> logger)
        {
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
        }


        public IActionResult OnGet()
        {
            try
            {
                this.AngularOutput = System.IO.File.ReadAllText($"{_webHostEnvironment.WebRootPath}/Angular_Output.html");
            }
            catch (FileNotFoundException)
            {
                this.AngularOutput = "<h1>ANGULAR OUTPUT NOT READY</h1>";
            }

            return Page();
        }

    }
}
