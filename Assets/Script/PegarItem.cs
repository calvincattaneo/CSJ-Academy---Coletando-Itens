using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PegarItem : MonoBehaviour {
    public int Pontuacao;
    public Text PontCont;

    private void Update() {
        PontCont.text = "X " + Pontuacao.ToString();
    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Moeda") {
            Pontuacao += 10;
            Destroy(collision.gameObject);
        }
    }

}
