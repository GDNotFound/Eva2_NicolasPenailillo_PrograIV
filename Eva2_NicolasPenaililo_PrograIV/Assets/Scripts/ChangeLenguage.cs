using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChangeLenguage
{
    public int attackDamage;
    public int abilityPower;
    public int armor;
    public int magicResistance;
    public int attackSpeed;
    public int abilityHaste;
    public int criticalChance;
    public int movementSpeed;
    public int healthRegeneration;
    public int manaRegeneration;
    public int armorPenetration;
    public int magicPenetration;
    public int lifeSteal;
    public int spellSteal;
    public int range;
    public int tenacity;
    public int lenguage;

    string filePath = Application.streamingAssetsPath + "/" + "CSVIdiomas.csv";
    public Dictionary<int , string> ActiveDictionary;
    public void SetDictionary(int lenguaje)
    {
        List<string[]> tabla = new SaveSystem().ReadFromCSV(filePath);
        ActiveDictionary = CreateRowDictionary(tabla, lenguage);
    }
    public Dictionary<int, string> CreateRowDictionary(List<string[]> csvData,int lenguage)
    {
        Dictionary<int, string> tableDictionary = new Dictionary<int, string>();
        string[] filaCompleta = csvData[lenguage];
        for (int i = 0; i < filaCompleta.Length; i++)
        {
            tableDictionary.Add(i, filaCompleta[i]);
        }
        return tableDictionary;
    }
}
