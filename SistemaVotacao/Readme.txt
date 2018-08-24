Para a implementação do sistema proposto, optei por utilizar o padrão de projeto MVC. 
Já o módulo de persistência de dados, como na especificação não mencionava a necessidade de criar um banco de dados, opei por uma solução mais simples utilizando arquivos .CSV. Além disso, o acesso
ao módulo responsável por ler e escrever no banco é feito utilizando o padrão singleton, viabilizando, assim, futuras mudanças de base somente alterando a classe "SingletonTXT" por uma equivalente que implemente a interface "ISingleton".


Dentre as funcionalidades, estão:
#Criação de usuário informando nome, login e senha, onde o login é único;
#Acesso ao sistema mediante login e senha;
#Escolher/Votar em um restaurante qualquer selecionando uma data e digitando o nome do restaurante ou selecionando na caixa de seleção;
#Visualizar o restaurante com maior número de votos até o momento e que ainda não tenha sido o eleito na semana. Considerando que a semana inicia no domingo, termina no sábado e, em caso de empate de votos, o restaurante escolhido é o primeiro inserido.


Instalação/Execução
Para executar o projeto, basta abrir o arquivo "ExecutarSistema.exe" presente neste mesmo diretório.
Na primeira execução, dois arquivos ".txt" serão criados em: "<DiretórioRaiz>\Users\<NomeUsuário>" os quais serão utilizados para armazenar os dados do sistema. 
