using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleWebApp.Pages
{
    public class ExportStoryModel : PageModel
    {
        private readonly ILogger<ExportStoryModel> _logger;

        public ExportStoryModel(ILogger<ExportStoryModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
