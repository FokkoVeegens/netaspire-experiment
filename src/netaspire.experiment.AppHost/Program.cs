var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.netaspire_experiment_ApiService>("apiservice");

builder.AddProject<Projects.netaspire_experiment_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
