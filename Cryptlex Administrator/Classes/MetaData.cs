using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptlex_Administrator.Classes
{
    internal class MetaData
    {
        public MetaData() { }
        public MetaData(int id, string key, string value, bool visible, DateTime createdAt, DateTime updatedAt) { 
            ID = id;
            Key = key;
            Value = value;
            Visible = visible;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public int ID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public bool Visible { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
