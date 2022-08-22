using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VotingApp;
using VotingApp.Common.Interfaces;
using VotingApp.Infrastructure.Factories;
using VotingApp.Infrastructure.Interfaces.Factories;
using VotingApp.Infrastructure.Interfaces.Repositories;
using VotingApp.Infrastructure.Repositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTransient<IBaseFactory<IVoter>, VoterFactory>();
builder.Services.AddTransient<IBaseFactory<ICandidate>, CandidateFactory>();
builder.Services.AddSingleton<IBaseRepository<IVoter>, VotersRepository>();
builder.Services.AddSingleton<IBaseRepository<ICandidate>, CandidatesRepository>();

await builder.Build().RunAsync();
