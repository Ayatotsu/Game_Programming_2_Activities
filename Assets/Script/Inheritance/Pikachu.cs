using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pikachu : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Pikachu";
        types = Types.Electric;
        types2 = Types.None;
        gender = Gender.Male;

        stats = new Stats();
        stats.hp = 45;
        stats.atk = 80;
        stats.def = 50;
        stats.spatk = 75;
        stats.spdef = 60;
        stats.speed = 120;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
