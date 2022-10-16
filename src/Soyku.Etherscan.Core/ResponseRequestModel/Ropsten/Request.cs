using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyku.Etherscan.Core.ResponseRequestModel.Ropsten
{
    public class Request
    {
        public string Module { get; set; }
        public string Action { get; set; }
        public string Address { get; set; }
        public string Startblock { get; set; }
        public string Endblock { get; set; }
        public string Page { get; set; }
        public string Offset { get; set; }
        public string Sort { get; set; }
        public string Apikey { get; set; }
    }
}
