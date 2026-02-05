# 🚀 P001 - .NET CORE + ANGULAR PARA LEIGOS ABSOLUTOS
## HELLO WORLD ULTRA-SIMPLIFICADO COM EXPLICAÇÃO LINHA POR LINHA

---

## 🧠 **NEUROCIÊNCIA: .NET + ANGULAR SIMPLIFICADO**

👨‍🏫 **O Professor Explica**:  
> *"Erro meu! .NET Core + Angular pode ser SIMPLES para leigos SE explicarmos cada linha. Vamos criar o menor Hello World possível, mas explicando TUDO: por que .NET? Por que Angular? O que faz cada comando?"*

### 💼 **CASO REAL: SENIOR PEDRO SANTOS - TECH LEAD BANCO INTER**

> *"No Banco Inter, treinamos estagiários em .NET + Angular. Segredo: começar com 3 arquivos apenas! 1 controller, 1 component, pronto. Depois evoluir. Zero complexidade inicial."*

---

## ⏰ **MICRO-ETAPA 1A: .NET API MÍNIMA (5 MINUTOS)**

### 🎯 **OBJETIVO**: 1 endpoint funcionando com explicação total

#### **✅ STEP 1: CRIAR API MÍNIMA (2 MINUTOS)**

```powershell
# 🧠 O QUE ESTAMOS FAZENDO?
# Criando uma "API" = programa que responde perguntas via internet
# POR QUE .NET? Criado pela Microsoft, muito usado em empresas

# Criar pasta do projeto
mkdir HelloWorldSimples
cd HelloWorldSimples

# 🎯 Comando mágico: criar API mínima
dotnet new webapi --name HelloApi

# 🧠 O QUE SIGNIFICA ISSO?
# dotnet = ferramenta da Microsoft para criar programas
# new webapi = "crie uma nova API"
# --name HelloApi = "chame de HelloApi"  
# (Se aparecer erro sobre --minimal, ignore: o template padrão já serve para leigos)
```

#### **✅ STEP 2: VER O QUE FOI CRIADO (1 MINUTO)**

```powershell
cd HelloApi
dir

# 🧠 ARQUIVOS CRIADOS:
# Program.cs = arquivo principal (onde tudo começa)
# HelloApi.csproj = configurações do projeto
# Controllers/WeatherForecastController.cs = controlador de exemplo (pode remover para simplificar)
# Properties/ = configurações avançadas
```

#### **✅ STEP 3: ENTENDER O ARQUIVO PRINCIPAL (2 MINUTOS)**
**IMPORTANTE:** Para que a documentação automática (Swagger) funcione, precisamos instalar um pacote extra. Execute este comando na pasta do projeto:

```powershell
dotnet add package Swashbuckle.AspNetCore
```

```csharp
// 📄 Program.cs - EXPLICAÇÃO LINHA POR LINHA
// 🧠 Este arquivo é o "coração" da nossa API

var builder = WebApplication.CreateBuilder(args);
// ⬆️ O QUE FAZ? Cria um "construtor" de aplicação web
// POR QUE? É como dizer "quero fazer um programa web"

builder.Services.AddEndpointsApiExplorer();
// ⬆️ O QUE FAZ? Adiciona documentação automática
// POR QUE? Para vermos quais "perguntas" nossa API responde

builder.Services.AddSwaggerGen();
// ⬆️ O QUE FAZ? Adiciona interface visual para testar
// POR QUE? É como ter um "painel de controle" da API

var app = builder.Build();
// ⬆️ O QUE FAZ? "Constrói" a aplicação
// POR QUE? É como "ligar" nossa API

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// ⬆️ O QUE FAZ? Se estamos desenvolvendo, mostra o painel
// POR QUE? Só queremos o painel enquanto testamos

app.UseHttpsRedirection();
// ⬆️ O QUE FAZ? Força usar conexão segura (https)
// POR QUE? Segurança = importante sempre

// 🎯 NOSSA PRIMEIRA "PERGUNTA" QUE A API RESPONDE
app.MapGet("/hello", () => "Olá! Eu sou uma API .NET!");
// ⬆️ O QUE FAZ? Quando alguém vai em "/hello", responde com texto
// POR QUE? É nosso Hello World mais simples possível

app.Run();
// ⬆️ O QUE FAZ? "Liga" a API e fica esperando perguntas
// POR QUE? É como "abrir a loja" para receber clientes
```

---

## 🧩 **CHECKPOINT COGNITIVO 1A - ENTENDEU .NET?**

### ❓ **PERGUNTAS PARA LEIGOS**:

1. **"O que é uma API?"**
   - 🟢 **Resposta**: Programa que responde perguntas via internet

2. **"O que faz `app.MapGet("/hello")`?"**  
   - 🟢 **Resposta**: Quando alguém vai em "/hello", responde com texto

3. **"Por que usar Swagger?"**
   - 🟢 **Resposta**: É como um "painel de controle" para testar nossa API

### 🎮 **EXERCÍCIO PRÁTICO**:
```powershell
# Rodar a API e ver funcionando
dotnet run

# Se aparecer erro sobre Swagger, volte e execute:
dotnet add package Swashbuckle.AspNetCore

# Acessar no navegador: https://localhost:5001/hello
# Ver o texto: "Olá! Eu sou uma API .NET!"
```

**🚀 PRÓXIMO: PARTE 1B - Angular mínimo consumindo nossa API!**

**📊 PROGRESSO**: .NET API funcionando | ⏰ 5 minutos | 🧠 Conceitos: API, endpoint, Swagger