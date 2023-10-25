
function Conta(nomeCorrentista, banco, numeroConta, saldo) {
    this.nomeCorrentista = nomeCorrentista;
    this.banco = banco;
    this.numeroConta = numeroConta;
    this.saldo = saldo;
  }
  
  Conta.prototype.getNomeCorrentista = function() {
    return this.nomeCorrentista;
  };
  
  Conta.prototype.setNomeCorrentista = function(nome) {
    this.nomeCorrentista = nome;
  };
  
  Conta.prototype.getBanco = function() {
    return this.banco;
  };
  
  Conta.prototype.setBanco = function(novoBanco) {
    this.banco = novoBanco;
  };
  
  Conta.prototype.getNumeroConta = function() {
    return this.numeroConta;
  };
  
  Conta.prototype.setNumeroConta = function(numero) {
    this.numeroConta = numero;
  };
  
  Conta.prototype.getSaldo = function() {
    return this.saldo;
  };
  
  Conta.prototype.setSaldo = function(novoSaldo) {
    this.saldo = novoSaldo;
  };
  
 
  function contaCorrenteEspecial(nomeCorrentista, banco, numeroConta, saldo, limite) {
    Conta.call(this, nomeCorrentista, banco, numeroConta, saldo);
    this.limite = limite;
  }
  
  contaCorrenteEspecial.prototype = Object.create(Conta.prototype);
  
  
  function contaPoupancaJuros(nomeCorrentista, banco, numeroConta, saldo, taxaJuros, dataVencimento) {
    Conta.call(this, nomeCorrentista, banco, numeroConta, saldo);
    this.taxaJuros = taxaJuros;
    this.dataVencimento = dataVencimento;
  }
  
  contaPoupancaJuros.prototype = Object.create(Conta.prototype);
  var contaCorrente = new contaCorrenteEspecial("Xiaoting", "Banco WakeOne", "123456", 1000, 500);
  var contaPoupanca = new contaPoupancaJuros("ZhangHao", "Banco Yehua", "789012", 2000, 0.03, "01/12/2023");
  
 
alert("Dados da Conta Corrente com Saldo Especial:");
alert("Nome do Correntista: " + contaCorrente.getNomeCorrentista());
alert("Banco: " + contaCorrente.getBanco());
alert("Número da Conta: " + contaCorrente.getNumeroConta());
alert("Saldo: $" + contaCorrente.getSaldo());
alert("Limite de Saldo Especial: $" + contaCorrente.limite);

alert("\nDados da Conta Poupança com Juros:");
alert("Nome do Correntista: " + contaPoupanca.getNomeCorrentista());
alert("Banco: " + contaPoupanca.getBanco());
alert("Número da Conta: " + contaPoupanca.getNumeroConta());
alert("Saldo: $" + contaPoupanca.getSaldo());
alert("Taxa de Juros: " + (contaPoupanca.taxaJuros * 100) + "%");
alert("Data de Vencimento: " + contaPoupanca.dataVencimento);