using UnityEngine;

public class ProceduralMesh : MonoBehaviour
{
    [SerializeField] private Material material;

    private MeshFilter _meshfilter;
    private Mesh _mesh;

    private MeshRenderer _meshRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //crear los componentes
        _meshfilter=gameObject.AddComponent<MeshFilter>();
        _meshRenderer=gameObject.AddComponent<MeshRenderer>();

        //crear el mesh
        _mesh= new Mesh();
        _mesh.name = "Procedural Mesh";

        //configurar mesh data

        _mesh.vertices = new Vector3[] 
        {
            //cara trasera
            new Vector3(0,0,0),//vertice0
            new Vector3(0,1,0),//vertice 1
            new Vector3(1,1,0),//vertice 2
            new Vector3(1,0,0),//vertice 3

            //cara frontal
            new Vector3(1,0,1),
            new Vector3(1,1,1),
            new Vector3(0,1,1),
            new Vector3(0,0,1),

            //cara izquierda
            new Vector3(1,0,0),
            new Vector3(1,1,0),
            new Vector3(1,1,1),
            new Vector3(1,0,1),
            //cara derecha
            new Vector3(0,0,1),
            new Vector3(0,1,1),
            new Vector3(0,1,0),
            new Vector3(0,0,0),
            //cara superior
            new Vector3(0,1,0),
            new Vector3(0,1,1),
            new Vector3(1,1,1),
            new Vector3(1,1,0),
            //cara inferior
            new Vector3(0,0,1),
            new Vector3(0,0,0),
            new Vector3(1,0,0),
            new Vector3(1,0,1),

        };

        _mesh.triangles = new int[]
        {
            //cara trasera
            0,1,2,//triangulo a
            0,2,3,//triangulo b

            //cara frontal
            4,5,6, //triangulo c
            4,6,7, //triangulo d

            //cara izquierda
            8,9,10,
            8,10,11,
            //cara derecha
            12,13,14,
            12,14,15,
            //cara superior
            16,17,18,
            16,18,19,
            //cara inferior
            20,21,22,
            20,22,23
        };

        _mesh.uv = new[]{

            new Vector2(0,0), //vertice 0
            new Vector2(0,1), //vertice 1
            new Vector2(1,1), //vertice 2
            new Vector2(1,0), //vertice 3

             new Vector2(0,0), //vertice 0
            new Vector2(0,1), //vertice 1
            new Vector2(1,1), //vertice 2
            new Vector2(1,0), //vertice 3

             new Vector2(0,0), //vertice 0
            new Vector2(0,1), //vertice 1
            new Vector2(1,1), //vertice 2
            new Vector2(1,0), //vertice 3

             new Vector2(0,0), //vertice 0
            new Vector2(0,1), //vertice 1
            new Vector2(1,1), //vertice 2
            new Vector2(1,0), //vertice 3

             new Vector2(0,0), //vertice 0
            new Vector2(0,1), //vertice 1
            new Vector2(1,1), //vertice 2
            new Vector2(1,0), //vertice 3

             new Vector2(0,0), //vertice 0
            new Vector2(0,1), //vertice 1
            new Vector2(1,1), //vertice 2
            new Vector2(1,0), //vertice 3

        };

        _mesh.normals = new[]
        {
            //cara trasera
            new Vector3(0,0,-1),
            Vector3.back,
            Vector3.back,
            Vector3.back,

            //cara frontal
            new Vector3(0,0,1),
            Vector3.forward,
            Vector3.forward,
            Vector3.forward,
            
            //cara izquierda
            new Vector3(-1,0,0),
            Vector3.left,
            Vector3.left,
            Vector3.left,
            
            //cara derecha
            new Vector3(1,0,0),
            Vector3.right,
            Vector3.right,
            Vector3.right,
            
            //cara superior
            new Vector3(0,1,0),
            Vector3.up,
            Vector3.up,
            Vector3.up,
            
            //cara inferior
            new Vector3(0,-1,0),
            Vector3.down,
            Vector3.down,
            Vector3.down,

        };

        _mesh.colors = new[]
        {
            //cara trasera
            Color.black ,
            Color.green ,
            Color.yellow ,
            Color.red ,

            //cara frontal
            Color.magenta,
            Color.white ,
            Color.cyan ,
            Color.blue ,

            //cara izquierda
            Color.red,
            Color.yellow ,
            Color.white ,
            Color.magenta ,

            //cara derecha
            Color.blue,
            Color.cyan ,
            Color.green ,
            Color.black ,

            //cara superior
            Color.green,
            Color.cyan ,
            Color.white ,
            Color.yellow ,

            //cara inferior
            Color.blue,
            Color.black ,
            Color.red ,
            Color.magenta ,

        };


        //asignar referencias
        _meshfilter.mesh= _mesh;
        _meshRenderer.material= material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
