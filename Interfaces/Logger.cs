namespace Interfaces;

// Um das Austauschen der Logger in Zukunft angenehmer zu gestalten, designen wir eine Abstrakte 
// Klasse, von der alle logger Erben.
// Abstrakte Klassen verhindern die Instanziierung dieser -> Absicherung deiner Schnittstellen

public abstract class BaseLogger 
{

  public abstract void Log(string message);
  
    
  
}

public class ConsoleLogger : BaseLogger
{
  public override void Log(string message)
  {
    Console.WriteLine(message);
  }
}
public class FileLogger : BaseLogger
{
  public override void Log(string message)
  {
    File.AppendAllText("./log.txt",$"{DateTime.Now}:{message}\n");
  }

}

public class JsonLogger : BaseLogger
{
  public override void Log(string message)
  {
    File.AppendAllText("./log.json",$"{DateTime.Now}:{message}\n");
  }
}




