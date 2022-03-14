namespace Observer
{
    class Outpost : IObserver<int>
    {
        public string OutpostName { get; set; }

        public Outpost()
        {
            this.OutpostName = "";            
        }

        public Outpost(string name)
        {
            this.OutpostName = name;            
        }

        public void OnCompleted()
        {
            Console.WriteLine($"{this.OutpostName} has completed his watch");
        }
        
        public  void OnError(Exception error)
        {
            Console.WriteLine("watch error");
        }
       
        public void OnNext(int value)
        {
            Console.WriteLine($"Value: {value}");
            Console.WriteLine($"{this.OutpostName} still watching");
        }
    }
}