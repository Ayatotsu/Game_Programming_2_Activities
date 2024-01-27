using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.Analytics;

public class Charizard : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        stats = new Stats();
        name = "Charizard";
        types = Types.Fire;
        types2 = Types.Flying;
        gender = Gender.Male;
        stats.hp = 60;
        stats.atk = 95;
        stats.def = 69;
        stats.spatk = 65;
        stats.spdef = 79;
        stats.speed = 80;
    }
}
