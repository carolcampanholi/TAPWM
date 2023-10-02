function MaiorNumero(num1, num2, num3, num4) {
    return Math.max(num1, num2, num3, num4);
  }
  
  function NumerosCrescente(num1, num2, num3, num4) {
    const numeros = [num1, num2, num3, num4];
    numeros.sort((a, b) => a - b);
    return numeros;
  }
  
