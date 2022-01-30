namespace ComicStore.DAL.Entities
{
    public class Comic
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string CasaCreadora { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
    }
}
