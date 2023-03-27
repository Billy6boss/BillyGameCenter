let countDownUnitMSec = 1000; 
let countDownSec = 5;

let timer;

function updateTimerText(timerString){
    document.getElementById("timer").innerText = timerString;
}

function stopTimer(){
    window.clearInterval(timer);
    timer = null;
}

function startTimer(sec){
    countDownSec = sec;
    if (!timer){
        timer = setInterval(function(){
            updateTimerText(countDownSec);
            
            if (countDownSec <= 0){
                stopTimer();
            }

            countDownSec -= countDownUnitMSec / 1000;
        },countDownUnitMSec);    
    }
    
}