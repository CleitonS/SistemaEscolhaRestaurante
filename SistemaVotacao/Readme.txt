Para a implementa��o do sistema proposto, optei por utilizar o padr�o de projeto MVC. 
J� o m�dulo de persistencia de dados, como na especifica��o n�o mencionava a necessidade de utiliza��o 
de um banco de dados, opei por uma solu��o mais simples utilizando arquivos .CSV. Al�m disso, o acesso
ao m�dulo respons�vel pelo banco � feito utilizando o padr�o singleton, viabilizando, assim, futuras 
mudan�as na base somente alterando a classe "SingletonTXT" por uma equivalente que implemente a interface
"ISingleton".




Dentre as funcionalidades, est�o:
#Cria��o de usu�rio informando nome, login e senha, onde o login � �nico;
#Acesso ao sistema mediante login e senha;
#Escolher/Votar em um restaurante qualquer selecionando uma data;
#Visualizar o restaurante com maior n�mero de votos at� o momente e que ainda n�o tenha sido o eleito na semana. Considerando que a semana inicia no domingo e termina no s�bado.

