
using System;

namespace Code.Pattern.Prototype
{
    public class ServerInfo : ICloneable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string IP { get; set; }
        public int Port { get; set; }
        public string Description { get; set; }

        public void Log() 
        {
            UnityEngine.Debug.Log(string.Format("{0},{1},{2},{3},{4}", ID, Name, IP, Port, Description));
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
