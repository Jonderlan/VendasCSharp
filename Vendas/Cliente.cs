using System;
using System.Collections.Generic;
using System.Text;

namespace Vendas {
    class Cliente {


        //Construtor padrão
        public Cliente() {

        }

        //Construtor com dois parametros
        public Cliente(string nome, string cpf) {

            Nome = nome;
            Cpf = cpf;
        }


        // Atributos, propriedades e caracteristicas.
        public string Nome { get; set;}
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString() {
            return $"Nome: { Nome}  | CPF: {Cpf} Criado em: {CriadoEm}";
        }






    }
}
