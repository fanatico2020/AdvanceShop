using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Shared.Validation
{
    public static class ValidacaoConexaoInternet
    {
        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);

        
        public static bool EstarConectado()
        {
            int Description;

            return InternetGetConnectedState(out Description, 0);
        }
    }
}
