using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using TMPro;

public class ControlOleadas : MonoBehaviour, MMEventListener<MMGameEvent>
{
    [SerializeField]
    private TMP_Text texto;

    void OnEnable()
    {
        this.MMEventStartListening<MMGameEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<MMGameEvent>();
    }
    public virtual void OnMMEvent(MMGameEvent e)
    {
        if(e.EventName == "ActualizarUIOla")
        {
            Oleadas temp = ControlOleadas.Instance;
            texto.text = "Oleada " + temp.OlaActual + "/" + temp.CantidadOlas();
        }
    }
}
