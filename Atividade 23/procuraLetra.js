function procura(texto) {
    var contadorA = 0;
  
    for (var i = 0; i < texto.length; i++) {
      if (texto[i] === 'a' || texto[i] === 'A') {
        contadorA++;
      }
    }
    console.log("Número de letras 'A': " + contadorA);
  }
  
  // Teste
  var textoExemplo = "Tem três A nesse texto, a, A";
  procura(textoExemplo);