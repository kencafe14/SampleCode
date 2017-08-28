using System;

namespace SingletonSample
{
    public class Singleton
    {
        private static Singleton _singleInstance = new Singleton();
        private Singleton()
        {
            Console.WriteLine("インスタンスを生成しました。");
        }

        public static Singleton GetInstance()
        {
            return _singleInstance;
        }
    }
}
