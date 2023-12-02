function ordena(num1, num2, num3, num4, num5) {
   
    var numeros = [num1, num2, num3, num4, num5];

    numeros.sort(function(a, b) {
      return b - a;
    });
    
    alert("Números em ordem decrescente:", numeros);
  }
  
  
  ordena(10, 45, 6, 78, 5);
  