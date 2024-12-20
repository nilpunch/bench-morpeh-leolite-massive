using TMPro;
using UnityEngine;

public class Runner : MonoBehaviour
{
    public GameObject rootOverlay;
    public TMP_InputField inputField;

    public BenchmarkMorpeh morpeh;
    public BenchmarkLeo leoLite;
    public BenchmarkMassive massive;
    
    public void LeoLiteIteration()
    {
        rootOverlay.SetActive(false);
        leoLite.IterationTest(int.Parse(inputField.text));
    }
    
    public void LeoLiteSingleMigration()
    {
        rootOverlay.SetActive(false);
        leoLite.SingleMigrationTest(int.Parse(inputField.text));
    }
    
    public void LeoLiteTripleMigration()
    {
        rootOverlay.SetActive(false);
        leoLite.TripleMigrationTest(int.Parse(inputField.text));
    }
    
    public void MorpehIteration()
    {
        rootOverlay.SetActive(false);
        morpeh.IterationTest(int.Parse(inputField.text));
    }
    
    public void MorpehSingleMigration()
    {
        rootOverlay.SetActive(false);
        morpeh.SingleMigrationTest(int.Parse(inputField.text));
    }
    
    public void MorpehTripleMigration()
    {
        rootOverlay.SetActive(false);
        morpeh.TripleMigrationTest(int.Parse(inputField.text));
    }
    
    public void MassiveIteration()
    {
        rootOverlay.SetActive(false);
        massive.IterationTest(int.Parse(inputField.text));
    }
    
    public void MassiveSingleMigration()
    {
        rootOverlay.SetActive(false);
        massive.SingleMigrationTest(int.Parse(inputField.text));
    }
    
    public void MassiveTripleMigration()
    {
        rootOverlay.SetActive(false);
        massive.TripleMigrationTest(int.Parse(inputField.text));
    }
}
