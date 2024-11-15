using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEventos.Models
{
    public class Dados
    {
        public Double NumParticipantes { get; set;}
        public Double Custo { get; set; }
        public DateTime DataIni { get; set; }
        public DateTime DataTermino { get; set; }
        public int Duracao
        {
            get => DataIni.Subtract(DataTermino).Days;
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
    

