using UnityEngine;
using System.Collections;

public class NBTest : MonoBehaviour {

    Rigidbody2D m_playerRB;
    

    float m_totalTime;

    UnityEngine.UI.Text[] m_text;

	// Use this for initialization
	void Start () {
        m_text = new UnityEngine.UI.Text[2];
        m_text[0] = gameObject.GetComponent<UnityEngine.UI.Text>();
        //m_text[0] = gameObject.GetComponent<UnityEngine.UI.Text>();

	}
	
	// Update is called once per frame
	void Update () {
        var f_find = GameObject.FindGameObjectWithTag("RobotPlayer");
        m_playerRB = f_find.GetComponent<Rigidbody2D>();
        //var f_ob = gameObject.GetComponent<UnityEngine.UI.Text>();
        m_totalTime += Time.deltaTime;
        m_text[0].text = ("X Velocity: " + m_playerRB.velocity.x + "   TotalTime: " + m_totalTime);
        
	}
}
