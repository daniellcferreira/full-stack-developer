// Arrays

const alunos = [
  {
    nome: "Pedro",
    idade: 42,
  },
  {
    nome: "Ana",
    idade: 16,
  },
  {
    nome: "Andre",
    idade: 35,
  },
];

// filter
const alunosFiltrados = alunos.filter((aluno) => aluno.idade >= 18);
console.log(alunosFiltrados);

// find
const alunoAna = alunos.find((aluno) => aluno.nome == "Ana");
console.log(alunoAna);

// findIndex
const alunoAnaIndex = alunos.findIndex((aluno) => aluno.nome == "Ana");
console.log(alunoAnaIndex);

// reduce
const idades = alunos.reduce((acc, aluno) => {
  return acc + aluno.idade;
}, 0);
console.log(idades);

// some
const acimaNove = alunos.some((alunos) => alunos.idade < 10);

console.log(acimaNove);

// every
const menorNoventa = alunos.every((alunos) => alunos.idade < 90);

console.log(menorNoventa);
