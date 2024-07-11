

var builder = WebApplication.CreateBuilder(args);


// Configure Logging
builder.Logging
    .ClearProviders()
    .AddConfiguration(builder.Configuration);

if (builder.Environment.IsDevelopment())
{
    builder.Logging
        .AddConsole()
        .AddDebug();
}

// Configure Services
builder.Services
  .AddHealthChecks()
  .AddCheck("Default", () => HealthCheckResult.Healthy("OK"))
  // [You can add more checks here...]
  ;

builder.Services
    // Registers the Swagger generator, defining one Swagger document.
    .AddEndpointsApiExplorer()
    .AddSwaggerGen()
    // Registers services to compress outputs.
    .AddResponseCompression()
    // Registers sensitive encryption services (e.g. to encrypt cookies).
    .AddDataProtection();

builder.Services
    // Registers MVC & Web API services.
    .AddMvcCore(
        options => options.Filters.Add<ApiExceptionFilter>()
    )
    .AddApiExplorer()
    .AddDataAnnotations()
    .AddAuthorization();

// Add JWT authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
	.AddJwtBearer(options =>
	{
		options.Authority = "https://tetouanb2clogin.com/86c8033c-5084-4843-b6bc-4247068dc0e1/v2.0/";
		options.Audience = "b53df2b9-ef2f-4e1c-ad1e-4f2bfcec7303";
		options.TokenValidationParameters = new TokenValidationParameters
		{
			ValidateIssuer = true,
			ValidateAudience = true,
			ValidateLifetime = true,
			ValidateIssuerSigningKey = true,
			ValidIssuer = "https://tetouanb2clogin.com/86c8033c-5084-4843-b6bc-4247068dc0e1/v2.0/",
			ValidAudience = "b53df2b9-ef2f-4e1c-ad1e-4f2bfcec7303"
		};
	});



// [You can add your own application services here...]
builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration); ;


var app = builder.Build();

// Configure Application middlewares pipeline
if (builder.Environment.IsDevelopment())
{
    // Uses development tools.
    app
        .UseDeveloperExceptionPage();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app
    .UseRouting()
    .UseResponseCompression()
    .UseAuthentication()
    .UseAuthorization();

app.MapHealthChecks("/health");
app.MapControllers();

app.Run();
