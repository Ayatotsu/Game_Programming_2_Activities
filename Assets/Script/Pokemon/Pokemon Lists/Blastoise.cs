using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.Analytics;
using TMPro;

public class Blastoise : PokemonData
{
    [Header("Reference Game Objects")]
    public TextMeshProUGUI pName;
    public TextMeshProUGUI pTypes;
    public TextMeshProUGUI pGender;
    public TextMeshProUGUI pHp;
    public TextMeshProUGUI pAtk;
    public TextMeshProUGUI pSpAtk;
    public TextMeshProUGUI pDef;
    public TextMeshProUGUI pSpDef;
    public TextMeshProUGUI pSpeed;
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

    void Update()
    {
        pName.text = "Name:  " + pokemonName;
        pTypes.text = "Types:  " + types;
        pGender.text = "Gender:  " + gender;
        pHp.text = "Hp:  " + stats.hp;
        pAtk.text = "Atk:  " + stats.atk;
        pSpAtk.text = "SpAtk:  " + stats.spatk;
        pDef.text = "Def:  " + stats.def;
        pSpDef.text = "SpDef:  " + stats.spdef;
        pSpeed.text = "Speed:  " + stats.speed;
    }
}
