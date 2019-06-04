# az-func2-csharp-HttpServiceBus

### Info
Platform: Azure Function runtime 2.0  
Language: C#  
Input Binding: Http Trigger  
Output Binding: Service Bus Queue  

### Summary
RESTful Http endpoint that places the body of the Http request onto the Service Bus queue. In the case of my PoC, the body of the message is JSON. The function **does not** run asynchronously. An asynchronous function does not support output bindings.

### Pre-requisites
- Azure Function App 
  - Runtime version 2.0
  - C# Language
  - Function
    - HTTP Trigger 
- Azure Service Bus namespace
  - Queue
  - Shared Access Policy

### Creating the outbound binding
Under your Azure Function, select **Integrate**.  
**+ New Output**  
Enter the appropriate information for your Service Bus namespace, queue, and Shared Access Policy.

### References
Below URL contains information on retrieving messages from the Service Bus.  
[.NET Core Service Bus SDK Example](https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-dotnet-get-started-with-queues "Microsoft Docs Getting started with Service Bus queues")

