// Importação para podermos utilizar o prompt
const prompt = require("prompt-sync")();
// Tomada de decisão para saber o laço de repitição continua ou não
let continuar = true;

// lAÇO DE REPETIÇÃO
while (continuar) {
  // Variaveis
  console.clear();
  let nomeHeroi = prompt("Digite o nome do Herói: ");
  let xpHeroi = parseInt(prompt("Digite a quantidade de Xp do Herói: "));
  let nivelHeroi = "";

  // Condicionais para o nivel do heroi
  if (xpHeroi <= 1000) {
    nivelHeroi = "Ferro";
  } else if (xpHeroi >= 1001 && xpHeroi <= 2000) {
    nivelHeroi = "Bronze";
  } else if (xpHeroi >= 2001 && xpHeroi <= 5000) {
    nivelHeroi = "Prata";
  } else if (xpHeroi >= 5001 && xpHeroi <= 7000) {
    nivelHeroi = "Ouro";
  } else if (xpHeroi >= 7001 && xpHeroi <= 8000) {
    nivelHeroi = "Platina";
  } else if (xpHeroi >= 8001 && xpHeroi <= 9000) {
    nivelHeroi = "Ascendente";
  } else if (xpHeroi >= 9001 && xpHeroi <= 10000) {
    nivelHeroi = "Imortal";
  } else {
    nivelHeroi = "Radiante";
  }

  // SAIDA
  console.log(`O Herói de nome ${nomeHeroi} está no nível de ${nivelHeroi} \n`);

  // Pergunta se o usuário deseja continuar
  let resposta = prompt("Deseja cadastrar outro herói? (s/n): ");
  if (resposta.toLowerCase() !== "s") {
    continuar = false;
  }
}
