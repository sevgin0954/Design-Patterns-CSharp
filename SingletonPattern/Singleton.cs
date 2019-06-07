namespace SingletonPattern
{
    internal class Singleton
    {
        private Singleton instance = null;
        private object padlock = new object();

        private Singleton() { }


        internal Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
