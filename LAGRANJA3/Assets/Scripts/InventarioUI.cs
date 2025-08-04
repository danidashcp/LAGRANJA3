using UnityEngine;
using UnityEngine.UIElements;

public class InventarioUI : MonoBehaviour
{
    private Label labelHuevos;
    private int huevosPrevios = -1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable() { 
         var root = GetComponent<UIDocument>().rootVisualElement;
         labelHuevos = root.Q<Label>("labelHuevos");
         }

         

    // Update is called once per frame
    void Update()
    {
        
        
        if (GameManager.instancia.huevos != huevosPrevios)
        {

          huevosPrevios = GameManager.instancia.huevos;
          labelHuevos.text = huevosPrevios.ToString();
        }
        
    }
}
