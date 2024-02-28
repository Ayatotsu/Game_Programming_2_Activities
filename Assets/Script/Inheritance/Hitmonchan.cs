using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitmonchan : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Hitmonchan";
        types = Types.Fighting;
        types2 = Types.None;
        gender = Gender.Male;

        stats = new Stats();
        stats.hp = 50;
        stats.atk = 105;
        stats.def = 79;
        stats.spatk = 35;
        stats.spdef = 110;
        stats.speed = 76;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
