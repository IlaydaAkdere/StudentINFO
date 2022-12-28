using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace StudentInfoSystem.Web;

[Dependency(ReplaceServices = true)]
public class StudentInfoSystemBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "StudentInfoSystem";
}
