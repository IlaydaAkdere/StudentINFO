using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace StudentInfoSystem.Web.Pages;

public class IndexModel : StudentInfoSystemPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
