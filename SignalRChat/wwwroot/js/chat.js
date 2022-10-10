"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub")
.configureLogging(signalR.LogLevel.Debug)
// .configureLogging(logging =>
//     {
// 		debugger
//         // Log to the Output Window
//         logging.AddDebug();

//         // This will set ALL logging to Debug level
//         logging.SetMinimumLevel(LogLevel.Debug)
//     })
.build();

//Disable the send button until connection is established.
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
	debugger
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = `${user} says ${message}`;
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
	debugger
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});