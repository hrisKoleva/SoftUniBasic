using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Reflection;
using System.Security.Permissions;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectDirectoryPath = @"C:\Nemo\Baseline\Bin\x86d\Kongsberg.Dory.ErsParameterMaps.dll";

            Assembly domainAssembly = Assembly.LoadFrom(projectDirectoryPath);

            var types = domainAssembly.GetTypes();


            foreach (var item in types.OrderBy(x => x.Name))
            {
                if (!item.IsNested)
                    Console.WriteLine(item.Name);

            //    var methods = item.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            //    var fields = item.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            //    foreach (var method in methods.OrderBy(x => x.Name))
            //    {

            //        if (!method.Name.Equals("GetType") && !method.Name.StartsWith("<") &&
            //            !method.Name.StartsWith("get_") && !method.Name.StartsWith("set_") &&
            //            !method.Name.StartsWith("Member") && !method.Name.Equals("GetValue") &&
            //            !method.Name.StartsWith("System") && !method.Name.Equals("ToString") &&
            //            !method.Name.StartsWith("GetHashCode") && !method.Name.Equals("Finalize") &&
            //            !method.Name.StartsWith("Equals") && !method.Name.Equals("HasFlag"))
            //        {

            //            Console.WriteLine("\t" + method.Name);
                   
                      
            //        }

            //    }
            //    Console.WriteLine();

            //    foreach (var field in fields.OrderBy(x => x.Name))
            //    {
            //        if (!field.Name.StartsWith("<"))
            //        Console.WriteLine("\t\t" + field.Name);
            //    }
            }

            Console.ReadLine();
        }
    }
}
