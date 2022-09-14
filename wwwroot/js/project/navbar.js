//Navbar is already declared in event.js
eventHandler(window, navbar, "scroll", "show"); //SCROLL-STICKY NAVBAR

const profile = document.querySelector(".profile");
const profile_container = document.querySelector(".profile_container");
eventHandler(profile, profile_container, "click", "show");

const searchbar_container = document.querySelector(".searchbar_container");
const search_icon_container = document.querySelector(".search_icon_container");
const searchbar_x = document.querySelector(".searchbar_x");
eventHandler(search_icon_container, searchbar_container, "click", "show");
eventHandler(searchbar_x, searchbar_container, "click", "hide");