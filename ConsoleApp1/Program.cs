using System.Text.Json;
using Nrk.FluentCore.Utils;

try
{
    var memoryMetrics = MemoryUtils.GetWindowsMetrics();
    Console.WriteLine(JsonSerializer.Serialize(memoryMetrics));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
