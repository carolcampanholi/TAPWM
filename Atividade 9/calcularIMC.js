var Altura = parseFloat(prompt("Informe a sua altura: "));
var Peso = parseFloat(prompt("Informe o seu peso atual: "));
var IMC = ((Peso) / ((Altura) * (Altura)));
IMC = Math.round(IMC,1);

if (IMC < 18.5){
alert("Seu IMC é: " + IMC.toFixed(1) + " Sua classificação de IMC é definida como Magreza");}

else if(IMC < 24.9){
    alert("Seu IMC é: " + IMC.toFixed(1) + " Sua classificação de IMC é definida como Normal");}
    
else if(IMC < 29.9){
    alert("Seu IMC é: " + IMC.toFixed(1) + " Sua classificação de IMC é definida como Sobrepeso");}
    
else if(IMC < 39.9){
    alert("Seu IMC é: " + IMC.toFixed(1) + " Sua classificação de IMC é definida como Obesidade");}

else {
    alert("Seu IMC é: " + IMC.toFixed(1) + " Sua classificação de IMC é definida como Obesidade Grave");}

