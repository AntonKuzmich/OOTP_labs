using System;

namespace lab5
{
    interface IControl
    {
        string type { get; set; }
        public int size { get; set; }

        public string Show();
        public string Input(string obj, string param);
        public int Resize();
    }

}
