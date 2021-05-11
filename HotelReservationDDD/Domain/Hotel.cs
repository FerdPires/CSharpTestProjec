using HotelReservationDDD.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelReservationDDD.Domain
{
    public class Hotel
    {
        public string NomeHotel { get; private set; }
        public int Classificacao { get; private set; }
        public List<Preco> ListaPrecos { get; set; }

        public Hotel(string nomeHotel, int classificacao, List<Preco> listaPrecos)
        {
            NomeHotel = nomeHotel;
            Classificacao = classificacao;
            ListaPrecos = listaPrecos;
        }

        public decimal CalcularPrecoReservaHotel(CategoriaCliente categoriaCliente, List<DateTime> listaDatas)
        {
            if (listaDatas == null)
                throw new ArgumentException("Lista de datas está nula!");

            return listaDatas
                .Sum(data => ListaPrecos
                .First(preco => preco.CategoriaCliente == categoriaCliente 
                    && preco.FimDeSemana == (data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday))
                .PrecoDiaria);
        }
    }
}
