using System;
using System.Collections.Generic;
using System.Text;

namespace telegramapp
{
    /// <summary>
    /// this represents a telegram account
    /// where you can chat or call
    /// to your friends or familys
    /// </summary>
    class account
    {
        #region properties
        public int phonenumber { get; set; }
        public string username { get; set; }
        public string chat { get; set; }
        public string groupchat { get; set; }
        public string contact { get; set; }
        public int call { get; set; }
        #endregion 

    }
}
