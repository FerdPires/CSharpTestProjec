using CSharpTestProject.FakeRepositories;
using HotelReservation.Domain;
using HotelReservation.Domain.Services;
using HotelReservation.Enum;
using System;
using System.Collections.Generic;
using Xunit;

namespace CSharpTestProject
{
    //Escreva um programa para encontrar o hotel mais barato. 
    //A entrada do programa será uma sequência de datas para um cliente participante ou não do programa de fidelidade. 
    //Utilize "Regular" para denominar um cliente normal e "Fidelidade" para um cliente participante do programa de fidelidade. 
    //A saída deverá ser o hotel disponível mais barato e em caso de empate, o hotel com a maior classificação deverá ser retornado.

    //1.Encontrar o hotel mais barato
    //2.Fazer o cálculo dos valores da diária de cada hotel - OK
    //3.Quando der empate nos valores dos hoteis, deve retornar aquele com a maior classificação 
    //---------------------------------------------------------------------------------------------

    public class SampleUnitTest
    {
        private List<Preco> _listaPrecos;
        private Hotel _hotel;
        private FakeHotelRepository _hotelRepository;
        private ReservaHotelService _serviceHotel;

        public SampleUnitTest()
        {
            _listaPrecos = new List<Preco>()
            {
                new Preco(110, false, CategoriaCliente.Regular),
                new Preco(80, false, CategoriaCliente.Fidelidade),
                new Preco(90, true, CategoriaCliente.Regular),
                new Preco(80, true, CategoriaCliente.Fidelidade),
            };

            _hotel = new Hotel("Parque das flores", 3, _listaPrecos);

            _hotelRepository = new FakeHotelRepository();
            _serviceHotel = new ReservaHotelService(_hotelRepository);
        }

        [Fact]
        public void DeveCalcularPrecoHotelSomandoValoresEncontrados()
        {
            var datas = new List<DateTime>()
            {
                new DateTime(2021, 05, 16),
                new DateTime(2021, 05, 17),
                new DateTime(2021, 05, 18)
            };

            var somaValores = _hotel.CalcularPrecoReservaHotel(CategoriaCliente.Regular, datas);

            Assert.Equal(310, somaValores);
        }

        [Fact]
        public void DeveRetornarExceptionSeListaDeDatasEnviadaForNula()
        {
            List<DateTime> datas = null;

            Assert.Throws<ArgumentException>(() => _hotel.CalcularPrecoReservaHotel(CategoriaCliente.Regular, datas));
        }

        [Fact]
        public void DeveRetornarHotelMaisBarato()
        {
            var datas = new List<DateTime>()
            {
                new DateTime(2021, 05, 21),
                new DateTime(2021, 05, 22),
                new DateTime(2021, 05, 23)
            };

            var hotelMaisBarato = _serviceHotel.BuscarHotelMaisBarato(CategoriaCliente.Regular, datas);

            Assert.Equal("Jardim Botânico", hotelMaisBarato.NomeHotel);
        }

        [Fact]
        public void DeveRetornarHotelComMaiorClassificacaoCasoEncontreMaisDeUmHotelComMesmoValor()
        {
            var datas = new List<DateTime>()
            {
                new DateTime(2021, 05, 27),
                new DateTime(2021, 05, 28),
                new DateTime(2021, 05, 29)
            };

            var hotelMaisBarato = _serviceHotel.BuscarHotelMaisBarato(CategoriaCliente.Fidelidade, datas);

            Assert.Equal("Mar Atlântico", hotelMaisBarato.NomeHotel);
        }
    }
}
