using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Person : Entity
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public int CPF { get; set; }

        public string Nationality { get; set; }

        public int CEP { get; set; }

        public int State { get; set; }

        public string City { get; set; }

        public string PublicPlace { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

    }
}
