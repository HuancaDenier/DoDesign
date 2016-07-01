﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using DoDesign.Service.Dominio;
using DoDesign.Service.Data;
using DoDesign.Service.Persistencia;

namespace DoDesign.Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Transaccion" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Transaccion.svc o Transaccion.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Transaccion : ITransaccion
    {
        #region . DAO .
        //PedidoDAO
        private PedidoDAO objPedido = null;
        private PedidoDAO ObjPedido
        {
            get
            {
                if (objPedido == null)
                    objPedido = new PedidoDAO();
                return objPedido;
            }
        }
        //ClienteDAO
        private ClienteDAO objCliente = null;
        private ClienteDAO ObjCliente
        {
            get
            {
                if (objCliente == null)
                    objCliente = new ClienteDAO();
                return objCliente;
            }
        }
        /*//ColorDAO
        private ColorDAO objColor = null;
        private ColorDAO ObjColor
        {
            get
            {
                if (objColor == null)
                    objColor = new ColorDAO();
                return objColor;
            }
        }*/
        //DesignDAO
        private DesignDAO objDesign = null;
        private DesignDAO ObjDesign
        {
            get
            {
                if (objDesign == null)
                    objDesign = new DesignDAO();
                return objDesign;
            }
        }
        //DetallePedido
        private DetallePedidoDAO objDetallePedido = null;
        private DetallePedidoDAO ObjDetallePedido
        {
            get
            {
                if (objDetallePedido == null)
                    objDetallePedido = new DetallePedidoDAO();
                return objDetallePedido;
            }
        }
        //PagoDAO 
        private PagoDAO objPago = null;
        private PagoDAO ObjPago
        {
            get
            {
                if (objPago == null)
                    objPago = new PagoDAO();
                return objPago;
            }
        }
        //PoloDAO
        private PoloDAO objPolo = null;
        private PoloDAO ObjPolo
        {
            get
            {
                if (objPolo == null)
                    objPolo = new PoloDAO();
                return objPolo;
            }
        }
        //TLoginDAO
        private TLoginDAO objTLogin = null;
        private TLoginDAO ObjTLogin
        {
            get
            {
                if (objTLogin == null)
                    objTLogin = new TLoginDAO();
                return objTLogin;
            }
        }
        #endregion

        #region .LOGUEOS.
        public bool LoginCliente(TLogin logueo)
        {
            
            //return logueado;
            return TLoginDAO.LoginCli(logueo); 
        }
        #endregion

        #region . PEDIDO .
        public Pedido CrearPedido(Pedido pedido)
        {
            return ObjPedido.Crear(pedido);
        }

        public IList<Pedido> ListarPedido()
        {
            return ObjPedido.ListarTodos();
        }
        public Pedido ModificarPedido(Pedido pedido)
        {
            return ObjPedido.Modificar(pedido);
        }

        public Pedido ObtenerPedido(int IdPedido)
        {
            return ObjPedido.Obtener(IdPedido);
        }
        #endregion

        #region . CLIENTE .
        /*public Cliente ObtenerCliente(string NombreUsuario)
        {
            Cliente cliente = new Cliente();
            return cliente;
        }*/

        public Cliente CrearCliente(Cliente cliente)
        {
            return ObjCliente.Crear(cliente);
        }

        public IList<Cliente> ListarCliente()
        {
            return ObjCliente.ListarTodos();
        }

        public Cliente ModificarCliente(Cliente cliente)
        {
            return ObjCliente.Modificar(cliente);
        }

        public Cliente ObtenerCliente(int IdCliente)
        {
            return ObjCliente.Obtener(IdCliente);
        }
        #endregion

        #region . COLOR .
        public Color CrearColor(Color color)
        {
            var colorDao = new ColorDAO();
            var newColor = colorDao.Crear(color);
            return newColor;
        }

        public List<Color> ListarColor()
        {
            var colorDao = new ColorDAO();
            var listColor = colorDao.ListarTodos();
            return listColor.ToList();
        }

        public Color ModificarColor(Color color)
        {
            var colorDao = new ColorDAO();
            var modColor = colorDao.Modificar(color);
            return modColor;
        }

        public Color ObtenerColor(int IdColor)
        {
            var colorDao = new ColorDAO();
            var getColor = colorDao.Obtener(IdColor);
            return getColor;
        }
        #endregion

        #region . DESIGN .
        public Design CrearDesign(Design design)
        {
            return ObjDesign.Crear(design);
        }

        public IList<Design> ListarDesign()
        {
            return ObjDesign.ListarTodos();
        }

        public Design ModificarDesign(Design design)
        {
            return ObjDesign.Modificar(design);
        }

        public Design ObtenerDesign(int IdDesign)
        {
            return ObjDesign.Obtener(IdDesign);
        }
        #endregion

        #region . DETALLEPEDIDO .
        public DetallePedido CrearDetallePedido(DetallePedido detallePedido)
        {
            return ObjDetallePedido.Crear(detallePedido);
        }

        public IList<DetallePedido> ListarDetallePedido()
        {
            return ObjDetallePedido.ListarTodos();
        }

        public DetallePedido ModificarDetallePedido(DetallePedido detallePedido)
        {
            return ObjDetallePedido.Modificar(detallePedido);
        }

        public DetallePedido ObtenerDetallePedido(int IdDetallePedido)
        {
            return ObjDetallePedido.Obtener(IdDetallePedido);
        }
        #endregion

        #region . PAGO .

        public Pago CrearPago(Pago pago)
        {
            return ObjPago.Crear(pago);
        }

        public IList<Pago> ListarPago()
        {
            return ObjPago.ListarTodos();
        }

        public Pago ModificarPago(Pago pago)
        {
            return ObjPago.Modificar(pago);
        }

        public Pago ObtenerPago(int IdPago)
        {
            return ObjPago.Obtener(IdPago);
        }
        #endregion

        #region . POLO .
        public Polo CrearPolo(Polo polo)
        {
            return ObjPolo.Crear(polo);
        }

        public IList<Polo> ListarPolo()
        {
            return ObjPolo.ListarTodos();
        }

        public Polo ModificarPolo(Polo polo)
        {
            return ObjPolo.Modificar(polo);
        }

        public Polo ObtenerPolo(int IdPolo)
        {
            return ObjPolo.Obtener(IdPolo);
        }
        #endregion

        #region . TLOGION .

        public TLogin CrearTLogin(TLogin tlogin)
        {
            return ObjTLogin.CrearLoginCli(tlogin);
        }

        public IList<TLogin> ListarTLogin()
        {
            return ObjTLogin.ListarTodos();
        }

        public TLogin ModificarTlogin(TLogin tlogin)
        {
            return ObjTLogin.Modificar(tlogin);
        }

        public TLogin ObtenerTLogin(int IdTLogin)
        {
            return ObjTLogin.Obtener(IdTLogin);
        }
        #endregion
    }
}
