using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Models.DomainModels
{
    public class DbNameOnThisDbServer
    {
 
            public int Id { get; set; }
            public string Name { get; set; }
            public bool IsSelected { get; set; }

        public DbServerParameters DbServerParameters { get; set; }
        public int DbServerParametersId { get; set; }

    }
}
