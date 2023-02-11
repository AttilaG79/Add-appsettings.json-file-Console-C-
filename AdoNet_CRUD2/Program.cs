



using AdoNet_CRUD2;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

// build a collection
var serviceCollection = new ServiceCollection();

// build a configuration
IConfiguration configuration;

configuration = new ConfigurationBuilder().SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
    .AddJsonFile("appsettings.json").Build();

// add configuration to the service collection

serviceCollection.AddSingleton<IConfiguration>(configuration);

serviceCollection.AddSingleton<ApplicationDbContext>();

// Testing

var serviceProvider = serviceCollection.BuildServiceProvider();


var getInstanceDb = serviceProvider.GetService<ApplicationDbContext>();
getInstanceDb.GetConnectionStringDB();

Console.ReadLine();