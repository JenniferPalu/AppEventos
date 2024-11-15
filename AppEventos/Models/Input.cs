using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppEventos.Models
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string nomeevento;
        public string NomeEvento
        {
            get => nomeevento;
            set
            {
                if (nomeevento != value)
                {
                    nomeevento = value;
                    OnPropertyChanged();
                }
            }
        }

        private string localevento;
        public string LocalEvento
        {
            get => localevento;
            set
            {
                if (localevento != value)
                {
                    localevento = value;
                    OnPropertyChanged();
                }
            }
        }


        private double numpart;
        public double Numpart
        {
            get => numpart;
            set
            {
                if (numpart != value)
                {
                    numpart = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Resultado));
                }
            }
        }

        private double custopart;
        public double Custopart
        {
            get => custopart;
            set
            {
                if (custopart != value)
                {
                    custopart = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Resultado));
                }
            }
        }

        public string Resultado
        {
            get
            {
                try
                {
                    return (Numpart * Custopart).ToString("C");
                }catch (Exception ex)
                {
                    return $"Erro: {ex.Message}";
                }
            }
        }
        

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
internal class Input
    {
    }

