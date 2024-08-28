let contador = 1;
let cambio = false;
function agregarElemento() {
    const lista = document.getElementById('lista');
    const nuevoElemento = document.createElement('li');
    nuevoElemento.textContent = `Elemento ${contador}`;
    lista.appendChild(nuevoElemento);
    contador++;
}

function eliminarElemento() {
    const lista = document.getElementById('lista');
    if (lista.lastChild) {
        lista.removeChild(lista.lastChild);
        contador--;
    }
}

function cambiarColorFondo() {
    const body = document.body;
    if (cambio) {
        body.style.backgroundColor = 'white';
    } else {
        body.style.backgroundColor = 'darkslategrey'; // Cambia este color a tu preferencia
    }
    cambio = !cambio;
}