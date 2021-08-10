using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class FireBaseConnect
    {
        private static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Z4plqhJs5asEIuFq7ReEfyjLvNQE9MMr6euygB46",
            BasePath = "https://quanlysieuthi-12102000-default-rtdb.firebaseio.com/"
        };

         private static IFirebaseClient client;

        public static IFirebaseConfig Config { get => config; set => config = value; }
        public static IFirebaseClient Client { get => client; set => client = value; }

        public static void connectFireBase()
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                if (client != null)
                {
                    new UC_Message().showAlert("Kết nối dữ liệu thành công", UC_Message.enmType.Success);
                }
                else
                    new UC_Message().showAlert("Lỗi kết nối", UC_Message.enmType.Error);
            }
            catch (Exception e)
            {
                new UC_Message().showAlert("Lỗi: " + e.Message, UC_Message.enmType.Error);
            }
            
        }

    }
}
