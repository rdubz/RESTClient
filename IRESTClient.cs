using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTClient
{
    public interface IRESTClient
    {
        event Action<string> PutRequest;
        event Action<string> PostRequest;
        event Action<string> GetRequest;
        event Action FireClearTextBox;

        void ClearTextBox();
        string Response { set; }

        string StatusCode { set; }
    }
}
