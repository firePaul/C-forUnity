using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InTrap 
{
    

        private static string _trap;

        public static void InSlowTrap()
        {
            _trap = "Вы в ловушке"; 
            Debug.Log(_trap);
        }
        
    
}
