using UnityEngine;
using UnityEngine.SceneManagement; 

public class ChangeScene : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        
        if (other.gameObject.name == "Goober (Enemy)")
        {
              Debug.Log(other.gameObject.name);
            SceneManager.LoadScene("_Scene_1");
        }
    }
}
