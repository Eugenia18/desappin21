using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class peliculas {
        public int IdTituloPeli {get; set;}
        public string TituloPeli {get; set;}
        public string HisPeli {get; set;}
        public dateline FechaEsPeli {get; set;}
        public int DuracionPeli {get; set;}
        public string IdGeneroCinematografico {get; set;}
        public int IdCertificadoDePeli {get; set;}
        public string InformacionAdiPeli{get; set;}
    
    public peliculasdirigidasporproductores Peliculasdirigidasporproductores {get; set;}
public peliculas peliculas {get; set;}
public actores actores {get; set;}
public generosdepelicula generosdepelicula {get; set;}
public certificadosdepeliculas certificadosdepeliculas {get; set;}
}
}
}