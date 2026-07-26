
using System;
using System.Runtime.CompilerServices;
using CommunityToolkit.HighPerformance;
using Arch.Core.Utils;

namespace Arch.Core;
public partial class World
{
    
    [SkipLocalsInit]
    public void Set<T0, T1>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default,in T8? t8ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            ref var t8FirstElement = ref chunk.GetFirst<T8>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                ref var t8Component = ref Unsafe.Add(ref t8FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                var oldT8 = t8Component;
                t8Component = t8ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                OnComponentSet<T8>(entity, in oldT8, ref t8Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default,in T8? t8ComponentValue = default,in T9? t9ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            ref var t8FirstElement = ref chunk.GetFirst<T8>();
            ref var t9FirstElement = ref chunk.GetFirst<T9>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                ref var t8Component = ref Unsafe.Add(ref t8FirstElement, entityIndex);
                ref var t9Component = ref Unsafe.Add(ref t9FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                var oldT8 = t8Component;
                t8Component = t8ComponentValue;
                var oldT9 = t9Component;
                t9Component = t9ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                OnComponentSet<T8>(entity, in oldT8, ref t8Component);
                OnComponentSet<T9>(entity, in oldT9, ref t9Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default,in T8? t8ComponentValue = default,in T9? t9ComponentValue = default,in T10? t10ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            ref var t8FirstElement = ref chunk.GetFirst<T8>();
            ref var t9FirstElement = ref chunk.GetFirst<T9>();
            ref var t10FirstElement = ref chunk.GetFirst<T10>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                ref var t8Component = ref Unsafe.Add(ref t8FirstElement, entityIndex);
                ref var t9Component = ref Unsafe.Add(ref t9FirstElement, entityIndex);
                ref var t10Component = ref Unsafe.Add(ref t10FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                var oldT8 = t8Component;
                t8Component = t8ComponentValue;
                var oldT9 = t9Component;
                t9Component = t9ComponentValue;
                var oldT10 = t10Component;
                t10Component = t10ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                OnComponentSet<T8>(entity, in oldT8, ref t8Component);
                OnComponentSet<T9>(entity, in oldT9, ref t9Component);
                OnComponentSet<T10>(entity, in oldT10, ref t10Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default,in T8? t8ComponentValue = default,in T9? t9ComponentValue = default,in T10? t10ComponentValue = default,in T11? t11ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            ref var t8FirstElement = ref chunk.GetFirst<T8>();
            ref var t9FirstElement = ref chunk.GetFirst<T9>();
            ref var t10FirstElement = ref chunk.GetFirst<T10>();
            ref var t11FirstElement = ref chunk.GetFirst<T11>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                ref var t8Component = ref Unsafe.Add(ref t8FirstElement, entityIndex);
                ref var t9Component = ref Unsafe.Add(ref t9FirstElement, entityIndex);
                ref var t10Component = ref Unsafe.Add(ref t10FirstElement, entityIndex);
                ref var t11Component = ref Unsafe.Add(ref t11FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                var oldT8 = t8Component;
                t8Component = t8ComponentValue;
                var oldT9 = t9Component;
                t9Component = t9ComponentValue;
                var oldT10 = t10Component;
                t10Component = t10ComponentValue;
                var oldT11 = t11Component;
                t11Component = t11ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                OnComponentSet<T8>(entity, in oldT8, ref t8Component);
                OnComponentSet<T9>(entity, in oldT9, ref t9Component);
                OnComponentSet<T10>(entity, in oldT10, ref t10Component);
                OnComponentSet<T11>(entity, in oldT11, ref t11Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default,in T8? t8ComponentValue = default,in T9? t9ComponentValue = default,in T10? t10ComponentValue = default,in T11? t11ComponentValue = default,in T12? t12ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            ref var t8FirstElement = ref chunk.GetFirst<T8>();
            ref var t9FirstElement = ref chunk.GetFirst<T9>();
            ref var t10FirstElement = ref chunk.GetFirst<T10>();
            ref var t11FirstElement = ref chunk.GetFirst<T11>();
            ref var t12FirstElement = ref chunk.GetFirst<T12>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                ref var t8Component = ref Unsafe.Add(ref t8FirstElement, entityIndex);
                ref var t9Component = ref Unsafe.Add(ref t9FirstElement, entityIndex);
                ref var t10Component = ref Unsafe.Add(ref t10FirstElement, entityIndex);
                ref var t11Component = ref Unsafe.Add(ref t11FirstElement, entityIndex);
                ref var t12Component = ref Unsafe.Add(ref t12FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                var oldT8 = t8Component;
                t8Component = t8ComponentValue;
                var oldT9 = t9Component;
                t9Component = t9ComponentValue;
                var oldT10 = t10Component;
                t10Component = t10ComponentValue;
                var oldT11 = t11Component;
                t11Component = t11ComponentValue;
                var oldT12 = t12Component;
                t12Component = t12ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                OnComponentSet<T8>(entity, in oldT8, ref t8Component);
                OnComponentSet<T9>(entity, in oldT9, ref t9Component);
                OnComponentSet<T10>(entity, in oldT10, ref t10Component);
                OnComponentSet<T11>(entity, in oldT11, ref t11Component);
                OnComponentSet<T12>(entity, in oldT12, ref t12Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default,in T8? t8ComponentValue = default,in T9? t9ComponentValue = default,in T10? t10ComponentValue = default,in T11? t11ComponentValue = default,in T12? t12ComponentValue = default,in T13? t13ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            ref var t8FirstElement = ref chunk.GetFirst<T8>();
            ref var t9FirstElement = ref chunk.GetFirst<T9>();
            ref var t10FirstElement = ref chunk.GetFirst<T10>();
            ref var t11FirstElement = ref chunk.GetFirst<T11>();
            ref var t12FirstElement = ref chunk.GetFirst<T12>();
            ref var t13FirstElement = ref chunk.GetFirst<T13>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                ref var t8Component = ref Unsafe.Add(ref t8FirstElement, entityIndex);
                ref var t9Component = ref Unsafe.Add(ref t9FirstElement, entityIndex);
                ref var t10Component = ref Unsafe.Add(ref t10FirstElement, entityIndex);
                ref var t11Component = ref Unsafe.Add(ref t11FirstElement, entityIndex);
                ref var t12Component = ref Unsafe.Add(ref t12FirstElement, entityIndex);
                ref var t13Component = ref Unsafe.Add(ref t13FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                var oldT8 = t8Component;
                t8Component = t8ComponentValue;
                var oldT9 = t9Component;
                t9Component = t9ComponentValue;
                var oldT10 = t10Component;
                t10Component = t10ComponentValue;
                var oldT11 = t11Component;
                t11Component = t11ComponentValue;
                var oldT12 = t12Component;
                t12Component = t12ComponentValue;
                var oldT13 = t13Component;
                t13Component = t13ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                OnComponentSet<T8>(entity, in oldT8, ref t8Component);
                OnComponentSet<T9>(entity, in oldT9, ref t9Component);
                OnComponentSet<T10>(entity, in oldT10, ref t10Component);
                OnComponentSet<T11>(entity, in oldT11, ref t11Component);
                OnComponentSet<T12>(entity, in oldT12, ref t12Component);
                OnComponentSet<T13>(entity, in oldT13, ref t13Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default,in T8? t8ComponentValue = default,in T9? t9ComponentValue = default,in T10? t10ComponentValue = default,in T11? t11ComponentValue = default,in T12? t12ComponentValue = default,in T13? t13ComponentValue = default,in T14? t14ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            ref var t8FirstElement = ref chunk.GetFirst<T8>();
            ref var t9FirstElement = ref chunk.GetFirst<T9>();
            ref var t10FirstElement = ref chunk.GetFirst<T10>();
            ref var t11FirstElement = ref chunk.GetFirst<T11>();
            ref var t12FirstElement = ref chunk.GetFirst<T12>();
            ref var t13FirstElement = ref chunk.GetFirst<T13>();
            ref var t14FirstElement = ref chunk.GetFirst<T14>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                ref var t8Component = ref Unsafe.Add(ref t8FirstElement, entityIndex);
                ref var t9Component = ref Unsafe.Add(ref t9FirstElement, entityIndex);
                ref var t10Component = ref Unsafe.Add(ref t10FirstElement, entityIndex);
                ref var t11Component = ref Unsafe.Add(ref t11FirstElement, entityIndex);
                ref var t12Component = ref Unsafe.Add(ref t12FirstElement, entityIndex);
                ref var t13Component = ref Unsafe.Add(ref t13FirstElement, entityIndex);
                ref var t14Component = ref Unsafe.Add(ref t14FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                var oldT8 = t8Component;
                t8Component = t8ComponentValue;
                var oldT9 = t9Component;
                t9Component = t9ComponentValue;
                var oldT10 = t10Component;
                t10Component = t10ComponentValue;
                var oldT11 = t11Component;
                t11Component = t11ComponentValue;
                var oldT12 = t12Component;
                t12Component = t12ComponentValue;
                var oldT13 = t13Component;
                t13Component = t13ComponentValue;
                var oldT14 = t14Component;
                t14Component = t14ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                OnComponentSet<T8>(entity, in oldT8, ref t8Component);
                OnComponentSet<T9>(entity, in oldT9, ref t9Component);
                OnComponentSet<T10>(entity, in oldT10, ref t10Component);
                OnComponentSet<T11>(entity, in oldT11, ref t11Component);
                OnComponentSet<T12>(entity, in oldT12, ref t12Component);
                OnComponentSet<T13>(entity, in oldT13, ref t13Component);
                OnComponentSet<T14>(entity, in oldT14, ref t14Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default,in T8? t8ComponentValue = default,in T9? t9ComponentValue = default,in T10? t10ComponentValue = default,in T11? t11ComponentValue = default,in T12? t12ComponentValue = default,in T13? t13ComponentValue = default,in T14? t14ComponentValue = default,in T15? t15ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            ref var t8FirstElement = ref chunk.GetFirst<T8>();
            ref var t9FirstElement = ref chunk.GetFirst<T9>();
            ref var t10FirstElement = ref chunk.GetFirst<T10>();
            ref var t11FirstElement = ref chunk.GetFirst<T11>();
            ref var t12FirstElement = ref chunk.GetFirst<T12>();
            ref var t13FirstElement = ref chunk.GetFirst<T13>();
            ref var t14FirstElement = ref chunk.GetFirst<T14>();
            ref var t15FirstElement = ref chunk.GetFirst<T15>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                ref var t8Component = ref Unsafe.Add(ref t8FirstElement, entityIndex);
                ref var t9Component = ref Unsafe.Add(ref t9FirstElement, entityIndex);
                ref var t10Component = ref Unsafe.Add(ref t10FirstElement, entityIndex);
                ref var t11Component = ref Unsafe.Add(ref t11FirstElement, entityIndex);
                ref var t12Component = ref Unsafe.Add(ref t12FirstElement, entityIndex);
                ref var t13Component = ref Unsafe.Add(ref t13FirstElement, entityIndex);
                ref var t14Component = ref Unsafe.Add(ref t14FirstElement, entityIndex);
                ref var t15Component = ref Unsafe.Add(ref t15FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                var oldT8 = t8Component;
                t8Component = t8ComponentValue;
                var oldT9 = t9Component;
                t9Component = t9ComponentValue;
                var oldT10 = t10Component;
                t10Component = t10ComponentValue;
                var oldT11 = t11Component;
                t11Component = t11ComponentValue;
                var oldT12 = t12Component;
                t12Component = t12ComponentValue;
                var oldT13 = t13Component;
                t13Component = t13ComponentValue;
                var oldT14 = t14Component;
                t14Component = t14ComponentValue;
                var oldT15 = t15Component;
                t15Component = t15ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                OnComponentSet<T8>(entity, in oldT8, ref t8Component);
                OnComponentSet<T9>(entity, in oldT9, ref t9Component);
                OnComponentSet<T10>(entity, in oldT10, ref t10Component);
                OnComponentSet<T11>(entity, in oldT11, ref t11Component);
                OnComponentSet<T12>(entity, in oldT12, ref t12Component);
                OnComponentSet<T13>(entity, in oldT13, ref t13Component);
                OnComponentSet<T14>(entity, in oldT14, ref t14Component);
                OnComponentSet<T15>(entity, in oldT15, ref t15Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default,in T8? t8ComponentValue = default,in T9? t9ComponentValue = default,in T10? t10ComponentValue = default,in T11? t11ComponentValue = default,in T12? t12ComponentValue = default,in T13? t13ComponentValue = default,in T14? t14ComponentValue = default,in T15? t15ComponentValue = default,in T16? t16ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            ref var t8FirstElement = ref chunk.GetFirst<T8>();
            ref var t9FirstElement = ref chunk.GetFirst<T9>();
            ref var t10FirstElement = ref chunk.GetFirst<T10>();
            ref var t11FirstElement = ref chunk.GetFirst<T11>();
            ref var t12FirstElement = ref chunk.GetFirst<T12>();
            ref var t13FirstElement = ref chunk.GetFirst<T13>();
            ref var t14FirstElement = ref chunk.GetFirst<T14>();
            ref var t15FirstElement = ref chunk.GetFirst<T15>();
            ref var t16FirstElement = ref chunk.GetFirst<T16>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                ref var t8Component = ref Unsafe.Add(ref t8FirstElement, entityIndex);
                ref var t9Component = ref Unsafe.Add(ref t9FirstElement, entityIndex);
                ref var t10Component = ref Unsafe.Add(ref t10FirstElement, entityIndex);
                ref var t11Component = ref Unsafe.Add(ref t11FirstElement, entityIndex);
                ref var t12Component = ref Unsafe.Add(ref t12FirstElement, entityIndex);
                ref var t13Component = ref Unsafe.Add(ref t13FirstElement, entityIndex);
                ref var t14Component = ref Unsafe.Add(ref t14FirstElement, entityIndex);
                ref var t15Component = ref Unsafe.Add(ref t15FirstElement, entityIndex);
                ref var t16Component = ref Unsafe.Add(ref t16FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                var oldT8 = t8Component;
                t8Component = t8ComponentValue;
                var oldT9 = t9Component;
                t9Component = t9ComponentValue;
                var oldT10 = t10Component;
                t10Component = t10ComponentValue;
                var oldT11 = t11Component;
                t11Component = t11ComponentValue;
                var oldT12 = t12Component;
                t12Component = t12ComponentValue;
                var oldT13 = t13Component;
                t13Component = t13ComponentValue;
                var oldT14 = t14Component;
                t14Component = t14ComponentValue;
                var oldT15 = t15Component;
                t15Component = t15ComponentValue;
                var oldT16 = t16Component;
                t16Component = t16ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                OnComponentSet<T8>(entity, in oldT8, ref t8Component);
                OnComponentSet<T9>(entity, in oldT9, ref t9Component);
                OnComponentSet<T10>(entity, in oldT10, ref t10Component);
                OnComponentSet<T11>(entity, in oldT11, ref t11Component);
                OnComponentSet<T12>(entity, in oldT12, ref t12Component);
                OnComponentSet<T13>(entity, in oldT13, ref t13Component);
                OnComponentSet<T14>(entity, in oldT14, ref t14Component);
                OnComponentSet<T15>(entity, in oldT15, ref t15Component);
                OnComponentSet<T16>(entity, in oldT16, ref t16Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default,in T8? t8ComponentValue = default,in T9? t9ComponentValue = default,in T10? t10ComponentValue = default,in T11? t11ComponentValue = default,in T12? t12ComponentValue = default,in T13? t13ComponentValue = default,in T14? t14ComponentValue = default,in T15? t15ComponentValue = default,in T16? t16ComponentValue = default,in T17? t17ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            ref var t8FirstElement = ref chunk.GetFirst<T8>();
            ref var t9FirstElement = ref chunk.GetFirst<T9>();
            ref var t10FirstElement = ref chunk.GetFirst<T10>();
            ref var t11FirstElement = ref chunk.GetFirst<T11>();
            ref var t12FirstElement = ref chunk.GetFirst<T12>();
            ref var t13FirstElement = ref chunk.GetFirst<T13>();
            ref var t14FirstElement = ref chunk.GetFirst<T14>();
            ref var t15FirstElement = ref chunk.GetFirst<T15>();
            ref var t16FirstElement = ref chunk.GetFirst<T16>();
            ref var t17FirstElement = ref chunk.GetFirst<T17>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                ref var t8Component = ref Unsafe.Add(ref t8FirstElement, entityIndex);
                ref var t9Component = ref Unsafe.Add(ref t9FirstElement, entityIndex);
                ref var t10Component = ref Unsafe.Add(ref t10FirstElement, entityIndex);
                ref var t11Component = ref Unsafe.Add(ref t11FirstElement, entityIndex);
                ref var t12Component = ref Unsafe.Add(ref t12FirstElement, entityIndex);
                ref var t13Component = ref Unsafe.Add(ref t13FirstElement, entityIndex);
                ref var t14Component = ref Unsafe.Add(ref t14FirstElement, entityIndex);
                ref var t15Component = ref Unsafe.Add(ref t15FirstElement, entityIndex);
                ref var t16Component = ref Unsafe.Add(ref t16FirstElement, entityIndex);
                ref var t17Component = ref Unsafe.Add(ref t17FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                var oldT8 = t8Component;
                t8Component = t8ComponentValue;
                var oldT9 = t9Component;
                t9Component = t9ComponentValue;
                var oldT10 = t10Component;
                t10Component = t10ComponentValue;
                var oldT11 = t11Component;
                t11Component = t11ComponentValue;
                var oldT12 = t12Component;
                t12Component = t12ComponentValue;
                var oldT13 = t13Component;
                t13Component = t13ComponentValue;
                var oldT14 = t14Component;
                t14Component = t14ComponentValue;
                var oldT15 = t15Component;
                t15Component = t15ComponentValue;
                var oldT16 = t16Component;
                t16Component = t16ComponentValue;
                var oldT17 = t17Component;
                t17Component = t17ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                OnComponentSet<T8>(entity, in oldT8, ref t8Component);
                OnComponentSet<T9>(entity, in oldT9, ref t9Component);
                OnComponentSet<T10>(entity, in oldT10, ref t10Component);
                OnComponentSet<T11>(entity, in oldT11, ref t11Component);
                OnComponentSet<T12>(entity, in oldT12, ref t12Component);
                OnComponentSet<T13>(entity, in oldT13, ref t13Component);
                OnComponentSet<T14>(entity, in oldT14, ref t14Component);
                OnComponentSet<T15>(entity, in oldT15, ref t15Component);
                OnComponentSet<T16>(entity, in oldT16, ref t16Component);
                OnComponentSet<T17>(entity, in oldT17, ref t17Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default,in T8? t8ComponentValue = default,in T9? t9ComponentValue = default,in T10? t10ComponentValue = default,in T11? t11ComponentValue = default,in T12? t12ComponentValue = default,in T13? t13ComponentValue = default,in T14? t14ComponentValue = default,in T15? t15ComponentValue = default,in T16? t16ComponentValue = default,in T17? t17ComponentValue = default,in T18? t18ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            ref var t8FirstElement = ref chunk.GetFirst<T8>();
            ref var t9FirstElement = ref chunk.GetFirst<T9>();
            ref var t10FirstElement = ref chunk.GetFirst<T10>();
            ref var t11FirstElement = ref chunk.GetFirst<T11>();
            ref var t12FirstElement = ref chunk.GetFirst<T12>();
            ref var t13FirstElement = ref chunk.GetFirst<T13>();
            ref var t14FirstElement = ref chunk.GetFirst<T14>();
            ref var t15FirstElement = ref chunk.GetFirst<T15>();
            ref var t16FirstElement = ref chunk.GetFirst<T16>();
            ref var t17FirstElement = ref chunk.GetFirst<T17>();
            ref var t18FirstElement = ref chunk.GetFirst<T18>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                ref var t8Component = ref Unsafe.Add(ref t8FirstElement, entityIndex);
                ref var t9Component = ref Unsafe.Add(ref t9FirstElement, entityIndex);
                ref var t10Component = ref Unsafe.Add(ref t10FirstElement, entityIndex);
                ref var t11Component = ref Unsafe.Add(ref t11FirstElement, entityIndex);
                ref var t12Component = ref Unsafe.Add(ref t12FirstElement, entityIndex);
                ref var t13Component = ref Unsafe.Add(ref t13FirstElement, entityIndex);
                ref var t14Component = ref Unsafe.Add(ref t14FirstElement, entityIndex);
                ref var t15Component = ref Unsafe.Add(ref t15FirstElement, entityIndex);
                ref var t16Component = ref Unsafe.Add(ref t16FirstElement, entityIndex);
                ref var t17Component = ref Unsafe.Add(ref t17FirstElement, entityIndex);
                ref var t18Component = ref Unsafe.Add(ref t18FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                var oldT8 = t8Component;
                t8Component = t8ComponentValue;
                var oldT9 = t9Component;
                t9Component = t9ComponentValue;
                var oldT10 = t10Component;
                t10Component = t10ComponentValue;
                var oldT11 = t11Component;
                t11Component = t11ComponentValue;
                var oldT12 = t12Component;
                t12Component = t12ComponentValue;
                var oldT13 = t13Component;
                t13Component = t13ComponentValue;
                var oldT14 = t14Component;
                t14Component = t14ComponentValue;
                var oldT15 = t15Component;
                t15Component = t15ComponentValue;
                var oldT16 = t16Component;
                t16Component = t16ComponentValue;
                var oldT17 = t17Component;
                t17Component = t17ComponentValue;
                var oldT18 = t18Component;
                t18Component = t18ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                OnComponentSet<T8>(entity, in oldT8, ref t8Component);
                OnComponentSet<T9>(entity, in oldT9, ref t9Component);
                OnComponentSet<T10>(entity, in oldT10, ref t10Component);
                OnComponentSet<T11>(entity, in oldT11, ref t11Component);
                OnComponentSet<T12>(entity, in oldT12, ref t12Component);
                OnComponentSet<T13>(entity, in oldT13, ref t13Component);
                OnComponentSet<T14>(entity, in oldT14, ref t14Component);
                OnComponentSet<T15>(entity, in oldT15, ref t15Component);
                OnComponentSet<T16>(entity, in oldT16, ref t16Component);
                OnComponentSet<T17>(entity, in oldT17, ref t17Component);
                OnComponentSet<T18>(entity, in oldT18, ref t18Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default,in T8? t8ComponentValue = default,in T9? t9ComponentValue = default,in T10? t10ComponentValue = default,in T11? t11ComponentValue = default,in T12? t12ComponentValue = default,in T13? t13ComponentValue = default,in T14? t14ComponentValue = default,in T15? t15ComponentValue = default,in T16? t16ComponentValue = default,in T17? t17ComponentValue = default,in T18? t18ComponentValue = default,in T19? t19ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            ref var t8FirstElement = ref chunk.GetFirst<T8>();
            ref var t9FirstElement = ref chunk.GetFirst<T9>();
            ref var t10FirstElement = ref chunk.GetFirst<T10>();
            ref var t11FirstElement = ref chunk.GetFirst<T11>();
            ref var t12FirstElement = ref chunk.GetFirst<T12>();
            ref var t13FirstElement = ref chunk.GetFirst<T13>();
            ref var t14FirstElement = ref chunk.GetFirst<T14>();
            ref var t15FirstElement = ref chunk.GetFirst<T15>();
            ref var t16FirstElement = ref chunk.GetFirst<T16>();
            ref var t17FirstElement = ref chunk.GetFirst<T17>();
            ref var t18FirstElement = ref chunk.GetFirst<T18>();
            ref var t19FirstElement = ref chunk.GetFirst<T19>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                ref var t8Component = ref Unsafe.Add(ref t8FirstElement, entityIndex);
                ref var t9Component = ref Unsafe.Add(ref t9FirstElement, entityIndex);
                ref var t10Component = ref Unsafe.Add(ref t10FirstElement, entityIndex);
                ref var t11Component = ref Unsafe.Add(ref t11FirstElement, entityIndex);
                ref var t12Component = ref Unsafe.Add(ref t12FirstElement, entityIndex);
                ref var t13Component = ref Unsafe.Add(ref t13FirstElement, entityIndex);
                ref var t14Component = ref Unsafe.Add(ref t14FirstElement, entityIndex);
                ref var t15Component = ref Unsafe.Add(ref t15FirstElement, entityIndex);
                ref var t16Component = ref Unsafe.Add(ref t16FirstElement, entityIndex);
                ref var t17Component = ref Unsafe.Add(ref t17FirstElement, entityIndex);
                ref var t18Component = ref Unsafe.Add(ref t18FirstElement, entityIndex);
                ref var t19Component = ref Unsafe.Add(ref t19FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                var oldT8 = t8Component;
                t8Component = t8ComponentValue;
                var oldT9 = t9Component;
                t9Component = t9ComponentValue;
                var oldT10 = t10Component;
                t10Component = t10ComponentValue;
                var oldT11 = t11Component;
                t11Component = t11ComponentValue;
                var oldT12 = t12Component;
                t12Component = t12ComponentValue;
                var oldT13 = t13Component;
                t13Component = t13ComponentValue;
                var oldT14 = t14Component;
                t14Component = t14ComponentValue;
                var oldT15 = t15Component;
                t15Component = t15ComponentValue;
                var oldT16 = t16Component;
                t16Component = t16ComponentValue;
                var oldT17 = t17Component;
                t17Component = t17ComponentValue;
                var oldT18 = t18Component;
                t18Component = t18ComponentValue;
                var oldT19 = t19Component;
                t19Component = t19ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                OnComponentSet<T8>(entity, in oldT8, ref t8Component);
                OnComponentSet<T9>(entity, in oldT9, ref t9Component);
                OnComponentSet<T10>(entity, in oldT10, ref t10Component);
                OnComponentSet<T11>(entity, in oldT11, ref t11Component);
                OnComponentSet<T12>(entity, in oldT12, ref t12Component);
                OnComponentSet<T13>(entity, in oldT13, ref t13Component);
                OnComponentSet<T14>(entity, in oldT14, ref t14Component);
                OnComponentSet<T15>(entity, in oldT15, ref t15Component);
                OnComponentSet<T16>(entity, in oldT16, ref t16Component);
                OnComponentSet<T17>(entity, in oldT17, ref t17Component);
                OnComponentSet<T18>(entity, in oldT18, ref t18Component);
                OnComponentSet<T19>(entity, in oldT19, ref t19Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default,in T8? t8ComponentValue = default,in T9? t9ComponentValue = default,in T10? t10ComponentValue = default,in T11? t11ComponentValue = default,in T12? t12ComponentValue = default,in T13? t13ComponentValue = default,in T14? t14ComponentValue = default,in T15? t15ComponentValue = default,in T16? t16ComponentValue = default,in T17? t17ComponentValue = default,in T18? t18ComponentValue = default,in T19? t19ComponentValue = default,in T20? t20ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            ref var t8FirstElement = ref chunk.GetFirst<T8>();
            ref var t9FirstElement = ref chunk.GetFirst<T9>();
            ref var t10FirstElement = ref chunk.GetFirst<T10>();
            ref var t11FirstElement = ref chunk.GetFirst<T11>();
            ref var t12FirstElement = ref chunk.GetFirst<T12>();
            ref var t13FirstElement = ref chunk.GetFirst<T13>();
            ref var t14FirstElement = ref chunk.GetFirst<T14>();
            ref var t15FirstElement = ref chunk.GetFirst<T15>();
            ref var t16FirstElement = ref chunk.GetFirst<T16>();
            ref var t17FirstElement = ref chunk.GetFirst<T17>();
            ref var t18FirstElement = ref chunk.GetFirst<T18>();
            ref var t19FirstElement = ref chunk.GetFirst<T19>();
            ref var t20FirstElement = ref chunk.GetFirst<T20>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                ref var t8Component = ref Unsafe.Add(ref t8FirstElement, entityIndex);
                ref var t9Component = ref Unsafe.Add(ref t9FirstElement, entityIndex);
                ref var t10Component = ref Unsafe.Add(ref t10FirstElement, entityIndex);
                ref var t11Component = ref Unsafe.Add(ref t11FirstElement, entityIndex);
                ref var t12Component = ref Unsafe.Add(ref t12FirstElement, entityIndex);
                ref var t13Component = ref Unsafe.Add(ref t13FirstElement, entityIndex);
                ref var t14Component = ref Unsafe.Add(ref t14FirstElement, entityIndex);
                ref var t15Component = ref Unsafe.Add(ref t15FirstElement, entityIndex);
                ref var t16Component = ref Unsafe.Add(ref t16FirstElement, entityIndex);
                ref var t17Component = ref Unsafe.Add(ref t17FirstElement, entityIndex);
                ref var t18Component = ref Unsafe.Add(ref t18FirstElement, entityIndex);
                ref var t19Component = ref Unsafe.Add(ref t19FirstElement, entityIndex);
                ref var t20Component = ref Unsafe.Add(ref t20FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                var oldT8 = t8Component;
                t8Component = t8ComponentValue;
                var oldT9 = t9Component;
                t9Component = t9ComponentValue;
                var oldT10 = t10Component;
                t10Component = t10ComponentValue;
                var oldT11 = t11Component;
                t11Component = t11ComponentValue;
                var oldT12 = t12Component;
                t12Component = t12ComponentValue;
                var oldT13 = t13Component;
                t13Component = t13ComponentValue;
                var oldT14 = t14Component;
                t14Component = t14ComponentValue;
                var oldT15 = t15Component;
                t15Component = t15ComponentValue;
                var oldT16 = t16Component;
                t16Component = t16ComponentValue;
                var oldT17 = t17Component;
                t17Component = t17ComponentValue;
                var oldT18 = t18Component;
                t18Component = t18ComponentValue;
                var oldT19 = t19Component;
                t19Component = t19ComponentValue;
                var oldT20 = t20Component;
                t20Component = t20ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                OnComponentSet<T8>(entity, in oldT8, ref t8Component);
                OnComponentSet<T9>(entity, in oldT9, ref t9Component);
                OnComponentSet<T10>(entity, in oldT10, ref t10Component);
                OnComponentSet<T11>(entity, in oldT11, ref t11Component);
                OnComponentSet<T12>(entity, in oldT12, ref t12Component);
                OnComponentSet<T13>(entity, in oldT13, ref t13Component);
                OnComponentSet<T14>(entity, in oldT14, ref t14Component);
                OnComponentSet<T15>(entity, in oldT15, ref t15Component);
                OnComponentSet<T16>(entity, in oldT16, ref t16Component);
                OnComponentSet<T17>(entity, in oldT17, ref t17Component);
                OnComponentSet<T18>(entity, in oldT18, ref t18Component);
                OnComponentSet<T19>(entity, in oldT19, ref t19Component);
                OnComponentSet<T20>(entity, in oldT20, ref t20Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default,in T8? t8ComponentValue = default,in T9? t9ComponentValue = default,in T10? t10ComponentValue = default,in T11? t11ComponentValue = default,in T12? t12ComponentValue = default,in T13? t13ComponentValue = default,in T14? t14ComponentValue = default,in T15? t15ComponentValue = default,in T16? t16ComponentValue = default,in T17? t17ComponentValue = default,in T18? t18ComponentValue = default,in T19? t19ComponentValue = default,in T20? t20ComponentValue = default,in T21? t21ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            ref var t8FirstElement = ref chunk.GetFirst<T8>();
            ref var t9FirstElement = ref chunk.GetFirst<T9>();
            ref var t10FirstElement = ref chunk.GetFirst<T10>();
            ref var t11FirstElement = ref chunk.GetFirst<T11>();
            ref var t12FirstElement = ref chunk.GetFirst<T12>();
            ref var t13FirstElement = ref chunk.GetFirst<T13>();
            ref var t14FirstElement = ref chunk.GetFirst<T14>();
            ref var t15FirstElement = ref chunk.GetFirst<T15>();
            ref var t16FirstElement = ref chunk.GetFirst<T16>();
            ref var t17FirstElement = ref chunk.GetFirst<T17>();
            ref var t18FirstElement = ref chunk.GetFirst<T18>();
            ref var t19FirstElement = ref chunk.GetFirst<T19>();
            ref var t20FirstElement = ref chunk.GetFirst<T20>();
            ref var t21FirstElement = ref chunk.GetFirst<T21>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                ref var t8Component = ref Unsafe.Add(ref t8FirstElement, entityIndex);
                ref var t9Component = ref Unsafe.Add(ref t9FirstElement, entityIndex);
                ref var t10Component = ref Unsafe.Add(ref t10FirstElement, entityIndex);
                ref var t11Component = ref Unsafe.Add(ref t11FirstElement, entityIndex);
                ref var t12Component = ref Unsafe.Add(ref t12FirstElement, entityIndex);
                ref var t13Component = ref Unsafe.Add(ref t13FirstElement, entityIndex);
                ref var t14Component = ref Unsafe.Add(ref t14FirstElement, entityIndex);
                ref var t15Component = ref Unsafe.Add(ref t15FirstElement, entityIndex);
                ref var t16Component = ref Unsafe.Add(ref t16FirstElement, entityIndex);
                ref var t17Component = ref Unsafe.Add(ref t17FirstElement, entityIndex);
                ref var t18Component = ref Unsafe.Add(ref t18FirstElement, entityIndex);
                ref var t19Component = ref Unsafe.Add(ref t19FirstElement, entityIndex);
                ref var t20Component = ref Unsafe.Add(ref t20FirstElement, entityIndex);
                ref var t21Component = ref Unsafe.Add(ref t21FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                var oldT8 = t8Component;
                t8Component = t8ComponentValue;
                var oldT9 = t9Component;
                t9Component = t9ComponentValue;
                var oldT10 = t10Component;
                t10Component = t10ComponentValue;
                var oldT11 = t11Component;
                t11Component = t11ComponentValue;
                var oldT12 = t12Component;
                t12Component = t12ComponentValue;
                var oldT13 = t13Component;
                t13Component = t13ComponentValue;
                var oldT14 = t14Component;
                t14Component = t14ComponentValue;
                var oldT15 = t15Component;
                t15Component = t15ComponentValue;
                var oldT16 = t16Component;
                t16Component = t16ComponentValue;
                var oldT17 = t17Component;
                t17Component = t17ComponentValue;
                var oldT18 = t18Component;
                t18Component = t18ComponentValue;
                var oldT19 = t19Component;
                t19Component = t19ComponentValue;
                var oldT20 = t20Component;
                t20Component = t20ComponentValue;
                var oldT21 = t21Component;
                t21Component = t21ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                OnComponentSet<T8>(entity, in oldT8, ref t8Component);
                OnComponentSet<T9>(entity, in oldT9, ref t9Component);
                OnComponentSet<T10>(entity, in oldT10, ref t10Component);
                OnComponentSet<T11>(entity, in oldT11, ref t11Component);
                OnComponentSet<T12>(entity, in oldT12, ref t12Component);
                OnComponentSet<T13>(entity, in oldT13, ref t13Component);
                OnComponentSet<T14>(entity, in oldT14, ref t14Component);
                OnComponentSet<T15>(entity, in oldT15, ref t15Component);
                OnComponentSet<T16>(entity, in oldT16, ref t16Component);
                OnComponentSet<T17>(entity, in oldT17, ref t17Component);
                OnComponentSet<T18>(entity, in oldT18, ref t18Component);
                OnComponentSet<T19>(entity, in oldT19, ref t19Component);
                OnComponentSet<T20>(entity, in oldT20, ref t20Component);
                OnComponentSet<T21>(entity, in oldT21, ref t21Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default,in T8? t8ComponentValue = default,in T9? t9ComponentValue = default,in T10? t10ComponentValue = default,in T11? t11ComponentValue = default,in T12? t12ComponentValue = default,in T13? t13ComponentValue = default,in T14? t14ComponentValue = default,in T15? t15ComponentValue = default,in T16? t16ComponentValue = default,in T17? t17ComponentValue = default,in T18? t18ComponentValue = default,in T19? t19ComponentValue = default,in T20? t20ComponentValue = default,in T21? t21ComponentValue = default,in T22? t22ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            ref var t8FirstElement = ref chunk.GetFirst<T8>();
            ref var t9FirstElement = ref chunk.GetFirst<T9>();
            ref var t10FirstElement = ref chunk.GetFirst<T10>();
            ref var t11FirstElement = ref chunk.GetFirst<T11>();
            ref var t12FirstElement = ref chunk.GetFirst<T12>();
            ref var t13FirstElement = ref chunk.GetFirst<T13>();
            ref var t14FirstElement = ref chunk.GetFirst<T14>();
            ref var t15FirstElement = ref chunk.GetFirst<T15>();
            ref var t16FirstElement = ref chunk.GetFirst<T16>();
            ref var t17FirstElement = ref chunk.GetFirst<T17>();
            ref var t18FirstElement = ref chunk.GetFirst<T18>();
            ref var t19FirstElement = ref chunk.GetFirst<T19>();
            ref var t20FirstElement = ref chunk.GetFirst<T20>();
            ref var t21FirstElement = ref chunk.GetFirst<T21>();
            ref var t22FirstElement = ref chunk.GetFirst<T22>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                ref var t8Component = ref Unsafe.Add(ref t8FirstElement, entityIndex);
                ref var t9Component = ref Unsafe.Add(ref t9FirstElement, entityIndex);
                ref var t10Component = ref Unsafe.Add(ref t10FirstElement, entityIndex);
                ref var t11Component = ref Unsafe.Add(ref t11FirstElement, entityIndex);
                ref var t12Component = ref Unsafe.Add(ref t12FirstElement, entityIndex);
                ref var t13Component = ref Unsafe.Add(ref t13FirstElement, entityIndex);
                ref var t14Component = ref Unsafe.Add(ref t14FirstElement, entityIndex);
                ref var t15Component = ref Unsafe.Add(ref t15FirstElement, entityIndex);
                ref var t16Component = ref Unsafe.Add(ref t16FirstElement, entityIndex);
                ref var t17Component = ref Unsafe.Add(ref t17FirstElement, entityIndex);
                ref var t18Component = ref Unsafe.Add(ref t18FirstElement, entityIndex);
                ref var t19Component = ref Unsafe.Add(ref t19FirstElement, entityIndex);
                ref var t20Component = ref Unsafe.Add(ref t20FirstElement, entityIndex);
                ref var t21Component = ref Unsafe.Add(ref t21FirstElement, entityIndex);
                ref var t22Component = ref Unsafe.Add(ref t22FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                var oldT8 = t8Component;
                t8Component = t8ComponentValue;
                var oldT9 = t9Component;
                t9Component = t9ComponentValue;
                var oldT10 = t10Component;
                t10Component = t10ComponentValue;
                var oldT11 = t11Component;
                t11Component = t11ComponentValue;
                var oldT12 = t12Component;
                t12Component = t12ComponentValue;
                var oldT13 = t13Component;
                t13Component = t13ComponentValue;
                var oldT14 = t14Component;
                t14Component = t14ComponentValue;
                var oldT15 = t15Component;
                t15Component = t15ComponentValue;
                var oldT16 = t16Component;
                t16Component = t16ComponentValue;
                var oldT17 = t17Component;
                t17Component = t17ComponentValue;
                var oldT18 = t18Component;
                t18Component = t18ComponentValue;
                var oldT19 = t19Component;
                t19Component = t19ComponentValue;
                var oldT20 = t20Component;
                t20Component = t20ComponentValue;
                var oldT21 = t21Component;
                t21Component = t21ComponentValue;
                var oldT22 = t22Component;
                t22Component = t22ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                OnComponentSet<T8>(entity, in oldT8, ref t8Component);
                OnComponentSet<T9>(entity, in oldT9, ref t9Component);
                OnComponentSet<T10>(entity, in oldT10, ref t10Component);
                OnComponentSet<T11>(entity, in oldT11, ref t11Component);
                OnComponentSet<T12>(entity, in oldT12, ref t12Component);
                OnComponentSet<T13>(entity, in oldT13, ref t13Component);
                OnComponentSet<T14>(entity, in oldT14, ref t14Component);
                OnComponentSet<T15>(entity, in oldT15, ref t15Component);
                OnComponentSet<T16>(entity, in oldT16, ref t16Component);
                OnComponentSet<T17>(entity, in oldT17, ref t17Component);
                OnComponentSet<T18>(entity, in oldT18, ref t18Component);
                OnComponentSet<T19>(entity, in oldT19, ref t19Component);
                OnComponentSet<T20>(entity, in oldT20, ref t20Component);
                OnComponentSet<T21>(entity, in oldT21, ref t21Component);
                OnComponentSet<T22>(entity, in oldT22, ref t22Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default,in T8? t8ComponentValue = default,in T9? t9ComponentValue = default,in T10? t10ComponentValue = default,in T11? t11ComponentValue = default,in T12? t12ComponentValue = default,in T13? t13ComponentValue = default,in T14? t14ComponentValue = default,in T15? t15ComponentValue = default,in T16? t16ComponentValue = default,in T17? t17ComponentValue = default,in T18? t18ComponentValue = default,in T19? t19ComponentValue = default,in T20? t20ComponentValue = default,in T21? t21ComponentValue = default,in T22? t22ComponentValue = default,in T23? t23ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            ref var t8FirstElement = ref chunk.GetFirst<T8>();
            ref var t9FirstElement = ref chunk.GetFirst<T9>();
            ref var t10FirstElement = ref chunk.GetFirst<T10>();
            ref var t11FirstElement = ref chunk.GetFirst<T11>();
            ref var t12FirstElement = ref chunk.GetFirst<T12>();
            ref var t13FirstElement = ref chunk.GetFirst<T13>();
            ref var t14FirstElement = ref chunk.GetFirst<T14>();
            ref var t15FirstElement = ref chunk.GetFirst<T15>();
            ref var t16FirstElement = ref chunk.GetFirst<T16>();
            ref var t17FirstElement = ref chunk.GetFirst<T17>();
            ref var t18FirstElement = ref chunk.GetFirst<T18>();
            ref var t19FirstElement = ref chunk.GetFirst<T19>();
            ref var t20FirstElement = ref chunk.GetFirst<T20>();
            ref var t21FirstElement = ref chunk.GetFirst<T21>();
            ref var t22FirstElement = ref chunk.GetFirst<T22>();
            ref var t23FirstElement = ref chunk.GetFirst<T23>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                ref var t8Component = ref Unsafe.Add(ref t8FirstElement, entityIndex);
                ref var t9Component = ref Unsafe.Add(ref t9FirstElement, entityIndex);
                ref var t10Component = ref Unsafe.Add(ref t10FirstElement, entityIndex);
                ref var t11Component = ref Unsafe.Add(ref t11FirstElement, entityIndex);
                ref var t12Component = ref Unsafe.Add(ref t12FirstElement, entityIndex);
                ref var t13Component = ref Unsafe.Add(ref t13FirstElement, entityIndex);
                ref var t14Component = ref Unsafe.Add(ref t14FirstElement, entityIndex);
                ref var t15Component = ref Unsafe.Add(ref t15FirstElement, entityIndex);
                ref var t16Component = ref Unsafe.Add(ref t16FirstElement, entityIndex);
                ref var t17Component = ref Unsafe.Add(ref t17FirstElement, entityIndex);
                ref var t18Component = ref Unsafe.Add(ref t18FirstElement, entityIndex);
                ref var t19Component = ref Unsafe.Add(ref t19FirstElement, entityIndex);
                ref var t20Component = ref Unsafe.Add(ref t20FirstElement, entityIndex);
                ref var t21Component = ref Unsafe.Add(ref t21FirstElement, entityIndex);
                ref var t22Component = ref Unsafe.Add(ref t22FirstElement, entityIndex);
                ref var t23Component = ref Unsafe.Add(ref t23FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                var oldT8 = t8Component;
                t8Component = t8ComponentValue;
                var oldT9 = t9Component;
                t9Component = t9ComponentValue;
                var oldT10 = t10Component;
                t10Component = t10ComponentValue;
                var oldT11 = t11Component;
                t11Component = t11ComponentValue;
                var oldT12 = t12Component;
                t12Component = t12ComponentValue;
                var oldT13 = t13Component;
                t13Component = t13ComponentValue;
                var oldT14 = t14Component;
                t14Component = t14ComponentValue;
                var oldT15 = t15Component;
                t15Component = t15ComponentValue;
                var oldT16 = t16Component;
                t16Component = t16ComponentValue;
                var oldT17 = t17Component;
                t17Component = t17ComponentValue;
                var oldT18 = t18Component;
                t18Component = t18ComponentValue;
                var oldT19 = t19Component;
                t19Component = t19ComponentValue;
                var oldT20 = t20Component;
                t20Component = t20ComponentValue;
                var oldT21 = t21Component;
                t21Component = t21ComponentValue;
                var oldT22 = t22Component;
                t22Component = t22ComponentValue;
                var oldT23 = t23Component;
                t23Component = t23ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                OnComponentSet<T8>(entity, in oldT8, ref t8Component);
                OnComponentSet<T9>(entity, in oldT9, ref t9Component);
                OnComponentSet<T10>(entity, in oldT10, ref t10Component);
                OnComponentSet<T11>(entity, in oldT11, ref t11Component);
                OnComponentSet<T12>(entity, in oldT12, ref t12Component);
                OnComponentSet<T13>(entity, in oldT13, ref t13Component);
                OnComponentSet<T14>(entity, in oldT14, ref t14Component);
                OnComponentSet<T15>(entity, in oldT15, ref t15Component);
                OnComponentSet<T16>(entity, in oldT16, ref t16Component);
                OnComponentSet<T17>(entity, in oldT17, ref t17Component);
                OnComponentSet<T18>(entity, in oldT18, ref t18Component);
                OnComponentSet<T19>(entity, in oldT19, ref t19Component);
                OnComponentSet<T20>(entity, in oldT20, ref t20Component);
                OnComponentSet<T21>(entity, in oldT21, ref t21Component);
                OnComponentSet<T22>(entity, in oldT22, ref t22Component);
                OnComponentSet<T23>(entity, in oldT23, ref t23Component);
                
        #endif
            }
        }
    }
    
    [SkipLocalsInit]
    public void Set<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(in QueryDescription queryDescription, in T0? t0ComponentValue = default,in T1? t1ComponentValue = default,in T2? t2ComponentValue = default,in T3? t3ComponentValue = default,in T4? t4ComponentValue = default,in T5? t5ComponentValue = default,in T6? t6ComponentValue = default,in T7? t7ComponentValue = default,in T8? t8ComponentValue = default,in T9? t9ComponentValue = default,in T10? t10ComponentValue = default,in T11? t11ComponentValue = default,in T12? t12ComponentValue = default,in T13? t13ComponentValue = default,in T14? t14ComponentValue = default,in T15? t15ComponentValue = default,in T16? t16ComponentValue = default,in T17? t17ComponentValue = default,in T18? t18ComponentValue = default,in T19? t19ComponentValue = default,in T20? t20ComponentValue = default,in T21? t21ComponentValue = default,in T22? t22ComponentValue = default,in T23? t23ComponentValue = default,in T24? t24ComponentValue = default)
    {
        var query = Query(in queryDescription);
        foreach (ref var chunk in query)
        {
            ref var t0FirstElement = ref chunk.GetFirst<T0>();
            ref var t1FirstElement = ref chunk.GetFirst<T1>();
            ref var t2FirstElement = ref chunk.GetFirst<T2>();
            ref var t3FirstElement = ref chunk.GetFirst<T3>();
            ref var t4FirstElement = ref chunk.GetFirst<T4>();
            ref var t5FirstElement = ref chunk.GetFirst<T5>();
            ref var t6FirstElement = ref chunk.GetFirst<T6>();
            ref var t7FirstElement = ref chunk.GetFirst<T7>();
            ref var t8FirstElement = ref chunk.GetFirst<T8>();
            ref var t9FirstElement = ref chunk.GetFirst<T9>();
            ref var t10FirstElement = ref chunk.GetFirst<T10>();
            ref var t11FirstElement = ref chunk.GetFirst<T11>();
            ref var t12FirstElement = ref chunk.GetFirst<T12>();
            ref var t13FirstElement = ref chunk.GetFirst<T13>();
            ref var t14FirstElement = ref chunk.GetFirst<T14>();
            ref var t15FirstElement = ref chunk.GetFirst<T15>();
            ref var t16FirstElement = ref chunk.GetFirst<T16>();
            ref var t17FirstElement = ref chunk.GetFirst<T17>();
            ref var t18FirstElement = ref chunk.GetFirst<T18>();
            ref var t19FirstElement = ref chunk.GetFirst<T19>();
            ref var t20FirstElement = ref chunk.GetFirst<T20>();
            ref var t21FirstElement = ref chunk.GetFirst<T21>();
            ref var t22FirstElement = ref chunk.GetFirst<T22>();
            ref var t23FirstElement = ref chunk.GetFirst<T23>();
            ref var t24FirstElement = ref chunk.GetFirst<T24>();
            
            foreach (var entityIndex in chunk)
            {
                ref var t0Component = ref Unsafe.Add(ref t0FirstElement, entityIndex);
                ref var t1Component = ref Unsafe.Add(ref t1FirstElement, entityIndex);
                ref var t2Component = ref Unsafe.Add(ref t2FirstElement, entityIndex);
                ref var t3Component = ref Unsafe.Add(ref t3FirstElement, entityIndex);
                ref var t4Component = ref Unsafe.Add(ref t4FirstElement, entityIndex);
                ref var t5Component = ref Unsafe.Add(ref t5FirstElement, entityIndex);
                ref var t6Component = ref Unsafe.Add(ref t6FirstElement, entityIndex);
                ref var t7Component = ref Unsafe.Add(ref t7FirstElement, entityIndex);
                ref var t8Component = ref Unsafe.Add(ref t8FirstElement, entityIndex);
                ref var t9Component = ref Unsafe.Add(ref t9FirstElement, entityIndex);
                ref var t10Component = ref Unsafe.Add(ref t10FirstElement, entityIndex);
                ref var t11Component = ref Unsafe.Add(ref t11FirstElement, entityIndex);
                ref var t12Component = ref Unsafe.Add(ref t12FirstElement, entityIndex);
                ref var t13Component = ref Unsafe.Add(ref t13FirstElement, entityIndex);
                ref var t14Component = ref Unsafe.Add(ref t14FirstElement, entityIndex);
                ref var t15Component = ref Unsafe.Add(ref t15FirstElement, entityIndex);
                ref var t16Component = ref Unsafe.Add(ref t16FirstElement, entityIndex);
                ref var t17Component = ref Unsafe.Add(ref t17FirstElement, entityIndex);
                ref var t18Component = ref Unsafe.Add(ref t18FirstElement, entityIndex);
                ref var t19Component = ref Unsafe.Add(ref t19FirstElement, entityIndex);
                ref var t20Component = ref Unsafe.Add(ref t20FirstElement, entityIndex);
                ref var t21Component = ref Unsafe.Add(ref t21FirstElement, entityIndex);
                ref var t22Component = ref Unsafe.Add(ref t22FirstElement, entityIndex);
                ref var t23Component = ref Unsafe.Add(ref t23FirstElement, entityIndex);
                ref var t24Component = ref Unsafe.Add(ref t24FirstElement, entityIndex);
                
                var oldT0 = t0Component;
                t0Component = t0ComponentValue;
                var oldT1 = t1Component;
                t1Component = t1ComponentValue;
                var oldT2 = t2Component;
                t2Component = t2ComponentValue;
                var oldT3 = t3Component;
                t3Component = t3ComponentValue;
                var oldT4 = t4Component;
                t4Component = t4ComponentValue;
                var oldT5 = t5Component;
                t5Component = t5ComponentValue;
                var oldT6 = t6Component;
                t6Component = t6ComponentValue;
                var oldT7 = t7Component;
                t7Component = t7ComponentValue;
                var oldT8 = t8Component;
                t8Component = t8ComponentValue;
                var oldT9 = t9Component;
                t9Component = t9ComponentValue;
                var oldT10 = t10Component;
                t10Component = t10ComponentValue;
                var oldT11 = t11Component;
                t11Component = t11ComponentValue;
                var oldT12 = t12Component;
                t12Component = t12ComponentValue;
                var oldT13 = t13Component;
                t13Component = t13ComponentValue;
                var oldT14 = t14Component;
                t14Component = t14ComponentValue;
                var oldT15 = t15Component;
                t15Component = t15ComponentValue;
                var oldT16 = t16Component;
                t16Component = t16ComponentValue;
                var oldT17 = t17Component;
                t17Component = t17ComponentValue;
                var oldT18 = t18Component;
                t18Component = t18ComponentValue;
                var oldT19 = t19Component;
                t19Component = t19ComponentValue;
                var oldT20 = t20Component;
                t20Component = t20ComponentValue;
                var oldT21 = t21Component;
                t21Component = t21ComponentValue;
                var oldT22 = t22Component;
                t22Component = t22ComponentValue;
                var oldT23 = t23Component;
                t23Component = t23ComponentValue;
                var oldT24 = t24Component;
                t24Component = t24ComponentValue;
                
        #if EVENTS
                var entity = chunk.Entity(entityIndex);
                OnComponentSet<T0>(entity, in oldT0, ref t0Component);
                OnComponentSet<T1>(entity, in oldT1, ref t1Component);
                OnComponentSet<T2>(entity, in oldT2, ref t2Component);
                OnComponentSet<T3>(entity, in oldT3, ref t3Component);
                OnComponentSet<T4>(entity, in oldT4, ref t4Component);
                OnComponentSet<T5>(entity, in oldT5, ref t5Component);
                OnComponentSet<T6>(entity, in oldT6, ref t6Component);
                OnComponentSet<T7>(entity, in oldT7, ref t7Component);
                OnComponentSet<T8>(entity, in oldT8, ref t8Component);
                OnComponentSet<T9>(entity, in oldT9, ref t9Component);
                OnComponentSet<T10>(entity, in oldT10, ref t10Component);
                OnComponentSet<T11>(entity, in oldT11, ref t11Component);
                OnComponentSet<T12>(entity, in oldT12, ref t12Component);
                OnComponentSet<T13>(entity, in oldT13, ref t13Component);
                OnComponentSet<T14>(entity, in oldT14, ref t14Component);
                OnComponentSet<T15>(entity, in oldT15, ref t15Component);
                OnComponentSet<T16>(entity, in oldT16, ref t16Component);
                OnComponentSet<T17>(entity, in oldT17, ref t17Component);
                OnComponentSet<T18>(entity, in oldT18, ref t18Component);
                OnComponentSet<T19>(entity, in oldT19, ref t19Component);
                OnComponentSet<T20>(entity, in oldT20, ref t20Component);
                OnComponentSet<T21>(entity, in oldT21, ref t21Component);
                OnComponentSet<T22>(entity, in oldT22, ref t22Component);
                OnComponentSet<T23>(entity, in oldT23, ref t23Component);
                OnComponentSet<T24>(entity, in oldT24, ref t24Component);
                
        #endif
            }
        }
    }
    }

