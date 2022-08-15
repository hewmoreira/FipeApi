using FipeApi.DTO;
using HtmlAgilityPack;

namespace FipeApi
{
    public class FipeWS
    {
        public FipeInfoDTO GetFipeInfo(string carFipeCode)
        {
            var url = "https://www.tabelafipebrasil.com/FIPE/" + carFipeCode;
            var priceRow = "//td";

            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);

            var element = doc.DocumentNode.SelectNodes(priceRow);

            var elementValue = element[5].InnerText.Split("R$ ")[1].Split(",")[0].Replace(".","");

            var price = int.Parse(elementValue);

            return new FipeInfoDTO(price);
        }
    }
}
