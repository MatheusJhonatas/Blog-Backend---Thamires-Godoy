# Blog Backend Thamires-Godoy

Este repositório contém uma API desenvolvida em [ASP.NET] para fornecer dados pessoais relacionados ao blog **Primor Estética**. O objetivo é facilitar o acesso a informações de contato e redes sociais por meio de um endpoint RESTful.

## Endpoints

### **GET /v1/dados**

Retorna os dados pessoais do blog em formato JSON.

#### Exemplo de Resposta:

```json
{
    "Name": "Primor Estética",
    "Address": "Rua Mateus Sommer",
    "City": "Guapimirim",
    "State": "Rio de Janeiro",
    "Cep": "25946619",
    "Whatsapp": "21985356134",
    "Email": "thamirisgodoyhotmail.com.br",
    "Numer_phone": "21985356134",
    "Numer_Phone2": "",
    "Instagram": "https://www.instagram.com/thamirisgodoy.rj/",
    "Facebook": "https://www.facebook.com/primorestetica.rj/",
    "Qrcode_Intagram": "",
    "Qrcode_Facebook": "",
    "Qrcode_Whatsap": ""
}
```

## Como Contribuir

1. Faça um fork deste repositório.
2. Crie uma branch para sua feature ou correção de bug:
   ```bash
   git checkout -b minha-branch
   ```
3. Envie suas alterações:
   ```bash
   git commit -m "Descrição do que foi feito"
   git push origin minha-branch
   ```
4. Abra um pull request.

## Contato

Se tiver dúvidas ou sugestões, entre em contato pelo email: [mateuskappa81@gmail.com].

## 🛠️ Construído com
🧩 Tecnologia: .NET Core 8.0.302
