using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    string contraseñaCorrecta;
    public Text ingresoUsuario;
    string contraseñaUsuario;
    public GameObject cartelMSJ;
    public Text textoMSJ;

    // Start is called before the first frame update
    void Start()
    {
        contraseñaCorrecta = "12345";
        cartelMSJ.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContraseña ()
    {
        contraseñaUsuario = ingresoUsuario.text;

        if (contraseñaUsuario == contraseñaCorrecta)
        {
            cartelMSJ.SetActive(true);
            textoMSJ.text = "BIENVENIDO";
            Debug.Log("BIENVENIDO");
        }

        else
        {
            cartelMSJ.SetActive(true);
            textoMSJ.text = "Contraseña INCORRECTA";
            Debug.Log("Contraseña INCORRECTA");
        }
    }
}
