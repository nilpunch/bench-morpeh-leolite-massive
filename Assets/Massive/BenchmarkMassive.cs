using System;
using Massive;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

[Il2CppSetOption(Option.NullChecks, false)]
[Il2CppSetOption(Option.DivideByZeroChecks, false)]
[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
public class BenchmarkMassive : MonoBehaviour
{
    private Registry _registry;
    private ISystem _system;
    
    public void IterationTest(int entitiesCount)
    {
        _registry = new Registry ();
        _system = new MassiveIterationSystem(entitiesCount);
        _system.Init(_registry);
    }
    
    public void SingleMigrationTest(int entitiesCount)
    {
        _registry = new Registry ();
        _system = new MassiveSingleMigrationSystem(entitiesCount);
        _system.Init(_registry);
    }
    
    public void TripleMigrationTest(int entitiesCount)
    {
        _registry = new Registry ();
        _system = new MassiveTripleMigrationSystem(entitiesCount);
        _system.Init(_registry);
    }
    
    private void Update () 
    {
        _system?.Run ();
    }

    private void OnDestroy () 
    {
    }
}

public interface ISystem
{
    void Init(Registry registry);
    void Run();
}

[Il2CppSetOption(Option.NullChecks, false)]
[Il2CppSetOption(Option.DivideByZeroChecks, false)]
[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
public class MassiveIterationSystem : ISystem
{
    private Group _filter0;
    private Group _filter1;
    private Group _filter2;
    private Group _filter3;
    
    private DataSet<TestComponent0> _pool0;
    private DataSet<TestComponent1> _pool1;
    private DataSet<TestComponent2> _pool2;
    private DataSet<TestComponent3> _pool3;
    
    private int entitiesCount;
    private Registry _registry;

    public MassiveIterationSystem(int entitiesCount)
    {
        this.entitiesCount = entitiesCount;
    }
    
    public void Init(Registry registry) 
    {
        _registry = registry;
        _filter0 = registry.Group<Include<TestComponent0>>();
        _filter1 = registry.Group<Include<TestComponent0, TestComponent1>>();
        _filter2 = registry.Group<Include<TestComponent0, TestComponent1, TestComponent2>>();
        _filter3 = registry.Group<Include<TestComponent0, TestComponent1, TestComponent2, Include<TestComponent3>>>();
        
        _pool0 = registry.DataSet<TestComponent0>();
        _pool1 = registry.DataSet<TestComponent1>();
        _pool2 = registry.DataSet<TestComponent2>();
        _pool3 = registry.DataSet<TestComponent3>();
        
        for (int i = 0; i < entitiesCount; i++)
        {
            var e = registry.Create();
            _pool0.Assign(e);
            _pool1.Assign(e);
            _pool2.Assign(e);
            _pool3.Assign(e);
        }
    }

    public void Run()
    {
        foreach (var ent in _registry.View().Group(_filter3))
        {
            _pool0.Get(ent).Test++;
            _pool1.Get(ent).Test++;
            _pool2.Get(ent).Test++;
            _pool3.Get(ent).Test++;
        }
    }
}

[Il2CppSetOption(Option.NullChecks, false)]
[Il2CppSetOption(Option.DivideByZeroChecks, false)]
[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
public class MassiveSingleMigrationSystem : ISystem
{
    private Group _filter0;
    private Group _filter1;
    private Group _filter2;
    private Group _filter3;
    
    private DataSet<TestComponent0> _pool0;
    private DataSet<TestComponent1> _pool1;
    private DataSet<TestComponent2> _pool2;
    private DataSet<TestComponent3> _pool3;
    
    private int entitiesCount;
    private Registry _registry;

    public MassiveSingleMigrationSystem(int entitiesCount)
    {
        this.entitiesCount = entitiesCount;
    }
    
    public void Init(Registry registry) 
    {
        _registry = registry;
        _filter0 = registry.Group<Include<TestComponent0>>();
        _filter1 = registry.Group<Include<TestComponent0, TestComponent1>>();
        _filter2 = registry.Group<Include<TestComponent0, TestComponent1, TestComponent2>>();
        _filter3 = registry.Group<Include<TestComponent0, TestComponent1, TestComponent2, Include<TestComponent3>>>();
        
        _pool0 = registry.DataSet<TestComponent0>();
        _pool1 = registry.DataSet<TestComponent1>();
        _pool2 = registry.DataSet<TestComponent2>();
        _pool3 = registry.DataSet<TestComponent3>();
        
        for (int i = 0; i < entitiesCount; i++)
        {
            var e = registry.Create();
            _pool0.Assign(e);
            _pool1.Assign(e);
            _pool2.Assign(e);
            _pool3.Assign(e);
        }
    }

    public void Run()
    {
        foreach (var ent in _registry.View().Group(_filter3))
        {
            _pool1.Unassign(ent);
        }
        
        foreach (var ent in _registry.View().Group(_filter0))
        {
            _pool1.Assign(ent);
        }
    }
}

[Il2CppSetOption(Option.NullChecks, false)]
[Il2CppSetOption(Option.DivideByZeroChecks, false)]
[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
public class MassiveTripleMigrationSystem : ISystem
{
    private Group _filter0;
    private Group _filter1;
    private Group _filter2;
    private Group _filter3;
    
    private DataSet<TestComponent0> _pool0;
    private DataSet<TestComponent1> _pool1;
    private DataSet<TestComponent2> _pool2;
    private DataSet<TestComponent3> _pool3;
    
    private int entitiesCount;
    private Registry _registry;

    public MassiveTripleMigrationSystem(int entitiesCount)
    {
        this.entitiesCount = entitiesCount;
    }
    
    public void Init(Registry registry) 
    {
        _registry = registry;
        _filter0 = registry.Group<Include<TestComponent0>>();
        _filter1 = registry.Group<Include<TestComponent0, TestComponent1>>();
        _filter2 = registry.Group<Include<TestComponent0, TestComponent1, TestComponent2>>();
        _filter3 = registry.Group<Include<TestComponent0, TestComponent1, TestComponent2, Include<TestComponent3>>>();
        
        _pool0 = registry.DataSet<TestComponent0>();
        _pool1 = registry.DataSet<TestComponent1>();
        _pool2 = registry.DataSet<TestComponent2>();
        _pool3 = registry.DataSet<TestComponent3>();
        
        for (int i = 0; i < entitiesCount; i++)
        {
            var e = registry.Create();
            _pool0.Assign(e);
            _pool1.Assign(e);
            _pool2.Assign(e);
            _pool3.Assign(e);
        }
    }

    public void Run()
    {
        foreach (var ent in _registry.View().Group(_filter3))
        {
            _pool1.Unassign(ent);
            _pool2.Unassign(ent);
            _pool3.Unassign(ent);
        }

        foreach (var ent in _registry.View().Group(_filter0))
        {
            _pool1.Assign(ent);
            _pool2.Assign(ent);
            _pool3.Assign(ent);
        }
    }
}

public struct TestComponent0 { public int Test; }
public struct TestComponent1 { public int Test; }
public struct TestComponent2 { public int Test; }
public struct TestComponent3 { public int Test; }

#if ENABLE_IL2CPP
// Unity IL2CPP performance optimization attribute.
namespace Unity.IL2CPP.CompilerServices {
    using System;
    enum Option {
        NullChecks = 1,
        ArrayBoundsChecks = 2,
        DivideByZeroChecks = 3
    }

    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    class Il2CppSetOptionAttribute : Attribute {
        public Option Option { get; private set; }
        public object Value { get; private set; }

        public Il2CppSetOptionAttribute (Option option, object value) { Option = option; Value = value; }
    }
}
#endif