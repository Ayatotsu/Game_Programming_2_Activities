using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbok : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Arbok";
        types = Types.Poison;
        types2 = Types.None;
        gender = Gender.Female;

        stats = new Stats();
        stats.hp = 60;
        stats.atk = 95;
        stats.def = 69;
        stats.spatk = 65;
        stats.spdef = 79;
        stats.speed = 80;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
