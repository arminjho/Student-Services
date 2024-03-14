using FIT.WinForms.Asinhrono;
using FIT.WinForms.Izvjestaji;
using FIT.WinForms.Predavanja;
using FIT.WinForms.Predmeti;
using FIT.WinForms.Studenti;

namespace FIT.WinForms
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
            var startnaForma = new frmPrijava(); // frmGlavna(); //frmStudentiPretraga();            
            Application.Run(startnaForma);
        }
    }
}