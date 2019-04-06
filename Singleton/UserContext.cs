using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton {
    class UserContext {

        static UserContext instance;

        public int UserId { get; private set; }
        public string Username { get; private set; }

        private UserContext() {
            
        }

        public void Load() {
            // TODO: Load the date from somewhere
        }



        public static UserContext Instance {
            get {
                if (instance == null)
                    instance = new UserContext();
                return instance;
            }
        }
    }
}
