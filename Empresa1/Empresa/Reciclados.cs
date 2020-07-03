
namespace Empresa.Reciclados
{

    class Reciclados
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Precio { get; set; }

        public string Peso { get; set; }

        public Persona Dueño { get; set; }

        public List<Empresa> Reciclados { get; set; }
    }

}
public enum PrecioReciclado
{
    PrecioOro,
    PrecioCobre,
    PrecioAluminio,
    PrecioPlastico,
    PrecioCarton

}

