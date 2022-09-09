
let darkMode = localStorage.getItem("darkMode")
const dark_mode = document.querySelector(".dark_mode");
const dark_icon = document.querySelector(".dark_icon");
const switch_dark = document.querySelector(".switch_dark");
const switch_light = document.querySelector(".switch_light"); 
const light_icon = document.querySelector(".light_icon");
const logo = document.querySelector(".logo");


const enableDarkMode = () => {
    document.body.classList.add("dark");
    localStorage.setItem("darkMode", "enabled");
    dark_icon.classList.remove("dark_show");
    light_icon.classList.add("dark_show");
    logo.classList.add("dark");
};

const disableDarkMode = () => {
    document.body.classList.remove("dark");
    localStorage.setItem("darkMode", "disabled");
    dark_icon.classList.add("dark_show");
    light_icon.classList.remove("dark_show");
    logo.classList.remove("dark");
};


if (darkMode === "enabled") {
    enableDarkMode();
} else {
    disableDarkMode();
};


dark_mode.addEventListener("click", function() {
    darkMode = localStorage.getItem("darkMode");
    if(darkMode !== "enabled") {
        enableDarkMode();
    } else {
        disableDarkMode();
    }
});

switch_dark.addEventListener("click", function() {
    enableDarkMode();
});

switch_light.addEventListener("click", function() {
    disableDarkMode();
});