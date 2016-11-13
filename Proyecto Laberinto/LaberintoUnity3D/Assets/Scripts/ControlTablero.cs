using UnityEngine;
using System.Collections;

public class ControlTablero : MonoBehaviour {
    public float anguloGiro;
    public float limiteGiro;
    private float limiteActualGiroX;
    private float limiteActualGiroZ;
    private float limiteMaxGiroX;
    private float limiteMaxGiroZ;

    // Use this for initialization
    void Start () {
        this.limiteActualGiroX = 0.0f;
        this.limiteActualGiroZ = 0.0f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Horizontal") != 0.0f && Mathf.Abs(this.limiteActualGiroX) <= this.limiteGiro)
        {
            this.transform.Rotate(0, 0, Time.deltaTime * this.anguloGiro * -(Input.GetAxis("Horizontal")), Space.World);
            this.limiteActualGiroX += Time.deltaTime * this.anguloGiro * -(Input.GetAxis("Horizontal"));
        }
        else if (Input.GetAxis("Horizontal") != 0.0f && Mathf.Abs(this.limiteActualGiroX) > this.limiteGiro)
        {
            this.limiteMaxGiroX = this.limiteActualGiroX;
            this.limiteActualGiroX += Time.deltaTime * this.anguloGiro * -(Input.GetAxis("Horizontal"));
            if (Mathf.Abs(this.limiteActualGiroX) > Mathf.Abs(this.limiteMaxGiroX))
            {
                this.limiteActualGiroX = this.limiteMaxGiroX;
            }
        }

        if (Input.GetAxis("Vertical") != 0.0f && Mathf.Abs(this.limiteActualGiroZ) <= this.limiteGiro)
        {
            this.transform.Rotate(Time.deltaTime * this.anguloGiro * Input.GetAxis("Vertical"), 0, 0, Space.World);
            this.limiteActualGiroZ += Time.deltaTime * this.anguloGiro * Input.GetAxis("Vertical");
        }
        else if (Input.GetAxis("Vertical") != 0.0f && Mathf.Abs(this.limiteActualGiroZ) > this.limiteGiro)
        {
            this.limiteMaxGiroZ = this.limiteActualGiroZ;
            this.limiteActualGiroZ += Time.deltaTime * this.anguloGiro * Input.GetAxis("Vertical");
            if (Mathf.Abs(this.limiteActualGiroZ) > Mathf.Abs(this.limiteMaxGiroZ))
            {
                this.limiteActualGiroZ = this.limiteMaxGiroZ;
            }
        }
        Debug.Log("posicion en X" + this.limiteActualGiroX);
        Debug.Log("posicion en Z" + this.limiteActualGiroZ);
    }
}