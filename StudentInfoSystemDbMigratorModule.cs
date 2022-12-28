using StudentInfoSystem.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace StudentInfoSystem.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StudentInfoSystemEntityFrameworkCoreModule),
    typeof(StudentInfoSystemApplicationContractsModule)
    )]
public class StudentInfoSystemDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
