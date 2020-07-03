namespace Empresa
{
    class Material
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Costo { get; set; }

        public string Calidad { get; set; }

        public Persona Volumen { get; set; }

        public List<Empresa> Reciclados { get; set; }
    }
    public enum TipoMaterial
    {
        TipoOro,
        TipoCobre,
        TipoAluminio,
        TipoPlastico,
        TipoCarton

    }

  
