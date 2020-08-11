using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerIntegrationV3
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public float Rating { get; set; }
        public string[] Stars { get; set; }

    }
}
