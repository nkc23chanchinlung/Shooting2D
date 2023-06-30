using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHpCon : MonoBehaviour
{
    
    public Image bosshp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bosshp.fillAmount = BossController.Hp / 15f;
    }
}
