using System;
using System.Collections.Generic;

namespace UnitOfWorkDemo.Repository.Models
{
    public partial class Doit
    {
        public int Id { get; set; }
        public string Msg { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
