"use strict";

/*
   New Perspectives on HTML5 and CSS3, 7th Edition
   Tutorial 9
   Case Problem 3

   Random Jane Austen Quote Generator
   Author: Anthony Nadeau
   Date: 05/11/2021   
   
   This script randomly generates a Jane Austen quote from
   a list of 10 quotes and writes that quote into the first
   quotation tag in the Web page.

*/
var randomQ = randomInt(0, 9); // really 10 possibilities because of 0 indexing

var quoteElem = document.getElementsByTagName("quote")[0]; // retrieves all the elements with tag name quote
                                                           // then assigns the very first one to the quoteElem variable

quoteElem.innerHTML = getQuote(randomQ); // assigns the innerHTML of the retrieved element as one of the quotes in the method getQuote

function randomInt(lowest, size) {
   /* 
      Math.random() returns a number between [0, 1[.
      By multiplying it by size we get a number between [0, size[.
      Then we can add the lowest number to it to ensure the lowest value is being respected.
      Finally Math.floor() will round the given number down to be a whole number.
   */
   return Math.floor((Math.random() * size) + lowest)
}

// Provided method
function getQuote(n) {
   var quotes = [
   "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.",
   "I hate to hear you talk about all women as if they were fine ladies instead of rational creatures. None of us want to be in calm waters all our lives.",
   "Silly things do cease to be silly if they are done by sensible people in an impudent way.",
   "Give a girl an education and introduce her properly into the world, and ten to one but she has the means of settling well, without further expense to anybody.",
   "Life seems but a quick succession of busy nothings.",
   "Our scars make us know that our past was for real.",
   "I cannot speak well enough to be unintelligible.",
   "One cannot be always laughing at a man without now and then stumbling on something witty.",
   "Men were put into the world to teach women the law of compromise.",
   "The person, be it gentlemen or lady, who has not pleasure in a good novel, must be intolerably stupid."
   ];
   
   return quotes[n];
}