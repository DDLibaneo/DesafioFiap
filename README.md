# DesafioFiap

### Especificações de sistema
Para rodar esse projeto é necessario 
- Visual Studio 2017 ou versão mais recente;
- Sistema operacional windows, preferecialmente Windows 10;
- SQL Server instalado;

### Ferramentas utilizadas
Foi utilizado ASP.NET MVC para desenvolver este projeto, e Enitity Framework para criar o banco de dados com migrações code-first.

### Passos para rodar o projeto
##### 1. Preparando o ambiente
Abra a solução no Visual Studio e em seguida abra o Nuget Package Manager Console. Ele notificará que algumas Packages estão faltando no projeto e dará a opção de baixar as dependencias.

##### 2. Gerando o banco de dados 
No Nuget Package Manager Console digite `enable-migrations`. Depois digite o comando `update-database` Isso irá criar uma base de dados no Servidor local `(LocalDb)\MSSQLLocalDB`.

Alternativamente, você pode rodar o script gerado pelo Entity Framework que está no root do projeto, em um arquivo chamado `full-migration-sql-script.sql`, rodar em uma base de dados e apontar para essa base no Web.Config.

##### 3. Rode o projeto
Rode o projeto DesafioFiap clicando no botão Run do Visual Studio. 

##### 4. Autenticação
Para acessar a tela de Administração da Newsletter é necessario fazer login. Use o seguinte usuario admin padrão:
- User: admin@gmail.com
- Senha: 1234567aA!

##### 5. Utilizando as funcionalidades
Todas funcionalidades estão no menu no topo da tela. As funcionalidades "Administração Newsletter" e "Novo Admin" exigem um usuario logado para ser utilizada.
