using System;
using System.Collections.Generic;

namespace Singleton
{
    class Singleton
    {
        private List<string> messages = new List<string>();
        private static Singleton instance;

        private Singleton(){}

        public static Singleton Instance{
            get{
                if(instance == null){
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public void AddMessage(string msg){
            messages.Add(msg);
        }

        public bool HasMessage(string msg){
            return messages.Contains(msg);
        }
    }
}
