
const janela = document.getElementById("janela");
const h1 = document.querySelector("h1");


function abrirJanela() {
    janela.src = "Imagens/gato sorrindo.jpg";
    h1.textContent = "Janela Aberta";
}


function fecharJanela() {
    janela.src = "Imagens/gato fazendo pose.jpg";
    h1.textContent = "Janela Fechada";
}


function quebrarJanela() {
    janela.src = "Imagens/gato desconfiado.jpg";
    h1.textContent = "Janela Quebrada";
}


janela.addEventListener("mouseover", abrirJanela);
janela.addEventListener("mouseout", fecharJanela);
janela.addEventListener("click", quebrarJanela);
