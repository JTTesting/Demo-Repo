using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibDemo;
namespace my_web_app.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }


    static string Lib(string txt)
    {
        LibClass Lib = new LibClass(txt);
        return Lib.GetMessage();
    }

    public string message = Lib("Bringing in the text");
}
