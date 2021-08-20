using FluentMigrator;

namespace DapperMigrations.Migrations
{
	[Migration(202106280001)]
	public class InitialTables_202106280001 : Migration
	{
		public override void Down()
		{
			Delete.Table("Employees");
			Delete.Table("Companies");
		}

		public override void Up()
		{
			Create.Table("Companies")
				.WithColumn("Id").AsGuid().NotNullable().PrimaryKey()
				.WithColumn("Name").AsString(50).NotNullable()
				.WithColumn("Address").AsString(60).NotNullable()
				.WithColumn("Country").AsString(50).NotNullable();

			Create.Table("Employees")
				.WithColumn("Id").AsGuid().NotNullable().PrimaryKey()
				.WithColumn("Name").AsString(50).NotNullable()
				.WithColumn("Age").AsInt32().NotNullable()
				.WithColumn("Position").AsString(50).NotNullable()
				.WithColumn("CompanyId").AsGuid().NotNullable().ForeignKey("Companies", "Id");
		}
	}
}
