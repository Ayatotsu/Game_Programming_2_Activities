using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machamp : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Machamp";
        types = Types.Fighting;
        types2 = Types.None;
        gender = Gender.Male;

        stats = new Stats();
        stats.hp = 90;
        stats.atk = 130;
        stats.def = 80;
        stats.spatk = 65;
        stats.spdef = 85;
        stats.speed = 55;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
