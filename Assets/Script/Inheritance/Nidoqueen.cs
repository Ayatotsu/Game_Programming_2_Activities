using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nidoqueen : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Nidoqueen";
        types = Types.Poison;
        types2 = Types.Ground;
        gender = Gender.Female;

        stats = new Stats();
        stats.hp = 90;
        stats.atk = 92;
        stats.def = 87;
        stats.spatk = 75;
        stats.spdef = 85;
        stats.speed = 76;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
