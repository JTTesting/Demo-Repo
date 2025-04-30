using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibDemo1;
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
        LibClass1 Lib = new LibClass1(txt);
        return Lib.GetMessage1();
    }

    public string message = Lib("Bringing in the text");
}
