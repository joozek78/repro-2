using Starcounter;
using Starcounter.Startup.Routing;

namespace StarcounterApplication7
{
    [Url("/StarcounterApplication7/wrapper")]
    public partial class ViewModelWrapper : Json
    {
        public ViewModelWrapper()
        {
            InnerJson = Self.GET("/StarcounterApplication7/main");
        }
    }
}
