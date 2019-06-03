namespace SingletonPattern
{
    public class Singleton
    {
        private Singleton instance = null;
        private object padlock = new object();

        private Singleton() { }


        public Singleton GetInstance
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
