using System;

namespace ConsoleAppSerializationRevision
{
    [Serializable]
    internal class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
    }
}
