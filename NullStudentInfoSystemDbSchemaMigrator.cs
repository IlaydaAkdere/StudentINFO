using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace StudentInfoSystem.Data;

/* This is used if database provider does't define
 * IStudentInfoSystemDbSchemaMigrator implementation.
 */
public class NullStudentInfoSystemDbSchemaMigrator : IStudentInfoSystemDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
