# Connect and Consume Services - Azure Event Grid

**Azure Event Grid** is fast and reliable event routing service allowing developers to create real time applications and decouple their systems at ease. Thanks to event grid built in events you can quickly automate Azure subscription for all your operation needs.

## Event Grid

- create project and publish

<img src="/pictures/event_grid.png" title="event grid"  width="900">
<img src="/pictures/event_grid2.png" title="event grid"  width="900">

- add an *Event Grid Subscription* on your *storage account*. For event types, choose blob created and blob deleted
<img src="/pictures/event_grid3.png" title="event grid"  width="900">

- on the ngrok tool run
```
ngrok.exe http -host-header=localhost 7071
```

## Logic App

- create 
<img src="/pictures/logic_app.png" title="logic app"  width="500">

- go to the *Logic App Designer* 
<img src="/pictures/logic_app2.png" title="logic app"  width="500">

 