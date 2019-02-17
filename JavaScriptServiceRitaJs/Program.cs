using System.IO;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Configuration.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.NodeServices;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace PocClearScriptRitaJs
{
    /// <summary>
    /// Referencia:
    ///         https://github.com/aspnet/JavaScriptServices/tree/master/src/Microsoft.AspNetCore.NodeServices
    /// </summary>
    class Program
    {
        static async Task Main(string[] args)
        {

            string camihoAppJs = Directory.GetCurrentDirectory().Replace(@"JavaScriptServiceRitaJs\bin\Debug\netcoreapp3.0", "RitaApplication");

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddNodeServices( options => {
                options.ProjectPath = camihoAppJs;
            });

            var serivceProvider = serviceCollection.BuildServiceProvider();
            var nodeService = serivceProvider.GetService<INodeServices>();
            await RequisitaRitaJs(nodeService);
        }

        private static async Task RequisitaRitaJs(INodeServices nodeService)
        {
            var gramar = new Dictionary<string, string>()
            {
                {"<start>", "<Subj> <V> <Det> <N> <AdjS>" },
                {"<Subj>", "<Pron>" },
                {"<Pron>", "Você" },
                {"<V>", "é" },
                {"<Det>", "uma" },
                {"<N>", "pessoa" },
                {"<AdjS>", "<Adj_1> e <Adj_2> | <Adj_1>, <Adj_2> e <Adj_3>" },
                {"<Adj_1>", "forte" },
                {"<Adj_2>", "determinada" },
                {"<Adj_3>", "autoconfiante" }
            };
                
        var result = await nodeService.InvokeAsync<string>(
                            "./rita_grammar",
                              gramar
                            );

            Console.Write(result);
        }
    }
}
