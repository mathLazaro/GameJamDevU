using UnityEngine;

public class Info : MonoBehaviour {
    public static int score;
    private void Update() {
        DontDestroyOnLoad(gameObject);
    }
}