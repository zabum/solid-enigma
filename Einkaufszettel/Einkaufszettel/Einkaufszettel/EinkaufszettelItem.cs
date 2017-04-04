using System;
using SQLite;

namespace Einkaufszettel
{
    public class EinkaufszettelItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Done { get; set; }
    }
}