﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_medical_webAPI.ViewModels
{
    public class ConsultumViewModel
    {
        public int idPaciente { get; set; }
        public int idMedico { get; set; }
        public DateTime dataAgendamento { get; set; }
        public TimeSpan horaAgendamento { get; set; }
        public int idSituacao { get; set; }
        public string descricao { get; set; }
    }
}
