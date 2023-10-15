var palavra1 = prompt("Informe a primeira palavra: ");
var palavra2 = prompt("Informe a segunda palavra: ");

function verificar (palavra1, palavra2) {
  if (!palavra1 || !palavra2) {
    return "erro";
  }

  if (palavra1.includes(palavra2)) {
    return "é um subconjunto";
  } else {
    return "não é um subconjunto";
  }
}

var resultado = verificar (palavra1, palavra2);

if (resultado === "erro") {
  alert("Erro: uma ou ambas as palavras estão vazias/indefinidas.");
} else {
  alert("Resultado: A segunda palavra " + resultado + " da primeira.");
}
