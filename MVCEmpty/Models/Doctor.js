"Use strict";

function TestForFever(temp) {
    document.getElementById("docResult").innerHTML = ""
    if (temp > 40)
        document.getElementById("docResult").innerHTML = "You have a deadly fever"
    if (temp > 37 && temp < 40)
        document.getElementById("docResult").innerHTML = "You have a small fever"
    if (temp < 37)
        document.getElementById("docResult").innerHTML = "You are freezing"
}
addEventListener("submit", TestForFever(document.getElementById("tempCheck").value));