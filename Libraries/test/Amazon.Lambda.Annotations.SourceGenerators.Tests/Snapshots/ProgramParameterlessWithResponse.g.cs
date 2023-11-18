﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Amazon.Lambda.Core;

namespace TestServerlessApp;

public class GeneratedProgram
{
    public static async Task Main(string[] args)
    {

        switch (Environment.GetEnvironmentVariable("ANNOTATIONS_HANDLER"))
        {
            case "NoParameterWithResponse":
                Func<Stream, string> noparameterwithresponse_handler = new TestServerlessApp.ParameterlessMethodWithResponse_NoParameterWithResponse_Generated().NoParameterWithResponse;
                await Amazon.Lambda.RuntimeSupport.LambdaBootstrapBuilder.Create(noparameterwithresponse_handler, new Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer()).Build().RunAsync();
                break;

        }
    }
}