namespace MoviesApi.Entidades
{
    public class DatosClass
    {

        private List<GeneroClass> _listGenero;

        public DatosClass() {
            _listGenero = new List<GeneroClass> {
                new GeneroClass {Id=1, Nombre="Comedia"},
                new GeneroClass {Id=2, Nombre="Terror"},
                new GeneroClass {Id=3, Nombre="Acción"},
                new GeneroClass {Id=4, Nombre="Aventura"},
                new GeneroClass {Id=5, Nombre="Animación"},

               };


        }

        public List<GeneroClass> getListGenero()
        {
            return _listGenero;
        }

        public GeneroClass getGenero(int _id)
        {
            return _listGenero[0];
        }

    }
}
