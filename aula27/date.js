const agora = new Date().getMonth() + 1;
const hoje = new Date();
const mesPorExtenso = hoje.toLocaleString("pt-BR", { month: "long" });
const diaPorExtenso = hoje.toLocaleString("pt-BR", { weekday: "long" });

console.log(`Mês atual: ${agora}`);
console.log(`Mês por extenso: ${mesPorExtenso}`);
console.log(`Dia da semana: ${diaPorExtenso}`);
console.log(hoje.getDay() + 1);
console.log(hoje.getHours());
console.log(hoje.getMinutes());
console.log(hoje.getSeconds());
console.log(hoje.getFullYear());
console.log(hoje.getTime());
