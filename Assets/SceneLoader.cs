using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public static Vector3 targetLocation;

    public Vector3 worktableLocation = new Vector3();
    public Vector3 emergencyLocation = new Vector3();
    public Vector3 forkliftLocation = new Vector3();

    public void LoadWorktable()
    {
        targetLocation = worktableLocation;
        SceneManager.LoadScene("TrainingCenter", LoadSceneMode.Single);
    }

    public void LoadEmergency()
    {
        targetLocation = emergencyLocation;
        SceneManager.LoadScene("TrainingCenter", LoadSceneMode.Single);
    }

    public void LoadForklift()
    {
        targetLocation = forkliftLocation;
        SceneManager.LoadScene("TrainingCenter", LoadSceneMode.Single);
    }
}

