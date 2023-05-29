using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactive_tutorial.entities
{
    public class ContentCharakter
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public string Video { get; set; }

        public string Picture { get; set; }

        public Progress Progress { get; set; }
    }
}
