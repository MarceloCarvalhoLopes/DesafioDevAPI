# Desafio API

## Criação da API para vaga de analista/desenvolvedor.
Desenvolvido uma API em C# para testar os conhecimentos solicitados a vaga.

## Tecnologias utilizadas.


* .Net 8
* AspNetCore.Authentication.JwtBearer
* EntityFrameworkCore
* EntityFrameworkCore.Design
* EntityFrameworkCore.SqlServer
* EntityFrameworkCore.Tools
* IdentityModel.Tokens.Jwt

## End-points.
### Cliente Conta
* Get / Cliente
* Post / Cliente
* Put / Cliente
* Delete / Cliente
* Get / Cliente by Id
* Get / Cliente by UF

  <p align="left">
    <img src="assets/to_readme/allendpoints.png">
  </p>

### Conta

* Post / Conta

## Executando a API

Abra a API em sua IDE de preferência, deve ter instalado o banco Sql Server em
sua máquina. Executar os comandos abaixo pelo Package Manager Console para gerar
o Banco de Dados e as Tabelas.

add-migration first-migration e update-database

Após criação do banco pode ser executado a API que irá carregar no navegador
padrão https://localhost:7202/swagger/index.html

Para utilizar os end-points primeiro é necessário logar na API através do 
end-point Conta informando login e password

```
{
  "login": "admin",
  "password": "admin"
}
```

No Response body da requisição irá gerar o token que deve ser copiado para logar
na API e liberar os demais end-points.
