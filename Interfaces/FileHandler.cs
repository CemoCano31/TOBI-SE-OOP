

namespace Interfaces;

/// <summary>
/// Ein Interface ist ein Vertrag.
/// Wer ein Interface Implementiert muss alle Member (Eigenschaften + Methoden)
/// des Interfaces implementieren.
/// Man könnte auch sagen ein Interface ist eine Blaupause für eine Klasse/Struct,
/// welche beschreibt was eine diese haben müssen, aber nicht wie diese sein müssen
/// </summary>

public interface FileHandler
{
  public string FilePath  { get; set; }

  

  public void DeleteFile();
 
}
