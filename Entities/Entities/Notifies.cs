﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Notifies
    { 

        public Notifies() 
        {
            Notificacoes = new List<Notifies>();
        }




        [NotMapped]                                          // para que o migration nao crie essa propriedade no campo
        public string NomePropriedade { get; set; } 
        [NotMapped]
        public string mensagem { get; set; }
        [NotMapped]
        public List<Notifies> Notificacoes { get; set; }


        public bool ValidarPropriedadeString(string valor, string nomePropriedade)
        {
            if(string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notificacoes.Add(new Notifies { 
                    mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedade
                });

                return false;
            }
            
                return true;    
        }


        public bool ValidarPropriedadeString(int valor, string nomePropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notificacoes.Add(new Notifies
                {
                    mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedade
                });

                return false;
            }

            return true;


        }
    
    }

}
