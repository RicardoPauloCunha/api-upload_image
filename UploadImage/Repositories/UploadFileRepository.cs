using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using UploadImage.Interfaces;
using UploadImage.Services;
using UploadImage.ViewModels;

namespace UploadImage.Repositories
{
    public class UploadFileRepository : IUploadFileRepository
    {
        private readonly HttpClient _httpClient;
        private UrlAndKeyViewModel _urlGateawayKeyUserViewModel;

        public UploadFileRepository()
        {
            _httpClient = new HttpClient();
            _urlGateawayKeyUserViewModel = ReadFileService.GetUrlAndKey();
        }

        public async Task<ResultViewModel> Upload(ImageViewModel imageViewModel)
        {
            try
            {
                // Declara a variavel do formulario
                var multiForm = new MultipartFormDataContent();

                // Declara uma lista de bytes
                byte[] imageBytes;

                // Faze a leitura e conversão do bytes
                using (var br = new BinaryReader(imageViewModel.ImageFile.OpenReadStream()))
                    imageBytes = br.ReadBytes((int)imageViewModel.ImageFile.OpenReadStream().Length);

                // Adiciona os campos do formulário
                multiForm.Add(new ByteArrayContent(imageBytes), "image", imageViewModel.ImageFile.FileName);
                multiForm.Add(new StringContent(imageViewModel.Name), "name");
                multiForm.Add(new StringContent(_urlGateawayKeyUserViewModel.Key), "key");

                // Envia a requisição
                var response = await _httpClient.PostAsync(_urlGateawayKeyUserViewModel.Url, multiForm);

                // Caso de erro
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Ocorreu um erro fazer o upload da imagem na API do Imabb");
                }

                // Mapeia o resultado
                ResultViewModel result = await response.Content.ReadAsAsync<ResultViewModel>();

                // Retorna o resultado
                return (result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
