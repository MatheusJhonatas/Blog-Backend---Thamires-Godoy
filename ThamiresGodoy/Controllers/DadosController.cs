using Microsoft.AspNetCore.Mvc;

[ApiController]
public class DadosController : ControllerBase
{
    [HttpGet("v1/dados")]
    public IActionResult GetDados()
    {

        var dados = new
        {
            Name = "Primor Estética",
            Address = "Rua Mateus Sommer",
            City = "Guapimirim",
            State = "Rio de Janeiro",
            Cep = "25946619",
            Whatsapp = "21985356134",
            Email = "thamirisgodoyhotmail.com.br",
            Numer_phone = "21985356134",
            Numer_Phone2 = "",
            Instagram = "https://www.instagram.com/thamirisgodoy.rj/",
            Facebook = "https://www.facebook.com/primorestetica.rj/",
            Qrcode_Intagram = "",
            Qrcode_Facebook = "",
            Qrcode_Whatsap = ""
        };
        return Ok(dados);
    }
}
