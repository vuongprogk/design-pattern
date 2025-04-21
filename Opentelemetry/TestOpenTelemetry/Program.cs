

await DoWork();

async Task DoWork()
{
    await StepOne();
    await StepTwo();
}

async Task StepTwo()
{
    await Task.Delay(100);
}

async Task StepOne()
{
    await Task.Delay(1000);
}

Console.WriteLine("Done!");