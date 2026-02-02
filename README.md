# OrderSystem - Gestão de Contratos e Composição 🚀

Este projeto faz parte do meu roadmap de estudos em C# e .NET. O foco principal aqui foi aplicar conceitos avançados de **Programação Orientada a Objetos** para resolver problemas de escalabilidade de dados.

## 🎯 Objetivo do Projeto
Desenvolver um sistema que gerencie trabalhadores, seus departamentos e múltiplos contratos de horas, permitindo o cálculo consolidado de renda por período.

## 🛠️ Tecnologias e Conceitos Aplicados
* **C# / .NET 10**
**Enums:** Utilizados para padronizar níveis de experiência (WorkerLevel).
**Composição de Objetos:** Implementação da relação "tem-muitos" entre `Worker` e `HourContract`, evitando herança desnecessária.
**LINQ / Manipulação de Listas:** Lógica para filtrar e somar valores de contratos baseados em mês e ano.

## 📊 Status: Em Desenvolvimento 🚧
O projeto está na fase de lógica de negócio via Console.
- [x] Modelagem de Entidades (Worker, Department, HourContract)
- [x] Implementação de Enums (WorkerLevel)
- [x] Cálculo de renda mensal com composição
- [ ] Persistência de dados em Banco de Dados (Próximo passo)
- [ ] Interface Web/API (Planejado)

## 💻 Como executar
1. Clone o repositório.
2. Certifique-se de ter o SDK do .NET instalado.
3. Execute o comando `dotnet run` na pasta do projeto.
