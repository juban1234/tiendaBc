namespace Modelo.Entitys
{
    public static class SesionActual
    {
        private static usuarioEntyti _usuario;

        public static void IniciarSesion(usuarioEntyti usuario)
        {
            _usuario = usuario;
        }

        public static void CerrarSesion()
        {
            _usuario = null;
        }

        public static usuarioEntyti ObtenerUsuario()
        {
            return _usuario;
        }

        public static bool EstaAutenticado()
        {
            return _usuario != null;
        }
    }
}
