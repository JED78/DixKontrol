using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DixKontrol.MVVM.ViewModel
{
    public class SesionesViewModel
    {
        public ObservableCollection<SesionItem> Sesiones { get; set; }

        public event Action<string> PlayRequested;

        public Command<string> PlayCommand { get; }

        public SesionesViewModel()
        {
            Sesiones = new ObservableCollection<SesionItem>();

            for (int i = 1; i <= 12; i++)
            {
                Sesiones.Add(new SesionItem
                {
                    Nombre = $"Sesión {i:00}",
                    Archivo = $"sesion{i}.mp3"
                });
            }

            PlayCommand = new Command<string>(OnPlay);
        }

        private void OnPlay(string archivo)
        {
            PlayRequested?.Invoke(archivo);
        }
    }

    public class SesionItem
    {
        public string Nombre { get; set; }
        public string Archivo { get; set; }
    }
}
