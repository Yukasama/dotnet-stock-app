//Navbar is already declared in event.js
eventHandler(window, navbar, "scroll", "show"); //SCROLL-STICKY NAVBAR

const profile = document.querySelector(".profile");
const profile_container = document.querySelector(".profile_container");
eventHandler(profile, profile_container, "click", "show");


const sidebar = document.querySelector(".sidebar");
const hamburger_container = document.querySelector(".hamburger_container");
eventHandler(hamburger_container, sidebar, "click");