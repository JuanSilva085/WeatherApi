# WeatherApi

![Weather_App](https://github.com/user-attachments/assets/c6ef079c-a9ac-40e3-ba25-d2fb98b136d4)


🌦️ WeatherApp – Aplicativo de Clima em C#
Um aplicativo simples de console em C# que consome a API do OpenWeatherMap para exibir a previsão do tempo em tempo real.

🚀 Funcionalidades
✅ Consulta de temperatura atual 🌡️
✅ Exibe a descrição do clima (ex: "céu limpo", "chuva") 🌦️
✅ Suporte para múltiplas cidades 🌍
✅ Retorno rápido e fácil de entender 🏃

🛠️ Tecnologias Usadas
C# 💻
.NET Core 🏗️
OpenWeatherMap API 🌍
Newtonsoft.Json 📜
📦 Como Instalar e Rodar
Clone o repositório

git clone https://github.com/SEU_USUARIO/WeatherApp.git
cd WeatherApp
Instale as dependências

dotnet restore
Obtenha uma chave da API OpenWeatherMap

Crie uma conta no OpenWeatherMap
Copie sua API Key
Adicione sua chave de API no código
No arquivo WeatherService.cs, substitua "YOUR_API_KEY" pela sua chave real:

private string apiKey = "YOUR_API_KEY";
Execute o projeto

dotnet run
Digite o nome da cidade e veja a previsão do tempo! 🌍🌦️

📸 Exemplo de Uso
Enter a city name:
  👉 Miami
Current weather in Miami: céu limpo, 27°C 🌞
