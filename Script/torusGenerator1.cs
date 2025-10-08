using UnityEngine;
[ExecuteInEditMode]
[RequireComponent (typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class torusGenerator : MonoBehaviour
{
    public bool creationProcess = false;
    private Mesh model3D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        model3D = new Mesh();
        model3D.name = "mon Mesh";
        GetComponent<MeshFilter>().mesh = model3D;
    }

    // Update is called once per frame
    void Update()
    {
        if (creationProcess)
        {
            model3D.SetVertices(new Vector3[]
            {
                new Vector3(-1.0f, 0.0f, -1.0f),
                new Vector3(1.0f, 0.0f, -1.0f),
                new Vector3(1.0f, 0.0f, 1.0f),
                new Vector3(-1.0f, 0.0f, 1.0f),
                new Vector3(-1.0f, 2.0f, -1.0f),
                new Vector3(1.0f, 2.0f, -1.0f),
                new Vector3(1.0f, 2.0f, 1.0f),
                new Vector3(-1.0f, 2.0f, 1.0f)
            });

            model3D.SetIndices(new int[] { 
                0, 2, 3, 0, 1, 2, //-Y
                3, 7, 0, 7, 4, 0, //-X
                0, 4, 5, 5, 1, 0, //Z
                1, 5, 2, 5, 6, 2, //X
                2, 6, 3, 6, 7, 3, //-Z
                7, 6, 4, 6, 5, 4, //Y
            
            }, MeshTopology.Triangles, 0);
            model3D.RecalculateBounds();
            Debug.Log("Modele 3D généré");
            creationProcess = false;
        }
    }
}
