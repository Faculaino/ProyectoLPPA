using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Lppa.Entities;
using Lppa.Data;

namespace Lppa.Business
{
    /// <summary>
    /// GestorBusiness business component.
    /// </summary>
    public class GestorBusinessComponent
    {

        #region Proyecto
        /// <summary>
        /// AgregarUnProyecto . 
        /// </summary>
        /// <param name="proyecto">A proyecto value.</param>
        /// <returns>Returns a Proyecto object.</returns>
        //public Proyecto AgregarUnProyecto(Proyecto proyecto)
        //{
        //    var result = default(Proyecto);

        //    // Aplicar lógica de negocio
        //    var proyectoRepository = new ProyectoRepository();
        //    result = proyectoRepository.Create(proyecto);
        //    return result;

        //}

        /// <summary>
        /// EliminarProyecto . 
        /// </summary>
        /// <param name="id">A id value.</param>
        //public void EliminarProyecto(int id)
        //{
        //    // Aplicar lógica de negocio
        //    var proyectoRepository = new ProyectoRepository();
        //    proyectoRepository.DeleteById(id);

        //}

        /// <summary>
        /// ListarProyectos . 
        /// </summary>
        /// <returns>Returns a List Proyecto object.</returns>
        //public List<Proyecto> ListarProyectos()
        //{
        //    var result = default(List<Proyecto>);
        //    var proyectoRepository = new ProyectoRepository();
        //    result = proyectoRepository.Select();
        //    return result;

        //}

        /// <summary>
        /// ListarProyectosPorCodigo . 
        /// </summary>
        /// <param name="id">A id value.</param>
        /// <returns>Returns a Proyecto object.</returns>
        //public Proyecto ListarProyectosPorCodigo(int id)
        //{
        //    var result = default(Proyecto);

        //    var proyectoRepository = new ProyectoRepository();

        //    result = proyectoRepository.SelectById(id);
        //    return result;

        //}

        /// <summary>
        /// EditarProyecto . 
        /// </summary>
        /// <param name="proyecto">A proyecto value.</param>
        //public void EditarProyecto(Proyecto proyecto)
        //{
        //    // Aplicar lógica de negocio

        //    var proyectoRepository = new ProyectoRepository();
        //    proyectoRepository.UpdateById(proyecto);

        //}
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        public void AgregarCliente(ClienteEntity cliente)
        {
            //Validar datos del negocio
            var cr = new Cliente();
            cr.Insert(cliente);

        }

        public List<ClienteEntity> SeleccionarCliente()
        {
            //Validar datos del negocio
            var us = new ClienteRepository();
            return us.ListarTodos();

        }
        public void AgregarBanco(BancoEntity banco)
        {
            //Validar datos del negocio
            var us = new BancoRepository();
            us.Create(banco);

        }

        public List<BancoEntity> SeleccionarBanco()
        {
            //Validar datos del negocio
            var us = new BancoRepository();
            return us.ListarTodos();
        }

        public int ValidarVeraz(long NroDoc)
        {
            var us = new VerazRepository();
            return us.ValidarVeraz(NroDoc);

        }

        public ClienteEntity BuscarPorDNI(long dni)
        {
            var cr = new Cliente();
            return cr.SearhByDNI(dni);
        }

        //public int ValidarSistemaBancario (long NroDoc)
        //{
        //    var us = new SistemaBancarioRepository();
        //    return us.ValidarSistemaBancario(NroDoc);

        //}

    }
}
