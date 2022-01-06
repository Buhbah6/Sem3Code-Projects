"use strict";

/*
   New Perspectives on HTML5 and CSS3, 7th Edition
   Tutorial 10
   Review Assignment

   Author: Anthony Nadeau
   Date: 19/11/2021    

	
*/

// Declaration of static date
var thisDay = new Date("August 30, 2018");

// Creation of the table in HTML
var tableHTML = "<table id='eventTable'>";
tableHTML += "<caption>Upcoming Events</caption>";
tableHTML += "<tr><th>Date</th><th>Event</th><th>Price</th></tr>"

// Declaration of end date
var endDate = new Date(thisDay.getTime() + 14*24*60*60*1000);

// Loop to add event info to the table
for (var i = 0; i < eventDates.length; i++) {
   // Declaring event variables 
   var eventDate = new Date(eventDates[i]);
   var eventDay = eventDate.toDateString();
   var eventTime = eventDate.toLocaleTimeString();
   
   // adding event info to the the tableHTML variable
   if (thisDay <= eventDate && eventDate <= endDate) {
      tableHTML += "<tr>";
      tableHTML += "<td>" + eventDay + " @ " + eventTime + "</td>";
      tableHTML += "<td>" + eventDescriptions[i] + "</td>";
      tableHTML += "<td>" + eventPrices[i] + "</td>"
      tableHTML += "</tr>";
   }
}

// Closing off the table
tableHTML += "</table>";

// Adding tableHTML to the div with the 'eventList' id
document.getElementById("eventList").innerHTML = tableHTML;

