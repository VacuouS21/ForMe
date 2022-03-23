using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp
{
    class KeyCheck
    {
        public event EventHandler<char>? OnKeyPressed;

        public void Run()
        {
       
            char c;
            while ((c = Console.ReadKey().KeyChar) != 'c')
            {
              
                OnKeyPressed?.Invoke(this, c);
                
            }
           
        }
    }
}
