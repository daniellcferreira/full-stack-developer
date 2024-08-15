// FOR

for (let i = 1; i < 10; i++) {
  console.log("Valor", i);
}

//exemplo 2
for (let i = 1; i < 11; i++) {
  console.log(`${i} x 5 = ${i * 5}`);
}

// WHILE

let i = 1;
while (i < 10) {
  console.log(`${i} x 5 = ${i * 5}`);
  i++;
}

// FOREACH
const valores = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
valores.forEach((value) => {
  console.log(`${value} x 5 = ${value * 5}`);
});

// MAP
const valores1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
const resultado = valores1.map((value) => {
  return value * 5;
});

console.log(resultado);
