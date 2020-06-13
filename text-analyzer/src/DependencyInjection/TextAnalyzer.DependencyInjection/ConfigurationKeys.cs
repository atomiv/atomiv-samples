using Microsoft.EntityFrameworkCore.Infrastructure;
using System;

namespace TextAnalyzer.DependencyInjection
{
    public static class ConfigurationKeys
    {
        public const string DatabaseConnectionKey = "DefaultConnection";

        public static Action<SqlServerDbContextOptionsBuilder> SqlServerOptionsAction = b => b.MigrationsAssembly("TextAnalyzer.Tools.Migrator");
    }
}