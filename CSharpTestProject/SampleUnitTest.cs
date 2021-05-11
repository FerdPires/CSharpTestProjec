using CSharpTestProject.Mocks;
using HotelReservationDDD.Domain;
using HotelReservationDDD.Domain.Services;
using HotelReservationDDD.Enum;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace CSharpTestProject
{
    //Escreva um programa para encontrar o hotel mais barato. A entrada do programa ser� uma sequ�ncia de datas 
    //para um cliente participante ou n�o do programa de fidelidade. Utilize "Regular" para denominar um cliente normal 
    //e "Fidelidade" para um cliente participante do programa de fidelidade. 
    //A sa�da dever� ser o hotel dispon�vel mais barato e em caso de empate, o hotel com a maior classifica��o dever� ser retornado.

    //Cen�rios de aceite

    //1.DeveRetornarHotelMaisBaratoDisponivel
    //2.DeveRetornarHotelMaisBaratoDisponivelParaClienteRegular
    //3.DeveRetornarHotelMaisBaratoDisponivelParaClienteFidelidade
    //4.DeveRetornarHotelComMaiorClassificacaoDisponivelSeHouverEmpateDosMaisBaratos
    //5.DeveRetornarHotelParqueDasFloresParaClienteRegular
    //6.DeveRetornarHotelJardimBotanicoParaClienteRegular
    //7.DeveRetornarHotelMarAtlanticoParaClienteFidelidade

    //Modelagem

    //Enum da categoria do cliente
    //Modelo de Hotel (informa��es do hotel)
    //Cada hotel deve ter uma avalia��o, e lista de valores para dia de semana e fim de semana
    //C�lculo para o retorno do hotel mais barato para aquele dia, em caso de empate, ser� retornado o de maior avalia��o 
    //Como a regra aceita uma lista de datas, dever� ser somado os valores da di�ria 

    public class SampleUnitTest
    {
        //private Mock<FakeHotelRepository> _hotelRepositoryMock;

        //public SampleUnitTest()
        //{
        //    _hotelRepositoryMock = new Mock<FakeHotelRepository>();
        //}

        [Fact]
        public void ShouldBeLakewoodForRegularGuest()
        {
            List<DateTime> dates = new List<DateTime>()
            {
                new DateTime(2021, 05, 16),
                new DateTime(2021, 05, 17),
                new DateTime(2021, 05, 18)
            };

            //  _hotelRepositoryMock.Setup(h => h.GetHotels()).Returns(new FakeHotelRepository().GetHotels());
            Hotel cheapestHotel = new ReservaHotelService(new FakeHotelRepository()).BuscarHotelMaisBarato(CategoriaCliente.Regular, dates);

            Assert.Equal("Parque das Flores", cheapestHotel.NomeHotel);
        }
        //[Fact]
        //public void DeveRetornarHotelMaisBaratoDisponivelParaClienteRegular()
        //{
        //    var reservaHotelService = new ReservaHotelService();
        //    var categoriaCliente = CategoriaCliente.Regular;
        //    var datas = new List<DateTime>() 
        //    {
        //        new DateTime(2021, 05, 16),
        //        new DateTime(2021, 05, 17),
        //        new DateTime(2021, 05, 18)
        //    };

        //    var hotelMaisBarato = reservaHotelService.BuscarHotelMaisBarato(categoriaCliente, datas);

        //    Assert.Equal("Parque das Flores", hotelMaisBarato);
        //}

        //[Fact]
        //public void DeveRetornarHotelMaisBaratoDisponivelParaClienteFidelidade()
        //{
        //    var reservaHotelService = new ReservaHotelService();
        //    var categoriaCliente = CategoriaCliente.Fidelidade;
        //    var datas = new List<DateTime>()
        //    {
        //        new DateTime(2021, 05, 16),
        //        new DateTime(2021, 05, 17),
        //        new DateTime(2021, 05, 18)
        //    };

        //    var hotelMaisBarato = reservaHotelService.BuscarHotelMaisBarato(categoriaCliente, datas);

        //    Assert.Equal("Mar Atl�ntico", hotelMaisBarato);
        //}

        //DeveRetornarHotelDeMaiorClassificacao
        //DeveRetornarHotelDeMaiorClassificacaoClienteRegular
        //DeveRetornarHotelDeMaiorClassificacaoClienteFidelidade
    }

    //public enum CategoriaCliente
    //{
    //    Fidelidade,
    //    Regular
    //}

    //internal class ReservaHotelService
    //{
    //    public ReservaHotelService()
    //    {
    //    }

    //    public string BuscarHotelMaisBarato(CategoriaCliente categoriaCliente, List<DateTime> datas)
    //    {
    //        if(categoriaCliente == CategoriaCliente.Regular)
    //            return "Parque das Flores";
    //        else
    //            return "Mar Atl�ntico";
    //    }
    //}
}
 