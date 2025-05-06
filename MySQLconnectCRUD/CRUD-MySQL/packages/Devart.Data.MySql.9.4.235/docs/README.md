## dotConnect for MySQL

[dotConnect for MySQL](https://www.devart.com/dotconnect/mysql/) is a high-performance ORM enabled data provider for MySQL 8.0+ including Embedded servers (starting with 4.1), MariaDB, Amazon RDS, Amazon Aurora, Azure MySQL, Percona that builds on ADO.NET technology. 

The provider works with .NET Frameworks 2.0+, .NET Core 1.0+, .NET 5+.

It supports a wide range of MySQL-specific features, such as [secure SSL and SSH connections](https://www.devart.com/dotconnect/mysql/features.html), compression protocol, HTTP tunneling and others. Package provides advanced Visual Studio integration and convenient visual component editors to simplify component tweaking.

More information at [dotConnect for MySQL](https://www.devart.com/dotconnect/mysql/).

### Installation
------------

For projects, using general ADO.NET functionality of dotConnect for MySQL, you need to install the [Devart.Data.MySql](https://www.nuget.org/packages/Devart.Data.MySql/) package. Execute the following command in the Package Manager Console:

```sh
Install-Package Devart.Data.MySql
```

For projects, using Entity Framework Core 1, 3, 5, 6, 7, 8, 9 with MySQL, install the [Devart.Data.MySql.EFCore](https://www.nuget.org/packages/Devart.Data.MySql.EFCore/) package.

For projects that require integration with Entity Framework 6.4 (EF6), use the [Devart.Data.MySql.EF6](https://www.nuget.org/packages/Devart.Data.MySql.EF6/) package.

## License

dotConnect for MySQL is available in [several editions](https://www.devart.com/dotconnect/mysql/editions.html). See [pricing options](https://www.devart.com/dotconnect/mysql/ordering.html) for ordering.

The NuGet package initiates a 30-day free trial automatically, so no additional action is required.

### Compatibility
-------------

The following table show which version of this package to use with which version of frameworks.

| Frameworks | Version support
|-|-
| .NET | 9, 8, 7, 6, 5
| .NET Core | 3, 2, 1
| .NET Framework | 4.8, 4.7, 4.6

More information [here](https://www.devart.com/dotconnect/mysql/compatibility.html)

### Usage
-----
In this example, a new instance of the MySqlConnection class (part of the Devart.Data.MySql namespace) is created.
```csharp=
using Devart.Data.MySql;
...
MySqlConnection сonnection = new MySqlConnection();
сonnection.Host = "127.0.0.1";
сonnection.Port = 3306;
сonnection.UserId = "root";
сonnection.Password = "mypassword";
```
This snippet simplifies the connection setup by directly assigning a connection string to the ConnectionString property of the MySqlConnection object

```csharp=
сonnection.ConnectionString = "UserId=root;Password=mypassword;Host=127.0.0.1;Port=3306;";
```
#### ASP.NET Core and Blazor

Configuration File Snippet (appsettings.json):
```csharp=
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=127.0.0.1;UserId=root;Password=mypassword;Port=3306;"
   }
}
```

Dependency Injection of IConfiguration:

```csharp=
private readonly IConfiguration configuration;

public YourController(IConfiguration config) 
{
    configuration = config;
}
```

Retrieving a Connection String:

```csharp=
var connectionString = configuration.GetConnectionString("DefaultConnection");
var connection = new MySqlConnection(connectionString);
```

For more information about secure connections [using SSL](https://docs.devart.com/dotconnect/mysql/SecureConnections.html#usessl) or [SSH](https://docs.devart.com/dotconnect/mysql/SecureConnections.html#usessh) connections read at our documentation.

## Key Features

* **Direct Mode:** Allows your application to work with MySQL directly, without involving MySQL client library.
* **ASP.NET Core:** Supports ASP.NET Core Identity.
* **Performance:** Uses many MySQL-specific performance features & optimizations to ensure the highest performance.
* **Monitoring:** Allows per-component tracing of database events with a free dbMonitor application.
* **Security:** Supports various encryption ciphers, SSL and SSH connections, etc.
* **Support and updates:** Enjoy dedicated support team for prompt issue resolution and regular updates to keep your software running smoothly and securely.


## Related Packages

* [Devart.Data.MySql.EFCore](https://www.nuget.org/packages/Devart.Data.MySql.EFCore)
* [Devart.Data.MySql.EF6](https://www.nuget.org/packages/Devart.Data.MySql.EF6)
* [Devart.Data.MySql.EFCore.Design](https://www.nuget.org/packages/Devart.Data.MySql.EFCore.Design)

## Support Area

* [Documentation](https://docs.devart.com/dotconnect/mysql/GettingStarted.html)
* [Request form](https://www.devart.com/company/contactform.html?category=1&product=dotconnect/mysql)
* [Feedback page](https://www.devart.com/dotconnect/mysql/feedback.html)
* [Product history](https://www.devart.com/dotconnect/mysql/history.html)