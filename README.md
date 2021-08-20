# Dapper Migrations with FluentMigrator and ASP.NET Core
## https://code-maze.com/dapper-migrations-with-fluentmigrator-and-asp-net-core
<p>In this article, we are going to show you how to use the FluentMigrator library to create data migrations with Dapper and ASP.NET Core. In <a href="https://code-maze.com/using-dapper-with-asp-net-core-web-api/" target="_blank" rel="noopener">our previous article</a>, where we learned a lot about Dapper and ASP.NET Core, we had to create our database and seed our data manually. Since Dapper doesn't support migrations, if we want to create them, we have to use some additional help. For that, we are going to use FluentMigrator.</p>
<p>These are the topics:</p>
<ul>
	<li>Project Creation and Dapper and FluentMigrator Installation</li>
	<li>Using Dapper and FluentMigration to Create a Database Migration</li>
	<li>Adding Tables to the Database Using FluentMigrator</li>
	<li><a href="#seeding-data">Seeding Data with FluentMigrator</li>
	<li>Reverting Migrations</li>
	<li>Conclusion</li>
</ul>