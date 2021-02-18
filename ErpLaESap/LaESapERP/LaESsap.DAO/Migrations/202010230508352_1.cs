namespace LaESsap.DAO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Area",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Estatus = c.Int(nullable: false),
                        FechaAlta = c.DateTime(nullable: false),
                        FechaCambio = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cargos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Estatus = c.Int(nullable: false),
                        FechaAlta = c.DateTime(nullable: false),
                        FechaCambio = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Estatus = c.Int(nullable: false),
                        Login = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 100),
                        FechaAlta = c.DateTime(nullable: false),
                        FechaCambio = c.DateTime(),
                        CargoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Estatus = c.Int(nullable: false),
                        FechaAlta = c.DateTime(nullable: false),
                        FechaCambio = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Equipo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100),
                        IdEquipo = c.String(maxLength: 100),
                        Departamento = c.String(maxLength: 100),
                        ActividadUtilizado = c.String(maxLength: 100),
                        NombreUsuario = c.String(maxLength: 100),
                        NumeroPersonas = c.Int(),
                        FechaAdquisicion = c.DateTime(),
                        VigenciaGarantia = c.DateTime(),
                        TiempoVida = c.Int(),
                        ConectadoInternet = c.Boolean(nullable: false),
                        MantenimientoPreventivo = c.String(maxLength: 100),
                        MantenimientoCorrectivo = c.String(maxLength: 100),
                        NumeroInventarioCPU = c.String(maxLength: 100),
                        NumeroSerieCPU = c.String(maxLength: 100),
                        MarcaCPU = c.String(maxLength: 100),
                        ModeloCPU = c.String(maxLength: 100),
                        Procesador = c.String(maxLength: 100),
                        DiscoDuro = c.String(maxLength: 100),
                        RAM = c.String(maxLength: 100),
                        NumeroInventarioMonitor = c.String(maxLength: 100),
                        NumeroSerieMonitor = c.String(maxLength: 100),
                        MarcaMonitor = c.String(maxLength: 100),
                        ModeloMonitor = c.String(maxLength: 100),
                        PulgadasMmonitor = c.String(maxLength: 100),
                        TipoMonitor = c.String(maxLength: 100),
                        NumeroInventarioTeclado = c.String(maxLength: 100),
                        NumeroSerieTeclado = c.String(maxLength: 100),
                        MarcaTeclado = c.String(maxLength: 100),
                        ModeloTeclado = c.String(maxLength: 100),
                        NumeroInventarioRaton = c.String(maxLength: 100),
                        NumeroSerieRaton = c.String(maxLength: 100),
                        MarcaRaton = c.String(maxLength: 100),
                        ModeloRaton = c.String(maxLength: 100),
                        NumeroInventarioOtroAccesorio = c.String(maxLength: 100),
                        NumeroSerieOtroAccesorio = c.String(maxLength: 100),
                        MarcaOtroAccesorio = c.String(maxLength: 100),
                        ModeloOtroAccesorio = c.String(maxLength: 100),
                        FechaAdquisiciónOtroAccesorio = c.DateTime(nullable: false),
                        VigenciaGarantiaOtroAccesorio = c.DateTime(nullable: false),
                        TiempoVidaOtroAccesorio = c.String(maxLength: 100),
                        TipoAccesorio = c.String(maxLength: 100),
                        Comentarios = c.String(maxLength: 100),
                        DescripcionAccesorio = c.String(maxLength: 100),
                        Estatus = c.Int(nullable: false),
                        FechaAlta = c.DateTime(nullable: false),
                        FechaCambio = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cargos", "Id", "dbo.Usuario");
            DropIndex("dbo.Cargos", new[] { "Id" });
            DropTable("dbo.Equipo");
            DropTable("dbo.Departamento");
            DropTable("dbo.Usuario");
            DropTable("dbo.Cargos");
            DropTable("dbo.Area");
        }
    }
}
