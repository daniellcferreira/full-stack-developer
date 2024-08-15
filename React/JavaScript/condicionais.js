// if
const idade = 45;

if (idade > 18) {
  console.log("Maior que Idade");
} else {
  console.log("Menor de Idade");
}

// switch
const nota = 9;

switch (nota) {
  case nota < 5:
    console.log("Abaixo da média");
    break;
  case nota > 5:
    console.log("Na média");
    break;
  default:
    console.log("Acima de média");
    break;
}

// ternarios
const nota2 = 8;

nota2 > 5 ? console.log("aprovado") : console.log("reprovado");
