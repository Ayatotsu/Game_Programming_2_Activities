using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blastoise : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Hitmonchan";
        types = Types.Water;
        types2 = Types.None;
        gender = Gender.Male;

        stats = new Stats();
        stats.hp = 79;
        stats.atk = 83;
        stats.def = 100;
        stats.spatk = 85;
        stats.spdef = 105;
        stats.speed = 78;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
