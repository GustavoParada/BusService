using Newtonsoft.Json;
using Rabbit.MVC.Models.DTO;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Rabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _appClient;
        public TransferService(HttpClient appClient)
        {
            _appClient = appClient;
        }

        public async Task Transfer(TransferDTO transferDTO)
        {
            var uri = "https://localhost:5001/api/Banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDTO), System.Text.Encoding.UTF8, "application/json");


            var response = await _appClient.PostAsync(uri, transferContent);
        }
    }
}
