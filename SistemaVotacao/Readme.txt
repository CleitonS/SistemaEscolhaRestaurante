Para a implementa��o do sistema proposto, optei por utilizar o padr�o de projeto MVC. 
J� o m�dulo de persist�ncia de dados, como na especifica��o n�o mencionava a necessidade de criar um banco de dados, opei por uma solu��o mais simples utilizando arquivos .CSV. Al�m disso, o acesso
ao m�dulo respons�vel por ler e escrever no banco � feito utilizando o padr�o singleton, viabilizando, assim, futuras mudan�as de base somente alterando a classe "SingletonTXT" por uma equivalente que implemente a interface "ISingleton".


Dentre as funcionalidades, est�o:
#Cria��o de usu�rio informando nome, login e senha, onde o login � �nico;
#Acesso ao sistema mediante login e senha;
#Escolher/Votar em um restaurante qualquer selecionando uma data e digitando o nome do restaurante ou selecionando na caixa de sele��o;
#Visualizar o restaurante com maior n�mero de votos at� o momento e que ainda n�o tenha sido o eleito na semana. Considerando que a semana inicia no domingo, termina no s�bado e, em caso de empate de votos, o restaurante escolhido � o primeiro inserido.


Instala��o/Execu��o
Para executar o projeto, basta abrir o arquivo "ExecutarSistema.exe" presente neste mesmo diret�rio.
Na primeira execu��o, dois arquivos ".txt" ser�o criados em: "<Diret�rioRaiz>\Users\<NomeUsu�rio>" os quais ser�o utilizados para armazenar os dados do sistema. 
