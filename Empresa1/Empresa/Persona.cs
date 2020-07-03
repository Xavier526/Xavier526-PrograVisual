namespace Empresa
{
    class Persona
   {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido{ get; set; }

        public string Edad { get; set; }

        public Persona Dueño { get; set; }
    }
}
public enum TipoMaterial
{
    Estatura,
    ColordePiel,
    ColordeOjos,
    Peso

}