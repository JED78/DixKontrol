using Plugin.Maui.Audio;
using System;
using System.Collections.Generic;
using System.Text;

namespace DixKontrol.MVVM.Servicios
{
    public static class AudioService
    {
        private static IAudioPlayer _player;

        public static void Play(Stream stream)
        {
            // Si ya hay un reproductor sonando, lo paramos
            if (_player != null)
            {
                _player.Stop();
                _player.Dispose();
                _player = null;
            }

            // Creamos el nuevo reproductor
            // Crear el reproductor
            var player = AudioManager.Current.CreatePlayer(stream);

            // Reproducir la canción
            player.Play();
        }

        public static void Stop()
        {
            if (_player != null)
            {
                _player.Stop();
                _player.Dispose();
                _player = null;
            }
        }
    }
}