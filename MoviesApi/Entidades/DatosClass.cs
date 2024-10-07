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

           // (from genero in _listGenero where genero.Id == _id select genero).FirstOrDefault<GeneroClass>()!; 

            return _listGenero.FirstOrDefault<GeneroClass>(g => g.Id==_id)!; 
        }

        public bool isExisteGenero(string _nombre)
        {
            return _listGenero.Any(genero => genero.Nombre == _nombre); ;
        }

    }
}
