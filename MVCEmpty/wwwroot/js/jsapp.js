"Use strict";

function dateUpdate() {
    var today = new Date();
    [month, day, year] = [today.getMonth(), today.getDay(), today.getFullYear()];
    [hour, minutes, seconds] = [today.getHours(), today.getMinutes(), today.getSeconds()];
    var dateTime = document.getElementById('myDiv');
    dateTime.innerHTML = ''
    dateTime.innerHTML = (month + '/' + day + '/' + year + ' ' + hour + ':' + minutes + ':' + seconds)
    setInterval(dateUpdate, 1000);
}
dateUpdate();

function TestForFever() {
    var temp = document.getElementById("tempCheck").value;
    document.getElementById("docResult").innerHTML = ""
    if (temp > 40)
        document.getElementById("docResult").innerHTML = "You have a deadly fever"
    if (temp > 37 && temp < 40)
        document.getElementById("docResult").innerHTML = "You have a small fever"
    if (temp < 37)
        document.getElementById("docResult").innerHTML = "You are freezing"
}
//var randomNumber;
//if (randomNumber === undefined)
//    randomNumber = Math.floor(Math.random() * 100 + 1);
//console.log(randomNumber);
//sessionStorage.setItem("randomNum", randomNumber);
//var countX = sessionStorage.getItem("countX") | 0;
//function RandomNumberTest() {
//    var storageNum = parseInt(sessionStorage.getItem("randomNum"));
//    var num = document.getElementById("guess").value;
//    console.log(num)
//    //if (countX === 0) {
//    //    = parseInt(sessionStorage.getItem("randomNum"));
//    //    sessionStorage.setItem("countX", 1);
//    //}
//    console.log(storageNum)
//    if (storageNum > num)
//        document.getElementById("guessp").innerHTML = "Your guess was too small";
//    if (storageNum < num)
//        document.getElementById("guessp").innerHTML = "Your guess was too big";
//    if (storageNum == num)
//        document.getElementById("guessp").innerHTML = "Congratulations, you won!";
//}
function StoreRandomNumber() {
    num = Math.floor(Math.random() * 100 + 1);
    sessionStorage.setItem("rndNum", num)
}
function RandomNumberTest() {
    var guess = document.getElementById("guess").value;
    var randomNumber = sessionStorage.getItem("rndNum");
    if (guess == randomNumber)
        return document.getElementById("guessp").innerHTML = "Congratulations, you won!";
    if (guess > randomNumber)
        return document.getElementById("guessp").innerHTML = "Your guess was too big";
    if (guess < randomNumber)
        return document.getElementById("guessp").innerHTML = "Your guess was too small";
}
function onclick() {
    location.href = '@Url.Action("RandomNumber()","Guess")';
}
