using AutoMapper;
using SistemaAcademicoBackend.Mapping;
using SistemaAcademicoBackend.Servicios;
using SistemaAcademicoFrontend.Presentacion;
using System.Reflection;

namespace SistemaAcademicoFrontend
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<Mapping>(); // Así se agrega el perfil que definiste
            });
            var _mapper = new Mapper(config);
            Application.Run(new Login(new IFabricaServicio(), _mapper));

            



        }

    }
}