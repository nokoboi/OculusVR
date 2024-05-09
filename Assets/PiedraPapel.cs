using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PiedraPapel : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public string[] opciones = {"piedra", "papel", "tijera"};
    public string jugador;
    public GameObject cubito;

    // Start is called before the first frame update
    void Start()
    {

        texto.text = opciones[Random.Range(0, opciones.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        if(jugador.Equals(texto.text))
        {
            cubito.GetComponent<Renderer>().material.color = Color.red;
            Destroy(cubito,1);
        }
    }

    public void Piedra()
    {
        jugador = "piedra";
    }

    public void Papel()
    {
        jugador = "papel";
    }

    public void Tijera()
    {
        jugador = "tijera";
    }
}
