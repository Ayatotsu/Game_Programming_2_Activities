using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charizard : PokemonData
{
    // Start is called before the first frame update
    void Start()
    {
        pokemonName = "Charizard";
        types = Types.Fire;
        types2 = Types.Flying;
        gender = Gender.Male;

        stats = new Stats();
        stats.hp = 78;
        stats.atk = 84;
        stats.def = 78;
        stats.spatk = 109;
        stats.spdef = 85;
        stats.speed = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
