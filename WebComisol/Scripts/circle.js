document.addEventListener('DOMContentLoaded', () => {

    const liContactanos = document.getElementById('liContactanos');

    liContactanos.addEventListener('mouseover', () => {
        document.getElementById('circle').classList.add('pulse');
    });

    liContactanos.addEventListener('mouseleave', () => {
        document.getElementById('circle').classList.remove('pulse');
    });

});