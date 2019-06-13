using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectDetection : MonoBehaviour
{
    [SerializeField] Image[] exampleImg;
   [SerializeField] Text effectName;
   [SerializeField] int nextImg = 0;

       void Start()
    {  
         for (int i = 0; i < exampleImg.Length; i++)
        {
            exampleImg[i].color = new Color (0,0,0,0);
        }
    }
   void OnTriggerEnter(Collider other)
   {
    
      if (other.gameObject.tag == "effect")
      {
          effectName.text = other.gameObject.name;
          exampleImg[nextImg].color = new Color(1,1,1,1);
      }
   }

   void OnTriggerExit(Collider other)
   {
       if (other.gameObject.tag == "effect")
      {
          effectName.text = "";
          exampleImg[nextImg].color = new Color(0,0,0,0);
          nextImg++;
      }
   }
}
