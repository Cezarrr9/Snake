using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Settings
    {
        public static int CellSize { get; set; }   

        public Settings() 
        {
            CellSize = 20;
        }
    }
}
