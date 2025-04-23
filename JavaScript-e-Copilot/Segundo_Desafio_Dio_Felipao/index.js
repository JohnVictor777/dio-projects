// Importando biblioteca de prompt-sync
const prompt = require("prompt-sync")();

console.clear();
console.log(
  "==================== QUAL MEU NIVEL DE HERÓI ====================\n"
);

function jogador(vitorias, derrotas) {
  // Subtrai parametros
  let saldoVitorias = vitorias - derrotas;
  let continua = true;
  let nivel = "";

  // Inicio de laço de repitição. Só finaliza se jogador desejar
  while (continua) {
    if (saldoVitorias <= 10) {
      nivel = "Ferro";
    } else if (saldoVitorias >= 11 && saldoVitorias <= 20) {
      nivel = "Bronze";
    } else if (saldoVitorias >= 21 && saldoVitorias <= 50) {
      nivel = "Prata";
    } else if (saldoVitorias >= 51 && saldoVitorias <= 80) {
      nivel = "Ouro";
    } else if (saldoVitorias >= 81 && saldoVitorias <= 90) {
      nivel = "Diamante";
    } else if (saldoVitorias >= 91 && saldoVitorias <= 100) {
      nivel = "Lendário";
    } else {
      nivel = "Imortal";
    }

    // SAIDA
    console.log(
      `O Herói tem de saldo de ${saldoVitorias} está no nível de ${nivel} \n`
    );

    // Pergunta para o jogador se deseja fazer outra somatoria de nivel
    let resposta = prompt("Deseja refazer a somatoria de nivel? (s/n): ");
    if (resposta.toLowerCase() === "s") {
      console.clear();
      console.log(
        "==================== QUAL MEU NIVEL DE HERÓI ====================\n"
      );
      // Entrada de novos dados no parametro de vitorias e derrotas
      vitorias = parseInt(prompt("Digite número de vitórias: "));
      derrotas = parseInt(prompt("Digite número de derrotas: "));
      saldoVitorias = vitorias - derrotas;
    } else {
      continua = false;
      console.log("Encerrando o jogo... \n");
    }
  }
}

// Chamada inicial com entrada de dados
jogador(
  parseInt(prompt("Digite número de vitórias: ")),
  parseInt(prompt("Digite número de derrotas: "))
);
