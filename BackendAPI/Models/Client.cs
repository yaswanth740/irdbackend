using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BackendAPI.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string client_name { get; set; }
        public string code { get; set; }
        public string email 
            { get; set; }

       
        //relation
       
        public List<client_inv_del> client_inv_del { get; set; }
    }
}
