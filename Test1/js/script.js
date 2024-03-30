//let menu = document.querySelector('#menu-bar');
//let navbar = document.querySelector('.navbar');
//let header = document.querySelector('.header-3');
//let scrollTop = document.querySelector('.scroll-top');

//menu.addEventListener('click', () =>{
//    menu.classList.toggle('fa-times');
//    navbar.classList.toggle('active');
//});

//window.onscroll = () =>{

//    menu.classList.remove('fa-times');
//    navbar.classList.remove('active');

//    if(window.scrollY > 250){
//        header.classList.add('active');
//    }else{
//        header.classList.remove('active');
//    }

//    if(window.scrollY > 250){
//        scrollTop.style.display = 'initial';
//    }else{
//        scrollTop.style.display = 'none';
//    }

//}

//var swiper = new Swiper(".home-slider", {
//    pagination: {
//        el: ".swiper-pagination",
//        clickable: true,
//    },
//    autoplay: {
//        delay: 3000,
//        disableOnInteraction: false,
//    },
//    loop:true,
//});

//let countDate = new Date('june 1, 2021 00:00:00').getTime();

//function countDown(){

//    let now = new Date().getTime();

//    gap = countDate - now;

//    let second = 1000;
//    let minute = second * 60;
//    let hour = minute * 60;
//    let day = hour * 24;

//    let d = Math.floor(gap / (day));
//    let h = Math.floor((gap % (day)) / (hour));
//    let m = Math.floor((gap % (hour)) / (minute));
//    let s = Math.floor((gap % (minute)) / (second));

//    document.getElementById('day').innerText = d;
//    document.getElementById('hour').innerText = h;
//    document.getElementById('minute').innerText = m;
//    document.getElementById('second').innerText = s;

//}

//setInterval(function(){
//    countDown();
//},1000)



var i = 0;
$(document).ready(function () {
    setInterval(() => {
        i++;
        currentSlide(i);
        if (i == 3)
            i = 0;
    }, 180000)
});

let slideIndex = 1;
showSlides(slideIndex);

function plusSlides(n) {
    showSlides(slideIndex += n);
}

function currentSlide(n) {
    showSlides(slideIndex = n);
}

function showSlides(n) {
    let i;
    let slides = document.getElementsByClassName("mySlides");
    let dots = document.getElementsByClassName("dot");
    if (n > slides.length) { slideIndex = 1 }
    if (n < 1) { slideIndex = slides.length }
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";
}
