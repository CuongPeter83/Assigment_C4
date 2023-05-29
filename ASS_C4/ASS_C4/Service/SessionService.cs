using Assignment.Models.Data;
using Newtonsoft.Json;

namespace Assignment.Service
{
    public static class SessionService
    {
        // lay data tu session tra ve 1 list san pham
        public static List<CartDetails> GetObjFormSession(ISession session, string key)
        {
            string JsonData = session.GetString(key);
            // lay string data tu session o dang Json
            // Convert ve list
            if(JsonData == null)
            {
                return new List<CartDetails>(); // tao moi du lieu khi du lieu null
            }
            var product  = JsonConvert.DeserializeObject<List<CartDetails>>(JsonData);
            return product;
        }
        //Ghi du lieu tu 1 list vao Session
        public static void SetObjSession(ISession session, string key , object value)
        {
            var JsonData = JsonConvert.SerializeObject(value);
            session.SetString(key, JsonData);
        }

        //Kiem tra su ton tai san pham trong list
        public static bool CheckSession(Guid id , List<CartDetails> list)
        {
            return list.Any(p => p.ID == id);
        }
    }
}
