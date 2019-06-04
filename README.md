# az-func2-csharp-HttpServiceBus

### Info
Platform: Azure Function runtime 2.0  
Language: C#  
Input Binding: Http Trigger  
Output Binding: Service Bus Queue  

### Summary
RESTful Http endpoint that places the body of the Http request onto the Service Bus queue. In the case of my PoC, the body of the message is JSON. 

#### Pre-requisites
- Azure Function App 
  - Runtime version 2.0
  - C# Language
  - Function
    - HTTP Trigger 
- Azure Service Bus namespace
  - Queue
  - Shared Access Policy


