using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

//Step 1. Create the service collection
var service = new ServiceCollection();

//Step 2. Register the service
service.AddSingleton<IConsole>(
  implementationFactory: static _ => new DefaultConsole{
    IsEnables = true
});
//Or you can use ServiceDescriptor class
// service.Add(ServiceDescriptor.Describe(
//   serviceType: typeof(IConsole),
//   implementationFactory: static _ => new DefaultConsole{
//     IsEnables = true
//   },
//   lifetime: ServiceLifetime.Singleton
// ));
service.AddSingleton<IGreetingService, DefaultGreetingService>();
service.AddSingleton<FarewellService>();

//Step 3. Build the service provider
var serviceProvider = service.BuildServiceProvider();

//Step 4. Resolve the services that you need
var greetingService = serviceProvider.GetRequiredService<IGreetingService>();
var farewellService = serviceProvider.GetRequiredService<FarewellService>();

//Step 5. Use the services
var greeting = greetingService.Greet("TrungLQ");
var farewell = farewellService.SayGoodbye("TrungLQ");

