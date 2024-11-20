/*
  var orderService = new OrderService();
  orderServicve.ProcessOrder("123456");
*/

using Interfaces;
var consoleLogger = new ConsoleLogger();
var orderService = new OrderService(consoleLogger);
orderService.ProcessOrder("123456");
orderService.ProcessOrder("789546");

var fileLogger = new FileLogger("./logger.txt");
var orderServiceWithFileLogging = new OrderService(logger: fileLogger);
orderServiceWithFileLogging.ProcessOrder("48757384");
orderServiceWithFileLogging.ProcessOrder("7856784");



