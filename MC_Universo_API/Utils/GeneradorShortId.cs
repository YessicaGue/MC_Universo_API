using System.Text;

namespace MC_Universo_API.Utils
{
    public class GeneradorShortId
    {
        private static readonly Random random = new Random();
        private const string CaracteresPermitidos = "abcdefghijklmnopqrstuvwxyz0123456789";

        public string GenerarCadenaAleatoria()
        {
            int longitud = 8; 
            StringBuilder cadenaAleatoria = new StringBuilder(longitud);
            
            for(int i = 0; i < longitud; i++)
            {
                int indiceCaracter = random.Next(CaracteresPermitidos.Length);
                cadenaAleatoria.Append(CaracteresPermitidos[indiceCaracter]);
            }

            return cadenaAleatoria.ToString();

        }
    }
}
