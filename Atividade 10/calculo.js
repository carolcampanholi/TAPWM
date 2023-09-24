var a = parseFloat(prompt("Digite um valor de A: "));
var b = parseFloat(prompt("Digite um valor de B: "));
var c = parseFloat(prompt("Digite um valor de C: "));

function isNumber(value) {
    return !isNaN(parseFloat(value)) && isFinite(value);
  }

function validarTriangulo(a, b, c) {
    if (
      a + b > c &&
      a + c > b &&
      b + c > a &&
      isNumber(a) &&
      isNumber(b) &&
      isNumber(c)
    ) {
      if (a === b && b === c) {
        return "É um triângulo equilátero";
      } 
      else if (a === b || b === c || a === c) {
        return "É um triângulo isósceles";
      } 
      else {
        return "É um triângulo escaleno";
      }
    } 
    else {
      return "Não é um triângulo válido";
    }
  }

var resultado = validarTriangulo(a, b, c);
alert(resultado);


  