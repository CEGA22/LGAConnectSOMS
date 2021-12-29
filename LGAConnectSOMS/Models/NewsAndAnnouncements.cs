using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
    public class NewsAndAnnouncements
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public byte[] ContentPhoto { get; set; }

        public string AuthorsName { get; set; }
       
        public DateTime DateCreated { get; set; }
    }
}
