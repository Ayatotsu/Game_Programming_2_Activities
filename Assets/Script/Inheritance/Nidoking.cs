using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nidoking : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Nidoking";
        types = Types.Poison;
        types2 = Types.Ground;
        gender = Gender.Male;

        stats = new Stats();
        stats.hp = 81;
        stats.atk = 102;
        stats.def = 77;
        stats.spatk = 85;
        stats.spdef = 75;
        stats.speed = 85;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
