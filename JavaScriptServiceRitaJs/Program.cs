using System.IO;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.NodeServices;
using Microsoft.Extensions.DependencyInjection;

namespace PocClearScriptRitaJs
{
    /// <summary>
    /// https://www.c-sharpcorner.com/article/net-core-html-to-pdf-generation-using-node/
    /// https://github.com/aspnet/JavaScriptServices/tree/master/src/Microsoft.AspNetCore.NodeServices
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddNodeServices();

            var serivceProvider = serviceCollection.BuildServiceProvider();
            var nodeService = serivceProvider.GetService<INodeServices>();
        }
    }
}
