using System.Collections.Generic;
using HolaWeb.App.Dominio;
using System;
using System.IO.Pipes;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public interface IRepositorioSaludos
    {
        IEnumerable<Saludo> GetAll();

        IEnumerable<Saludo> GetSaludoFiltro(string filtro);
         
        Saludo GetSaludoPorId(int Id);

        Saludo GetSaludoPorId(DateTime Id);

        Saludo Update(Saludo saludoActualizado);

        Saludo Add(Saludo saludoNuevo);

        Saludo Delete(Saludo saludoEliminar);
    }
}