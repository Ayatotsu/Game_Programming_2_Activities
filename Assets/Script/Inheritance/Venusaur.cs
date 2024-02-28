using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venusaur : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Venusaur";
        types = Types.Grass;
        types2 = Types.Poison;
        gender = Gender.Male;

        stats = new Stats();
        stats.hp = 80;
        stats.atk = 82;
        stats.def = 83;
        stats.spatk = 100;
        stats.spdef = 100;
        stats.speed = 80;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
