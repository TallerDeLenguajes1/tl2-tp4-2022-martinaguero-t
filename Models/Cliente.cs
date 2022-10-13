using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCtest.Models
{
    public class Cliente
    {
        private string name;
        private int edad;
        public Cliente(string name, int edad){
            this.Name = name;
            this.Edad = edad;
        }
        public Cliente(){
            
        }

        public string Name { get => name; set => name = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}