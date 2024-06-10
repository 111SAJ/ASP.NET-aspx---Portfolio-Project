/*Navbar Starts*/
navbar = document.querySelector('.navbar');
navList = document.querySelector('.nav-list');
rightNav = document.querySelector('.rightNav');
burger = document.querySelector('.burger');

burger.addEventListener('click',()=>{
    navbar.classList.toggle('h-nav-resp');
    navList.classList.toggle('v-class-resp');
    rightNav.classList.toggle('v-class-resp');
})
/*Navbar Ends*/


/*Frame for Mobile Screen Starts*/
function changeInnerHTML(){
    var screenWidth = window.innerWidth;
    if (screenWidth <= 700){
        /*If the screen width is less than or equal to 700 then show "frame-mobile" */
        document.querySelector(".frame-mobile").style.display = "block";
        document.querySelector(".sec-2-box-main").style.display = "none";
    }
    else{
        /*Otherwise, hide the "frame-mobile" */
        document.querySelector(".frame-mobile").style.display = "none";
        document.querySelector(".sec-2-box-main").style.display = "flex";
    }
}
/*Listener for resize the event and call the changeInnerHTML function */
window.addEventListener("resize", changeInnerHTML);
/*Frame for Mobile Screen Ends*/