function initialiseMenu() {
    const menuHamburger = document.querySelector(".Menu-Hamburger");
    const navLinks = document.querySelector(".Navlinks");
    const liens = document.querySelectorAll(".lien");

    if (menuHamburger && navLinks) {
        menuHamburger.addEventListener('click', () => {
            navLinks.classList.toggle('mobile-menu');
        });
    }

    liens.forEach(lien => {
        lien.addEventListener('click', () => {
            liens.forEach(l => l.classList.remove('active'));
            lien.classList.add('active'); 
        });
    });
}
function showModal(modalId) {
    document.getElementById(modalId).style.display = "block";
}

function hideModal(modalId) {
    document.getElementById(modalId).style.display = "none";
}
