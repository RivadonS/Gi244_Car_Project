using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int _number = 0;
    string _player = "Rei";
    string _grade = "A";
    bool _isPlayer = false;
    public float _speed = .01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(_player);
    }

    // Update is called once per frame
    void Update()
    {
        Transform t = gameObject.GetComponent<Transform>();
        //t.Translate(0,0, _speed * Time.deltaTime);
        t.Translate(_speed * Time.deltaTime* Vector3.forward);

        float inputZ = Input.GetAxis("Vertical");

        //Vector3 movement = Vector3.forward * inputZ * _speed * Time.deltaTime;

        //transform.Translate(movement);
    }
}
