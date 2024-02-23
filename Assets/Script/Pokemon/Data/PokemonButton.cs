using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PokemonButton : MonoBehaviour
{
    public GameObject pokemonData;
    public TextMeshProUGUI pokemonName;
    public TextMeshProUGUI pTypes;
    public TextMeshProUGUI pGender;
    public TextMeshProUGUI pHp;
    public TextMeshProUGUI pAtk;
    public TextMeshProUGUI pSpAtk;
    public TextMeshProUGUI pDef;
    public TextMeshProUGUI pSpDef;
    public TextMeshProUGUI pSpeed;
    public void SetPokemonData(Pokemon cPokemon)
    {
        pokemonData.SetActive(true);
        pokemonName.text = "Name:  " + cPokemon.name;
        pTypes.text = "Types:  " + cPokemon.types.ToString() + ", " + cPokemon.types2.ToString();
        pGender.text = "Gender:  " + cPokemon.gender.ToString();
        pHp.text = "HP:  " + cPokemon.pHp.ToString();
        pAtk.text = "Atk:  " + cPokemon.atk.ToString();
        pSpAtk.text = "SpAtk:  " + cPokemon.spatk.ToString();
        pDef.text = "Def:  " + cPokemon.def.ToString();
        pSpDef.text = "SpDef:  " + cPokemon.spdef.ToString();
        pSpeed.text = "Speed:  " + cPokemon.speed.ToString();
    }


}
