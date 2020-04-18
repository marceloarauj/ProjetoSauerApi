# instalar o cli do dotnet ef
dotnet tool install --global dotnet-ef

# Criar arquivo de migrations
dotnet ef migrations add Migrations --context Context

# Atualizar banco com as tabelas
dotnet ef database update --context Context


# Trabalhando com asp net core fluent api
https://docs.microsoft.com/pt-br/ef/ef6/modeling/code-first/fluent/relationships