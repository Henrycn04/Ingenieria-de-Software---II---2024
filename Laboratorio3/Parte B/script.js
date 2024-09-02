let contador = 1;
let cambio = false;

function agregar() {
    const lista = document.getElementById('lista');
    const nuevoElemento = document.createElement('li');
    nuevoElemento.textContent = `Elemento ${contador}`;
    lista.appendChild(nuevoElemento);
    contador++;
}

function borrar() {
    const lista = document.getElementById('lista');
    if (lista.lastChild) {
        lista.removeChild(lista.lastChild);
        contador--;
    }
}

function cambiarFondo() {
    const body = document.body;
    const list = document.getElementById('lista');
    if (cambio) {
        body.style.backgroundColor = 'white';
        list.style.color = 'black';
    } else {
        body.style.backgroundColor = 'darkslategrey';
        list.style.color = 'white';
    }
    cambio = !cambio;
}