﻿using System;
using System.ComponentModel.DataAnnotations;

namespace fusariose.Models
{
    public class MonthDataModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Campo obrigatório")]
        public int Temperature { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public int Rain { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public int Humidity { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Month { get; set; }
        public string Risk { get; set; }
    }
}
