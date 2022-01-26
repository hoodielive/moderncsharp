/* Because a delegate is an object that knows how to call a method*/

public class Sender : MonoBehaviour
{
  public delegate void Test();
  public static event Test _delTester;
  private bool _isAlive;

  void Start()
  {
    // Invoke me in 3secs of OnEnable.
    Invoke("ExecuteEvent", 3f);
  }

  void ExecuteEvent()
  {
    if (_delTester != null)
      _delTester();
  }
}



