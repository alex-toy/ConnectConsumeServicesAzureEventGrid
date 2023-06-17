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
<img src="/pictures/event_grid1.png" title="event grid"  width="500">

 