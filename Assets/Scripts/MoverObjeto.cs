using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[RequireComponent(typeof(MeshCollider))]

public class MoverObjeto : MonoBehaviour {

    public Vector3 screenPoint;
    public Vector3 offset;
    public Vector3 scanPos;

    [SerializeField]
    public AudioSource won;


    public GameObject selectedObject;
    // Use this for initialization
    void Start () {

    }

	// Update is called once per frame
	void Update () {

        validadeTagram();

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                selectedObject = hit.transform.gameObject;
                Debug.Log(hit.transform.gameObject.name);
            }
        }

        if (Input.GetAxisRaw("Horizontal") < 0){
           selectedObject.transform.Rotate(0, 0, Time.deltaTime + 0.5f);
        }
        if (Input.GetAxisRaw("Horizontal") >  0){
            selectedObject.transform.Rotate(0, 0, Time.deltaTime - 0.5f);
        }

        scanPos = transform.position;
    }

    void OnMouseDown() {

        screenPoint = Camera.main.WorldToScreenPoint(scanPos);
        offset = scanPos - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag() {

        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

    bool validadeTagram(){

        bool triangle_big_1 = false;
        bool triangle_big_2 = false;
        bool triangle_middle = false;
        bool triangle_small_1 = false;
        bool triangle_small_2 = false;
        bool parallelogram = false;
        bool square = false;

        //Vector3 v_triangle_big_1 = GameObject.Find("triangle_big_1").transform.position;
        //Vector3 v_triangle_big_1_s = GameObject.Find("triangle_big_1_s").transform.position;

        //Vector3 v_triangle_big_2 = GameObject.Find("triangle_big_2").transform.position;
        //Vector3 v_triangle_big_2_s = GameObject.Find("triangle_big_2_s").transform.position;

        //Vector3 v_triangle_middle = GameObject.Find("triangle_middle").transform.position;
        //Vector3 v_triangle_middle_s = GameObject.Find("triangle_middle_s").transform.position;

        //Vector3 v_triangle_small_1 = GameObject.Find("triangle_small_1").transform.position;
        //Vector3 v_triangle_small_1_s = GameObject.Find("triangle_small_1_s").transform.position;

        //Vector3 v_triangle_small_2 = GameObject.Find("triangle_small_2").transform.position;
        //Vector3 v_triangle_small_2_s = GameObject.Find("triangle_small_2_s").transform.position;

        //Vector3 v_parallelogram = GameObject.Find("parallelogram").transform.position;
        //Vector3 v_parallelogram_s = GameObject.Find("parallelogram_s").transform.position;

        //Vector3 v_square = GameObject.Find("square").transform.position;
        //Vector3 v_square_s = GameObject.Find("square_s").transform.position;

        GameObject v_triangle_big_1 = GameObject.Find("triangle_big_1");
        GameObject v_triangle_big_1_s = GameObject.Find("triangle_big_1_s");

        GameObject v_triangle_big_2 = GameObject.Find("triangle_big_2");
        GameObject v_triangle_big_2_s = GameObject.Find("triangle_big_2_s");

        GameObject v_triangle_big_3 = GameObject.Find("triangle_big_3");
        GameObject v_triangle_big_3_s = GameObject.Find("triangle_big_3_s");

        GameObject v_triangle_middle = GameObject.Find("triangle_middle");
        GameObject v_triangle_middle_s = GameObject.Find("triangle_middle_s");

        GameObject v_triangle_small_1 = GameObject.Find("triangle_small_1");
        GameObject v_triangle_small_1_s = GameObject.Find("triangle_small_1_s");

        GameObject v_triangle_small_2 = GameObject.Find("triangle_small_2");
        GameObject v_triangle_small_2_s = GameObject.Find("triangle_small_2_s");

        GameObject v_parallelogram = GameObject.Find("parallelogram");
        GameObject v_parallelogram_s = GameObject.Find("parallelogram_s");

        GameObject v_square = GameObject.Find("square");
        GameObject v_square_s = GameObject.Find("square_s");


        //TRIANGULO GRANDE
        if ((Vector3.Distance(v_triangle_big_1.transform.position, v_triangle_big_1_s.transform.position) <= 0.6f) && !triangle_big_1)
        {
            v_triangle_big_1.transform.position = new Vector3(v_triangle_big_1_s.transform.position.x, v_triangle_big_1_s.transform.position.y, v_triangle_big_1.transform.position.z);
            v_triangle_big_1.transform.rotation = v_triangle_big_1_s.transform.rotation;
            triangle_big_1 = true;
        }

        if ((Vector3.Distance(v_triangle_big_2.transform.position, v_triangle_big_2_s.transform.position) <= 0.6f) && !triangle_big_2)
        {
            v_triangle_big_2.transform.position = new Vector3(v_triangle_big_2_s.transform.position.x, v_triangle_big_2_s.transform.position.y, v_triangle_big_2.transform.position.z);
            v_triangle_big_2.transform.rotation = v_triangle_big_2_s.transform.rotation;
            triangle_big_2 = true;
        }

    

        //TRIANGULO MEDIO
        if ((Vector3.Distance(v_triangle_middle.transform.position, v_triangle_middle_s.transform.position) <= 0.6f) && !triangle_middle)
        {
            v_triangle_middle.transform.position = new Vector3(v_triangle_middle_s.transform.position.x, v_triangle_middle_s.transform.position.y, v_triangle_middle.transform.position.z);
            v_triangle_middle.transform.rotation = v_triangle_middle_s.transform.rotation;
            triangle_middle = true;
        }

        //TRIANGULO PEQUENO
        if ((Vector3.Distance(v_triangle_small_1.transform.position, v_triangle_small_1_s.transform.position) <= 0.6f) && !triangle_small_1)
        {
            v_triangle_small_1.transform.position = new Vector3(v_triangle_small_1_s.transform.position.x, v_triangle_small_1_s.transform.position.y, v_triangle_small_1.transform.position.z);
            v_triangle_small_1.transform.rotation = v_triangle_small_1_s.transform.rotation;
            triangle_small_1 = true;
        }

        if ((Vector3.Distance(v_triangle_small_2.transform.position, v_triangle_small_2_s.transform.position) <= 0.6f) && !triangle_small_2)
        {
            v_triangle_small_2.transform.position = new Vector3(v_triangle_small_2_s.transform.position.x, v_triangle_small_2_s.transform.position.y, v_triangle_small_2.transform.position.z);
            v_triangle_small_2.transform.rotation = v_triangle_small_2_s.transform.rotation;
            triangle_small_2 = true;
        }

        //PARALELOGRAMA
        if ((Vector3.Distance(v_parallelogram.transform.position, v_parallelogram_s.transform.position) <= 0.6f) && !parallelogram)
        {
            v_parallelogram.transform.position = new Vector3(v_parallelogram_s.transform.position.x, v_parallelogram_s.transform.position.y, v_parallelogram.transform.position.z);
            v_parallelogram.transform.rotation = v_parallelogram_s.transform.rotation;
            parallelogram = true;
        }

        //QUADRADO
        if ((Vector3.Distance(v_square.transform.position, v_square_s.transform.position) <= 0.6f) && !square)
        {
            v_square.transform.position = new Vector3(v_square_s.transform.position.x, v_square_s.transform.position.y, v_square.transform.position.z);
            v_square.transform.rotation = v_square_s.transform.rotation;
            square = true;
        }

        if (triangle_big_1 && triangle_big_2 && triangle_middle && triangle_small_1 && triangle_small_2 && parallelogram && square){

            if (!won.isPlaying)
            {
            Debug.Log("lsdjcsdc~dsc´ds~,clds WON");
            won.Play();

            }

        }

        return true;
    }

}
