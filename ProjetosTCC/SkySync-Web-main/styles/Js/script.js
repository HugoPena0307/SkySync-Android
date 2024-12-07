window.onload = function() {
    if (localStorage.getItem('cookiesAccepted')) {
        document.getElementById('cookie-banner').style.display = 'none';
    }
    document.getElementById('accept-cookies').onclick = function() {
        localStorage.setItem('cookiesAccepted', 'true');
        document.getElementById('cookie-banner').style.display = 'none';
    };
    document.getElementById('reject-cookies').onclick = function() {
        localStorage.setItem('cookiesAccepted', 'false');
        document.getElementById('cookie-banner').style.display = 'none';
    };
    document.getElementById('close-button').onclick = function() {
        localStorage.setItem('cookiesAccepted', 'false');
        document.getElementById('cookie-banner').style.display = 'none';
    };
};

document.addEventListener("DOMContentLoaded", function() {
    const links = document.querySelectorAll("a");
                
    links.forEach(link => {
        link.addEventListener("click", function(event) {
            event.preventDefault();
            const href = this.href;
            document.body.classList.add("fade-out");
            setTimeout(() => {
                window.location.href = href;
            }, 500);
        });
    });
});
            
document.body.classList.add("fade-in");
    setTimeout(() => {
        document.body.classList.add("fade-in-active");
    }, 50);

document.getElementById('btn-saibamais').onclick = function() {
    window.location.href = 'planos.html';
}

document.getElementById('btn-plano-anual').onclick = function() {
    window.location.href = 'cotacao.html';
}

document.getElementById('btn-plano-prime').onclick = function() {
    window.location.href = 'cotacao.html';
}

document.getElementById('btn-plano-ilimitado').onclick = function() {
    window.location.href = 'cotacao.html';
}
