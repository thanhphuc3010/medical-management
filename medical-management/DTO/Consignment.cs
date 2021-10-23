using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medical_management
{
    class Consignment
    {
        private string id;
        private int inventory;

        public Consignment(string id, int inventory)
        {
            this.Id = id;
            this.Inventory = inventory;
        }

        public string Id { get => id; set => id = value; }
        public int Inventory { get => inventory; set => inventory = value; }
    }
}
