console.log(Math.PI);
let raio = 8;
const area = Math.PI * Math.pow(raio, 2);
console.log("Área do círculo:", area.toFixed(2));

const raizQuadrada = Math.sqrt(16);
console.log("Raiz quadrada de 16:", raizQuadrada);

let x = Math.floor(4.8);
let z = Math.round(4.5);
let y = Math.ceil(4.2);
console.log("y:", y);
console.log("x:", x);
console.log("z:", z);

const min = 500;
const max = -500;

let a = Math.floor(Math.random());
console.log(a);

function gerarAleatorio(min, max) {
  return Math.floor(Math.random() * (max - min + 1)) + min;
}

console.log(
  `Número aleatório entre ${min} e ${max}: ${gerarAleatorio(min, max)}`,
);
