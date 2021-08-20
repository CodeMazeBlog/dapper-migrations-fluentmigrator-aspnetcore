using DapperMigrations.Migrations;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DapperMigrations.Extensions
{
	public static class MigrationManager
	{
		public static IHost MigrateDatabase(this IHost host)
		{
			using (var scope = host.Services.CreateScope())
			{
				var databaseService = scope.ServiceProvider.GetRequiredService<Database>();
				var migrationService = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();

				try
				{
					databaseService.CreateDatabase("DapperMigrationExample");

					migrationService.ListMigrations();
					migrationService.MigrateDown(202106280001);

				}
				catch
				{
					//log errors or ...
					throw;
				}
			}

			return host;
		}
	}
}
