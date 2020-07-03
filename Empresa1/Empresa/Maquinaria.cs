using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa
{
    class Maquinaria
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string TipoMaquina { get; set; }

        public string Marca { get; set; }

        public Persona Dueño { get; set; }

        public List<Empresa> Reciclados { get; set; }
    }
        public enum Genero
    {
        Masculino,
        Femenino,
        otro
    }
}
