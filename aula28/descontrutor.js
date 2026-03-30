
const numeros = [1, 2, 3, 4, 5];
// const a = numeros[0];
// const b = numeros[1];
// const c = numeros[2];
// const d = numeros[3];
// const e = numeros[4];
const [a, b, c, d, e] = numeros;

console.log(a, b, c, d, e);

const pessoa = {
  nome: "João",
  idade: 30,
  cidade: "São Paulo",
};

const { nome, idade, cidade } = pessoa;

console.log(nome, idade, cidade);

======================= spread-rest.j

const numeros = [1, 2, 3, 4, 5];
const pessoas = [
  { nome: 'Ana Silva', idade: 28, email: 'ana.silva@example.com', cidade: 'São Paulo' },
  { nome: 'Bruno Costa', idade: 35, email: 'bruno.costa@example.com', cidade: 'Rio de Janeiro' },
  { nome: 'Carla Souza', idade: 22, email: 'carla.souza@example.com', cidade: 'Belo Horizonte' },
  { nome: 'Daniel Pereira', idade: 41, email: 'daniel.pereira@example.com', cidade: 'Curitiba' },
  { nome: 'Eva Lima', idade: 30, email: 'eva.lima@example.com', cidade: 'Porto Alegre' }];