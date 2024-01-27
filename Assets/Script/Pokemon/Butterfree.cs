using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butterfree : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        stats = new Stats();
        name = "Butterfree";
        types = Types.Bug;
        types2 = Types.Flying;
        gender = Gender.Male;
        stats.hp = 60;
        stats.atk = 45;
        stats.def = 50;
        stats.spatk = 90;
        stats.spdef = 80;
        stats.speed = 70;
    }
}
