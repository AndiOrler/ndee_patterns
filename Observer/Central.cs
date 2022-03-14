namespace Observer
{
    class Central : IObservable<int>, IDisposable
    {
        private int _myValue;

        public int MyValue {
            get
            {
                return _myValue;
            }
            set
            {
                this._myValue = value;
                Notify();
            }
        }

        public Central()
        {
            this.MyValue = 0;            
        }

        List<IObserver<int>> _observers = new();
        public IDisposable Subscribe(IObserver<int> observer)
        {
            _observers.Add(observer);
            return this;
        }

        public void Notify()
        {
            if (this._myValue == 5)
            {
                _observers.ForEach(x => x.OnCompleted());
            } else
            {
                _observers.ForEach(x => x.OnNext(this._myValue));
            }
            
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}