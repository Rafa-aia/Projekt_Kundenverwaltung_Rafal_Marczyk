using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XML_Kundenverwaltung_MVC_GrundstrukturAufgabe_Rafal_Marczyk
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new dieForm());

            /*
                XDocument Kunden = new XDocument(

                    new XElement("Kunden",
                        new XElement("Kundennummer")
                        new XElement("Name", "")
                        new XElement("Vorname")
                        new XElement("Strasse")
                        new XElement("Hausnummer")
                        new XElement("PLZ")
                        new XElement("Ort")
                        new XElement("E-Mailadresse")
                        );
            */

            XDocument Kunden = XDocument.Load("Kunden.xml"); 
        }
    }
}
