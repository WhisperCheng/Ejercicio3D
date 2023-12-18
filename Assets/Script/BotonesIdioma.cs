using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization;
using UnityEngine.Rendering;

public class BotonesIdioma : MonoBehaviour
{
    List<Locale> lista;
    static int movimiento = 2;
    // Start is called before the first frame update
    void Start()
    {
        lista = LocalizationSettings.AvailableLocales.Locales;
    }

    public void botonDerecha()
    {
        if (movimiento < 2) 
        {
            LocalizationSettings.Instance.SetSelectedLocale(lista[++movimiento]);
        }
    }
    public void botonIzquierda()
    {
        if (movimiento > 0) 
        {
            LocalizationSettings.Instance.SetSelectedLocale(lista[--movimiento]);
        }
    }
}
