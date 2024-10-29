using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class SaveSystem
{
    public List<string[]> ReadFromCSV(string filePath)
    {
        List<string[]> data = new List<string[]>();
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] row = line.Split(",");
                    data.Add(row);
                }
            }
            Debug.Log("Lenguaje Cambiado con Exito");
        }
        catch (System.Exception e)
        {
            Debug.Log($"Fallo al cambiar Lenguaje: {e.Message}");
        }
        return data;
    }
}