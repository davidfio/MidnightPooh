using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaler : MonoBehaviour
{
    private Vector3 scaler = new Vector3(.1f, .1f, .1f);

    public void Pluser()
    {
        //if (this.transform.localScale != Vector3.zero)
        this.gameObject.transform.localScale += scaler;

        Debug.Log(this.transform.localScale);
    }

    public void Lesser()
    {
        if (this.transform.localScale != Vector3.zero)
            this.gameObject.transform.localScale -= scaler;

        Debug.Log(this.transform.localScale);

    }
}
