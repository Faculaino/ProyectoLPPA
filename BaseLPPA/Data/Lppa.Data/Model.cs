namespace Lppa.Data
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'Model' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Lppa.Data.Model' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Model'  en el archivo de configuración de la aplicación.
        public Model()
            : base("Model")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public  DbSet<ClienteEntity> TablaCliente { get; set; }

        public DbSet<TarjetaEntity> TablaTarjeta { get; set; }

        public DbSet<BancoEntity> TablaBanco { get; set; }

        public DbSet<VerazEntity> TablaVeraz { get; set; }

        public DbSet<SolicitudEntity> TablaSolicitud { get; set; }

        public DbSet<SistemaBancarioEntity> TablaSistemaBancario { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}