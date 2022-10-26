using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleJogo : MonoBehaviour
{
    public Text TextoMortes;
    public int QuantidadedeMortes;
    void Start()
    {
        QuantidadedeMortes = 10;
    }
    void Update()
    {
        TextoMortes.text = (QuantidadedeMortes.ToString());
    }
}
