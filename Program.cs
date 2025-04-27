using g8kpr.services;   

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/gettrack/{trackName}", (string trackName) => {
    var track = Testmanager.GetTrackByName(trackName);
    return track;
})
.WithName("GetTrackByName")
.WithOpenApi();

app.Run();
