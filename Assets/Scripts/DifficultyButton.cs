using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DifficultyButton : MonoBehaviour
{
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button + GetComponent<Button>();
        button.onClickAddListener(SetDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
