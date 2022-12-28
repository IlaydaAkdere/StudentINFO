using System.Threading.Tasks;

namespace StudentInfoSystem.Data;

public interface IStudentInfoSystemDbSchemaMigrator
{
    Task MigrateAsync();
}
