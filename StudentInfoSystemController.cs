using StudentInfoSystem.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace StudentInfoSystem.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StudentInfoSystemController : AbpControllerBase
{
    protected StudentInfoSystemController()
    {
        LocalizationResource = typeof(StudentInfoSystemResource);
    }
}
