using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEventos.Models
{
    public class Dados
    {
        public string? Local { get; set;}
        public string? Nome { get; set;}
        public Double NumParticipantes { get; set;}
        public Double Custo { get; set; }
        public DateTime DataIni { get; set; }
        public DateTime DataTermino { get; set; }
        public int Duracao
        {
            get => DataTermino.Subtract(DataIni).Days + 1;
        }

        public double CustoTotal
        {
            get
            {
                double num_part = NumParticipantes;
                double custo_part = Custo;

                double total = (num_part * custo_part);

                return total;
            }
            
        }

    }
        }
    

