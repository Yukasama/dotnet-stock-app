let sidebarActive = localStorage.getItem("sidebarActive");
const sidebar = document.querySelector(".sidebar");
const hamburger_container = document.querySelector(".hamburger_container");


const enableSidebar = () => {
    sidebar.classList.add("show");
    localStorage.setItem("sidebarActive", "enabled");
}

const disableSidebar = () => {
    sidebar.classList.remove("show");
    localStorage.setItem("sidebarActive", "disabled");
}


if (sidebarActive === "enabled") {
    enableSidebar();
} else {
    disableSidebar();
}


hamburger_container.addEventListener("click", function () {
    sidebarActive = localStorage.getItem("sidebarActive");
    if (sidebarActive !== "enabled") {
        enableSidebar();
    } else {
        disableSidebar();
    }
})


