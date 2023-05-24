using TShop.Models;
using TShop.Presenter;
using TShop._Repositories;
using TShop.Views;

namespace TShop
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
            Application.Run(new loginScreen());
            //string sqlConnectionString = @"Data Source=DESKTOP-95L7MVP\SQLEXPRESS01;Initial Catalog=TShop;Integrated Security=True";
            //IMainView view = new MainView();
            //IProductRepository repository = new ProductRepository(sqlConnectionString);
            //new MainPresenter(view, sqlConnectionString);
            //Application.Run((Form)view);
        }
    }
}