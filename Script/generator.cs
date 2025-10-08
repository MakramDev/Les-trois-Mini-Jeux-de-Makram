using JetBrains.Annotations;
using UnityEngine;

public class generator : MonoBehaviour
{
    [SerializeField] private GameObject generatedThing;


    private void SpawnThing()
    {
        Instantiate(generatedThing);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            SpawnThing();
            generatedThing.transform.position = generatedThing.transform.position + new Vector3(1, 0, 0);
            Debug.Log("Thing Generated");
        }
    }
}
