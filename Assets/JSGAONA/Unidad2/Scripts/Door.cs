using System.Collections;
using System.Collections.Generic;
using Jsgaona;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int id;
    [SerializeField] private int conexionId;
    [SerializeField] private int idScene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneLoadingManager.SceneInstance.LoadGameScene(idScene);
        }
    }
}
