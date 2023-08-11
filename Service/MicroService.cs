using System;
using System.Text;
using microOndas.Controllers;
using microOndas.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace microOndas.Service
{
    public class MicroService
    {
        private bool _isRunning = false;
        private int _tempoRestante = 0;
        private int _potencia = 10;
        private StringBuilder _aquecimentoString = new StringBuilder();

        public string InicioAquecimento(int seconds, int potencia)
        {
            if (_isRunning)
                throw new MicroOndasException("Aquecimento já em andamento.");

            if (seconds < 1 || seconds > 120)
                throw new MicroOndasException("Tempo inválido. O tempo deve estar entre 1 segundo e 2 minutos.");

            if (potencia < 1 || potencia > 10)
                throw new MicroOndasException("Potência inválida. A potência deve estar entre 1 e 10.");

            _tempoRestante = seconds;
            _potencia = potencia;
            _isRunning = true;
            _aquecimentoString.Clear();

            return GerarAquecimentoString();
        }

        public string InicioRapMicroOndas()
        {
            return InicioAquecimento(30, 10);
        }

        public string PauseMicroOndas()
        {
            if (!_isRunning)
                throw new MicroOndasException("Nenhum aquecimento em andamento para pausar.");

            _isRunning = false;
            return GerarAquecimentoString();
        }

        public string CancelAquecimento()
        {
            _isRunning = false;
            _tempoRestante = 0;
            _potencia = 10;
            _aquecimentoString.Clear();
            return "Aquecimento cancelado.";
        }

        private string GerarAquecimentoString()
        {
            _aquecimentoString.Clear();

            if (!_isRunning)
                return "Aquecimento não iniciado.";

            int PotPorSegundos = _potencia;
            int totalSegundos = _tempoRestante * PotPorSegundos;

            for (int i = 0; i < totalSegundos; i++)
            {
                _aquecimentoString.Append(".");
            }

            _aquecimentoString.Append(" Aquecimento concluído.");

            return _aquecimentoString.ToString();
        }
    }
}
