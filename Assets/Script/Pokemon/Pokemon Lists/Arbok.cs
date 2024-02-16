using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Arbok : PokemonData
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
        pokemonName = "Arbok";
        types = Types.Poison;
        types2 = Types.None;
        gender = Gender.Male;
        stats.hp = 60;
        stats.atk = 95;
        stats.def = 69;
        stats.spatk = 65;
        stats.spdef = 79;
        stats.speed = 80;
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
