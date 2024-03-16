
                        /*░█████╗░░█████╗░██╗░░░░░░█████╗░██╗░░░██╗██╗░░░░░░█████╗░████████╗░█████╗░██████╗░  ░█████╗░██████╗░██████╗░
                        ██╔══██╗██╔══██╗██║░░░░░██╔══██╗██║░░░██║██║░░░░░██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗██╔══██╗
                        ██║░░╚═╝███████║██║░░░░░██║░░╚═╝██║░░░██║██║░░░░░███████║░░░██║░░░██║░░██║██████╔╝  ███████║██████╔╝██████╔╝
                        ██║░░██╗██╔══██║██║░░░░░██║░░██╗██║░░░██║██║░░░░░██╔══██║░░░██║░░░██║░░██║██╔══██╗  ██╔══██║██╔═══╝░██╔═══╝░
                        ╚█████╔╝██║░░██║███████╗╚█████╔╝╚██████╔╝███████╗██║░░██║░░░██║░░░╚█████╔╝██║░░██║  ██║░░██║██║░░░░░██║░░░░░
                        ░╚════╝░╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝  ╚═╝░░╚═╝╚═╝░░░░░╚═╝░░░░░*/

                        //                                       Date Started ~ 16.03.2024                                          //
                        //                                Creator ~ https://github.com/vosticdev                                    //
                        //                              Repository ~ https://github.com/vosticdev                                   //
                        //                                 Contact ~ vostic.business@gmail.com                                      //
                        //                   Icon Credits ~ https://www.flaticon.com/free-icon/calculator_1011812                   //

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcUI
{
    static class Program
    {
        /// Entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorUI());
        }
    }
}
