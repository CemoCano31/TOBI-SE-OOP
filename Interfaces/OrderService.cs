using System;

namespace Interfaces;

public class OrderService
{
  private BaseLogger logger;

  /* Das hier ist ein konkreites Beispiel für das Designpattern "Dependeny-Injection"
  Mit DI lassen sich Abhänigkeiten aus einer Klasse heraus extrahieren und auf 
  den Caller/ Nutzer der Klasse übertragen.*/
  public OrderService(BaseLogger logger)
  {
    this.logger = logger;
  }

  public void ProcessOrder(string orderID)
  {
    /*/*Hier den Logger zu instanziieren macht diese Klasse abhänig von der 
     spezifischen Logger-Implementation.
     Wenn die Logger-Implementation ausgetauscht werden soll, kann dies zu viel 
     Arbeit führen, je nach größe der Klasse./*
     */
    /*var logger =new Logger(); !Abhänigkeit!*/
    
    logger.Log($"Order {orderID} is being processed...");
    Thread.Sleep(1000);
    logger.Log($"Order {orderID} processed succsessfully");
    Thread.Sleep(1000);
    logger.Log($"Order {orderID} proccessing comlete!");
  }
}
