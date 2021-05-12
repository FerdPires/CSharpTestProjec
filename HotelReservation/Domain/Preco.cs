using HotelReservation.Enum;

namespace HotelReservation.Domain
{
    public class Preco
    {
        public decimal PrecoDiaria { get; private set; }
        public bool FimDeSemana { get; private set; }
        public CategoriaCliente CategoriaCliente { get; private set; }

        public Preco(decimal precoDiaria, bool fimDeSemana, CategoriaCliente categoriaCliente)
        {
            PrecoDiaria = precoDiaria;
            FimDeSemana = fimDeSemana;
            CategoriaCliente = categoriaCliente;
        }
    }
}