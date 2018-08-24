Para a implementação do sistema proposto, optei por utilizar o padrão de projeto MVC. 
Já o módulo de persistencia de dados, como na especificação não mencionava a necessidade de utilização 
de um banco de dados, opei por uma solução mais simples utilizando arquivos .CSV. Além disso, o acesso
ao módulo responsável pelo banco é feito utilizando o padrão singleton, viabilizando, assim, futuras 
mudanças na base somente alterando a classe "SingletonTXT" por uma equivalente que implemente a interface
"ISingleton".




Dentre as funcionalidades, estão:
#Criação de usuário informando nome, login e senha, onde o login é único;
#Acesso ao sistema mediante login e senha;
#Escolher/Votar em um restaurante qualquer selecionando uma data;
#Visualizar o restaurante com maior número de votos até o momente e que ainda não tenha sido o eleito na semana. Considerando que a semana inicia no domingo e termina no sábado.

