using System.Collections.Generic;

namespace ComicStore.DAL.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public virtual ICollection<Comic> Comics{ get; set; }
    }
}
