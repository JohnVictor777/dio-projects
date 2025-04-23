// Importação da biblioteca protmpt-sync para utilizar o prompt
const prompt = require("prompt-sync")();
//Criando a classe para representar Hero
class Hero {
  constructor(nome, idade, tipo, ataque) {
    this.nome = nome;
    this.idade = idade;
    this.tipo = tipo;
    this.ataque = ataque;
  }
  //Metodo para saida de dados(Exibir informações do úsuario)
  info() {
    console.log("========== COMBAT ZONE ==========\n");
    return `O ${this.tipo} atacou usando ${this.ataque} \n`;
  }
}

let continua = true;

while (continua) {
  console.clear();
  //Exibe as opções de heróis
  console.log(
    "Qual heroi deseja acompanhar? \n=> Digite o número desejado:",
    " \n 1 - Guerreiro \n 2 - Mago \n 3 - Monge \n 4 - Ninja \n 5 - Fugir da batalha!\n"
  );
  let resp = parseInt(prompt("Digite aqui: "));

  // Estrutura Condicional para para selecionar o herói baseado na escolha do usuário
  switch (resp) {
    case 1:
      console.clear();
      let hero1 = new Hero("Yasuki", 30, "guerreiro", "espada");
      console.log(hero1.info());
      break;
    case 2:
      console.clear();
      hero2 = new Hero("Patolino", 20, "Mago", "Mágia");
      console.log(hero2.info());
      break;

    case 3:
      console.clear();
      hero3 = new Hero("Kuriri", 27, "Monge", "artes marciais");
      console.log(hero3.info());
      break;

    case 4:
      console.clear();
      hero4 = new Hero("Naruto", 15, "Ninja", "shuriken");
      console.log(hero4.info());
      break;

    case 5:
      console.clear();
      console.log("Fungindo da batalha... \n");
      process.exit();
      break;
    default:
      console.log("Esse heroi infelizmente morr... \n");
  }
  //
  if (continua) {
    prompt("Pressione ENTER para continuar...");
  }
}

consolo.log("Fugindo da batalha...");
