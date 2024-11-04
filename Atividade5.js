const fs = require('fs');
const path = require('path');
const readline = require('readline');

// Criar interface de leitura de dados
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

// Função para solicitar dados do usuário
function solicitarDados() {
  rl.question('Digite seu nome: ', (nome) => {
    rl.question('Digite sua idade: ', (idade) => {
      rl.question('Digite seu telefone: ', (telefone) => {
        rl.question('Digite seu endereço: ', (endereco) => {
          rl.question('Digite sua profissão: ', (profissao) => {
            
            // Validar tipo de idade
            if (isNaN(idade) || idade <= 0) {
              console.log('Idade inválida. Por favor, insira um número válido para a idade.');
              rl.close();
              return;
            }

            // Criar a pasta Currículos caso não exista
            const curriculosDir = './Currículos';
            if (!fs.existsSync(curriculosDir)) {
              try {
                fs.mkdirSync(curriculosDir);
                console.log('Pasta "Currículos" criada com sucesso!');
              } catch (err) {
                console.error('Erro ao criar a pasta Currículos:', err);
                rl.close();
                return;
              }
            }

            // Criar a pasta da profissão caso não exista
            const profissaoDir = path.join(curriculosDir, profissao);
            if (!fs.existsSync(profissaoDir)) {
              try {
                fs.mkdirSync(profissaoDir);
                console.log(`Pasta "${profissao}" criada com sucesso!`);
              } catch (err) {
                console.error(`Erro ao criar a pasta para a profissão ${profissao}:`, err);
                rl.close();
                return;
              }
            }

            // Criar o arquivo com o nome do usuário e armazenar os dados
            const arquivoCandidato = path.join(profissaoDir, `${nome}.txt`);
            const dadosCandidato = `
            Nome: ${nome}
            Idade: ${idade}
            Telefone: ${telefone}
            Endereço: ${endereco}
            Profissão: ${profissao}
            `;

            try {
              fs.writeFileSync(arquivoCandidato, dadosCandidato);
              console.log(`Currículo de ${nome} salvo com sucesso na pasta "${profissao}"!`);
            } catch (err) {
              console.error('Erro ao salvar o currículo:', err);
              rl.close();
              return;
            }

            // Perguntar se o usuário deseja cadastrar outro currículo
            rl.question('Deseja cadastrar outro currículo? (s/n): ', (resposta) => {
              if (resposta.toLowerCase() === 's') {
                solicitarDados();  // Chamar a função novamente para nova submissão
              } else {
                console.log('Obrigado por utilizar o banco de talentos!');
                rl.close();
              }
            });

          });
        });
      });
    });
  });
}

// Iniciar o processo de coleta de dados
solicitarDados();
