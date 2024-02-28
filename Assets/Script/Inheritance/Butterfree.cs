using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butterfree : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Butterfree";
        types = Types.Flying;
        types2 = Types.Bug;
        gender = Gender.Female;

        stats = new Stats();
        stats.hp = 60;
        stats.atk = 45;
        stats.def = 50;
        stats.spatk = 90;
        stats.spdef = 80;
        stats.speed = 70;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
