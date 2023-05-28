# Connect and Consume Services - Azure Event Grid

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

 