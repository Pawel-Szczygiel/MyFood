

const navSlide = () => {

    const menuIcon = document.querySelector('.hamburger-menu');
    const navbar = document.querySelector('.navbar');
    const line1 = document.querySelector('.line-1');
    const line3 = document.querySelector('.line-3');
    const navLinks = document.querySelectorAll('.nav-list li');


    menuIcon.addEventListener('click', () => {
        //--- Toggle Nav ---
        menuIcon.classList.toggle('change');
        navbar.classList.toggle('change');
        line1.classList.toggle('red');
        line3.classList.toggle('red');

        // --- Animation links ---
        navLinks.forEach((link, index) => {
            if (link.style.animation) {
                link.style.animation = '';
            } else {
                link.style.animation = `Fade 0.5s ease forwards ${index / 7 + 0.5}s`;
            }

        });
    });
}


const loginForm = () => {

    const signup = document.querySelector('.signup');
    const signin = document.querySelector('.signin');
    const container = document.querySelector('.wraper');


    const toggleForm = () => {

        container.classList.toggle('active');
        console.log("click");
    }
    
    signup.addEventListener('click', toggleForm);
    signin.addEventListener('click', toggleForm);

}


    const rangeSlide = (value) => {
        const rangeValue = document.querySelector(".rangeValue");
        rangeValue.textContent = value;
        console.log(value);
    };

    window.addEventListener('scroll', () => {
        const scroll = document.querySelector('.scrollTop');
        scroll.classList.toggle("up", window.scrollY > 200)
    })    

    const scrollToTop = () => {
      window.scrollTo({
          top: 0,
          behavior: 'smooth'
      })
    }


const showToaster = document.querySelector('.showToaster');
const toastr = document.querySelector('.toastr');




const init = () => {
    navSlide();
    loginForm();
    rangeSlide();
};

init();

