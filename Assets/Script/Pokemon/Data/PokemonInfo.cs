using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PokemonInfo : MonoBehaviour
{
    public Pokemon pokemon;

    [Header("UI Headers")]

    public TextMeshProUGUI pokemonName;
    public TextMeshProUGUI pokemonTypes;
    public TextMeshProUGUI pokemonGender;
    public TextMeshProUGUI pokemonHp;
    public TextMeshProUGUI pokemonAtk;
    public TextMeshProUGUI pokemonSpAtk;
    public TextMeshProUGUI pokemonDef;
    public TextMeshProUGUI pokemonSpDef;
    public TextMeshProUGUI pokemonSpeed;

    public void ShowUI() 
    {
        DisplayPokemon(pokemon);
    }
    public void DisplayPokemon(Pokemon pokemon)
    {
        pokemonName.text = pokemon.name;
        pokemonTypes.text = pokemon.types.ToString() + pokemon.types2.ToString();
        pokemonGender.text = pokemon.gender.ToString();
        pokemonHp.text = pokemon.pHp.ToString();
        pokemonAtk.text = pokemon.atk.ToString();
        pokemonSpAtk.text = pokemon.spatk.ToString();
        pokemonDef.text = pokemon.def.ToString();
        pokemonSpDef.text = pokemon.spdef.ToString();
        pokemonSpeed.text = pokemon.speed.ToString();

    }

    public void ClearUI()
    {
        pokemon = null;
        pokemonName = null;
        pokemonTypes = null;
        pokemonGender = null;
        pokemonHp = null;
        pokemonAtk = null;
        pokemonSpAtk = null;
        pokemonDef = null;
        pokemonSpDef = null;
        pokemonSpeed = null;
    }

    public void OnDisable()
    {
        ClearUI();
    }
}
