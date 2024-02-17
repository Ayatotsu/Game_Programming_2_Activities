using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public PokemonData pokemonData;

    public TextMeshProUGUI pTypes;
    public TextMeshProUGUI pGender;
    public TextMeshProUGUI pHp;
    public TextMeshProUGUI pAtk;
    public TextMeshProUGUI pSpAtk;
    public TextMeshProUGUI pDef;
    public TextMeshProUGUI pSpDef;
    public TextMeshProUGUI pSpeed;
    public void SetCharacterData(Stats stats)
    {

        pTypes.text = Types.Poison.ToString();
        pGender.text = Gender.Male.ToString();
        pHp.text = stats.hp.ToString();
        pAtk.text = stats.atk.ToString();
        pSpAtk.text = stats.spatk.ToString();
        pDef.text = stats.def.ToString();


    }


}
