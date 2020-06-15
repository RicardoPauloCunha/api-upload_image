using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UploadImage.ViewModels;

namespace UploadImage.Services
{
    public static class ReadFileService
    {
        public static UrlAndKeyViewModel GetUrlAndKey()
        {
            // Declara a variavel do arquivo
            string arquivo = "";

            // Tenta instacia-lo
            try
            {
                arquivo = File.ReadAllText(@".\Services\Files\url_and_user.json");
            }
            catch
            {
                return null;
            }

            // Caso não ache o arquivo retorna nulo
            if (string.IsNullOrEmpty(arquivo))
            {
                return null;
            }

            // Deserializa as credenciais
            var response = JsonConvert.DeserializeObject<UrlAndKeyViewModel>(arquivo);

            // Retorna as credenciais
            return response;
        }
    }
}
