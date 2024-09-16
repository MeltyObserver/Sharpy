const MAIN = document.getElementById("main");
const SIDEBAR = document.getElementById("sidebar");
const BACKDROP = document.getElementById("sidebar-backdrop");
// const search = document.getElementById("topbar-search");

const Hidden = "hidden";
const MobileView = "page-mobile-view";
const side_mobileView = "sidebar-mobile-view";
const backdrop_animation = "sidebar-backdrop-animation";

const breakpoint_medium = 768;
// const breakpoint_lg = 992;

let mobileViewSet = false;

window.addEventListener("resize", () => {
    if (mobileViewSet && window.innerWidth >= breakpoint_medium) {
        HideSideBarOnMobile()
        mobileViewSet = false;
    }
});

function UpdateSideBar() {
    if (MAIN.classList.contains(MobileView)) {
        HideSideBarOnMobile()
    } else {
        ShowSideBarOnMobile()
    }
}

function HideSideBarOnMobile() {
    BACKDROP.classList.add(Hidden);
    BACKDROP.classList.remove(backdrop_animation);
    MAIN.classList.remove(MobileView);
    SIDEBAR.classList.remove(side_mobileView);
}

function ShowSideBarOnMobile() {
    BACKDROP.classList.remove(Hidden);
    BACKDROP.classList.add(backdrop_animation);
    MAIN.classList.add(MobileView);
    SIDEBAR.classList.add(side_mobileView);
    mobileViewSet = true;
}