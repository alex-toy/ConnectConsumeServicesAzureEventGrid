# Connect and Consume Services - Azure Event Grid

**Azure Event Grid** is fast and reliable event routing service allowing developers to create real time applications and decouple their systems at ease. Thanks to event grid built in events you can quickly automate Azure subscription for all your operation needs.


## Event Grid

### Azure Functions

- create HTTP azure function
<img src="/pictures/az_function.png" title="azure function"  width="900">

- create a storage account that subscribes to the azure event grid (on the *Events* section)
<img src="/pictures/az_function2.png" title="azure function"  width="500">

- on the function app, create and delete blobs, then chech that the event has been triggered
<img src="/pictures/az_function3.png" title="azure function"  width="900">


## Azure Portal

- create project and publish

<img src="/pictures/event_grid.png" title="event grid"  width="900">
<img src="/pictures/event_grid2.png" title="event grid"  width="900">

- add an *Event Grid Subscription* on your *storage account*. For event types, choose blob created and blob deleted
<img src="/pictures/event_grid3.png" title="event grid"  width="900">

- upload a file to the storage account and see that the Azure Function has been executed
<img src="/pictures/event_grid4.png" title="event grid"  width="900">


## Debug Locally

- create a new Event Subscription with a web hook
<img src="/pictures/web_hook.png" title="web hook"  width="400">

- on the ngrok tool run
```
ngrok http 7071
```
<img src="/pictures/web_hook2.png" title="web hook"  width="900">

- copy the fowarding url and paste it into the endpoint section
```
https://a459-93-15-253-30.eu.ngrok.io/runtime/webhooks/EventGrid?functionName=GetBlobDetails
```
<img src="/pictures/web_hook3.png" title="web hook"  width="900">


## Event Grid Schema

- publish the azure function and subscribe the storage account to it. Then delete and upload blobs and see the result.
<img src="/pictures/event_grid1.png" title="event grid"  width="900">


## Storage Queue Handler

- create a queue

- create an event subscription
<img src="/pictures/queue.png" title="queue handler"  width="900">

- in the storage account, upload a file and see the result in the queue
<img src="/pictures/queue2.png" title="queue handler"  width="900">


## Event Grid Filters

- create an event subscription for the azure function

- add a filer on file extension
<img src="/pictures/event_grid_filter.png" title="event grid filter"  width="900">
 
- on azure storage, upload both .png and .txt files and see the filtering taking place
<img src="/pictures/event_grid_filter2.png" title="event grid filter"  width="900">
 
- see the filtering taking place : only the .png file has triggered the azure function
<img src="/pictures/event_grid_filter3.png" title="event grid filter"  width="900">


## Events at the Resource Group level

- create an event subscription at the resource group level. Choose only the success events
<img src="/pictures/event_rg.png" title="event resource group"  width="900">

- now, any action on the resource group that ends up as a success will trigger the azure function
<img src="/pictures/event_rg2.png" title="event resource group"  width="900">

- add a filter on the subject
<img src="/pictures/event_rg3.png" title="event resource group"  width="900">

- and see the event on that subject
<img src="/pictures/event_rg4.png" title="event resource group"  width="900">


## HTTP endpoint

- create an azure function based on HTTP trigger
<img src="/pictures/http_endpoint.png" title="http endpoint"  width="900">

- on the storage account, create a subscription 
<img src="/pictures/http_endpoint2.png" title="http endpoint"  width="900">

- this results in a fail, because we first need to perform a hand shake
<img src="/pictures/http_endpoint3.png" title="http endpoint"  width="900">

- install packages
```
Microsoft.Azure.EventGrid
```

- run the local azure function. It is now the endpoint for azure event grid.


## Custom Topics

- create an event grid topic
<img src="/pictures/custom_topic.png" title="custom topic"  width="900">

- create a console app. Install packages
```
Azure.Messaging.EventGrid
```

- publish the azure function *HttpTriggerBis*

- create an endpoint to the azure function
<img src="/pictures/custom_topic2.png" title="custom topic"  width="900">

- run the PublishEvents app. 