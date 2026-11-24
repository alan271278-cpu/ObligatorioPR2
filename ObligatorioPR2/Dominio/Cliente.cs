
namespace ObligatorioPR2.Dominio
{
    public class Cliente
    {
        private int aId;
        private string aTipo;
        private string aNombre;
        private string aDocumento;
        private string aTelefono;
        private string aEmail;
        private string aDireccion;
        private bool aActivo;

        public int Id { get { return aId; } set { aId = value; } }
        public string Tipo { get { return aTipo; } set { aTipo = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public string Documento { get { return aDocumento; } set { aDocumento = value; } }
        public string Telefono { get { return aTelefono; } set { aTelefono = value; } }
        public string Email { get { return aEmail; } set { aEmail = value; } }
        public string Direccion { get { return aDireccion; } set { aDireccion = value; } }
        public bool Activo { get { return aActivo; } set { aActivo = value; } }

        public Cliente(int pId, string pTipo, string pNombre, string pDocumento, string pTelefono, string pEmail, string pDireccion, bool pActivo)
        {
            aId = pId;
            aTipo = pTipo;
            aNombre = pNombre;
            aDocumento = pDocumento;
            aTelefono = pTelefono;
            aEmail = pEmail;
            aDireccion = pDireccion;
            aActivo = pActivo;
        }

        public Cliente()
        {
            aId = 0;
            aTipo = "";
            aNombre = "";
            aDocumento = "";
            aTelefono = "";
            aEmail = "";
            aDireccion = "";
            aActivo = false;
        }
    }
}
