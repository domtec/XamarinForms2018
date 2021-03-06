﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico.Modelo;
using App01_ConsultarCEP.Servico;

namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;


        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            //TODO - Lógica do programa

            //TODO - Validações
            string cep = CEP.Text.Trim();

            if (isValidCEP(cep))
            {
                try
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

                    if (end != null)
                    {

                        RESULTADO.Text = string.Format("Endereço: {2}, {4} - {5} - {3} {0},{1} ", end.localidade, end.uf, end.logradouro, end.bairro, end.unidade, end.complemento);
                    }
                    else
                    {
                        DisplayAlert("ERRO", "O endereço não foi encontrado para o CEP informado.", "OK");
                    }
                }
                catch (Exception e)
                {
                    DisplayAlert("ERRO CRÍTICO", e.Message, "OK");
                }
            }


        }

        private bool isValidCEP(string cep)
        {
            bool valido = true;

            //if(cep.Length != 8)
            //{
            //    // ERRO

            //    DisplayAlert("ERRO", "CEP inválido !!! O CEP deve conter 8 caracteres.", "OK");

            //    valido = false;
            //}

            int NovoCEP = 0;
            if (!int.TryParse(cep, out NovoCEP))
            {
                // ERRO

                DisplayAlert("ERRO", "CEP inválido !!! O CEP deve ser composto apenas por números.", "OK");

                valido = false;
            }

            return valido;
        }
    }
}
