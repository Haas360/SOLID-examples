namespace SOLID_example.S
{
    public class BadExample
    {
        //Entry modem Class
        public void Connect(){ }
        public void Disconnect(){ }
        public void Send(){ }
        public void Recieve(){ }
    }







    public class BadExamplev1
    {
        //Responsible for connection
        public void Connect() { }
        public void Disconnect() { }
        //Responsible for comunication
        public void Send() { }
        public void Recieve() { }
    }
}
