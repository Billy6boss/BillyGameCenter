
let sinalRConn = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

sinalRConn.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});


sinalRConn.on("ReceiveMessage", function (user, message) {
    let msg = message.replace(/&/g, "&").replace(/>/g, ">");
    let encodedMsg = user + " says " + msg;
    let li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("messagesList").appendChild(li);
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    let user = document.getElementById("userInput").value;
    let message = document.getElementById("messageInput").value;
    sinalRConn.invoke("SendMsg", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

sinalRConn.on("UpdateCountDown",function (sec){
    startTimer(sec);
})

document.getElementById("startTimerButton").addEventListener("click", function (event){
    sinalRConn.invoke("StartCountDown",countDownSec).catch(function (err){
        return console.error(err.toString());
    })
    
    event.preventDefault();
})