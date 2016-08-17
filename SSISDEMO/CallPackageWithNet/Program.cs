using System;
using Microsoft.SqlServer.Dts.Runtime;

namespace CallPackageWithNet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var packageLocation=string.Empty;
            Package package;
            Application app;
            DTSExecResult pkgResults;

            packageLocation =
              @"C:\Program Files\Microsoft SQL Server\100\Samples\Integration Services" +
              @"\Package Samples\CalculatedColumns Sample\CalculatedColumns\CalculatedColumns.dtsx";
            app = new Application();
            package = app.LoadPackage(packageLocation, null);
            pkgResults = package.Execute();

            Console.WriteLine(pkgResults.ToString());
            Console.ReadKey();
        }
    }
}
