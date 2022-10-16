using Newtonsoft.Json;

namespace ChiOfTang.Global
{
    public class GlobalResultSave
    {
        public string Serialize(object data)
        {
            return JsonConvert.SerializeObject(data);
        }
    }
}