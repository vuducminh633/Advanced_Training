using UnityEngine;

public class Sword : MonoBehaviour
{

    [SerializeField]
    private SwordData swordData; // 1

    [SerializeField] private GameEvent OnSwordSelected;

    private void OnMouseDown() // 2
    {
       OnSwordSelected.Raise(); 
    }

}
