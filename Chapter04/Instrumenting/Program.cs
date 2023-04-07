using System.Diagnostics;
using Microsoft.Extensions.Configuration;

string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt");

Console.WriteLine($"Writing to: {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));

Trace.Listeners.Add(logFile);

//text write is buffered, so this option calls Flush() on all listeners after writing
Trace.AutoFlush = true;

Debug.WriteLine("Debug says, I am watching");
Trace.WriteLine("Trace says, I am watching");

Console.WriteLine("Reading from appsettings.json in {0}", arg0: Directory.GetCurrentDirectory());

ConfigurationBuilder builder = new();

builder.SetBasePath(Directory.GetCurrentDirectory());

builder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

TraceSwitch ts = new(displayName: "PacktSwitch", description: "This switch is set via a JSON config.");

configuration.GetSection("PacktSwitch").Bind(ts);

Trace.WriteLineIf(ts.TraceError, "TraceError");
Trace.WriteLineIf(ts.TraceWarning, "TraceWarning");
Trace.WriteLineIf(ts.TraceInfo, "TraceInformation");
Trace.WriteLineIf(ts.TraceVerbose, "TraceVerbose");

int unitsInStock = 12;
LogSourceDetails(unitsInStock > 10);

Console.ReadLine();