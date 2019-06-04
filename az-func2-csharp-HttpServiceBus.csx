#r "Newtonsoft.Json"


using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System.Net.Http;

public static void Run(HttpRequest req, out string outputSbQueue, ILogger log) 
{
    
    log.LogInformation("API Service Bus: Function START.");

    try
    {
        StreamReader reader = new StreamReader( req.Body );
        log.LogInformation("API Service Bus: StreamReader method instance created.");

        string body = reader.ReadToEnd();
        log.LogInformation("API Service Bus: Http request read.");
        
        outputSbQueue = body;
        log.LogInformation("API Service Bus: Http body to Service Bus complete.");
    }
    catch (Exception e)
    {
        log.LogInformation("API Service Bus: {0} exception caught.", e);
    }
}