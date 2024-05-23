using System.Reflection;
using Namotion.Reflection;

var assembly = Assembly.LoadFrom(args[0]);
foreach(var type in assembly.GetExportedTypes())
{
    Console.WriteLine(type.Name);
    Console.WriteLine(type.GetXmlDocsSummary());
    Console.WriteLine();
}
