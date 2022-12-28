using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentInfoSystem.Data;
using Volo.Abp.DependencyInjection;

namespace StudentInfoSystem.EntityFrameworkCore;

public class EntityFrameworkCoreStudentInfoSystemDbSchemaMigrator
    : IStudentInfoSystemDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreStudentInfoSystemDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the StudentInfoSystemDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<StudentInfoSystemDbContext>()
            .Database
            .MigrateAsync();
    }
}
