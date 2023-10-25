function Retangulo(base, altura) {
    this.base = base;
    this.altura = altura;
    
    this.calcularArea = function() {
      return this.base * this.altura;
    };
  }
  
  var retangulo = new Retangulo(5, 10);
  var area = retangulo.calcularArea();
  alert("A área do retângulo é: " + area);
  
  //segunda opçao:
/* var retangulo = {
    base: 8,
    altura: 20,
    calcularArea: function() {
      return this.base * this.altura;
    }
  };
  
  // Chamar o método para calcular a área
  var area = retangulo.calcularArea();
  
  alert("A área do retângulo é: " + area); 
  */

  