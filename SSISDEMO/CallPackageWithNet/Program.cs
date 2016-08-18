using System;
using Microsoft.SqlServer.Dts.Runtime;

namespace CallPackageWithNet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            //method1
            //            Microsoft.SqlServer.Dts.Runtime.Application app = new Microsoft.SqlServer.Dts.Runtime.Application();
            //            Package package = null;
            //
            //            try
            //            {
            //                package = app.LoadPackage(@"F:\study\SSISDEMO1\SSISDEMO\SSISDEMO\Package.dtsx", null);
            //                Microsoft.SqlServer.Dts.Runtime.DTSExecResult results = package.Execute();
            //                Console.WriteLine(results.ToString());
            //              
            //            }
            //            catch (Exception ex)
            //            {
            //                throw ex;
            //            }
            //            finally
            //            {
            //                package.Dispose();
            //                package = null;
            //            }
            
        }
    }
}
