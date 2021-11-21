using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class rolesdeactoresenpeliculas {
        public dateline IdTituloPelicula {get; set;}
        public dateline IdActor {get; set;}
        public dateline IdTipoRol {get; set;}
        public String NombrePersonaje {get; set;}
        public dateline DescripcionPersonajel {get; set;}
    
    public rolesdeactoresenpeliculas rolesdeactoresenpeliculas {get; set;}
    public actores actores {get; set;}
    public TipoRol TipoRol {get; set;}
    }