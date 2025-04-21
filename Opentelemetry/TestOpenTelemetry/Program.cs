
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;
using TestOpenTelemetryConsole;

using var tracerProvider = OpenTelemetry.Sdk.CreateTracerProviderBuilder().
    SetResourceBuilder(ResourceBuilder.CreateDefault().AddService("MyService")).
    AddSource(ActivityApplicationDiagnotics.ActivityName).
    AddConsoleExporter().
    Build();
await DoWork();

async Task DoWork()
{
    await StepOne();
    await StepTwo();
}

async Task StepTwo()
{
    using var activity = ActivityApplicationDiagnotics.ActivitySource.StartActivity("StepTwo");
    await Task.Delay(100);
}

async Task StepOne()
{
    using var activity = ActivityApplicationDiagnotics.ActivitySource.StartActivity("StepOne");
    await Task.Delay(1000);
}

Console.WriteLine("Done!");