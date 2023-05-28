# Connect and Consume Services - Azure Event Grid

**Azure Event Grid** is fast and reliable event routing service allowing developers to create real time applications and decouple their systems at ease. Thanks to event grid built in events you can quickly automate Azure subscription for all your operation needs.


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



## Logic App

- create 
<img src="/pictures/logic_app.png" title="logic app"  width="500">

- go to the *Logic App Designer* 
<img src="/pictures/logic_app2.png" title="logic app"  width="500">

 