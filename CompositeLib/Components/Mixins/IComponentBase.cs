using Chickensoft.Introspection;

namespace CompositeLib.Components.Mixins;


[Mixin]
public interface IComponentBase : IMixin<IComponentBase>
{
    void IMixin<IComponentBase>.Handler()
    {
        
    }
    /// <summary>
    /// Called when owner is transferred to another host
    /// Main use is to be used when this component is assigned to its original host,
    /// but it's made as a transfer in case of that being somthing you want to do.
    /// </summary>
    /// <param name="oldOwner"></param>
    void OnOwnershipTransferred(IComponentHost oldOwner) { }
}