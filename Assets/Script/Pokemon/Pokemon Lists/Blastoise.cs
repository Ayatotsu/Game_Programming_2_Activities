using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.Analytics;
using TMPro;

public class Blastoise : PokemonData
{

    // Start is called before the first frame update
    void Start()
    {
        stats = new Stats();
        pokemonName = "Blastoise";
        types = Types.Water;
        types2 = Types.None;
        gender = Gender.Male;
        stats.hp = 79;
        stats.atk = 83;
        stats.def = 100;
        stats.spatk = 85;
        stats.spdef = 105;
        stats.speed = 78;
    }
}
