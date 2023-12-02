function criarObjeto() {
    
    var nome = document.getElementById('nome').value;
    var dataNascimento = document.getElementById('dataNascimento').value;
    var matriculado = document.querySelector('input[name="matriculado"]:checked').value;
    var endereco = document.getElementById('endereco').value;

    
    var dataFormatada = new Date(dataNascimento);
    var dia = dataFormatada.getDate();
    var mes = dataFormatada.getMonth() + 1; 
    var ano = dataFormatada.getFullYear();
    dataFormatada = dia + '/' + mes + '/' + ano;

    
    var inscrito = {
      nome: nome,
      dataNascimento: dataFormatada,
      matriculado: matriculado === 'sim' ? 'está inscrito' : 'NÃO foi inscrito porque não atende aos requisitos',
      endereco: endereco
    };

    alert(inscrito.nome + ' – ' + inscrito.dataNascimento + ' – ' + inscrito.endereco + ' – ' + inscrito.matriculado);
  }