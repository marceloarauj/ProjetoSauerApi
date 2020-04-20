# instalar o cli do dotnet ef
dotnet tool install --global dotnet-ef

# Criar arquivo de migrations
dotnet ef migrations add Migrations --context Context

# Atualizar banco com as tabelas
dotnet ef database update --context Context

# Diretorios
-   Contexts possui uma classe que cria o contexto para acessar o banco de dados
-   Configurations possui arquivos gerais de configuração como inversão de controle,criptografia,token,etc 
-   Controllers possui as urls de acesso à api
-   DTO possui os objetos que transitam pela api , entrada do usuário e saídas para o usuario
-   Entity é o mapeamento dos objetos da pasta Models para tabelas e relacionamentos do banco
-   Service é chamado pelos controllers, possui as regras de negócio e validações
-   Repositories é chamado pelas services, utiliza o contexts para acessar o banco e retornar dados   

# Trabalhando com asp net core fluent api
https://docs.microsoft.com/pt-br/ef/ef6/modeling/code-first/fluent/relationships

