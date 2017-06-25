namespace Websockettorest.DataAccess
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;    
    
    public enum EventStatus
    {        
        Idle,
        Running,
        Finished,
        Errorred
    }
}
