using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbok : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        stats = new Stats();
        name = "Arbok";
        types = Types.Poison;
        types2 = Types.None;
        gender = Gender.Male;
        stats.hp = 60;
        stats.atk = 95;
        stats.def = 69;
        stats.spatk = 65;
        stats.spdef = 79;
        stats.speed = 80;
    }
}
