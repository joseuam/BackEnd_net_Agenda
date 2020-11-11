using System;
using System.Collections.Generic;
using System.Linq;
using AgendaT.Models;

namespace AgendaT.Repositorios
{
    public class RPContacto
    {
        public static List<Contacto> _listaContactos = new List<Contacto>()
        {
            new Contacto() { Id_Contacto = 1, Nombre = "Cliente 1" , Apellido = "Apellido 1" ,Telefono=55, Correo="@@"},
            new Contacto() { Id_Contacto = 2, Nombre = "Cliente 2" , Apellido = "Apellido 2" ,Telefono=55, Correo="@@"},
            new Contacto() { Id_Contacto = 3, Nombre = "Cliente 3" , Apellido = "Apellido 3" ,Telefono=55, Correo="@@"}
        };

        public IEnumerable<Contacto> ObtenerContactos()
        {
            return _listaContactos;
        }

        public Contacto ObtenerContacto(int id)
        {
            var contacto = _listaContactos.Where(cli => cli.Id_Contacto == id);

            return contacto.FirstOrDefault();
        }

        public void Agregar(Contacto nuevoContacto)
        {
            _listaContactos.Add(nuevoContacto);
        }

        public Contacto Actualizar(Contacto contacto)
        {
  
            foreach (Contacto element in _listaContactos)
            {
                if (element.Id_Contacto == contacto.Id_Contacto)
                {
                    element.Nombre = contacto.Nombre;
                    element.Apellido = contacto.Apellido;
                    element.Telefono = contacto.Telefono;
                    element.Correo = contacto.Correo;
                    return (element);
                }
            }

            return null;

        }

        public Boolean Eliminar(int id)
        {

            return _listaContactos.Remove(ObtenerContacto(id));

        }
    }
}


