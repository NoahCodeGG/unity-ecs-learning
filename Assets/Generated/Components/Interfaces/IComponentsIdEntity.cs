//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface IComponentsIdEntity {

    Components.Id componentsId { get; }
    bool hasComponentsId { get; }

    void AddComponentsId(int newValue);
    void ReplaceComponentsId(int newValue);
    void RemoveComponentsId();
}