
using System;
using System.Runtime.CompilerServices;
using CommunityToolkit.HighPerformance;
using Arch.Core.Utils;

namespace Arch.Core;
public partial class World
{
    
    public void Set<T0, T1>(Entity entity, in T0? t0Component = default,in T1? t1Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        
        archetype.Set<T0, T1>(ref slot,  in t0Component,in t1Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        
    }
    
    public void Set<T0, T1, T2>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        
        archetype.Set<T0, T1, T2>(ref slot,  in t0Component,in t1Component,in t2Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        
    }
    
    public void Set<T0, T1, T2, T3>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        
        archetype.Set<T0, T1, T2, T3>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        
    }
    
    public void Set<T0, T1, T2, T3, T4>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        var oldT8 = archetype.Get<T8>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        ref var newT8 = ref archetype.Get<T8>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        OnComponentSet<T8>(entity, in oldT8, ref newT8);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        var oldT8 = archetype.Get<T8>(ref slot);
        var oldT9 = archetype.Get<T9>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        ref var newT8 = ref archetype.Get<T8>(ref slot);
        ref var newT9 = ref archetype.Get<T9>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        OnComponentSet<T8>(entity, in oldT8, ref newT8);
        OnComponentSet<T9>(entity, in oldT9, ref newT9);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        var oldT8 = archetype.Get<T8>(ref slot);
        var oldT9 = archetype.Get<T9>(ref slot);
        var oldT10 = archetype.Get<T10>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        ref var newT8 = ref archetype.Get<T8>(ref slot);
        ref var newT9 = ref archetype.Get<T9>(ref slot);
        ref var newT10 = ref archetype.Get<T10>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        OnComponentSet<T8>(entity, in oldT8, ref newT8);
        OnComponentSet<T9>(entity, in oldT9, ref newT9);
        OnComponentSet<T10>(entity, in oldT10, ref newT10);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        var oldT8 = archetype.Get<T8>(ref slot);
        var oldT9 = archetype.Get<T9>(ref slot);
        var oldT10 = archetype.Get<T10>(ref slot);
        var oldT11 = archetype.Get<T11>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        ref var newT8 = ref archetype.Get<T8>(ref slot);
        ref var newT9 = ref archetype.Get<T9>(ref slot);
        ref var newT10 = ref archetype.Get<T10>(ref slot);
        ref var newT11 = ref archetype.Get<T11>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        OnComponentSet<T8>(entity, in oldT8, ref newT8);
        OnComponentSet<T9>(entity, in oldT9, ref newT9);
        OnComponentSet<T10>(entity, in oldT10, ref newT10);
        OnComponentSet<T11>(entity, in oldT11, ref newT11);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        var oldT8 = archetype.Get<T8>(ref slot);
        var oldT9 = archetype.Get<T9>(ref slot);
        var oldT10 = archetype.Get<T10>(ref slot);
        var oldT11 = archetype.Get<T11>(ref slot);
        var oldT12 = archetype.Get<T12>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        ref var newT8 = ref archetype.Get<T8>(ref slot);
        ref var newT9 = ref archetype.Get<T9>(ref slot);
        ref var newT10 = ref archetype.Get<T10>(ref slot);
        ref var newT11 = ref archetype.Get<T11>(ref slot);
        ref var newT12 = ref archetype.Get<T12>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        OnComponentSet<T8>(entity, in oldT8, ref newT8);
        OnComponentSet<T9>(entity, in oldT9, ref newT9);
        OnComponentSet<T10>(entity, in oldT10, ref newT10);
        OnComponentSet<T11>(entity, in oldT11, ref newT11);
        OnComponentSet<T12>(entity, in oldT12, ref newT12);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        var oldT8 = archetype.Get<T8>(ref slot);
        var oldT9 = archetype.Get<T9>(ref slot);
        var oldT10 = archetype.Get<T10>(ref slot);
        var oldT11 = archetype.Get<T11>(ref slot);
        var oldT12 = archetype.Get<T12>(ref slot);
        var oldT13 = archetype.Get<T13>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        ref var newT8 = ref archetype.Get<T8>(ref slot);
        ref var newT9 = ref archetype.Get<T9>(ref slot);
        ref var newT10 = ref archetype.Get<T10>(ref slot);
        ref var newT11 = ref archetype.Get<T11>(ref slot);
        ref var newT12 = ref archetype.Get<T12>(ref slot);
        ref var newT13 = ref archetype.Get<T13>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        OnComponentSet<T8>(entity, in oldT8, ref newT8);
        OnComponentSet<T9>(entity, in oldT9, ref newT9);
        OnComponentSet<T10>(entity, in oldT10, ref newT10);
        OnComponentSet<T11>(entity, in oldT11, ref newT11);
        OnComponentSet<T12>(entity, in oldT12, ref newT12);
        OnComponentSet<T13>(entity, in oldT13, ref newT13);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        var oldT8 = archetype.Get<T8>(ref slot);
        var oldT9 = archetype.Get<T9>(ref slot);
        var oldT10 = archetype.Get<T10>(ref slot);
        var oldT11 = archetype.Get<T11>(ref slot);
        var oldT12 = archetype.Get<T12>(ref slot);
        var oldT13 = archetype.Get<T13>(ref slot);
        var oldT14 = archetype.Get<T14>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        ref var newT8 = ref archetype.Get<T8>(ref slot);
        ref var newT9 = ref archetype.Get<T9>(ref slot);
        ref var newT10 = ref archetype.Get<T10>(ref slot);
        ref var newT11 = ref archetype.Get<T11>(ref slot);
        ref var newT12 = ref archetype.Get<T12>(ref slot);
        ref var newT13 = ref archetype.Get<T13>(ref slot);
        ref var newT14 = ref archetype.Get<T14>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        OnComponentSet<T8>(entity, in oldT8, ref newT8);
        OnComponentSet<T9>(entity, in oldT9, ref newT9);
        OnComponentSet<T10>(entity, in oldT10, ref newT10);
        OnComponentSet<T11>(entity, in oldT11, ref newT11);
        OnComponentSet<T12>(entity, in oldT12, ref newT12);
        OnComponentSet<T13>(entity, in oldT13, ref newT13);
        OnComponentSet<T14>(entity, in oldT14, ref newT14);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        var oldT8 = archetype.Get<T8>(ref slot);
        var oldT9 = archetype.Get<T9>(ref slot);
        var oldT10 = archetype.Get<T10>(ref slot);
        var oldT11 = archetype.Get<T11>(ref slot);
        var oldT12 = archetype.Get<T12>(ref slot);
        var oldT13 = archetype.Get<T13>(ref slot);
        var oldT14 = archetype.Get<T14>(ref slot);
        var oldT15 = archetype.Get<T15>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        ref var newT8 = ref archetype.Get<T8>(ref slot);
        ref var newT9 = ref archetype.Get<T9>(ref slot);
        ref var newT10 = ref archetype.Get<T10>(ref slot);
        ref var newT11 = ref archetype.Get<T11>(ref slot);
        ref var newT12 = ref archetype.Get<T12>(ref slot);
        ref var newT13 = ref archetype.Get<T13>(ref slot);
        ref var newT14 = ref archetype.Get<T14>(ref slot);
        ref var newT15 = ref archetype.Get<T15>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        OnComponentSet<T8>(entity, in oldT8, ref newT8);
        OnComponentSet<T9>(entity, in oldT9, ref newT9);
        OnComponentSet<T10>(entity, in oldT10, ref newT10);
        OnComponentSet<T11>(entity, in oldT11, ref newT11);
        OnComponentSet<T12>(entity, in oldT12, ref newT12);
        OnComponentSet<T13>(entity, in oldT13, ref newT13);
        OnComponentSet<T14>(entity, in oldT14, ref newT14);
        OnComponentSet<T15>(entity, in oldT15, ref newT15);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        var oldT8 = archetype.Get<T8>(ref slot);
        var oldT9 = archetype.Get<T9>(ref slot);
        var oldT10 = archetype.Get<T10>(ref slot);
        var oldT11 = archetype.Get<T11>(ref slot);
        var oldT12 = archetype.Get<T12>(ref slot);
        var oldT13 = archetype.Get<T13>(ref slot);
        var oldT14 = archetype.Get<T14>(ref slot);
        var oldT15 = archetype.Get<T15>(ref slot);
        var oldT16 = archetype.Get<T16>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        ref var newT8 = ref archetype.Get<T8>(ref slot);
        ref var newT9 = ref archetype.Get<T9>(ref slot);
        ref var newT10 = ref archetype.Get<T10>(ref slot);
        ref var newT11 = ref archetype.Get<T11>(ref slot);
        ref var newT12 = ref archetype.Get<T12>(ref slot);
        ref var newT13 = ref archetype.Get<T13>(ref slot);
        ref var newT14 = ref archetype.Get<T14>(ref slot);
        ref var newT15 = ref archetype.Get<T15>(ref slot);
        ref var newT16 = ref archetype.Get<T16>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        OnComponentSet<T8>(entity, in oldT8, ref newT8);
        OnComponentSet<T9>(entity, in oldT9, ref newT9);
        OnComponentSet<T10>(entity, in oldT10, ref newT10);
        OnComponentSet<T11>(entity, in oldT11, ref newT11);
        OnComponentSet<T12>(entity, in oldT12, ref newT12);
        OnComponentSet<T13>(entity, in oldT13, ref newT13);
        OnComponentSet<T14>(entity, in oldT14, ref newT14);
        OnComponentSet<T15>(entity, in oldT15, ref newT15);
        OnComponentSet<T16>(entity, in oldT16, ref newT16);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        var oldT8 = archetype.Get<T8>(ref slot);
        var oldT9 = archetype.Get<T9>(ref slot);
        var oldT10 = archetype.Get<T10>(ref slot);
        var oldT11 = archetype.Get<T11>(ref slot);
        var oldT12 = archetype.Get<T12>(ref slot);
        var oldT13 = archetype.Get<T13>(ref slot);
        var oldT14 = archetype.Get<T14>(ref slot);
        var oldT15 = archetype.Get<T15>(ref slot);
        var oldT16 = archetype.Get<T16>(ref slot);
        var oldT17 = archetype.Get<T17>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        ref var newT8 = ref archetype.Get<T8>(ref slot);
        ref var newT9 = ref archetype.Get<T9>(ref slot);
        ref var newT10 = ref archetype.Get<T10>(ref slot);
        ref var newT11 = ref archetype.Get<T11>(ref slot);
        ref var newT12 = ref archetype.Get<T12>(ref slot);
        ref var newT13 = ref archetype.Get<T13>(ref slot);
        ref var newT14 = ref archetype.Get<T14>(ref slot);
        ref var newT15 = ref archetype.Get<T15>(ref slot);
        ref var newT16 = ref archetype.Get<T16>(ref slot);
        ref var newT17 = ref archetype.Get<T17>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        OnComponentSet<T8>(entity, in oldT8, ref newT8);
        OnComponentSet<T9>(entity, in oldT9, ref newT9);
        OnComponentSet<T10>(entity, in oldT10, ref newT10);
        OnComponentSet<T11>(entity, in oldT11, ref newT11);
        OnComponentSet<T12>(entity, in oldT12, ref newT12);
        OnComponentSet<T13>(entity, in oldT13, ref newT13);
        OnComponentSet<T14>(entity, in oldT14, ref newT14);
        OnComponentSet<T15>(entity, in oldT15, ref newT15);
        OnComponentSet<T16>(entity, in oldT16, ref newT16);
        OnComponentSet<T17>(entity, in oldT17, ref newT17);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        var oldT8 = archetype.Get<T8>(ref slot);
        var oldT9 = archetype.Get<T9>(ref slot);
        var oldT10 = archetype.Get<T10>(ref slot);
        var oldT11 = archetype.Get<T11>(ref slot);
        var oldT12 = archetype.Get<T12>(ref slot);
        var oldT13 = archetype.Get<T13>(ref slot);
        var oldT14 = archetype.Get<T14>(ref slot);
        var oldT15 = archetype.Get<T15>(ref slot);
        var oldT16 = archetype.Get<T16>(ref slot);
        var oldT17 = archetype.Get<T17>(ref slot);
        var oldT18 = archetype.Get<T18>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        ref var newT8 = ref archetype.Get<T8>(ref slot);
        ref var newT9 = ref archetype.Get<T9>(ref slot);
        ref var newT10 = ref archetype.Get<T10>(ref slot);
        ref var newT11 = ref archetype.Get<T11>(ref slot);
        ref var newT12 = ref archetype.Get<T12>(ref slot);
        ref var newT13 = ref archetype.Get<T13>(ref slot);
        ref var newT14 = ref archetype.Get<T14>(ref slot);
        ref var newT15 = ref archetype.Get<T15>(ref slot);
        ref var newT16 = ref archetype.Get<T16>(ref slot);
        ref var newT17 = ref archetype.Get<T17>(ref slot);
        ref var newT18 = ref archetype.Get<T18>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        OnComponentSet<T8>(entity, in oldT8, ref newT8);
        OnComponentSet<T9>(entity, in oldT9, ref newT9);
        OnComponentSet<T10>(entity, in oldT10, ref newT10);
        OnComponentSet<T11>(entity, in oldT11, ref newT11);
        OnComponentSet<T12>(entity, in oldT12, ref newT12);
        OnComponentSet<T13>(entity, in oldT13, ref newT13);
        OnComponentSet<T14>(entity, in oldT14, ref newT14);
        OnComponentSet<T15>(entity, in oldT15, ref newT15);
        OnComponentSet<T16>(entity, in oldT16, ref newT16);
        OnComponentSet<T17>(entity, in oldT17, ref newT17);
        OnComponentSet<T18>(entity, in oldT18, ref newT18);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        var oldT8 = archetype.Get<T8>(ref slot);
        var oldT9 = archetype.Get<T9>(ref slot);
        var oldT10 = archetype.Get<T10>(ref slot);
        var oldT11 = archetype.Get<T11>(ref slot);
        var oldT12 = archetype.Get<T12>(ref slot);
        var oldT13 = archetype.Get<T13>(ref slot);
        var oldT14 = archetype.Get<T14>(ref slot);
        var oldT15 = archetype.Get<T15>(ref slot);
        var oldT16 = archetype.Get<T16>(ref slot);
        var oldT17 = archetype.Get<T17>(ref slot);
        var oldT18 = archetype.Get<T18>(ref slot);
        var oldT19 = archetype.Get<T19>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        ref var newT8 = ref archetype.Get<T8>(ref slot);
        ref var newT9 = ref archetype.Get<T9>(ref slot);
        ref var newT10 = ref archetype.Get<T10>(ref slot);
        ref var newT11 = ref archetype.Get<T11>(ref slot);
        ref var newT12 = ref archetype.Get<T12>(ref slot);
        ref var newT13 = ref archetype.Get<T13>(ref slot);
        ref var newT14 = ref archetype.Get<T14>(ref slot);
        ref var newT15 = ref archetype.Get<T15>(ref slot);
        ref var newT16 = ref archetype.Get<T16>(ref slot);
        ref var newT17 = ref archetype.Get<T17>(ref slot);
        ref var newT18 = ref archetype.Get<T18>(ref slot);
        ref var newT19 = ref archetype.Get<T19>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        OnComponentSet<T8>(entity, in oldT8, ref newT8);
        OnComponentSet<T9>(entity, in oldT9, ref newT9);
        OnComponentSet<T10>(entity, in oldT10, ref newT10);
        OnComponentSet<T11>(entity, in oldT11, ref newT11);
        OnComponentSet<T12>(entity, in oldT12, ref newT12);
        OnComponentSet<T13>(entity, in oldT13, ref newT13);
        OnComponentSet<T14>(entity, in oldT14, ref newT14);
        OnComponentSet<T15>(entity, in oldT15, ref newT15);
        OnComponentSet<T16>(entity, in oldT16, ref newT16);
        OnComponentSet<T17>(entity, in oldT17, ref newT17);
        OnComponentSet<T18>(entity, in oldT18, ref newT18);
        OnComponentSet<T19>(entity, in oldT19, ref newT19);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,in T20? t20Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        var oldT8 = archetype.Get<T8>(ref slot);
        var oldT9 = archetype.Get<T9>(ref slot);
        var oldT10 = archetype.Get<T10>(ref slot);
        var oldT11 = archetype.Get<T11>(ref slot);
        var oldT12 = archetype.Get<T12>(ref slot);
        var oldT13 = archetype.Get<T13>(ref slot);
        var oldT14 = archetype.Get<T14>(ref slot);
        var oldT15 = archetype.Get<T15>(ref slot);
        var oldT16 = archetype.Get<T16>(ref slot);
        var oldT17 = archetype.Get<T17>(ref slot);
        var oldT18 = archetype.Get<T18>(ref slot);
        var oldT19 = archetype.Get<T19>(ref slot);
        var oldT20 = archetype.Get<T20>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        ref var newT8 = ref archetype.Get<T8>(ref slot);
        ref var newT9 = ref archetype.Get<T9>(ref slot);
        ref var newT10 = ref archetype.Get<T10>(ref slot);
        ref var newT11 = ref archetype.Get<T11>(ref slot);
        ref var newT12 = ref archetype.Get<T12>(ref slot);
        ref var newT13 = ref archetype.Get<T13>(ref slot);
        ref var newT14 = ref archetype.Get<T14>(ref slot);
        ref var newT15 = ref archetype.Get<T15>(ref slot);
        ref var newT16 = ref archetype.Get<T16>(ref slot);
        ref var newT17 = ref archetype.Get<T17>(ref slot);
        ref var newT18 = ref archetype.Get<T18>(ref slot);
        ref var newT19 = ref archetype.Get<T19>(ref slot);
        ref var newT20 = ref archetype.Get<T20>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        OnComponentSet<T8>(entity, in oldT8, ref newT8);
        OnComponentSet<T9>(entity, in oldT9, ref newT9);
        OnComponentSet<T10>(entity, in oldT10, ref newT10);
        OnComponentSet<T11>(entity, in oldT11, ref newT11);
        OnComponentSet<T12>(entity, in oldT12, ref newT12);
        OnComponentSet<T13>(entity, in oldT13, ref newT13);
        OnComponentSet<T14>(entity, in oldT14, ref newT14);
        OnComponentSet<T15>(entity, in oldT15, ref newT15);
        OnComponentSet<T16>(entity, in oldT16, ref newT16);
        OnComponentSet<T17>(entity, in oldT17, ref newT17);
        OnComponentSet<T18>(entity, in oldT18, ref newT18);
        OnComponentSet<T19>(entity, in oldT19, ref newT19);
        OnComponentSet<T20>(entity, in oldT20, ref newT20);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,in T20? t20Component = default,in T21? t21Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        var oldT8 = archetype.Get<T8>(ref slot);
        var oldT9 = archetype.Get<T9>(ref slot);
        var oldT10 = archetype.Get<T10>(ref slot);
        var oldT11 = archetype.Get<T11>(ref slot);
        var oldT12 = archetype.Get<T12>(ref slot);
        var oldT13 = archetype.Get<T13>(ref slot);
        var oldT14 = archetype.Get<T14>(ref slot);
        var oldT15 = archetype.Get<T15>(ref slot);
        var oldT16 = archetype.Get<T16>(ref slot);
        var oldT17 = archetype.Get<T17>(ref slot);
        var oldT18 = archetype.Get<T18>(ref slot);
        var oldT19 = archetype.Get<T19>(ref slot);
        var oldT20 = archetype.Get<T20>(ref slot);
        var oldT21 = archetype.Get<T21>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,in t21Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        ref var newT8 = ref archetype.Get<T8>(ref slot);
        ref var newT9 = ref archetype.Get<T9>(ref slot);
        ref var newT10 = ref archetype.Get<T10>(ref slot);
        ref var newT11 = ref archetype.Get<T11>(ref slot);
        ref var newT12 = ref archetype.Get<T12>(ref slot);
        ref var newT13 = ref archetype.Get<T13>(ref slot);
        ref var newT14 = ref archetype.Get<T14>(ref slot);
        ref var newT15 = ref archetype.Get<T15>(ref slot);
        ref var newT16 = ref archetype.Get<T16>(ref slot);
        ref var newT17 = ref archetype.Get<T17>(ref slot);
        ref var newT18 = ref archetype.Get<T18>(ref slot);
        ref var newT19 = ref archetype.Get<T19>(ref slot);
        ref var newT20 = ref archetype.Get<T20>(ref slot);
        ref var newT21 = ref archetype.Get<T21>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        OnComponentSet<T8>(entity, in oldT8, ref newT8);
        OnComponentSet<T9>(entity, in oldT9, ref newT9);
        OnComponentSet<T10>(entity, in oldT10, ref newT10);
        OnComponentSet<T11>(entity, in oldT11, ref newT11);
        OnComponentSet<T12>(entity, in oldT12, ref newT12);
        OnComponentSet<T13>(entity, in oldT13, ref newT13);
        OnComponentSet<T14>(entity, in oldT14, ref newT14);
        OnComponentSet<T15>(entity, in oldT15, ref newT15);
        OnComponentSet<T16>(entity, in oldT16, ref newT16);
        OnComponentSet<T17>(entity, in oldT17, ref newT17);
        OnComponentSet<T18>(entity, in oldT18, ref newT18);
        OnComponentSet<T19>(entity, in oldT19, ref newT19);
        OnComponentSet<T20>(entity, in oldT20, ref newT20);
        OnComponentSet<T21>(entity, in oldT21, ref newT21);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,in T20? t20Component = default,in T21? t21Component = default,in T22? t22Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        var oldT8 = archetype.Get<T8>(ref slot);
        var oldT9 = archetype.Get<T9>(ref slot);
        var oldT10 = archetype.Get<T10>(ref slot);
        var oldT11 = archetype.Get<T11>(ref slot);
        var oldT12 = archetype.Get<T12>(ref slot);
        var oldT13 = archetype.Get<T13>(ref slot);
        var oldT14 = archetype.Get<T14>(ref slot);
        var oldT15 = archetype.Get<T15>(ref slot);
        var oldT16 = archetype.Get<T16>(ref slot);
        var oldT17 = archetype.Get<T17>(ref slot);
        var oldT18 = archetype.Get<T18>(ref slot);
        var oldT19 = archetype.Get<T19>(ref slot);
        var oldT20 = archetype.Get<T20>(ref slot);
        var oldT21 = archetype.Get<T21>(ref slot);
        var oldT22 = archetype.Get<T22>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,in t21Component,in t22Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        ref var newT8 = ref archetype.Get<T8>(ref slot);
        ref var newT9 = ref archetype.Get<T9>(ref slot);
        ref var newT10 = ref archetype.Get<T10>(ref slot);
        ref var newT11 = ref archetype.Get<T11>(ref slot);
        ref var newT12 = ref archetype.Get<T12>(ref slot);
        ref var newT13 = ref archetype.Get<T13>(ref slot);
        ref var newT14 = ref archetype.Get<T14>(ref slot);
        ref var newT15 = ref archetype.Get<T15>(ref slot);
        ref var newT16 = ref archetype.Get<T16>(ref slot);
        ref var newT17 = ref archetype.Get<T17>(ref slot);
        ref var newT18 = ref archetype.Get<T18>(ref slot);
        ref var newT19 = ref archetype.Get<T19>(ref slot);
        ref var newT20 = ref archetype.Get<T20>(ref slot);
        ref var newT21 = ref archetype.Get<T21>(ref slot);
        ref var newT22 = ref archetype.Get<T22>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        OnComponentSet<T8>(entity, in oldT8, ref newT8);
        OnComponentSet<T9>(entity, in oldT9, ref newT9);
        OnComponentSet<T10>(entity, in oldT10, ref newT10);
        OnComponentSet<T11>(entity, in oldT11, ref newT11);
        OnComponentSet<T12>(entity, in oldT12, ref newT12);
        OnComponentSet<T13>(entity, in oldT13, ref newT13);
        OnComponentSet<T14>(entity, in oldT14, ref newT14);
        OnComponentSet<T15>(entity, in oldT15, ref newT15);
        OnComponentSet<T16>(entity, in oldT16, ref newT16);
        OnComponentSet<T17>(entity, in oldT17, ref newT17);
        OnComponentSet<T18>(entity, in oldT18, ref newT18);
        OnComponentSet<T19>(entity, in oldT19, ref newT19);
        OnComponentSet<T20>(entity, in oldT20, ref newT20);
        OnComponentSet<T21>(entity, in oldT21, ref newT21);
        OnComponentSet<T22>(entity, in oldT22, ref newT22);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,in T20? t20Component = default,in T21? t21Component = default,in T22? t22Component = default,in T23? t23Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        var oldT8 = archetype.Get<T8>(ref slot);
        var oldT9 = archetype.Get<T9>(ref slot);
        var oldT10 = archetype.Get<T10>(ref slot);
        var oldT11 = archetype.Get<T11>(ref slot);
        var oldT12 = archetype.Get<T12>(ref slot);
        var oldT13 = archetype.Get<T13>(ref slot);
        var oldT14 = archetype.Get<T14>(ref slot);
        var oldT15 = archetype.Get<T15>(ref slot);
        var oldT16 = archetype.Get<T16>(ref slot);
        var oldT17 = archetype.Get<T17>(ref slot);
        var oldT18 = archetype.Get<T18>(ref slot);
        var oldT19 = archetype.Get<T19>(ref slot);
        var oldT20 = archetype.Get<T20>(ref slot);
        var oldT21 = archetype.Get<T21>(ref slot);
        var oldT22 = archetype.Get<T22>(ref slot);
        var oldT23 = archetype.Get<T23>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,in t21Component,in t22Component,in t23Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        ref var newT8 = ref archetype.Get<T8>(ref slot);
        ref var newT9 = ref archetype.Get<T9>(ref slot);
        ref var newT10 = ref archetype.Get<T10>(ref slot);
        ref var newT11 = ref archetype.Get<T11>(ref slot);
        ref var newT12 = ref archetype.Get<T12>(ref slot);
        ref var newT13 = ref archetype.Get<T13>(ref slot);
        ref var newT14 = ref archetype.Get<T14>(ref slot);
        ref var newT15 = ref archetype.Get<T15>(ref slot);
        ref var newT16 = ref archetype.Get<T16>(ref slot);
        ref var newT17 = ref archetype.Get<T17>(ref slot);
        ref var newT18 = ref archetype.Get<T18>(ref slot);
        ref var newT19 = ref archetype.Get<T19>(ref slot);
        ref var newT20 = ref archetype.Get<T20>(ref slot);
        ref var newT21 = ref archetype.Get<T21>(ref slot);
        ref var newT22 = ref archetype.Get<T22>(ref slot);
        ref var newT23 = ref archetype.Get<T23>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        OnComponentSet<T8>(entity, in oldT8, ref newT8);
        OnComponentSet<T9>(entity, in oldT9, ref newT9);
        OnComponentSet<T10>(entity, in oldT10, ref newT10);
        OnComponentSet<T11>(entity, in oldT11, ref newT11);
        OnComponentSet<T12>(entity, in oldT12, ref newT12);
        OnComponentSet<T13>(entity, in oldT13, ref newT13);
        OnComponentSet<T14>(entity, in oldT14, ref newT14);
        OnComponentSet<T15>(entity, in oldT15, ref newT15);
        OnComponentSet<T16>(entity, in oldT16, ref newT16);
        OnComponentSet<T17>(entity, in oldT17, ref newT17);
        OnComponentSet<T18>(entity, in oldT18, ref newT18);
        OnComponentSet<T19>(entity, in oldT19, ref newT19);
        OnComponentSet<T20>(entity, in oldT20, ref newT20);
        OnComponentSet<T21>(entity, in oldT21, ref newT21);
        OnComponentSet<T22>(entity, in oldT22, ref newT22);
        OnComponentSet<T23>(entity, in oldT23, ref newT23);
        
    }
    
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(Entity entity, in T0? t0Component = default,in T1? t1Component = default,in T2? t2Component = default,in T3? t3Component = default,in T4? t4Component = default,in T5? t5Component = default,in T6? t6Component = default,in T7? t7Component = default,in T8? t8Component = default,in T9? t9Component = default,in T10? t10Component = default,in T11? t11Component = default,in T12? t12Component = default,in T13? t13Component = default,in T14? t14Component = default,in T15? t15Component = default,in T16? t16Component = default,in T17? t17Component = default,in T18? t18Component = default,in T19? t19Component = default,in T20? t20Component = default,in T21? t21Component = default,in T22? t22Component = default,in T23? t23Component = default,in T24? t24Component = default)
    {
        ref var entitySlot = ref EntityInfo.GetEntityData(entity.Id);
        var slot = entitySlot.Slot;
        var archetype = entitySlot.Archetype;
        var oldT0 = archetype.Get<T0>(ref slot);
        var oldT1 = archetype.Get<T1>(ref slot);
        var oldT2 = archetype.Get<T2>(ref slot);
        var oldT3 = archetype.Get<T3>(ref slot);
        var oldT4 = archetype.Get<T4>(ref slot);
        var oldT5 = archetype.Get<T5>(ref slot);
        var oldT6 = archetype.Get<T6>(ref slot);
        var oldT7 = archetype.Get<T7>(ref slot);
        var oldT8 = archetype.Get<T8>(ref slot);
        var oldT9 = archetype.Get<T9>(ref slot);
        var oldT10 = archetype.Get<T10>(ref slot);
        var oldT11 = archetype.Get<T11>(ref slot);
        var oldT12 = archetype.Get<T12>(ref slot);
        var oldT13 = archetype.Get<T13>(ref slot);
        var oldT14 = archetype.Get<T14>(ref slot);
        var oldT15 = archetype.Get<T15>(ref slot);
        var oldT16 = archetype.Get<T16>(ref slot);
        var oldT17 = archetype.Get<T17>(ref slot);
        var oldT18 = archetype.Get<T18>(ref slot);
        var oldT19 = archetype.Get<T19>(ref slot);
        var oldT20 = archetype.Get<T20>(ref slot);
        var oldT21 = archetype.Get<T21>(ref slot);
        var oldT22 = archetype.Get<T22>(ref slot);
        var oldT23 = archetype.Get<T23>(ref slot);
        var oldT24 = archetype.Get<T24>(ref slot);
        
        archetype.Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(ref slot,  in t0Component,in t1Component,in t2Component,in t3Component,in t4Component,in t5Component,in t6Component,in t7Component,in t8Component,in t9Component,in t10Component,in t11Component,in t12Component,in t13Component,in t14Component,in t15Component,in t16Component,in t17Component,in t18Component,in t19Component,in t20Component,in t21Component,in t22Component,in t23Component,in t24Component);
        ref var newT0 = ref archetype.Get<T0>(ref slot);
        ref var newT1 = ref archetype.Get<T1>(ref slot);
        ref var newT2 = ref archetype.Get<T2>(ref slot);
        ref var newT3 = ref archetype.Get<T3>(ref slot);
        ref var newT4 = ref archetype.Get<T4>(ref slot);
        ref var newT5 = ref archetype.Get<T5>(ref slot);
        ref var newT6 = ref archetype.Get<T6>(ref slot);
        ref var newT7 = ref archetype.Get<T7>(ref slot);
        ref var newT8 = ref archetype.Get<T8>(ref slot);
        ref var newT9 = ref archetype.Get<T9>(ref slot);
        ref var newT10 = ref archetype.Get<T10>(ref slot);
        ref var newT11 = ref archetype.Get<T11>(ref slot);
        ref var newT12 = ref archetype.Get<T12>(ref slot);
        ref var newT13 = ref archetype.Get<T13>(ref slot);
        ref var newT14 = ref archetype.Get<T14>(ref slot);
        ref var newT15 = ref archetype.Get<T15>(ref slot);
        ref var newT16 = ref archetype.Get<T16>(ref slot);
        ref var newT17 = ref archetype.Get<T17>(ref slot);
        ref var newT18 = ref archetype.Get<T18>(ref slot);
        ref var newT19 = ref archetype.Get<T19>(ref slot);
        ref var newT20 = ref archetype.Get<T20>(ref slot);
        ref var newT21 = ref archetype.Get<T21>(ref slot);
        ref var newT22 = ref archetype.Get<T22>(ref slot);
        ref var newT23 = ref archetype.Get<T23>(ref slot);
        ref var newT24 = ref archetype.Get<T24>(ref slot);
        

        OnComponentSet<T0>(entity, in oldT0, ref newT0);
        OnComponentSet<T1>(entity, in oldT1, ref newT1);
        OnComponentSet<T2>(entity, in oldT2, ref newT2);
        OnComponentSet<T3>(entity, in oldT3, ref newT3);
        OnComponentSet<T4>(entity, in oldT4, ref newT4);
        OnComponentSet<T5>(entity, in oldT5, ref newT5);
        OnComponentSet<T6>(entity, in oldT6, ref newT6);
        OnComponentSet<T7>(entity, in oldT7, ref newT7);
        OnComponentSet<T8>(entity, in oldT8, ref newT8);
        OnComponentSet<T9>(entity, in oldT9, ref newT9);
        OnComponentSet<T10>(entity, in oldT10, ref newT10);
        OnComponentSet<T11>(entity, in oldT11, ref newT11);
        OnComponentSet<T12>(entity, in oldT12, ref newT12);
        OnComponentSet<T13>(entity, in oldT13, ref newT13);
        OnComponentSet<T14>(entity, in oldT14, ref newT14);
        OnComponentSet<T15>(entity, in oldT15, ref newT15);
        OnComponentSet<T16>(entity, in oldT16, ref newT16);
        OnComponentSet<T17>(entity, in oldT17, ref newT17);
        OnComponentSet<T18>(entity, in oldT18, ref newT18);
        OnComponentSet<T19>(entity, in oldT19, ref newT19);
        OnComponentSet<T20>(entity, in oldT20, ref newT20);
        OnComponentSet<T21>(entity, in oldT21, ref newT21);
        OnComponentSet<T22>(entity, in oldT22, ref newT22);
        OnComponentSet<T23>(entity, in oldT23, ref newT23);
        OnComponentSet<T24>(entity, in oldT24, ref newT24);
        
    }
    }

