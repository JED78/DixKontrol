using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DixKontrol.MVVM.ViewModel
{
    public class SesionesViewModel
    {
        public ObservableCollection<SesionItem> Sesiones { get; set; }
        public Command<string> PlayCommand { get; }

        public SesionesViewModel()
        {
            Sesiones = new ObservableCollection<SesionItem>();

            for (int i = 1; i <= 12; i++)
            {
                Sesiones.Add(new SesionItem
                {
                    Nombre = $"Sesión {i:00}",
                    Archivo = $"sesionespsicodromo/sesion{i}.mp3"
                });
            }

            PlayCommand = new Command<string>(PlaySesion);
        }

        private async void PlaySesion(string archivo)
        {
            await Launcher.OpenAsync(archivo);
        }
    }

    public class SesionItem
    {
        public string Nombre { get; set; }
        public string Archivo { get; set; }
    }
}
