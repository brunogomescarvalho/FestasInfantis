﻿using FestasInfantis.Dominio.ModuloCliente;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FestasInfantis.InfraDados.ModuloCompartilhado
{
    public class ContextoDados
    {
        private const string NOME_ARQUIVO = @"ModuloCompartilhado\dados.json";

        public List<Cliente> Clientes { get; set; }


        public ContextoDados()
        {
            Clientes = new List<Cliente>();
        }


        public ContextoDados(bool carregarArquivos) : this()
        {
            if(carregarArquivos)
            {
                CarregarDadosDoArquivo();
            }
        }

        public void CarregarDadosDoArquivo()
        {
            JsonSerializerOptions jsonSerializerOptions = ObterConfiguracao();

            string arquivoJson = File.ReadAllText(NOME_ARQUIVO);

            if(arquivoJson.Trim().Length > 10)
            {
                ContextoDados contexto = JsonSerializer.Deserialize<ContextoDados>(arquivoJson, jsonSerializerOptions)!;

                Clientes = contexto.Clientes;
            }
        }

        
        public void GravarDadosNoArquivo()
        {
            JsonSerializerOptions jsonSerializerOptions = ObterConfiguracao();

            string arquivoJson = JsonSerializer.Serialize(this, jsonSerializerOptions);

            File.WriteAllText(NOME_ARQUIVO, arquivoJson);
        }

        private static JsonSerializerOptions ObterConfiguracao()
        {
            return new JsonSerializerOptions()
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve,
            };
        }
    }
}
