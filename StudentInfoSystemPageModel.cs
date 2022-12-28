using StudentInfoSystem.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace StudentInfoSystem.Web.Pages;

public abstract class StudentInfoSystemPageModel : AbpPageModel
{
    protected StudentInfoSystemPageModel()
    {
        LocalizationResourceType = typeof(StudentInfoSystemResource);
    }
}
