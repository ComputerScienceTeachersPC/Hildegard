using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace data.Models
{
    public class SetClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Reference { get; set; }
    }
}
