using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManagement gameManagement;

    void OnTriggerEnter()
    {
        gameManagement.FinishLevel();
    }
}
