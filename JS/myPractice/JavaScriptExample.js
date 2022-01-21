"use strict";
// console.log("Hello World");

// var myName = "Rich";
// console.log(myName);

// value = "didn't define var";
// console.log(value);

// var string = "Rich",
//   num = 123;

// console.log(string, num);

// let user = {
//   name: "john",
//   age: 30,
// };

// console.log(typeof user);

// // = is for assignment of a variable
// // == comparison operator of the values
// // === is a comparison of the variable type and value must be same

// var result = string === user;
// console.log(result);
// // same type same content: True
// result = myName === string;
// console.log(result);
// // different type same content: False
// num = 123;
// str = "123";
// console.log(num === str);

// function newFunc(sent) {
//   console.log("This is a function, received param: " + sent);
//   return "Success";
// }

// var ret = newFunc("Sent message");
// console.log("Return from function: " + ret);

// console.log(myVariable); // Ouput: undefined
// var myVariable = "Look, I'm defined!";

// var myFunc = (function () {
//   console.log("Func variable: " + funcVariable); // Output: undefined
//   console.log("If variable: " + ifVariable);
//   var funcVariable = "In function!";

//   if (true) {
//     var ifVariable = "If block!";
//   }
// })();

document.addEventListener("DOMContentLoaded", function () {
  let formOut = document.getElementById("formOut");
});

function myFunction() {
  document.getElementById("paragraph").innerHTML = Date();
}

function formFunction() {
  var x = document.getElementById("form");
  var text = "Submitted: ";
  for (let i = 0; i < x.length; i++) {
    text += x.elements[i].value + " ";
  }

  document.getElementById("formOut").innerHTML = text;
}

function json() {
  let batch =
    '{ "Trainer": [{"fname":["Rich"],"lname":["Hawkins"]}], "Associates": [{ "fname": ["Travis"], "lname": ["Boskowitz"] },' +
    '{ "fname": ["Melinda"], "lname": ["Waggoner"] },' +
    '{ "fname": ["Jing"], "lname": ["Zhuang"] }]}';

  const obj = JSON.parse(batch); // parse to JSON
  const myJSON = JSON.stringify(obj); // parse to string
  alert(myJSON);
}

let cnt = 0;
function addNodes() {
  let testElement = document.getElementById("test");
  let newElement = document.createElement("p");
  newElement.textContent = `This is a new paragraph ${++cnt}`;
  testElement.append(newElement);

  newElement.addEventListener("click", () => {
    console.log(`Clicked on paragraph ${cnt}`);
  });
}

function removeNodes() {
  let testElement = document.getElementById("test");
  let newElement = document.createElement("div");
  newElement.id = "test";
  testElement.after(newElement);
  testElement.remove();
}
