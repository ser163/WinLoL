# WinLoL
  一个C#编写明华 CS-230Z-YKT程序.


## 使用说明
###  1.编译成功之后



客户端代码:

```js
            if ("WebSocket" in window) {
                // init the websocket client
                wsc = new WebSocket("ws://localhost:5050/Love");
                wsc.onopen = function() {
                    console.log("connected");
                };
                wsc.onclose = function() {
                    console.log("closed");
                };
                wsc.onmessage = function(e) {
                    //var data = JSON.parse(e.data);
                    console.log(e.data);
                    $("#c-card_no").val(e.data);
                };
            }
```

