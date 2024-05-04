//window.myFunction = function (element, text) {
//    element.innerText = text
//    return text;
//}

//console.log("test");

window.myFunction = function (arg) {
    const isConfirmed = confirm(arg);
    return isConfirmed;
}