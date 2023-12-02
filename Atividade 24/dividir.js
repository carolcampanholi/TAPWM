function dividir(a, b) {
    // NaN
    if (isNaN(a / b)) {
      console.log("Divisão deu NaN");
    } else {
      // Infinity
      if (!isFinite(a / b)) {
        console.log("Divisão de Infinity");
      } else {
        // Retornar o valor da divisão
        console.log("Divisão =", a / b);
      }
    }
  }
  
  // Teste
  dividir(10, 2);      
  dividir(5, 0);       
  dividir(0, 5);       
  dividir(undefined, 5);  
  dividir(10, undefined);  
  dividir(null, 5);    
  dividir(10, null);   
  dividir(null, null);