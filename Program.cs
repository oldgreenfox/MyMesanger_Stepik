// See https://aka.ms/new-console-template for more information

using MyMessanger_Stepik;
using Newtonsoft.Json;

Message msg = new Message("GreenFox", "Hello", DateTime.UtcNow);
string output = JsonConvert.SerializeObject(msg);
Console.WriteLine(output);
Message deserializeMsg = JsonConvert.DeserializeObject<Message>(output);
Console.WriteLine(deserializeMsg.ToString());

//{"UserName":"GreenFox","MessageText":"Hello","TimeStamp":"2022-07-22T20:03:57.784543Z"}
//GreenFox <22.07.2022 20:03:57>: Hello
