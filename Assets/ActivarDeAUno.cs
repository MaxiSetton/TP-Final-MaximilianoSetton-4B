using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarDeAUno : MonoBehaviour
{
    public GameObject[] alimentos;
    int currentIndex = -1;
    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentIndex < alimentos.Length - 1)
            {
                currentIndex++;
            }
            else
            {
                currentIndex = 0;
            }
            DeactivateAll();
            alimentos[currentIndex].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentIndex > 0)
            {
                currentIndex--;
            }
            else
            {
                currentIndex = alimentos.Length - 1;
            }
            DeactivateAll();
            alimentos[currentIndex].SetActive(true);
        }

    }
    void DeactivateAll()
    {
        for (int i = 0; i < alimentos.Length; i++)
        {
            alimentos[i].SetActive(false);
        }
    }
}
