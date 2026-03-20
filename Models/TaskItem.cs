using System;

namespace TodoApi.Models
{
    public class Tarefa
    {
        public int Id { get; set; } // Identificador único (chave primária)
        public string? Titulo { get; set; } // O nome da tarefa
        public bool EstaCompleta { get; set; } // Status
    }
}