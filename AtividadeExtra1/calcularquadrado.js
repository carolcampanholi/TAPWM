var a = parseFloat(prompt("Digite o primeiro número: "));
var b = parseFloat(prompt("Digite o segundo número: "));
var c = parseFloat(prompt("Digite o último número: "));

function isNumber(value) {
  return !isNaN(parseFloat(value)) && isFinite(value);
}

function calcularQuadrados(a, b, c) {
  if (isNumber(a) && isNumber(b) && isNumber(c)) {
    const soma = a + b + c;
    const quadradoA = a * a;
    const quadradoB = b * b;
    return "A soma dos três números é: " + soma + ", o quadrado do primeiro é: " + quadradoA + " e o quadrado do segundo é: " + quadradoB;
  } else {
    return "Por favor, insira três números válidos.";
  }
}

var resultado = calcularQuadrados(a, b, c);
alert(resultado);
