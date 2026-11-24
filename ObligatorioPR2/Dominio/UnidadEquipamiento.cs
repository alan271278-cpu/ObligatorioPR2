namespace ObligatorioPR2.Dominio
{
    public class UnidadEquipamiento
    {
        private int aId;
        private string aIdentificador;
        private string aEstado;

        public int Id { get { return aId; } set { aId = value; } }
        public string Identificador { get { return aIdentificador; } set { aIdentificador = value; } }
        public string Estado { get { return aEstado; } set { aEstado = value; } }

        public UnidadEquipamiento(int pId, string pIdentificador, string pEstado)
        {
            aId = pId;
            aIdentificador = pIdentificador;
            aEstado = pEstado;
        }

        public UnidadEquipamiento()
        {
            aId = 0;
            aIdentificador = "";
            aEstado = "";
        }
    }
}
